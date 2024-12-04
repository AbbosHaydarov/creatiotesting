﻿define("OAuthAuthorizationEditPage", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(sdk)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "MainContainer",
				"values": {
					"gap": {
						"columnGap": "large",
						"rowGap": "small"
					},
					"alignItems": "stretch"
				}
			},
			{
				"operation": "merge",
				"name": "CancelButton",
				"values": {
					"color": "default",
					"size": "large",
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"visible": "$HasUnsavedData"
				}
			},
			{
				"operation": "insert",
				"name": "Name_Input",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.OAuthClientAppDS_Name_s6hc1ry",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_Name_s6hc1ry"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_ClientIdCopy",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
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
					"alignItems": "center",
					"justifyContent": "start",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "FlexContainer_ClientId",
				"values": {
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
					"stretch": true,
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "FlexContainer_ClientIdCopy",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ClientId_Input",
				"values": {
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.OAuthClientAppDS_ClientId_bloa9r5",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_ClientId_bloa9r5",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "FlexContainer_ClientId",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Button_CopyClientId",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_CopyClientId_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "copy-icon",
					"clicked": {
						"request": "crt.CopyClipboardRequest",
						"params": {
							"value": "$OAuthClientAppDS_ClientId_bloa9r5"
						}
					}
				},
				"parentName": "FlexContainer_ClientIdCopy",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "FlexContainer_ClientSecretCopy",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
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
					"alignItems": "center",
					"justifyContent": "start",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "FlexContainer_ClientSecret",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"color": "transparent",
					"visible": true,
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"stretch": true,
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "FlexContainer_ClientSecretCopy",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ClientSecret_Input",
				"values": {
					"type": "crt.Input",
					"multiline": false,
					"label": "#ResourceString(ClientSecret_Input_label)#",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_ClientSecretText_Control",
					"readonly": true,
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "FlexContainer_ClientSecret",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Button_CopySecret",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_CopySecretCaption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "copy-icon",
					"clicked": {
						"request": "crt.CopyClipboardRequest",
						"params": {
							"value": "$OAuthClientAppDS_ClientSecretText_Control"
						}
					}
				},
				"parentName": "FlexContainer_ClientSecretCopy",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "FlexContainer_userWithLink",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"color": "transparent",
					"visible": true,
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"alignItems": "center",
					"justifyContent": "start",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "FlexContainer_User",
				"values": {
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
					"stretch": true,
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "none",
					"wrap": "wrap"
				},
				"parentName": "FlexContainer_userWithLink",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SystemUser_ComboBox",
				"values": {
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.OAuthClientAppDS_SystemUser",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_SystemUser",
					"listActions": [],
					"showValueAsLink": false,
					"controlActions": [],
					"visible": true,
					"readonly": false,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "FlexContainer_User",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Button_OpenUser",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_OpenUser_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "open-button-icon",
					"clicked": {
						"request": "crt.OpenUserCardRequest",
						"params": {
							"systemUserId": "$OAuthClientAppDS_SystemUser.value",
							"openInNewWindow": true
						}
					},
					"clickMode": "default"
				},
				"parentName": "FlexContainer_userWithLink",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Active_Checkbox",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Checkbox",
					"label": "$Resources.Strings.OAuthClientAppDS_IsActive_vw1njh1",
					"labelPosition": "right",
					"control": "$OAuthClientAppDS_IsActive_vw1njh1",
					"visible": true,
					"readonly": false,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "ApplicationUrl_WebInput",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 6,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.WebInput",
					"label": "$Resources.Strings.OAuthClientAppDS_ApplicationUrl_73n2fz9",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_ApplicationUrl_73n2fz9"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "Description_Input",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 7,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": true,
					"label": "$Resources.Strings.OAuthClientAppDS_Description_7ji0tjg",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_Description_7ji0tjg",
					"visible": true,
					"readonly": false,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 6
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"OAuthClientAppDS_Name_s6hc1ry": {
						"modelConfig": {
							"path": "OAuthClientAppDS.Name"
						}
					},
					"OAuthClientAppDS_ApplicationUrl_73n2fz9": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ApplicationUrl"
						}
					},
					"OAuthClientAppDS_ClientId_bloa9r5": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientId"
						}
					},
					"OAuthClientAppDS_SystemUser": {
						"modelConfig": {
							"path": "OAuthClientAppDS.SystemUser"
						}
					},
					"OAuthClientAppDS_Description_7ji0tjg": {
						"modelConfig": {
							"path": "OAuthClientAppDS.Description"
						}
					},
					"OAuthClientAppDS_IsActive_vw1njh1": {
						"modelConfig": {
							"path": "OAuthClientAppDS.IsActive"
						}
					},
					"OAuthClientAppDS_ClientSecretText": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientSecret"
						}
					},
					"OAuthClientAppDS_ClientSecretText_Control": {
						"modelConfig": {}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"dataSources": {
						"OAuthClientAppDS": {
							"type": "crt.EntityDataSource",
							"scope": "page",
							"config": {
								"entitySchemaName": "OAuthClientApp"
							}
						}
					},
					"primaryDataSourceName": "OAuthClientAppDS"
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[
          {
			request: "crt.HandleViewModelInitRequest",
			handler: async (request, next) => {
                await next?.handle(request);
                const handlerChain = sdk.HandlerChainService.instance;
                return await handlerChain.process({
							type: 'crt.OpenOAuthClientPageRequest', 
							$context: request.$context
						});
			}
		},
        {
				request: "crt.LoadDataRequest",
				handler: async (request, next) => {
					var systemUserSourceName = "OAuthClientAppDS_SystemUser_List_DS";
					if(request.dataSourceName !== systemUserSourceName) {
						return await next?.handle(request);
					}
					const filter = new sdk.FilterGroup();
                    filter.logicalOperation = sdk.LogicalOperatorType.Or;
  					await filter.addSchemaColumnFilterWithParameter(sdk.ComparisonType.Equal, "SysAdminUnitTypeValue", 7);
                    await filter.addSchemaColumnFilterWithParameter(sdk.ComparisonType.Equal, "SysAdminUnitTypeValue", 4);
					const newFilter = Object.assign({}, filter);
					newFilter.items = filter.items;
					request.parameters.push({
						type: "filter",
						value: newFilter
					});       
					return await next?.handle(request);
				}
			},
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});