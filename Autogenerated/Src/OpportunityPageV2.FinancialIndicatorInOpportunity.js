define("OpportunityPageV2", [], function() {
	return {
		entitySchemaName: "Opportunity",
		details: /**SCHEMA_DETAILS*/ {
			"AccountFinIndicator": {
				schemaName: "AccountFinIndicatorDetailV2",
				filter: {
					masterColumn: "Account",
					detailColumn: "Account"
				},
				useRelationship: true
			}
		} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "insert",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"name": "AccountFinIndicator",
			"values": {
				"itemType": Terrasoft.ViewItemType.DETAIL,
				"visible": {
					"bindTo": "isShowAccountsDetail"
				}
			}
		}] /**SCHEMA_DIFF*/
	};
});
