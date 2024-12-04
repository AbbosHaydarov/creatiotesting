define("CaseConsultationThemeDetailV2", [],
	function() {
		return {
			entitySchemaName: "CaseConsultationTheme",
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "merge",
					"name": "AddRecordButton",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "Theme"
					}
				}
			] /**SCHEMA_DIFF*/,
			methods: {
				/**
				 * Add View menu item .
				 * @protected
				 * @param {Object} toolsButtonMenu - detail menu.
				 */
				addViewMenuItem: function(toolsButtonMenu) {
					var menuItem = this.getButtonMenuItem({
						Caption: {"bindTo": "Resources.Strings.ViewMenuCaption"},
						Click: {"bindTo": "editRecord"},
						Enabled: {bindTo: "getEditRecordButtonEnabled"}
					});
					toolsButtonMenu.addItem(menuItem);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addGridOperationsMenuItems
				 * @overridden
				 */
				addGridOperationsMenuItems: function(toolsButtonMenu) {
					var showQuickFilterButton = this.getShowQuickFilterButton();
					if (showQuickFilterButton) {
						toolsButtonMenu.addItem(this.getButtonMenuSeparator());
						toolsButtonMenu.addItem(showQuickFilterButton);
					}
					var hideQuickFilterButton = this.getHideQuickFilterButton();
					if (hideQuickFilterButton) {
						toolsButtonMenu.addItem(this.getButtonMenuSeparator());
						toolsButtonMenu.addItem(hideQuickFilterButton);
					}
					var gridSortMenuItem = this.getGridSortMenuItem();
					if (gridSortMenuItem) {
						toolsButtonMenu.addItem(this.getButtonMenuSeparator());
						toolsButtonMenu.addItem(gridSortMenuItem);
					}
					var gridSettingsMenuItem = this.getGridSettingsMenuItem();
					if (gridSettingsMenuItem) {
						toolsButtonMenu.addItem(this.getButtonMenuSeparator());
						toolsButtonMenu.addItem(gridSettingsMenuItem);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addToolsButtonMenuItems
				 * @overridden
				 */
				addToolsButtonMenuItems: function(toolsButtonMenu) {
					this.addViewMenuItem(toolsButtonMenu);
					this.addGridOperationsMenuItems(toolsButtonMenu);
				}
			}
		};
	}
);
