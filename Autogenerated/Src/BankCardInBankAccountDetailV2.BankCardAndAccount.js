define("BankCardInBankAccountDetailV2", ["terrasoft"], function(Terrasoft) {
	return {
		entitySchemaName: "BankCardBankAccount",
		attributes: {
			"MasterSchemaName": {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: "BankAccount"
			},
			"ChildSchemaName": {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: "BankCard"
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
					"BankCard": {path: "BankCard"},
					"BankCard.Number": {path: "BankCard.Number"},
					"BankCard.BankCardType": {path: "BankCard.BankCardType"},
					"BankCard.BankCardStatus": {path: "BankCard.BankCardStatus"}
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
					columns: ["Number", "BankCardType", "BankCardStatus"]
				};
			}
		},
		diff: /**SCHEMA_DIFF*/[{
			"operation": "merge",
			"name": "DataGrid",
			"values": {
				"rowDataItemMarkerColumnName": "BankCard"
			}
		}]/**SCHEMA_DIFF*/
	};
});
