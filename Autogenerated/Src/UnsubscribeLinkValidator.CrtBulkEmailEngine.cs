namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: UnsubscribeLinkValidator

	/// <summary>
	/// Represents unsubscribe link validator.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "UnsubscribeLinkValidator")]
	public class UnsubscribeLinkValidator : BaseMessageValidator
	{

		#region Fields: Private

		private ILog _logger;

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected override bool IsAbortOnValidation => true;

		/// <summary>
		/// Validation code
		/// </summary>
		protected override string ValidationCode => "UnsubscribeLink";

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 50;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail, SendingType.TriggerEmail, SendingType.TestEmail };

		/// <summary>
		/// Gets or sets the logger.
		/// </summary>
		public ILog Logger {
			get => _logger ?? (_logger = LogManager.GetLogger("CheckUnsubscribeInTemplate"));
			set => _logger = value;
		}

		#endregion

		#region Methods: Private

		private static bool CheckIfExists(List<string> unsubscribeMacrosValues, List<string> replicas) {
			var replicasSet = new HashSet<string>(replicas);
			var unsubscribeSet = new HashSet<string>(unsubscribeMacrosValues);
			foreach (string replica in replicasSet) {
				bool replicaHasUnsubscribe = unsubscribeSet.Any(unsubscribeValue => replica.Contains(unsubscribeValue));
				if (!replicaHasUnsubscribe) {
					return false;
				}
			}
			return true;
		}

		private List<string> GetUnsubscribeMacrosValues() {
			Dictionary<Guid, string> cultures = CommonUtilities.GetCulturesNames(UserConnection);
			var macroses = new List<string>();
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmailTemplateMacros");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			EntitySchemaQueryColumn nameColumn = esq.AddColumn("Name");
			EntitySchemaQueryColumn parentNameColumn = esq.AddColumn("Parent.Name");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id",
				MarketingConsts.EmailTemplateMacrosUnsubscribeUrlId));
			foreach (KeyValuePair<Guid, string> cultureInfo in cultures) {
				esq.SetLocalizationCultureId(cultureInfo.Key);
				EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
				Entity entity = entityCollection.FirstOrDefault();
				if (entity == null) {
					continue;
				}
				var name = entity.GetTypedColumnValue<string>(nameColumn.Name);
				var parentName = entity.GetTypedColumnValue<string>(parentNameColumn.Name);
				macroses.Add($"[#{parentName}.{name}#]");
			}
			return macroses;
		}

		private List<string> GetDcReplicas(Guid templateId) {
			Guid dcTemplateId = GetDcTemplateId(templateId);
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "DCReplica") {
				PrimaryQueryColumn = {
					IsAlwaysSelect = true
				}
			};
			esq.AddColumn("Content");
			esq.AddColumn("DCTemplate");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "DCTemplate",
				dcTemplateId));
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			return entityCollection.Select(entity => entity.GetTypedColumnValue<string>("Content")
			).ToList();
		}

		private Guid GetDcTemplateId(Guid templateId) {
			var dcTemplateEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "DCTemplate") {
				PrimaryQueryColumn = {
					IsAlwaysSelect = true
				}
			};
			dcTemplateEsq.AddColumn("RecordId");
			dcTemplateEsq.Filters.Add(dcTemplateEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "RecordId",
				templateId));
			var dcTemplate = dcTemplateEsq.GetEntityCollection(UserConnection).FirstOrDefault();
			if (dcTemplate == null) {
				return Guid.Empty;
			}
			var dcTemplateId = dcTemplate.GetTypedColumnValue<Guid>("Id");
			return dcTemplateId;
		}

		private bool ValidateUnsubscribeLink(Guid templateId) {
			try {
				var replicas = GetDcReplicas(templateId);
				if (replicas.Capacity == 0) {
					return false;
				}
				List<string> unsubscribeMacrosValues = GetUnsubscribeMacrosValues();
				return CheckIfExists(unsubscribeMacrosValues, replicas);
			} catch (Exception e) {
				Logger.Error($"Error while checking unsubscribe link in template. {e}");
				return false;
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates bulk email message.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			bool isValid = ValidateUnsubscribeLink(emailContext.MessageIds[0]);
			return isValid ? string.Empty : GetLczStringValue("UnsubscribeLinkValidationError");
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			var mailingValidationResult = new MailingValidationResult();
			string validationResult = Validate(emailContext);
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

