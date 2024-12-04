define("OBSWModule", ["BaseSchemaModuleV2", "OBSWSchema", "css!BaseSectionV2CSS"],
	function() {
		/**
		 * @class Terrasoft.configuration.OBSWModule
		 * OBSWModule class for creating an instance of the module to operate from a single window.
		 */
		Ext.define("Terrasoft.configuration.OBSWModule", {
			alternateClassName: "Terrasoft.OBSWModule",
			extend: "Terrasoft.BaseSchemaModule",
			Ext: null,
			sandbox: null,
			Terrasoft: null,

			/**
			 * @inheritdoc Terrasoft.BaseSchemaModule#schemaName
			 * @overridden
			 */
			schemaName: "OBSWSchema",

			/**
			 * @inheritdoc Terrasoft.BaseSchemaModule#isSchemaConfigInitialized
			 * @overridden
			 */
			isSchemaConfigInitialized: true,

			/**
			 * @inheritdoc Terrasoft.BaseSchemaModule#useHistoryState
			 * @overridden
			 */
			useHistoryState: false
		});
		return Terrasoft.OBSWModule;
	});
