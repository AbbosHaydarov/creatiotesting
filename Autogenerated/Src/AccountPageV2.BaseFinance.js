define("AccountPageV2", ["AccountPageV2Resources", "BusinessRuleModule", "BaseFinanceConstants",
		"css!ClientProfileIconCSS"],
	function(resources, businessRuleModule, baseFinanceConstants) {
		return {
			entitySchemaName: "Account",
			details: /**SCHEMA_DETAILS*/ {
				"ExternalBankAccount": {
					"schemaName": "ExternalBankAccountDetailV2",
					"filter": {
						"detailColumn": "Account",
						"masterColumn": "Id"
					},
					"useRelationship": true
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "AdditionalAccountProfileContainer",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": [],
					"classes": {
						"wrapClassName": ["profile-container"]
					}
				},
				"index": 2
			}, {
				"operation": "insert",
				"name": "AccountClientProfileIcon",
				"parentName": "AdditionalAccountProfileContainer",
				"propertyName": "items",
				"values": {
					"getSrcMethod": "getAccountClientProfileIcon",
					"onPhotoChange": Terrasoft.emptyFn,
					"readonly": true,
					"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
					"classes": {
						"wrapClass": ["client-profile-icon"]
					},
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 4
					},
					"markerValue": "AccountClientProfileIcon"
				}
			}, {
				"operation": "move",
				"name": "AccountType",
				"parentName": "AdditionalAccountProfileContainer",
				"propertyName": "items"
			}, {
				"operation": "merge",
				"name": "AccountType",
				"values": {
					"layout": {
						"column": 4,
						"row": 0,
						"colSpan": 20
					}
				}
			}, {
				"operation": "move",
				"name": "NewAccountCategory",
				"parentName": "AdditionalAccountProfileContainer",
				"propertyName": "items"
			}, {
				"operation": "merge",
				"name": "NewAccountCategory",
				"values": {
					"layout": {
						"column": 4,
						"row": 1,
						"colSpan": 20
					}
				}
			}, {
				"operation": "insert",
				"parentName": "AdditionalAccountProfileContainer",
				"propertyName": "items",
				"name": "AccountBranch",
				"values": {
					"bindTo": "Branch",
					"layout": {
						"column": 4,
						"row": 2,
						"colSpan": 20
					}
				}
			}, {
				"operation": "move",
				"name": "AccountOwner",
				"parentName": "AdditionalAccountProfileContainer",
				"propertyName": "items"
			}, {
				"operation": "merge",
				"name": "AccountOwner",
				"values": {
					"layout": {
						"column": 4,
						"row": 3,
						"colSpan": 20
					}
				}
			}, {
				"operation": "merge",
				"name": "AccountPhone",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 24
					}
				}
			}, {
				"operation": "merge",
				"name": "AccountWeb",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					}
				}
			}, {
				"operation": "merge",
				"name": "AccountCompletenessContainer",
				"values": {
					"layout": {
						"column": 0,
						"row": 8,
						"colSpan": 24
					}
				}
			}, {
				"operation": "move",
				"parentName": "CategoriesControlGroupContainer",
				"propertyName": "items",
				"name": "AccountIndustry",
				"values": {
					"bindTo": "Industry",
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "merge",
				"name": "AlternativeName",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "merge",
				"name": "Code",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "merge",
				"name": "AnnualRevenue",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "merge",
				"name": "EmployeesNumber",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "merge",
				"name": "Ownership",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "insert",
				"name": "INN",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "INN",
					"textSize": 0,
					"contentType": 1,
					"labelConfig": {
						"visible": true
					},
					"enabled": true
				},
				"parentName": "AccountPageGeneralInfoBlock",
				"propertyName": "items",
				"index": 3
			}, {
				"operation": "insert",
				"name": "IsNotResident",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "IsNotResident",
					"textSize": 0,
					"labelConfig": {
						"visible": true
					},
					"enabled": true
				},
				"parentName": "AccountPageGeneralInfoBlock",
				"propertyName": "items",
				"index": 4
			}, {
				"operation": "insert",
				"name": "IsLiquidated",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "IsLiquidated",
					"textSize": 0,
					"labelConfig": {
						"visible": true
					},
					"enabled": true
				},
				"parentName": "AccountPageGeneralInfoBlock",
				"propertyName": "items",
				"index": 5
			}, {
				"operation": "insert",
				"name": "IsInBlackList",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "IsInBlackList",
					"textSize": 0,
					"labelConfig": {
						"visible": true
					},
					"enabled": true
				},
				"parentName": "AccountPageGeneralInfoBlock",
				"propertyName": "items",
				"index": 6
			}, {
				"operation": "insert",
				"name": "LiquidationDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "LiquidationDate",
					"textSize": 0,
					"labelConfig": {
						"visible": true
					},
					"enabled": true
				},
				"parentName": "AccountPageGeneralInfoBlock",
				"propertyName": "items",
				"index": 7
			}, {
				"operation": "insert",
				"name": "BlackListReason",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "BlackListReason",
					"caption": {
						"bindTo": "Resources.Strings.BlackListReasonCaption"
					},
					"textSize": 0,
					"contentType": 1,
					"labelConfig": {
						"visible": true
					},
					"enabled": true
				},
				"parentName": "AccountPageGeneralInfoBlock",
				"propertyName": "items",
				"index": 8
			}, {
				"operation": "insert",
				"name": "BlackListDate",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "BlackListDate",
					"caption": {
						"bindTo": "Resources.Strings.BlackListDateCaption"
					},
					"textSize": 0,
					"labelConfig": {
						"visible": true
					},
					"enabled": true
				},
				"parentName": "AccountPageGeneralInfoBlock",
				"propertyName": "items",
				"index": 9
			}, {
				"operation": "insert",
				"name": "OwnershipForm",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					},
					"bindTo": "OwnershipForm",
					"labelConfig": {
						"visible": true
					},
					"textSize": 0,
					"enabled": true,
					"contentType": Terrasoft.ContentType.ENUM
				},
				"parentName": "CategoriesControlGroupContainer",
				"propertyName": "items",
				"index": 10
			}, {
				"operation": "insert",
				"name": "ExternalBankAccount",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "HistoryTabContainer",
				"propertyName": "items",
				"index": 4
			}, {
				"operation": "remove",
				"name": "Order"
			}, {
				"operation": "remove",
				"name": "Invoice"
			}] /**SCHEMA_DIFF*/ ,
			attributes: {
				"IsLiquidated": {
					"dependencies": [{
						"columns": ["IsLiquidated"],
						"methodName": "onIsLiquidatedChanged"
					}]
				},
				"IsInBlackList": {
					"dependencies": [{
						"columns": ["IsInBlackList"],
						"methodName": "onIsInBlackListChanged"
					}]
				}
			},
			rules: {
				"Branch": {
					"BranchFiltrationByOurBank": {
						"ruleType": businessRuleModule.enums.RuleType.FILTRATION,
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"baseAttributePatch": "Type",
						"type": businessRuleModule.enums.ValueType.CONSTANT,
						"value": baseFinanceConstants.AccountType.OurBank
					}
				},
				"LiquidationDate": {
					"VisibleLiquidationDate": {
						"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": businessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsLiquidated"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": businessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"BlackListDate": {
					"VisibleBlackListDate": {
						"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": businessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsInBlackList"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": businessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"BlackListReason": {
					"VisibleBlackListReason": {
						"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": businessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsInBlackList"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": businessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				}
			},
			methods: {

				//region Methods: Protected

				/**
				 * IsLiquidated change handler.
				 * @protected
				 */
				onIsLiquidatedChanged: function() {
					this.set("LiquidationDate", this.get("IsLiquidated") ? new Date() : null);
				},

				/**
				 * IsInBlackList change handler.
				 * @protected
				 */
				onIsInBlackListChanged: function() {
					this.set("BlackListDate", this.get("IsInBlackList") ? new Date() : null);
				},

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#validate.
				 * @override
				 */
				validate: function() {
					var isValid = this.callParent(arguments);
					if (!isValid) {
						return false;
					}
					if ((this.get("IsLiquidated")) && (this.get("LiquidationDate") > Date.now())) {
						this.showInformationDialog(this.get("Resources.Strings.NotValidLiquidationDateMessage"));
						return false;
					}
					if ((this.get("IsInBlackList")) && (this.get("BlackListDate") > Date.now())) {
						this.showInformationDialog(this.get("Resources.Strings.NotValidBlackListDateMessage"));
						return false;
					}
					return true;
				},

				//endregion

				//region Methods: Public

				/**
				 * Returns url for AccountClientProfileIcon image in AdditionalAccountProfileContainer.
				 */
				getAccountClientProfileIcon: function() {
					var accountClientProfileIconImage = this.get("Resources.Images.AccountClientProfileIcon");
					return this.Terrasoft.ImageUrlBuilder.getUrl(accountClientProfileIconImage);
				}

				//endregion

			}
		};
	});
