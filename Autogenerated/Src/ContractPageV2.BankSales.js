define("ContractPageV2", ["ContractPageV2Resources"], function() {
	return {
		entitySchemaName: "Contract",
		details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "remove",
			"name": "Order"
		}, {
			"operation": "remove",
			"name": "Invoice"
		}, {
			"operation": "move",
			"name": "Activities",
			"parentName": "HistoryTab",
			"propertyName": "items",
			"index": 0
		}, {
			"operation": "move",
			"name": "EmailDetailV2",
			"parentName": "HistoryTab",
			"propertyName": "items",
			"index": 1
		}, {
			"operation": "move",
			"name": "Document",
			"parentName": "HistoryTab",
			"propertyName": "items",
			"index": 2
		}, {
			"operation": "move",
			"name": "BankAccount",
			"parentName": "HistoryTab",
			"propertyName": "items",
			"index": 3
		}, {
			"operation": "move",
			"name": "BankCard",
			"parentName": "HistoryTab",
			"propertyName": "items",
			"index": 4
		}] /**SCHEMA_DIFF*/
	};
});
