define("BaseWebPageConditionalTransitionSchema", ["CampaignEnums",
		"BaseWebPageConditionalTransitionSchemaResources", "ProcessCampaignConditionalSequenceFlowSchema"],
	function(CampaignEnums) {
	Ext.define("Terrasoft.manager.BaseWebPageConditionalTransitionSchema", {
		extend: "Terrasoft.ProcessCampaignConditionalSequenceFlowSchema",
		alternateClassName: "Terrasoft.BaseWebPageConditionalTransitionSchema",

		managerItemUId: "2F442517-E45E-4B86-96FF-31D46F4B3775",

		mixins: {
			parametrizedProcessSchemaElement: "Terrasoft.ParametrizedProcessSchemaElement"
		},

		/**
		 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
		 * @protected
		 * @overridden
		 */
		typeName: "Terrasoft.Configuration.BaseWebPageConditionalTransitionElement, Terrasoft.Configuration",

		/**
		 * Sequence flow name.
		 * @type {String}
		 */
		connectionUserHandleName: "BaseWebPageConditionalTransition",

		/**
		 * @inheritdoc Terrasoft.ProcessBaseElementSchema#editPageSchemaName
		 */
		editPageSchemaName: "BaseWebPageConditionalTransitionPropertiesPage",

		/**
		 * Type of element
		 * @type {String}
		 */
		elementType: CampaignEnums.CampaignSchemaElementTypes.CONDITIONAL_TRANSITION,

		/**
		 * Transition can transfer participants with any status condition
		 * @type {Integer}
		 */
		stepCompletedCondition: CampaignEnums.StepCompletedConditions.COMPLETED,

		/**
		 * @inheritdoc Terrasoft.configuration.mixins.CampaignElementMixin#getElementSpecificPropertiesNames
		 * @overridden
		 */
		getElementSpecificPropertiesNames: function() {
			return  ["stepCompletedCondition"];
		},

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchema#getSerializableProperties
		 * @overridden
		 */
		getSerializableProperties: function() {
			var baseSerializableProperties = this.callParent(arguments);
			Ext.Array.push(baseSerializableProperties, ["stepCompletedCondition"]);
			return baseSerializableProperties;
		},

		/**
		 * @inheritdoc Terrasoft.ProcessCampaignConditionalSequenceFlowSchema#hasNotEmptyFilter
		 * @override
		 */
		hasNotEmptyFilter: function() {
			var result = this.callParent(arguments);
			return result || this.stepCompletedCondition !== CampaignEnums.StepCompletedConditions.ANY;
		}
	});
	return Terrasoft.BaseWebPageConditionalTransitionSchema;
});
