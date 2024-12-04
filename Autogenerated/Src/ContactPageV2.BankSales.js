define("ContactPageV2", ["ContactPageV2Resources"], function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "Order"
			},
			{
				"operation": "remove",
				"name": "Invoice"
			},
			{
				"operation": "move",
				"name": "Activities",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "move",
				"name": "Email",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "move",
				"name": "Leads",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "move",
				"name": "Opportunities",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "move",
				"name": "Contract",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "move",
				"name": "Documents",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "move",
				"name": "BankCard",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "move",
				"name": "Calls",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 7
			}
		]/**SCHEMA_DIFF*/
	};
});
