define("ProductPageV2", ["BusinessRuleModule", "BaseFinanceConstants", "ProductBankConstants", "ProductPageV2Resources",
		"css!ProductPageV2CSS"
	],
	function(BusinessRuleModule, BaseFinanceConstants, ProductBankConstants, resources) {
		return {
			entitySchemaName: "Product",
			attributes: {
				/**
				 * Information message with type and category of current product.
				 * @type {String}
				 */
				"InfoMessage": {
					dataValueType: Terrasoft.DataValueType.TEXT
				},

				/**
				 * Category field.
				 * @type {Object}
				 */
				"Category": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {
						columns: ["Kind"]
					},
					dependencies: [{
						columns: ["Category"],
						methodName: "onCategoryKindChange"
					}]
				},

				/**
				 * Insurance company field.
				 * @type {Object}
				 */
				"InsuranceCompany": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {
						filter: function() {
							return this.Terrasoft.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL,
								"Type.Id",
								ProductBankConstants.AccountType.INSURANCE_COMPANY);
						}
					}
				},
				
				/**
				 * Linked products tab caption.
				 * @type {String}
				 */
				"LinkedProductsTabCaption": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: resources.localizableStrings.ServicePackageTabTabCaption
				}
			},
			messages: {
				/**
				 * @message ReloadDetail.
				 */
				"ReloadProductConditionDetail": {
					"mode": this.Terrasoft.MessageMode.PTP,
					"direction": this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			details: /**SCHEMA_DETAILS*/ {
				ProductConditionDetailV2: {
					schemaName: "ProductConditionDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Product"
					},
					defaultValues: {
						ProductStatus: {
							masterColumn: "ProductStatus"
						},
						ProductDueDate: {
							masterColumn: "DueDate"
						},
						ProductCompleteStatus: {
							masterColumn: "ProductCompleteStatus"
						}
					}
				},
				PackageInProductDetailV2: {
					schemaName: "PackageInProductDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Package"
					}
				},
				ProductInPackageDetailV2: {
					schemaName: "ProductInPackageDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Product"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "LinkedProductsTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"caption": {
						"bindTo": "LinkedProductsTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "LinkedProductsTab",
				"propertyName": "items",
				"name": "PackageInProductDetailV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "IsServiceProduct"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "LinkedProductsTab",
				"propertyName": "items",
				"name": "ProductInPackageDetailV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "IsServiceProduct",
						"bindConfig": {
							"converter": "invertConverter"
						}
					}
				}
			}, {
				"operation": "merge",
				"name": "CardContentContainer",
				"values": {
					"wrapClass": ["ProductPageV2", "center-main-container"]
				}
			}, {
				"operation": "remove",
				"name": "StartDate"
			}, {
				"operation": "remove",
				"name": "ProductStatus"
			}, {
				"operation": "remove",
				"name": "DueDate"
			}, {
				"operation": "remove",
				"name": "ProductSpecificationTab"
			}, {
				"operation": "remove",
				"name": "ProductKind"
			}, {
				"operation": "remove",
				"name": "Type"
			}, {
				"operation": "remove",
				"name": "Category"
			}, {
				"operation": "insert",
				"name": "Category",
				"parentName": "AdditionalLeftFieldsContainer",
				"propertyName": "items",
				"values": {
					"bindTo": "Category",
					"contentType": Terrasoft.ContentType.ENUM,
					"visible": {
						"bindTo": "IsNew"
					}
				}
			}, {
				"operation": "insert",
				"name": "Type",
				"parentName": "AdditionalRightFieldsContainer",
				"propertyName": "items",
				"values": {
					"bindTo": "Type",
					"contentType": Terrasoft.ContentType.ENUM,
					"visible": {
						"bindTo": "IsNew"
					}
				}
			}, {
				"operation": "remove",
				"name": "DescriptionGroup"
			}, {
				"operation": "insert",
				"name": "ProductGeneralInfoControlGroup",
				"parentName": "ProductGeneralInfoTab",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"caption": {
						"bindTo": "Resources.Strings.ProductGeneralInfoTab"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "ProductGeneralInfoControlGroupContainer",
				"parentName": "ProductGeneralInfoControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "StartDate",
				"propertyName": "items",
				"parentName": "ProductGeneralInfoControlGroupContainer",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "StartDate"
				}
			}, {
				"operation": "insert",
				"name": "ProductStatus",
				"parentName": "ProductGeneralInfoControlGroupContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "ProductStatus",
					"contentType": Terrasoft.ContentType.ENUM
				}
			}, {
				"operation": "insert",
				"name": "DueDate",
				"parentName": "ProductGeneralInfoControlGroupContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "DueDate"
				}
			}, {
				"operation": "insert",
				"name": "AdditionalLeftFieldsContainer",
				"parentName": "ProductGeneralInfoControlGroupContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "AdditionalRightFieldsContainer",
				"parentName": "ProductGeneralInfoControlGroupContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "InsuranceCompany",
				"parentName": "AdditionalLeftFieldsContainer",
				"propertyName": "items",
				"values": {
					"bindTo": "InsuranceCompany",
					"visible": {
						"bindTo": "getInsuranceFieldsVisible"
					}
				}
			}, {
				"operation": "insert",
				"name": "InsuranceContractNumber",
				"parentName": "AdditionalLeftFieldsContainer",
				"propertyName": "items",
				"values": {
					"bindTo": "InsuranceContractNumber",
					"visible": {
						"bindTo": "getInsuranceFieldsVisible"
					}
				}
			}, {
				"operation": "insert",
				"name": "InsuranceContractDate",
				"parentName": "AdditionalRightFieldsContainer",
				"propertyName": "items",
				"values": {
					"bindTo": "InsuranceContractDate",
					"visible": {
						"bindTo": "getInsuranceFieldsVisible"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "ProductGeneralInfoControlGroupContainer",
				"propertyName": "items",
				"name": "Code",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					},
					"bindTo": "Code",
					"labelWrapConfig": {
						"classes": {
							"wrapClassName": ["page-header-label-wrap"]
						}
					}
				}
			}, {
				"operation": "insert",
				"parentName": "ProductGeneralInfoTab",
				"propertyName": "items",
				"name": "ProductConditionDetailV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "merge",
				"name": "Name",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24,
						"rowSpan": 1
					},
					"labelWrapConfig": {
						"classes": {
							"wrapClassName": ["page-header-label-wrap"]
						}
					},
					"tip": {
						"content": {
							"bindTo": "InfoMessage"
						}
					}
				}
			}, {
				"operation": "insert",
				"name": "AvailableFor",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24,
						"rowSpan": 1
					},
					"bindTo": "AvailableFor",
					"contentType": Terrasoft.ContentType.ENUM
				}
			}, {
				"operation": "insert",
				"name": "ProductFilesTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.FilesTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ProductFilesTab",
				"propertyName": "items",
				"index": 0,
				"name": "Files",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"name": "NotesControlGroup",
				"parentName": "ProductFilesTab",
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
			}, {
				"operation": "remove",
				"name": "ProductFile"
			}] /**SCHEMA_DIFF*/ ,
			methods: {

				/**
				 * Sets tab header value for the related products items.
				 * @private
				 * @param {String} caption Title for the tab.
				 */
				setLinkedProductsTabCaption: function(caption) {
					var tabsCollection = this.get("TabsCollection");
					var tab = tabsCollection.get("LinkedProductsTab");
					tab.set("Caption", caption);
				},

				/**
				 * Handles category field changing.
				 * @private
				 */
				onCategoryKindChange: function() {
					var category = this.get("Category");
					var isServiceProduct = false;
					if (!this.Ext.isEmpty(category)) {
						var kind = category && category.Kind;
						var kindValue = kind && kind.value;
						isServiceProduct = kindValue === ProductBankConstants.CategoryKind.SERVICE_PACKAGE;
					}
					this.set("IsServiceProduct", isServiceProduct);
					var caption = isServiceProduct
						? this.get("Resources.Strings.ProductsTabTabCaption")
						: this.get("Resources.Strings.ServicePackageTabTabCaption");
					this.setLinkedProductsTabCaption(caption);
				},

				/**
				 * Returns the sign to display fields of insurance product.
				 * @private
				 * @return {Boolean} The sign of insurance product display fields.
				 */
				getInsuranceFieldsVisible: function() {
					var category = this.get("Category");
					var insuranceFieldsVisible = false;
					if (!this.Ext.isEmpty(category)) {
						var kind = category && category.Kind;
						var kindValue = kind && kind.value;
						insuranceFieldsVisible = kindValue === ProductBankConstants.CategoryKind.INSURANCE_PRODUCT;
					}
					return insuranceFieldsVisible;
				},

				/**
				 * Inverts boolean value.
				 * @private
				 * @param {Boolean} value Target value.
				 * @return {Boolean} Reverse value.
				 */
				invertConverter: function(value) {
					return !value;
				},

				/**
				 * Reloads ProductConditionDetailV2 detail.
				 * @private
				 */
				_reloadProductConditionDetail: function() {
					this.updateDetail({
						detail: "ProductConditionDetailV2"
					});
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#onRender
				 * @override
				 */
				onRender: function() {
					this.callParent(arguments);
					this.onCategoryKindChange();
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.subscribeOnColumnChange("DueDate", this.onDueDateChange);
					this.Terrasoft.SysSettings.querySysSettingsItem("ProductCompleteStatus", function(value) {
						this.set("ProductCompleteStatus", value);
					}, this);
					if (this.isNew) {
						this.set("IsNew", this.isNew);
					} else {
						this.setInfoMessage();
					}
					this.onCategoryKindChange();
					this.sandbox.subscribe("ReloadProductConditionDetail", this._reloadProductConditionDetail, this);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#isNewMode
				 * @override
				 */
				isNewMode: function() {
					var isNewMode = this.callParent(arguments);
					if (!isNewMode) {
						isNewMode = this.isCopied();
					}
					return isNewMode;
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#updateButtonsVisibility
				 * @override
				 */
				updateButtonsVisibility: function() {
					if (this.destroyed) {
						return;
					}
					this.callParent(arguments);
					var isNeedSave = this.isEditMode() && !this.get("ShowSaveButton") && this.isCopied();
					if (!isNeedSave) {
						return;
					}
					this.set("ShowDiscardButton", false);
					this.set("ShowSaveButton", true);
					this.set("ShowCloseButton", false);
				},

				/**
				 * Checks if is copied record.
				 * @protected
				 * @return {Boolean}
				 */
				isCopied: function() {
					return this.$IsCopied;
				},

				/**
				 * @inheritdoc BasePageV2#save
				 * @override
				 */
				onSaved: function() {
					this.callParent(arguments);
					this.$IsCopied = false;
				},

				/**
				 * Sets the value in InfoMessage attribute, based on the current category and the type of product.
				 * @protected
				 */
				setInfoMessage: function() {
					var type = this.get("Type");
					var category = this.get("Category");
					var message = this.Ext.String.format(this.get("Resources.Strings.InformationMessage"),
						category.displayValue, type.displayValue);
					this.set("InfoMessage", message);
				},

				/**
				 * Handles product due date changing.
				 * @param {Object} model Modified model.
				 * @param {Date} value New date value.
				 * @protected
				 */
				onDueDateChange: function(model, value) {
					if (this.Ext.isEmpty(value)) {
						this.set("DueDateValidationInfo", {
							isValid: true
						});
					} else {
						var date = this.Ext.Date.format(value, "d.m.Y");
						var message = this.Ext.String.format(this.get("Resources.Strings.DueDateConfirmationMessage"),
							date);
						this.set("DueDateValidationInfo", {
							isValid: false,
							message: message
						});
						if (this.isDueDateExpire()) {
							this.set("ProductStatus", this.get("ProductCompleteStatus"));
						}
						this.validate();
					}
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#onCardAction
				 * @override
				 */
				onCardAction: function() {
					var action = arguments[0] || arguments[3];
					var validationInfo = this.get("DueDateValidationInfo");
					if (action === "save" && !this.Ext.isEmpty(validationInfo) && !validationInfo.isValid) {
						this.showConfirmationDialogForDueDate();
						return;
					}
					if (action !== "onCloseClick") {
						this.updateProductConditionDetail();
					}
					this.callParent(arguments);
				},

				/**
				 * Displays a confirmation window.
				 * @protected
				 */
				showConfirmationDialogForDueDate: function() {
					var validationInfo = this.get("DueDateValidationInfo");
					this.showConfirmationDialog(validationInfo.message, this.onConfirmationDialogButtonClick, ["yes", "no"]);
				},

				/**
				 * Handles the user's choice in the confirmation window.
				 * If the user clicks "Yes", then save the record occurs. If "No",
				 * then cancels the save and returns to the editing card.
				 * @param {String} result Button code, which the user clicked.
				 * @protected
				 */
				onConfirmationDialogButtonClick: function(result) {
					if (result === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
						if (this.isDueDateExpire()) {
							this.set("ProductStatus", this.get("ProductCompleteStatus"));
						}
						this.updateProductConditionDueDate();
					} else {
						return false;
					}
				},

				/**
				 * Updates due date in accordance with the new due date of the product.
				 * @protected
				 */
				updateProductConditionDueDate: function() {
					var update = Ext.create("Terrasoft.UpdateQuery", {
						rootSchemaName: "ProductCondition"
					});
					update.filters.addItem(this.getProductConditionFilter());
					update.setParameterValue("DueDate", this.get("DueDate"), Terrasoft.DataValueType.DATE);
					update.execute(this.onUpdateProductConditionDueDateResponse, this);
				},

				/**
				 * Creates a filter for the due date conditions update request.
				 * Should be selected records that do not have due date or due date is longer than due date of the product.
				 * @return {Terrasoft.FilterGroup} Filter group.
				 * @protected
				 */
				getProductConditionFilter: function() {
					var mainFilterGroup = this.Terrasoft.createFilterGroup();
					var dueDatefilterGroup = this.Terrasoft.createFilterGroup();
					var productPrymaryColumnVal = this.get(this.primaryColumnName);
					dueDatefilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					dueDatefilterGroup.add("DueDate", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.GREATER, "DueDate", this.get("DueDate")));
					dueDatefilterGroup.add("DueDateNull", this.Terrasoft.createColumnIsNullFilter("DueDate"));
					mainFilterGroup.logicalOperation = Terrasoft.LogicalOperatorType.AND;
					mainFilterGroup.add("DueDateGroup", dueDatefilterGroup);
					mainFilterGroup.add("ProductCondition", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Product", productPrymaryColumnVal));
					return mainFilterGroup;
				},

				/**
				 * Saves the product and reload the product condition detail after a successful update
				 * due date of the product.
				 * @param {Object} result Server response.
				 * @protected
				 */
				onUpdateProductConditionDueDateResponse: function(result) {
					if (result.success) {
						this.save();
						this.set("DueDateValidationInfo", {
							isValid: true
						});
						this.updateProductConditionDetail();
					}
				},

				/**
				 * Performs update detail ProductConditionDetailV2.
				 */
				updateProductConditionDetail: function() {
					var detailConfig = this.details.ProductConditionDetailV2;
					detailConfig.detail = "ProductConditionDetailV2";
					this.updateDetail(detailConfig);
				},

				/**
				 * Checks whether the current date is greater than the end date.
				 * @return {Boolean} Returns "true", if current date is greater than due date of product
				 * and "false" if it is not.
				 * @protected
				 */
				isDueDateExpire: function() {
					var dueDate = this.get("DueDate");
					var clearDueDate = this.Ext.Date.clearTime(dueDate);
					var clearNow = this.Ext.Date.clearTime(new Date(this.Ext.Date.now()));
					return !this.Ext.isEmpty(dueDate) && clearDueDate < clearNow;
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSchemaModuleV2#destroy
				 * @override
				 */
				destroy: function() {
					this.unsubscribeOnColumnChange("DueDate", this.onDueDateChange);
					this.callParent(arguments);
				}
			},
			rules: {
				"StartDate": {
					"RequiredByStatus": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.REQUIRED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "ProductStatus"
							},
							comparisonType: Terrasoft.ComparisonType.NOT_EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: BaseFinanceConstants.ProductStatus.InDevelop
							}
						}]
					}
				}
			}
		};
	});
