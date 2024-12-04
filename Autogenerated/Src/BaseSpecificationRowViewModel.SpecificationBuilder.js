define("BaseSpecificationRowViewModel", ["BaseSpecificationRowViewModelResources", "ViewUtilities",
	"BaseSpecificationItemViewModel", "BaseFloatItemViewModel", "BaseIntegerItemViewModel",
	"BaseComboBoxItemViewModel", "BaseTextItemViewModel", "BaseBooleanItemViewModel",
	"SpecificationMatrixBuilderViewModel", "ToolsItemViewModel"],
	function(resources, ViewUtilities) {
	/**
	 * @class Terrasoft.BaseSpecificationRowViewModel
	 */
	Ext.define("Terrasoft.configuration.BaseSpecificationRowViewModel", {
		alternateClassName: "Terrasoft.BaseSpecificationRowViewModel",
		extend: "Terrasoft.BaseViewModel",

		Ext: null,
		Terrasoft: null,
		sandbox: null,

		/**
		* #######, ########### ## ############# ############# ######## ###### ######### ######### ########.
		* @type {Boolean}
		*/
		useInternalTools: true,

		/**
		* ### ###### ### ######### ######.
		* @type {String}
		*/
		parameterViewModelClassName: "Terrasoft.BaseSpecificationItemViewModel",

		/**
		 * ### ###### ### ######## ######## ######.
		 * @type {String}
		 */
		floatItemClassName: "Terrasoft.BaseFloatItemViewModel",

		/**
		 * ### ###### ### ###### ######## ######.
		 * @type {String}
		 */
		integerItemClassName: "Terrasoft.BaseIntegerItemViewModel",

		/**
		 * ### ###### ### ########### ######## ######.
		 * @type {String}
		 */
		comboBoxItemClassName: "Terrasoft.BaseComboBoxItemViewModel",

		/**
		 * ### ###### ### ########## ######## ######.
		 * @type {String}
		 */
		textItemClassName: "Terrasoft.BaseTextItemViewModel",

		/**
		 * ### ###### ### ########### ######## ######.
		 * @type {String}
		 */
		booleanItemClassName: "Terrasoft.BaseBooleanItemViewModel",

		/**
		 * ######## ###### ViewModel'# ### ######### ##-#########.
		 * @type {String}
		 */
		defaultRowItemViewModelName: "Terrasoft.BaseSpecificationItemViewModel",

		/**
		 * ######## ###### ViewModel'# ### ########## ########.
		 * @type {String}
		 */
		defaultMatrixViewModelName: "Terrasoft.SpecificationMatrixBuilderViewModel",

		/**
		 * ########## ######### ############# ######.
		 * @protected
		 * @return {Object} ######### ############# ######.
		 */
		getRowViewConfig: this.Terrasoft.emptyFn,

		/**
		 * ############## ###### ########## ######## ## ####### ########.
		 * @protected
		 * @virtual
		 * @param {Object} resourcesObj ###### ########.
		 */
		initResourcesValues: function(resourcesObj) {
			var resourcesSuffix = "Resources";
			Terrasoft.each(resourcesObj, function(resourceGroup, resourceGroupName) {
				resourceGroupName = resourceGroupName.replace("localizable", "");
				Terrasoft.each(resourceGroup, function(resourceValue, resourceName) {
					var viewModelResourceName = [resourcesSuffix, resourceGroupName, resourceName].join(".");
					this.set(viewModelResourceName, resourceValue);
				}, this);
			}, this);
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#loadEntity
		 * @overridden
		 */
		loadEntity: function(entity) {
			var items = entity.get("RowValuesCollection");
			var parameterViewModel = this.get("ParameterViewModel");
			var value = entity.get("Value");
			parameterViewModel.isNew = false;
			parameterViewModel.set("IsReadMode", true, {silent: true, preventValidation: true});
			parameterViewModel.set("Value", value, {silent: true, preventValidation: true});
			items.each(function(item) {
				this.addRowValue(item);
			}, this);
		},

		/**
		 * ############# ###### ####### ######### #########.
		 * @protected
		 */
		refreshPositionIndex: function() {
			var rowPosition = this.get("RowPosition");
			var valuesCollection = this.getRowValuesCollection();
			var items = valuesCollection.getItems();
			for (var index = 0; index < items.length; index++) {
				var item = items[index];
				item.set("RowPosition", rowPosition);
				item.set("ValuePosition", index);
			}
		},

		/**
		 * ############ ####### ######## ########.
		 * @protected
		 * @param {String} id ############# ########.
		 */
		removeItemByKey: function(id) {
			var valuesCollection = this.getRowValuesCollection();
			valuesCollection.removeByKey(id);
			this.refreshPositionIndex();
		},

		/**
		 * ########## ######### ######## ######.
		 * @protected
		 * @return {Terrasoft.BaseViewModelCollection} ######### ######## ######.
		 */
		getRowValuesCollection: function() {
			return this.get("RowValuesCollection");
		},

		/**
		 * ############# ######### ######## ######.
		 * @protected
		 * @param {Terrasoft.BaseViewModelCollection} values ######### ######## ######.
		 */
		setRowValuesCollection: function(values) {
			return this.set("RowValuesCollection", values);
		},

		/**
		 * ############ ####### {@link Terrasoft.Collection#itemChanged}.
		 * @protected
		 * @virtual
		 * @param {Terrasoft.BaseViewModel} item ####### #########, # ####### ######### #########.
		 * @param {Object} config ######### #######.
		 */
		onItemChanged: function(item, config) {
			if (!config.silent && !config.preventValidation) {
				this.changeFireEvent();
			}
			if (config.event) {
				switch (config.event) {
					case "onRemove":
						var itemConfig = config.arguments;
						var id = itemConfig.id;
						this.removeItemByKey(id);
						break;
					case "onToolsClick":
						this.onToolsClick(config.arguments);
						break;
					case "onChangeValue":
						this.onValueChanged(config.arguments);
						break;
					case "onChangeParameterValue":
						this.onParameterValueChanged(config.arguments);
						break;
					case "onRowRemove":
						this.onRowRemove();
						break;
				}
			}
		},

		/**
		 * ############ ######## ######## ## #########.
		 * @protected
		 * @param {Terrasoft.BaseSpecificationItemViewModel} item ######## ## #########.
		 */
		onItemRemoved: function(item) {
			if (this.Ext.isEmpty(item.get("IsTools"))) {
				this.fireRemoveEvent(item);
			}
		},

		/**
		 * ########## ## ######## ######.
		 * @protected
		 */
		onRowRemove: function() {
			this.fireEvent("change", this, {
				event: "onRemove",
				arguments: {
					id: this.get("Id"),
					rowItemValues: this.get("RowValuesCollection")
				}
			});
		},

		/**
		 * ########## ## ######### ######## # ######.
		 * @protected
		 * @param {Object} changedItemArgs ######### ########### ########.
		 * @param {String} changedItemArgs.id ############# ########.
		 * @param {Object} changedItemArgs.value ########.
		 */
		onValueChanged: function(changedItemArgs) {
			this.fireEvent("change", this, {
				event: "onRowValueChanged",
				arguments: {
					rowId: this.get("Id"),
					changedItemArgs: changedItemArgs
				}
			});
		},

		/**
		 * ########## ## ######### ######## ######### # ######.
		 * @protected
		 * @param {Object} changedItemArgs ######### ########### ########.
		 * @param {String} changedItemArgs.id ############# ########.
		 * @param {Object} changedItemArgs.value ########.
		 */
		onParameterValueChanged: function(changedItemArgs) {
			this.fireEvent("change", this, {
				event: "onRowValueChanged",
				arguments: {
					rowId: this.get("Id"),
					changedItemArgs: changedItemArgs
				}
			});
		},

		/**
		 * ############ ####### ## ###### ########.
		 * @protected
		 * @virtual
		 * @param {Object} tag ######## tag ####### ######.
		 */
		onToolsClick: function(tag) {
			switch (tag) {
				case "add":
					this.onAddRowValue();
					break;
			}
		},

		/**
		 * ########## ## ######### ######### RowValuesCollection.
		 * @protected
		 */
		changeFireEvent: function() {
			this.fireEvent("change", this, {
				event: "change",
				arguments: null
			});
		},

		/**
		 * ########## ## ######### ######### RowValuesCollection.
		 * @protected
		 */
		fireRemoveEvent: function(item) {
			this.fireEvent("change", this, {
				event: "onRemoveRowItem",
				arguments: item
			});
		},

		/**
		 * ############# ## ####### ######### ######### ########.
		 * @protected
		 * @virtual
		 */
		subscribeForValuesCollectionEvents: function() {
			var collection = this.getRowValuesCollection();
			collection.on("itemChanged", this.onItemChanged, this);
			collection.on("remove", this.onItemRemoved, this);
		},

		/**
		 * ########## ## ####### ######### ######### ########.
		 * @protected
		 */
		unsubscribeForValuesCollectionEvents: function() {
			var collection = this.getRowValuesCollection();
			collection.un("itemChanged", this.onItemChanged, this);
			collection.un("remove", this.onItemRemoved, this);
		},

		/**
		 * ############## ####### ######## ###### ######### ######### ########.
		 * @protected
		 */
		initInternalTools: function() {
			if (this.useInternalTools) {
				var id = this.Terrasoft.generateGUID();
				this.set("ToolsItemId", id);
				var collection = this.getRowValuesCollection();
				var tools = this.getToolsItemViewModel();
				collection.add(id, tools);
			}
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#constructor
		 * @overridden
		 */
		constructor: function() {
			this.callParent(arguments);
			this.setParameterViewModel();
			var collection = this.getRowValuesCollection() || this.Ext.create("Terrasoft.BaseViewModelCollection");
			this.setRowValuesCollection(collection);
			this.subscribeForValuesCollectionEvents();
			this.initResourcesValues(resources);
			this.initInternalTools();
		},

		/**
		 * ########## ###### ############ ############# ### #########.
		 * @return {Object} ###### ############.
		 */
		getParameterViewConfig: function() {
			var viewModel = this.get("ParameterViewModel");
			return viewModel.getItemViewConfig();
		},

		/**
		 * ########## ###### ############ ###### ############# ### #########.
		 * @private
		 * @return {Object} ###### ############.
		 */
		getParameterViewModelConfig: function() {
			return {
				Ext: this.Ext,
				Terrasoft: this.Terrasoft,
				sandbox: this.sandbox,
				values: {
					ParentItem: this,
					DefaultValues: this.get("DefaultValues")
				}
			};
		},

		/**
		 * ####### # ############# ###### ### ######### ######.
		 * @protected
		 */
		setParameterViewModel: function() {
			var viewModelConfig = this.getParameterViewModelConfig();
			var viewModel = this.Ext.create(this.parameterViewModelClassName, viewModelConfig);
			viewModel.on("change", this.onItemChanged, this);
			this.set("ParameterViewModel", viewModel);
		},

		/**
		 * ########## ##### ###### ######## ## ####.
		 * @protected
		 * @param {Terrasoft.DataValueType} dataValueType ### #########.
		 * @return {String} ######## ###### ###### ### ########.
		 */
		getRowItemViewModelName: function(dataValueType) {
			var viewModelName;
			switch (dataValueType) {
				case this.Terrasoft.DataValueType.ENUM:
					viewModelName = this.comboBoxItemClassName;
					break;
				case this.Terrasoft.DataValueType.FLOAT:
					viewModelName = this.floatItemClassName;
					break;
				case this.Terrasoft.DataValueType.INTEGER:
					viewModelName = this.integerItemClassName;
					break;
				case this.Terrasoft.DataValueType.BOOLEAN:
					viewModelName = this.booleanItemClassName;
					break;
				case this.Terrasoft.DataValueType.TEXT:
					viewModelName = this.textItemClassName;
					break;
				default:
					viewModelName = this.defaultRowItemViewModelName;
					break;
			}
			return viewModelName;
		},

		/**
		 * ########## ###### ############ ###### ############# ### ######## ######.
		 * @private
		 * @param {String} id ############# ########.
		 * @return {Object} ###### ############.
		 */
		getRowItemViewModelConfig: function(id) {
			return {
				values: {
					Id: id,
					ElementId: this.Terrasoft.generateGUID(),
					ParentItem: this,
					DefaultValues: this.get("DefaultValues")
				}
			};
		},

		/**
		 * ########## ######### {@link Terrasoft.BaseSpecificationItemViewModel}.
		 * @protected
		 * @param {String} id ############# ########.
		 * @param {Terrasoft.BaseViewModel} entity ###### ########.
		 * @return {Terrasoft.BaseSpecificationItemViewModel} ##### ######### ###### ########.
		 */
		getItemViewModel: function(id, entity) {
			var hasEntity = !this.Ext.isEmpty(entity);
			var rowIndex = this.get("RowPosition");
			var collection = this.getRowValuesCollection();
			var valueIndex = collection.getCount();
			var viewModelConfig = this.getRowItemViewModelConfig(id);
			var entityDataValueType = entity && entity.get("DataValueType");
			if (hasEntity && !this.Ext.isEmpty(entityDataValueType)) {
				var rowItemViewModelName = this.getRowItemViewModelName(entityDataValueType);
				this.set("RowItemViewModelName", rowItemViewModelName);
			}
			viewModelConfig.Ext = this.Ext;
			viewModelConfig.sandbox = this.sandbox;
			viewModelConfig.Terrasoft = this.Terrasoft;
			var viewModel = this.Ext.create(this.get("RowItemViewModelName") || this.defaultRowItemViewModelName,
				viewModelConfig);
			if (hasEntity) {
				viewModel.loadEntity(entity);
			} else {
				viewModel.set("RowPosition", rowIndex);
				viewModel.set("ValuePosition", valueIndex);
			}
			return viewModel;
		},

		/**
		 * ########## ######### {@link Terrasoft.ToolsItemViewModel} ### ######## ###### ########.
		 * @protected
		 * @return {Terrasoft.ToolsItemViewModel} ##### ######### ######.
		 */
		getToolsItemViewModel: function() {
			var viewModelConfig = {
				values: {
					Id: this.get("ToolsItemId"),
					IsTools: true
				}
			};
			return this.Ext.create("Terrasoft.ToolsItemViewModel", viewModelConfig);
		},

		/**
		 * ######### ###### ############ ######## ###### ######## ########.
		 * @protected
		 * @return {Object} ###### ############ ########.
		 */
		getToolsItemViewConfig: function() {
			var itemId = this.get("ToolsItemId");
			var wrapContainer = ViewUtilities.getContainerConfig(itemId,
				["specification-row-inline-value", "row-add-button"]);
			var toolsConfig = this.get("ToolItemsConfig");
			wrapContainer.visible = {"bindTo": "ToolItemsVisible"};
			this.Terrasoft.each(toolsConfig, function(item) {
				item = this.Ext.apply(item, {
					"click": {"bindTo": "onToolsClick"}
				});
				wrapContainer.items.push(item);
			}, this);
			return wrapContainer;
		},

		/**
		 * ############# ######## ######### ###### "######## ########".
		 * @protected
		 * @param {Boolean} value ######## ######### ###### ########.
		 */
		setToolsVisible: function(value) {
			var collection = this.getRowValuesCollection();
			var toolsItemId = this.get("ToolsItemId");
			var buttonItem = collection.get(toolsItemId);
			buttonItem.set("ToolItemsVisible", value);
		},

		/**
		 * ####### ######### ######## ######.
		 * @protected
		 */
		clearValuesCollection: function() {
			var collection = this.getRowValuesCollection();
			collection.each(function(item) {
				if (!item.get("IsTools")) {
					collection.remove(item);
				}
			});
		},

		/**
		 * ######### # ######### ######## ##### ######### {@link Terrasoft.BaseSpecificationItemViewModel}.
		 * @protected
		 */
		onAddRowValue: function() {
			this.changeFireEvent();
			this.addRowValue();
		},

		/**
		 * ######### # ######### ######## ######### # ######## #############.
		 * @param {Terrasoft.BaseViewModel} entity ###### ########.
		 * @protected
		 */
		addRowValue: function(entity) {
			this.onBeforeAddRowValue();
			var collection = this.getRowValuesCollection();
			var id;
			if (this.Ext.isEmpty(entity)) {
				id = this.Terrasoft.generateGUID();
			} else {
				var entityPrimaryColumnName = entity.primaryColumnName;
				id = entity.get(entityPrimaryColumnName);
			}
			collection.add(id, this.getItemViewModel(id, entity));
		},

		/**
		 * ######### ###### ############ ######## ########.
		 * @protected
		 * @param {Object} itemConfig ###### ############ ######.
		 * @param {Object} viewModel ###### ######## ########.
		 */
		getRowItemViewConfig: function(itemConfig, viewModel) {
			if (viewModel.get("IsTools")) {
				var toolsViewConfig = this.getToolsItemViewConfig();
				itemConfig.config = toolsViewConfig;
				return;
			}
			var wrapContainer = ViewUtilities.getContainerConfig("value-item-view",
				["specification-row-inline-value"]);
			var itemViewConfig = {};
			if (Terrasoft.instanceOfClass(viewModel, this.defaultRowItemViewModelName) ||
				Terrasoft.instanceOfClass(viewModel, this.defaultMatrixViewModelName)) {
				itemViewConfig = viewModel.getItemViewConfig();
				wrapContainer.items.push(itemViewConfig);
			}
			itemConfig.config = wrapContainer;
		},

		/**
		 * ######### ############## ######## ##### ########### ###### ######## # ######.
		 * @protected
		 */
		onBeforeAddRowValue: this.Terrasoft.emptyFn,

		/**
		 * @inheritdoc Terrasoft.BaseObject#onDestroy
		 * @overridden
		 */
		onDestroy: function() {
			this.unsubscribeForValuesCollectionEvents();
			var parameterViewModel = this.get("ParameterViewModel");
			parameterViewModel.un("change", this.onItemChanged, this);
			parameterViewModel.destroy();
			this.callParent(arguments);
		}
	});

	return Terrasoft.BaseSpecificationRowViewModel;
});
