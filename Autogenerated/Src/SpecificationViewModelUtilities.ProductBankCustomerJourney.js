define("SpecificationViewModelUtilities", ["SpecificationBuilderConstants", "LookupUtilities",
		"SpecificationViewModelUtilitiesResources"],
	function(SpecificationBuilderConstants, LookupUtilities, resources) {
		Ext.define("Terrasoft.configuration.SpecificationViewModelUtilities", {
			extend: "Terrasoft.BaseObject",
			alternateClassName: "Terrasoft.SpecificationViewModelUtilities",

			/**
			 * ######## ######, ######## ########### ##########
			 * ####### {@link Terrasoft.BaseSpecificationItemViewModel}, {@link Terrasoft.SpecificationRowViewModel}.
			 * @type {Object}
			 */
			methods: {
				/**
				 * ############## View Model.
				 * @protected
				 */
				init: function() {
					this.set("ValueList", this.Ext.create("Terrasoft.Collection"));
					this.setChangeTypeButtonMenu();
					this.set("CurrentType", SpecificationBuilderConstants.ViewType.SingleValue);
				},

				/**
				 * ######### ######### ######### ### ########### #### ### ###### ## ##### #### ########
				 * #########.
				 * @protected
				 */
				setChangeTypeButtonMenu: function() {
					var changeTypeMenuItems = Ext.create("Terrasoft.BaseViewModelCollection");
					changeTypeMenuItems.add("singleValue", this.Ext.create("Terrasoft.BaseViewModel", {
						values: {
							"Caption": resources.localizableStrings.SingleValueButtonCaption,
							"Click": {"bindTo": "changeType"},
							"Tag": SpecificationBuilderConstants.ViewType.SingleValue
						}
					}));
					changeTypeMenuItems.add("tableValue", this.Ext.create("Terrasoft.BaseViewModel", {
						values: {
							"Caption": resources.localizableStrings.TableValueButtonCaption,
							"Click": {"bindTo": "changeType"},
							"Tag": SpecificationBuilderConstants.ViewType.TableValue
						}
					}));
					this.set("ChangeTypeMenuItems", changeTypeMenuItems);
				},

				/**
				 * ############ ####### ###### # ########## #### ## ##### #### ######## #########.
				 * @protected
				 * @param {String} tag Tag ######.
				 */
				changeType: function(tag) {
					if (this.get("CurrentType") === tag) {
						return;
					}
					if (tag === SpecificationBuilderConstants.ViewType.TableValue) {
						this.setToolsVisible(false);
					}
					this.set("CurrentType", tag);
					var value = this.get("Value");
					this.sandbox.publish("GetSpecificationRowConfig", {
						id: this.get("Id"),
						value: value,
						tag: tag,
						isParameterValue: this.IsParameterValue
					}, [this.sandbox.id]);
				},

				/**
				 * @inheritdoc Terrasoft.SpecificationRowViewModel#onBeforeAddRowValue
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
					var item = this.get("Value");
					var valueType = item && item.Type;
					valueType = valueType && valueType.value;
					var isValueTypeEqualLookup = valueType === SpecificationBuilderConstants.SpecificationType.Lookup;
					var viewType = this.get("CurrentType");
					var isViewTypeEqualTableValue = viewType === SpecificationBuilderConstants.ViewType.TableValue;
					this.setToolsVisible(isValueTypeEqualLookup && !isViewTypeEqualTableValue);
				},

				/**
				 * ######### ####### ## #### # ######### ########.
				 * @protected
				 */
				getProductTypeFilter: function(callback) {
					var productId = this.get("ProductId");
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
							this.getLookupFilters(productCategoryId, productTypeId, callback);
						}
					}, this);
				},

				/**
				 * ######### ######## ###### ## ###########.
				 * @protected
				 * @param {Terrasoft.FilterGroup} filters ####### ### ######## ###########.
				 */
				openLookup: function(filters) {
					var config = {
						entitySchemaName: this.get("EntitySchemaName"),
						multiSelect: false,
						columns: ["Type"],
						filters: filters
					};
					var handler = function(args) {
						var collection = args.selectedRows;
						var items = collection.getItems();
						if (items.length > 0) {
							this.set("Value", items[0]);
						}
					};
					LookupUtilities.Open(this.sandbox, config, handler, this, null, false, false);
				},

				/**
				 * ############ ####### ## #### # #### ########### ####.
				 * @protected
				 */
				loadVocabulary: function() {
					this.getProductTypeFilter(this.openLookup);
				},

				/**
				 * ############ ####### ##### ######## # #### ########### ####.
				 * @protected
				 * @param {String} value ######### ########.
				 * @param {Terrasoft.Collection} list ######### ######## ######.
				 */
				prepareList: function(value, list) {
					this.getProductTypeFilter(function(filter) {
						this.fillSpecification(value, filter, list);
					});
				},

				/**
				 * ########## ######## ### ########### ### ##### # ##########.
				 * @protected
				 * @param {String} value ######### ########.
				 * @param {Terrasoft.FilterGroup} filter ####### ### ######## # ########## ######.
				 * @param {Terrasoft.Collection} list ######### ######## ######.
				 */
				fillSpecification: function(value, filter, list) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Specification"
					});
					esq.addColumn("Id", "value");
					esq.addColumn("Name", "displayValue");
					esq.addColumn("Type");
					var lookupFilter = esq.createPrimaryDisplayColumnFilterWithParameter(
						this.Terrasoft.SysSettings.lookupFilterType, value, this.Terrasoft.DataValueType.TEXT);
					esq.filters.addItem(lookupFilter);
					esq.filters.addItem(filter);
					esq.getEntityCollection(function(result) {
						if (result.success) {
							var objects = {};
							var collection = result.collection;
							collection.each(function(item) {
								var itemId = item.get("value");
								var itemName = item.get("displayValue");
								var itemType = item.get("Type");
								objects[itemId] = {
									value: itemId,
									displayValue: itemName,
									Type: itemType
								};
							}, this);
							list.clear();
							list.loadAll(objects);
						}
					}, this);
				},

				/**
				 * ######### ####### ### ########## ############ ######## ########## # #######.
				 * @protected
				 * @return {Terrasoft.FilterGroup} ###### ########.
				 */
				getUniqueFilter: function() {
					var parentItem = this.get("ParentItem");
					var rows = parentItem.getRowsCollection();
					var rowsItems = rows.getItems();
					var selectedValues = [];
					this.Terrasoft.each(rowsItems, function(item) {
						var itemValue = item.get("Value");
						itemValue = itemValue && itemValue.value;
						if (!this.Ext.isEmpty(itemValue)) {
							selectedValues.push(itemValue);
						}
					}, this);
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					var notInFilter = this.Terrasoft.createColumnInFilterWithParameters("Id", selectedValues);
					notInFilter.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
					filterGroup.addItem(notInFilter);
					return filterGroup;
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
				 * ######### ####### ### ######## ##########.
				 * @protected
				 * @return {Terrasoft.FilterGroup} ###### ########.
				 */
				getLookupFilters: function(productCategoryId, productTypeId, callback) {
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					filterGroup.addItem(this.getUniqueFilter());
					var categoryFilterGroup = this.getCategoryFilter(productCategoryId);
					categoryFilterGroup.addItem(this.getTypeFilter(productCategoryId, productTypeId));
					filterGroup.addItem(categoryFilterGroup);
					if (this.Ext.isFunction(callback)) {
						callback.call(this, filterGroup);
					}
				}
			},

			/**
			 * ######## ###### ## ########## ####### {@link Terrasoft.BaseSpecificationItemViewModel},
			 * {@link Terrasoft.SpecificationRowViewModel}.
			 * @type {Object}
			 */
			queryMethods: {
				/**
				 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
				 * @overridden
				 */
				getSaveQuery: function() {
					var specificationId = this.get("SpecificationId");
					var value = this.get("Value");
					var dataValueType = this.get("DataValueType");
					var parentItem = this.get("ParentItem");
					var productConditionId = parentItem.get("ProductConditionId");
					var query = null;
					if (this.isNew) {
						query = this.getInsertQuery();
					} else {
						query = this.getUpdateQuery();
						this.primaryColumnName = "Id";
						query.enablePrimaryColumnFilter(this.get(this.primaryColumnName));
					}
					var columnValues = query.columnValues;
					columnValues.clear();
					columnValues.setParameterValue("ProductCondition", productConditionId,
							this.Terrasoft.DataValueType.GUID);
					columnValues.setParameterValue("Specification", specificationId,
						this.Terrasoft.DataValueType.GUID);
					columnValues.setParameterValue("SpecInConditionType",
						this.get("SpecificationInConditionType"),
						this.Terrasoft.DataValueType.GUID);
					columnValues.setParameterValue("RowPosition",
						this.get("RowPosition"),
						this.Terrasoft.DataValueType.INTEGER);
					columnValues.setParameterValue("ValuePosition",
						this.get("ValuePosition"),
						this.Terrasoft.DataValueType.INTEGER);
					this.addParameterValue(columnValues, dataValueType, value);
					return query;
				},

				/**
				 * ######### # ####### ## ########## ###### ######## # ############ # ##### ######## #########
				 * @private
				 * @param {Terrasoft.InsertQuery} columnValues ###### ## ########## ######.
				 * @param {Terrasoft.DataValueType} dataValueType ### #########.
				 * @param {Object} value ######## #########.
				*/
				addParameterValue: function(columnValues, dataValueType, value) {
					switch (dataValueType) {
						case this.Terrasoft.DataValueType.ENUM:
							if (!this.Ext.isEmpty(value.value)) {
								columnValues.setParameterValue("SpecificationListItem", value.value,
									this.Terrasoft.DataValueType.GUID);
							}
							break;
						case this.Terrasoft.DataValueType.FLOAT:
							columnValues.setParameterValue("FloatValue", value, this.Terrasoft.DataValueType.FLOAT);
							break;
						case this.Terrasoft.DataValueType.INTEGER:
							columnValues.setParameterValue("IntegerValue", value, this.Terrasoft.DataValueType.INTEGER);
							break;
						case this.Terrasoft.DataValueType.BOOLEAN:
							columnValues.setParameterValue("BooleanValue", value, this.Terrasoft.DataValueType.BOOLEAN);
							break;
						case this.Terrasoft.DataValueType.TEXT:
							columnValues.setParameterValue("TextValue", value, this.Terrasoft.DataValueType.TEXT);
							break;
						default:
							break;
					}
				}
			}
		});
		return Ext.create("Terrasoft.SpecificationViewModelUtilities");
	});
