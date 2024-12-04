define("OpportunityConditionServiceRequest", ["ConfigurationServiceRequest"], function() {
	Ext.define("Terrasoft.configuration.OpportunityConditionServiceRequest", {
		extend: "Terrasoft.ConfigurationServiceRequest",
		alternateClassName: "Terrasoft.OpportunityConditionServiceRequest",

		/**
		 * ############# ######, ####### ##### ###########.
		 * @type {Terrasoft.GUID}
		 */
		sourceEntityId: null,

		/**
		 * @inheritdoc Terrasoft.ConfigurationServiceRequest#serviceName
		 * @overridden
		 */
		serviceName: "SpecificationHelperService",

		/**
		 * @inheritdoc Terrasoft.BaseRequest#getSerializableObject
		 * @overridden
		 */
		getSerializableObject: function(serializableObject) {
			this.callParent(arguments);
			var request = serializableObject.request = serializableObject.request || {};
			if (this.sourceEntityId) {
				request.sourceEntityId = this.sourceEntityId;
			}
		}

	});
});
