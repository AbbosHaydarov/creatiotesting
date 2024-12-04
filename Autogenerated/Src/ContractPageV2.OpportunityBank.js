define("ContractPageV2", ["BusinessRuleModule"], function(BusinessRuleModule) {
		return {
			entitySchemaName: "Contract",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			attributes: {
				"Account": {
					name: "Account",
					dependencies: [
						{
							columns: ["Account"],
							methodName: "OnAccountChanged"
						}
					]
				}
			},
			methods: {
				/**
				 * ##### ####### #### "#######" ### ####### #### "##. ####"
				 * @protected
				 * @param {Object} newValue ######## # #### Account
				 */
				OnAccountChanged: function(newValue) {
					if (!newValue) {
						this.set("Opportunity", null);
					}
				}
			},
			rules: {
				"Opportunity": {
					"FiltrationOpportunityByAccount": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						autocomplete: true,
						autoClean: true,
						baseAttributePatch: "Account",
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						attribute: "Account"
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "Parent",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 1
					},
					"parentName": "ContractConnectionsBlock",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Opportunity",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Opportunity",
						"tabIndex": 0
					},
					"parentName": "ContractConnectionsBlock",
					"propertyName": "items"
				}
			] /**SCHEMA_DIFF*/
		};
	}
);
