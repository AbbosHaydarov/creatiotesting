define("CustomerSpecificationInConditionDetail", ["SpecificationBuilderConstants", "SpecificationBuilderModule",
		"Switcher", "CustomerSpecificationInConditionDetailResources"],
	function(SpecificationBuilderConstants) {
		return {
			messages: {
				/**
				 * @message GetSpecificationBuilderSchemaName
				 */
				"GetSpecificationBuilderSchemaName": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "CustomerModuleContainer",
					"parentName": "Detail",
					"propertyName": "items",
					"values": {
						"makeUniqueId": true,
						"generateId": true,
						"itemType": Terrasoft.ViewItemType.MODULE,
						"moduleName": "SpecificationBuilderModule",
						"afterrender": {"bindTo": "onAfterRender"},
						"afterrerender": {"bindTo": "onAfterReRender"}
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * @inheritDoc BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					var builderModuleId = this.getModuleId("SpecificationBuilderModule");
					this.sandbox.subscribe("GetSpecificationBuilderSchemaName", function() {
						return "CustomerSpecificationInConditionSpecificationBuilder";
					}, this, [builderModuleId]);
				},

				/**
				 * ########## ############# ######### # ####### ########.
				 * @return {Guid} ### ############# ######### # ####### ########.
				 */
				getSpecInConditionType: function() {
					return SpecificationBuilderConstants.SpecInConditionType.SpecificationCustomerDetail;
				}
			}
		};
	});
