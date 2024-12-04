define("CampaignStartFacebookFormSchema", ["CampaignStartFacebookFormSchemaResources",
	"CampaignStartSignalSchema", "CampaignElementMixin"],
		function(resources) {
	/**
	 * @class Terrasoft.manager.CampaignStartFacebookFormSchema
	 * Schema of Facebook form start element.
	 */
	Ext.define("Terrasoft.manager.CampaignStartFacebookFormSchema", {
		extend: "Terrasoft.CampaignStartSignalSchema",
		alternateClassName: "Terrasoft.CampaignStartFacebookFormSchema",

		mixins: {
			campaignElementMixin: "Terrasoft.CampaignElementMixin"
		},

		/**
		 * UId of current manager item.
		 */
		managerItemUId: "CB8B1CAF-95DD-49C2-8854-0C1D12EA581F",

		/**
		 * @inheritdoc Terrasoft.manager.CampaignStartSignalSchema#name
		 */
		name: "CampaignStartFacebookForm",

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchema#caption
		 */
		caption: resources.localizableStrings.Caption,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#TitleImage
		 */
		titleImage: resources.localizableImages.TitleImage,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#LargeImage
		 */
		largeImage: resources.localizableImages.LargeImage,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#SmallImage
		 */
		smallImage: resources.localizableImages.SmallImage,

		/**
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#editPageSchemaName
		 */
		editPageSchemaName: "CampaignStartFacebookFormPage",

		/**
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#typeName
		 * @override
		 */
		typeName: "Terrasoft.Configuration.CampaignStartFacebookFormElement, Terrasoft.Configuration",

		/**
		 * @override
		 * @type {enum}
		 */
		entitySignal: Terrasoft.EntityChangeType.Inserted,

		/**
		 * @override
		 * @type {Boolean}
		 */
		hasEntityFilters: true,

		/**
		 * @override
		 * @type {String}
		 */
		entityFilters: null,

		/**
		 * Identifier of the landing page
		 */
		landingId: null,

		/**
		 * Clears linked landing when element copy is created.
		 * @inheritdoc Terrasoft.manager.CampaignBaseElementSchema#prepareCopy
		 * @override
		 */
		prepareCopy: function() {
			var copy = this.callParent(arguments);
			copy.entityFilters = null;
			copy.landingId = null;
			return copy;
		},

		/**
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#getSerializableProperties
		 * @override
		 */
		getSerializableProperties: function() {
			var baseSerializableProperties = this.callParent(arguments);
			return Ext.Array.push(baseSerializableProperties, ["landingId"]);
		},

		/**
		 * @inheritdoc Terrasoft.CampaignBaseElementSchema#getElementMarkers
		 * @override
		 */
		getElementMarkers: function() {
			var markers = {};
			if (this.isRecurring) {
				markers.recurring = { name: "Recurring" };
			}
			return markers;
		},

		/**
		 * @inheritDoc Terrasoft.CampaignBaseElementSchema#initTitleImage
		 * @override
		 */
		initTitleImage: function() {
			this.titleImage = this.isRecurring
				? resources.localizableImages.TitleIsRecurringImage
				: resources.localizableImages.TitleImage;
		}
	});
	return Terrasoft.CampaignStartFacebookFormSchema;
});
