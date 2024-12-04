define("AppFormPropertyFieldsDetail", ["ConfigurationItemGenerator", "DetailEntityMappingMixin",
	"AppFormPropertyRowViewModel", "css!FinAppLendingCSS"],
	function(ConfigurationItemGenerator) {
		return {
			entitySchemaName: "AppFormProperty",
			mixins: {
				DetailEntityMappingMixin: "Terrasoft.DetailEntityMappingMixin"
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "AddRecordButton"
				},
				{
					"operation": "insert",
					"name": "AddTypedRecordButton",
					"parentName": "Detail",
					"propertyName": "tools",
					"values": {
						"visible": true,
						"itemType": this.Terrasoft.ViewItemType.BUTTON,
						"controlConfig": {
							"menu": {
								"items": {"bindTo": "AddButtonMenuItems"}
							}
						},
						"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"imageConfig": {"bindTo": "Resources.Images.AddButtonImage"},
						"markerValue": "AddTypedRecordButton"
					}
				},
				{
					"operation": "merge",
					"name": "Detail",
					"values": {
						"classes": {
							"wrapClass": ["detail", "appform-property-fields-detail"]
						}
					}
				},
				{
					"operation": "merge",
					"name": "FieldsDetailContainer",
					"values": {
						"classes": {
							"wrapClassName": ["fields-detail-container detail", "vertical-view-fields-detail"]
						}
					}
				}
			], /**SCHEMA_DIFF*/
			methods: {

				//region Methods: Protected

				/**
				 * Returns add button menu items collection.
				 * @protected
				 * @virtual
				 * @return {Terrasoft.BaseViewModelCollection} Menu items collection.
				 */
				getAddButtonMenuItems: function() {
					var menuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					var obligationTypes = this.get("CollateralObjectTypes");
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
						"values": {
							"Id": value,
							"Caption": name,
							"MarkerValue": name,
							"Tag": {
								"name": "CollateralObjectType",
								"displayValue": name,
								"value": value
							},
							"Click": {
								"bindTo": "addItem"
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
							"rawData": {
								"CollateralObjectType": type
							}
						});
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#initESQColumns
				 * @overridden
				 */
				initESQColumns: function(esq) {
					this.callParent(arguments);
					esq.addColumn("PropertyType.CollateralObjectType", "CollateralObjectType");
				},

				/**
				 * Initialise types items collection.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Function} scope Function context.
				 */
				initCollateralObjectTypeCollection: function(callback, scope) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "CollateralObjectType"
					});
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
					esq.getEntityCollection(function(response) {
						if (response.success) {
							var entityCollection = response.collection;
							this.set("CollateralObjectTypes", entityCollection);
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
						this.initCollateralObjectTypeCollection(function() {
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
					return ["PropertyType"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
				 * @overridden
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.AppFormPropertyRowViewModel";
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#createViewGeneratorInstance
				 * @overridden
				 */
				createViewGeneratorInstance: function() {
					var viewGenerator = this.Ext.create("Terrasoft.ViewGenerator");
					viewGenerator.init({
						"schemaName": this.name,
						"viewModelClass": this.Ext.ClassManager.get(this.getViewGeneratorViewModelClassName()),
						"schema": {},
						"customGenerators": {
							"ItemValuesContainer": "ConfigurationItemGenerator.generateContainerList"
						}
					});
					viewGenerator.setGeneratorsByModule("ConfigurationItemGenerator", ConfigurationItemGenerator);
					return viewGenerator;
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#initDetailRowViewConfig
				 * @overridden
				 */
				initDetailRowViewConfig: function(itemConfig, item) {
					var viewGenerator = this.createViewGeneratorInstance();
					var viewConfig = viewGenerator.generateView(this.getDetailRowViewConfig(item));
					viewConfig = viewConfig[0];
					itemConfig.config = viewConfig;
					viewGenerator.destroy();
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#onSaved
				 * @overridden
				 */
				onSaved: function(response) {
					var message = response.errorInfo && response.errorInfo.message;
					if (response.success && !message) {
						this.updateItemsState(response);
					} else {
						this.publishSaveResponse({
							success: false,
							message: this.getErrorMessage(message)
						});
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#updateItemsState
				 * @overridden
				 */
				updateItemsState: function(response) {
					this.showBodyMask();
					this.callParent(arguments);
					var collection = this.get("Collection");
					var asyncActions = [];
					collection.each(function(item) {
						var itemSaveAction = function(next) {
							item.saveInnerItems(next, this);
						};
						asyncActions.push(itemSaveAction);
					}, this);
					asyncActions.push(function() {
						this.hideBodyMask();
						this.publishSaveResponse(response);
					});
					this.Terrasoft.chain.apply(this, asyncActions);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDetailRowViewConfig
				 * @overridden
				 */
				getDetailRowViewConfig: function() {
					var typeConfig = {
						"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
						"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
						"name": "PropertyType",
						"wrapClass": ["type-control-item"],
						"markerValue": "PropertyType",
						"labelConfig": {
							"visible": false
						},
						"controlConfig": {
							"placeholder": {
								"bindTo": "Resources.Strings.PropertyTypePlaceholderCaption"
							}
						}
					};
					return [{
						"id": "FieldDetailRow" + this.entitySchemaName,
						"name": "FieldDetailRow",
						"wrapClass": ["vertical-view-detail-row-item"],
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"visible": {
							"bindTo": "getRowVisible"
						},
						"items": [{
							"id": "TypeAndDeleteButtonContainer",
							"name": "TypeAndDeleteButtonContainer",
							"wrapClass": ["type-delete-button-container"],
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"items": [
								{
									"id": "TypeContainer",
									"name": "TypeContainer",
									"wrapClass": ["type-container"],
									"itemType": this.Terrasoft.ViewItemType.CONTAINER,
									"items": [
										typeConfig,
										this.getDeleteButtonConfig()
									]
								}
							]
						},
						{
							"id": "ItemValuesContainer",
							"name": "ItemValuesContainer",
							"generator": "ConfigurationItemGenerator.generateContainerList",
							"idProperty": "Id",
							"collection": "PropertySpecificationCollection",
							"dataItemIdPrefix": "specification-field-detail-item",
							"onGetItemConfig": "getSpecificationRowViewConfig",
							"classes": {
								"wrapClassName": ["fields-detail-container"]
							}
						}]
					}];
				},

				/**
				 * @inheritdoc Terrasoft.mixins.DetailEntityMappingMixin#addDetailItem
				 * @overridden
				 */
				addDetailItem: function(columnValues) {
					var communicationType = columnValues.filter(function(item) {
						if (item.Key === "CollateralObjectType") {
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
