namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: HeadersValidator
	/// <summary>
	/// Manages validation of message headers.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "HeadersValidator")]
	public class HeadersValidator : BaseMessageValidator
	{

		#region Properties: Protected

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected override bool IsAbortOnValidation => true;

		/// <summary>
		/// Validation code
		/// </summary>
		protected override string ValidationCode => MailingValidationCodes.Headers;

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 40;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail, SendingType.TriggerEmail, SendingType.TestEmail };

		#endregion

		#region Methods: Private

		private IEnumerable<string> GetBulkEmailHeaders(Guid bulkEmailId) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, nameof(BulkEmail));
			EntitySchemaQueryColumn subjectColumn = esq.AddColumn("TemplateSubject");
			EntitySchemaQueryColumn senderEmailColumn = esq.AddColumn("SenderEmail");
			EntitySchemaQueryColumn senderNameColumn = esq.AddColumn("SenderName");
			Entity entityItem = esq.GetEntity(UserConnection, bulkEmailId);
			var senderEmail = entityItem?.GetTypedColumnValue<string>(senderEmailColumn.Name);
			var subject = entityItem?.GetTypedColumnValue<string>(subjectColumn.Name);
			var senderName = entityItem?.GetTypedColumnValue<string>(senderNameColumn.Name);
			return new[] { senderEmail, senderName, subject };
		}

		private string ValidateBulkEmailHeaders(Guid bulkEmailId) {
			if (bulkEmailId == Guid.Empty) {
				return GetLczStringValue("HeadersValidationError");
			}
			IEnumerable<string> headers = GetBulkEmailHeaders(bulkEmailId);
			bool allHeadersAreFilled = headers.All(x => !string.IsNullOrWhiteSpace(x));
			return allHeadersAreFilled ? string.Empty : GetLczStringValue("HeadersValidationError");
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates bulk email message.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			return ValidateBulkEmailHeaders(emailContext.MessageIds[0]);
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			var mailingValidationResult = new MailingValidationResult();
			string validationResult = ValidateBulkEmailHeaders(emailContext.MessageIds.FirstOrDefault());
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

