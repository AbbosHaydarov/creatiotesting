define("ContactCareerPageInContactV2", [], function() {
	return {
		entitySchemaName: "ContactCareer",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "Contact",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colspan": 12
					}
				}
			},
			{
				"operation": "insert",
				"name": "EmploymentType",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "EmploymentType",
					"enabled": true,
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "merge",
				"name": "Primary",
				"values": {
					"layout": {
						"colSpan": 2,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "Current",
				"values": {
					"layout": {
						"colSpan": 2,
						"rowSpan": 1,
						"column": 17,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"parentName": "LeftContainer",
				"propertyName": "items",
				"name": "actions",
				"values": {
					"visible": false
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
