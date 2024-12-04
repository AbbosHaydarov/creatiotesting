namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Campaign.Interfaces;
	using Terrasoft.Core.Process;

	#region Class: AddFromWebPageSignalElement

	/// <summary>
	/// Element that appends participants to campaign audience by signal.
	/// </summary>
	[DesignModeProperty(Name = "WebPageURL",
		UsageType = DesignModeUsageType.NotVisible, MetaPropertyName = WebPageURLPropertyName)]
    [DesignModeProperty(Name = "WebPageURLColumn",
        UsageType = DesignModeUsageType.NotVisible, MetaPropertyName = WebPageURLColumnPropertyName)]
    public class AddFromWebPageSignalElement : CampaignStartSignalElement, IProcessSchemaSignalEvent,
		IFragmentSynchronizable, ICampaignSignalEntityHandlerFactory
	{

		#region Constants: Private

		private const string WebPageURLPropertyName = "WebPageURL";
        private const string WebPageURLColumnPropertyName = "WebPageURLColumn";

        #endregion

        #region Constructors: Public

        /// <summary>
        /// Default constructor for <see cref="AddFromWebPageSignalElement"/>.
        /// </summary>
        public AddFromWebPageSignalElement() {
			ElementType = CampaignSchemaElementType.StartSignal | CampaignSchemaElementType.Sessioned;
			WaitingRandomSignal = false;
			WaitingEntitySignal = true;
			HasEntityColumnChange = false;
        }

		/// <summary>
		/// Constructor for <see cref="AddFromWebPageSignalElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="AddFromWebPageSignalElement"/>.</param>
		public AddFromWebPageSignalElement(AddFromWebPageSignalElement source)
				: this(source, null, null) {
		}

		/// <summary>
		/// Constructor for <see cref="AddFromWebPageSignalElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="AddFromWebPageSignalElement"/>.</param>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		public AddFromWebPageSignalElement(AddFromWebPageSignalElement source,
				Dictionary<Guid, Guid> dictToRebind, Core.Campaign.CampaignSchema parentSchema)
					: base(source, dictToRebind, parentSchema) {
			EntitySchemaUId = source.EntitySchemaUId;
			SignalEntityId = source.SignalEntityId;
			Signal = source.Signal;
			WaitingRandomSignal = source.WaitingRandomSignal;
			WaitingEntitySignal = source.WaitingEntitySignal;
			EntitySignal = source.EntitySignal;
			HasEntityColumnChange = source.HasEntityColumnChange;
			HasEntityFilters = source.HasEntityFilters;
			LocalizableEntityFilters = new LocalizableString(source.LocalizableEntityFilters);
			EntityFilters = source.EntityFilters;
			EntityChangedColumns = source.EntityChangedColumns;
			IsRecurring = source.IsRecurring;
			WebPageURL = source.WebPageURL;
			WebPageURLColumn = source.WebPageURLColumn;

		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Identifier of element action.
		/// </summary>
		protected override Guid Action => CampaignConsts.CampaignLogTypeAddFromWebPage;

		#endregion

		#region Properties: Public

		public override bool UseBackgroundMode => false;

		[MetaTypeProperty("{A2990809-780E-40D2-871F-5E3BD081F469}")]
		public string WebPageURL { get; set; }

        [MetaTypeProperty("{50510F36-D287-422F-942D-0BCA3632EB78}")]
        public string WebPageURLColumn { get; set; }

        #endregion

        #region Methods: Protected

        /// <summary>
        /// Reads MetaData values to properties.
        /// </summary>
        protected override void ApplyMetaDataValue(DataReader reader) {
			base.ApplyMetaDataValue(reader);
			switch (reader.CurrentName) {
				case WebPageURLPropertyName:
					WebPageURL = reader.GetStringValue();
					break;
				case HasEntityFiltersPropertyName:
					HasEntityFilters = true;
					break;
				case WebPageURLColumnPropertyName:
                    WebPageURLColumn = reader.GetStringValue();
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
			writer.WriteValue(WebPageURLPropertyName, WebPageURL, null);
            writer.WriteValue(WebPageURLColumnPropertyName, WebPageURLColumn, null);
        }

		/// <summary>
		/// Creates a new instance that is a clone of the current instance.
		/// </summary>
		/// <returns>Cloned instance of the AddCampaignParticipantElement.</returns>
		public override object Clone() {
			return new AddFromWebPageSignalElement(this);
		}

		/// <summary>
		/// Creates a new instance that is a copy of the current instance.
		/// </summary>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		/// <returns>Copied instance of the AddCampaignParticipantElement.</returns>
		public override object Copy(Dictionary<Guid, Guid> dictToRebind, Core.Campaign.CampaignSchema parentSchema) {
			return new AddFromWebPageSignalElement(this, dictToRebind, parentSchema);
		}

		#endregion

	}

	#endregion

}

