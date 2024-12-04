define("ContactPageV2", ["ContactPageV2Resources"], function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/ {
			"BankCard": {
				"schemaName": "BankCardDetailV2",
				"filter": {
					"detailColumn": "Holder",
					"masterColumn": "Id"
				}
			}
		} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "insert",
			"name": "BankCard",
			"values": {
				"itemType": Terrasoft.ViewItemType.DETAIL
			},
			"parentName": "HistoryTab",
			"propertyName": "items",
			"index": 5
		}] /**SCHEMA_DIFF*/
	};
});
