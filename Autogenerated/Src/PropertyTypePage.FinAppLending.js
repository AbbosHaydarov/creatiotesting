define("PropertyTypePage", ["PropertyTypePageResources"], function() {
	return {
		entitySchemaName: "PropertyType",
		details: /**SCHEMA_DETAILS*/ {
			"SpecInPropertyTypeDetail": {
				"schemaName": "SpecInPropertyTypeDetail",
				"filter": {
					"detailColumn": "PropertyType",
					"masterColumn": "Id"
				}
			}
		} /**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/ [
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Name",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "CollateralObjectType",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "AdditionalInformationContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"name": "SpecInPropertyTypeDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL,
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			}
		] /**SCHEMA_DIFF*/
	};
});
