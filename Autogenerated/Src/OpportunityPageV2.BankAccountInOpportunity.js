define("OpportunityPageV2", [], function() {
	return {
		entitySchemaName: "Opportunity",
		details: /**SCHEMA_DETAILS*/ {
			"BankAccount": {
				"schemaName": "BankAccountDetailV2",
				"filter": {
					"detailColumn": "Account",
					"masterColumn": "Account"
				},
				"useRelationship": true
			}
		} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "insert",
			"parentName": "OpportunityHistoryAccountTabContainer",
			"propertyName": "items",
			"name": "BankAccount",
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
