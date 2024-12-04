define("OpportunityPageV2", [], function() {
	return {
		entitySchemaName: "Opportunity",
		details: /**SCHEMA_DETAILS*/ {
			"AccountLead": {
				schemaName: "LeadDetailV2",
				filter: {
					masterColumn: "Account",
					detailColumn: "QualifiedAccount"
				},
				useRelationship: true
			}
		} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "insert",
			"parentName": "HistoryAccountTab",
			"propertyName": "items",
			"name": "AccountLead",
			"values": {
				"itemType": Terrasoft.ViewItemType.DETAIL,
				"visible": {
					"bindTo": "isShowAccountsDetail"
				}
			}
		}] /**SCHEMA_DIFF*/
	};
});
