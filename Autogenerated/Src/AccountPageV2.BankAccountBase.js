define("AccountPageV2", ["AccountPageV2Resources"], function() {
	return {
		entitySchemaName: "Account",
		details: /**SCHEMA_DETAILS*/{
			"BankAccount": {
				"schemaName": "BankAccountDetailV2",
				"entitySchemaName": "BankAccount",
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
				"name": "BankAccount",
				"values": {
					"itemType": 2
				},
				"parentName": "HistoryTabContainer",
				"propertyName": "items",
				"index": 4
			}
		]/**SCHEMA_DIFF*/
	};
});
