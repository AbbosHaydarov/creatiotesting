namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Core.Factories;

	#region Class: SenderValidator
	/// <summary>
	/// Manages validation of bulk email messages senders.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "SenderValidator")]
	public class SenderValidator : BaseMessageValidator
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
		protected override string ValidationCode => MailingValidationCodes.Sender;

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 80;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail, SendingType.TriggerEmail, SendingType.TestEmail };

		#endregion

		#region Methods: Private

		private string GetDomainValidationExceptionMessage(IEnumerable<string> domains, string lczPattern) {
			var emails = string.Join(", ", domains);
			var message = domains.Count() == 1 ? GetLczStringValue(string.Format(lczPattern, "Singular"))
				: GetLczStringValue(string.Format(lczPattern, "Plural"));
			return string.Format(message, emails);
		}

		private IEnumerable<string> GetUniqueDomainsFromEmails(IEnumerable<string> emailsList) {
			return emailsList.Select(email => new Regex("^.*@").Replace(email, "")).Distinct();
		}

		private List<SenderValidationInfo> ValidateSendForEachProvider(
			IEnumerable<ProviderSenderEmail> senderEmailsWithProviders) {
			var validationResults = new List<SenderValidationInfo>();
			foreach (var providerSenderEmails in senderEmailsWithProviders) {
				var request = new ValidateSenderRequest {
					EmailList = providerSenderEmails.SenderEmails,
					ApiKey = ServiceApi.ApiKey,
					ProviderName = providerSenderEmails.ProviderName
				};
				var validationResult =
					Utilities.RetryOnFailure(() => ServiceApi.ValidateSenderForProvider(request), 20, 10);
				validationResults.Add(validationResult);
			}
			return validationResults;
		}

		private string ValidateSender(BulkEmailContext emailContext) {
			var exceptionMessage = string.Empty;
			var bulkEmailQueryHelper = new BulkEmailQueryHelper();
			var senderEmailsWithProviders = bulkEmailQueryHelper.GetSenderEmailsWithProviderNames(emailContext.MessageIds,
				UserConnection);
			var valuableSenderEmails = senderEmailsWithProviders.Select(x => new ProviderSenderEmail {
				ProviderName = x.ProviderName,
				SenderEmails = x.SenderEmails.Where(y => !Regex.IsMatch(y, MacroRegexPattern)).ToList()
			}).Where(z => z.SenderEmails.Any());
			if (!valuableSenderEmails.Any()) {
				return exceptionMessage;
			}
			var resultList = ValidateSendForEachProvider(valuableSenderEmails);
			if (!resultList.Any(x => x.ValidatedEmailsList.Any())) {
				return exceptionMessage;
			}
			var domains = GetUniqueDomainsFromEmails(resultList.SelectMany(x => x.ValidatedEmailsList));
			exceptionMessage += GetDomainValidationExceptionMessage(domains, "SenderEmailValidation{0}Warning");
			exceptionMessage += '\n';
			return exceptionMessage;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates sender in bulk email messages.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			return ValidateSender(emailContext);
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			var mailingValidationResult = new MailingValidationResult();
			var validationResult = ValidateSender(emailContext);
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
