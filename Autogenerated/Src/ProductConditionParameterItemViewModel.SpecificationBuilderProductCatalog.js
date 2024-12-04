define("ProductConditionParameterItemViewModel", ["ProductConditionParameterItemViewModelResources",
	"SpecificationBuilderConstants", "BaseComboBoxItemViewModel"],
	function(resources, SpecificationBuilderConstants) {
		/**
		 * @class Terrasoft.ProductConditionParameterItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionParameterItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionParameterItemViewModel",
			extend: "Terrasoft.BaseComboBoxItemViewModel",

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: null,

			/**
			 * ### ####### ### ########### ########.
			 * @type {String}
			 */
			valueColumnName: "Value",

			/**
			 * @inheritdoc Terrasoft.BaseComboBoxItemViewModel#constructor
			 * @overridden
			*/
			constructor: function() {
				this.callParent(arguments);
				this.initResourcesValues(resources);
				this.prepareChangeTypeMenu();
			},

			/**
			 * ############ ####### ## ###### ########.
			 * @protected
			 */
			onRemoveButtonClick: function() {
				this.fireEvent("change", this, {
					event: "onRowRemove",
					arguments: { id: this.get("Id") }
				});
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#initValues
			 * @overridden
			 */
			initValues: function() {
				this.set("ValueList", this.Ext.create("Terrasoft.Collection"));
				this.set("CurrentType", SpecificationBuilderConstants.ViewType.SingleValue);
				this.set("SpecificationListItemCollection", this.Ext.create("Terrasoft.Collection"));
			},

			/**
			 * ########## ### {@link Terrasoft.DataValueType} #########.
			 * @protected
			 * @param {Object} type ### #########.
			 * @param {String} type.value ############# #### ######### # ######## ########.
			 * @return {Terrasoft.DataValueType} ### #########.
			 */
			getParameterDataValueType: function(type) {
				var parentItem = this.get("ParentItem");
				return type ? parentItem.getDataValueTypeBySpecificationType(type.value) : null;
			},

			/**
			 * ############ ######## ######### # ######## ######## Visible ### ######## #### "######## ######## ##-##".
			 * @protected
			 * @param {Object} value ######## #########.
			 * @return {Boolean} ######, #### ### ######### ############# ### #######, ##### ####.
			 */
			rangeMenuItemVisibilityConverter: function(value) {
				var type = value && value.Type;
				var dataValueType = this.getParameterDataValueType(type);
				return dataValueType === this.Terrasoft.DataValueType.FLOAT ||
					dataValueType === this.Terrasoft.DataValueType.INTEGER;
			},

			/**
			 * ######### ######### ######### ########### #### ### ###### ## ##### #### #########.
			 * @protected
			 */
			prepareChangeTypeMenu: function() {
				var changeTypeMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
				changeTypeMenuItems.add("singleValue", this.Ext.create("Terrasoft.BaseViewModel", {
					values: {
						"Caption": this.get("Resources.Strings.SingleValueButtonCaption"),
						"Click": { "bindTo": "onChangeTypeClick" },
						"MarkerValue": this.get("Resources.Strings.SingleValueButtonCaption"),
						"Tag": SpecificationBuilderConstants.ViewType.SingleValue
					}
				}));
				changeTypeMenuItems.add("rangeValue", this.Ext.create("Terrasoft.BaseViewModel", {
					values: {
						"Caption": this.get("Resources.Strings.RangeValueButtonCaption"),
						"Click": { "bindTo": "onChangeTypeClick" },
						"MarkerValue": this.get("Resources.Strings.RangeValueButtonCaption"),
						"Tag": SpecificationBuilderConstants.ViewType.RangeValue,
						"Visible": {
							"bindTo": "Value",
							"bindConfig": {
								"converter": this.rangeMenuItemVisibilityConverter
							}
						}
					}
				}));
				this.set("ChangeTypeMenuItems", changeTypeMenuItems);
			},

			/**
			 * ############ ####### ###### # ########## #### ## ##### #### ######## #########.
			 * @protected
			 * @param {String} tag Tag ######.
			 */
			onChangeTypeClick: function(tag) {
				if (this.get("CurrentType") === tag) {
					return;
				}
				this.set("CurrentType", tag);
				var value = this.get("Value");
				this.fireEvent("change", this, {
					event: "onChangeViewType",
					arguments: {
						tag: tag,
						value: value
					}
				});
			},

			/**
			 * @inheritDoc Terrasoft.BaseComboBoxItemViewModel#onValueChanged
			 * @overridden
			 */
			onValueChanged: function() {
				var value = this.get("Value");
				if (value) {
					this.setRemoveButtonMarker(value);
					this.fillSpecificationListItemCollection(value);
				}
				this.fireEvent("change", this, {
					event: "onChangeParameterValue",
					arguments: {
						id: this.get("Id"),
						value: value
					}
				});
			},

			/**
			 * ############# ##### ######## # RemoveParameterMarker.
			 * @protected
			 * @param {Object} value ####### ######## ######## Value.
			 */
			setRemoveButtonMarker: function(value) {
				var markerValue = this.Ext.String.format(this.get("Resources.Strings.RemoveButtonMarkerValue"),
					value.displayValue);
				this.set("RemoveParameterMarker", markerValue);
			},

			/**
			 * ########## ###### ## ######### ###### ######## ###########.
			 * @protected
			 * @param {Object} specification ######## #########.
			 */
			fillSpecificationListItemCollection: function(specification) {
				var config = this.getConfigForSpecificationListItemQuery(specification);
				var esq = this.createLookupQuery(config);
				esq.getEntityCollection(this.onGetSpecificationListItems.bind(this, config.columnNames), this);
			},

			/**
			 * ########## ###### ############ ### ########## ####### ## ######### ######## ###########.
			 * @protected
			 * @param {Object} specification ######## #########.
			 * @return {Object} ########## ###### ############.
			 */
			getConfigForSpecificationListItemQuery: function(specification) {
				var schemaName = "SpecificationListItem";
				var filterGroup = this.getSpecificationListItemFilter(specification.value);
				return {
					schemaName: schemaName,
					filter: filterGroup
				};
			},

			/**
			 * ########## ###### ######## ### ######### ###### ######## ###########.
			 * @protected
			 * @param {Object} specificationId ############# ######## #########.
			 * @return {Terrasoft.FilterGroup} ###### ########.
			 */
			getSpecificationListItemFilter: function(specificationId) {
				var filterGroup = this.Terrasoft.createFilterGroup();
				filterGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "Specification", specificationId));
				return filterGroup;
			},

			/**
			 * ############ ######### ########## ####### ## ######### ######## ###########.
			 * @protected
			 * @param {Array} columnNames ###### ############## #######, ####### ########## ######### # ##############
			 * #########.
			 * @param {Object} result ##### ## #######.
			 */
			onGetSpecificationListItems: function(columnNames, result) {
				if (result.success) {
					var resultCollection = this.prepareSpecificationListItemCollection(result.collection, columnNames);
					var collection = this.get("SpecificationListItemCollection");
					collection.clear();
					collection.loadAll(resultCollection);
				} else {
					throw new this.Terrasoft.QueryExecutionException();
				}
			},

			/**
			 * ######### ######### ######### ######## ###########, ########## ## #######.
			 * @protected
			 * @param {Terrasoft.Collection} collection ######### ######## ###########.
			 * @param {Array} columnNames ###### ############## #######, ####### ########## ######### # ##############
			 * #########.
			 * @return {Object} ######, # ######## ### ######## ############ ## #### ############# ######, # ########
			 * ######## ######## ########, ########## displayValue # #### #### ######## columnNames, ## # ######## ###
			 * #### #######.
			 */
			prepareSpecificationListItemCollection: function(collection, columnNames) {
				var objects = {};
				collection.each(function(item) {
					var value = item.get("value");
					var displayValue = item.get("displayValue");
					var object = objects[value] = {};
					object.value = value;
					object.displayValue = displayValue;
					if (this.Ext.isArray(columnNames)) {
						this.Terrasoft.each(columnNames, function(columnName) {
							object[columnName] = item.get(columnName);
						});
					}
				}, this);
				return objects;
			},

			/**
			 * @inheritdoc Terrasoft.BaseComboBoxItemViewModel#getToolsConfig
			 * @overridden
			 */
			getToolsConfig: function() {
				var tools = [];
				tools.push({
					"className": "Terrasoft.Button",
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": { "bindTo": "Resources.Images.ChangeTypeButtonImage" },
					"menu": { "items": { "bindTo": "ChangeTypeMenuItems" } },
					"markerValue": "ChangeViewType",
					"visible": {
						"bindTo": "Value",
						"bindConfig": { "converter": this.changeTypeVisibilityConverter }
					}
				});
				tools.push({
					"className": "Terrasoft.Button",
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"tag": "remove",
					"click": { "bindTo": "onRemoveButtonClick" },
					"markerValue": { "bindTo": "RemoveParameterMarker" },
					"imageConfig": { "bindTo": "Resources.Images.RemoveButtonImage" }
				});
				return tools;
			},

			/**
			 * ######### ######## #### ###### ## ######### #### #########.
			 * @protected
			 * @param {Terrasoft.BaseViewModel} item ####### ######### ####.
			 * @return {Boolean} ######, #### ####### ###### ####### # ############### #########, ##### ####.
			 */
			filterMenuItems: function(item) {
				var result = true;
				var visibleConfig = item.get("Visible");
				if (visibleConfig) {
					var value = this.get(visibleConfig.bindTo);
					var bindConfig = visibleConfig.bindConfig;
					var converter = bindConfig.converter;
					result = this.Ext.isFunction(converter) ? converter.call(this, value) : value;
				}
				return result;
			},

			/**
			 * ######### ######## ######### # ######## visible ### ###### ######### #### #########.
			 * @protected
			 * @param {Object} value ######## #########.
			 * @return {Boolean} ######, #### ######## ###### # # #### ############ ###### ###### ########, ##### ####.
			 */
			changeTypeVisibilityConverter: function(value) {
				var menuItems = this.get("ChangeTypeMenuItems");
				var visibleItems = menuItems.filterByFn(this.filterMenuItems, this);
				return !this.Ext.isEmpty(value) && visibleItems.getCount() > 1;
			},

			/**
			 * @inheritDoc BaseComboBoxItemViewModel#prepareList
			 * @overriden
			 */
			prepareList: function(value, list) {
				this.getProductTypeFilter(function(filter) {
					var config = {
						value: value,
						list: list,
						schemaName: "Specification",
						columnNames: ["Type"],
						filter: filter
					};
					this.fillList(config);
				});
			},

			/**
			 * ######### ####### ## #### # ######### ########.
			 * @protected
			 * @param {Function} callback ####### ######### ######.
			 */
			getProductTypeFilter: function(callback) {
				var productId = this.get("Product");
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "Product"
				});
				esq.addColumn("Id");
				esq.addColumn("Category.Id", "ProductCategoryId");
				esq.addColumn("Type.Id", "ProductTypeId");
				esq.getEntity(productId, function(result) {
					if (result.success) {
						var entity = result.entity;
						var productTypeId = entity.get("ProductTypeId");
						var productCategoryId = entity.get("ProductCategoryId");
						var filterGroup = this.getLookupFilters(productCategoryId, productTypeId, callback);
						if (this.Ext.isFunction(callback)) {
							callback.call(this, filterGroup);
						}
					}
				}, this);
			},

			/**
			 * ######### ####### ### ########## ############ ######## ########## # #######.
			 * @protected
			 * @return {Terrasoft.FilterGroup} ###### ########.
			 */
			getLookupValueUniqueFilter: function() {
				var selectedValues = this.getSelectedValues();
				var filterGroup = this.Terrasoft.createFilterGroup();
				filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
				var notInFilter = this.Terrasoft.createColumnInFilterWithParameters("Id", selectedValues);
				notInFilter.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
				filterGroup.addItem(notInFilter);
				return filterGroup;
			},

			/**
			 * ########## ###### ############### ######### ##########.
			 * @protected
			 * @return {Array} ###### ############### ##########.
			 */
			getSelectedValues: function() {
				var row = this.get("ParentItem");
				var parentItem = row.get("ParentItem");
				var rows = parentItem.getRowsCollection();
				var rowsItems = rows.getItems();
				var selectedValues = [];
				this.Terrasoft.each(rowsItems, function(item) {
					var parameterValue = this.getRowParameterValue(item);
					if (!this.Ext.isEmpty(parameterValue)) {
						selectedValues.push(parameterValue);
					}
				}, this);
				return selectedValues;
			},

			/**
			 * ######## ######## ######### # ######### ######.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationRowViewModel} item ###### ######.
			 * @return {String} ############# ########## ######### ######.
			 */
			getRowParameterValue: function(item) {
				var parameter = item.get("ParameterViewModel");
				var parameterValue = parameter.get("Value");
				parameterValue = parameterValue && parameterValue.value;
				return parameterValue;
			},

			/**
			 * ######### ####### ### ########## ## ######### ########.
			 * @protected
			 * @param {Guid} productCategoryId ########## ############# ######### ########.
			 * @return {Terrasoft.FilterGroup} ###### ########.
			 */
			getCategoryFilter: function(productCategoryId) {
				var categoryFilterGroup = this.Terrasoft.createFilterGroup();
				categoryFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
				var categoryFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"[DefSpecification:Specification:Id].ProductCategory",
					productCategoryId);
				categoryFilterGroup.addItem(categoryFilter);
				return categoryFilterGroup;
			},

			/**
			 * ######### ####### ### ########## ## #### ########.
			 * @protected
			 * @param {Guid} productCategoryId ########## ############# ######### ########.
			 * @param {Guid} productTypeId ########## ############# #### ########.
			 * @return {Terrasoft.FilterGroup} ###### ########.
			 */
			getTypeFilter: function(productCategoryId, productTypeId) {
				var typeFilterGroup = this.Terrasoft.createFilterGroup();
				typeFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
				var typeFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"[DefSpecification:Specification:Id].ProductType",
					productTypeId);
				var typeCategoryFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"[DefSpecification:Specification:Id].ProductType.Category",
					productCategoryId);
				typeFilterGroup.addItem(typeFilter);
				typeFilterGroup.addItem(typeCategoryFilter);
				return typeFilterGroup;
			},

			/**
			 * Generates filters for parameter classification.
			 * @protected
			 * @return {Terrasoft.FilterGroup} Filter group.
			 */
			getSpecInConditionTypeFilters: function() {
				var specificationTypeFilterGroup = this.Terrasoft.createFilterGroup();
				if (this.validateSpecInConditionType()) {
					specificationTypeFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					var specificationTypeFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"SpecInConditionType",
						this.$SpecificationInConditionType
					);
					specificationTypeFilterGroup.addItem(specificationTypeFilter);
					var specificationTypeIsNullFilter = this.Terrasoft.createColumnIsNullFilter("SpecInConditionType");
					specificationTypeFilterGroup.addItem(specificationTypeIsNullFilter);
				}
				return specificationTypeFilterGroup;
			},

			/**
			 * ######### ####### ### ######## ##########.
			 * @protected
			 * @param {Guid} productCategoryId ########## ############# ######### ########.
			 * @param {Guid} productTypeId ########## ############# #### ########.
			 * @return {Terrasoft.FilterGroup} ###### ########.
			 */
			getLookupFilters: function(productCategoryId, productTypeId) {
				var filterGroup = this.Terrasoft.createFilterGroup();
				filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
				filterGroup.addItem(this.getLookupValueUniqueFilter());
				var categoryFilterGroup = this.getCategoryFilter(productCategoryId);
				categoryFilterGroup.addItem(this.getTypeFilter(productCategoryId, productTypeId));
				filterGroup.addItem(categoryFilterGroup);
				filterGroup.addItem(this.getSpecInConditionTypeFilters());
				return filterGroup;
			},

			/**
			 * Check if the type is "Customer".
			 * @protected
			 * @return {boolean} .
			 */
			isCustomerSpecInConditionType: function() {
				return this.$SpecificationInConditionType === SpecificationBuilderConstants.SpecInConditionType.SpecificationCustomerDetail;
			},

			/**
			 * Check if the type is "Product".
			 * @protected
			 * @return {boolean} .
			 */
			isProductSpecInConditionType: function() {
				return this.$SpecificationInConditionType === SpecificationBuilderConstants.SpecInConditionType.SpecificationProductDetail;
			},

			/**
			 * Validate SpecInConditionType.
			 * @protected
			 * @return {boolean} .
			 */
			validateSpecInConditionType: function() {
				return this.$SpecificationInConditionType && (this.isCustomerSpecInConditionType() || this.isProductSpecInConditionType());
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#setItemValue
			 * @overriden
			*/
			setItemValue: function(value) {
				this.set("Value", value);
			}
		});

		return Terrasoft.ProductConditionParameterItemViewModel;
	});
