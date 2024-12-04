namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: AudienceSizeValidator
	/// <summary>
	/// Manages validation of message audience size.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "AudienceSizeValidator")]
	public class AudienceSizeValidator : BaseMessageValidator
	{

		#region Properties: Protected

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected override bool IsAbortOnValidation => true;

		/// <summary>
		/// Validation code
		/// </summary>
		protected override string ValidationCode => MailingValidationCodes.AudienceSize;

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 30;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail };

		#endregion

		#region Methods: Private

		private int GetAudienceSize(Guid bulkEmailId) {
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "VwBulkEmailAudience");
			EntitySchemaQueryColumn countColumn =
				entitySchemaQuery.AddColumn(
					entitySchemaQuery.CreateAggregationFunction(AggregationTypeStrict.Count, "Id"));
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, "BulkEmail", bulkEmailId));
			Entity countEntity = entitySchemaQuery.GetEntityCollection(UserConnection).FirstOrDefault();
			var audienceSize = countEntity?.GetTypedColumnValue<int>(countColumn.Name);
			return audienceSize ?? default;
		}

		private string ValidateAudienceSize(Guid bulkEmailId) {
			if (bulkEmailId == Guid.Empty) {
				return GetLczStringValue("AudienceSizeValidationError");
			}
			int audienceSize = GetAudienceSize(bulkEmailId);
			bool isAudienceNotEmpty = audienceSize > 0;
			return isAudienceNotEmpty ? string.Empty : GetLczStringValue("AudienceSizeValidationError");
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates bulk email message.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			return ValidateAudienceSize(emailContext.MessageIds[0]);
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			var mailingValidationResult = new MailingValidationResult();
			string validationResult = ValidateAudienceSize(emailContext.MessageIds.FirstOrDefault());
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

