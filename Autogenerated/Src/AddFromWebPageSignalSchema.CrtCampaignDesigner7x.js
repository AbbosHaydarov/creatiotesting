 define("AddFromWebPageSignalSchema", ["AddFromWebPageSignalSchemaResources",
	"CampaignEnums", "CampaignBaseAudienceSchema", "CampaignElementMixin","css!MultilineLabel"],
		function(resources, CampaignEnums) {
	/**
	 * @class Terrasoft.manager.AddFromWebPageSignalSchema
	 * Schema of start signal element.
	 */
	Ext.define("Terrasoft.manager.AddFromWebPageSignalSchema", {
		extend: "Terrasoft.CampaignBaseAudienceSchema",
		alternateClassName: "Terrasoft.AddFromWebPageSignalSchema",

		mixins: {
			campaignElementMixin: "Terrasoft.CampaignElementMixin"
		},

		/**
		 * UId of current manager item.
		 */
		managerItemUId: "36be5beb-f74d-494e-8e61-4e1b90563440",

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchema#name
		 */
		name: "AddFromWebPageSignal",

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
		 * @inheritdoc Terrasoft.ProcessBaseElementSchema#editPageSchemaName
		 */
		editPageSchemaName: "AddFromWebPageSignalPropertiesPage",

		/**
		 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
		 * @protected
		 * @overridden
		 */
		typeName: "Terrasoft.Configuration.AddFromWebPageSignalElement, Terrasoft.Configuration",

		/**
		 * Type of element
		 * @type {string}
		 */
		elementType: "AddFromWebPageSignal",

		/**
		 * Background fill color.
		 * @protected
		 * @type {String}
		 */
		color: "rgba(101, 215, 144, 1)",

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#width
		 * @overridden
		 */
		width: 55,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#height
		 * @overridden
		 */
		height: 55,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#incomingConnectionsLimit
		 * @overridden
		 */
		incomingConnectionsLimit: 0,

		/**
		 * @protected
		 * @type {enum}
		 */
		entitySignal: Terrasoft.EntityChangeType.Updated,

		/**
		 * Signal object unique Id.
		 * @protected
		 * @type {String}
		 */
		signalEntityId: null,

		/**
		 * @protected
		 * @type {String}
		 */
		signal: null,

		/**
		 * @protected
		 * @type {Boolean}
		 */
		waitingRandomSignal: false,

		/**
		 * @protected
		 * @type {Boolean}
		 */
		waitingEntitySignal: true,

		/**
		 * @protected
		 * @type {Boolean}
		 */
		hasEntityColumnChange: false,

		/**
		 * @protected
		 * @type {Boolean}
		 */
		hasEntityFilters: false,

		/**
		 * @protected
		 * @type {Object}
		 */
		newEntityChangedColumns: null,

		/**
		 * @protected
		 * @type {String}
		 */
		entityFilters: null,

		/**
		 * Object unique Id.
		 * @protected
		 * @type {String}
		 */
		entitySchemaUId: null,

		/**
		 * Flag to indicate participant recurring entrance to campaign audience.
		 * @type {Boolean}
		 */
		isRecurring: false,
		
		/**
		 * Parameter to compare with webPageURL from lookupColumn
		 * @type {String}
		 */
		webPageURL: "",

		/**
		 * Path to column for compare with webPageURL
		 * @type {String}
		 */
		webPageURLColumn: "",

		/**
		 * @inheritdoc Terrasoft.CampaignBaseAudienceSchema#constructor
		 * @override
		 */
		constructor: function() {
			this.callParent(arguments);
			this.newEntityChangedColumns =
				this._decodeNewEntityChangedColumns(this.newEntityChangedColumns);
		},

		/**
		 * Decode entity columns.
		 * @private
		 * @param {String} stringValue Encoded string value.
		 * @return {Array} Entity columns array.
		 */
		_decodeNewEntityChangedColumns: function(stringValue) {
			var newEntityChangedColumns = [];
			if (Ext.isEmpty(stringValue)) {
				return newEntityChangedColumns;
			}
			var newEntityChangedColumnsRawValue = Terrasoft.decode(stringValue);
			if (Ext.isArray(newEntityChangedColumnsRawValue)) {
				return newEntityChangedColumnsRawValue;
			}
			Terrasoft.each(newEntityChangedColumnsRawValue, function(propertyValue, propertyName) {
				if (propertyName === "$values" && Ext.isArray(propertyValue)) {
					newEntityChangedColumns = propertyValue;
					return true;
				}
			});
			return newEntityChangedColumns;
		},

		/**
		 * @inheritdoc Terrasoft.ProcessFlowElementSchema#validate
		 * @override
		 */
		validate: function() {
			var results = Ext.create("Terrasoft.Collection");
			if (this.getOutgoingsSequenceFlows().length === 0) {
				results.add(CampaignEnums.CampaignFlowSchemaValidationRules.ADD_AUDIENCE_WITHOUT_OUTGOINGS,
					resources.localizableStrings.AddAudienceWithoutOutgoingsMessage);
			}
			return results;
		},

		/**
		 * @inheritdoc Terrasoft.ProcessFlowElementSchema#getSerializableObject
		 * @override
		 */
		getSerializableObject: function(serializableObject) {
			this.callParent(arguments);
			serializableObject.newEntityChangedColumns = JSON.stringify(this.newEntityChangedColumns);
		},

		/**
		 * @inheritdoc Terrasoft.ProcessFlowElementSchema#getSerializableProperties
		 * @override
		 */
		getSerializableProperties: function() {
			var baseSerializableProperties = this.callParent(arguments);
			return Ext.Array.push(baseSerializableProperties, ["signal", "signalEntityId", "entitySignal",
				"waitingRandomSignal", "waitingEntitySignal", "hasEntityColumnChange", "hasEntityFilters",
				"entityFilters", "entitySchemaUId", "isRecurring","webPageURL","webPageURLColumn"]);
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
	return Terrasoft.AddFromWebPageSignalSchema;
});
