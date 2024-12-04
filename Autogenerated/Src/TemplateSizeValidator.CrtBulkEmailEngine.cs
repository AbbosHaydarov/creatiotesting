namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Configuration.Utils;
	using Terrasoft.Core.Factories;

	#region Class: TemplateSizeValidator

	/// <summary>
	/// Manages validation of messages template size.
	/// </summary>
	[DefaultBinding(typeof(BaseMessageValidator), Name = "TemplateSizeValidator")]
	public class TemplateSizeValidator : BaseMessageValidator
	{

		#region Constants: Private

		private const int MailingMaxTemplateSizeInBytes = 5242880;

		#endregion

		#region Fields: Private

		private BulkEmailMacroParser _bulkEmailMacroParser;

		private CESMailingTemplateFactory _templateFactory;

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Gets the possibility to interrupt chain of validators.
		/// </summary>
		protected override bool IsAbortOnValidation => false;

		/// <summary>
		/// Gets or sets name of linked entity schema.
		/// </summary>
		protected string LinkedEntitySchemaName { get; set; }

		/// <summary>
		/// Validation code
		/// </summary>
		protected override string ValidationCode => MailingValidationCodes.TemplateSize;

		/// <summary>
		/// Gets the priority of the validator.
		/// </summary>
		public override int Priority => 20;

		/// <summary>
		/// Types of email to validate.
		/// </summary>
		public override SendingType[] SendingTypesToValidate => new[] { SendingType.BulkEmail, SendingType.TriggerEmail, SendingType.TestEmail };

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets the template factory.
		/// </summary>
		public CESMailingTemplateFactory TemplateFactory =>
			_templateFactory ?? (_templateFactory = new CESMailingTemplateFactory());

		/// <summary>
		/// Gets or sets the bulk email macro parser.
		/// </summary>
		public BulkEmailMacroParser BulkEmailMacroParser {
			get => _bulkEmailMacroParser ?? (_bulkEmailMacroParser = GetMacroParser());
			set => _bulkEmailMacroParser = value;
		}

		#endregion

		#region Methods: Private

		private double ConvertBytesToMegabytes(int sizeInBytes) {
			return Math.Round(sizeInBytes / 1024f / 1024f, 2);
		}

		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = UserConnection;
			var bulkEmailMacroParser = ClassFactory.Get<BulkEmailMacroParser>(
				new ConstructorArgument("macrosHelper", macrosHelper),
				new ConstructorArgument("linkedEntitySchemaName", LinkedEntitySchemaName));
			return bulkEmailMacroParser;
		}

		private Dictionary<string, int> GetOversizedTemplates(BulkEmail bulkEmail) {
			var templateCollection = new List<IMailingTemplate>();
			var invalidTemplateNames = new Dictionary<string, int>();
			if (!bulkEmail.AudienceSchemaId.IsEmpty()) {
				InitLinkedEntitySchemaName(bulkEmail.AudienceSchemaId);
			}
			IEnumerable<IMailingTemplate> templateReplicas =
				TemplateFactory.CreateDCTemplates(UserConnection, bulkEmail, BulkEmailMacroParser);
			if (templateReplicas == null) {
				return null;
			}
			templateCollection.AddRange(templateReplicas);
			foreach (IMailingTemplate mailingTemplate in templateCollection) {
				if (ValidateTemplateSize(mailingTemplate, out int templateSize)) {
					continue;
				}
				string templateName = string.Concat("\"", bulkEmail.Name, "\"");
				invalidTemplateNames.Add(templateName, templateSize);
				return invalidTemplateNames;
			}
			return invalidTemplateNames;
		}

		private int GetTemplateSize(IMailingTemplate template) {
			List<image> images = template.InlineImages.ToCESImage().ToList();
			int templateSize = CESUtilities.GetTemplateSize(template.Content, images);
			return templateSize;
		}

		private string GetTemplateValidationExceptionMessage(string lczPattern, Dictionary<string, int> bulkEmails) {
			string emails = string.Join(", ", bulkEmails.Keys);
			string message, result;
			double maxSizeInMegabytes = ConvertBytesToMegabytes(MailingMaxTemplateSizeInBytes);
			if (bulkEmails.Count == 1) {
				double templateSizeInMegabytes = ConvertBytesToMegabytes(bulkEmails.Values.FirstOrDefault());
				message = GetLczStringValue(string.Format(lczPattern, "Singular"));
				result = string.Format(message, templateSizeInMegabytes, maxSizeInMegabytes);
			} else {
				message = GetLczStringValue(string.Format(lczPattern, "Plural"));
				result = string.Format(message, emails, maxSizeInMegabytes);
			}
			return result;
		}

		private void InitLinkedEntitySchemaName(Guid audienceSchemaId) {
			var audienceSchema = new BulkEmailAudienceSchema(UserConnection);
			audienceSchema.FetchFromDB("Id", audienceSchemaId, new[] { "EntityObject" });
			LinkedEntitySchemaName = UserConnection.EntitySchemaManager
				.GetInstanceByUId(audienceSchema.EntityObjectId).Name;
		}

		private string ValidateTemplateSize(BulkEmailContext emailContext) {
			var result = string.Empty;
			var invalidTemplates = new Dictionary<string, int>();
			foreach(var messageId in emailContext.MessageIds) {
				var bulkEmail = GetBulkEmailFromDB(messageId);
				var oversizedTemplates = GetOversizedTemplates(bulkEmail);
				if(oversizedTemplates == null) {
					result += string.Format(GetLczStringValue("TemplateSavedValidationError"),
						"\"" + bulkEmail.Name + "\"");
					result += '\n';
				} else {
					invalidTemplates.AddRange(oversizedTemplates);
				}
			}
			if(invalidTemplates.Any()) {
				result += GetTemplateValidationExceptionMessage("TemplateSizeValidation{0}Warning", invalidTemplates);
			}
			return result;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Validates template size of bulk email message.
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Validation message if not succeed.</returns>
		protected override string Validate(BulkEmailContext emailContext) {
			return ValidateTemplateSize(emailContext);
		}

		/// <summary>
		/// Validates bulk email message
		/// </summary>
		/// <param name="emailContext">Dto with necessary bulk email info</param>
		/// <returns>Model, which contains information about validation</returns>
		protected override MailingValidationResult ValidateInternal(BulkEmailContext emailContext) {
			var mailingValidationResult = new MailingValidationResult();
			var validationResult = ValidateTemplateSize(emailContext);
			if (!string.IsNullOrEmpty(validationResult)) {
				mailingValidationResult.ValidationMessage = validationResult;
				mailingValidationResult.ValidationCode = ValidationCode;
			}
			return mailingValidationResult;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validates the size of the template.
		/// </summary>
		/// <param name="template">The template.</param>
		/// <param name="templateSize">Result size of the template.</param>
		/// <returns></returns>
		public bool ValidateTemplateSize(IMailingTemplate template, out int templateSize) {
			templateSize = GetTemplateSize(template);
			return templateSize <= MailingMaxTemplateSizeInBytes;
		}

		#endregion

	}

	#endregion

}

