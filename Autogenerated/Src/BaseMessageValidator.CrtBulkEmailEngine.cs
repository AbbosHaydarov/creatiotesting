namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Core;

	#region Class: BaseMessageValidator

	/// <summary>
	/// Creates and manages a chain of bulk email validators.
	/// </summary>
	public abstract class BaseMessageValidator
	{
		
		#region Fields: Private

		private BaseMessageValidator _nextMessageValidator;

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Instance of the <see cref="Terrasoft.Core.UserConnection"/> type.
		/// </summary>
		protected UserConnection UserConnection { get; set; }

		/// <summary>
		/// Introduces API for Cloud Email Service.
		/// </summary>
		protected ICESApi ServiceApi { get; set; }

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected abstract bool IsAbortOnValidation { get; }

		/// <summary>
		/// Validation code
		/// </summary>
		protected abstract string ValidationCode { get; }

		/// <summary>
		/// Priority of the validator.
		/// </summary>
		public virtual int Priority => 0;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public virtual SendingType[] SendingTypesToValidate => new[] { SendingType.None };

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets bulk email info from db.
		/// </summary>
		/// <param name="bulkEmailId">Bulk email id</param>
		/// <returns>Bulk email info</returns>
		protected BulkEmail GetBulkEmailFromDB(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			var fetchBulkEmailResult = bulkEmail.FetchFromDB("Id", bulkEmailId,
				new[] {
					"Id", "Owner", "Name", "TemplateBody", "UseUtm", "StartDate", "Category", "Domains",
					"UtmSource", "UtmMedium", "UtmCampaign", "UtmTerm", "UtmContent", "TemplateSubject",
					"SenderName", "SenderEmail", "AudienceSchema", "ProviderName", "SplitTest"
				});
			if(fetchBulkEmailResult) {
				return bulkEmail;
			}
			MailingUtilities.Log.WarnFormat(
				"[CESMaillingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {0} fails.", bulkEmailId);
			throw new Exception(
				$"[CESMaillingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {bulkEmailId} fails.");
		}

		/// <summary>
		/// Creates a localizable validation message.
		/// </summary>
		/// <param name="lczName">Name of validation error</param>
		/// <returns>Localizable validation message</returns>
		protected string GetLczStringValue(string lczName) {
			var localizableStringName = $"LocalizableStrings.{lczName}.Value";
			var localizableString = new LocalizableString(UserConnection.Workspace.ResourceStorage,
				"CESMailingProvider", localizableStringName);
			var value = localizableString.Value ??
				localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			return value;
		}

		/// <summary>
		/// Validates bulk email message.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected abstract string Validate(BulkEmailContext emailContext);

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected virtual MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			return new MailingValidationResult { 
				ValidationCode = string.Empty, 
				ValidationMessage = string.Empty 
			};
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Sets next bulk email validator in the chain.
		/// </summary>
		/// <param name="handler">Next validator</param>
		/// <returns>Next validator</returns>
		public BaseMessageValidator SetNext(BaseMessageValidator handler) {
			_nextMessageValidator = handler;
			return handler;
		}

		/// <summary>
		/// Manages a chain of bulk email validators.
		/// </summary>
		/// <param name="emailContext">Collection of bulk emails infos</param>
		/// <returns>Collection of validation messages</returns>
		[Obsolete("Will be removed after 8.1.3")]
		public virtual IEnumerable<string> HandleValidation(BulkEmailContext emailContext) {
			UserConnection = UserConnection ?? emailContext.UserConnection;
			ServiceApi = ServiceApi ?? emailContext.ServiceApi;
			var validationResult = new List<string>();
			var validationMessage = Validate(emailContext);
			if (!validationMessage.IsNullOrEmpty()) {
				validationResult.Add(validationMessage);
				if (IsAbortOnValidation) {
					return validationResult;
				}
			}
			if (_nextMessageValidator == null) {
				return validationResult;
			}
			var nextValidationMessage = _nextMessageValidator.HandleValidation(emailContext);
			return !nextValidationMessage.IsNullOrEmpty()
				? validationResult.Union(nextValidationMessage)
				: validationResult;
		}

		/// <summary>
		/// Manages a chain of bulk email validators.
		/// </summary>
		/// <param name="emailContext">Collection of bulk emails infos</param>
		/// <returns>Collection of models, which contains validation information</returns>
		public virtual IEnumerable<MailingValidationResult> HandleValidationInternal(BulkEmailContext emailContext) {
			UserConnection = UserConnection ?? emailContext.UserConnection;
			ServiceApi = ServiceApi ?? emailContext.ServiceApi;
			var validationResults = new List<MailingValidationResult>();
			var validationResult = ValidateInternal(emailContext);
			if (!validationResult.ValidationMessage.IsNullOrEmpty() && 
				!validationResult.ValidationCode.IsNullOrEmpty()){
				validationResults.Add(validationResult);
				if (IsAbortOnValidation) {
					return validationResults;
				}
			}
			if (_nextMessageValidator == null) {
				return validationResults;
			}
			var nextValidationResults = _nextMessageValidator.HandleValidationInternal(emailContext);
			return !nextValidationResults.IsNullOrEmpty()
				? validationResults.Union(nextValidationResults)
				: validationResults;
		}


		#endregion

	}

	#endregion

}

