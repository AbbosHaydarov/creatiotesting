define("CategoryOrTypeModalBoxModule", ["BaseSchemaModuleV2"], function() {
	Ext.define("Terrasoft.configuration.CategoryOrTypeModalBoxModule", {
		extend: "Terrasoft.BaseSchemaModule",
		alternateClassName: "Terrasoft.CategoryOrTypeModalBoxModule",

		/**
		 * @inheritdoc Terrasoft.BaseSchemaModule#generateViewContainerId
		 * @overridden
		 */
		generateViewContainerId: false,

		/**
		 * @inheritdoc Terrasoft.BaseSchemaModule#initSchemaName
		 * @overridden
		 */
		initSchemaName: function() {
			this.schemaName = this.sandbox.publish("GetSchemaName", null, [this.sandbox.id]);
		},

		/**
		 * @inheritdoc Terrasoft.BaseSchemaModule#initHistoryState
		 * @overridden
		 */
		initHistoryState: this.Terrasoft.emptyFn
	});
	return this.Terrasoft.CategoryOrTypeModalBoxModule;
});
