define("OpportunityConditionPage", [],
	function() {
		return {
			entitySchemaName: "OpportunityCondition",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"bindTo": "Name"
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "OpportunitySpecificationInConditionDetail",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/,
			details: {
				OpportunitySpecificationInConditionDetail: {
					schemaName: "OpportunitySpecificationInConditionDetail",
					defaultValues: {
						Product: {
							masterColumn: "Product"
						},
						ProductCondition: {
							masterColumn: "ProductCondition"
						}
					}
				}
			},
			attributes: {
				/**
				 * #######, # ####### ####### ####### #######.
				 * @type {Terrasoft.DataValueType.LOOKUP}
				 */
				Product: {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {

				/**
				 * @inheritDoc Terrasoft.BasePageV2#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.set("Product", this.getDefaultValueByName("Product"));
				},

				/**
				 * @inheritDoc Terrasoft.BasePAgeV2#initActionButtonMenu
				 * @overridden
				 */
				initActionButtonMenu: this.Terrasoft.emptyFn

			}
		};
	});
