define("OpportunityPageV2", ["ConfigurationConstants"],
	function(configurationConstants) {
		return {
			entitySchemaName: "Opportunity",
			messages: {
				"LeadTypeChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			details: /**SCHEMA_DETAILS*/ {
				"SpecificationInOpportunity": {
					"schemaName": "OpportunityEditableSpecificationDetailV2",
					"entitySchemaName": "SpecificationInOpportunity",
					"filter": {
						"detailColumn": "Opportunity",
						"masterColumn": "Id"
					}
				},
				"AccountContract": {
					"schemaName": "ContractDetailV2",
					"filter": {
						"masterColumn": "Account",
						"detailColumn": "Account"
					},
					"useRelationship": true
				},
				"EmailDetailV2": {
					"schemaName": "EmailDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Opportunity"
					},
					"defaultValues": {
						"Opportunity": {
							"masterColumn": "Id"
						},
						"Account": {
							"masterColumn": "Account"
						},
						"Contact": {
							"masterColumn": "Contact"
						}
					}
				},
				"AccountEmails": {
					"schemaName": "EmailDetailV2",
					"filter": {
						"masterColumn": "Account",
						"detailColumn": "Account"
					},
					"useRelationship": true,
					"filterMethod": "emailDetailFilter"
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "remove",
				"parentName": "BantProfile",
				"propertyName": "items",
				"name": "OpportunityBudget"
			}, {
				"operation": "remove",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "IsPrimary"
			}, {
				"operation": "remove",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Type"
			}, {
				"operation": "remove",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Partner"
			}, {
				"operation": "insert",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Revenue",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					},
					"enabled": true
				}
			}, {
				"operation": "merge",
				"parentName": "BantProfile",
				"propertyName": "items",
				"name": "OpportunityDecisionMaker",
				"values": {
					"layout": {
						"row": 1,
						"column": 5,
						"colSpan": 19
					}
				}
			}, {
				"operation": "merge",
				"parentName": "BantProfile",
				"propertyName": "items",
				"name": "OpportunityLeadType",
				"values": {
					"layout": {
						"row": 2,
						"column": 5,
						"colSpan": 19
					}
				}
			}, {
				"operation": "merge",
				"parentName": "BantProfile",
				"propertyName": "items",
				"name": "OpportunityDueDate",
				"values": {
					"layout": {
						"row": 3,
						"column": 5,
						"colSpan": 19
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Amount",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Probability",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Category",
				"values": {
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "ResponsibleDepartment",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "OpportunityTitle",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Owner",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "CreatedOn",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12
					}
				}
			}, {
				"operation": "merge",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"name": "Source",
				"values": {
					"layout": {
						"column": 12,
						"row": 3,
						"colSpan": 12
					}
				}
			}, {
				"operation": "insert",
				"name": "SpecificationInOpportunity",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 2
			}, {
				"operation": "insert",
				"parentName": "HistoryAccountTab",
				"propertyName": "items",
				"name": "AccountContract",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "isShowAccountsDetail"
					}
				},
				"index": 1
			}, {
				"operation": "move",
				"name": "EmailDetailV2",
				"parentName": "OpportunityHistoryTabContainer",
				"propertyName": "items",
				"index": 2
			}, {
				"operation": "insert",
				"parentName": "HistoryAccountTab",
				"propertyName": "items",
				"name": "AccountEmails",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "isShowAccountsDetail"
					}
				}
			}] /**SCHEMA_DIFF*/ ,
			attributes: {
				"LeadTypeChange": {
					"name": "LeadType",
					"dependencies": [{
						"columns": ["LeadType"],
						"methodName": "onLeadTypeChanged"
					}]
				}
			},
			methods: {

				/**
				 * Returns email detail filter group.
				 * @protected
				 * @return {Terrasoft.FilterGroup} Email detail filter group.
				 */
				emailDetailFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.add("AccountConnection", this.contactAccountFilter());
					filterGroup.add("ActivityType", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Type", configurationConstants.Activity.Type.Email));
					return filterGroup;
				},

				/**
				 * Checks for substring in string.
				 * @protected
				 * @param {String} name Name.
				 * @param {String} part Part.
				 * @return {Boolean} Check result.
				 */
				namePartExists: function(name, part) {
					return (name.indexOf(part) !== -1 && !this.Ext.isEmpty(part));
				},

				/**
				 * Checks for slash symbol in string.
				 * @protected
				 * @param {String} name Name.
				 * @return {Boolean} Check result.
				 */
				nameSlashExists: function(name) {
					return this.namePartExists(name, " / ");
				},

				/**
				 * Add lead type part to name.
				 * @protected
				 * @param {String} name Name.
				 * @return {String} Name with lead type part.
				 */
				addLeadTypePart: function(name) {
					var leadType = this.get("LeadType");
					var oldLeadType = this.get("OldLeadTypeForName");
					leadType = this.Ext.isEmpty(leadType) ? "" : leadType.displayValue;
					oldLeadType = this.Ext.isEmpty(oldLeadType) ? "" : oldLeadType.displayValue;
					var leadTypePartExists = this.namePartExists(name, oldLeadType);
					var nameSlashExists = this.nameSlashExists(name);
					var leadTypeIsEmpty = this.Ext.isEmpty(leadType);
					if (leadTypePartExists) {
						name = name.replace(oldLeadType, leadType);
					}
					if (!leadTypePartExists && nameSlashExists && !leadTypeIsEmpty) {
						name = name.replace(" / ", " " + leadType + " / ");
					} else if (!leadTypePartExists && !leadTypeIsEmpty) {
						name = this.Ext.String.format("{0} / {1}", leadType, name);
					}
					return name;
				},

				/**
				 * Add client type part to name.
				 * @protected
				 * @param {String} name Name.
				 * @return {String} Name with client type part.
				 */
				addClientPart: function(name) {
					var client = this.get("Client");
					var oldClient = this.get("OldClient");
					client = this.Ext.isEmpty(client) ? "" : client.displayValue;
					oldClient = this.Ext.isEmpty(oldClient) ? "" : oldClient.displayValue;
					var clientPartExists = this.namePartExists(name, oldClient);
					var nameSlashExists = this.nameSlashExists(name);
					var clientIsEmpty = this.Ext.isEmpty(client);
					if (clientPartExists) {
						name = name.replace(oldClient, client);
					}
					if (!clientPartExists && nameSlashExists && !clientIsEmpty) {
						name = name.replace(" / ", " / " + client + " ");
					} else if (!clientPartExists && !clientIsEmpty) {
						name = this.Ext.String.format("{0} / {1}", name, client);
					}
					return name;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onDiscardChangesClick
				 * @overridden
				 */
				onDiscardChangesClick: function() {
					if (!this.isNew) {
						this.updateDetail({
							detail: "SpecificationInOpportunity"
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
					}, this, [this.getDetailId("SpecificationInOpportunity")]);
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
				 * Changes opportunity specification by LeadType.
				 * @protected
				 */
				changeSpecificationInOpportunity: function() {
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
								this.sandbox.publish("LeadTypeChanged", leadTypeChangedInfo, [this.getDetailId("SpecificationInOpportunity")]);
								this.deleteOpportunityProductInterest();
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
						this.sandbox.publish("LeadTypeChanged", leadTypeChangedInfo, [this.getDetailId("SpecificationInOpportunity")]);
					}
				},

				/**
				 * Lead type change handler.
				 * @protected
				 */
				onLeadTypeChanged: function() {
					this.changeSpecificationInOpportunity();
				},

				/**
				 * Deletes opportunity product interest, and updates opportunity product detail.
				 * @protected
				 */
				deleteOpportunityProductInterest: function() {
					var deleteQuery = this.Ext.create("Terrasoft.DeleteQuery", {
						rootSchemaName: "OpportunityProductInterest"
					});
					deleteQuery.filters.add("IdFilter", deleteQuery.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Opportunity", this.get("Id")));
					deleteQuery.execute(function() {
						this.updateDetail({
							detail: "OpportunityProduct"
						});
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.set("OldLeadType", this.get("LeadType"));
					this.set("OldLeadTypeForName", this.get("LeadType"));
					var oldClient = this.get("Account") || this.get("Contact");
					this.set("OldClient", oldClient);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#save
				 * @overridden
				 */
				save: function() {
					this.set("OldLeadType", this.get("LeadType"));
					this.set("OldLeadTypeForName", this.get("LeadType"));
					this.callParent(arguments);
				}
			}
		};
	}
);
