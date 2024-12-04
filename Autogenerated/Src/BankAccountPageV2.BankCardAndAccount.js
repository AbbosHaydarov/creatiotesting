define("BankAccountPageV2",
	["BusinessRuleModule", "BaseFinanceConstants", "BankAccountPageV2Resources", "GeneralDetails"],
	function() {
		return {
			entitySchemaName: "BankAccount",
			details: /**SCHEMA_DETAILS*/{
				BankCardInBankAccountDetailV2: {
					schemaName: "BankCardInBankAccountDetailV2",
					entitySchemaName: "BankCardBankAccount",
					filter: {
						masterColumn: "Id",
						detailColumn: "BankAccount"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"name": "BankCardInBankAccountDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
