define("ProductCategoryTypeEditPage", [], function() {
	return {
		entitySchemaName: "ProductType",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Name",
				"parentName": "ControlsContainer",
				"propertyName": "items",
				"values": {
					"bindTo": "Name",
					"classes": {
						"labelClass": ["modalbox-control-caption"]
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
