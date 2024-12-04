define("SpecificationInContractPageV2", [], function() {
	return {
		entitySchemaName: "SpecificationInContract",
		diff: /**SCHEMA_DIFF*/[],/**SCHEMA_DIFF*/
		attributes: {
			"Contract": {
				lookupListConfig: {
					columns: ["Product", "Product.Type", "Product.Category"]
				}
			}
		},
		methods: {
			/**
			 * Returns filter for ListItemValue column.
			 * @protected
			 * @return {Terrasoft.CompareFilter} Filter for ListItemValue column.
			 */
			getListItemValueFilter: function() {
				var specification = this.get("Specification");
				var listItemValueFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"Specification", specification.value);
				return listItemValueFilter;
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#getLookupQueryFilters
			 * @overridden
			 */
			getLookupQueryFilters: function(columnName) {
				var mainFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
				var contract = this.get("Contract");
				if (columnName === "Specification" && !this.Ext.isEmpty(contract)) {
					var productType = contract["Product.Type"];
					var productCategory =  contract["Product.Category"];
					var contractFilterPath = "[SpecificationInContract:Specification:Id].Contract";
					var subContractFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
					var contractFilter = this.Terrasoft.createColumnInFilterWithParameters(contractFilterPath,
						[contract.value]);
					subContractFilterGroup.addItem(contractFilter);
					var notExistsFilter = this.Terrasoft.createNotExistsFilter("Id", subContractFilterGroup);
					var productTypeFiltersGroup = this.Terrasoft.createFilterGroup();
					productTypeFiltersGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					if (!Ext.isEmpty(productType)) {
						var productTypeFilterPath = "[DefSpecification:Specification:Id].ProductType";
						var productTypeFilter = this.Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
							productTypeFilterPath, productType.value);
						productTypeFiltersGroup.addItem(productTypeFilter);
					}
					if (!Ext.isEmpty(productCategory)) {
						var productCategoryFilterPath = "[DefSpecification:Specification:Id].ProductCategory";
						var productCategoryFilter = this.Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
							productCategoryFilterPath, productCategory.value);
						productTypeFiltersGroup.addItem(productCategoryFilter);
					}
					mainFilterGroup.addItem(notExistsFilter);
					mainFilterGroup.addItem(productTypeFiltersGroup);
				}
				var specification = this.get("Specification");
				if (columnName === "ListItemValue" && !this.Ext.isEmpty(specification)) {
					var specificationFilter = this.getListItemValueFilter();
					mainFilterGroup.addItem(specificationFilter);
				}
				return mainFilterGroup;
			}
		}
	};
});
