define("ProductPageV2", ["BusinessRuleModule", "BaseFinanceConstants"],
	function(BusinessRuleModule, BaseFinanceConstants) {
		return {
			entitySchemaName: "Product",
			details: /**SCHEMA_DETAILS*/ {
				"ProductSpecificationDetail": {
					"schemaName": "ProductSpecificationDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Product"
					}
				},
				"ProductFile": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "ProductFile",
					"filter": {
						"detailColumn": "Product",
						"masterColumn": "Id"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
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
								"wrapClassName": [""]
							}
						},
						"controlWrapConfig": {
							"classes": {
								"wrapClassName": [""]
							}
						},
						"tabIndex": 2
					}
				}, {
					"operation": "merge",
					"name": "Category",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 3
					}
				}, {
					"operation": "move",
					"name": "Category",
					"parentName": "Header",
					"propertyName": "items",
					"index": 1
				}, {
					"operation": "merge",
					"name": "Type",
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
					"operation": "move",
					"name": "Type",
					"parentName": "Header",
					"propertyName": "items",
					"index": 2
				}, {
					"operation": "insert",
					"name": "ProductKind",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ProductKind",
						"contentType": 3,
						"tabIndex": 5
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 3
				}, {
					"operation": "insert",
					"name": "ProductStatus",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ProductStatus",
						"contentType": 3,
						"tabIndex": 6
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 4
				}, {
					"operation": "insert",
					"name": "StartDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "StartDate",
						"tabIndex": 7
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 5
				}, {
					"operation": "insert",
					"name": "DueDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "DueDate",
						"tabIndex": 8
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 6
				}, {
					"operation": "merge",
					"name": "ProductGeneralInfoTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.ProductGeneralInfoTabCaption"
						}
					}
				}, {
					"operation": "insert",
					"name": "ProductFile",
					"values": {
						"itemType": 2
					},
					"parentName": "ProductGeneralInfoTab",
					"propertyName": "items",
					"index": 0
				},

				{
					"operation": "insert",
					"name": "DescriptionGroup",
					"parentName": "ProductGeneralInfoTab",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"controlConfig": {
							"collapsed": false
						},
						"caption": {
							"bindTo": "Resources.Strings.DescriptionGroupCaption"
						}
					}
				}, {
					"operation": "insert",
					"name": "Description",
					"values": {
						"contentType": Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"controlConfig": {
							"imageLoaded": {
								"bindTo": "insertImagesToProductFinance"
							},
							"plainTextValue": {
								"bindTo": "NotHtmlNote"
							},
							"images": {
								"bindTo": "productFinanceImagesCollection"
							},
							"plainTextMode": {
								"bindTo": "plainTextMode"
							}
						},
						"tabIndex": 9
					},
					"parentName": "DescriptionGroup",
					"propertyName": "items",
					"index": 2
				}, {
					"operation": "merge",
					"name": "ProductSpecificationTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.ProductSpecificationTabCaption"
						}
					}
				}, {
					"operation": "remove",
					"name": "CommonControlGroup"
				}, {
					"operation": "merge",
					"name": "PhotoContainer",
					"values": {
						"visible": {
							"bindTo": "getPhotoContainerVisible"
						}
					}
				}, {
					"operation": "remove",
					"name": "Code"
				}, {
					"operation": "remove",
					"name": "Owner"
				}, {
					"operation": "remove",
					"name": "URL"
				}, {
					"operation": "remove",
					"name": "IsArchive"
				}, {
					"operation": "remove",
					"name": "ProductCategoryControlGroup"
				}, {
					"operation": "remove",
					"name": "ProductCategoryBlock"
				}, {
					"operation": "remove",
					"name": "TradeMark"
				}, {
					"operation": "remove",
					"name": "PriceControlGroup"
				}, {
					"operation": "remove",
					"name": "ProductPriceBlock"
				}, {
					"operation": "remove",
					"name": "Price"
				}, {
					"operation": "remove",
					"name": "Tax"
				}, {
					"operation": "remove",
					"name": "Currency"
				}, {
					"operation": "remove",
					"name": "Unit"
				}, {
					"operation": "remove",
					"name": "ProductUnitDetail"
				}, {
					"operation": "remove",
					"name": "ProductPricesTab"
				}, {
					"operation": "remove",
					"name": "ProductPriceDetail"
				}, {
					"operation": "remove",
					"name": "ProductStockBalance"
				}, {
					"operation": "remove",
					"name": "ProductFilesTab"
				}, {
					"operation": "remove",
					"name": "Files"
				}, {
					"operation": "remove",
					"name": "NotesControlGroup"
				}, {
					"operation": "remove",
					"name": "Notes"
				}, {
					"operation": "move",
					"name": "ESNTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 2
				}
			] /**SCHEMA_DIFF*/ ,
			attributes: {
				"type": {
					name: "Type",
					dataValueType: Terrasoft.DataValueType.ENUM,
					dependencies: [{
						columns: ["Category"],
						methodName: "onCategoryChange"
					}]
				},
				"kind": {
					name: "Kind",
					dataValueType: Terrasoft.DataValueType.ENUM,
					dependencies: [{
						columns: ["Type"],
						methodName: "onTypeChange"
					}]
				},
				"dueDate": {
					name: "DueDate",
					dataValueType: Terrasoft.DataValueType.DATE,
					dependencies: [{
						columns: ["ProductStatus"],
						methodName: "autocompleteDueDate"
					}]
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * Automatic completion of the "End Date" field if the status is "Outdated".
				 * @private
				 */
				autocompleteDueDate: function() {
					var productStatus = this.get("ProductStatus");
					if (productStatus && productStatus.value === BaseFinanceConstants.ProductStatus.IsNotActual) {
						var dueDate = this.get("DueDate");
						if (!this.Ext.isDate(dueDate)) {
							var today = this.Ext.Date.clearTime(new Date());
							this.set("DueDate", today);
						}
					}
				},
				/**
				 * Cleaning fields depending on category field.
				 * @private
				 */
				onCategoryChange: function() {
					this.set("Type", null);
					this.set("ProductKind", null);
					this.setValidationInfo("Type", true, "");
					this.setValidationInfo("ProductKind", true, "");
				},
				/**
				 * Cleaning fields depending on type field.
				 * @private
				 */
				onTypeChange: function() {
					this.set("ProductKind", null);
					this.setValidationInfo("ProductKind", true, "");
				},
				/**
				 * Insertion image in htmlEditor.
				 * @param {object[]} files Files selected for download.
				 * @private
				 */
				insertImagesToProductFinance: function(files) {
					var scope = this;
					Terrasoft.each(files, function(file) {
						var reader = new FileReader();
						reader.file = file;
						reader.onload = function(result) {
							var target = result.target;
							var currentFile = target.file;
							var image = this.Ext.create("Terrasoft.BaseViewModel", {
								values: {
									fileName: currentFile.name,
									url: target.result
								}
							});
							var imagesCollection = scope.get("productFinanceImagesCollection");
							if (imagesCollection) {
								imagesCollection.add(imagesCollection.getUniqueKey(), image);
							}
						};
						reader.readAsDataURL(reader.file);
					}, this);
				},
				/**
				 * Initializes properties for HtmlEditor.
				 * @private
				 */
				initializeHtmlEditor: function() {
					this.set("productFinanceImagesCollection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
					this.set("plainTextMode", false);
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#validate.
				 * @protected
				 * @overridden
				 */
				validate: function() {
					var isValid = this.callParent(arguments);
					if (!isValid) {
						return false;
					}
					var productStatus = this.get("ProductStatus") ? this.get("ProductStatus").value : null;
					if (productStatus === BaseFinanceConstants.ProductStatus.IsNotActual) {
						var dueDate = this.get("DueDate");
						var startDate = this.get("StartDate");
						if (this.Ext.isDate(dueDate) && this.Ext.isDate(startDate) &&
							this.Ext.Date.clearTime(startDate) > this.Ext.Date.clearTime(dueDate)) {
							this.showInformationDialog(this.get("Resources.Strings.NotValidDate"));
							return false;
						}
					}
					return true;
				},
				/**
				 * @inheritdoc Terrasoft.BasePageV2ViewModel#init.
				 * @protected
				 * @overridden
				 */
				init: function() {
					this.initializeHtmlEditor();
					this.callParent(arguments);
				},

				/**
				 * Gets if photo container is visible.
				 * @protected
				 */
				getPhotoContainerVisible: function() {
					return this.getIsFeatureEnabled("UseNewProductSelection");
				}

				//endregion

			},
			rules: {
				"Type": {
					"FiltrationTypeByCategory": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						autocomplete: true,
						autoClean: true,
						baseAttributePatch: "Category",
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						attribute: "Category"
					}
				},
				"ProductKind": {
					"FiltrationTypeByType": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						autocomplete: true,
						autoClean: true,
						baseAttributePatch: "ProductType",
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						attribute: "Type"
					},
					"FiltrationTypeByCategory": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						autocomplete: true,
						autoClean: true,
						baseAttributePatch: "ProductCategory",
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						attribute: "Category"
					}
				},
				"DueDate": {
					"RequiredByStatus": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.REQUIRED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "ProductStatus"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: BaseFinanceConstants.ProductStatus.IsNotActual
							}
						}]
					}
				}
			}
		};
	});
