define("LeadQualificationSearchSimilarPageV2", ["BusinessRuleModule", "terrasoft",
		"LeadQualificationSearchSimilarPageV2Resources", "LookupUtilities", "ConfigurationConstants",
		"ConfigurationEnums", "CustomProcessPageV2Utilities", "LeadQualification", "css!InfoButtonStyles",
		"css!LeadQualificationModuleStyles"
	],
	function(BusinessRuleModule, Terrasoft) {
		return {
			entitySchemaName: "LeadQualification",
			messages: {
				/**
				 * @message LeadTypeChanged
				 * ########## ### ######### #### ###########.
				 */
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
						"masterColumn": "LeadId",
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
						"masterColumn": "LeadId",
						"detailColumn": "Lead"
					}
				},
				"Leads": {
					"schemaName": "LeadDetailV2",
					"filter": {
						"masterColumn": "LeadAccount",
						"detailColumn": "QualifiedAccount"
					},
					"filterMethod": "getLeadFinanceFilters",
					"captionName": "AccountLeadDetailCaption",
					"defaultValues": {
						"QualifiedAccount": {
							"masterColumn": "LeadAccount"
						}
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			methods: {
				/**
				 * ############## ######### ######## ######.
				 * @protected
				 * @virtual
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.un("change:LeadContact", function() {
							this.updateDetail({
								detail: "Leads"
							});
						}, this);
						this.on("change:LeadAccount", function() {
							this.updateDetail({
								detail: "Leads"
							});
						}, this);
						callback.call(scope || this);
					}, this]);
				},

				/**
				 * ######### ####### ##### ## #### #####
				 * @private
				 */
				generateFullName: function() {
					this.set("LeadContactName", null);
					this.nameAppender(this.get("LeadContactSurname"));
					this.nameAppender(this.get("LeadContactGivenName"));
					this.nameAppender(this.get("LeadContactMiddleName"));
				},
				/**
				 * ####### ######### ##### ##### # #######
				 * @private
				 * @param {String} part ##### ##### (#######, ###, ########)
				 */
				nameAppender: function(part) {
					var fullName = this.get("LeadContactName");
					if (part && part !== "") {
						if (fullName) {
							this.set("LeadContactName", fullName + " " + part);
						} else {
							this.set("LeadContactName", part);
						}
					}
				},
				/**
				 * ######### ###### ####### "###". ######### #### #######, ###, ########
				 * @overridden
				 * @param {String} leadId ########## #############.
				 * @param {Function} callback ####### ######### ######.
				 */
				readLead: function(leadId, callback) {
					this.readEntity("Lead", leadId, ["Account", "AccountOwnership", "Website", "AccountCategory",
						"Fax", "EmployeesNumber", "AnnualRevenue", "Gender", "Dear", "FullJobTitle", "Contact",
						"Title", "Zip", "Job", "Department", "DecisionRole", "LeadType", "LeadTypeStatus",
						"BusinesPhone", "Address", "MobilePhone", "Email", "AddressType", "Country", "Region",
						"City", "Industry", "CreatedOn", "InformationSource", "AddressType.ForContact",
						"AddressType.ForAccount", "QualifiedContact", "QualifiedAccount", "Surname", "GivenName",
						"MiddleName"
					], callback);
				},
				/**
				 * ######### ###### ####### "###. ####". ######### #### #######, ###, ########
				 * @overridden
				 * @param {String} contactId ########## #############.
				 * @param {Function} callback ####### ######### ######.
				 */
				readContact: function(contactId, callback) {
					this.readEntity("Contact", contactId, ["Name", "Surname", "GivenName", "MiddleName", "Dear",
						"JobTitle", "Gender", "SalutationType", "Job", "Department", "DecisionRole", "Phone",
						"MobilePhone", "Email"
					], callback);
				},
				/**
				 * ######### ############# ####### ######## ##### ########## ##### ######## "###" # "#######".
				 * ######### #### #######, ###, ########
				 * @overriden
				 * @param {Object} lead ###### ############# "###".
				 * @param {Object} contact ###### ############# "#######".
				 */
				syncContact: function(lead, contact) {
					this.callParent(arguments);
					this.syncColumn("LeadContactSurname", lead, contact, "Surname", "Surname");
					this.syncColumn("LeadContactGivenName", lead, contact, "GivenName", "GivenName");
					this.syncColumn("LeadContactMiddleName", lead, contact, "MiddleName", "MiddleName");
				},
				/**
				 * ########## ########## ########## #### #### ############### ###### # ####### {fieldName}ColumnCaption
				 * @param {string} fieldName ### ####
				 * @returns {string} ########## data-item-marker
				 */
				getMarkerValue: function(fieldName) {
					var markerValue = fieldName;
					var localizableString = this.get("Resources.Strings." + fieldName + "ColumnCaption");
					if (!Ext.isEmpty(localizableString)) {
						markerValue += " " + localizableString;
					}
					return markerValue;
				},

				/**
				 * ############# ######## ######### ## ########## ########.
				 * @protected
				 * @override
				 */
				setInitialValues: function() {
					this.callParent(arguments);
					this.preloadSpecificationDetail();
				},
				/**
				 * ################ ####.
				 * @protected
				 */
				disqualifyLead: function(tag) {
					if (this.Ext.isEmpty(tag)) {
						return;
					}
					this.processParameters.push({
						key: "Result",
						value: "Disqualify"
					}, {
						key: "DisqualifyReasonId",
						value: tag
					});
					this.saveAndCompleteProcess(false);
				},

				/**
				 * ############# ####.
				 * @protected
				 */
				qualifyLead: function() {
					this.processParameters.push({
						key: "Result",
						value: "Qualify"
					});
					this.saveAndCompleteProcess(true);
				},

				/**
				 * ######### ######### ############ ####.
				 * @protected
				 */
				saveLead: function() {
					this.processParameters.push({
						key: "Result",
						value: "Save"
					});
					this.saveAndCompleteProcess(true);
				},
				/**
				 * ######### ###### # ###### "#########" # ########## ## ########.
				 * @param {bool} validate ############ ######## ### ###
				 * @protected
				 */
				saveAndCompleteProcess: function(validate) {
					this.sandbox.subscribe("DetailSaved", function(result) {
						if (result.success) {
							this.completeProcess(validate);
						} else {
							this.showInformationDialog(this.get("Resources.Strings.ParametersDetailSavedError"));
						}
					}, this, [this.getDetailId("SpecificationInLead")]);
					this.sandbox.publish("SaveDetail", null, [this.getDetailId("SpecificationInLead")]);
				},
				/**
				 * ### ######### #### "### ###########", ########## ######### ####.
				 * @private
				 */
				changeSpecificationInLead: function() {
					if (!this.get("IsInitializedValues")) {
						this.set("OldLeadType", this.get("LeadType"));
					}
					var oldLeadType = this.get("OldLeadType");
					var leadType = this.get("LeadType");
					var leadTypeChangedInfo = {
						leadType: this.get("LeadType"),
						isClearParams: true
					};
					if (!Ext.isEmpty(leadType) && oldLeadType.value !== leadType.value &&
						this.get("IsInitializedValues")) {
						var message = this.get("Resources.Strings.ChangeLeadTypeWarningMessage");
						var handler = function(returnCode) {
							if (returnCode === Terrasoft.MessageBoxButtons.YES.returnCode && this.validate()) {
								this.set("OldLeadType", leadType);
								this.sandbox.publish("LeadTypeChanged", leadTypeChangedInfo, [this.getDetailId("SpecificationInLead")]);
								this.deleteLeadProduct();
							} else {
								this.set("LeadType", oldLeadType);
							}
						};
						this.showConfirmationDialog(message, handler, ["yes", "no"]);
					}
				},
				/**
				 * ######### ######## ###### ##########.
				 * @private
				 */
				preloadSpecificationDetail: function() {
					this.preloadDetail("SpecificationInLead",
						"LeadQualificationSearchSimilarPageV2SpecificationInLeadContainer");
				},
				/**
				 * ######### ######## ######, ####### ######### ## ## ######### #######.
				 * @param {String} detailName  ### ######
				 * @param {String} containerId  ######### ######
				 * @virtual
				 */
				preloadDetail: function(detailName, containerId) {
					var parameterDetailConfig = {
						detailName: detailName,
						containerId: containerId
					};
					this.loadDetail(parameterDetailConfig);
				},
				/**
				 * ######### #### "### ###########".
				 * @private
				 */
				onLeadTypeChanged: function() {
					this.changeSpecificationInLead();
				},
				/**
				 * ######## ######### # ####.
				 * @private
				 */
				deleteLeadProduct: function() {
					var deleteQuery = this.Ext.create("Terrasoft.DeleteQuery", {
						rootSchemaName: "LeadProduct"
					});
					deleteQuery.filters.add("IdFilter", deleteQuery.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Lead", this.get("LeadId")));
					deleteQuery.execute(function() {
						this.updateDetail({
							detail: "LeadProduct"
						});
					}, this);
				},

				/**
				 * ##### ########## ###### ##### ## ##. ####.
				 * @private
				 * @return {Terrasoft.FilterGroup} ########## ###### ########.
				 */
				getLeadFinanceFilters: function() {
					var account = this.get("LeadAccount");
					var accountId = this.Terrasoft.GUID_EMPTY;
					if (account && account.value) {
						accountId = account.value;
					}
					var leadId = this.get("LeadId");
					var filters = this.Terrasoft.createFilterGroup();
					filters.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "QualifiedAccount", accountId));
					filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.NOT_EQUAL, "Id", leadId));
					return filters;
				},

				/**
				 * ########## ########## ###### ######## # ######## ########## # #######.
				 * @param {Boolean} validate ######, ####### ## ######### #########.
				 */
				completeProcess: function() {
					this.pushProcessParameter("LeadContactSurname");
					this.pushProcessParameter("LeadContactGivenName");
					this.pushProcessParameter("LeadContactMiddleName");
					this.callParent(arguments);
				}
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"parentName": "LeadTab",
				"propertyName": "items",
				"name": "LeadProduct",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"index": 1
			}, {
				"operation": "insert",
				"parentName": "LeadTab",
				"propertyName": "items",
				"name": "SpecificationInLead",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"index": 0
			}, {
				"operation": "merge",
				"parentName": "LeadTab",
				"propertyName": "items",
				"name": "Leads",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "merge",
				"name": "Job",
				"values": {
					"layout": {
						"column": 12,
						"row": 0
					}
				}
			}, {
				"operation": "merge",
				"name": "FullJobTitle",
				"values": {
					"layout": {
						"column": 12,
						"row": 1
					}
				}
			}, {
				"operation": "merge",
				"name": "Department",
				"values": {
					"layout": {
						"column": 12,
						"row": 2
					}
				}
			}, {
				"operation": "merge",
				"name": "DecisionRole",
				"values": {
					"layout": {
						"column": 12,
						"row": 3
					}
				}
			}, {
				"operation": "merge",
				"parentName": "Header",
				"propertyName": "items",
				"name": "LeadContact",
				"values": {
					"markerValue": {
						bindTo: "getMarkerValue"
					}
				}
			}, {
				"operation": "merge",
				"parentName": "Header",
				"propertyName": "items",
				"name": "LeadAccount",
				"values": {
					"markerValue": {
						bindTo: "getMarkerValue"
					}
				}
			}, {
				"operation": "insert",
				"name": "LeadContactSurname",
				"parentName": "ContactDataGridLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0
					},
					"isRequired": true
				}
			}, {
				"operation": "insert",
				"name": "LeadContactGivenName",
				"parentName": "ContactDataGridLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 1
					}
				}
			}, {
				"operation": "insert",
				"name": "LeadContactMiddleName",
				"parentName": "ContactDataGridLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 2
					}
				}
			}, {
				"operation": "remove",
				"name": "Gender"
			}, {
				"operation": "remove",
				"name": "LeadContactName"
			}, {
				"operation": "merge",
				"name": "Dear",
				"values": {
					"layout": {
						"column": 0,
						"row": 3
					}
				}
			}, {
				"operation": "remove",
				"name": "Salutation"
			}, {
				"operation": "remove",
				"name": "AccountAdressBlock"
			}, {
				"operation": "remove",
				"name": "ContactAdressBlock"
			}, {
				"operation": "merge",
				"name": "ContactBusinessPhone",
				"values": {
					"layout": {
						"column": 12,
						"row": 0
					}
				}
			}, {
				"operation": "merge",
				"name": "ContactMobilePhone",
				"values": {
					"layout": {
						"column": 0,
						"row": 0
					}
				}
			}, {
				"operation": "remove",
				"name": "Ownership"
			}, {
				"operation": "remove",
				"name": "BREAK"
			}] /**SCHEMA_DIFF*/ ,
			attributes: {
				"LeadContactSurname": {
					"isRequired": true
				},
				"LeadContact": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					caption: {
						bindTo: "Resources.Strings.LeadContactColumnCaption"
					},
					referenceSchemaName: "Contact"
				},
				"LeadAccount": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					caption: {
						bindTo: "Resources.Strings.LeadAccountColumnCaption"
					},
					referenceSchemaName: "Account"
				},
				"IsContactSearchBySurname": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				"ContactSearchValueSurname": {
					caption: {
						bindTo: "Resources.Strings.SearchContactSurnameCaption"
					},
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				"IsContactSearchByGivenName": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				"ContactSearchValueGivenName": {
					caption: {
						bindTo: "Resources.Strings.SearchContactGivenNameCaption"
					},
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				"IsContactSearchByMiddleName": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				"ContactSearchValueMiddleName": {
					caption: {
						bindTo: "Resources.Strings.SearchContactMiddleNameCaption"
					},
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				"FullNameGenerator": {
					dependencies: [{
						columns: ["LeadContactSurname", "LeadContactGivenName", "LeadContactMiddleName"],
						methodName: "generateFullName"
					}]
				},
				"LeadTypeChange": {
					name: "LeadType",
					dependencies: [{
						columns: ["LeadType"],
						methodName: "onLeadTypeChanged"
					}]
				}
			}
		};
	});
