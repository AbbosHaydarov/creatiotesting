define("ContactPageV2", [], function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{
			"FinApplication": {
				"schemaName": "FinApplicationDetail",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Contact"
				}
			},
			"Contract": {
				"schemaName": "ContractDetailV2",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "ContactContract"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "Order"
			},
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"name": "FinApplication",
				"index": 8,
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {},
		methods: {},
		rules: {},
		userCode: {}
	};
});

