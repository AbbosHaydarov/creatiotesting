define("Campaigns_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "LandingPagesExpansionPanel",
				"values": {
					"layoutConfig": {
						"column": 1,
						"colSpan": 1,
						"rowSpan": 1,
						"row": 20
					},
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(ExpansionPanel_cou3zi6_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": true,
					"alignItems": "stretch"
				},
				"parentName": "AssociatedEntitiesGridContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LandingPagesToolsGridContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
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
				"parentName": "LandingPagesExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LandingPagesToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "LandingPagesToolsGridContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LandingPagesRefreshBtn",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LandingPagesRefreshBtn_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "DataGrid_gjgndhgDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "LandingPagesToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LandingPagesSettingsBtn",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LandingPagesSettingsBtn_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "LandingPagesToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LandingPagesExportDataBtn",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(LandingPagesExportDataBtn_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "LandingPagesList",
							"filters": "$DataGrid_gjgndhg | crt.ToCollectionFilters : 'DataGrid_gjgndhg' : $DataGrid_gjgndhg_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "LandingPagesSettingsBtn",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LandingPagesSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(LandingPagesSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"DataGrid_gjgndhg"
					]
				},
				"parentName": "LandingPagesToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "LandingPagesGridContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
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
				"parentName": "LandingPagesExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LandingPagesList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"features": {
						"rows": {
							"selection": false
						},
						"editable": {
							"enable": false,
							"itemsCreation": false
						}
					},
					"items": "$DataGrid_gjgndhg",
					"activeRow": "$DataGrid_gjgndhg_ActiveRow",
					"selectionState": "$DataGrid_gjgndhg_SelectionState",
					"_selectionOptions": {
						"attribute": "DataGrid_gjgndhg_SelectionState"
					},
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "DataGrid_gjgndhgDS_Id",
					"columns": [
						{
							"id": "feee54ac-0ef9-e2ef-20a3-f9e4e8c70080",
							"code": "DataGrid_gjgndhgDS_Landing",
							"path": "Landing",
							"caption": "#ResourceString(DataGrid_gjgndhgDS_Landing)#",
							"dataValueType": 10,
							"referenceSchemaName": "GeneratedWebForm",
							"width": 271
						},
						{
							"id": "35694b7e-a08a-5f5a-788c-4c842692c2a9",
							"code": "DataGrid_gjgndhgDS_CampaignItem",
							"path": "CampaignItem",
							"caption": "#ResourceString(DataGrid_gjgndhgDS_CampaignItem)#",
							"dataValueType": 10,
							"referenceSchemaName": "CampaignItem",
							"width": 219
						},
						{
							"id": "5f3b89d9-f7e8-a25a-31d1-859b18c242fe",
							"code": "DataGrid_gjgndhgDS_Type",
							"path": "Type",
							"caption": "#ResourceString(DataGrid_gjgndhgDS_Type)#",
							"dataValueType": 10,
							"referenceSchemaName": "LandingType"
						},
						{
							"id": "cd35db76-a9f9-2adf-1e9c-9d16a9148c75",
							"code": "DataGrid_gjgndhgDS_State",
							"path": "State",
							"caption": "#ResourceString(DataGrid_gjgndhgDS_State)#",
							"dataValueType": 10,
							"referenceSchemaName": "LendingState"
						}
					],
					"bulkActions": []
				},
				"parentName": "LandingPagesGridContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DataGrid_gjgndhg_AddTagsBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Add tag",
					"icon": "tag-icon",
					"clicked": {
						"request": "crt.AddTagsInRecordsRequest",
						"params": {
							"dataSourceName": "DataGrid_gjgndhgDS",
							"filters": "$DataGrid_gjgndhg | crt.ToCollectionFilters : 'DataGrid_gjgndhg' : $DataGrid_gjgndhg_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_gjgndhg_SelectionState"
						}
					},
					"items": []
				},
				"parentName": "LandingPagesList",
				"propertyName": "bulkActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DataGrid_gjgndhg_RemoveTagsBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Remove tag",
					"icon": "delete-button-icon",
					"clicked": {
						"request": "crt.RemoveTagsInRecordsRequest",
						"params": {
							"dataSourceName": "DataGrid_gjgndhgDS",
							"filters": "$DataGrid_gjgndhg | crt.ToCollectionFilters : 'DataGrid_gjgndhg' : $DataGrid_gjgndhg_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_gjgndhg_SelectionState"
						}
					}
				},
				"parentName": "DataGrid_gjgndhg_AddTagsBulkAction",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DataGrid_gjgndhg_ExportToExcelBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Export to Excel",
					"icon": "export-button-icon",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "DataGrid_gjgndhg",
							"filters": "$DataGrid_gjgndhg | crt.ToCollectionFilters : 'DataGrid_gjgndhg' : $DataGrid_gjgndhg_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_gjgndhg_SelectionState"
						}
					}
				},
				"parentName": "LandingPagesList",
				"propertyName": "bulkActions",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "DataGrid_gjgndhg_DeleteBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Delete",
					"icon": "delete-button-icon",
					"clicked": {
						"request": "crt.DeleteRecordsRequest",
						"params": {
							"dataSourceName": "DataGrid_gjgndhgDS",
							"filters": "$DataGrid_gjgndhg | crt.ToCollectionFilters : 'DataGrid_gjgndhg' : $DataGrid_gjgndhg_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_gjgndhg_SelectionState"
						}
					}
				},
				"parentName": "LandingPagesList",
				"propertyName": "bulkActions",
				"index": 2
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"DataGrid_gjgndhg": {
						"isCollection": true,
						"modelConfig": {
							"path": "DataGrid_gjgndhgDS",
							"filterAttributes": [
								{
									"loadOnChange": true,
									"name": "DataGrid_gjgndhg_PredefinedFilter"
								}
							]
						},
						"viewModelConfig": {
							"attributes": {
								"DataGrid_gjgndhgDS_Landing": {
									"modelConfig": {
										"path": "DataGrid_gjgndhgDS.Landing"
									}
								},
								"DataGrid_gjgndhgDS_CampaignItem": {
									"modelConfig": {
										"path": "DataGrid_gjgndhgDS.CampaignItem"
									}
								},
								"DataGrid_gjgndhgDS_Type": {
									"modelConfig": {
										"path": "DataGrid_gjgndhgDS.Type"
									}
								},
								"DataGrid_gjgndhgDS_State": {
									"modelConfig": {
										"path": "DataGrid_gjgndhgDS.State"
									}
								},
								"DataGrid_gjgndhgDS_Id": {
									"modelConfig": {
										"path": "DataGrid_gjgndhgDS.Id"
									}
								}
							}
						}
					},
					"DataGrid_gjgndhg_PredefinedFilter": {
						"value": null
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"DataGrid_gjgndhgDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "VwLandingInCampaign",
							"attributes": {
								"Landing": {
									"path": "Landing"
								},
								"CampaignItem": {
									"path": "CampaignItem"
								},
								"Type": {
									"path": "Type"
								},
								"State": {
									"path": "State"
								}
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dependencies"
				],
				"values": {
					"DataGrid_gjgndhgDS": [
						{
							"attributePath": "Campaign",
							"relationPath": "PDS.Id"
						}
					]
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
