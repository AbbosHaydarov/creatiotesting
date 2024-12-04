define("ProductCategoryEditPage", [], function() {
	return {
		entitySchemaName: "ProductCategory",
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
			},
			{
				"operation": "insert",
				"name": "Kind",
				"parentName": "ControlsContainer",
				"propertyName": "items",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "Kind",
					"classes": {
						"labelClass": ["modalbox-control-caption"]
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
