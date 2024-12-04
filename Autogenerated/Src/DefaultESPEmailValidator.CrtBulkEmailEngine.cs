namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Core.Factories;

	#region Class: DefaultESPValidator
	/// <summary>
	/// Manages validation of bulk email messages default esp email.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "DefaultESPValidator")]
	public class DefaultESPEmailValidator : BaseMessageValidator
	{

		#region Constants: Private

		private const string MacroRegexPattern = "^(\\[\\#.+\\#\\])$";

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected override bool IsAbortOnValidation => false;

		/// <summary>
		/// Validation code
		/// </summary>
		protected override string ValidationCode => MailingValidationCodes.DefaultESPEmail;

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 70;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail, SendingType.TriggerEmail, SendingType.TestEmail };

		#endregion

		#region Methods: Private

		private string ValidateDefaultSenderByMacro(IEnumerable<string> emailProviders) {
			var defaultEspEmail =
				Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "DefaultESPEmail") as string;
			if (string.IsNullOrEmpty(defaultEspEmail)) {
				var message = GetLczStringValue("SenderEmailValidationDefaultESPEmailEmpty");
				return message;
			}
			var resultList = new List<SenderValidationInfo>();
			var request = new ValidateSenderRequest {
				ApiKey = ServiceApi.ApiKey
			};
			foreach (string provider in emailProviders) {
				request.EmailList = new[] { defaultEspEmail };
				request.ProviderName = provider;
				var validationResult = ServiceApi.ValidateSenderForProvider(request);
				resultList.Add(validationResult);
			}
			if (resultList.Any(x => x.ValidatedEmailsList.Any())) {
				var messageTemplate = GetLczStringValue("SenderEmailValidationDefaultESPEmailNotApproved");
				var message = string.Format(messageTemplate, defaultEspEmail);
				return message;
			}
			if (resultList.Any(x => x.WrongEmailsList.Any())) {
				var messageTemplate = GetLczStringValue("SenderEmailValidationDefaultESPEmailWrong");
				var message = string.Format(messageTemplate, defaultEspEmail);
				return message;
			}
			return string.Empty;
		}

		private string ValidateDefaultSender(BulkEmailContext emailContext) {
			var bulkEmailQueryHelper = new BulkEmailQueryHelper();
			var senderEmailsWithProviders = bulkEmailQueryHelper.GetSenderEmailsWithProviderNames(emailContext.MessageIds,
				UserConnection);
			var hasMacrosesInSender = senderEmailsWithProviders.Any(x => x.SenderEmails.Any(y => Regex.IsMatch(y, MacroRegexPattern)));
			if (hasMacrosesInSender) {
				var message =
					ValidateDefaultSenderByMacro(senderEmailsWithProviders.Select(x => x.ProviderName).Distinct());
				if (!string.IsNullOrEmpty(message)) {
					return message;
				}
			}
			return null;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates default sender in bulk email messages.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			return ValidateDefaultSender(emailContext);
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			var mailingValidationResult = new MailingValidationResult();
			var validationResult = ValidateDefaultSender(emailContext);
			if (!string.IsNullOrEmpty(validationResult)) {
				mailingValidationResult.ValidationMessage = validationResult;
				mailingValidationResult.ValidationCode = ValidationCode;
			}
			return mailingValidationResult;
		}

		#endregion

	}

	#endregion

}
