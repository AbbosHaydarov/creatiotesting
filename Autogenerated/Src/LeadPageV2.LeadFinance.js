define("LeadPageV2", ["BusinessRuleModule", "ConfigurationEnums", "LeadConfigurationConst", "LeadPageV2Resources",
		"ContactFieldConverterMixin"
	],
	function(businessRuleModule, configurationEnums, leadConfigurationConst) {
		return {
			entitySchemaName: "Lead",
			mixins: {
				ContactFieldConverterMixin: "Terrasoft.ContactFieldConverterMixin"
			},
			messages: {
				"LeadTypeChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			details: /**SCHEMA_DETAILS*/ {
				"LeadProduct": {
					"schemaName": "LeadProductDetailV2",
					"entitySchemaName": "LeadProduct",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Lead"
					},
					"defaultValues": {
						"LeadType": {
							"masterColumn": "LeadType"
						}
					}
				},
				"SpecificationInLead": {
					"schemaName": "LeadEditableSpecificationDetailV2",
					"entitySchemaName": "SpecificationInLead",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Lead"
					}
				},
				"LeadEmail": {
					"schemaName": "EmailDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Lead"
					},
					"defaultValues": {
						"Lead": {
							"masterColumn": "Id"
						}
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"name": "Opportunity",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"name": "SalesOwner",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"name": "OpportunityDepartment",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					}
				}
			}, {
				"operation": "remove",
				"name": "Budget"
			}, {
				"operation": "remove",
				"name": "LeadBudget"
			}] /**SCHEMA_DIFF*/ ,
			attributes: {
				"SplitNamesGenerator": {
					"dependencies": [{
						"columns": ["Contact"],
						"methodName": "splitFullName"
					}]
				},
				"LeadTypeChange": {
					"name": "LeadType",
					"dependencies": [{
						"columns": ["LeadType"],
						"methodName": "onLeadTypeChanged"
					}]
				},
				"QualifiedContact": {
					"lookupListConfig": {
						"columns": ["Account"]
					}
				}
			},
			methods: {
				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.mixins.ContactFieldConverterMixin.initContactFieldConverter.call(this, "Contact",
							callback, scope);
					}, this]);
				},

				/**
				 * Inits default qualify status.
				 * @protected
				 */
				initDefQualifyStatus: function() {
					var operation = this.get("Operation");
					if (operation === configurationEnums.CardStateV2.EDIT || operation === configurationEnums.CardStateV2.COPY) {
						return;
					}
					var qualifyStatusId = this.getQualifyStatus();
					if (qualifyStatusId !== leadConfigurationConst.LeadConst.QualifyStatus.Qualification) {
						return;
					}
					var qualifiedContact = this.get("QualifiedContact");
					if (qualifiedContact && qualifiedContact.value !== Terrasoft.GUID_EMPTY && qualifiedContact.Account &&
						qualifiedContact.Account.value !== Terrasoft.GUID_EMPTY) {
						this.setQualifyStatus(leadConfigurationConst.LeadConst.QualifyStatus.Distribution);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onDiscardChangesClick
				 * @overridden
				 */
				onDiscardChangesClick: function() {
					if (!this.isNew) {
						this.updateDetail({
							detail: "SpecificationInLead"
						});
					}
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("GetRecordInfo", function() {
						return {
							operation: this.get("Operation"),
							copiedRecordId: this.get("CopiedRecordId")
						};
					}, this, [this.getDetailId("SpecificationInLead")]);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#copyEntity
				 * @overridden
				 */
				copyEntity: function(primaryColumnValue) {
					this.callParent(arguments);
					this.set("CopiedRecordId", primaryColumnValue);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#save
				 * @overridden
				 */
				save: function() {
					this.set("OldLeadType", this.get("LeadType"));
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#asyncValidate
				 * @overridden
				 */
				asyncValidate: function(callback, scope) {
					this.callParent([function(response) {
						this.setRequiredQulificationFields();
						if (!this.validateResponse(response)) {
							return;
						}
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this, response);
						}
					}, this]);
				},

				/**
				 * Set required property to false.
				 * @protected
				 */
				setRequiredQulificationFields: function() {
					var columns = ["Surname", "MobilePhone"];
					columns.forEach(function(columnName) {
						var column = this.columns[columnName];
						column.isRequired = false;
					}, this);
				},

				/**
				 * Deletes lead product.
				 * @protected
				 */
				deleteLeadProduct: function() {
					var deleteQuery = this.Ext.create("Terrasoft.DeleteQuery", {
						rootSchemaName: "LeadProduct"
					});
					deleteQuery.filters.add("IdFilter", deleteQuery.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Lead", this.get("Id")));
					deleteQuery.execute(function() {
						this.updateDetail({
							detail: "LeadProduct"
						});
					}, this);
				},

				/**
				 * Returns account marker.
				 * @return {String}
				 */
				getAccountMarker: function() {
					return "Account " + this.get("Resources.Strings.AccountNameCaption");
				},

				/**
				 * Changes specifications in lead.
				 * @protected
				 */
				changeSpecificationInLead: function() {
					var oldLeadType = this.get("OldLeadType");
					var leadType = this.get("LeadType");
					var leadTypeChangedInfo = {
						leadType: this.get("LeadType"),
						isClearParams: true
					};
					if ((!Ext.isEmpty(oldLeadType) && !Ext.isEmpty(leadType) && oldLeadType.value !== leadType.value)) {
						var message = this.get("Resources.Strings.ChangeLeadTypeWarningMessage");
						var handler = function(returnCode) {
							if (returnCode === Terrasoft.MessageBoxButtons.YES.returnCode && this.validate()) {
								this.set("OldLeadType", leadType);
								this.sandbox.publish("LeadTypeChanged", leadTypeChangedInfo, [this.getDetailId("SpecificationInLead")]);
								this.deleteLeadProduct();
								var args = {
									isSilent: true,
									messageTags: [this.sandbox.id]
								};
								this.save(args);
							} else {
								this.set("IsEntityInitialized", false);
								this.set("LeadType", oldLeadType);
								this.setValidationInfo("LeadType", true);
								this.set("IsEntityInitialized", true);
								delete this.changedValues.LeadType;
								this.updateButtonsVisibility(this.isChanged());
							}
						};
						this.showConfirmationDialog(message, handler, ["yes", "no"]);
					} else if (this.isNewMode()) {
						this.sandbox.publish("LeadTypeChanged", leadTypeChangedInfo, [this.getDetailId("SpecificationInLead")]);
					}
				},

				/**
				 * Lead type change handler.
				 * @protected
				 */
				onLeadTypeChanged: function() {
					this.changeSpecificationInLead();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.set("OldLeadType", this.get("LeadType"));
					this.preloadSpecificationDetail();
				},

				/**
				 * Preloads specification detail.
				 * @protected
				 */
				preloadSpecificationDetail: function() {
					if (this.isSpecificationDetailLoaded) {
						return;
					}
					this.preloadDetail("SpecificationInLead", null);
					this.isSpecificationDetailLoaded = true;
				},

				/**
				 * Preloads detail.
				 * @param {String} detailName Detail name.
				 * @param {String} containerId Container id.
				 * @protected
				 */
				preloadDetail: function(detailName, containerId) {
					var detailId = this.getDetailId(detailName);
					this.sandbox.loadModule("DetailModuleV2", {
						renderTo: containerId,
						id: detailId
					});
				}

				//endregion
			},
			rules: {
				"Surname": {
					"EnabledSurname": {
						"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": businessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "SourceDataEditable"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": businessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"GivenName": {
					"EnabledGivenName": {
						"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": businessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "SourceDataEditable"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": businessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"MiddleName": {
					"EnabledMiddleName": {
						"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": businessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "SourceDataEditable"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": businessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				}
			}
		};
	}
);
