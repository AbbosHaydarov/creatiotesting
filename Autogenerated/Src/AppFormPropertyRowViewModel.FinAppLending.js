define("AppFormPropertyRowViewModel", ["SpecInAppFormProperty", "ViewUtilities",
	"BaseFieldRowViewModel", "AppFormPropertySpecificationRowViewModel"], function(SpecInAppFormProperty, ViewUtilities) {
	/**
	 * @class Terrasoft.configuration.AppFormPropertyRowViewModel
	 */
	Ext.define("Terrasoft.configuration.AppFormPropertyRowViewModel", {
		extend: "Terrasoft.BaseFieldRowViewModel",
		alternateClassName: "Terrasoft.AppFormPropertyRowViewModel",

		//region Methods: Protected

		/**
		 * Sets entity schema query filters for collateral object type.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 */
		setCollateralObjectTypeESQFilters: function(filters) {
			var collateralObjectType = this.get("CollateralObjectType");
			collateralObjectType = collateralObjectType && collateralObjectType.value;
			if (!this.Ext.isEmpty(collateralObjectType)) {
				var collateralObjectTypeFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "CollateralObjectType", collateralObjectType);
				filters.add("CollateralObjectTypeFilter", collateralObjectTypeFilter);
			}
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
		 * @overridden
		 */
		getLookupQuery: function(filterValue, columnName) {
			var esq = this.callParent(arguments);
			if (columnName === "PropertyType") {
				this.setCollateralObjectTypeESQFilters(esq.filters);
			}
			return esq;
		},

		/**
		 * @inheritdoc Terrasoft.LookupQuickAddMixin#getLookupQueryFilters
		 * @overridden
		 */
		getLookupQueryFilters: function(columnName) {
			var filters = this.callParent(arguments);
			if (columnName === "PropertyType") {
				this.setCollateralObjectTypeESQFilters(filters);
			}
			return filters;
		},

		/**
		 * Sets entity schema query filters for collateral object type.
		 * @protected
		 * @return {Terrasoft.BaseViewModelCollection} Collection of specifications.
		 */
		getPropertySpecificationCollection: function() {
			return this.get("PropertySpecificationCollection");
		},

		/**
		 * Gets data from DB and fill specification types collection.
		 * @protected
		 * @param {Function} callback Callback-function.
		 * @param {Object} scope Callback-function scope.
		 */
		loadSpecificationTypes: function(callback, scope) {
			var propertyTypeValue = this.get("PropertyType");
			propertyTypeValue = propertyTypeValue && propertyTypeValue.value;
			var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "SpecInPropertyType"
			});
			esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
			esq.addColumn("Specification");
			var caption = esq.addColumn("Specification.Name", "Caption");
			caption.orderDirection = this.Terrasoft.OrderDirection.ASC;
			esq.addColumn("Specification.Type", "SpecificationType");
			esq.filters.add("PropertyTypeFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "PropertyType", propertyTypeValue));
			esq.getEntityCollection(function(response) {
				if (response.success) {
					var entityCollection = response.collection;
					this.set("SpecificationTypes", entityCollection);
				}
				this.Ext.callback(callback, scope);
			}, this);
		},

		/**
		 * Initialize specification item default values collection.
		 * @protected
		 */
		initItemsDefaultValues: function() {
			var defaultValues = [{
				"name": "AppFormProperty",
				"value": this.get(this.primaryColumnName)
			}];
			this.set("ItemsDefaultValues", defaultValues);
		},

		/**
		 * Returns entity schema query instance sor SpecInAppFormProperty entity.
		 * @protected
		 * @return {Terrasoft.EntitySchemaQuery} Entity schema query instance.
		 */
		getSpecificationESQ: function() {
			return this.Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchema: SpecInAppFormProperty,
				rowViewModelClassName: "AppFormPropertySpecificationRowViewModel"
			});
		},

		/**
		 * Returns specification item columns array.
		 * @protected
		 * @return {Array} Columns array.
		 */
		getItemDisplayColumns: function() {
			return ["TextValue", "IntValue", "FloatValue", "BooleanValue", "SpecificationListItem", "Specification",
				"AppFormProperty"];
		},

		/**
		 * Fills entity schema query columns.
		 * @protected
		 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
		 */
		initESQColumns: function(esq) {
			esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
			this.Terrasoft.each(this.getItemDisplayColumns(), function(displayColumn) {
				esq.addColumn(displayColumn);
			}, this);
			var caption = esq.addColumn("Specification.Name", "Caption");
			caption.orderDirection = this.Terrasoft.OrderDirection.ASC;
			esq.addColumn("Specification.Type", "SpecificationType");
			esq.addColumn("AppFormProperty.PropertyType.CollateralObjectType", "CollateralObjectType");
		},

		/**
		 * Fills entity schema query filters.
		 * @protected
		 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
		 */
		initESQFilters: function(esq) {
			var masterRecordId = this.get(this.primaryColumnName);
			esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
				this.Terrasoft.ComparisonType.EQUAL,
				"AppFormProperty",
				masterRecordId
			));
		},

		/**
		 * Clear query events.
		 * @private
		 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
		 */
		initQueryEvents: function(esq) {
			esq.on("createviewmodel", this.createRowViewModel, this);
		},

		/**
		 * Clear query events.
		 * @private
		 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
		 */
		initQueryColumnSorting: function(esq) {
			esq.on("createviewmodel", this.createRowViewModel, this);
		},

		/**
		 * Clear query events.
		 * @private
		 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
		 */
		destroyQueryEvents: function(esq) {
			esq.un("createviewmodel", this.createRowViewModel, this);
		},

		/**
		 * Gets data from DB and fill specification collection.
		 * @protected
		 * @param {Function} callback Callback-function.
		 * @param {Object} scope Callback-function scope.
		 */
		loadPropertySpecifications: function(callback, scope) {
			var esq = this.getSpecificationESQ();
			this.initESQColumns(esq);
			this.initESQFilters(esq);
			this.initQueryEvents(esq);
			esq.getEntityCollection(function(result) {
				this.destroyQueryEvents(esq);
				this.onRowDataLoaded(result, callback, scope);
			}, this);
		},

		/**
		 * Handles result of specification loading.
		 * @protected
		 * @param {Object} result Result of data loading.
		 * @param {Function} callback Callback-function.
		 * @param {Terrasoft.BaseViewModel} scope Calllback execution context.
		 */
		onRowDataLoaded: function(result, callback, scope) {
			if (result.success && result.collection) {
				var collection = this.getPropertySpecificationCollection();
				collection.loadAll(result.collection);
			}
			this.Ext.callback(callback, scope);
		},

		/**
		 * Returns specification row columns.
		 * @protected
		 * @return {Array} Specification row columns.
		 */
		getSpecificationItemColumns: function() {
			var columns = this.Terrasoft.deepClone(SpecInAppFormProperty.columns);
			this.Terrasoft.each(columns, function(column) {
				column.columnPath = column.name;
				column.type = this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN;
			}, this);
			return columns;
		},

		/**
		 * Returns specification row view model configuration.
		 * @protected
		 * @param {Object} config Row configuration.
		 * @return {Object} Specification row view model configuration.
		 */
		getRowViewModelConfig: function(config) {
			config = config || {};
			config.rawData = config.rawData || {};
			var isNew = config.isNew || false;
			var defaultValues = this.get("ItemsDefaultValues");
			if (config.defaultValues) {
				defaultValues = this.Ext.Array.merge(defaultValues, config.defaultValues);
			}
			this.Ext.apply(config.rawData, {
				DetailColumnName: "AppFormProperty",
				DefaultValues: defaultValues
			});
			return {
				entitySchema: SpecInAppFormProperty,
				isNew: isNew,
				isVirtual: config.isVirtual || false,
				isDeleted: false,
				Ext: this.Ext,
				Terrasoft: this.Terrasoft,
				sandbox: this.sandbox,
				columns: this.getSpecificationItemColumns(),
				rowConfig: config.rowConfig,
				values: config.rawData
			};
		},

		/**
		 * Generate specification entity row view model.
		 * @protected
		 * @param {Object} config optional viewModel config.
		 * @return {Terrasoft.BaseViewModel} specification item viewModel.
		 */
		createRowViewModel: function(config) {
			config = config || {};
			var gridRowViewModelConfig = this.getRowViewModelConfig(config);
			var viewModel = this.Ext.create("Terrasoft.AppFormPropertySpecificationRowViewModel",
				gridRowViewModelConfig);
			config.viewModel = viewModel;
			return viewModel;
		},

		/**
		 * Adds new specification in collection.
		 * @protected
		 * @param {Function} callback Callback-function.
		 * @param {Terrasoft.BaseViewModel} scope Calllback execution context.
		 */
		addSpecifications: function(callback, scope) {
			var specificationTypes = this.get("SpecificationTypes");
			var collection = this.getPropertySpecificationCollection();
			specificationTypes.each(function(item) {
				var specificationValue = item.get("Specification");
				specificationValue = specificationValue && specificationValue.value;
				var config = {
					isNew: true,
					rawData: {
						"SpecificationType": item.get("SpecificationType"),
						"Caption": item.get("Caption")
					},
					defaultValues: [
						{
							"name": "Specification",
							"value": specificationValue
						}
					]
				};
				var viewModelItem = this.createRowViewModel(config);
				var viewModelItemId = viewModelItem.get(viewModelItem.primaryColumnName);
				collection.add(viewModelItemId, viewModelItem);
			}, this);
			this.Ext.callback(callback, scope);
		},

		/**
		 * Handles PropertyType field change.
		 * @protected
		 */
		onPropertyTypeChange: function() {
			var collection = this.getPropertySpecificationCollection();
			collection.each(function(item) {
				item.deleteItem();
			});
			var propertyType = this.get("PropertyType");
			if (!this.Ext.isEmpty(propertyType)) {
				this.loadSpecificationTypes(this.addSpecifications, this);
			}
		},

		/**
		 * Initialize subscribe for model attributes events.
		 * @protected
		 */
		subscribeForColumnEvents: function() {
			this.subscribeOnColumnChange("PropertyType", this.onPropertyTypeChange);
		},

		/**
		 * Saves inner specification items.
		 * @protected
		 * @param {Function} callback Callback-function.
		 * @param {Terrasoft.BaseViewModel} scope Calllback execution context.
		 */
		saveInnerItems: function(callback, scope) {
			var asyncActions = [];
			var collection = this.getPropertySpecificationCollection();
			collection.each(function(item) {
				var itemSaveAction = function(next) {
					item.saveEntity(next, scope);
				};
				asyncActions.push(itemSaveAction);
			});
			asyncActions.push(callback);
			this.Terrasoft.chain.apply(scope, asyncActions);
		},

		/**
		 * Unsubscribe handlers from event model attributes.
		 * @protected
		 */
		unsubscribeForColumnEvents: function() {
			this.unsubscribeOnColumnChange("PropertyType", this.onPropertyTypeChange);
		},

		/**
		 * Initialize specification collection
		 * @protected
		 */
		initPropertySpecificationCollection: function() {
			this.set("PropertySpecificationCollection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#setConfigDefaultValues
		 * @overridden
		 */
		setConfigDefaultValues: function(callback, scope) {
			this.callParent([function() {
				this.initItemsDefaultValues();
				this.Ext.callback(callback, scope);
			}, this]);
		},

		/**
		 * Initialize row item columns.
		 * @protected
		 */
		initRowItemColumns: function() {
			var idColumn = this.columns[this.primaryColumnName];
			idColumn.columnPath = idColumn.name;
		},

		/**
		 * Handles change item event in collection.
		 * @protected
		 */
		onCollectionItemChanged: function() {
			this.fireEvent("change", this, {
				OperationType: "ItemChange"
			});
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#validate
		 * @overridden
		 */
		validate: function() {
			var result = this.callParent(arguments);
			if (result === false) {
				return false;
			}
			var collection = this.getPropertySpecificationCollection();
			collection.each(function(item) {
				if (item.changedValues && !item.isDeleted && !item.validate()) {
					result = false;
					return !result;
				}
			}, this);
			return result;
		},

		/**
		 * Subscribe collection events.
		 * @protected
		 */
		subscribeCollectionEvents: function() {
			var collection = this.getPropertySpecificationCollection();
			collection.on("itemChanged", this.onCollectionItemChanged, this);
		},

		/**
		 * Unsubscribe collection events.
		 * @protected
		 */
		unsubscribeCollectionEvents: function() {
			var collection = this.getPropertySpecificationCollection();
			collection.un("itemChanged", this.onCollectionItemChanged, this);
		},

		/**
		 * Sets default property type value.
		 * @protected
		 * @param {Function} callback Callback-function.
		 * @param {Terrasoft.BaseViewModel} scope Calllback execution context.
		 */
		setPropertyTypeDefaultValue: function(callback, scope) {
			var esq = this.getLookupQuery(null, "PropertyType");
			esq.getEntityCollection(function(response) {
				if (response.success) {
					var collection = response.collection;
					if (collection.getCount() === 1) {
						var propertyType = collection.getByIndex(0);
						var propertyTypeValue = {
							"value": propertyType.get("value"),
							"displayValue": propertyType.get("displayValue")
						};
						this.set("PropertyType", propertyTypeValue);
					}
				}
				this.Ext.callback(callback, scope);
			}, this);
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#init
		 * @overridden
		 */
		init: function(callback, scope) {
			this.initRowItemColumns();
			this.subscribeForColumnEvents();
			this.initPropertySpecificationCollection();
			this.subscribeCollectionEvents();
			this.callParent([function() {
				if (!this.isNew) {
					this.initItemsDefaultValues();
					this.loadPropertySpecifications(callback, scope);
				} else {
					this.setPropertyTypeDefaultValue(callback, scope);
				}
			}, this]);
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#destroy
		 * @overridden
		 */
		destroy: function() {
			this.unsubscribeForColumnEvents();
			this.unsubscribeCollectionEvents();
			this.callParent(arguments);
		},

		/**
		 * Returns specification row view configuration.
		 * @protected
		 * @return {Object} Detail row view configuration.
		 */
		getSpecificationViewConfig: function() {
			var controlId = this.Terrasoft.generateGUID();
			var config = ViewUtilities.getContainerConfig("item-view",
					["row-specification-container", "control-width-15"]);
			config = this.Ext.apply(config, {
				"visible": {
					"bindTo": "getRowVisible"
				},
				"markerValue": {
					"bindTo": "Caption"
				}
			});
			var labelConfig = {
				"className": "Terrasoft.Container",
				"classes": {
					"wrapClassName": ["label-wrap"]
				},
				"items": [{
					"className": "Terrasoft.Label",
					"classes": {
						labelClass: ["control-left label-specificationInProperty"]
					},
					"caption": {
						"bindTo": "Caption"
					}
				}]
			};
			var stringEditConfig = {
				"id": "StringEdit" + controlId,
				"className": "Terrasoft.TextEdit",
				"classes": {
					"wrapClass": ["base-edit-specificationInProperty"]
				},
				"value": {
					"bindTo": "TextValue"
				},
				"visible": {
					"bindTo": "getControlVisible"
				},
				"tag": "String",
				"markerValue": {
					"bindTo": "getMarkerValue"
				}
			};
			var intEditConfig = {
				"id": "IntEdit" + controlId,
				"className": "Terrasoft.IntegerEdit",
				"classes": {
					"wrapClass": ["base-edit-specificationInProperty"]
				},
				"value": {
					"bindTo": "IntValue"
				},
				"visible": {
					"bindTo": "getControlVisible"
				},
				"tag": "Int",
				"markerValue": {
					"bindTo": "getMarkerValue"
				}
			};
			var floatEditConfig = {
				"id": "FloatEdit" + controlId,
				"className": "Terrasoft.FloatEdit",
				"classes": {
					"wrapClass": ["base-edit-specificationInProperty"]
				},
				"value": {
					"bindTo": "FloatValue"
				},
				"visible": {
					"bindTo": "getControlVisible"
				},
				"tag": "Float",
				"markerValue": {
					"bindTo": "getMarkerValue"
				}
			};
			var booleanEditConfig = {
				"id": "BooleanEdit" + controlId,
				"className": "Terrasoft.CheckBoxEdit",
				"classes": {
					"wrapClass": ["check-box-edit-specificationInProperty"]
				},
				"checked": {
					"bindTo": "BooleanValue"
				},
				"visible": {
					"bindTo": "getControlVisible"
				},
				"tag": "Boolean",
				"markerValue": {
					"bindTo": "getMarkerValue"
				}
			};
			var lookupEditConfig = {
				"id": "ComboBoxEdit" + controlId,
				"className": "Terrasoft.ComboBoxEdit",
				"classes": {
					"wrapClass": ["base-edit-specificationInProperty"]
				},
				"value": {
					"bindTo": "SpecificationListItem"
				},
				"visible": {
					"bindTo": "getControlVisible"
				},
				"list": {
					"bindTo": "SpecificationListItemList"
				},
				"tag": "ListItem",
				"markerValue": {
					"bindTo": "getMarkerValue"
				}
			};
			config.items.push(labelConfig, stringEditConfig, intEditConfig, floatEditConfig, booleanEditConfig,
				lookupEditConfig);
			return config;
		},

		/**
		 * Sets up specification view configuration.
		 * @protected
		 * @param {Object} itemConfig Item configuration.
		 * @param {Object} item ViewModel item.
		 */
		getSpecificationRowViewConfig: function(itemConfig, item) {
			itemConfig.config = this.getSpecificationViewConfig(item);
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#deleteItem
		 * @overridden
		 */
		deleteItem: function() {
			this.callParent(arguments);
			var collection = this.getPropertySpecificationCollection();
			collection.each(function(item) {
				item.deleteItem();
			});
		}

		//endregion

	});
	return Terrasoft.AppFormPropertyRowViewModel;
});
