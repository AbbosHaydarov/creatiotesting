define("ProductConditionSpecificationRowViewModel", ["SpecificationBuilderConstants",
	"ProductConditionSpecificationRowViewModelResources", "BaseSpecificationRowViewModel",
	"ProductConditionParameterItemViewModel", "ProductConditionComboBoxItemViewModel",
	"ProductConditionFloatItemViewModel", "ProductConditionIntegerItemViewModel",
	"ProductConditionBooleanItemViewModel", "ProductConditionTextItemViewModel",
	"ProductConditionFloatItemRangeViewModel", "ProductConditionIntegerItemRangeViewModel"],
	function(SpecificationBuilderConstants, resources) {
	/**
	 * @class Terrasoft.ProductConditionSpecificationRowViewModel
	 */
	Ext.define("Terrasoft.configuration.ProductConditionSpecificationRowViewModel", {
		alternateClassName: "Terrasoft.ProductConditionSpecificationRowViewModel",
		extend: "Terrasoft.BaseSpecificationRowViewModel",

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#floatItemClassName
		 * @overridden
		 */
		floatItemClassName: "Terrasoft.ProductConditionFloatItemViewModel",

		/**
		 * ### ###### ### ######### ####### ########.
		 * @type {String}
		 */
		floatItemRangeClassName: "Terrasoft.ProductConditionFloatItemRangeViewModel",

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#integerItemClassName
		 * @overridden
		 */
		integerItemClassName: "Terrasoft.ProductConditionIntegerItemViewModel",

		/**
		 * ### ###### ### ######### ##### ########.
		 * @type {String}
		 */
		integerItemRangeClassName: "Terrasoft.ProductConditionIntegerItemRangeViewModel",

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#comboBoxItemClassName
		 * @overridden
		 */
		comboBoxItemClassName: "Terrasoft.ProductConditionComboBoxItemViewModel",

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#textItemClassName
		 * @overridden
		 */
		textItemClassName: "Terrasoft.ProductConditionTextItemViewModel",

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#booleanItemClassName
		 * @overridden
		 */
		booleanItemClassName: "Terrasoft.ProductConditionBooleanItemViewModel",

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#parameterViewModelClassName
		 * @overridden
		 */
		parameterViewModelClassName: "Terrasoft.ProductConditionParameterItemViewModel",

		/**
		 * ### #######, ############ ### ##### #### ########### ######## ######.
		 * @type {String}
		 */
		viewTypeChangedEventName: "onChangeViewType",

		/**
		 * ### #######, ############ ### ######## ########### ###### ######## ######.
		 * @type {String}
		 */
		prepareListEventName: "prepareList",

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#constructor
		 * @overridden
		*/
		constructor: function() {
			this.callParent(arguments);
			this.initResourcesValues(resources);
		},

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#onItemChanged
		 * @overridden
		*/
		onItemChanged: function(item, config) {
			this.callParent(arguments);
			switch (config.event) {
				case this.viewTypeChangedEventName:
					this.changeViewType(config.arguments);
					break;
				case this.prepareListEventName:
					this.prepareValueList.apply(this, config.arguments);
					break;
				default:
					break;
			}
		},

		/**
		 * ######### ###### ######## ### ###### # ######## ######.
		 * @protected
		 * @param {String} value #####, ######### # ##########.
		 * @param {Terrasoft.Collection} list ######### ######## ## ######.
		 */
		prepareValueList: function(value, list) {
			var rowValuesCollection = this.get("RowValuesCollection");
			var listItemsCollection = this.getSpecificationListItemCollection();
			var uniqueItems = this.difference(listItemsCollection, rowValuesCollection, function(listItem, rowItem) {
				var value = rowItem.get("Value");
				return value && value.value === listItem.value;
			}, this);
			list.clear();
			list.loadAll(uniqueItems);
		},

		/**
		 * ####### ##### ######### sourceCollection, ## ####### ####### ### ######## ## collectionToCompare.
		 * @private
		 * @param {Terrasoft.Collection} sourceCollection ######### #########, ######## ####### ##### ######### #
		 * ############## #########.
		 * @param {Terrasoft.Collection} collectionToCompare ######### ######### ### #########.
		 * @param {Function} comparator ####### ### ######### ######### sourceCollection # collectionToCompare.
		 * ########## true, #### ######## #########.
		 * @param {Object} scope ######## ####### comparator.
		 * @return {Terrasoft.Collection} ############## ######### #########.
		 */
		difference: function(sourceCollection, collectionToCompare, comparator, scope) {
			var result = this.clone(sourceCollection);
			sourceCollection.each(function(sourceItem) {
				collectionToCompare.each(function(itemToCompare) {
					if (comparator.call(scope || this, sourceItem, itemToCompare)) {
						result.remove(sourceItem);
					}
				});
			});
			return result;
		},

		/**
		 * ####### ############# ##### #########.
		 * @private
		 * @return {Terrasoft.Collection} ##### #########.
		 */
		clone: function(collection) {
			var cloneFunc = function() {
				var result = new this.self();
				result.collection = this.collection.clone();
				return result;
			}.bind(collection);
			return cloneFunc();
		},

		/**
		 * ###### ### ############# ######## # ######.
		 * @protected
		 * @param {Object} config ###### ############.
		 */
		changeViewType: function(config) {
			var value = config.value;
			var type = value.Type;
			var itemViewModelName = this.getRowItemViewModelNameByType(type);
			this.set("RowItemViewModelName", itemViewModelName);
			this.onParameterChanged();
		},

		/**
		 * ########## ##### ###### ############# ########.
		 * @protected
		 * @param {Object} type ### #########.
		 * @param {String} type.value ############# #### #########.
		 * @return {String} ### ###### ###### ######## ######.
		 */
		getRowItemViewModelNameByType: function(type) {
			var dataValueType = this.getDataValueTypeBySpecificationType(type.value);
			return this.getRowItemViewModelName(dataValueType);
		},

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#getRowItemViewModelName
		 * @overridden
		 */
		getRowItemViewModelName: function(dataValueType) {
			var viewModelName = this.callParent(arguments);
			var parameterViewModel = this.get("ParameterViewModel");
			var rangeViewModelName;
			if (parameterViewModel.get("CurrentType") === SpecificationBuilderConstants.ViewType.RangeValue) {
				rangeViewModelName = this.getRangeItemViewModelName(dataValueType);
			}
			return rangeViewModelName || viewModelName;
		},

		/**
		 * ########## ##### ###### ### ######### ########.
		 * @protected
		 * @param {Terrasoft.DataValueType} dataValueType ### #########.
		 * @return {String} ##### ###### ### ######### ########.
		 */
		getRangeItemViewModelName: function(dataValueType) {
			var viewModelClassName;
			switch (dataValueType) {
				case this.Terrasoft.DataValueType.FLOAT:
					viewModelClassName = this.floatItemRangeClassName;
					break;
				case this.Terrasoft.DataValueType.INTEGER:
					viewModelClassName = this.integerItemRangeClassName;
					break;
				default:
					break;
			}
			return viewModelClassName;
		},

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#onParameterValueChanged
		 * @overridden
		 */
		onParameterValueChanged: function(changedItemArgs) {
			this.callParent(arguments);
			var value = changedItemArgs.value;
			var type = value && value.Type;
			if (!this.Ext.isEmpty(type)) {
				var dataValueType = this.getDataValueTypeBySpecificationType(type.value);
				var itemViewModelName = this.getRowItemViewModelName(dataValueType);
				this.set("RowItemViewModelName", itemViewModelName);
				this.onParameterChanged();
			} else {
				this.clearValuesCollection();
				this.setToolsVisible(false);
			}
		},

		/**
		 * #### ######### ######## ## ######, ## ####### #########.
		 * ##### ######### # ######### ##### ######### {@link Terrasoft.BaseSpecificationItemViewModel} ### ##########.
		 * @protected
		 */
		onParameterChanged: function() {
			var rowValuesCollection = this.getRowValuesCollection();
			if (!rowValuesCollection.isEmpty()) {
				this.clearValuesCollection();
			}
			this.addRowValue();
		},

		/**
		 * ##### ########## ### ######## ## #### ##############.
		 * @protected
		 * @param {Terrasoft.Guid} typeId ######## #### ##############.
		 * @return {Terrasoft.DataValueType} ### ########.
		 */
		getDataValueTypeBySpecificationType: function(typeId) {
			var dataValueType;
			switch (typeId.toLowerCase()) {
				case SpecificationBuilderConstants.SpecificationType.Lookup:
					dataValueType = this.Terrasoft.DataValueType.ENUM;
					break;
				case SpecificationBuilderConstants.SpecificationType.Float:
					dataValueType = this.Terrasoft.DataValueType.FLOAT;
					break;
				case SpecificationBuilderConstants.SpecificationType.Boolean:
					dataValueType = this.Terrasoft.DataValueType.BOOLEAN;
					break;
				case SpecificationBuilderConstants.SpecificationType.Text:
					dataValueType = this.Terrasoft.DataValueType.TEXT;
					break;
				case SpecificationBuilderConstants.SpecificationType.Integer:
					dataValueType = this.Terrasoft.DataValueType.INTEGER;
					break;
				default:
					break;
			}
			return dataValueType;
		},

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#getRowViewConfig
		 * @overridden
		 */
		getRowViewConfig: function() {
			var baseSpecificationConfig = this.getSpecificationViewConfig();
			var config = {
				"className": "Terrasoft.SpecificationRow",
				"specificationConfig": baseSpecificationConfig,
				"parameterViewModel": {"bindTo": "ParameterViewModel"},
				"containerListConfig": {
					"itemPrefix": "row-value",
					"idProperty": "ElementId",
					"collection": {"bindTo": "RowValuesCollection"},
					"onGetItemConfig": {"bindTo": "getRowItemViewConfig"}
				},
				"isRowToolsVisible": false,
				"items": {
					"bindTo": "ToolItemsConfig"
				}
			};
			return config;
		},

		/**
		 * ########## ############ #########.
		 * @protected
		 * @return {Object} ###### ############ ### #########.
		 */
		getSpecificationViewConfig: function() {
			var viewModel = this.get("ParameterViewModel");
			return viewModel.getItemViewConfig();
		},

		/**
		* ########## ###### ######### ### ####### ######## # ######### ######.
		* @protected
		* @return {Object} ###### #########.
		*/
		getSpecificationToolsConfig: function() {
			var toolsConfig = {
				items: [{
					"className": "Terrasoft.Button",
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {"bindTo": "Resources.Images.RemoveButtonImage"},
					"tag": "remove",
					"click": {"bindTo": "onRemoveButtonClick"}
				}]
			};
			return toolsConfig;
		},

		/**
		 * @inheritDoc Terrasoft.BaseSpecificationRowViewModel#onBeforeAddRowValue
		 * @overridden
		 */
		onBeforeAddRowValue: function() {
			this.setAddButtonVisibleByType();
		},

		/**
		 * ############# ######### ### ###### ######## # ########### ## ######## #### ### ######## ######### #
		 * ########## #### #############.
		 * @protected
		 */
		setAddButtonVisibleByType: function() {
			var parameter = this.get("ParameterViewModel");
			var viewType = parameter.get("CurrentType");
			var item = parameter.get("Value");
			var valueType = item && item.Type;
			valueType = valueType && valueType.value;
			var isValueTypeEqualLookup = valueType === SpecificationBuilderConstants.SpecificationType.Lookup;
			var isViewTypeEqualTableValue = viewType === SpecificationBuilderConstants.ViewType.TableValue;
			this.setToolsVisible(isValueTypeEqualLookup && !isViewTypeEqualTableValue);
		},

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#loadEntity
		 * @overridden
		 */
		loadEntity: function(entity) {
			var value = entity.get("Value");
			var propertyValueConfig = {
				silent: true,
				preventValidation: true
			};
			var parameterViewModel = this.get("ParameterViewModel");
			parameterViewModel.set("CurrentType", entity.get("CurrentType"), propertyValueConfig);
			parameterViewModel.setRemoveButtonMarker(value);
			this.callParent(arguments);
			parameterViewModel.fillSpecificationListItemCollection(value);
		},

		/**
		 * ########## ######## ######## SpecificationListItemCollection ## ###### #########.
		 * @return {Terrasoft.Collection} ######### ######### ######## ### ###### # ######.
		 */
		getSpecificationListItemCollection: function() {
			var parameter = this.get("ParameterViewModel");
			return parameter.get("SpecificationListItemCollection");
		},

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#onAddRowValue
		 * @overridden
		 */
		onAddRowValue: function() {
			var collection = this.getSpecificationListItemCollection();
			var selectedValues = this.get("RowValuesCollection");
			var parameter = this.get("ParameterViewModel");
			var parameterValue = parameter.get("Value");
			if (collection.getCount() < selectedValues.getCount() &&
				parameterValue.Type.value === SpecificationBuilderConstants.SpecificationType.Lookup) {
				this.showInformationDialog(this.get("Resources.Strings.WarningAllLookupItemsAdded"));
			} else {
				this.callParent(arguments);
			}
		}
	});
	return Terrasoft.ProductConditionSpecificationRowViewModel;
});
