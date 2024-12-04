define("ConsultationThemeBlockPage", ["css!ConsultationThemeBlockCSS"],
	function() {
		return {
			entitySchemaName: "ConsultationThemeBlock",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "ConsultationThemeBlockHeader",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24,
							"rowSpan": 4
						},
						"wrapClass": ["consultation-theme-block-container"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "ConsultationThemeDetailContainer",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["consultation-theme-detail-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "ConsultationThemePageContainer",
					"parentName": "ConsultationThemeBlockHeader",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 11,
							"rowSpan": 1
						}
					},
					"parentName": "ConsultationThemePageContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Description",
					"values": {
						"contentType": Terrasoft.ContentType.LONG_TEXT,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 11,
							"rowSpan": 1
						}
					},
					"parentName": "ConsultationThemePageContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "UseInOBSW",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 11,
							"rowSpan": 1
						},
						"classes": {"wrapClass": ["useInOBSW-option"],
					"labelClass": ["useInOBSW-label"]}
					},
					"parentName": "ConsultationThemePageContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "CaptionColorButtonLabel",
					"parentName": "ConsultationThemePageContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.CaptionColorLabel"
						},
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 3,
							"rowSpan": 1
						},
						"classes": {
							"labelClass": ["colorButtonLabel"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "CaptionColorButton",
					"parentName": "ConsultationThemePageContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 15,
							"row": 0,
							"colSpan": 3,
							"rowSpan": 1
						},
						"itemType": Terrasoft.ViewItemType.COLOR_BUTTON,
						"value": {"bindTo": "CaptionColor"}
					}
				},
				{
					"operation": "insert",
					"name": "ItemColorButtonLabel",
					"parentName": "ConsultationThemePageContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.ItemColorLabel"
						},
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 3,
							"rowSpan": 1
						},
						"classes": {
							"labelClass": ["colorButtonLabel"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "ItemColorButton",
					"parentName": "ConsultationThemePageContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 15,
							"row": 1,
							"colSpan": 3,
							"rowSpan": 1
						},
						"itemType": Terrasoft.ViewItemType.COLOR_BUTTON,
						"value": {"bindTo": "ItemColor"}
					}
				},
				{
					"operation": "insert",
					"parentName": "ConsultationThemeDetailContainer",
					"propertyName": "items",
					"name": "ConsultationThemeDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "remove",
					"name": "ViewOptionsButton"
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"DefaultCaptionColor": {
					"dataValueType": Terrasoft.DataValueType.STRING,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": "#64b8df"
				},
				"DefaultItemColor": {
					"dataValueType": Terrasoft.DataValueType.STRING,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": "#d4ebf6"
				}
			},
			details: /**SCHEMA_DETAILS*/{
				ConsultationThemeDetailV2: {
					schemaName: "ConsultationThemeDetailV2",
					entitySchemaName: "ConsultationTheme",
					filter: {
						masterColumn: "Id",
						detailColumn: "Block"
					},
					"defaultValues": {
						Block: {
							"masterColumn": "Id"
						}
					}
				}
			}/**SCHEMA_DETAILS*/,
			methods: {
				/**
				 * @inheritdoc Terrasoft.BasePageV2#initHeaderCaption
				 * @overridden
				 */
				initHeaderCaption: function() {
					this.sandbox.publish("InitDataViews", {caption: this.entitySchema.caption});
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getActions
				 * @overridden
				 */
				getActions: function() {
					var actionMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					return actionMenuItems;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					if (!this.get("CaptionColor")) {
						this.set("CaptionColor", this.get("DefaultCaptionColor"));
					}
					if (!this.get("ItemColor")) {
						this.set("ItemColor", this.get("DefaultItemColor"));
					}
				}
			}
		};
	}
);
