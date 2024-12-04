/**
 * Application mini page.
 * Parent: BaseMiniPage
 */
define("FinApplicationMiniPage", ["BusinessRuleModule", "BaseFinanceConstants", "css!FinApplicationMiniPageCSS"],
	function(BusinessRuleModule, BaseFinanceConstants) {
		return {
			entitySchemaName: "FinApplication",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			attributes: {
				/**
				 * @inheritdoc BaseMiniPage#MiniPageModes
				 * @overridden
				 */
				"MiniPageModes": {
					"value": [this.Terrasoft.ConfigurationEnums.CardOperation.ADD]
				}
			},
			rules: {
				"Branch": {
					"BranchFiltrationByOurBank": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"baseAttributePatch": "Type",
						"type": BusinessRuleModule.enums.ValueType.CONSTANT,
						"value": BaseFinanceConstants.AccountType.OurBank
					}
				},
				"Division": {
					"DivisionFiltrationByOurBank": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"baseAttributePatch": "Type",
						"type": BusinessRuleModule.enums.ValueType.CONSTANT,
						"value": BaseFinanceConstants.AccountType.OurBank
					}
				},
				"ProductType": {
					"ProductTypeByProductCategory": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"autoClean": true,
						"baseAttributePatch": "Category",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "ProductCategory"
					}
				}
			},
			methods: {

				//region Methods: Private

				/**
				* Sets Branch and Division default values.
				* @private
				*/
				initBranchDivision: function() {
					var currentUserAccount = this.Terrasoft.SysValue.CURRENT_USER_ACCOUNT;
					if (this.isAddMode() && this.Ext.isObject(currentUserAccount) &&
							!this.Terrasoft.isEmptyGUID(currentUserAccount.value)) {
						this.set("Branch", currentUserAccount);
						this.set("Division", currentUserAccount);
					}
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc BaseMiniPage#onEntityInitialized
				 * @protected
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.initBranchDivision();
					this.callParent(arguments);
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/[

				//region Fields: Edit/Add mode

				{
					"operation": "insert",
					"parentName": "MiniPage",
					"propertyName": "items",
					"name": "ProductCategory",
					"values": {
						"isMiniPageModelItem": true,
						"visible": {"bindTo": "isNotViewMode"},
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"controlConfig": {
							"focused": true
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "MiniPage",
					"propertyName": "items",
					"name": "ProductType",
					"values": {
						"isMiniPageModelItem": true,
						"visible": {"bindTo": "isNotViewMode"},
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"bindTo": "ProductType"
					}
				},
				{
					"operation": "insert",
					"parentName": "MiniPage",
					"propertyName": "items",
					"name": "Division",
					"values": {
						"isMiniPageModelItem": true,
						"visible": {"bindTo": "isNotViewMode"},
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "MiniPage",
					"propertyName": "items",
					"name": "Branch",
					"values": {
						"isMiniPageModelItem": true,
						"visible": {"bindTo": "isNotViewMode"},
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "merge",
					"name": "MiniPage",
					"values": {
						"classes": {
							"wrapClassName": ["fin-application-mini-page-container"]
						}
					}
				},
				{
					"operation": "merge",
					"name": "CloseMiniPageButton",
					"values": {
						"visible": {"bindTo": "isNotViewMode"}
					}
				},
				{
					"operation": "merge",
					"name": "SaveEditButton",
					"values": {
						"click": {"bindTo": "openCurrentEntityPage"}
					}
				}

				//endregion

			]/**SCHEMA_DIFF*/
		};
	});
