define("ContractPageV2", ["ContractPageV2Resources", "BusinessRuleModule", "BaseFinanceConstants"],
	function(resources, BusinessRuleModule, BaseFinanceConstants) {
		return {
			entitySchemaName: "Contract",
			details: /**SCHEMA_DETAILS*/ {
				SpecificationInContract: {
					schemaName: "ContractSpecificationDetailV2",
					entitySchemaName: "SpecificationInContract",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contract"
					},
					subscriber: function() {
						this.set("IsSpecificationCleared", false);
					}
				},
				"SubordinateContracts": {
					"schemaName": "ContractDetailV2",
					"entitySchemaName": "Contract",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Parent"
					},
					defaultValues: {
						Account: {
							"masterColumn": "Account"
						},
						Contact: {
							"masterColumn": "Contact"
						},
						CustomerBillingInfo: {
							"masterColumn": "CustomerBillingInfo"
						},
						OurCompany: {
							"masterColumn": "OurCompany"
						},
						SupplierBillingInfo: {
							"masterColumn": "SupplierBillingInfo"
						},
						Product: {
							"masterColumn": "Product"
						},
						Type: {
							"masterColumn": "DefaultType"
						},
						LockType: {
							"value": true
						}
					}
				},
				"Emails": {
					"schemaName": "EmailDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Contract"
					},
					"defaultValues": {
						"Contract": {
							"masterColumn": "Id"
						},
						"Account": {
							"masterColumn": "Account"
						},
						"Contact": {
							"masterColumn": "Contact"
						}
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"name": "Number",
				"values": {
					"tabIndex": 2
				}
			}, {
				"operation": "merge",
				"name": "Type",
				"values": {
					"enabled": {
						"bindTo": "canTypeChange"
					},
					"tabIndex": 3
				},
				"parentName": "Header",
				"propertyName": "items"
			}, {
				"operation": "merge",
				"name": "State",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"tabIndex": 4
				}
			}, {
				"operation": "merge",
				"name": "Owner",
				"values": {
					"tabIndex": 6
				}
			}, {
				"operation": "merge",
				"name": "StartDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"tabIndex": 8
				}
			}, {
				"operation": "insert",
				"name": "SigningDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"tabIndex": 7
				},
				"parentName": "Header",
				"propertyName": "items"
			}, {
				"operation": "merge",
				"name": "EndDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					},
					"tabIndex": 9
				}
			}, {
				"operation": "merge",
				"name": "Account",
				"values": {
					"tabIndex": 10
				}
			}, {
				"operation": "merge",
				"name": "CustomerBillingInfo",
				"values": {
					"tabIndex": 11
				}
			}, {
				"operation": "merge",
				"name": "Contact",
				"values": {
					"tabIndex": 12
				}
			}, {
				"operation": "merge",
				"name": "OurCompany",
				"values": {
					"tabIndex": 14
				}
			}, {
				"operation": "merge",
				"name": "SupplierBillingInfo",
				"values": {
					"tabIndex": 15
				}
			}, {
				"operation": "merge",
				"name": "Parent",
				"values": {
					"enabled": {
						"bindTo": "CheckSlave"
					},
					"tabIndex": 0
				},
				"parentName": "ContractConnectionsBlock",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Product",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					},
					"tabIndex": 5
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "ContractInfoTabContainer",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.ContractInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ContractInfoTabContainer",
				"propertyName": "items",
				"name": "SpecificationInContract",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}] /**SCHEMA_DIFF*/ ,
			attributes: {
				"ProductChange": {
					name: "Product",
					dependencies: [{
						columns: ["Product"],
						methodName: "onProductChanged"
					}]
				},
				"Parent": {
					"dependencies": [{
						"columns": ["Type"],
						"methodName": "parentChanged"
					}]
				},
				"Type": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						"columns": ["IsSlave"]
					}
				},
				"DefaultType": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": Terrasoft.DataValueType.LOOKUP
				},
				"CheckSlave": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN
				},
				"LockType": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN
				},
				"State": {
					"name": "State",
					"dependencies": [{
						"columns": ["State"],
						"methodName": "stateChanged"
					}]
				}
			},
			methods: {

				canTypeChange: function() {
					var type = this.get("Type");
					if (this.get("LockType")) {
						return false;
					}
					if (!this.Ext.isEmpty(type)) {
						var isSlave = type.IsSlave;
						return !((this.isEditMode() || this.isCopyMode()) && !isSlave);
					}
					return true;
				},

				parentChanged: function() {
					var type = this.get("Type");
					if (!this.Ext.isEmpty(type)) {
						if (!type.IsSlave) {
							this.set("CheckSlave", false);
							this.clearParent();
						} else {
							this.set("CheckSlave", true);
						}
					}
				},

				onEntityInitialized: function() {
					this.set("OldProduct", this.get("Product"));
					this.set("DefaultType", {
						value: BaseFinanceConstants.ContractType.SubAgreement,
						displayValue: ""
					});
					this.callParent(arguments);
					if (this.isCopyMode() && this.get("Type")) {
						this.loadLookupDisplayValueAsync("Type", this.get("Type").value,
							this.parentChanged);
					} else {
						this.parentChanged();
					}
				},

				save: function() {
					this.set("OldProduct", this.get("Product"));
					this.callParent(arguments);
				},

				/**
				 * Product field change event handler.
				 * @protected
				 */
				onProductChanged: function() {
					var oldProduct = this.get("OldProduct");
					var product = this.get("Product");
					this.changeProduct(product, oldProduct);
				},

				/**
				 * Product field change.
				 * @protected
				 * @param {Object} product Current product.
				 * @param {Object} oldProduct Previous product.
				 */
				changeProduct: function(product, oldProduct) {
					if (!Ext.isEmpty(oldProduct) && !Ext.isEmpty(product) && oldProduct.value !== product.value) {
						if (!this.get("IsSpecificationCleared")) {
							var message = this.get("Resources.Strings.ChangeProductWarningMessage");
							var handler = function(returnCode) {
								if (returnCode === Terrasoft.MessageBoxButtons.YES.returnCode) {
									var deleteQuery = this.Ext.create("Terrasoft.DeleteQuery", {
										rootSchemaName: "SpecificationInContract"
									});
									deleteQuery.filters.add("IdFilter", deleteQuery.createColumnFilterWithParameter(
										this.Terrasoft.ComparisonType.EQUAL, "Contract", this.get("Id")));
									deleteQuery.execute(function() {
										this.set("IsSpecificationCleared", true);
										this.updateDetail({
											detail: "SpecificationInContract"
										});
									}, this);
									this.set("OldProduct", product);
									var args = {
										isSilent: true,
										messageTags: [this.sandbox.id]
									};
									this.save(args);
								} else {
									this.set("IsEntityInitialized", false);
									this.set("Product", oldProduct);
									this.setValidationInfo("Product", true);
									this.set("IsEntityInitialized", true);
									delete this.changedValues.Product;
									this.updateButtonsVisibility(this.isChanged());
									this.set("IsSpecificationCleared", false);
								}
							};
							this.showConfirmationDialog(message, handler, ["yes", "no"]);
						}
					}
				},

				validateEndDate: function(column) {
					if (!this.get("IsEntityInitialized")) {
						this.cleanValidationInfo();
						return {};
					}
					var invalidMessage = "";
					var signingDate = this.get("SigningDate");
					var startDate = this.get("StartDate");
					if (this.Ext.isDate(column) && this.Ext.isDate(signingDate) &&
						this.Ext.Date.clearTime(signingDate) > this.Ext.Date.clearTime(column)) {
						invalidMessage = this.get("Resources.Strings.DueDateLowerSigningDate");
					} else {
						if (this.Ext.isDate(column) && this.Ext.isDate(startDate) &&
							this.Ext.Date.clearTime(startDate) > this.Ext.Date.clearTime(column)) {
							invalidMessage = this.get("Resources.Strings.DueDateLowerStartDate");
						}
					}
					return {
						fullInvalidMessage: invalidMessage,
						invalidMessage: invalidMessage
					};
				},

				validateStartDate: function(column) {
					if (!this.get("IsEntityInitialized")) {
						this.cleanValidationInfo();
						return {};
					}
					var invalidMessage = "";
					var signingDate = this.get("SigningDate");
					if (this.Ext.isDate(column) && this.Ext.isDate(signingDate) &&
						this.Ext.Date.clearTime(signingDate) > this.Ext.Date.clearTime(column)) {
						invalidMessage = this.get("Resources.Strings.StartDateLowerSigningDate");
					}
					return {
						fullInvalidMessage: invalidMessage,
						invalidMessage: invalidMessage
					};
				},

				cleanValidationInfo: function() {
					this.setValidationInfo("SigningDate", true, "");
					this.setValidationInfo("StartDate", true, "");
				},

				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("StartDate", this.validateStartDate);
				},

				stateChanged: function() {
					var state = this.get("State");
					if (state && state.value === BaseFinanceConstants.ContractState.Signed) {
						var signingDate = this.get("SigningDate");
						var startDate = this.get("StartDate");
						var today = Ext.Date.clearTime(new Date());
						if (Ext.isEmpty(signingDate)) {
							this.set("SigningDate", today);
						}
						if (Ext.isEmpty(startDate)) {
							this.set("StartDate", today);
						}
					}
				}
			},
			rules: {
				"OurCompany": {
					"OurCompanyFiltrationByOurBank": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						baseAttributePatch: "Type",
						type: BusinessRuleModule.enums.ValueType.CONSTANT,
						value: BaseFinanceConstants.AccountType.OurBank
					}
				},
				"Parent": {
					"FiltrationParentByAccount": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "Account",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Account"
					},
					"FiltrationParentBySupplier": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "OurCompany",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "OurCompany"
					},
					"FiltrationParentByParent": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": false,
						"baseAttributePatch": "Id",
						"comparisonType": this.Terrasoft.ComparisonType.NOT_EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Id"
					},
					"FiltrationParentByIsSlave": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "Type.IsSlave",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.CONSTANT,
						"value": false
					}
				},
				"SigningDate": {
					"RequiredByState": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "State"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": BaseFinanceConstants.ContractState.Signed
							}
						}]
					}
				},
				"StartDate": {
					"RequiredByState": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "State"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": BaseFinanceConstants.ContractState.Signed
							}
						}]
					}
				}
			}
		};
	}
);
