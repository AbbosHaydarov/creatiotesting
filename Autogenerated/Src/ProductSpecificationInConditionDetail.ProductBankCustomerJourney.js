define("ProductSpecificationInConditionDetail", ["SpecificationBuilderConstants", "SpecificationBuilderModule",
	"Switcher", "ProductSpecificationInConditionDetailResources"],
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
					"name": "ProductModuleContainer",
					"parentName": "Detail",
					"propertyName": "items",
					"values": {
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
						return "ProductSpecificationInConditionSpecificationBuilder";
					}, this, [builderModuleId]);
				},

				/**
				 * ########## ############# ######### # ####### ########.
				 * @return {Guid} ### ############# ######### # ####### ########.
				 */
				getSpecInConditionType: function() {
					return SpecificationBuilderConstants.SpecInConditionType.SpecificationProductDetail;
				}
			}
		};
	});
