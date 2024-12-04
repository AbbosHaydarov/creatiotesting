define("ProductSelectionModuleV3", ["BaseSchemaModuleV2", "ProductSelectionSchemaV3"], function() {
	Ext.define("Terrasoft.ProductSelectionModuleV3", {
		extend: "Terrasoft.configuration.BaseSchemaModule",

		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#initSchemaName
		 * @override
		 */
		initSchemaName: function() {
			this.schemaName = "ProductSelectionSchemaV3";
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#initHistoryState
		 * @override
		 */
		initHistoryState: Ext.emptyFn

	});

	return Terrasoft.ProductSelectionModuleV3;
});
