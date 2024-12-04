define("BankCardPageV2", ["terrasoft", "BankCardPageV2Resources", "GeneralDetails",
		"BaseFinanceConstants", "BusinessRuleModule"
	],
	function(Terrasoft, resources, GeneralDetails, BaseFinanceConstants, BusinessRuleModule) {
		return {
			entitySchemaName: "BankCard",
			details: /**SCHEMA_DETAILS*/ {
				Files: {
					schemaName: "FileDetailV2",
					entitySchemaName: "BankCardFile",
					filter: {
						masterColumn: "Id",
						detailColumn: "BankCard"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "Number",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					},
					"bindTo": "Number",
					"textSize": 0,
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"labelConfig": {
						"visible": true
					},
					"enabled": true,
					"tabIndex": 2
				},
				"parentName": "Header",
				"propertyName": "items"
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
				"name": "BankCardOwner",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					},
					"bindTo": "BankCardOwner",
					"textSize": 0,
					"contentType": Terrasoft.ContentType.LOOKUP,
					"labelConfig": {
						"visible": true
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Product",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					},
					"bindTo": "Product",
					"textSize": 0,
					"contentType": Terrasoft.ContentType.LOOKUP,
					"labelConfig": {
						"visible": true
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
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
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"name": "BankCardPageGeneralBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "BankCardType",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "BankCardType",
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 4
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "BankCardPaymentSystem",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "BankCardPaymentSystem",
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 5
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "BankCardCategory",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "BankCardCategory",
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 6
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "Holder",
				"values": {
					"contentType": Terrasoft.ContentType.LOOKUP,
					"bindTo": "Holder",
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 7
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "IsPrimary",
				"values": {
					"bindTo": "IsPrimary",
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 8
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "IsMulticurrency",
				"values": {
					"bindTo": "IsMulticurrency",
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 9
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "Branch",
				"values": {
					"contentType": Terrasoft.ContentType.LOOKUP,
					"bindTo": "Branch",
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 10
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardPageGeneralBlock",
				"propertyName": "items",
				"name": "Division",
				"values": {
					"contentType": Terrasoft.ContentType.LOOKUP,
					"bindTo": "Division",
					"layout": {
						"column": 12,
						"row": 3,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 11
				}
			}, {
				"operation": "insert",
				"name": "StatusGroup",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"caption": {
						"bindTo": "Resources.Strings.StatusGroupCaption"
					},
					"items": [],
					"controlConfig": {
						"collapsed": false
					}
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "StatusGroupGridLayout",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				},
				"parentName": "StatusGroup",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"parentName": "StatusGroupGridLayout",
				"propertyName": "items",
				"name": "StartDate",
				"values": {
					"bindTo": "StartDate",
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 12
				}
			}, {
				"operation": "insert",
				"parentName": "StatusGroupGridLayout",
				"propertyName": "items",
				"name": "EndDate",
				"values": {
					"bindTo": "EndDate",
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 13
				}
			}, {
				"operation": "insert",
				"parentName": "StatusGroupGridLayout",
				"propertyName": "items",
				"name": "BankCardStatus",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"bindTo": "BankCardStatus",
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					},
					"enabled": true,
					"tabIndex": 14
				}
			}, {
				"operation": "insert",
				"name": "NotesTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.NotesTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "NotesTab",
				"name": "BankCardNotesTabContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "BankCardNotesTabContainer",
				"name": "BankCardNotesTabControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"controlConfig": {
						"collapsed": false
					}
				}
			}, {
				"operation": "insert",
				"parentName": "NotesTab",
				"propertyName": "items",
				"name": "Files",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"name": "NotesControlGroup",
				"parentName": "NotesTab",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"caption": {
						"bindTo": "Resources.Strings.NotesGroupCaption"
					},
					"controlConfig": {
						"collapsed": false
					}
				}
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
			attributes: {
				"BankCardOwner": {
					name: "BankCardOwner",
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
				},
				"BankCardPaymentSystem": {
					name: "BankCardPaymentSystem",
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					dependencies: [{
						columns: ["BankCardPaymentSystem"],
						methodName: "OnBankCardPaymentSystemChanged"
					}]
				},
				"Branch": {
					lookupListConfig: {
						filter: function() {
							return Terrasoft.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL, "Type", BaseFinanceConstants.AccountType.OurBank);
						}
					}
				},
				"Division": {
					lookupListConfig: {
						filter: function() {
							return Terrasoft.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL, "Type", BaseFinanceConstants.AccountType.OurBank);
						}
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
					this.set("ContextHelpId", 1076);
					this.callParent(arguments);
				},

				/**
				 * Autofills product and bankcardowner from the contract.
				 * @protected
				 */
				onContractChange: function() {
					var contract = this.get("Contract");
					if (contract) {
						this.set("BankCardOwner", contract.Account);
						this.set("Product", contract.Product);
					} else {
						this.set("BankCardOwner", null);
						this.set("Product", null);
					}
				},
				/**
				 * Clears field "Category" on clearing field BankCardPaymentSystem.
				 * @protected
				 * @param {Object} newValue New value in field BankCardPaymentSystem.
				 */
				OnBankCardPaymentSystemChanged: function(newValue) {
					if (!newValue) {
						this.set("BankCardCategory", null);
					}
					this.setValidationInfo("BankCardCategory", true, "");
				},
				/**
				 * Checks if EndDate is bigger than the StartDate.
				 * @overridden
				 * @return {Boolean} Check result.
				 */
				validate: function() {
					var isValid = this.callParent(arguments);
					if (!isValid) {
						return false;
					}
					var ext = this.Ext;
					var startDate = this.get("StartDate");
					var endDate = this.get("EndDate");
					if (ext.isDate(startDate) && ext.isDate(endDate)) {
						if (ext.Date.clearTime(startDate) >= ext.Date.clearTime(endDate)) {
							this.showInformationDialog(this.get("Resources.Strings.NotValidEndDateMessage"));
							return false;
						}
					}
					return true;
				}

				//endregion

			},
			rules: {
				"BankCardCategory": {
					"FiltrationCategoryByPaymentSystem": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						autocomplete: true,
						autoClean: true,
						baseAttributePatch: "BankCardPaymentSystem",
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						attribute: "BankCardPaymentSystem"
					}
				}
			}
		};
	});
