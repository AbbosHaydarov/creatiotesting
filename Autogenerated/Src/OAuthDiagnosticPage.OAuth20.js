define("OAuthDiagnosticPage", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(sdk)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "PageTitle",
				"values": {
					"caption": "#MacrosTemplateString(#ResourceString(PageTitle_caption)#)#",
					"visible": true
				}
			},
			{
				"operation": "merge",
				"name": "MainContainer",
				"values": {
					"gap": {
						"columnGap": "large",
						"rowGap": "medium"
					},
					"alignItems": "stretch"
				}
			},
			{
				"operation": "merge",
				"name": "CancelButton",
				"values": {
					"caption": "#ResourceString(CancelButton_caption)#",
					"color": "default",
					"size": "large",
					"iconPosition": "only-text",
					"clickMode": "default"
				}
			},
			{
				"operation": "remove",
				"name": "SaveButton"
			},
			{
				"operation": "insert",
				"name": "StatusCheckContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SystemSettingsCheckBox",
				"values": {
					"type": "crt.Checkbox",
					"value": true,
					"disabled": false,
					"inversed": false,
					"label": "#ResourceString(Checkbox_t29glou_label)#",
					"ariaLabel": "#ResourceString(Checkbox_t29glou_ariaLabel)#",
					"labelPosition": "right",
					"tooltip": "",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"control": "$AreSystemSettingsFilledIn"
				},
				"parentName": "StatusCheckContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "IdentityServiceAvailabilityCheckbox",
				"values": {
					"type": "crt.Checkbox",
					"value": true,
					"disabled": false,
					"inversed": false,
					"label": "#ResourceString(Checkbox_r5topkp_label)#",
					"ariaLabel": "#ResourceString(Checkbox_r5topkp_ariaLabel)#",
					"labelPosition": "right",
					"tooltip": "",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"control": "$IsIdentityServiceAvailable"
				},
				"parentName": "StatusCheckContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "AccessTokenIsRetrievableCheckbox",
				"values": {
					"type": "crt.Checkbox",
					"value": true,
					"disabled": false,
					"inversed": false,
					"label": "#ResourceString(Checkbox_56zh3yi_label)#",
					"ariaLabel": "#ResourceString(Checkbox_56zh3yi_ariaLabel)#",
					"labelPosition": "right",
					"tooltip": "",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"control": "$IsTokenRetrivable"
				},
				"parentName": "StatusCheckContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ProblemDescriptionInput",
				"values": {
					"type": "crt.Input",
					"label": "#ResourceString(ProblemDescriptionInput_label)#",
					"control": "$ProblemDescriptionText",
					"placeholder": "",
					"tooltip": "",
					"readonly": false,
					"multiline": true,
					"labelPosition": "above",
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"visible": true
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"AreSystemSettingsFilledIn": {
						"value": true
					},
					"IsIdentityServiceAvailable": {
						"value": true
					},
					"IsTokenRetrivable": {
						"value": true
					},
					"ProblemDescriptionText": {
						"value": "",
						"modelConfig": {}
					},
					"PageParameters_BooleanParameter1_617kb8i": {
						"modelConfig": {
							"path": "PageParameters.SystemSettingsStatusBoolean"
						}
					},
					"PageParameters_BooleanParameter1_6umgvz0": {
						"modelConfig": {
							"path": "PageParameters.BooleanParameter1"
						}
					},
					"PageParameters_BooleanParameter2_pu5xtjm": {
						"modelConfig": {
							"path": "PageParameters.BooleanParameter2"
						}
					},
					"PageParameters_TextParameter1_7a21xvg": {
						"modelConfig": {
							"path": "PageParameters.TextParameter1"
						}
					},
					"PageParameters_RichTextParameter1_fyru4g7": {
						"modelConfig": {
							"path": "PageParameters.RichTextParameter1"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[
			{
				request: "crt.HandleViewModelInitRequest",
				handler: async (request, next) => {
                    const httpClientService = new sdk.HttpClientService();
					const endpoint = "/api/OAuthHealthCheck";
                   
					
					try{
						const response = await httpClientService.get(endpoint);
					}
					catch(result){
						console.error(result);
						request.$context.AreSystemSettingsFilledIn = result.error.IsSystemSettingsFilledIn;
						request.$context.IsIdentityServiceAvailable = result.error.IsIdentityServiceAvailable;
						request.$context.IsTokenRetrivable = result.error.IsAccessTokenRetrievableForSystemActions;
						request.$context.ProblemDescriptionText = result.error.Message;
					}

					return next?.handle(request);
				}
			}
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});