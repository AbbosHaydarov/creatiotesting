define("LeadManagementDistributionPageV2", [],
	function() {
		return {
			entitySchemaName: "Lead",
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
					"filterMethod": "getLeadFinanceFilters",
					"captionName": "ContactLeadDetailCaption",
					"filter": {
						"masterColumn": "QualifiedAccount",
						"detailColumn": "QualifiedAccount"
					},
					"defaultValues": {
						"QualifiedAccount": {
							"masterColumn": "QualifiedAccount"
						}
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BasePage#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.setInitialValues();
						callback.call(scope || this);
					}, this]);
				},

				/**
				 * Sets the attribute values for the process parameters.
				 * @protected
				 */
				setInitialValues: function() {
					this.preloadSpecificationDetail();
				},

				/**
				 * Preloads specification detail.
				 * @protected
				 */
				preloadSpecificationDetail: function() {
					this.preloadDetail("SpecificationInLead",
						"LeadQualificationSearchSimilarPageV2SpecificationInLeadContainer");
				},

				/**
				 * Loads the details, which is not in the initial tab.
				 * @protected
				 * @param {string} detailName Detail name.
				 * @param {string} containerId Container detail.
				 */
				preloadDetail: function(detailName, containerId) {
					var parameterDetailConfig = {
						detailName: detailName,
						containerId: containerId
					};
					this.loadDetail(parameterDetailConfig);
				},

				/**
				 * @inheritdoc Terrasoft.LeadManagementDistributionPageV2#setTransferToSale
				 * @overridden
				 */
				setTransferToSale: function() {
					this.processParameters.push({
						key: "Result",
						value: "TransferToSale"
					});
					this.saveAndCompleteProcess(true);
				},

				/**
				 * @inheritdoc Terrasoft.LeadManagementDistributionPageV2#setDistributeLater
				 * @overridden
				 */
				setDistributeLater: function() {
					this.processParameters.push({
						key: "Result",
						value: "DistributeLater"
					});
					this.saveAndCompleteProcess(false);
				},

				/**
				 * @inheritdoc Terrasoft.LeadManagementDistributionPageV2#setNotInteresting
				 * @overridden
				 */
				setNotInteresting: function() {
					this.processParameters.push({
						key: "Result",
						value: "NotInteresting"
					});
					this.saveAndCompleteProcess(false);
				},

				/**
				 * Saves the item of "Specification" detail, and continues through the process.
				 * @protected
				 * @param {bool} validate Validate result.
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
				 * Returns datamarker the right if there is a localized string in the format {fieldName}Caption.
				 * @protected
				 * @param {string} fieldName Column name.
				 * @return {string} Correct data-item-marker.
				 */
				getMarkerValue: function(fieldName) {
					var markerValue = fieldName;
					var localizableString = this.get("Resources.Strings." + fieldName + "Caption");
					if (!Ext.isEmpty(localizableString)) {
						markerValue += " " + localizableString;
					}
					return markerValue;
				},

				/**
				 * Filtration method details of leads for account.
				 * @protected
				 * @return {Terrasoft.FilterGroup} Filter group.
				 */
				getLeadFinanceFilters: function() {
					var account = this.get("QualifiedAccount");
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
				}

				//endregion

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
				"parentName": "Header",
				"propertyName": "items",
				"name": "QualifiedContact",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.QualifiedContactCaption"
					},
					"markerValue": {
						"bindTo": "getMarkerValue"
					}
				}
			}, {
				"operation": "merge",
				"parentName": "Header",
				"propertyName": "items",
				"name": "QualifiedAccount",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.QualifiedAccountCaption"
					},
					"markerValue": {
						"bindTo": "getMarkerValue"
					}
				}
			}, {
				"operation": "merge",
				"name": "ContactName",
				"parentName": "ContactDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "ContactName"
				}
			}, {
				"operation": "merge",
				"name": "ContactDepartment",
				"parentName": "ContactDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "ContactDepartment"
				}
			}, {
				"operation": "merge",
				"name": "ContactJob",
				"parentName": "ContactDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "ContactJob"
				}
			}, {
				"operation": "merge",
				"name": "ContactGender",
				"parentName": "ContactDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "ContactGender"
				}
			}, {
				"operation": "merge",
				"parentName": "Header",
				"propertyName": "items",
				"name": "ContactJobTitle",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.ContactJobTitleCaption"
					},
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "ContactJobTitle"
				}
			}, {
				"operation": "merge",
				"name": "ContactDecisionRole",
				"parentName": "ContactDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "ContactDecisionRole"
				}
			}, {
				"operation": "merge",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Category",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.CategoryCaption"
					},
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "Category"
				}
			}, {
				"operation": "merge",
				"name": "AccountIndustry",
				"parentName": "AccountDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "AccountIndustry"
				}
			}, {
				"operation": "merge",
				"name": "AccountAnnualRevenue",
				"parentName": "AccountDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "AccountAnnualRevenue"
				}
			}, {
				"operation": "merge",
				"name": "AccountEmployeesNumber",
				"parentName": "AccountDataBlockGridLayout",
				"propertyName": "items",
				"values": {
					"markerValue": {
						"bindTo": "getMarkerValue"
					},
					"tag": "AccountEmployeesNumber"
				}
			}] /**SCHEMA_DIFF*/
		};
	});
