define("BankAccountPageV2", ["BusinessRuleModule", "BaseFinanceConstants", "BankAccountPageV2Resources",
		"GeneralDetails", "BankAccountFile"
	],
	function(BusinessRuleModule, BaseFinanceConstants) {
		return {
			entitySchemaName: "BankAccount",
			details: /**SCHEMA_DETAILS*/ {
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "BankAccountFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "BankAccount"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "BankAccountNumber",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "BankAccountNumber",
					"enabled": true,
					"tabIndex": 2

				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Contract",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Contract",
					"enabled": true,
					"tabIndex": 3
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "Account",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Account",
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 2
			}, {
				"operation": "insert",
				"name": "Product",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Product",
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 3
			}, {
				"operation": "insert",
				"name": "GeneralInfoTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.GeneralInfoTabCaption"
					},
					"items": []
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0
			}, {
				"operation": "insert",
				"name": "generalGroup",
				"values": {
					"itemType": 15,
					"caption": {
						"bindTo": "Resources.Strings.generalGroupCaption"
					},
					"items": [],
					"controlConfig": {
						"collapsed": false
					}
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "generalGridLayout",
				"values": {
					"itemType": 0,
					"items": []
				},
				"parentName": "generalGroup",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Type",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Type",
					"enabled": true,
					"textSize": "Default",
					"contentType": 3,
					"labelConfig": {
						"visible": true
					},
					"tabIndex": 4
				},
				"parentName": "generalGridLayout",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Currency",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Currency",
					"enabled": true,
					"textSize": "Default",
					"contentType": 3,
					"labelConfig": {
						"visible": true
					},
					"tabIndex": 5
				},
				"parentName": "generalGridLayout",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "Balance",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Balance",
					"enabled": true,
					"tabIndex": 6
				},
				"parentName": "generalGridLayout",
				"propertyName": "items",
				"index": 2
			}, {
				"operation": "insert",
				"name": "Branch",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Branch",
					"enabled": true,
					"tabIndex": 7
				},
				"parentName": "generalGridLayout",
				"propertyName": "items",
				"index": 3
			}, {
				"operation": "insert",
				"name": "Division",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Division",
					"enabled": true,
					"tabIndex": 8
				},
				"parentName": "generalGridLayout",
				"propertyName": "items",
				"index": 4
			}, {
				"operation": "insert",
				"name": "statusGroup",
				"values": {
					"itemType": 15,
					"caption": {
						"bindTo": "Resources.Strings.StatusGroupCaption"
					},
					"items": [],
					"controlConfig": {
						"collapsed": false
					}
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "statusGroupGridLayout",
				"values": {
					"itemType": 0,
					"items": []
				},
				"parentName": "statusGroup",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "OpenedOn",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "OpenedOn",
					"enabled": true,
					"tabIndex": 9
				},
				"parentName": "statusGroupGridLayout",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "ActivatedOn",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "ActivatedOn",
					"enabled": true,
					"tabIndex": 10
				},
				"parentName": "statusGroupGridLayout",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "Status",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Status",
					"enabled": true,
					"textSize": "Default",
					"contentType": 3,
					"labelConfig": {
						"visible": true
					},
					"tabIndex": 11
				},
				"parentName": "statusGroupGridLayout",
				"propertyName": "items",
				"index": 2
			}, {
				"operation": "insert",
				"name": "ClosedOn",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "ClosedOn",
					"enabled": true,
					"tabIndex": 12
				},
				"parentName": "statusGroupGridLayout",
				"propertyName": "items",
				"index": 3
			}, {
				"operation": "insert",
				"name": "ReasonForClosing",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "ReasonForClosing",
					"enabled": true,
					"textSize": "Default",
					"contentType": 3,
					"tabIndex": 13
				},
				"parentName": "statusGroupGridLayout",
				"propertyName": "items",
				"index": 4
			}, {
				"operation": "insert",
				"name": "NotesAndFilesTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.BankAccountFilesTabCaption"
					},
					"items": []
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2
			}, {
				"operation": "insert",
				"name": "Files",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "NotesControlGroup",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"caption": {
						"bindTo": "Resources.Strings.NotesGroupCaption"
					}
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 2
			}, {
				"operation": "insert",
				"parentName": "NotesControlGroup",
				"propertyName": "items",
				"name": "Notes",
				"values": {
					"contentType": Terrasoft.ContentType.RICH_TEXT,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"imageLoaded": {
							"bindTo": "insertImagesToNotes"
						},
						"images": {
							"bindTo": "NotesImagesCollection"
						}
					}
				}
			}] /**SCHEMA_DIFF*/ ,
			rules: {
				"ReasonForClosing": {
					"VisibleReasonForClosing": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.VISIBLE,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "Status"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: BaseFinanceConstants.BankAccountStatus.Closed
							}
						}]
					},
					"RequiredReasonForClosing": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.REQUIRED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "Status"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: BaseFinanceConstants.BankAccountStatus.Closed
							}
						}]
					}
				},
				"ClosedOn": {
					"VisibleCloseOn": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.VISIBLE,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "Status"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: BaseFinanceConstants.BankAccountStatus.Closed
							}
						}]
					},
					"RequiredCloseOn": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.REQUIRED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "Status"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: BaseFinanceConstants.BankAccountStatus.Closed
							}
						}]
					}
				},
				"Branch": {
					"BranchFiltrationByOurBank": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						baseAttributePatch: "Type",
						type: BusinessRuleModule.enums.ValueType.CONSTANT,
						value: BaseFinanceConstants.AccountType.OurBank
					}
				},
				"Division": {
					"DivisionFiltrationByOurBank": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						baseAttributePatch: "Type",
						type: BusinessRuleModule.enums.ValueType.CONSTANT,
						value: BaseFinanceConstants.AccountType.OurBank
					}
				}
			},
			attributes: {
				"Account": {
					name: "Account",
					dataValueType: Terrasoft.DataValueType.ENUM,
					dependencies: [{
						columns: ["Contract"],
						methodName: "onContractChange"
					}]
				},
				"Contract": {
					lookupListConfig: {
						columns: ["Account", "Product"]
					}
				}
			},
			methods: {

				//region Methods: Protected
				
				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1078);
					this.callParent(arguments);
				},

				/**
				 * Autofills product and bankcardowner from the contract.
				 * @protected
				 */
				onContractChange: function() {
					var contract = this.get("Contract");
					if (contract) {
						this.set("Account", contract.Account);
						this.set("Product", contract.Product);
					} else {
						this.set("Account", null);
						this.set("Product", null);
					}
				},
				/**
				 * Validates fields.
				 * @protected
				 * @returns {boolean} true, if valid, false otherwice.
				 */
				validate: function() {
					var isValid = this.callParent(arguments);
					if (!isValid) {
						return false;
					}
					var ext = this.Ext;
					var openedOn = this.get("OpenedOn");
					var activatedOn = this.get("ActivatedOn");
					if (ext.isDate(openedOn) && ext.isDate(activatedOn)) {
						if (Ext.Date.clearTime(openedOn) > Ext.Date.clearTime(activatedOn)) {
							this.showInformationDialog(this.get("Resources.Strings.OpenOnBiggerThanActivatedOn"));
							return false;
						}
					}
					var status = this.get("Status");
					if (!ext.isEmpty(status) && status.value === BaseFinanceConstants.BankAccountStatus.Closed) {
						var closedOn = this.get("ClosedOn");
						if (ext.isDate(openedOn) && ext.isDate(closedOn) &&
							ext.Date.clearTime(openedOn) > ext.Date.clearTime(closedOn)) {
							this.showInformationDialog(this.get("Resources.Strings.OpenOnBiggerThanCloseOn"));
							return false;
						}
						if (ext.isDate(closedOn) && ext.isDate(activatedOn) &&
							ext.Date.clearTime(activatedOn) > ext.Date.clearTime(closedOn)) {
							this.showInformationDialog(this.get("Resources.Strings.ActivatedOnBiggerThanCloseOn"));
							return false;
						}
					}
					return true;
				}

				//endregion
				
			}
		};
	});
