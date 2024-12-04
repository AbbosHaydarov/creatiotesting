define("AppValidationUserTaskPropertiesPage", ["BusinessRuleModule", "FinAppLendingConstants",
		"AppValidationUserTaskPropertiesPageResources", "css!FinAppLendingCSS"
	],
	function(BusinessRuleModule, FinAppLendingConstants) {
		var AppValidationEnum = FinAppLendingConstants.AppValidation;
		return {
			attributes: {
				"PageUId": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"referenceSchemaName": "SysSchema",
					"initMethod": "initPageUId",
					"isRequired": true
				},
				"FinApplication": {
					"dataValueType": this.Terrasoft.DataValueType.MAPPING,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"doAutoSave": true,
					"initMethod": "initPropertySilent",
					"isRequired": true
				},
				"ParticipantRole": {
					"dataValueType": this.Terrasoft.DataValueType.MAPPING,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"doAutoSave": true,
					"initMethod": "initPropertySilent"
				},
				"Participant": {
					"dataValueType": this.Terrasoft.DataValueType.MAPPING,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"doAutoSave": true,
					"initMethod": "initPropertySilent"
				},
				"Role": {
					"dataValueType": this.Terrasoft.DataValueType.MAPPING,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"doAutoSave": true,
					"initMethod": "initPropertySilent"
				},
				"ValidationItem": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"doAutoSave": false,
					"referenceSchemaName": "AppValidationItem",
					"initMethod": "initValidationItem",
					"isRequired": true
				},
				"OwnerId": {
					"dataValueType": this.Terrasoft.DataValueType.MAPPING,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"doAutoSave": true,
					"initMethod": "initPropertySilent"
				},
				"ConductVerificationMode": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"initMethod": "initEnumParameter",
					"isRequired": true
				},
				"PerformActionMode": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"initMethod": "initEnumParameter",
					"isRequired": true
				},
				"ValidationDisplayMode": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"initMethod": "initEnumParameter",
					"isRequired": true
				},
				"CurrentAppValidationId": {
					"dataValueType": this.Terrasoft.DataValueType.MAPPING,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"doAutoSave": true,
					"initMethod": "initPropertySilent"
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * Returns enum parameter list.
				 * @private
				 * @param {String} parameterName Parameter name.
				 * @return {Object} List.
				 */
				getEnumParameterList: function(parameterName) {
					var list = {};
					var methodName = this.Ext.String.format("get{0}List", parameterName);
					if (this.Ext.isFunction(this[methodName])) {
						list = this[methodName]();
					}
					return list;
				},

				/**
				 * The event handler for preparing of the data drop-down enum parameter.
				 * @private
				 * @param {Object} filter Filters for data preparation.
				 * @param {Terrasoft.Collection} list The data for the drop-down list.
				 * @param {String} tag Tag.
				 */
				prepareEnumParameterList: function(filter, list, tag) {
					if (this.Ext.isEmpty(list)) {
						return;
					}
					var newList = this.getEnumParameterList(tag);
					list.clear();
					list.loadAll(newList);
				},

				/**
				 * Sets lookup attribute value.
				 * @private
				 * @param {String} attributeName Attribute name.
				 * @param {String} value Value.
				 * @param {String} displayValue Display value.
				 */
				setLookupAttribute: function(attributeName, value, displayValue) {
					this.set(attributeName, {
						"value": value,
						"displayValue": displayValue
					});
				},

				/**
				 * Initialize validation item Lookup attribute.
				 * @private
				 * @param {Terrasoft.ProcessSchemaParameter} parameter Process parameter.
				 */
				initValidationItem: function(parameter) {
					if (parameter.dataValueType === this.Terrasoft.DataValueType.LOOKUP) {
						var parameterName = parameter.name;
						var value = parameter.getValue();
						var displayValue = parameter.getParameterDisplayValue();
						var sourceValue = parameter.sourceValue;
						this.setLookupAttribute(parameterName, value, displayValue);
						this.set("ValidationItemSource", sourceValue.source);
						if (value) {
							var isMapping = this.Terrasoft.ProcessSchemaDesignerUtilities
								.getIsMappingParameterValue(parameter.sourceValue);
							if (!isMapping) {
								this.loadLookupDisplayValue(parameter.referenceSchemaName, value, function(result) {
									this.setLookupAttribute(parameterName, value, result.displayValue);
								});
							}
						} else {
							this.set(parameterName, null);
							this.setValidationInfo(parameterName, true, null);
						}
					} else {
						this.initProperty(parameter);
					}
				},

				/**
				 * Returns validation page check result.
				 * @private
				 * @param {Terrasoft.ClientUnitSchemaManagerItem} schema Schema.
				 * @return {Boolean}
				 */
				isAppValidationPage: function(schema) {
					schema = schema || {};
					var appValidationPageUId = AppValidationEnum.DefaultAppValidationPage.uId;
					var schemaParentUId = schema.parentUId;
					if (schema.uId === appValidationPageUId || schemaParentUId === appValidationPageUId) {
						return true;
					} else if (this.Ext.isEmpty(schemaParentUId)) {
						return false;
					} else {
						var parentSchema = this.Terrasoft.ClientUnitSchemaManager.getItem(schemaParentUId);
						return this.isAppValidationPage(parentSchema);
					}
				},

				/**
				 * Filters collection.
				 * @private
				 * @param {Terrasoft.Collection} schemas Original collection.
				 * @return {Terrasoft.Collection} Filtered collection.
				 */
				filterPageList: function(schemas) {
					return schemas.filter(function(schema) {
						var isAppValidationPage = this.isAppValidationPage(schema);
						return !schema.getExtendParent() && isAppValidationPage;
					}.bind(this));
				},

				/**
				 * Initializes PageList attribute.
				 * @private
				 */
				initPageList: function() {
					var pageList = this.Ext.create("Terrasoft.Collection");
					var schemas = this.Terrasoft.ClientUnitSchemaManager.getItems();
					schemas = this.filterPageList(schemas);
					this.Terrasoft.each(schemas.getItems(), function(schema) {
						var uId = schema.uId;
						pageList.add(uId, {
							displayValue: schema.caption,
							name: schema.name,
							value: uId
						});
					}, this);
					pageList.sort("displayValue", this.Terrasoft.OrderDirection.ASC);
					this.set("PageList", pageList);
				},

				/**
				 * The event handler for preparing page schemas drop-down list.
				 * @private
				 * @param {Object} filter Filters for data preparation.
				 * @param {Terrasoft.Collection} list The data for the drop-down list.
				 */
				onPreparePageList: function(filter, list) {
					if (this.Terrasoft.isEmptyObject(list)) {
						return;
					}
					list.clear();
					var selectedSchema = this.get("PageUId");
					var pageSchemas = this.get("PageList");
					if (selectedSchema) {
						pageSchemas = pageSchemas.filterByFn(function(schema) {
							return schema.value !== selectedSchema.value;
						});
					}
					list.loadAll(pageSchemas);
				},

				/**
				 * Sets attribute "PageUId".
				 * @private
				 * @param {Terrasoft.ProcessSchemaParameter} parameter Process parameter.
				 */
				initPageUId: function(parameter) {
					var pageUId = parameter.getValue();
					if (this.Ext.isEmpty(pageUId) || this.Terrasoft.isEmptyGUID(pageUId)) {
						pageUId = AppValidationEnum.DefaultAppValidationPage.uId;
					}
					var pageList = this.get("PageList");
					var pageItem;
					this.Terrasoft.each(pageList.getItems(), function(page) {
						if (page.value === pageUId) {
							pageItem = page;
							return false;
						}
					}, this);
					this.set("PageUId", pageItem);
				},

				/**
				 * Initialization enum parameter value.
				 * @private
				 * @param {Terrasoft.ProcessSchemaParameter} parameter Process parameter.
				 */
				initEnumParameter: function(parameter) {
					var parameterName = parameter.name;
					var parameterValue = parameter.getValue();
					var list = this.getEnumParameterList(parameterName);
					this.set(parameterName, list[parameterValue]);
					this.setValidationInfo(parameterName, true, null);
				},

				/**
				 * Returns ConductVerificationMode list.
				 * @private
				 * @return {Object}
				 */
				getConductVerificationModeList: function() {
					var list = {};
					var conductVerificationMode = AppValidationEnum.ConductVerificationMode;
					var oneParticipant = conductVerificationMode.OneParticipant;
					var moreParticipants = conductVerificationMode.MoreParticipants;
					var harmonizeApplication = conductVerificationMode.HarmonizeApplication;
					list[oneParticipant.value] = oneParticipant;
					list[moreParticipants.value] = moreParticipants;
					list[harmonizeApplication.value] = harmonizeApplication;
					return list;
				},

				/**
				 * Returns PerformActionMode list.
				 * @private
				 * @return {Object}
				 */
				getPerformActionModeList: function() {
					var list = {};
					var performActionMode = AppValidationEnum.PerformActionMode;
					var employeesGroup = performActionMode.EmployeesGroup;
					var responsibleOfficer = performActionMode.ResponsibleOfficer;
					list[employeesGroup.value] = employeesGroup;
					list[responsibleOfficer.value] = responsibleOfficer;
					return list;
				},

				/**
				 * Returns ValidationDisplayMode list.
				 * @private
				 * @return {Object}
				 */
				getValidationDisplayModeList: function() {
					var list = {};
					var validationDisplayMode = AppValidationEnum.ValidationDisplayMode;
					var addNewRecord = validationDisplayMode.AddNewRecord;
					var editExistingRecord = validationDisplayMode.EditExistingRecord;
					list[addNewRecord.value] = addNewRecord;
					list[editExistingRecord.value] = editExistingRecord;
					return list;
				},

				/**
				 * Saves page type identifier value.
				 * @private
				 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
				 */
				savePageUId: function(element) {
					var parameter = element.findParameterByName("PageUId");
					var pageUId = this.get("PageUId");
					var sourceValue = {};
					if (this.Ext.isObject(pageUId)) {
						sourceValue = {
							value: pageUId.value,
							source: this.Terrasoft.ProcessSchemaParameterValueSource.ConstValue
						};
					}
					parameter.setMappingValue(sourceValue);
				},

				/**
				 * Saves enum parameter.
				 * @private
				 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
				 * @param {String} parameterName Parameter name.
				 */
				saveEnumParameter: function(element, parameterName) {
					var changes = this.changedValues;
					if (changes && changes.hasOwnProperty(parameterName)) {
						var parameter = element.findParameterByName(parameterName);
						var sourceValue = {};
						var attribute = this.get(parameterName);
						if (!Ext.isEmpty(attribute)) {
							var value = String(attribute.value);
							sourceValue = {
								value: value,
								source: this.Terrasoft.ProcessSchemaParameterValueSource.ConstValue
							};
						}
						parameter.setMappingValue(sourceValue);
					}
				},

				/**
				 * Validates mapping value.
				 * @private
				 * @param {Object} value Value.
				 * @param {Object} column Column.
				 * @return {Object} Validation object.
				 */
				validateMappingValue: function(value, column) {
					var result = {};
					if (this.Terrasoft.isEmptyObject(column)) {
						return result;
					}
					var mappingValue = this.Terrasoft.isEmptyObject(value) ? null : value.value;
					var isMapping = column.dataValueType === this.Terrasoft.DataValueType.MAPPING;
					if (column.isRequired && isMapping && this.Ext.isEmpty(mappingValue)) {
						result.invalidMessage = this.Terrasoft.Resources.BaseViewModel.columnRequiredValidationMessage;
					}
					return result;
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#init.
				 * @overridden
				 */
				init: function() {
					this.initPageList();
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc BaseUserTaskPropertiesPage#getResultParameterAllValues
				 * @overridden
				 */
				getResultParameterAllValues: function(callback, scope) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "AppValidationResult"
					});
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
					esq.execute(function(result) {
						var resultParameterValues = {};
						if (result.success === true) {
							result.collection.each(function(item) {
								var id = item.get("Id");
								var name = item.get("Name");
								resultParameterValues[id] = name;
							});
						}
						this.Ext.callback(callback, scope, [resultParameterValues]);
					}, this);
				},

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveParameters
				 * @overridden
				 */
				saveParameters: function(element) {
					this.saveConductVerificationModeParameters(element);
					this.savePerformActionModeParameters(element);
					this.saveValidationDisplayModeParameters(element);
					this.saveValidationItem(element);
					this.callParent(arguments);
					this.savePageUId(element);
					this.saveEnumParameter(element, "ConductVerificationMode");
					this.saveEnumParameter(element, "PerformActionMode");
					this.saveEnumParameter(element, "ValidationDisplayMode");
				},

				/**
				 * @inheritdoc BaseSchemaViewModel#setValidationConfig
				 * @overridden
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("FinApplication", this.validateMappingValue);
					this.addColumnValidator("ParticipantRole", this.validateMappingValue);
					this.addColumnValidator("Participant", this.validateMappingValue);
					this.addColumnValidator("Role", this.validateMappingValue);
					this.addColumnValidator("OwnerId", this.validateMappingValue);
					this.addColumnValidator("CurrentAppValidationId", this.validateMappingValue);
				},

				/**
				 * Save ConductVerificationMode parameters.
				 * @protected
				 */
				saveConductVerificationModeParameters: function() {
					var conductVerificationMode = AppValidationEnum.ConductVerificationMode;
					var oneParticipant = conductVerificationMode.OneParticipant;
					var moreParticipants = conductVerificationMode.MoreParticipants;
					var attribute = this.get("ConductVerificationMode") || {};
					switch (attribute.value) {
						case oneParticipant.value:
							break;
						case moreParticipants.value:
							this.set("Participant", null, {
								silent: true
							});
							break;
						default:
							this.set("ParticipantRole", null, {
								silent: true
							});
							this.set("Participant", null, {
								silent: true
							});
							break;
					}
				},

				/**
				 * Save validation item parameter.
				 * @protected
				 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
				 */
				saveValidationItem: function(element) {
					if (element) {
						var validationItem = this.get("ValidationItem");
						var parameter = element.findParameterByName("ValidationItem");
						if (parameter) {
							var sourceValue = {};
							if (validationItem && validationItem.value) {
								var displayValue = validationItem.displayValue;
								var value = validationItem.value;
								var source = this.Terrasoft.isGUID(value)
									? this.Terrasoft.ProcessSchemaParameterValueSource.ConstValue
									: this.get("ValidationItemSource");
								sourceValue = {
									displayValue: displayValue,
									value: value,
									source: source,
									dataValueType: parameter.dataValueType
								};
							} else {
								sourceValue = {
									value: null,
									source: this.Terrasoft.ProcessSchemaParameterValueSource.None
								};
							}
							parameter.setMappingValue(sourceValue);
						}
					}
				},

				/**
				 * Save PerformActionMode parameters.
				 * @protected
				 */
				savePerformActionModeParameters: function() {
					var performActionMode = AppValidationEnum.PerformActionMode;
					var employeesGroup = performActionMode.EmployeesGroup;
					var responsibleOfficer = performActionMode.ResponsibleOfficer;
					var attribute = this.get("PerformActionMode") || {};
					switch (attribute.value) {
						case employeesGroup.value:
							this.set("OwnerId", null, {
								silent: true
							});
							break;
						case responsibleOfficer.value:
							this.set("Role", null, {
								silent: true
							});
							break;
						default:
							this.set("OwnerId", null, {
								silent: true
							});
							this.set("Role", null, {
								silent: true
							});
							break;
					}
				},

				/**
				 * Save ValidationDisplayMode parameters.
				 * @protected
				 */
				saveValidationDisplayModeParameters: function() {
					var validationDisplayMode = AppValidationEnum.ValidationDisplayMode;
					var editExistingRecord = validationDisplayMode.EditExistingRecord;
					var attribute = this.get("ValidationDisplayMode") || {};
					if (attribute.value !== editExistingRecord.value) {
						this.set("CurrentAppValidationId", null, {
							silent: true
						});
					}
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "UserTaskContainer",
				"propertyName": "items",
				"parentName": "EditorsContainer",
				"className": "Terrasoft.GridLayoutEdit",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "TitleTaskContainer",
				"propertyName": "items",
				"parentName": "UserTaskContainer",
				"className": "Terrasoft.GridLayoutEdit",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "RecommendationLabel",
				"parentName": "TitleTaskContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.RecommendationCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			}, {
				"operation": "insert",
				"name": "MainContainer",
				"parentName": "UserTaskContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "ValidationItem",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"caption": {
						"bindTo": "Resources.Strings.ValidationItemCaption"
					},
					"wrapClass": ["no-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "FinApplication",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.LOOKUP,
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24
					},
					"caption": {
						"bindTo": "Resources.Strings.FinApplicationCaption"
					},
					"wrapClass": ["top-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "PageUId",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 24
					},
					"caption": {
						"bindTo": "Resources.Strings.PageUIdCaption"
					},
					"controlConfig": {
						"prepareList": {
							"bindTo": "onPreparePageList"
						},
						"filterComparisonType": this.Terrasoft.StringFilterType.CONTAIN
					},
					"wrapClass": ["top-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "ConductVerificationModeCaption",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.HowPerfomValidationCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			}, {
				"operation": "insert",
				"name": "ConductVerificationMode",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"prepareList": {
							"bindTo": "prepareEnumParameterList"
						}
					},
					"tag": "ConductVerificationMode",
					"wrapClass": ["no-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "ConductVerificationModeContainer",
				"propertyName": "items",
				"parentName": "MainContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 5,
						"colSpan": 24
					},
					"wrapClass": ["appValidation-properties-container"]
				}
			}, {
				"operation": "insert",
				"name": "ParticipantRole",
				"parentName": "ConductVerificationModeContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.LOOKUP,
					"caption": {
						"bindTo": "Resources.Strings.ParticipantRoleCaption"
					},
					"wrapClass": ["top-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "Participant",
				"parentName": "ConductVerificationModeContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.LOOKUP,
					"caption": {
						"bindTo": "Resources.Strings.ParticipantCaption"
					},
					"wrapClass": ["top-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "PerformActionModeCaption",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 6,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.WhoPerfomValidationCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			}, {
				"operation": "insert",
				"name": "PerformActionMode",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 7,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"prepareList": {
							"bindTo": "prepareEnumParameterList"
						}
					},
					"tag": "PerformActionMode",
					"wrapClass": ["no-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "PerformActionModeContainer",
				"propertyName": "items",
				"parentName": "MainContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 8,
						"colSpan": 24
					},
					"wrapClass": ["appValidation-properties-container"]
				}
			}, {
				"operation": "insert",
				"name": "Role",
				"parentName": "PerformActionModeContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.LOOKUP,
					"caption": {
						"bindTo": "Resources.Strings.RoleCaption"
					},
					"wrapClass": ["top-caption-control"],
					"markerValue": "PerformActionRole"
				}
			}, {
				"operation": "insert",
				"name": "OwnerId",
				"parentName": "PerformActionModeContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.LOOKUP,
					"caption": {
						"bindTo": "Resources.Strings.OwnerIdCaption"
					},
					"wrapClass": ["top-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "HowDisplayValidationCaption",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 9,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.HowDisplayValidationCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			}, {
				"operation": "insert",
				"name": "ValidationDisplayMode",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 10,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"prepareList": {
							"bindTo": "prepareEnumParameterList"
						}
					},
					"tag": "ValidationDisplayMode",
					"wrapClass": ["no-caption-control"]
				}
			}, {
				"operation": "insert",
				"name": "ValidationDisplayModeContainer",
				"propertyName": "items",
				"parentName": "MainContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 11,
						"colSpan": 24
					},
					"wrapClass": ["appValidation-properties-container"]
				}
			}, {
				"operation": "insert",
				"name": "CurrentAppValidationId",
				"parentName": "ValidationDisplayModeContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.LOOKUP,
					"caption": {
						"bindTo": "Resources.Strings.RecordIdCaption"
					},
					"wrapClass": ["top-caption-control"]
				}
			}] /**SCHEMA_DIFF*/ ,
			rules: {
				"Participant": {
					"VisibleParticipantOnConductVerificationMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "ConductVerificationMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.ConductVerificationMode.OneParticipant.value
							}
						}]
					}
				},
				"ParticipantRole": {
					"RequireParticipantRoleOnConductVerificationMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"logical": this.Terrasoft.LogicalOperatorType.OR,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "ConductVerificationMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.ConductVerificationMode.MoreParticipants.value
							}
						}, {
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "ConductVerificationMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.ConductVerificationMode.OneParticipant.value
							}
						}]
					},
					"VisibleParticipantRoleOnConductVerificationMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"logical": this.Terrasoft.LogicalOperatorType.OR,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "ConductVerificationMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.ConductVerificationMode.MoreParticipants.value
							}
						}, {
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "ConductVerificationMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.ConductVerificationMode.OneParticipant.value
							}
						}]
					}
				},
				"Role": {
					"RequireRoleOnPerformActionMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "PerformActionMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.PerformActionMode.EmployeesGroup.value
							}
						}]
					},
					"VisibleRoleOnPerformActionMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "PerformActionMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.PerformActionMode.EmployeesGroup.value
							}
						}]
					}
				},
				"OwnerId": {
					"RequireOwnerIdOnPerformActionMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "PerformActionMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.PerformActionMode.ResponsibleOfficer.value
							}
						}]
					},
					"VisibleOwnerIdOnPerformActionMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "PerformActionMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.PerformActionMode.ResponsibleOfficer.value
							}
						}]
					}
				},
				"CurrentAppValidationId": {
					"RequireCurrentAppValidationIdOnValidationDisplayMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "ValidationDisplayMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.ValidationDisplayMode.EditExistingRecord.value
							}
						}]
					},
					"VisibleCurrentAppValidationIdOnValidationDisplayMode": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "ValidationDisplayMode"
							},
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": AppValidationEnum.ValidationDisplayMode.EditExistingRecord.value
							}
						}]
					}
				}
			}
		};
	}
);
