namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;


	#region Class: TemplateExistenceValidator
	/// <summary>
	/// Manages validation of messages template existence.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "TemplateExistenceValidator")]
	public class TemplateExistenceValidator : BaseMessageValidator
	{

		#region Properties: Protected

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected override bool IsAbortOnValidation => true;

		/// <summary>
		/// Validation code
		/// </summary>
		protected override string ValidationCode => MailingValidationCodes.TemplateExistence;

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 10;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail, SendingType.TriggerEmail, SendingType.TestEmail };

		#endregion

		#region Methods: Private

		private bool IsDcTemplateExistsForBulkEmailId(Guid bulkEmailId) {
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(nameof(DCTemplate));
			Entity entity = entitySchema.CreateEntity(UserConnection);
			return entity.FetchFromDB("RecordId", bulkEmailId);
		}

		private string ValidateTemplateExistence(Guid bulkEmailId) {
			if (bulkEmailId == Guid.Empty) {
				return GetLczStringValue("TemplateExistenceValidationError");
			}
			bool isExists = IsDcTemplateExistsForBulkEmailId(bulkEmailId);
			return isExists ? string.Empty : GetLczStringValue("TemplateExistenceValidationError");
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates bulk email message.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			return ValidateTemplateExistence(emailContext.MessageIds[0]);
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			var mailingValidationResult = new MailingValidationResult();
			string validationResult = ValidateTemplateExistence(emailContext.MessageIds.FirstOrDefault());
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

