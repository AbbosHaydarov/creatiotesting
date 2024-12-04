define("RegDocumentPageV2", [], function() {
	return {
		entitySchemaName: "RegDocument",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "IsPrimary",
				"values": {
					"layout": {
						"column": 0,
						"row": 5,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "CodeDivision",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "Document",
				"values": {
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Document"
				},
				"parentName": "Header",
				"propertyName": "items"
			}
		]/**SCHEMA_DIFF*/
	};
});
