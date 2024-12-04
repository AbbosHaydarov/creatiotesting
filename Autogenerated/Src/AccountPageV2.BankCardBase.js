define("AccountPageV2", ["AccountPageV2Resources"], function() {
	return {
		entitySchemaName: "Account",
		details: /**SCHEMA_DETAILS*/{
			"BankCard": {
				"schemaName": "BankCardDetailV2",
				"filter": {
					"detailColumn": "BankCardOwner",
					"masterColumn": "Id"
				},
				"useRelationship": true
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "BankCard",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "HistoryTabContainer",
				"propertyName": "items",
				"index": 6
			}
		]/**SCHEMA_DIFF*/
	};
});
