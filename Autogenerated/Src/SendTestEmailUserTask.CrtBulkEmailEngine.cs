namespace Terrasoft.Core.Process.Configuration
{
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core.Process;
	using Terrasoft.Configuration;
	using Terrasoft.Core.Factories;

	#region Class: SendTestEmailUserTask

	/// <exclude/>
	public partial class SendTestEmailUserTask
	{
		
		#region Fields: Private

		private IExtendedMessageValidator _mailingProvider;

		#endregion

		#region Properties: Public

		public IExtendedMessageValidator MailingProvider {
			get =>
				_mailingProvider ?? ClassFactory.Get<IMailingProviderBuilder>()?.Build() as IExtendedMessageValidator;
			set => _mailingProvider = value;
		}

		#endregion

		#region Methods: Private

		private TemplateExistenceValidator CreateChainOfBulkEmailValidators() {
			var templateExistenceValidator = new TemplateExistenceValidator();
			templateExistenceValidator.SetNext(new HeadersValidator());
			return templateExistenceValidator;
		}

		private string GetValidationCodes(IEnumerable<string> validationResults) {
			return validationResults == null ? string.Empty : string.Join(",", validationResults);
		}

		private MailingValidationResponse ValidateMessageExtended() {
			var validationRequest = new ValidationRequest {
				MessageIds = new[] { CrtBulkEmailIdentifier },
				SendingType = SendingType.TestEmail
			};
			return MailingProvider.ValidateMessageExtended(validationRequest);
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			IsSuccess = false;
			ValidationCodes = string.Empty;
			if (!MailingProvider.PingProvider()) {
				ValidationCodes = "Ping";
				return true;
			}
			MailingValidationResponse validationResult = ValidateMessageExtended();
			ValidationCodes =
				GetValidationCodes(validationResult.MailingValidationResults.Select(x => x.ValidationCode));
			if (!validationResult.Success) {
				return true;
			}
			IsSuccess = MailingProvider.SendTestMessage(CrtBulkEmailIdentifier, ContactToTestPersonalizations, SendTestEmailTo);
			ValidationCodes = IsSuccess ? string.Empty : "DefaultEmailValidation";
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		#endregion

	}

	#endregion

}

