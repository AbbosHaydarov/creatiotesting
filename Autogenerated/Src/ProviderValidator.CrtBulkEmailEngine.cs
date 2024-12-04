namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Core.Factories;

	#region Class: ProviderValidator
	/// <summary>
	/// Manages validation of bulk email messages providers on availability.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "ProviderValidator")]
	public class ProviderValidator : BaseMessageValidator
	{

		#region Properties: Protected

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected override bool IsAbortOnValidation => true;

		/// <summary>
		/// Validation code
		/// </summary>
		protected override string ValidationCode => MailingValidationCodes.Provider;

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 90;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail, SendingType.TriggerEmail, SendingType.TestEmail };

		#endregion

		#region Methods: Private

		private string GetBulkSplitTestProviderErrorMessage(IEnumerable<string> notConnectedProviders) {
			string notConnectedProviderNames = string.Join(", ", notConnectedProviders);
			string errorOriginMessage = GetLczStringValue("NotConnectedProviderSplitBulkEmailMessage");
			return string.Format(errorOriginMessage, notConnectedProviderNames);
		}

		private string GetTriggerErrorMessage(IEnumerable<BulkEmail> emailWithNotConnectedProviders) {
			IEnumerable<string> providerNamesToBeConnected =
				emailWithNotConnectedProviders.Select(email => email.ProviderName);
			string providersToBeConnected = string.Join(", ", providerNamesToBeConnected);
			string notConnectedProviderMessage = GetLczStringValue("NotConnectedProviderTriggerEmailMessage");
			string message = string.Format(notConnectedProviderMessage, providersToBeConnected);
			return message;
		}

		private bool IsBulkEmailFromSplitTest(BulkEmail emailWithNotConnectedProvider, IEnumerable<Guid> bulkEmailIds) {
			bool isSplitTest = !emailWithNotConnectedProvider.SplitTestId.Equals(Guid.Empty) &&
				bulkEmailIds.Count() > 1;
			return isSplitTest;
		}

		private string ValidateProvider(BulkEmailContext emailContext) {
			IEnumerable<string> availableProviders = ServiceApi.GetAvailableProviders().AvailableProviders
				.Where(providerInfo => providerInfo.IsConnected).Select(providerInfo => providerInfo.ProviderName);
			IEnumerable<BulkEmail> emails = emailContext.MessageIds.Select(GetBulkEmailFromDB)
				.Where(email => email.ProviderName.IsNotNullOrEmpty());
			List<BulkEmail> emailsWithNotConnectedProviders = emails
				.Where(email => !availableProviders.Contains(email.ProviderName)).ToList();
			if (emailsWithNotConnectedProviders.IsEmpty()) {
				return string.Empty;
			}
			BulkEmail emailWithNotConnectedProvider = emailsWithNotConnectedProviders[0];
			if (emailWithNotConnectedProvider.CategoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId) {
				return GetTriggerErrorMessage(emailsWithNotConnectedProviders);
			}
			IEnumerable<string> notConnectedProviders =
				emailsWithNotConnectedProviders.Select(e => e.ProviderName).Distinct();
			return IsBulkEmailFromSplitTest(emailWithNotConnectedProvider, emailContext.MessageIds)
				? GetBulkSplitTestProviderErrorMessage(notConnectedProviders)
				: GetLczStringValue("NotConnectedProviderBulkEmailMessage");
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates providers in bulk email messages on availability.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			return ValidateProvider(emailContext);
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext){
			var mailingValidationResult = new MailingValidationResult();
			var validationResult = ValidateProvider(emailContext);
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

