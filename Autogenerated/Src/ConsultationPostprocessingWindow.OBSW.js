define("ConsultationPostprocessingWindow", ["ModalBox", "CaseConsultationTheme", "ConfigurationItemGenerator",
		"PostprocessingCaseConsultationThemeViewModel"
	],
	function(ModalBox, CaseConsultationTheme) {
		return {
			entitySchemaName: "Case",
			messages: {

				/**
				 * @message CompleteConsultation
				 * Message informs that the consultation is completed.
				 * {Object} config Configuration object.
				 */
				"CompleteConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message GetCurrentConsultationInfo
				 * Message gets the information of the current consultation.
				 * {Object} config Configuration object.
				 */
				"GetCurrentConsultationInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message ClearConsultationPanelData
				 * Clears consultation panel data.
				 */
				"ClearConsultationPanelData": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {

				/**
				 * Case identifier.
				 * @protected
				 * @type {Guid}
				 */
				"CaseId": {
					"dataValueType": Terrasoft.DataValueType.GUID
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.set("CaseConsultationThemeCollection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
					this.callParent([function() {
						this.initCurrentConsultationInfo();
						callback.call(scope || this);
					}, this]);
				},

				/**
				 * Returns consultation panel identifier.
				 * @protected
				 * @return {String} Consultation panel identifier.
				 */
				getConsultationPanelModuleId: function() {
					return this.sandbox.id.replace("_ConsultationPostprocessingWindow", "");
				},

				/**
				 * Returns OBSW module identifier.
				 * @protected
				 * @return {String} OBSW module identifier.
				 */
				getOBSWModuleId: function() {
					return this.sandbox.id.replace("_OBSWConsultationPanelSchemaModule_ConsultationPostprocessingWindow", "");
				},

				/**
				 * Initializes current consultation information.
				 * @protected
				 */
				initCurrentConsultationInfo: function() {
					var config = this.sandbox.publish("GetCurrentConsultationInfo", null, [this.getConsultationPanelModuleId()]);
					if (this.Ext.isObject(config)) {
						this.setPageData(config);
					}
				},

				/**
				 * Sets page data.
				 * @protected
				 * @param {Object} config Configuration object.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				setPageData: function(config, callback, scope) {
					if (!config || !config.caseId) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
						return;
					}
					var caseId = config.caseId;
					var maskId = this.showBodyMask();
					this.setCaseData(config);
					this.setHeaderCaption();
					this.changedValues = {};
					this.Terrasoft.chain(
						function(next) {
							this.loadCaseConsultationThemes(caseId, next, this);
						},
						function() {
							this.hideBodyMask(maskId);
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this);
							}
						},
						this
					);
				},

				/**
				 * Returns case consultation theme class.
				 * @protected
				 * @return {Object} Case consultation theme class.
				 */
				getCaseConsultationThemeClass: function() {
					return CaseConsultationTheme;
				},

				/**
				 * Returns case consultation theme view model class name.
				 * @protected
				 * @return {String} Case consultation theme view model class name.
				 */
				getCaseConsultationThemeViewModelClassName: function() {
					return "Terrasoft.PostprocessingCaseConsultationThemeViewModel";
				},

				/**
				 * Returns Case consultation themes query.
				 * @protected
				 * @return {Terrasoft.EntitySchemaQuery} Case consultation themes query.
				 */
				getCaseConsultationThemesQuery: function() {
					return Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchema: this.getCaseConsultationThemeClass(),
						rowViewModelClassName: this.getCaseConsultationThemeViewModelClassName()
					});
				},

				/**
				 * Loads case consultation themes.
				 * @protected
				 * @param {Guid} caseId Case identifier.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				loadCaseConsultationThemes: function(caseId, callback, scope) {
					var esq = this.getCaseConsultationThemesQuery();
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					esq.addColumn("Theme");
					esq.addColumn("Result");
					esq.addColumn("Comment");
					esq.addColumn("Theme.Block");
					esq.addColumn("Theme.Parent");
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Case", caseId));
					esq.getEntityCollection(function(result) {
						if (result.success) {
							var entityCollection = result.collection;
							var collection = this.get("CaseConsultationThemeCollection");
							collection.clear();
							collection.loadAll(entityCollection);
						}
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}, this);
				},

				/**
				 * Sets case data.
				 * @protected
				 * @param {Object} config Configuration object.
				 */
				setCaseData: function(config) {
					this.set("CaseId", config.caseId);
					this.set("Contact", config.contact);
					this.set("Account", config.account);
					this.set("Symptoms", config.symptoms);
					this.set("Number", config.number);
					this.set("Status", config.status);
				},

				/**
				 * Sets page header caption.
				 * @protected
				 */
				setHeaderCaption: function() {
					var caption = this.get("Resources.Strings.HeaderCaption");
					var number = this.get("Number");
					caption = this.Ext.String.format(caption, number);
					this.set("HeaderCaption", caption);
				},

				/**
				 * Cancel button click handler.
				 * @protected
				 */
				onCancelButtonClick: function() {
					ModalBox.close();
				},

				/**
				 * Complete button click handler.
				 * @protected
				 */
				onCompleteButtonClick: function() {
					if (!this.validateCaseConsultationThemeItems()) {
						return;
					}
					var config = {
						caseId: this.get("CaseId")
					};
					var maskId = this.showBodyMask();
					this.saveData(function() {
						this.hideBodyMask(maskId);
						this.sandbox.publish("CompleteConsultation", config, [this.getOBSWModuleId()]);
						this.sandbox.publish("ClearConsultationPanelData", config, [this.getConsultationPanelModuleId()]);
						ModalBox.close();
					}, this);
				},

				/**
				 * Showes body mask.
				 * @protected
				 * @return {String} maskId Mask identifer.
				 */
				showBodyMask: function() {
					return this.Terrasoft.Mask.show({
						selector: ".consultation-postprocessing-page-modal-box",
						timeout: 0
					});
				},

				/**
				 * Hides body mask.
				 * protected
				 * @param {String} maskId Mask identifer.
				 */
				hideBodyMask: function(maskId) {
					this.Terrasoft.Mask.hide(maskId);
				},

				/**
				 * Validates case consultation items.
				 * @protected
				 * @return {Boolean} Validate result.
				 */
				validateCaseConsultationThemeItems: function() {
					var result = true;
					var collection = this.get("CaseConsultationThemeCollection");
					collection.each(function(item) {
						result = item.validate();
						return result;
					}, this);
					return result;
				},

				/**
				 * Returns case update query.
				 * @protected
				 * @return {Terrasoft.UpdateQuery} Case update query.
				 */
				getUpdateCaseQuery: function() {
					var updateQuery = this.Ext.create("Terrasoft.UpdateQuery", {
						rootSchemaName: this.entitySchemaName
					});
					updateQuery.enablePrimaryColumnFilter(this.get("CaseId"));
					updateQuery.setParameterValue("Symptoms", this.get("Symptoms"), Terrasoft.DataValueType.TEXT);
					return updateQuery;
				},

				/**
				 * Saves page data.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				saveData: function(callback, scope) {
					var queries = [];
					var batchQuery = Ext.create("Terrasoft.BatchQuery");
					var changedValues = this.changedValues;
					if (changedValues && changedValues.Symptoms) {
						queries.push(this.getUpdateCaseQuery());
					}
					queries = queries.concat(this.getSaveCaseConsultationThemeItemsQueries());
					this.Terrasoft.each(queries, function(query) {
						batchQuery.add(query);
					}, this);
					batchQuery.execute(callback, scope);
				},

				/**
				 * Returns save case consultation theme items queries.
				 * @protected
				 * @return {Array} Save queries array.
				 */
				getSaveCaseConsultationThemeItemsQueries: function() {
					var collection = this.get("CaseConsultationThemeCollection");
					var saveQueries = [];
					collection.each(function(item) {
						if (item.changedValues) {
							var query = item.getSaveQuery();
							if (query) {
								saveQueries.push(query);
							}
						}
					}, this);
					return saveQueries;
				},

				/**
				 * Returns default case consultation theme item view config.
				 * @protected
				 * @param  {Terrasoft.BaseViewModel} item Item ViewModel.
				 * @return {Object} Item view config.
				 */
				getDefaultConsultationThemeItemViewConfig: function(item) {
					var itemId = item.get("Id");
					var defaultItemConfig = {
						"id": itemId + "ConsultationThemeItemContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"name": "ConsultationThemeItemContainer",
						"wrapClass": ["consultation-theme-item-container"],
						"items": [{
							"id": itemId + "ConsultationThemeItemGRIDLAYOUT",
							"name": "ConsultationThemeItemGRIDLAYOUT",
							"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": [{
								"id": itemId + "ThemeEdit",
								"itemType": Terrasoft.ViewItemType.MODEL_ITEM,
								"name": "Theme",
								"dataValueType": Terrasoft.DataValueType.LOOKUP,
								"contentType": Terrasoft.ContentType.ENUM,
								"layout": {
									"column": 0,
									"row": 0,
									"colSpan": 12
								},
								"value": {
									"bindTo": "Theme"
								},
								"tag": "Theme",
								"controlConfig": {
									"enableLocalFilter": true,
									"filterComparisonType": Terrasoft.StringFilterType.CONTAIN
								}
							}, {
								"id": itemId + "ResultEdit",
								"itemType": Terrasoft.ViewItemType.MODEL_ITEM,
								"name": "Result",
								"dataValueType": Terrasoft.DataValueType.LOOKUP,
								"contentType": Terrasoft.ContentType.ENUM,
								"layout": {
									"column": 0,
									"row": 1,
									"colSpan": 12
								},
								"value": {
									"bindTo": "Result"
								},
								"tag": "Result"
							}, {
								"id": itemId + "CommentEdit",
								"itemType": Terrasoft.ViewItemType.MODEL_ITEM,
								"name": "Comment",
								"dataValueType": Terrasoft.DataValueType.TEXT,
								"contentType": Terrasoft.ContentType.LONG_TEXT,
								"layout": {
									"column": 12,
									"row": 0,
									"colSpan": 12,
									"rowSpan": 2
								},
								"value": {
									"bindTo": "Comment"
								},
								"tag": "Comment"
							}]
						}]
					};
					return defaultItemConfig;
				},

				/**
				 * Generates case consultation theme item view config.
				 * @protected
				 * @param {Object} itemConfig Item view config.
				 * @param  {Terrasoft.BaseViewModel} item Item ViewModel.
				 */
				getConsultationThemeItemViewConfig: function(itemConfig, item) {
					var defaultViewConfig = this.getDefaultConsultationThemeItemViewConfig(item);
					var viewGenerator = this.createViewGeneratorInstance();
					var itemViewConfig = viewGenerator.generateView([defaultViewConfig]);
					itemViewConfig = this.Ext.isArray(itemViewConfig) ? itemViewConfig[0] : itemViewConfig;
					itemConfig.config = itemViewConfig;
					viewGenerator.destroy();
					viewGenerator = null;
				},

				/**
				 * Create instance of View Generator.
				 * @protected
				 * @return {Terrasoft.ViewGenerator}
				 */
				createViewGeneratorInstance: function() {
					return Ext.create("Terrasoft.ViewGenerator", {
						viewModelClass: {
							prototype: this.getCaseConsultationThemeClass()
						}
					});
				},

				/**
				 * Add new record button click handler.
				 * @protected
				 */
				onAddRecordButtonClick: function() {
					var collection = this.get("CaseConsultationThemeCollection");
					var newEntity = this.createNewCaseConsultationThemeViewModel();
					var id = newEntity.get("Id");
					collection.insert(0, id, newEntity);
				},

				/**
				 * Creates new case consultation theme view model.
				 * @protected
				 * @return {Terrasoft.BaseViewModel} New case consultation theme view model.
				 */
				createNewCaseConsultationThemeViewModel: function() {
					var entityClass = this.getCaseConsultationThemeClass();
					var currentDate = new Date(this.Ext.Date.now());
					var values = {
						Id: this.Terrasoft.generateGUID(),
						Case: {
							value: this.get("CaseId")
						},
						DateTimeStart: currentDate,
						DateTimeEnd: currentDate
					};
					return this.Ext.create(this.getCaseConsultationThemeViewModelClassName(), {
						entitySchema: entityClass,
						columns: entityClass.columns,
						isNew: true,
						changedValues: values,
						values: values
					});
				}
			},
			diff: [{
				"operation": "insert",
				"name": "ConsultationPostprocessingContainer",
				"values": {
					"id": "ConsultationPostprocessingContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["consultation-postprocessing-container"],
					"markerValue": "ConsultationPostprocessingContainer",
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "HeaderContainer",
				"parentName": "ConsultationPostprocessingContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["header-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "HeaderCaptionContainer",
				"parentName": "HeaderContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["header-caption-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "HeaderCaption",
				"parentName": "HeaderCaptionContainer",
				"propertyName": "items",
				"values": {
					"labelClass": ["header-caption-label"],
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "HeaderCaption"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "HeaderContainer",
				"propertyName": "items",
				"name": "CloseIconContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["close-icon-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "CloseIconContainer",
				"propertyName": "items",
				"name": "CloseIconButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.CloseIcon"
					},
					"classes": {
						"wrapperClass": ["close-icon-button"]
					},
					"click": {
						"bindTo": "onCancelButtonClick"
					}
				}
			}, {
				"operation": "insert",
				"name": "MainContentContainer",
				"parentName": "ConsultationPostprocessingContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["main-content-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "MainContent",
				"parentName": "MainContentContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "Contact",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					},
					"enabled": false,
					"showValueAsLink": false,
					"bindTo": "Contact"
				},
				"parentName": "MainContent",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Account",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					},
					"enabled": false,
					"showValueAsLink": false,
					"bindTo": "Account"
				},
				"parentName": "MainContent",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Status",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					},
					"showValueAsLink": false,
					"enabled": false,
					"isRequired": false,
					"bindTo": "Status"
				},
				"parentName": "MainContent",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Symptoms",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 3
					},
					"contentType": Terrasoft.ContentType.LONG_TEXT,
					"enabled": true,
					"bindTo": "Symptoms"
				},
				"parentName": "MainContent",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "ConsultationThemesContainer",
				"parentName": "ConsultationPostprocessingContainer",
				"propertyName": "items",
				"values": {
					"wrapClass": ["consultation-themes-container"],
					"markerValue": "ConsultationThemesContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "ConsultationThemesControlGroup",
				"parentName": "ConsultationThemesContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"caption": {
						"bindTo": "Resources.Strings.ConsultationThemesControlGroupCaption"
					},
					"tools": [],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "AddRecordButton",
				"parentName": "ConsultationThemesControlGroup",
				"propertyName": "tools",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"click": {
						"bindTo": "onAddRecordButtonClick"
					},
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.AddButtonImage"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "ConsultationThemesControlGroup",
				"name": "ConsultationThemes",
				"propertyName": "items",
				"values": {
					"classes": {
						"wrapClassName": ["consultation-themes-container-list"]
					},
					"markerValue": "ConsultationThemesContainerList",
					"generator": "ConfigurationItemGenerator.generateContainerList",
					"idProperty": "Id",
					"itemPrefix": "Id",
					"collection": "CaseConsultationThemeCollection",
					"dataItemIdPrefix": "consultation-theme-item",
					"selectableRowCss": "",
					"onGetItemConfig": "getConsultationThemeItemViewConfig"

				}
			}, {
				"operation": "insert",
				"name": "ActionButtonContainer",
				"parentName": "ConsultationPostprocessingContainer",
				"propertyName": "items",
				"values": {
					"wrapClass": ["action-button-container"],
					"markerValue": "ActionButtonContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ActionButtonContainer",
				"propertyName": "items",
				"name": "CompleteButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.CompleteButtonCaption"
					},
					"classes": {
						"textClass": "actions-button"
					},
					"style": Terrasoft.controls.ButtonEnums.style.GREEN,
					"tag": "completeButton",
					"markerValue": "CompleteButton",
					"click": {
						"bindTo": "onCompleteButtonClick"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "ActionButtonContainer",
				"propertyName": "items",
				"name": "CancelButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.CancelButtonCaption"
					},
					"classes": {
						"textClass": "actions-button"
					},
					"style": Terrasoft.controls.ButtonEnums.style.DEFAULT,
					"tag": "CancelButton",
					"markerValue": "CancelButton",
					"click": {
						"bindTo": "onCancelButtonClick"
					}
				}
			}]
		};
	});
