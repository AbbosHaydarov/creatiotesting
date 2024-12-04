define("ContractPageV2", ["ContractPageV2Resources"],
	function() {
		return {
			entitySchemaName: "Contract",
			details: /**SCHEMA_DETAILS*/{
				"BankAccount": {
					"schemaName": "BankAccountDetailV2",
					"entitySchemaName": "BankAccount",
					"filter": {
						"detailColumn": "Contract",
						"masterColumn": "Id"
					},
					defaultValues: {
						Account: {
							masterColumn: "Account"
						},
						Product: {
							masterColumn: "Product"
						}
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "BankAccount",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 1
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
