define("BankCardPageV2", ["terrasoft", "BankCardPageV2Resources", "GeneralDetails",
		"BaseFinanceConstants", "BusinessRuleModule"],
	function(Terrasoft) {
		return {
			entitySchemaName: "BankCard",
			details: /**SCHEMA_DETAILS*/{
				BankAccountInBankCardDetailV2: {
					schemaName: "BankAccountInBankCardDetailV2",
					entitySchemaName: "BankCardBankAccount",
					filter: {
						masterColumn: "Id",
						detailColumn: "BankCard"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"name": "BankAccountInBankCardDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
