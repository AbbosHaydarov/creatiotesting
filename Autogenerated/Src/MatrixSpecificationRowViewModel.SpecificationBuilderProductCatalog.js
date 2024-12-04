define("MatrixSpecificationRowViewModel", ["ProductConditionSpecificationRowViewModel"],
	function() {
	/**
	 * @class Terrasoft.MatrixSpecificationRowViewModel
	 */
	Ext.define("Terrasoft.configuration.MatrixSpecificationRowViewModel", {
		alternateClassName: "Terrasoft.MatrixSpecificationRowViewModel",
		extend: "Terrasoft.ProductConditionSpecificationRowViewModel",

		Ext: null,
		Terrasoft: null,
		sandbox: null,

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#useInternalTools
		 * @overridden
		 */
		useInternalTools: false,

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#getSpecificationViewConfig
		 * @overridden
		 */
		getSpecificationViewConfig: Terrasoft.emptyFn,

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#getRowViewConfig
		 * @overridden
		 */
		getRowViewConfig: function() {
			var config = {
				"className": "Terrasoft.SpecificationRow",
				"specificationConfig": {
					"className": "Terrasoft.Container",
					"items": []
				},
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
		}

	});

	return Terrasoft.MatrixSpecificationRowViewModel;
});
