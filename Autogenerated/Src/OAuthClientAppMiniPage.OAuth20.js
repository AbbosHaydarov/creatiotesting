define("OAuthClientAppMiniPage", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(sdk)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "ContinueInOtherPageButton"
			},
			{
				"operation": "remove",
				"name": "MainContainer"
			},
			{
				"operation": "merge",
				"name": "FooterContainer",
				"values": {
					"alignItems": "center",
					"color": "transparent",
					"borderRadius": "none",
					"gap": "small"
				}
			},
			{
				"operation": "move",
				"name": "CancelButton",
				"parentName": "BaseButtonsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "merge",
				"name": "CancelButton",
				"values": {
					"color": "default",
					"size": "large",
					"iconPosition": "only-text",
					"layoutConfig": {}
				}
			},
			{
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"clicked": {
						"request": "crt.AddOAuthIntegrationRequest",
						"params": {
							"integrationName": "$OAuthClientAppName",
							"createTechnicalUser": "$IsNewIntegrationUserRequired"
						}
					},
					"disabled": "$SaveButtonDisabled",
					"layoutConfig": {}
				}
			},
			{
				"operation": "move",
				"name": "SaveButton",
				"parentName": "BaseButtonsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridContainer_x9637j7",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"items": [],
					"fitContent": true,
					"visible": false,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"alignItems": "stretch"
				},
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "MainFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "FirstStepFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column",
					"layoutConfig": {},
					"visible": "$IsAppRegistrationStagePassed | crt.InvertBooleanValue",
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "small",
						"right": "none",
						"bottom": "medium",
						"left": "none"
					},
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "MainFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Input_ApplicationName",
				"values": {
					"type": "crt.Input",
					"multiline": false,
					"label": "#ResourceString(Input_ApplicationName_label)#",
					"labelPosition": "above",
					"control": "$OAuthClientAppName",
					"visible": true,
					"readonly": false,
					"placeholder": "#ResourceString(Input_ApplicationName_placeholder)#",
					"tooltip": "#ResourceString(Input_ApplicationName_tooltip)#"
				},
				"parentName": "FirstStepFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ApplicatinUrlInput",
				"values": {
					"type": "crt.WebInput",
					"multiline": false,
					"label": "$Resources.Strings.OAuthClientAppDS_ApplicationUrl_020cu01",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_ApplicationUrl_020cu01",
					"visible": true,
					"readonly": false,
					"placeholder": "#ResourceString(ApplicatinUrlInput_placeholder)#",
					"tooltip": "#ResourceString(ApplicatinUrlInput_tooltip)#"
				},
				"parentName": "FirstStepFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ApplicationDescriptionInput",
				"values": {
					"type": "crt.Input",
					"multiline": true,
					"label": "$Resources.Strings.OAuthClientAppDS_Description_qo5ljt9",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_Description_qo5ljt9",
					"visible": true,
					"readonly": false,
					"placeholder": "#ResourceString(Input_eoyxijl_placeholder)#",
					"tooltip": ""
				},
				"parentName": "FirstStepFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "CreateNewSystemUserCheckbox",
				"values": {
					"type": "crt.Checkbox",
					"value": true,
					"disabled": "$ChangeCreateNewSystemUserCheckboxDisabled",
					"inversed": false,
					"label": "#ResourceString(CreateNewSystemUserCheckbox_label)#",
					"ariaLabel": "#ResourceString(Checkbox_yhlylce_ariaLabel)#",
					"labelPosition": "right",
					"tooltip": "#ResourceString(CreateNewSystemUserCheckbox_tooltip)#",
					"visible": "$ChangeCreateNewSystemUserCheckboxDisabled | crt.InvertBooleanValue",
					"readonly": false,
					"placeholder": "",
					"control": "$IsNewIntegrationUserRequired"
				},
				"parentName": "FirstStepFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "ExistingUserFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": "$IsNewIntegrationUserRequired | crt.InvertBooleanValue",
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
				"parentName": "FirstStepFlexContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "ComboBox_User",
				"values": {
					"type": "crt.ComboBox",
					"label": "#ResourceString(ComboBox_User_label)#",
					"labelPosition": "above",
					"control": "$OAuthClientAppSystemUser",
					"listActions": [],
					"showValueAsLink": false,
					"controlActions": [],
					"visible": "$ChangeCreateNewSystemUserCheckboxDisabled | crt.InvertBooleanValue",
					"readonly": "$ChangeCreateNewSystemUserCheckboxDisabled",
					"placeholder": "#ResourceString(ComboBox_User_placeholder)#",
					"tooltip": "#ResourceString(ComboBox_User_tooltip)#",
					"layoutConfig": {},
					"mode": "List"
				},
				"parentName": "ExistingUserFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_jd5pn2d",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"items": [],
					"fitContent": true,
					"padding": {
						"top": "medium",
						"right": "large",
						"bottom": "medium",
						"left": "large"
					},
					"color": "primary",
					"borderRadius": "medium",
					"visible": "$ChangeCreateNewSystemUserCheckboxDisabled | crt.InvertBooleanValue",
					"alignItems": "stretch",
					"styles": {
						"border-color": "#FFE7CC"
					}
				},
				"parentName": "ExistingUserFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "TabDescriptionTitleContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"alignItems": "center",
					"gap": "none"
				},
				"parentName": "GridContainer_jd5pn2d",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TabDescriptionTitleIconContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "4px",
						"bottom": "none",
						"left": "none"
					},
					"alignItems": "stretch",
					"justifyContent": "center",
					"gap": "none",
					"wrap": "wrap"
				},
				"parentName": "TabDescriptionTitleContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TabDescriptionTitleIcon",
				"values": {
					"type": "crt.ImageInput",
					"label": "#ResourceString(ImageLabel)#",
					"value": "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxNiIgaGVpZ2h0PSIxNiIgdmlld0JveD0iMCAwIDE2IDE2IiBmaWxsPSJub25lIj4KICA8cGF0aCBkPSJNNy4xNjE4MyA1LjM5NTkxQzcuMTYxODMgNC45MzQ3NiA3LjUzNTY3IDQuNTYwOTEgNy45OTY4MyA0LjU2MDkxSDguMDAzNDlDOC40NjQ2NSA0LjU2MDkxIDguODM4NSA0LjkzNDc2IDguODM4NSA1LjM5NTkxQzguODM4NSA1Ljg1NzA3IDguNDY0NjUgNi4yMzA5MSA4LjAwMzQ5IDYuMjMwOTFINy45OTY4M0M3LjUzNTY3IDYuMjMwOTEgNy4xNjE4MyA1Ljg1NzA3IDcuMTYxODMgNS4zOTU5MVoiIGZpbGw9IiNGRjg4MDAiLz4KICA8cGF0aCBkPSJNNy45OTk5NSA2Ljk1MzU3QzguNDYxMTEgNi45NTM5NyA4LjgzNDYzIDcuMzI4MTQgOC44MzQyMyA3Ljc4OTNMOC44MzE3OSAxMC42MDU1QzguODMxMzkgMTEuMDY2NiA4LjQ1NzIyIDExLjQ0MDIgNy45OTYwNyAxMS40Mzk4QzcuNTM0OTEgMTEuNDM5NCA3LjE2MTM5IDExLjA2NTIgNy4xNjE3OSAxMC42MDRMNy4xNjQyMyA3Ljc4Nzg1QzcuMTY0NjMgNy4zMjY2OSA3LjUzODggNi45NTMxNyA3Ljk5OTk1IDYuOTUzNTdaIiBmaWxsPSIjRkY4ODAwIi8+CiAgPHBhdGggZmlsbC1ydWxlPSJldmVub2RkIiBjbGlwLXJ1bGU9ImV2ZW5vZGQiIGQ9Ik04LjAwMDE2IDEuNUMxMS41ODk2IDEuNSAxNC40OTkzIDQuNDA5NzggMTQuNDk5MyA3Ljk5OTE4QzE0LjQ5OTMgMTEuNTg4NiAxMS41ODk2IDE0LjQ5ODQgOC4wMDAxNiAxNC40OTg0QzQuNDEwNzYgMTQuNDk4NCAxLjUwMDk4IDExLjU4ODYgMS41MDA5OCA3Ljk5OTE4QzEuNTAwOTggNC40MDk3OCA0LjQxMDc2IDEuNSA4LjAwMDE2IDEuNVpNMTMuMTU5MyA3Ljk5OTE4QzEzLjE1OTMgNS4xNDk4NCAxMC44NDk1IDIuODQgOC4wMDAxNiAyLjg0QzUuMTUwODIgMi44NCAyLjg0MDk4IDUuMTQ5ODQgMi44NDA5OCA3Ljk5OTE4QzIuODQwOTggMTAuODQ4NSA1LjE1MDgyIDEzLjE1ODQgOC4wMDAxNiAxMy4xNTg0QzEwLjg0OTUgMTMuMTU4NCAxMy4xNTkzIDEwLjg0ODUgMTMuMTU5MyA3Ljk5OTE4WiIgZmlsbD0iI0ZGODgwMCIvPgo8L3N2Zz4=",
					"readonly": true,
					"placeholder": "",
					"labelPosition": "auto",
					"customWidth": "100%",
					"customHeight": "100%",
					"borderRadius": "none",
					"positioning": "cover",
					"visible": true,
					"tooltip": ""
				},
				"parentName": "TabDescriptionTitleIconContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Label_3xw1kaw",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_3xw1kaw_caption)#)#",
					"labelType": "headline-4",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#181818",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "TabDescriptionTitleContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Label_jncep89",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_jncep89_caption)#)#",
					"labelType": "body",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "auto",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "GridContainer_jd5pn2d",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SecondStepFlexContainer",
				"values": {
					"layoutConfig": {},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": "$IsAppRegistrationStagePassed",
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "small",
						"right": "none",
						"bottom": "small",
						"left": "none"
					},
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "MainFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProtectSecurityInfoFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "small",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "SecondStepFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Label_lb8dlmd",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_lb8dlmd_caption)#)#",
					"labelType": "body-large",
					"labelThickness": "semibold",
					"labelEllipsis": false,
					"labelColor": "#181818",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "ProtectSecurityInfoFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ClientCredentialsDiscriptionLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(ClientCredentialsDiscriptionLabel_caption)#)#",
					"labelType": "body",
					"labelThickness": "normal",
					"labelEllipsis": false,
					"labelColor": "#181818",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true,
					"layoutConfig": {}
				},
				"parentName": "ProtectSecurityInfoFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Label_tdan5xh",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_tdan5xh_caption)#)#",
					"labelType": "body",
					"labelThickness": "normal",
					"labelEllipsis": false,
					"labelColor": "#181818",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": "$IsNewIntegrationUserRequired",
					"layoutConfig": {}
				},
				"parentName": "ProtectSecurityInfoFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ClientIdControlsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": false,
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
				"parentName": "SecondStepFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ClientIdInputFlexContainer",
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
				"parentName": "ClientIdControlsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ClientIdInput",
				"values": {
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.OAuthClientAppDS_ClientId_l9pqjq3",
					"labelPosition": "above",
					"control": "$OAuthClientAppDS_ClientId_l9pqjq3",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"tooltip": "",
					"layoutConfig": {}
				},
				"parentName": "ClientIdInputFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CopyClientIdButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_h64e7e0_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"icon": "copy-icon",
					"clicked": {
						"request": "crt.CopyClipboardRequest",
						"params": {
							"value": "$OAuthClientClientId"
						}
					}
				},
				"parentName": "ClientIdControlsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ClientSecretControlsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": false,
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
				"parentName": "SecondStepFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "FlexContainer_bg9gr85",
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
					"alignItems": "stretch",
					"justifyContent": "start",
					"gap": "none",
					"wrap": "nowrap",
					"stretch": true
				},
				"parentName": "ClientSecretControlsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ClientSecretInput",
				"values": {
					"type": "crt.Input",
					"multiline": false,
					"label": "#ResourceString(ClientSecretInput_label)#",
					"labelPosition": "above",
					"control": "$OAuthClientSecretKey",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"tooltip": "",
					"layoutConfig": {}
				},
				"parentName": "FlexContainer_bg9gr85",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CopyClientSecretButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_h64e7e0_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"icon": "copy-icon",
					"clicked": {
						"request": "crt.CopyClipboardRequest",
						"params": {
							"value": "$OAuthClientSecretKey"
						}
					},
					"layoutConfig": {}
				},
				"parentName": "ClientSecretControlsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "FlexContainer_User",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": false,
					"visible": "$ChangeCreateNewSystemUserCheckboxDisabled | crt.InvertBooleanValue",
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
				"parentName": "SecondStepFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "FlexContainer_UserInput",
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
				"parentName": "FlexContainer_User",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ComboBox_SelectedUser",
				"values": {
					"type": "crt.ComboBox",
					"label": "#ResourceString(ComboBox_SelectedUser_label)#",
					"labelPosition": "above",
					"control": "$OAuthClientAppSystemUser",
					"listActions": [],
					"showValueAsLink": false,
					"controlActions": [],
					"visible": true,
					"readonly": "$IsAppRegistrationStagePassed",
					"placeholder": "#ResourceString(ComboBox_SelectedUser_placeholder)#",
					"tooltip": "",
					"mode": "List"
				},
				"parentName": "FlexContainer_UserInput",
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
					"icon": "open-button-icon",
					"clicked": {
						"request": "crt.OpenUserCardRequest",
						"params": {
							"systemUserId": "$OAuthClientAppSystemUser.value",
							"openInNewWindow": true
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "FlexContainer_User",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ClosePageButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ClosePageButton_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": "$IsAppRegistrationStagePassed",
					"clicked": {
						"request": "crt.ClosePageRequest"
					},
					"clickMode": "default"
				},
				"parentName": "FooterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "BaseButtonsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"visible": "$IsAppRegistrationStagePassed | crt.InvertBooleanValue"
				},
				"parentName": "FooterContainer",
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
					"IsNewIntegrationUserRequired": {
						"value": true,
						"modelConfig": {}
					},
					"SaveButtonDisabled": {
						"value": true
					},
					"ChangeCreateNewSystemUserCheckboxDisabled": {
						"value": false
					},
					"IsAppRegistrationStagePassed": {
						"value": false
					},
					"ActiveToggleTab": {
						"value": {
							"value": "FirstStepTabContainer"
						}
					},
					"OAuthClientAppName": {
						"modelConfig": {
							"path": "OAuthClientAppDS.Name"
						},
						"validators": {
							"required": {
								"type": "crt.Required"
							}
						}
					},
					"OAuthClientAppDS_ApplicationUrl_020cu01": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ApplicationUrl"
						}
					},
					"OAuthClientAppDS_Description_qo5ljt9": {
						"modelConfig": {
							"path": "OAuthClientAppDS.Description"
						}
					},
					"OAuthClientAppSystemUser": {
						"modelConfig": {
							"path": "OAuthClientAppDS.SystemUser"
						},
						"validators": {
							"required": {
								"type": "crt.Required"
							}
						}
					},
					"OAuthClientAppDS_ClientId_or5ljl0": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientId"
						}
					},
					"OAuthClientAppDS_ClientSecret_lppxcuj": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientSecret"
						}
					},
					"OAuthClientClientId": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientId"
						}
					},
					"OAuthClientSecretKey": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientSecret"
						}
					},
					"OAuthClientAppDS_ClientId_qz2rgy5": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientId"
						}
					},
					"OAuthClientAppDS_ClientId_l9pqjq3": {
						"modelConfig": {
							"path": "OAuthClientAppDS.ClientId"
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Id",
					"modelConfig"
				],
				"values": {
					"path": "OAuthClientAppDS.Id"
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
					var systemUserSourceName = "OAuthClientAppSystemUser_List_DS";
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
          {
				request: "crt.HandleViewModelAttributeChangeRequest",
				handler: async (request, next) => {
					if (request.attributeName === 'OAuthClientAppName' || request.attributeName === 'IsNewIntegrationUserRequired'
							|| request.attributeName === 'OAuthClientAppSystemUser') {
						request.$context.SaveButtonDisabled = true;
                        const isNewIntegrationUserRequired = await request.$context.IsNewIntegrationUserRequired;
						if (isNewIntegrationUserRequired === false) {
							await request.$context.enableAttributeValidator('OAuthClientAppSystemUser', 'required');
						} else {
							await request.$context.disableAttributeValidator('OAuthClientAppSystemUser', 'required');
                            request.$context.formApiModel.controls.OAuthClientAppSystemUser.status = 'VALID';
						}
                        if (request.$context.formApiModel.controls.OAuthClientAppName.status === 'VALID' 
                            && (isNewIntegrationUserRequired || request.$context.formApiModel.controls.OAuthClientAppSystemUser.status === 'VALID' )) {
                          request.$context.SaveButtonDisabled = false;
                        }
						
					}
                    if (request.attributeName === 'Id' ) {
                      const filledUser = await request.$context.OAuthClientAppSystemUser;
                      if (filledUser) {
                          request.$context.IsNewIntegrationUserRequired = false;
                          request.$context.ChangeCreateNewSystemUserCheckboxDisabled = true;
                      } else {
                        request.$context.ChangeCreateNewSystemUserCheckboxDisabled = false;
                      }
                    }                    
    				return next?.handle(request);
				}
			},
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});