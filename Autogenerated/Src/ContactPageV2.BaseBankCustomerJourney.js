define("ContactPageV2", ["ContactPageV2Resources", "BusinessRuleModule", "BaseFinanceConstants", "ContactCareer"],
	function(resources, BusinessRuleModule, BaseFinanceConstants, ContactCareer) {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/ {
				"RegDocument": {
					"schemaName": "RegDocumentDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Contact"
					},
					"defaultValues": {
						"Citizenship": {
							"masterColumn": "Citizenship"
						}
					}
				},
				"BankAccountDetailV2": {
					"schemaName": "BankAccountDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Contact"
					},
					"defaultValues": {
						"Citizenship": {
							"masterColumn": "Citizenship"
						}
					}
				}
			} /**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "BankAccountDetailV2",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					}
				},{
					"operation": "move",
					"name": "BirthDate",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "BirthDate",
						"caption": {
							"bindTo": "Resources.Strings.BirthDateCaption"
						}
					},
					"parentName": "ContactGeneralInfoBlock",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "move",
					"name": "Citizenship",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "ContactGeneralInfoBlock",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "insert",
					"name": "ClientType",
					"parentName": "ContactGeneralInfoBlock",
					"propertyName": "items",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						}
					}
				}, {
					"operation": "merge",
					"name": "INN",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "INN",
						"caption": {
							"bindTo": "Resources.Strings.INNCaption"
						}
					},
					"parentName": "ContactGeneralInfoBlock",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "insert",
					"name": "PlaceOfBirth",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"caption": {
							"bindTo": "Resources.Strings.PlaceOfBirthCaption"
						}
					},
					"parentName": "ContactGeneralInfoBlock",
					"propertyName": "items",
					"index": 3
				}, {
					"operation": "insert",
					"name": "ContactPageV26Tab",
					"values": {
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.ContactPageV26TabCaption"
						}
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1
				}, {
					"operation": "insert",
					"name": "group51e8654c265f",
					"values": {
						"itemType": 15,
						"caption": {
							"bindTo": "Resources.Strings.group51e8654c265fCaption"
						},
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "ContactPageV26Tab",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "insert",
					"name": "group51e8654c265f_gridLayout",
					"values": {
						"itemType": 0,
						"items": []
					},
					"parentName": "group51e8654c265f",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "insert",
					"name": "IsAgreePersonalDataProcessing",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"caption": {
							"bindTo": "Resources.Strings.IsAgreePersonalDataProcessingCaption"
						}
					},
					"parentName": "group51e8654c265f_gridLayout",
					"propertyName": "items"
				}, {
					"operation": "insert",
					"name": "IsAgreePrivateDataVerification",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "group51e8654c265f_gridLayout",
					"propertyName": "items"
				}, {
					"operation": "move",
					"name": "SalutationType",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"caption": {
							"bindTo": "Resources.Strings.SalutationTypeCaption"
						}
					},
					"parentName": "ContactGeneralInfoBlock",
					"propertyName": "items"
				}, {
					"operation": "merge",
					"name": "Language",
					"values": {
						"layout": {
							"column": 12,
							"row": 3
						}
					}
				}, {
					"operation": "merge",
					"name": "Age",
					"values": {
						"layout": {
							"column": 0,
							"row": 4
						}
					}
				}, {
					"operation": "insert",
					"name": "Education",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Education",
						"caption": {
							"bindTo": "Resources.Strings.EducationCaption"
						},
						"enabled": true
					},
					"parentName": "group51e8654c265f_gridLayout",
					"propertyName": "items",
					"index": 2
				}, {
					"operation": "insert",
					"name": "Gender",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "ContactGeneralInfoBlock",
					"propertyName": "items",
					"index": 3
				}, {
					"operation": "insert",
					"name": "SocialStatus",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"caption": {
							"bindTo": "Resources.Strings.SocialStatusCaption"
						}
					},
					"parentName": "group51e8654c265f_gridLayout",
					"propertyName": "items"
				}, {
					"operation": "insert",
					"name": "groupb6be9b36cd24",
					"values": {
						"itemType": 15,
						"caption": {
							"bindTo": "Resources.Strings.groupb6be9b36cd24Caption"
						},
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "ContactPageV26Tab",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "insert",
					"name": "groupb6be9b36cd24_gridLayout",
					"values": {
						"itemType": 0,
						"items": []
					},
					"parentName": "groupb6be9b36cd24",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "insert",
					"name": "MaritalStatus",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "MaritalStatus",
						"caption": {
							"bindTo": "Resources.Strings.MaritalStatusCaption"
						},
						"enabled": true
					},
					"parentName": "groupb6be9b36cd24_gridLayout",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "insert",
					"name": "NumberOfFamilyMembers",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "NumberOfFamilyMembers",
						"caption": {
							"bindTo": "Resources.Strings.NumberOfFamilyMembersCaption"
						},
						"enabled": true
					},
					"parentName": "groupb6be9b36cd24_gridLayout",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "insert",
					"name": "Spouse",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Spouse",
						"caption": {
							"bindTo": "Resources.Strings.SpouseCaption"
						},
						"enabled": true
					},
					"parentName": "groupb6be9b36cd24_gridLayout",
					"propertyName": "items",
					"index": 2
				}, {
					"operation": "insert",
					"name": "NumberOfChildren",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "NumberOfChildren",
						"caption": {
							"bindTo": "Resources.Strings.NumberOfChildrenCaption"
						},
						"enabled": true
					},
					"parentName": "groupb6be9b36cd24_gridLayout",
					"propertyName": "items",
					"index": 3
				}, {
					"operation": "insert",
					"name": "grouped673b60b9fd",
					"values": {
						"itemType": 15,
						"caption": {
							"bindTo": "Resources.Strings.grouped673b60b9fdCaption"
						},
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "ContactPageV26Tab",
					"propertyName": "items",
					"index": 2
				}, {
					"operation": "insert",
					"name": "grouped673b60b9fd_gridLayout",
					"values": {
						"itemType": 0,
						"items": []
					},
					"parentName": "grouped673b60b9fd",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "insert",
					"name": "IsInBlackList",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "IsInBlackList",
						"caption": {
							"bindTo": "Resources.Strings.IsInBlackListCaption"
						},
						"enabled": true
					},
					"parentName": "grouped673b60b9fd_gridLayout",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "insert",
					"name": "BlackListDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "BlackListDate",
						"caption": {
							"bindTo": "Resources.Strings.BlackListDateCaption"
						},
						"enabled": true
					},
					"parentName": "grouped673b60b9fd_gridLayout",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "insert",
					"name": "BlackListReason",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "BlackListReason",
						"caption": {
							"bindTo": "Resources.Strings.BlackListReasonCaption"
						},
						"enabled": true
					},
					"parentName": "grouped673b60b9fd_gridLayout",
					"propertyName": "items",
					"index": 2
				}, {
					"operation": "move",
					"name": "JobTabContainer",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 3
				}, {
					"operation": "move",
					"name": "HistoryTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 4
				}, {
					"operation": "move",
					"name": "NotesAndFilesTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 5
				}, {
					"operation": "merge",
					"name": "DecisionRole",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						}
					}
				}, {
					"operation": "move",
					"name": "DecisionRole",
					"parentName": "JobInformationBlock",
					"propertyName": "items",
					"index": 0
				}, {
					"operation": "merge",
					"name": "JobTitle",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"rowSpan": 1,
							"colSpan": 12
						}
					}
				}, {
					"operation": "move",
					"name": "JobTitle",
					"parentName": "JobInformationBlock",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "merge",
					"name": "Job",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"rowSpan": 1,
							"colSpan": 12
						}
					}
				}, {
					"operation": "merge",
					"name": "Department",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"rowSpan": 1,
							"colSpan": 12
						}
					}
				}, {
					"operation": "insert",
					"name": "EmploymentType",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "EmploymentType",
						"caption": {
							"bindTo": "Resources.Strings.EmploymentTypeCaption"
						},
						"enabled": true
					},
					"parentName": "JobInformationBlock",
					"propertyName": "items",
					"index": 4
				}, {
					"operation": "insert",
					"name": "Account2",
					"values": {
						"markerValue": "Account",
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Account",
						"caption": {
							"bindTo": "Resources.Strings.AccountCaption"
						},
						"enabled": true
					},
					"parentName": "JobInformationBlock",
					"propertyName": "items",
					"index": 5
				}, {
					"operation": "remove",
					"name": "Account"
				}, {
					"operation": "remove",
					"name": "Confirmed"
				}, {
					"operation": "insert",
					"name": "RegDocument",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "remove",
					"name": "AdditionInfoTabContainer"
				}
			] /**SCHEMA_DIFF*/,
			attributes: {
				"IsInBlackList": {
					dependencies: [{
						columns: ["IsInBlackList"],
						methodName: "onIsInBlackListChanged"
					}]
				}
			},
			methods: {
				/**
				 * Handles "IsInBlackList" field change event.
				 * @protected
				 */
				onIsInBlackListChanged: function() {
					this.set("BlackListDate", this.get("IsInBlackList") ? new Date() : null);
				},

				/**
				 * Fields validation.
				 * @protected
				 */
				validate: function() {
					var isValid = this.callParent(arguments);
					if (!isValid) {
						return false;
					}
					if (!this.validateBlackListDate()) {
						return false;
					}
					if (!this.validateNumberOfChildren()) {
						return false;
					}
					return true;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#setValidationConfig
				 * @override
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("NumberOfChildren", this.validateNumberOfChildrenMoreThenZero);
					this.addColumnValidator("NumberOfFamilyMembers", this.validateNumberOfFamilyMembers);
				},

				/**
				 * "BlackListDate" field validation.
				 * @protected
				 * @return {Boolean} Validation result.
				 */
				validateBlackListDate: function() {
					if ((this.get("IsInBlackList")) && (this.get("BlackListDate") > Date.now())) {
						this.showInformationDialog(this.get("Resources.Strings.NotValidBlackListDateMessage"));
						return false;
					}
					return true;
				},

				/**
				 * "NumberOfFamilyMembers" field validation.
				 * @param {Object} columnValue Value of column.
				 * @protected
				 * @return {Object} Validation object.
				 */
				validateNumberOfFamilyMembers: function(columnValue) {
					var invalidMessage;
					if (columnValue < 0) {
						invalidMessage = this.get("Resources.Strings.NumberMustBeGreaterThenZeroMessage");
					}
					return {
						fullInvalidMessage: invalidMessage,
						invalidMessage: invalidMessage
					};
				},

				/**
				 * Validation that the number of children is greater than zero.
				 * @param {Object} columnValue Value of column.
				 * @protected
				 * @return {Object} Validation object.
				 */
				validateNumberOfChildrenMoreThenZero: function(columnValue) {
					var invalidMessage;
					if (columnValue < 0) {
						invalidMessage = this.get("Resources.Strings.NumberMustBeGreaterThenZeroMessage");
					}
					return {
						fullInvalidMessage: invalidMessage,
						invalidMessage: invalidMessage
					};
				},

				/**
				 * Children count validation.
				 * @protected
				 * @return {Boolean} Validation result.
				 */
				validateNumberOfChildren: function() {
					var numberOfChildren = this.get("NumberOfChildren") || 0;
					var numberOfFamilyMembers = this.get("NumberOfFamilyMembers") || 0;
					if (numberOfChildren !== 0 && numberOfChildren >= numberOfFamilyMembers) {
						this.showInformationDialog(this.get("Resources.Strings.NotValidNumberOfChildrenMessage"));
						return false;
					}
					return true;
				},

				/**
				 * @inheritdoc Terrasoft.ContactPagev2#getInsertContactCareerQuery
				 * @override
				 */
				getInsertContactCareerQuery: function() {
					var insert = this.Ext.create("Terrasoft.InsertQuery", {
						rootSchema: ContactCareer
					});
					var account = this.get("Account");
					if (!this.Ext.isEmpty(account)) {
						insert.setParameterValue("Account", account.value);
					}
					var job = this.get("Job");
					if (!this.Ext.isEmpty(job)) {
						insert.setParameterValue("Job", job.value);
					}
					var jobTitle = this.get("JobTitle");
					if (!this.Ext.isEmpty(jobTitle)) {
						insert.setParameterValue("JobTitle", jobTitle);
					}
					var decisionRole = this.get("DecisionRole");
					if (!this.Ext.isEmpty(decisionRole)) {
						insert.setParameterValue("DecisionRole", decisionRole.value);
					}
					var department = this.get("Department");
					if (!this.Ext.isEmpty(department)) {
						insert.setParameterValue("Department", department.value);
					}
					var employmentType = this.get("EmploymentType");
					if (!this.Ext.isEmpty(employmentType)) {
						insert.setParameterValue("EmploymentType", employmentType.value);
					}
					insert.setParameterValue("Contact", this.get("Id"));
					insert.setParameterValue("Current", true);
					insert.setParameterValue("Primary", true);
					return insert;
				},

				/**
				 * @inheritdoc Terrasoft.ContactPagev2#getUpdateContactCareerQuery
				 * @override
				 */
				getUpdateContactCareerQuery: function(notUpdate) {
					var update = this.Ext.create("Terrasoft.UpdateQuery", {
						rootSchemaName: "ContactCareer"
					});
					var filters = update.filters;
					var idContact = this.get("Id");
					var idFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"Contact", idContact);
					filters.add("IdFilter", idFilter);
					if (notUpdate) {
						update.setParameterValue("Current", false, this.Terrasoft.DataValueType.BOOLEAN);
						update.setParameterValue("DueDate", new Date(), this.Terrasoft.DataValueType.DATE);
					} else {
						var currentFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Current", true);
						filters.add("currentFilter", currentFilter);
						var primaryFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Primary", true);
						filters.add("primaryFilter", primaryFilter);
						var account = this.get("Account");
						var job = this.get("Job");
						var jobTitle = this.get("JobTitle");
						var decisionRole = this.get("DecisionRole");
						var department = this.get("Department");
						var employmentType = this.get("EmploymentType");
						if (!this.Ext.isEmpty(account)) {
							update.setParameterValue("Account", account.value, this.Terrasoft.DataValueType.GUID);
						}
						if (!this.Ext.isEmpty(job)) {
							update.setParameterValue("Job", job.value, this.Terrasoft.DataValueType.GUID);
						}
						if (!this.Ext.isEmpty(jobTitle)) {
							update.setParameterValue("JobTitle", jobTitle, this.Terrasoft.DataValueType.TEXT);
						}
						if (!this.Ext.isEmpty(decisionRole)) {
							update.setParameterValue("DecisionRole", decisionRole.value,
								this.Terrasoft.DataValueType.GUID);
						}
						if (!this.Ext.isEmpty(department)) {
							update.setParameterValue("Department", department.value, this.Terrasoft.DataValueType.GUID);
						}
						if (!this.Ext.isEmpty(employmentType)) {
							update.setParameterValue("EmploymentType", employmentType.value,
								this.Terrasoft.DataValueType.GUID);
						}
					}
					return update;
				},

				/**
				 * @inheritdoc Terrasoft.ContactPagev2#isCareerPropertyChanged
				 * @override
				 */
				isCareerPropertyChanged: function() {
					var values = this.changedValues;
					return (values && (values.Account ||
					values.Job ||
					values.JobTitle ||
					values.Department ||
					values.EmploymentType));
				}
			},
			rules: {
				"Branch": {
					"BranchFiltrationByOurBank": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						comparisonType: this.Terrasoft.ComparisonType.EQUAL,
						baseAttributePatch: "Type",
						type: BusinessRuleModule.enums.ValueType.CONSTANT,
						value: BaseFinanceConstants.AccountType.OurBank
					}
				},
				"BlackListDate": {
					"VisibleBlackListDate": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.VISIBLE,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "IsInBlackList"
							},
							comparisonType: this.Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"BlackListReason": {
					"VisibleBlackListReason": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.VISIBLE,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "IsInBlackList"
							},
							comparisonType: this.Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				}
			}
		};
	});
