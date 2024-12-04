define("LeadTypePageV2", [],
	function() {
		return {
			entitySchemaName: "LeadType",
			details: /**SCHEMA_DETAILS*/{
				LeadTypeSpecificationDetail: {
					schemaName: "LeadTypeSpecificationDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "LeadType"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "LeadTypeSpecificationDetail",
					"values": {
						"layout": {"column": 0, "row": 4, "colSpan": 12},
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "remove",
					"name": "ImageContainer"
				},
				{
					"operation": "merge",
					"name": "Name",
					"values" : {
						"layout": {
							"column": 0,
							"row": 0
						}
					}
				},
				{
					"operation": "merge",
					"name": "Description",
					"values" : {
						"layout": {
							"column": 0,
							"row": 1
						}
					}
				},
				{
					"operation": "merge",
					"name": "ProductInLeadTypeDetail",
					"values" : {
						"layout": {
							"column": 0,
							"row": 3
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
