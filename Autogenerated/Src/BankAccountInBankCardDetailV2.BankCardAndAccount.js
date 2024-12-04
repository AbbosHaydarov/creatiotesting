define("BankAccountInBankCardDetailV2", ["terrasoft"], function(Terrasoft) {
		return {
			entitySchemaName: "BankCardBankAccount",
			attributes: {
				"MasterSchemaName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: "BankCard"
				},
				"ChildSchemaName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: "BankAccount"
				}
			},
			methods: {
				/**
				 * ########## #######, ####### ###### ########## ########
				 * @return {Object} ########## ###### ########-############ #######
				 */
				getGridDataColumns: function() {
					return {
						"Id": {path: "Id"},
						"BankAccount": {path: "BankAccount"},
						"BankAccount.BankAccountNumber": {path: "BankAccount.BankAccountNumber"},
						"BankAccount.Type": {path: "BankAccount.Type"},
						"BankAccount.Status": {path: "BankAccount.Status"}
					};
				},

				/**
				 * ###### ### ######
				 * @abstract
				 */
				getLookupConfig: function() {
					return {
						entitySchemaName: this.get("ChildSchemaName"),
						multiSelect: true,
						columns: ["BankAccountNumber", "Type", "Status"]
					};
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "BankAccount"
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
