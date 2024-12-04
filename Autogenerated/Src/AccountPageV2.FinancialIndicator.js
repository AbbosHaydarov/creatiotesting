define("AccountPageV2", [],
	function() {
		return {
			entitySchemaName: "Account",
			details: /**SCHEMA_DETAILS*/{
				"AccountFinIndicator": {
					"schemaName": "AccountFinIndicatorDetailV2",
					"filter": {
						"detailColumn": "Account",
						"masterColumn": "Id"
					},
					"useRelationship": true
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "AccountFinIndicator",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTabContainer",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
