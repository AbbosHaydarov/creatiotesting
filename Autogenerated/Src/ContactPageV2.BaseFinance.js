define("ContactPageV2", ["BaseFinanceConstants", "BusinessRuleModule",
		"ContactFieldConverterMixin", "css!ClientProfileIconCSS"
	],
	function(baseFinanceConstants, businessRuleModule) {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "AdditionalContactProfileContainer",
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
				"name": "ContactClientProfileIcon",
				"parentName": "AdditionalContactProfileContainer",
				"propertyName": "items",
				"values": {
					"getSrcMethod": "getContactClientProfileIcon",
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
					"markerValue": "ContactClientProfileIcon"
				}
			}, {
				"operation": "move",
				"parentName": "AdditionalContactProfileContainer",
				"propertyName": "items",
				"name": "Type",
				"values": {
					"bindTo": "Type",
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 4,
						"row": 0,
						"colSpan": 20
					}
				}
			}, {
				"operation": "insert",
				"parentName": "AdditionalContactProfileContainer",
				"propertyName": "items",
				"name": "AccountServiceLevel",
				"values": {
					"bindTo": "ServiceLevel",
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 4,
						"row": 1,
						"colSpan": 20
					}
				},
				"markerValue": "Segment"
			}, {
				"operation": "insert",
				"parentName": "AdditionalContactProfileContainer",
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
				"parentName": "AdditionalContactProfileContainer",
				"propertyName": "items",
				"name": "Owner",
				"values": {
					"bindTo": "Owner",
					"layout": {
						"column": 4,
						"row": 3,
						"colSpan": 20
					}
				}
			},
			{
				"operation": "merge",
				"name": "Age",
				"values": {
					"layout": {
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "Language",
				"values": {
					"layout": {
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "INN",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "INN"
				},
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "AdditionInfoTabContainer",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.AdditionInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "AdditionInfoTabGroup",
				"parentName": "AdditionInfoTabContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "Surname",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Surname"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "GivenName",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "GivenName"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "MiddleName",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "MiddleName"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 2
			}, {
				"operation": "insert",
				"name": "BirthDate",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "BirthDate"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 3
			}, {
				"operation": "insert",
				"name": "IsAgreePersonalDataProcessing",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "IsAgreePersonalDataProcessing"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 4
			}, {
				"operation": "move",
				"name": "SalutationType",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "SalutationType"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 5
			}, {
				"operation": "insert",
				"name": "Citizenship",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Citizenship"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 6
			}, {
				"operation": "move",
				"name": "Gender",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Gender"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 7
			}, {
				"operation": "insert",
				"name": "SocialStatus",
				"values": {
					"layout": {
						"column": 12,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "SocialStatus"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 8
			}, {
				"operation": "insert",
				"name": "IsInBlackList",
				"values": {
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "IsInBlackList"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 9
			}, {
				"operation": "insert",
				"name": "BlackListDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 5,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "BlackListDate"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 10
			}, {
				"operation": "insert",
				"name": "BlackListReason",
				"values": {
					"layout": {
						"column": 12,
						"row": 6,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "BlackListReason"
				},
				"parentName": "AdditionInfoTabGroup",
				"propertyName": "items",
				"index": 11
			}, {
				"operation": "remove",
				"name": "Order"
			}, {
				"operation": "remove",
				"name": "Invoice"
			}] /**SCHEMA_DIFF*/ ,
			mixins: {
				ContactFieldConverterMixin: "Terrasoft.ContactFieldConverterMixin"
			},
			attributes: {
				"IsInBlackList": {
					"dependencies": [{
						"columns": ["IsInBlackList"],
						"methodName": "onIsInBlackListChanged"
					}]
				},
				"ContactFieldConverter": {
					"name": "ContactFieldConverter",
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP
				},
				"SplitNamesGenerator": {
					"dependencies": [{
						"columns": ["Name"],
						"methodName": "splitFullName"
					}]
				},
				"Name": {
					"isRequired": true
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
				//region Methods: Private

				/**
				 * Returns true if given date is greater than today's.
				 * @private
				 * @param {Date} date some date.
				 * @return {Boolean} True if given date is greater than today's.
				 */
				isGivenDateGreaterToday: function(date) {
					return this.Ext.isDate(date) && this.Ext.Date.clearTime(date) > this.Ext.Date.clearTime(new Date());
				},

				//endregion

				//region Methods: Protected

				/**
				 * Handler field change event blacklisted.
				 * @protected
				 */
				onIsInBlackListChanged: function() {
					this.set("BlackListDate", this.get("IsInBlackList") ? new Date() : null);
				},

				/**
				 * Validation date of entering into the black list.
				 * @protected
				 * @return {Boolean} Validation result.
				 */
				validateBlackListDate: function() {
					var result = true;
					var blackListDate = this.get("BlackListDate");
					if (this.get("IsInBlackList") && this.isGivenDateGreaterToday(blackListDate)) {
						this.showInformationDialog(this.get("Resources.Strings.NotValidBlackListDateMessage"));
						result = false;
					}
					return result;
				},

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#validate.
				 * @override
				 */
				validate: function() {
					return this.callParent(arguments) && this.validateBlackListDate();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.initContactFieldConverter("Name", this.fillContactNameFields, this);
				},

				/**
				 * Calls mixin method to split full name, if this is an Add mode.
				 * @protected
				 */
				fillContactNameFields: function() {
					if (this.isAddMode()) {
						this.splitFullName();
					}
				},

				//endregion

				//region Methods: Public

				/**
				 * Returns url for ContactClientProfileIcon image in AdditionalAccountProfileContainer.
				 */
				getContactClientProfileIcon: function() {
					var contactClientProfileIconImage = this.get("Resources.Images.ContactClientProfileIcon");
					return this.Terrasoft.ImageUrlBuilder.getUrl(contactClientProfileIconImage);
				}

				//endregion

			}
		};
	});
