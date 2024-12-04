define("ConsultationThemeBlockSectionV2", ["ConfigurationEnums", "LocalizableHelper", "ServiceHelper",
	"ConsultationThemeBlockSectionV2Resources", "GridUtilitiesV2", "css!ConsultationThemeBlockCSS"],
function(ConfigurationEnums, LocalizableHelper, ServiceHelper) {
	return {
		entitySchemaName: "ConsultationThemeBlock",
		messages: {
			/**
			 * @message ChangeHeaderCaption
			 * Message for change page caption.
			 */
			"ChangeHeaderCaption": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "FiltersContainer"
			},
			{
				"operation": "insert",
				"name": "SeparateModeCloseButton",
				"parentName": "SeparateModeActionButtonsLeftContainer",
				"propertyName": "items",
				"index": 2,
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {"bindTo": "Resources.Strings.CloseButtonCaption"},
					"click": {"bindTo": "closeSection"},
					"classes": {
						"textClass": ["actions-button-margin-right"],
						"wrapperClass": ["actions-button-margin-right"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowMoveUpAction",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"imageConfig": LocalizableHelper.localizableImages.Up,
					"tag": "up",
					"markerValue": "ButtonUp"
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowMoveDownAction",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"imageConfig": LocalizableHelper.localizableImages.Down,
					"tag": "down",
					"markerValue": "ButtonDown"
				}
			},
			{
				"operation": "merge",
				"name": "DataGridActiveRowOpenAction",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"style": Terrasoft.controls.ButtonEnums.style.GREY
				}
			},
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"activeRowAction": {"bindTo": "onActiveRowAction"},
					"type": "listed",
					"listedConfig": {
						"name": "DataGridListedConfig",
						"items": [
							{
								"name": "NameListedGridColumn",
								"bindTo": "Name",
								"type": Terrasoft.GridCellType.TEXT,
								"position": {
									"column": 1,
									"colSpan": 24
								}
							}
						]
					},
					"tiledConfig": {
						"name": "DataGridTiledConfig",
						"grid": {
							"columns": 24,
							"rows": 1
						},
						"items": [
							{
								"name": "NameTiledGridColumn",
								"bindTo": "Name",
								"type": Terrasoft.GridCellType.TEXT,
								"position": {
									"row": 1,
									"column": 1,
									"colSpan": 24
								},
								"captionConfig": {
									"visible": false
								}
							}
						]
					}
				}
			},
			{
				"operation": "remove",
				"name": "DataGridActiveRowCopyAction"
			}
		]/**SCHEMA_DIFF*/,
		attributes: {
			/**
			 * Is action "Add to folder" visible.
			 * @overridden
			 */
			"IsIncludeInFolderButtonVisible": {"value": false},

			/**
			 * Is action "Summary settings" visible.
			 * @overridden
			 */
			"IsSummarySettingsVisible": {"value": false},

			/**
			 * Is tag module available for use.
			 * @overridden
			 */
			"UseTagModule": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			}
		},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#addSectionDesignerViewOptions
			 * @overridden
			 */
			addSectionDesignerViewOptions: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.GridUtilitiesV2#getAddRowsOptions
			 * @overridden
			 */
			getAddRowsOptions: function() {
				return {mode: "bottom"};
			},

			/**
			 * @inheritdoc BaseSectionV2#getViewOptions
			 * @overridden
			 */
			getViewOptions: function() {
				var viewOptions = this.callParent(arguments);
				var sortColumnsIndex;
				viewOptions.each(function(item, index) {
					if (item.values.Items && item.values.Items.bindTo === "SortColumns") {
						sortColumnsIndex = index;
					}
				});
				if (!Ext.isEmpty(sortColumnsIndex)) {
					viewOptions.removeByIndex(sortColumnsIndex);
				}
				return viewOptions;
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#addProfileColumns
			 * @overridden
			 */
			addProfileColumns: function(entitySchemaQuery) {
				this.callParent(arguments);
				if (!entitySchemaQuery.columns.contains("Position")) {
					entitySchemaQuery.addColumn("Position");
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#getDefaultDataViews
			 * @overridden
			 */
			getDefaultDataViews: function() {
				var dataViews = this.callParent(arguments);
				delete dataViews.AnalyticsDataView;
				return dataViews;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#isMultiSelectVisible
			 * @overridden
			 */
			isMultiSelectVisible: function() {
				return false;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#isSingleSelectVisible
			 * @overridden
			 */
			isSingleSelectVisible: function() {
				return false;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#isUnSelectVisible
			 * @overridden
			 */
			isUnSelectVisible: function() {
				return false;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#getModuleCaption
			 * @overridden
			 */
			getModuleCaption: function() {
				return this.get("Resources.Strings.HeaderCaption");
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#closeCard
			 * @overridden
			 */
			closeCard: function() {
				this.callParent(arguments);
				var dataViews = this.Ext.create("Terrasoft.Collection");
				var caption = this.getModuleCaption();
				this.sandbox.publish("ChangeHeaderCaption", {
					caption: caption,
					dataViews: dataViews,
					moduleName: this.name
				});
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilitiesV2#getGridDataColumns
			 * @overridden
			 */
			getGridDataColumns: function() {
				var gridDataColumns = this.callParent(arguments);
				if (gridDataColumns && !gridDataColumns.Position) {
					gridDataColumns.Position = {
						path: "Position",
						orderPosition: 0,
						orderDirection: Terrasoft.OrderDirection.ASC
					};
				}
				return gridDataColumns;
			},

			/**
			 * Execute an action based on the parameter actionName.
			 * @private
			 * @param {string} actionName - name of the action executed.
			 * @param {Guid} recordId - identifier of the selected row.
			 */
			onActiveRowAction: function(actionName, recordId) {
				if (this.Terrasoft.contains(["delete", "edit"], actionName)) {
					this.callParent(arguments);
				} else {
					var gridData = this.getGridData();
					var activeRow = gridData.get(recordId);
					var oldPosition = activeRow.get("Position");
					var newPosition = oldPosition;
					switch (actionName) {
						case "up":
							if (oldPosition > 0) {
								newPosition--;
							}
							break;
						case "down":
							if (oldPosition < gridData.getCount() - 1) {
								newPosition++;
							}
							break;
					}
					if (newPosition !== oldPosition) {
						this.setPosition(recordId, newPosition, function() {
							gridData.clear();
							this.loadGridData();
						}, this);
					}
				}
			},

			/**
			 * Sets the values of the sort column position.
			 * @private
			 * @param {string} recordId - identifier of the selected row.
			 * @param {int} position - new position of selected row.
			 * @param {function} callback - callback function.
			 * @param {Object} scope - execution context callback.
			 */
			setPosition: function(recordId, position, callback, scope) {
				var data = {
					tableName: this.entitySchemaName,
					primaryColumnValue: recordId,
					position: position,
					grouppingColumnNames: ""
				};
				ServiceHelper.callService("RightsService", "SetCustomRecordPosition", callback, data, scope);
			},

			/**
			 * Back to lookup section.
			 * @protected
			 * @virtual
			 */
			closeSection: function() {
				this.sandbox.publish("PushHistoryState", {
					hash: this.Terrasoft.combinePath("SectionModuleV2", "LookupSection")
				});
			}
		}
	};
});
