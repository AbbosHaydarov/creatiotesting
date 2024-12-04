define("LeadSectionV2", [],
	function() {
		return {
			entitySchemaName: "Lead",
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/,
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getSectionActions
				 * @overridden
				 */
				getSectionActions: function() {
					var actionMenuItems = this.callParent(arguments);
					var menuItemsForRemove = actionMenuItems.filter(function(item) {
						if (item.get("Tag") === "ShowOnMap") {
							return item;
						}
					});
					this.Terrasoft.each(menuItemsForRemove.getItems(), function(item) {
						actionMenuItems.remove(item);
					}, this);
					return actionMenuItems;
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilities#getGridDataColumns
				 * @overridden
				 */
				getGridDataColumns: function() {
					var gridDataColumns = this.callParent(arguments);
					var gridDataColumnsFinance = {
						QualifiedContact: {path: "QualifiedContact"},
						QualifiedAccount: {path: "QualifiedAccount"},
						Surname: {path: "Surname"},
						MobilePhone: {path: "MobilePhone"},
						Account: {path: "Account"}
					};
					Ext.merge(gridDataColumns, gridDataColumnsFinance);
					return gridDataColumns;
				}
			}
		};
	}
);
