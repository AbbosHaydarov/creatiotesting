/**
 * Schema of campaign web page element.
 */
define("CampaignWebPageSchema", ["CampaignWebPageSchemaResources", "CampaignEnums",
		"CampaignBaseAudienceSchema"],
	function(resources, CampaignEnums) {
		/**
		 * @class Terrasoft.manager.CampaignWebPageSchema
		 * Schema of the web page element.
		 */
		Ext.define("Terrasoft.manager.CampaignWebPageSchema", {
			extend: "Terrasoft.CampaignBaseElementSchema",
			alternateClassName: "Terrasoft.CampaignWebPageSchema",

			mixins: {
				campaignElementMixin: "Terrasoft.CampaignElementMixin"
			},

			/**
			 * UId of current manager item.
			 */
			managerItemUId: "7EE16FA3-C3A8-417F-A887-C95DC8007D03",

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#name
			 */
			name: "CampaignWebPage",

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
			editPageSchemaName: "CampaignWebPagePropertiesPage",

			/**
			 * Type of element
			 * @type {string}
			 */
			elementType: CampaignEnums.CampaignSchemaElementTypes.CAMPAIGN_WEBPAGE,

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
			 * @protected
			 * @override
			 */
			typeName: "Terrasoft.Configuration.CampaignWebPageElement, Terrasoft.Configuration",

			/**
			 * Background fill color.
			 * @protected
			 * @type {string}
			 */
			color: "rgba(247, 194, 0, 1)",

			/**
			 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#width
			 * @override
			 */
			width: 55,

			/**
			 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#height
			 * @override
			 */
			height: 55,

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#nodeType
			 * @override
			 */
			nodeType: Terrasoft.diagram.UserHandlesConstraint.Gateway,

			/**
			 * Target entity source identifier for current web page.
			 * @type {string}
			 */
			webPageTargetEntityId: null,

			/**
			 * Path to target entity column with web page URL for filter.
			 * @type {String}
			 */
			webPageUrlColumn: null,

			/**
			 * URL of the web page to filter audience.
			 * @type {string}
			 */
			webPageUrl: null,

			/**
			 * @inheritdoc Terrasoft.manager.ProcessFlowElementSchema#getConnectionUserHandles
			 * @override
			 */
			getConnectionUserHandles: function() {
				return ["BaseWebPageConditionalTransition"];
			},

			/**
			 * Clears linked landing when element copy is created.
			 * @inheritdoc Terrasoft.manager.CampaignBaseElementSchema#prepareCopy
			 * @override
			 */
			prepareCopy: function() {
				var copy = this.callParent(arguments);
				copy.webPageUrl = null;
				return copy;
			},

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#getSerializableProperties
			 * @override
			 */
			getSerializableProperties: function() {
				var baseSerializableProperties = this.callParent(arguments);
				return Ext.Array.push(baseSerializableProperties,
					["webPageTargetEntityId", "webPageUrl", "webPageUrlColumn"]);
			},

			/**
			 * @inheritdoc CampaignBaseElementSchema#validate
			 * @override
			 */
			validate: function() {
				var results = Ext.create("Terrasoft.Collection");
				if (this.getIncomingSequenceFlows().length === 0) {
					results.add(CampaignEnums.CampaignFlowSchemaValidationRules.ASYNC_WITHOUT_INCOMINGS,
						resources.localizableStrings.AsyncWithoutIncomingsMessage);
				}
				return results;
			}
		});
		return Terrasoft.CampaignWebPageSchema;
	});
