define("ExternalBankAccountPageV2", ["terrasoft", "BaseFinanceConstants"], function(Terrasoft, BaseFinanceConstants) {
	return {
		entitySchemaName: "ExternalBankAccount",
		attributes: {
			"BankAccount": {
				isRequired: true,
				lookupListConfig: {
					filter: function() {
						return Terrasoft.createColumnFilterWithParameter(
							Terrasoft.ComparisonType.EQUAL, "Type", BaseFinanceConstants.AccountType.Bank);
					}
				}
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ExternalBankAccountPageGeneralTabContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ExternalBankAccountPageGeneralTabContainer",
				"propertyName": "items",
				"name": "ExternalBankAccountPageGeneralBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "remove",
				"name": "actions"
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "BankAccount",
				values: {
					"isRequired": true,
					"bindTo": "BankAccount",
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					},
					"tabIndex": 2
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Number",
				values: {
					"bindTo": "Number",
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					},
					"tabIndex": 3
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "BankAccountType",
				values: {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "BankAccountType",
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					},
					"tabIndex": 4
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "ActualizedOn",
				values: {
					"bindTo": "ActualizedOn",
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					},
					"tabIndex": 5
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Description",
				values: {
					"contentType": Terrasoft.ContentType.LONG_TEXT,
					"bindTo": "Description",
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 24,
						"rowSpan": 1
					},
					"tabIndex": 6
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "BankAccountTurnover",
				values: {
					"bindTo": "BankAccountTurnover",
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					},
					"tabIndex": 7
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Currency",
				values: {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "Currency",
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					},
					"tabIndex": 8
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "IsPrimary",
				values: {
					"bindTo": "IsPrimary",
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12
					},
					"tabIndex": 9
				}
			},
			{
				"operation": "remove",
				"name": "CommunicationsContainer"
			},
			{
				"operation": "remove",
				"name": "Tabs"
			}
		]
	};
});
