namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Process;

	#region Class: CampaignWebPageElement

	/// <summary>
	/// Web page schema element in campaign.
	/// </summary>
	[DesignModeProperty(Name = "WebPageTargetEntityId",
		UsageType = DesignModeUsageType.NotVisible, MetaPropertyName = WebPageTargetEntityPropertyName)]
	[DesignModeProperty(Name = "WebPageUrlColumn",
		UsageType = DesignModeUsageType.NotVisible, MetaPropertyName = WebPageUrlColumnPropertyName)]
	[DesignModeProperty(Name = "WebPageUrl",
		UsageType = DesignModeUsageType.NotVisible, MetaPropertyName = WebPageUrlPropertyName)]
	public class CampaignWebPageElement : CampaignSchemaElement
	{

		#region Constants: Private

		private const string WebPageTargetEntityPropertyName = "WebPageTargetEntityId";
		private const string WebPageUrlColumnPropertyName = "WebPageUrlColumn";
		private const string WebPageUrlPropertyName = "WebPageUrl";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Default constructor for <see cref="CampaignWebPageElement"/>.
		/// </summary>
		public CampaignWebPageElement() {
			ElementType = CampaignSchemaElementType.AsyncTask | CampaignSchemaElementType.Sessioned;
		}

		/// <summary>
		/// Constructor for <see cref="CampaignWebPageElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="CampaignWebPageElement"/>.</param>
		public CampaignWebPageElement(CampaignWebPageElement source) : this(source, null, null) {}

		/// <summary>
		/// Constructor for <see cref="CampaignWebPageElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="CampaignWebPageElement"/>.</param>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		public CampaignWebPageElement(CampaignWebPageElement source, Dictionary<Guid, Guid> dictToRebind,
				Core.Campaign.CampaignSchema parentSchema) : base(source, dictToRebind, parentSchema) {
			WebPageTargetEntityId = source.WebPageTargetEntityId;
			WebPageUrlColumn = source.WebPageUrlColumn;
			WebPageUrl = source.WebPageUrl;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Identifier of element action.
		/// </summary>
		protected override Guid Action => CampaignConsts.CampaignLogTypeWebPage;

		#endregion

		#region Properties: Public

		/// <summary>
		/// Unique identifier of the web page target entity.
		/// </summary>
		[MetaTypeProperty("{85A78F60-7E10-4F43-B6F5-B93092C44630}")]
		public Guid WebPageTargetEntityId { get; set; }

		/// <summary>
		/// Column name of target entity for current web page URL.
		/// </summary>
		[MetaTypeProperty("{E898DBC8-F922-4672-B880-50262B958F0C}")]
		public string WebPageUrlColumn { get; set; }

		/// <summary>
		/// URL of the current web page.
		/// </summary>
		[MetaTypeProperty("{7EE42072-D0CF-411D-A649-476BE2505009}")]
		public string WebPageUrl { get; set; }

		#endregion

		#region Methods: Protected

		protected override void ApplyMetaDataValue(DataReader reader) {
			base.ApplyMetaDataValue(reader);
			switch (reader.CurrentName) {
				case WebPageTargetEntityPropertyName:
					WebPageTargetEntityId = reader.GetGuidValue();
					break;
				case WebPageUrlColumnPropertyName:
					WebPageUrlColumn= reader.GetStringValue();
					break;
				case WebPageUrlPropertyName:
					WebPageUrl = reader.GetStringValue();
					break;
				default:
					break;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Writes meta data values.
		/// </summary>
		/// <param name="writer">Instance of the <see cref="DataWriter"/> type.</param>
		public override void WriteMetaData(DataWriter writer) {
			base.WriteMetaData(writer);
			writer.WriteValue(WebPageTargetEntityPropertyName, WebPageTargetEntityId, Guid.Empty);
			writer.WriteValue(WebPageUrlColumnPropertyName, WebPageUrlColumn, null);
			writer.WriteValue(WebPageUrlPropertyName, WebPageUrl, null);
		}

		/// <summary>
		/// Creates a new instance that is a clone of the current instance.
		/// </summary>
		/// <returns>Cloned instance of the <see cref="CampaignWebPageElement"/>.</returns>
		public override object Clone() {
			return new CampaignWebPageElement(this);
		}

		/// <summary>
		/// Creates a new instance that is a copy of the current instance.
		/// </summary>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		/// <returns>Copied instance of the <see cref="CampaignWebPageElement"/>.</returns>
		public override object Copy(Dictionary<Guid, Guid> dictToRebind, Core.Campaign.CampaignSchema parentSchema) {
			return new CampaignWebPageElement(this, dictToRebind, parentSchema);
		}

		/// <summary>
		/// Creates specific ProcessFlowElement instance.
		/// </summary>
		/// <param name="userConnection">Instance of <see cref="UserConnection"/>.</param>
		/// <returns>Instance of <see cref="ProcessFlowElement"/>.</returns>
		public override ProcessFlowElement CreateProcessFlowElement(UserConnection userConnection) {
			var executableElement = new CampaignWebPageFlowElement {
				UserConnection = userConnection,
				WebPageTargetEntityId = WebPageTargetEntityId,
				WebPageUrlColumn = WebPageUrlColumn,
				WebPageUrl = WebPageUrl
			};
			InitializeCampaignProcessFlowElement(executableElement);
			return executableElement;
		}

		#endregion

	}

	#endregion

}
