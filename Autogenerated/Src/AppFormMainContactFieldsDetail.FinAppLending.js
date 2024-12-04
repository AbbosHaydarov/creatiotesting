define("AppFormMainContactFieldsDetail", ["AppFormMainContactRowViewModel", "DetailEntityMappingMixin",
	"css!FinAppLendingCSS"],
	function() {
		return {
			entitySchemaName: "AppFormMainContact",
			mixins: {
				DetailEntityMappingMixin: "Terrasoft.DetailEntityMappingMixin"
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "remove",
				"name": "AddRecordButton"
			}, {
				"operation": "insert",
				"name": "AddButton",
				"parentName": "Detail",
				"propertyName": "tools",
				"values": {
					"visible": true,
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"controlConfig": {
						"menu": {
							"items": {
								"bindTo": "AddButtonMenuItems"
							}
						}
					},
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.AddButtonImage"
					},
					"markerValue": "AddTypedRecordButton"
				}
			}, {
				"operation": "merge",
				"name": "Detail",
				"values": {
					"classes": {
						"wrapClass": ["detail", "appform-main-contact-fields-detail"]
					}
				}
			}, {
				"operation": "merge",
				"name": "FieldsDetailContainer",
				"values": {
					"classes": {
						"wrapClassName": ["fields-detail-container detail", "vertical-view-fields-detail"]
					}
				}
			}],
			/**SCHEMA_DIFF*/
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
				 * @overridden
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.AppFormMainContactRowViewModel";
				},

				/**
				 * Returns add button menu items collection.
				 * @protected
				 * @virtual
				 * @return {Terrasoft.BaseViewModelCollection} Menu items collection.
				 */
				getAddButtonMenuItems: function() {
					var menuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					var obligationTypes = this.get("RelationTypes");
					obligationTypes.each(function(item) {
						var menuItem = this.getButtonMenuItem(item);
						menuItems.addItem(menuItem);
					}, this);
					return menuItems;
				},

				/**
				 * Returns add menu item based on input type.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} item collection item.
				 * @return {Terrasoft.BaseViewModel} button viewModel.
				 */
				getButtonMenuItem: function(item) {
					var name = item.get("Name");
					var value = item.get("Id");
					return Ext.create("Terrasoft.BaseViewModel", {
						values: {
							Id: value,
							Caption: name,
							MarkerValue: name,
							Tag: {
								name: "RelationType",
								displayValue: name,
								value: value
							},
							Click: {
								bindTo: "addItem"
							}
						}
					});
				},

				/**
				 * Initialise config to add detail row.
				 * @protected
				 * @param {Function} type Type value item object.
				 */
				addItem: function(type) {
					if (type) {
						this.addRow({
							"defaultValues": [type]
						});
					}
				},

				/**
				 * Initialise types items collection.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Function} scope Callback function.
				 */
				initRelationTypeCollection: function(callback, scope) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "RelationType"
					});
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
					esq.filters.add("ForContactContactFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"ForContactContact", true));
					esq.getEntityCollection(function(response) {
						if (response.success) {
							var entityCollection = response.collection;
							this.set("RelationTypes", entityCollection);
						}
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * Initialise add button menu items.
				 * @protected
				 */
				initAddButtonMenuItems: function() {
					var addButtonMenuItems = this.getAddButtonMenuItems();
					this.set("AddButtonMenuItems", this.Ext.create("Terrasoft.BaseViewModelCollection"));
					var menuItems = this.get("AddButtonMenuItems");
					menuItems.clear();
					menuItems.loadAll(addButtonMenuItems);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.initRelationTypeCollection(function() {
							this.initAddButtonMenuItems();
							this.Ext.callback(callback, scope);
						}, this);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#initDetailOptions
				 * @overridden
				 */
				getDisplayColumns: function() {
					return ["RelationType", "Name", "CommunicationType1", "CommunicationType2", "CommunicationType3",
						"CommunicationValue1", "CommunicationValue2", "CommunicationValue3"
					];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getLeftRowContainerWrapClass
				 * @overridden
				 */
				getLeftRowContainerWrapClass: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDeleteButtonConfig
				 * @overridden
				 */
				getDeleteButtonConfig: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#initDetailRowViewConfig
				 * @overridden
				 */
				initDetailRowViewConfig: function() {
					this.callParent(arguments);
					this.set("ItemViewConfig", null);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDetailRowViewConfig
				 * @overridden
				 */
				getDetailRowViewConfig: function() {
					var containerId = this.Terrasoft.generateGUID();
					return {
						"id": "FieldDetailRow" + containerId,
						"name": "FieldDetailRow",
						"wrapClass": ["vertical-view-detail-row-item"],
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"visible": {
							"bindTo": "getRowVisible"
						},
						"items": [{
							"id": "AppFormMainContactItemsContainer" + containerId,
							"name": "AppFormMainContactItemsContainer",
							"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": [{
								"id": "RelationType" + containerId,
								"name": "RelationType",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"dataValueType": this.Terrasoft.DataValueType.ENUM,
								"layout": {
									"column": 0,
									"row": 0,
									"colSpan": 6
								},
								"wrapClass": ["type-control-item"],
								"labelConfig": {
									"visible": false
								}
							}, {
								"id": "Name" + containerId,
								"name": "Name",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"layout": {
									"column": 0,
									"row": 1,
									"colSpan": 6
								},
								"wrapClass": ["value-control-item"],
								"labelConfig": {
									"visible": false
								},
								"controlConfig": {
									"placeholder": {
										"bindTo": "Resources.Strings.NamePlaceholderCaption"
									}
								}
							}, {
								"id": "CommunicationType1" + containerId,
								"name": "CommunicationType1",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"dataValueType": this.Terrasoft.DataValueType.ENUM,
								"layout": {
									"column": 6,
									"row": 0,
									"colSpan": 6
								},
								"wrapClass": ["type-control-item"],
								"labelConfig": {
									"visible": false
								}
							}, {
								"id": "CommunicationValue1" + containerId,
								"name": "CommunicationValue1",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"dataValueType": this.Terrasoft.DataValueType.TEXT,
								"layout": {
									"column": 6,
									"row": 1,
									"colSpan": 6
								},
								"wrapClass": ["value-control-item"],
								"labelConfig": {
									"visible": false
								}
							}, {
								"id": "CommunicationType2" + containerId,
								"name": "CommunicationType2",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"dataValueType": this.Terrasoft.DataValueType.ENUM,
								"layout": {
									"column": 12,
									"row": 0,
									"colSpan": 6
								},
								"wrapClass": ["type-control-item"],
								"labelConfig": {
									"visible": false
								}
							}, {
								"id": "CommunicationValue2" + containerId,
								"name": "CommunicationValue2",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"dataValueType": this.Terrasoft.DataValueType.TEXT,
								"layout": {
									"column": 12,
									"row": 1,
									"colSpan": 6
								},
								"wrapClass": ["value-control-item"],
								"labelConfig": {
									"visible": false
								}
							}, {
								"id": "CommunicationType3" + containerId,
								"name": "CommunicationType3",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"dataValueType": this.Terrasoft.DataValueType.ENUM,
								"layout": {
									"column": 18,
									"row": 0,
									"colSpan": 8
								},
								"wrapClass": ["type-control-item"],
								"labelConfig": {
									"visible": false
								}
							}, {
								"id": "CommunicationValue3" + containerId,
								"name": "CommunicationValue3",
								"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
								"dataValueType": this.Terrasoft.DataValueType.TEXT,
								"layout": {
									"column": 18,
									"row": 1,
									"colSpan": 6
								},
								"wrapClass": ["value-control-item"],
								"labelConfig": {
									"visible": false
								}
							}, {
								"id": "DeleteButton" + containerId,
								"itemType": this.Terrasoft.ViewItemType.BUTTON,
								"name": "DeleteButton",
								"layout": {
									"column": 23,
									"row": 0,
									"colSpan": 1
								},
								"click": {
									"bindTo": "deleteItem"
								},
								"controlConfig": {
									"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
									"imageConfig": {
										"bindTo": "Resources.Images.DeleteButtonImage"
									}
								},
								"classes": {
									"wrapperClass": ["delete-button-class"]
								}
							}]
						}]
					};
				},

				/**
				 * @inheritdoc Terrasoft.mixins.DetailEntityMappingMixin#addDetailItem
				 * @overridden
				 */
				addDetailItem: function(columnValues) {
					var communicationType = columnValues.filter(function(item) {
						if (item.Key === "RelationType") {
							return true;
						}
					});
					var typeId = communicationType[0] && communicationType[0].Value;
					return this.addItem(typeId);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.initStateMixinMessages();
				}

				//endregion

			}
		};
	});
