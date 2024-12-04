define("ChangeCriteriaDetailV2", ["DefSpecificationDetailV2"],
	function() {
		return {
			entitySchemaName: "ChangeCriteria",
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
			attributes: {
				/**
				 * ######## ### ####### ######, ############ ## ######## ####.
				 * @type {String}
				 */
				"DetailColumnNameForType": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"value": "ProductType"
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.DefSpecificationDetailV2#getSpecificationLookupFilter
				 * @overridden
				 */
				getSpecificationLookupFilter: function() {
					var filters;
					if (this.get("DetailColumnName") === this.get("DetailColumnNameForType")) {
						filters = this.getTypePageFilters();
					} else {
						filters = this.getCategoryPageFilters();
					}
					return filters;
				},

				/**
				 * ########## ###### ### ###### ## ######## #########.
				 * @protected
				 * @return {Terrasoft.BaseFilter} ###### ### ###### ######## ######### #######, ####### ### ## ####
				 * ######### # ####### ######### # ## ####.
				 */
				getCategoryPageFilters: function() {
					var categoryId = this.get("MasterRecordId");
					var notExistsFilter = this.Terrasoft.createNotExistsFilter(
						"[ChangeCriteria:Specification:Id].Id");
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					var filterByCategory = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ProductCategory", categoryId);
					filterGroup.addItem(filterByCategory);
					var typeExistsFilter = this.Terrasoft.createExistsFilter(
						"[ProductType:Id:ProductType].Category");
					var filterByType = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Category", categoryId);
					typeExistsFilter.subFilters.addItem(filterByType);
					filterGroup.addItem(typeExistsFilter);
					notExistsFilter.subFilters.addItem(filterGroup);
					return notExistsFilter;
				},

				/**
				 * ########## ###### ### ###### ## ######## ####.
				 * @protected
				 * @return {Terrasoft.BaseFilter} ###### ### ###### ######## ######### #######, ####### ### ## ####
				 * ######### # ####### ### # ### #########.
				 */
				getTypePageFilters: function() {
					var typeId = this.get("MasterRecordId");
					var categoryId = this.getDefaultValueByName("Category");
					var notExistsFilter = this.Terrasoft.createNotExistsFilter(
						"[ChangeCriteria:Specification:Id].Id");
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					var filterByType = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ProductType", typeId);
					filterGroup.addItem(filterByType);
					var filterByCategory = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ProductCategory", categoryId);
					filterGroup.addItem(filterByCategory);
					notExistsFilter.subFilters.addItem(filterGroup);
					return notExistsFilter;
				},

				/**
				 * ########## ######## ## #########.
				 * @protected
				 * @virtual
				 * @param {String} valueName ### ########.
				 * @return {Object} ########## ######## ## #########.
				 */
				getDefaultValueByName: function(valueName) {
					var value = null;
					var defaultValues = this.get("DefaultValues") || this.getDefaultValues() || [];
					if (defaultValues) {
						var defaultValue = this.Terrasoft.findItem(defaultValues, {name: valueName});
						if (defaultValue) {
							defaultValue = defaultValue.item;
							if (defaultValue && !this.Ext.isEmpty(defaultValue.value)) {
								value = defaultValue.value;
							}
						}
					}
					return value;
				}
			}
		};
	});
