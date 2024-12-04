define("SpecificationInProductPageV2", [], function() {
	return {
		entitySchemaName: "SpecificationInProduct",
		methods: {
			/**
			 * ######### #######, ####### ############# ## ########## ####.
			 * @private
			 * @param {String} columnName ######## #######.
			 * @return {Terrasoft.FilterGroup} ########## ###### ########.
			 */
			getLookupQueryFilters: function(columnName) {
				var mainFilterGroup = this.callParent(arguments);
				var product = this.get("Product");
				if (columnName === "Specification" && !this.Ext.isEmpty(product)) {
					var productFilterPath = "[SpecificationInProduct:Specification:Id].Product";
					var subFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
					var productFilter = this.Terrasoft.createColumnInFilterWithParameters(productFilterPath,
						[product.value]);
					subFilterGroup.addItem(productFilter);
					var notExistsFilter = this.Terrasoft.createNotExistsFilter("Id", subFilterGroup);
					mainFilterGroup.addItem(notExistsFilter);
				}
				return mainFilterGroup;
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
