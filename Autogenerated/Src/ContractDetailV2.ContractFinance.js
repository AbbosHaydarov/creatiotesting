define("ContractDetailV2", [], function() {
	return {
		entitySchemaName: "Contract",
		methods: {
			/**
			 * ######### ########## ########## ### ###### #######,
			 * ####### ########## ####### # ####### #########.
			 * @protected
			 * @override
			 * @return {Object} ###### ###########
			 */
			getLookupFilters: function() {
				var config = this.callParent(arguments);
				if (config && config.filters) {
					config.filters.addItem((this.Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Type.IsSlave", true)));
				}
				return config;
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
