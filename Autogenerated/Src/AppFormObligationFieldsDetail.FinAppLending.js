define("AppFormObligationFieldsDetail", ["AppFormObligationRowViewModel", "DetailEntityMappingMixin",
	"css!FinAppLendingCSS"],
	function() {
	return {
		entitySchemaName: "AppFormObligation",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "AddRecordButton"
			},
			{
				"operation": "insert",
				"name": "AddButton",
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
						"wrapClass": ["detail vertical-view-fields-detail"]
					}
				}
			}
		], /**SCHEMA_DIFF*/
		mixins: {
			DetailEntityMappingMixin: "Terrasoft.DetailEntityMappingMixin"
		},
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
				var obligationTypes = this.get("AppFormObligationTypes");
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
							name: "Type",
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
			initObligationTypesCollection: function(callback, scope) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "AppFormObligationType"
				});
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
				esq.getEntityCollection(function(response) {
					if (response.success) {
						var entityCollection = response.collection;
						this.set("AppFormObligationTypes", entityCollection);
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
					this.initObligationTypesCollection(function() {
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
				return ["Type", "Amount", "ExpirationDate"];
			},

			/**
			 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
			 * @overridden
			 */
			getRowViewModelClassName: function() {
				return "Terrasoft.AppFormObligationRowViewModel";
			},

			/**
			 * @inheritdoc Terrasoft.BaseFieldsDetail#getDetailRowViewConfig
			 * @overridden
			 */
			getDetailRowViewConfig: function() {
				var typeConfig = {
					"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"name": "Type",
					"wrapClass": ["type-control-item"],
					"markerValue": "Type",
					"labelConfig": {
						"visible": false
					}
				};
				var amountConfig = {
					"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
					"dataValueType": this.Terrasoft.DataValueType.MONEY,
					"name": "Amount",
					"wrapClass": ["value-control-item control-bottom-interval"],
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"classes": ["placeholder-opacity placeholder-size"],
						"placeholder": {
							"bindTo": "AmountCaption"
						}
					}
				};
				var expirationDateConfig = {
					"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
					"dataValueType": this.Terrasoft.DataValueType.DATE,
					"name": "ExpirationDate",
					"wrapClass": ["value-control-item"],
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"classes": ["placeholder-opacity placeholder-size"],
						"placeholder": {
							"bindTo": "ExpirationDateCaption"
						}
					}
				};
				return {
					"id": "FieldDetailRow" + this.entitySchemaName,
					"name": "FieldDetailRow",
					"wrapClass": ["vertical-view-detail-row-item"],
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"visible": {
						"bindTo": "getRowVisible"
					},
					"items": [{
						"id": "TypeAndDeleteButtonContained",
						"name": "TypeAndDeleteButtonContained",
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
					}, {
						"id": "ValueContainer",
						"name": "ValueContainer",
						"wrapClass": ["value-container"],
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"items": [
							amountConfig,
							expirationDateConfig
						]
					}]
				};
			},

			/**
			 * @inheritdoc Terrasoft.mixins.DetailEntityMappingMixin#addDetailItem
			 * @overridden
			 */
			addDetailItem: function(columnValues) {
				var communicationType = columnValues.filter(function(item) {
					if (item.Key === "Type") {
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
