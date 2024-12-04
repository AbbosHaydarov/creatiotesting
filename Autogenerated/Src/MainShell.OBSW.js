define("MainShell", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(sdk)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "OBSWTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(OBSWTab_caption)#",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "right-panel-consultation"
				},
				"parentName": "CommunicationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "OBSWTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "OBSWTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OBSWLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(OBSWTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "OBSWTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OBSWTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"id": "OBSWModule_WrapContainer",
					"direction": "column"
				},
				"parentName": "OBSWTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OBSWModule",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "OBSWModule"
				},
				"parentName": "OBSWTabItems",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[
			{
				request: 'crt.HandleViewModelInitRequest',
				handler: async (request, next) => {
					const handlerChainService = new sdk.HandlerChainService();
					await handlerChainService.process({
						type: 'crt.RightPanelSetupConsultationInfoRequest',
						$context: request.$context,
						scopes: ['MainShell']
					});
					return next?.handle(request);
				}
			}]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/,
	};
});