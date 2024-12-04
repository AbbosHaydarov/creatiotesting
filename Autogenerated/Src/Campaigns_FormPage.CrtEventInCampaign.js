define("Campaigns_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "EventsExpansionPanel",
				"values": {
					"layoutConfig": {
						"column": 1,
						"colSpan": 1,
						"rowSpan": 1,
						"row": 40
					},
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(EventsExpansionPanel_title)#",
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
				"name": "EventsToolsGridContainer",
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
				"parentName": "EventsExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EventsToolsFlexContainer",
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
				"parentName": "EventsToolsGridContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EventsRefreshBtn",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(EventsRefreshBtn_caption)#",
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
							"dataSourceName": "RelatedEventsDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "EventsToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EventsSettingsBtn",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_27kxpt1_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "EventsToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "EventsExportDataBtn",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(MenuItem_vlwcktm_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "EventsList",
							"filters": "$RelatedEvents | crt.ToCollectionFilters : 'RelatedEvents' : $RelatedEvents_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "EventsSettingsBtn",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EventsSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(SearchFilter_nf59qe5_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"RelatedEvents"
					]
				},
				"parentName": "EventsToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "EventsGridContainer",
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
				"parentName": "EventsExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EventsList",
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
					"items": "$RelatedEvents",
					"activeRow": "$RelatedEvents_ActiveRow",
					"selectionState": "$RelatedEvents_SelectionState",
					"_selectionOptions": {
						"attribute": "RelatedEvents_SelectionState"
					},
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "RelatedEventsDS_Id",
					"columns": [
						{
							"id": "3dd3a6f5-97c2-4d3d-d569-1df365bc3b49",
							"code": "RelatedEventsDS_Event",
							"path": "Event",
							"caption": "#ResourceString(RelatedEventsDS_Event)#",
							"dataValueType": 10,
							"referenceSchemaName": "Event",
							"width": 271
						},
						{
							"id": "758e3b01-efce-ec5b-b1ff-d7fa1b4603c4",
							"code": "RelatedEventsDS_CampaignItem",
							"path": "CampaignItem",
							"caption": "#ResourceString(RelatedEventsDS_CampaignItem)#",
							"dataValueType": 10,
							"referenceSchemaName": "CampaignItem",
							"width": 219
						},
						{
							"id": "00dea26b-a183-6354-3a1d-1fff6e7c38aa",
							"code": "RelatedEventsDS_Type",
							"path": "Type",
							"caption": "#ResourceString(RelatedEventsDS_Type)#",
							"dataValueType": 10,
							"referenceSchemaName": "EventType"
						}
					],
					"bulkActions": []
				},
				"parentName": "EventsGridContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedEvents_AddTagsBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Add tag",
					"icon": "tag-icon",
					"clicked": {
						"request": "crt.AddTagsInRecordsRequest",
						"params": {
							"dataSourceName": "RelatedEventsDS",
							"filters": "$RelatedEvents | crt.ToCollectionFilters : 'RelatedEvents' : $RelatedEvents_SelectionState | crt.SkipIfSelectionEmpty : $RelatedEvents_SelectionState"
						}
					},
					"items": []
				},
				"parentName": "EventsList",
				"propertyName": "bulkActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedEvents_RemoveTagsBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Remove tag",
					"icon": "delete-button-icon",
					"clicked": {
						"request": "crt.RemoveTagsInRecordsRequest",
						"params": {
							"dataSourceName": "RelatedEventsDS",
							"filters": "$RelatedEvents | crt.ToCollectionFilters : 'RelatedEvents' : $RelatedEvents_SelectionState | crt.SkipIfSelectionEmpty : $RelatedEvents_SelectionState"
						}
					}
				},
				"parentName": "RelatedEvents_AddTagsBulkAction",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedEvents_ExportToExcelBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Export to Excel",
					"icon": "export-button-icon",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "RelatedEvents",
							"filters": "$RelatedEvents | crt.ToCollectionFilters : 'RelatedEvents' : $RelatedEvents_SelectionState | crt.SkipIfSelectionEmpty : $RelatedEvents_SelectionState"
						}
					}
				},
				"parentName": "EventsList",
				"propertyName": "bulkActions",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RelatedEvents_DeleteBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Delete",
					"icon": "delete-button-icon",
					"clicked": {
						"request": "crt.DeleteRecordsRequest",
						"params": {
							"dataSourceName": "RelatedEventsDS",
							"filters": "$RelatedEvents | crt.ToCollectionFilters : 'RelatedEvents' : $RelatedEvents_SelectionState | crt.SkipIfSelectionEmpty : $RelatedEvents_SelectionState"
						}
					}
				},
				"parentName": "EventsList",
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
					"RelatedEvents": {
						"isCollection": true,
						"modelConfig": {
							"path": "RelatedEventsDS",
							"filterAttributes": [
								{
									"loadOnChange": true,
									"name": "RelatedEvents_PredefinedFilter"
								}
							]
						},
						"viewModelConfig": {
							"attributes": {
								"RelatedEventsDS_Event": {
									"modelConfig": {
										"path": "RelatedEventsDS.Event"
									}
								},
								"RelatedEventsDS_CampaignItem": {
									"modelConfig": {
										"path": "RelatedEventsDS.CampaignItem"
									}
								},
								"RelatedEventsDS_Type": {
									"modelConfig": {
										"path": "RelatedEventsDS.Type"
									}
								},
								"RelatedEventsDS_Id": {
									"modelConfig": {
										"path": "RelatedEventsDS.Id"
									}
								}
							}
						}
					},
					"RelatedEvents_PredefinedFilter": {
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
					"RelatedEventsDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "VwEventInCampaign",
							"attributes": {
								"Event": {
									"path": "Event"
								},
								"CampaignItem": {
									"path": "CampaignItem"
								},
								"Type": {
									"path": "Type"
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
					"RelatedEventsDS": [
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
