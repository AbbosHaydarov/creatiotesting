define("DefProductTypePageV2", [],
	function() {
		return {
			entitySchemaName: "ProductType",
			details: /**SCHEMA_DETAILS*/{
				DocumentListDetailV2: {
					schemaName: "DocumentListDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "ProductType"
					}
				},
				DefSpecificationDetailV2: {
					schemaName: "DefSpecificationDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "ProductType"
					}
				},
				ChangeCriteriaDetailV2: {
					schemaName: "ChangeCriteriaDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "ProductType"
					},
					defaultValues: {
						Category: {
							masterColumn: "Category"
						}
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "DocumentListTab",
					"propertyName": "items",
					"name": "DocumentListDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "ParametersTab",
					"propertyName": "items",
					"name": "DefSpecificationDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "ChangeCriteriaTab",
					"propertyName": "items",
					"name": "ChangeCriteriaDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
