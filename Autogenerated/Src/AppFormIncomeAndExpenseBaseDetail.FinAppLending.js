define("AppFormIncomeAndExpenseBaseDetail", ["AppFormIncomeAndExpenseBaseDetailResources",
	"BaseExpensesAndIncomeRowViewModel", "DetailEntityMappingMixin", "css!FinAppLendingCSS"
], function(resources) {
	return {
		entitySchemaName: "IncomeAndExpenseInAppForm",
		mixins: {
			DetailEntityMappingMixin: "Terrasoft.DetailEntityMappingMixin"
		},
		attributes: {
			/**
			 * Add button elements collection.
			 */
			"AddButtonMenuItems": {
				"dataValueType": this.Terrasoft.DataValueType.COLLECTION
			},

			/**
			 * IncomeAndExpense sources collection.
			 */
			"IncomeAndExpenseSources": {
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"dataValueType": this.Terrasoft.DataValueType.COLLECTION
			}
		},
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "remove",
			"name": "AddRecordButton"
		}, {
			"operation": "insert",
			"name": "AddTypedRecordButton",
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
					"wrapClass": ["detail vertical-view-fields-detail"]
				}
			}
		}],
		/**SCHEMA_DIFF*/
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
				var expenseTypes = this.get("IncomeAndExpenseSources");
				expenseTypes.each(function(item) {
					var menuItem = this.getButtonMenuItem(item);
					menuItems.addItem(menuItem);
				}, this);
				return menuItems;
			},

			/**
			 * Returns add menu item based on input income and expense sources type.
			 * @protected
			 * @param {Terrasoft.BaseViewModel} item IncomeAndExpenseSources collection item.
			 * @return {Terrasoft.BaseViewModel} IncomeAndExpense source viewModel.
			 */
			getButtonMenuItem: function(item) {
				var name = item.get("Name");
				var value = item.get("Id");
				return this.Ext.create("Terrasoft.BaseViewModel", {
					values: {
						Id: value,
						Caption: name,
						MarkerValue: name,
						Tag: {
							name: "Source",
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
			 * @param {Object} incomeAndExpenseSource IncomeAndExpenseSource item object.
			 */
			addItem: function(incomeAndExpenseSource) {
				if (incomeAndExpenseSource) {
					this.addRow({
						"defaultValues": [incomeAndExpenseSource]
					});
				}
			},

			/**
			 * Initialise Income and Expense source items collection.
			 * @protected
			 * @param {Function} callback callback function.
			 * @param {Object} scope Execution context.
			 */
			initExpenseTypes: function(callback, scope) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "IncomeAndExpenseSource"
				});
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
				this.addIncomeOrExpensesTypeFilter(esq.filters);
				esq.getEntityCollection(function(response) {
					if (response.success) {
						var entityCollection = response.collection;
						this.set("IncomeAndExpenseSources", entityCollection);
					}
					this.Ext.callback(callback, scope);
				}, this);
			},

			/**
			 * Adds filter for add button income or expenses type.
			 * @protected
			 * @virtual
			 * @param {Terrasoft.FilterGroup} Group of filters to add filter.
			 */
			addIncomeOrExpensesTypeFilter: this.Terrasoft.emptyFn,

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
					this.initExpenseTypes(function() {
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
				return ["Source", "Amount"];
			},

			/**
			 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
			 * @overridden
			 */
			getRowViewModelClassName: function() {
				return "Terrasoft.BaseExpensesAndIncomeRowViewModel";
			},

			/**
			 * @inheritdoc Terrasoft.BaseFieldsDetail#getDetailRowViewConfig
			 * @overridden
			 */
			getDetailRowViewConfig: function() {
				var typeControl = {
					"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"name": "Source",
					"wrapClass": ["type-control-item"],
					"markerValue": "IncomeAndExpenseSource",
					"labelConfig": {
						"visible": false
					}
				};
				var valueControl = {
					"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
					"dataValueType": this.Terrasoft.DataValueType.MONEY,
					"name": "Amount",
					"wrapClass": ["value-control-item"],
					"markerValue": "Amount",
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"classes": ["placeholder-opacity placeholder-size"],
						"placeholder": resources.localizableStrings.AmountCaption
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
						"items": [{
							"id": "TypeContainer",
							"name": "TypeContainer",
							"wrapClass": ["type-container"],
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"items": [
								typeControl,
								this.getDeleteButtonConfig()
							]
						}]
					}, {
						"id": "ValueContainer",
						"name": "ValueContainer",
						"wrapClass": ["value-container"],
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"items": [
							valueControl
						]
					}]
				};
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
