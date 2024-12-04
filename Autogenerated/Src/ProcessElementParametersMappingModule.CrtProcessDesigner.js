define("ProcessElementParametersMappingModule", ["BaseProcessParametersEditModule"], function() {

	Ext.define("Terrasoft.configuration.ProcessElementParametersMappingModule", {
		alternateClassName: "Terrasoft.ProcessElementParametersMappingModule",
		extend: "Terrasoft.BaseProcessParametersEditModule",

		/**
		 * @inheritdoc Terrasoft.BaseSchemaModule#initSchemaName
		 * @overridden
		 */
		initSchemaName: function() {
			this.schemaName = this.initialConfig.parameters.viewModelConfig.MappingType ===
				Terrasoft.MappingEnums.MappingType.COMPOSITE_OBJECT_CONFIGURATION
					? "CompositeObjectConfigurationPage"
					: "ProcessElementParametersMappingPage";
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessParametersEditModule#initParametersInfo
		 * @overridden
		 */
		initParametersInfo: function() {
			this.parametersInfo = {};
		}
	});
	return Terrasoft.ProcessElementParametersMappingModule;
});
