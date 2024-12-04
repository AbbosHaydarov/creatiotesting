define("ProductKindPageV2", [], function() {
	return {
		entitySchemaName: "ProductKind",
		details: /**SCHEMA_DETAILS*/{}, /**SCHEMA_DETAILS*/
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"parentName": "GeneralInfoBlock",
				"propertyName": "items",
				"name": "Name",
				"values": {
					"bindTo": "Name",
					"layout": {"column": 0, "row": 0, "colSpan": 12}
				}
			},
			{
				"operation": "merge",
				"parentName": "GeneralInfoBlock",
				"propertyName": "items",
				"name": "ProductType",
				"values": {
					"bindTo": "ProductType",
					"layout": {"column": 0, "row": 1, "colSpan": 12}
				}
			},
			{
				"operation": "merge",
				"parentName": "GeneralInfoBlock",
				"propertyName": "items",
				"name": "Description",
				"values": {
					"bindTo": "Description",
					"layout": {"column": 0, "row": 2, "colSpan": 12}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
