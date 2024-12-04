define("OpportunityPageV2", [], function() {
	return {
		entitySchemaName: "Opportunity",
		details: /**SCHEMA_DETAILS*/ {
			"AccountBankCard": {
				"schemaName": "BankCardDetailV2",
				"filter": {
					"detailColumn": "BankCardOwner",
					"masterColumn": "Account"
				},
				"useRelationship": true
			}
		} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "insert",
			"parentName": "OpportunityHistoryAccountTabContainer",
			"propertyName": "items",
			"name": "AccountBankCard",
			"values": {
				"itemType": Terrasoft.ViewItemType.DETAIL,
				"visible": {
					"bindTo": "isShowAccountsDetail"
				}
			},
			"index": "3"
		}] /**SCHEMA_DIFF*/
	};
});
