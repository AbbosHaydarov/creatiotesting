define("OpportunitySpecificationInConditionDetail", ["SpecificationBuilderConstants", "SpecificationBuilderModule",
	"SpecificationMatrixBuilder", "SpecificationMatrixBuilderViewModel",
	"OpportunityConditionSpecificationRowViewModel"],
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
					"name": "OpportunityModuleContainer",
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
					var defaultValues = this.get("DefaultValues");
					var productCondition = this.Ext.Array.findBy(defaultValues, function(item) {
						return item.name === "ProductCondition";
					}, this);
					this.set("ProductCondition", productCondition);
					var product = this.Ext.Array.findBy(defaultValues, function(item) {
						return item.name === "Product";
					}, this);
					this.set("Product", product);
					this.sandbox.subscribe("GetSpecificationBuilderSchemaName", function() {
						return "OpportunitySpecificationInConditionSpecificationBuilder";
					}, this, [builderModuleId]);
				},

				/**
				 * @inheritDoc Terrasoft.BaseSpecificationInConditionDetail#getDetailFilters
				 * @overridden
				 */
				getDetailFilters: function() {
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					var productCondition = this.get("ProductCondition");
					var conditionFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"ProductCondition.Id",
						this.Ext.isEmpty(productCondition) ? null : productCondition.value);
					var detailFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"OpportunityCondition.Id",
						this.get("MasterRecordId"));
					var typeFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"SpecInConditionType.Id", this.getSpecInConditionType());
					filterGroup.addItem(detailFilter);
					filterGroup.addItem(conditionFilter);
					filterGroup.addItem(typeFilter);
					return filterGroup;
				},

				/**
				 * ############# ######### ###### SpecificationBuilderModule.
				 * @protected
				 */
				setBuilderConfig: function() {
					var builderModuleId = this.getModuleId("SpecificationBuilderModule");
					var product = this.get("Product");
					var productCondition = this.get("ProductCondition");
					var defaultValues = [{
						name: "Product",
						value: product && product.value
					}, {
						name: "ProductCondition",
						value: productCondition && productCondition.value
					}, {
						name: "SpecificationInConditionType",
						value: this.getSpecInConditionType()
					}, {
						name: "OpportunityCondition",
						value: this.get("MasterRecordId")
					}];
					this.sandbox.publish("SetBuilderConfig", {
						rowsCollection: this.getRowsCollection(),
						rowViewModelClassName: "Terrasoft.OpportunityConditionSpecificationRowViewModel",
						defaultValues: defaultValues
					}, [builderModuleId]);
				},

				/**
				 * ########## ############# ######### # ####### ########.
				 * @return {Terrasoft.Guid} ### ############# ######### # ####### ########.
				 */
				getSpecInConditionType: function() {
					return SpecificationBuilderConstants.SpecInConditionType.SpecificationOpportunityDetail;
				}
			}
		};
	});
