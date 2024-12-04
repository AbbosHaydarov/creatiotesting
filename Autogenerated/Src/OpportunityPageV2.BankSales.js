define("OpportunityPageV2", [], function() {
	return {
		entitySchemaName: "Opportunity",
		details: /**SCHEMA_DETAILS*/ {
			"AccountDocument": {
				"schemaName": "DocumentDetailV2",
				"filter": {
					"masterColumn": "Account",
					"detailColumn": "Account"
				},
				"useRelationship": true,
				"captionName": "AccountDocumentsCaption"
			}
		} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "move",
			"name": "ContactsAccount",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 0
		}, {
			"operation": "move",
			"name": "ActivitiesAccount",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 1
		}, {
			"operation": "move",
			"name": "AccountLead",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 2
		}, {
			"operation": "move",
			"name": "OpportunityAccount",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 3
		}, {
			"operation": "move",
			"name": "AccountContract",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 4
		}, {
			"operation": "insert",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"name": "AccountDocument",
			"values": {
				"itemType": Terrasoft.ViewItemType.DETAIL
			},
			"index": 5
		}, {
			"operation": "move",
			"name": "BankAccount",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 6
		}, {
			"operation": "move",
			"name": "AccountExternalBankAccount",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 7
		}, {
			"operation": "move",
			"name": "AccountBankCard",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 8
		}, {
			"operation": "move",
			"name": "AccountFinIndicator",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 9
		}, {
			"operation": "move",
			"name": "AccountEmails",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 10
		}, {
			"operation": "move",
			"name": "FilesAccount",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"index": 11
		}] /**SCHEMA_DIFF*/
	};
});
