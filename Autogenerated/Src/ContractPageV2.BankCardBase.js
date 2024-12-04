define("ContractPageV2", ["ContractPageV2Resources"],
	function() {
		return {
			entitySchemaName: "Contract",
			details: /**SCHEMA_DETAILS*/{
				"BankCard": {
					"schemaName": "BankCardDetailV2",
					"filter": {
						"detailColumn": "Contract",
						"masterColumn": "Id"
					},
					defaultValues: {
						BankCardOwner: {
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
					"name": "BankCard",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 2
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
