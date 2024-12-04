define("FinAppLendingPage", ["BusinessRuleModule", "ProductBankConstants", "Product", "css!FinAppLendingCSS",
		"TimezoneGenerator", "TimezoneMixin", "FinApplicationProfileUtils", "FinAppSpecificationFieldsDetail",
		"DocListInFinAppDetail", "AppFormDetail", "AppValidationDetail", "FinApplicationActionsDashboard"
	],
	function(BusinessRuleModule, ProductBankConstants, Product) {
		return {
			entitySchemaName: "FinApplication",
			details: /**SCHEMA_DETAILS*/ {
				"AppValidationDetail": {
					"schemaName": "AppValidationDetail",
					"filter": {
						"detailColumn": "FinApplication",
						"masterColumn": "Id"
					}
				},
				"AppFormDetail": {
					"schemaName": "AppFormDetail",
					"filter": {
						"detailColumn": "FinApplication",
						"masterColumn": "Id"
					},
					"subscriber": function() {
						this.initBorrower();
					}
				},
				"DocListInFinAppDetail": {
					"schemaName": "DocListInFinAppDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "FinApplication"
					}
				},
				"FinAppSpecificationFieldsDetail": {
					"schemaName": "FinAppSpecificationFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "FinApplication"
					},
					"defaultValues": {
						"FinApplication": {
							"masterColumn": "FinApplication"
						}
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			modules: /**SCHEMA_MODULES*/ {
				"ActionsDashboardModule": {
					"config": {
						"isSchemaConfigInitialized": true,
						"schemaName": "FinApplicationActionsDashboard",
						"useHistoryState": false,
						"parameters": {
							"viewModelConfig": {
								"entitySchemaName": "FinApplication",
								"dashboardConfig": {
									"Activity": {
										"masterColumnName": "Id",
										"referenceColumnName": "FinApplication"
									}
								}
							}
						}
					}
				}
			} /**SCHEMA_MODULES*/ ,
			messages: {},
			mixins: {
				TimezoneMixin: "Terrasoft.TimezoneMixin",
				FinApplicationProfileUtils: "Terrasoft.FinApplicationProfileUtils"
			},
			attributes: {
				/**
				 * Borrower role Id.
				 */
				"BorrowerRole": {
					dataValueType: this.Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * FinApplication product in profile.
				 */
				"FinAppProduct": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isLookup": true,
					"referenceSchema": Product,
					"referenceSchemaName": "Product"
				},
				/**
				 * Profile Info product.
				 */
				"ProfileInfoCollection": {
					"dataValueType": Terrasoft.DataValueType.COLLECTION
				},
				/**
				 * Profile Info product. Amount with currency.
				 */
				"FinAppAmountWithCurrency": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN

				},
				/**
				 * Profile Info product. Amount value.
				 */
				"FinAppAmount": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Profile Info product. Currency value.
				 */
				"FinAppCurrency": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Profile Info product. Term value.
				 */
				"FinAppTerm": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Borrower photo.
				 */
				"Photo": {
					"dataValueType": this.Terrasoft.DataValueType.IMAGE,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Caption of "Borrower" column.
				 */
				"BorrowerCaption": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Borrower lookup column.
				 */
				"Borrower": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"referenceSchemaName": "AppForm"
				},

				/**
				 * Contract.
				 */
				"Contract": {
					"lookupListConfig": null,
					"dependencies": null
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * Sets Borrower value.
				 * @private
				 * @param {Object} response Response object.
				 */
				initBorrowerCallback: function(response) {
					if (response && response.success && !response.collection.isEmpty()) {
						var targetItem = response.collection.getByIndex(0);
						var participantId = targetItem.get("Id");
						var participantValue = targetItem.get("Participant") || "";
						var participantRole = targetItem.get("ParticipantRole") || {};
						var participantRoleCaption = participantRole.displayValue || "";
						var participantPhoto = targetItem.get("Photo") || null;
						var participantObj = {
							value: participantId,
							displayValue: participantValue
						};
						this.set("Borrower", participantObj);
						this.set("BorrowerCaption", participantRoleCaption);
						this.set("Photo", participantPhoto);
					} else {
						this.set("Borrower", "");
						this.set("BorrowerCaption", "");
						this.set("Photo", null);
					}
				},

				/**
				 * Sets Borrower value.
				 * @param {Object} borrowerRole borrower role Id.
				 * @private
				 */
				initBorrower: function(borrowerRole) {
					var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "AppForm"
					});
					esq.addColumn("Participant");
					esq.addColumn("ParticipantRole");
					esq.filters.add("FinApplicationId", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "FinApplication",
						this.get("Id")));
					esq.filters.add("ParticipantRoleId", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ParticipantRole",
						borrowerRole));
					esq.getEntityCollection(this.initBorrowerCallback, this);
				},

				/**
				 * Gets current borrower role, or default if not found.
				 * @param {Function} callback method to return after execution.
				 * @param {Object} scope scope of the method to return after execution.
				 * @private
				 */
				initBorrowerRole: function(callback, scope) {
					var borrowerRole = this.get("BorrowerRole");
					if (!this.Ext.isEmpty(borrowerRole)) {
						this.Ext.callback(callback, scope, [borrowerRole]);
						return;
					}
					var setting = this.Terrasoft.SysSettings.cachedSettings.MainParticipantRole || {};
					borrowerRole = setting.value;
					if (!borrowerRole) {
						this.Terrasoft.SysSettings.querySysSettingsItem("MainParticipantRole", function(dbSetting) {
							dbSetting = dbSetting || {};
							borrowerRole = dbSetting.value || ProductBankConstants.ParticipantRole.BORROWER;
							this.set("BorrowerRole", borrowerRole);
							this.Ext.callback(callback, scope, [borrowerRole]);
						}, this);
					} else {
						this.set("BorrowerRole", borrowerRole);
						this.Ext.callback(callback, scope, [borrowerRole]);
					}
				},

				/**
				 * Returns application form photo url.
				 * @private
				 * @return {String} Application form photo url.
				 */
				getFinApplicationPhoto: function() {
					var primaryImageColumnValue = this.get(this.primaryImageColumnName);
					if (primaryImageColumnValue) {
						return this.getSchemaImageUrl(primaryImageColumnValue);
					}
					return this.getFinApplicationDefaultPhoto();
				},

				/**
				 * Returns default application form photo url.
				 * @private
				 * @return {String} Default application form photo url.
				 */
				getFinApplicationDefaultPhoto: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.DefaultPhoto"));
				},

				//endregion

				//region Methods: Protected

				/**
				 * On photo uploaded handler.
				 * @protected
				 * @param {String} imageId Photo image id.
				 */
				onPhotoUploaded: function(imageId) {
					var primaryImageColumnName = this.primaryImageColumnName;
					if (!primaryImageColumnName) {
						return;
					}
					this.set(this.primaryImageColumnName, {
						value: imageId,
						displayValue: "Photo"
					});
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.mixins.TimezoneMixin.init.call(this);
					this.initBorrowerRole(this.initBorrower, this);
					this.callParent(arguments);
				}

				//endregion
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "PhotoTimeZoneContainer",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["image-edit-container"],
					"items": [],
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			}, {
				"operation": "insert",
				"parentName": "PhotoTimeZoneContainer",
				"propertyName": "items",
				"name": "PhotoFinApplication",
				"values": {
					"getSrcMethod": "getFinApplicationPhoto",
					"onPhotoChange": "onPhotoChange",
					"readonly": true,
					"defaultImage": {
						"bindTo": "getFinApplicationDefaultPhoto"
					},
					"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
				}
			}, {
				"operation": "insert",
				"parentName": "PhotoTimeZoneContainer",
				"propertyName": "items",
				"name": "Timezone",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"generator": "TimezoneGenerator.generateTimeZone",
					"wrapClass": ["timezone-container"],
					"visible": false,
					"timeZoneCaption": {
						"bindTo": "TimeZoneCaption"
					},
					"timeZoneCity": {
						"bindTo": "TimeZoneCity"
					},
					"tips": []
				}
			}, {
				"operation": "insert",
				"name": "Borrower",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					},
					"bindTo": "Borrower",
					"caption": {
						"bindTo": "BorrowerCaption"
					},
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "DecisionTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.DecisionTabCaption"
					},
					"items": []
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2
			}, {
				"operation": "move",
				"name": "HistoryTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 3
			}, {
				"operation": "insert",
				"name": "DecisionTabControlGroup",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"controlConfig": {
						"collapsed": false
					}
				},
				"parentName": "DecisionTab",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "DecisionTabGridLayout",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				},
				"parentName": "DecisionTabControlGroup",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "ActionsDashboardModule",
				"parentName": "ActionDashboardContainer",
				"propertyName": "items",
				"values": {
					"classes": {
						"wrapClassName": ["actions-dashboard-module"]
					},
					"itemType": Terrasoft.ViewItemType.MODULE
				}
			}, {
				"operation": "insert",
				"name": "AppValidationDetail",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "DecisionTab",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "AppFormDetail",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "ParticipantsAndDocumentsTab",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Approver",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "DecisionTabGridLayout",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Decision",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "DecisionTabGridLayout",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "DecisionDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "DecisionTabGridLayout",
				"propertyName": "items"
			}] /**SCHEMA_DIFF*/ ,
			rules: {}
		};
	});
