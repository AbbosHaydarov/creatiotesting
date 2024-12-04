define("ConsultationThemeDetailV2", ["terrasoft", "OBSWConstants", "ConfigurationEnums"],
	function(Terrasoft, OBSWConstants, ConfigurationEnums) {
		return {
			entitySchemaName: "ConsultationTheme",
			/**SCHEMA_DIFF*/
			diff: [
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"type": "listed",
						"listedConfig": {
							"name": "DataGridListedConfig",
							"items": [
								{
									"name": "ConsultationThemeNameListedGridColumn",
									"bindTo": "Name",
									"position": {
										"column": 0,
										"colSpan": 24
									},
									"type": Terrasoft.GridCellType.TITLE
								}
							]
						},
						"tiledConfig": {
							"name": "DataGridTiledConfig",
							"grid": {
								"columns": 24,
								"rows": 3
							},
							"items": [
								{
									"name": "ConsultationThemeNameListedGridColumn",
									"bindTo": "Name",
									"position": {
										"row": 0,
										"column": 0,
										"colSpan": 24
									},
									"type": Terrasoft.GridCellType.TITLE
								},
								{
									"name": "BlockTiledGridColumn",
									"bindTo": "Block",
									"position": {
										"row": 1,
										"column": 0,
										"colSpan": 12
									}
								},
								{
									"name": "ProcessSchemaTiledGridColumn",
									"bindTo": "ProcessSchema",
									"position": {
										"row": 1,
										"column": 12,
										"colSpan": 12
									}
								}
							]
						},
						"hierarchical": true,
						"hierarchicalColumnName": "ParentId"
					}
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"AddButtonMenuItems": {
					"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT,
					"value": {
						"Group": {
							"id": OBSWConstants.ConsultationThemesInBlock.Group,
							"caption": { bindTo: "Resources.Strings.AddGroupCaption" }
						},
						"Theme": {
							"id": OBSWConstants.ConsultationThemesInBlock.Theme,
							"caption": { bindTo: "Resources.Strings.AddThemeCaption" }
						}
					}
				}
			},
			methods: {

				// region Methods: Protected

				/**
				 * @inheritDoc Terrasoft.BaseGridDetail#getQuickFilterButton
				 * @ovveride
				 */
				getShowQuickFilterButton: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#getGridDataColumns
				 * @ovveride
				 */
				getGridDataColumns: function() {
					var gridDataColumns = this.callParent(arguments);
					if (!gridDataColumns.Parent) {
						gridDataColumns.Parent = {
							path: "Parent"
						};
					}
					if (!gridDataColumns.IsFolder) {
						gridDataColumns.IsFolder = {
							path: "IsFolder"
						};
					}
					if (!gridDataColumns.Position) {
						gridDataColumns.Position = {
							path: "Position",
							orderPosition: 0,
							orderDirection: Terrasoft.OrderDirection.ASC
						};
					}
					return gridDataColumns;
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#prepareResponseCollection
				 * @ovveride
				 */
				prepareResponseCollection: function(collection) {
					collection.each(function(item) {
						var parent = item.get("Parent");
						var parentId = parent && parent.value;
						if (parentId) {
							item.set("ParentId", parentId);
						}
						Terrasoft.each(item.columns, function(column) {
							this.addColumnLink(item, column);
							this.applyColumnDefaults(column);
						}, this);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#getEditPages
				 * @ovveride
				 */
				getEditPages: function() {
					var menuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					var entityStructure = this.getEntityStructure(this.entitySchemaName);
					if (entityStructure) {
						var editPage = entityStructure.pages[0];
						var schemaName = editPage.cardSchema;
						var addButtonMenuItems = this.get("AddButtonMenuItems");
						for (var key in addButtonMenuItems) {
							var menuItem = addButtonMenuItems[key];
							var id = menuItem.id;
							var caption = menuItem.caption;
							var item = this.getButtonMenuItem({
								Caption: caption,
								Click: { bindTo: "addRecord" },
								Tag: id,
								SchemaName: schemaName
							});
							menuItems.add(id, item);
						}
					}
					return menuItems;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#initTypeColumnName
				 * @ovveride
				 */
				initTypeColumnName: function() {
					this.set("TypeColumnName", "RecordType");
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @ovveride
				 */
				getCopyRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
				 * @ovveride
				 */
				addDetailWizardMenuItems: Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.Configuration.BaseDetailV2#updateDetail
				 * @ovveride
				 */
				updateDetail: function(config) {
					config.reloadAll = true;
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#editRecord
				 * @ovveride
				 */
				editRecord: function(record) {
					var activeRow = record || this.getActiveRow();
					if (activeRow) {
						var isFolder = activeRow.get("IsFolder");
						var primaryColumnValue = activeRow.get(activeRow.primaryColumnName);
						var typeColumnValue = isFolder ? OBSWConstants.ConsultationThemesInBlock.Group :
							OBSWConstants.ConsultationThemesInBlock.Theme;
						this.openCard(ConfigurationEnums.CardStateV2.EDIT, typeColumnValue, primaryColumnValue);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#copyRecord
				 * @ovveride
				 */
				copyRecord: function(editPageUId) {
					var activeRow = this.getActiveRow();
					if (activeRow) {
						var isFolder = activeRow.get("IsFolder");
						editPageUId = isFolder ? OBSWConstants.ConsultationThemesInBlock.Group :
							OBSWConstants.ConsultationThemesInBlock.Theme;
					}
					this.callParent([editPageUId]);
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#getRowCount
				 * @ovveride
				 */
				getRowCount: function() {
					return 1000;
				}

				// endregion

			}
		};
	}
);
