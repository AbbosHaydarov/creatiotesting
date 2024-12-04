Ext.define("Terrasoft.controls.CurrencyButton", {
	extend: "Terrasoft.controls.Button",
	alternateClassName: "Terrasoft.CurrencyButton",
	mainCaption: null,
	click: null,
	/**
	 * ############# ########## ####.
	 * @protected
	 * @override
	 */
	init: function() {
		this.callParent(arguments);
		this.setMenuList();
	},
	/**
	 * ############## ######### ### ########### # ########## ######.
	 */
	setMenuList: function() {
		var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
			rootSchemaName: "Currency"
		});
		esq.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
		var columnName = esq.addMacrosColumn(
			Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
		columnName.orderDirection = Terrasoft.OrderDirection.ASC;
		columnName.orderPosition = 0;
		esq.addColumn("Symbol");
		esq.addColumn("ShortName");
		esq.getEntityCollection(function(result) {
			if (result.success) {
				var collection = result.collection;
				if (collection.getCount() > 0) {
					this.setMenuListFromCollection(collection);
				}
			}
		}, this);
	},
	/**
	 * ######### ######## ## ######### # ###### ####.
	 * @param {Terrasoft.Collection} collection ######## ####### ########.
	 */
	setMenuListFromCollection: function(collection) {
		var clickHandler = this.click;
		collection.each(function(item) {
			this.menu.addItem(Ext.create("Terrasoft.controls.MenuItem", {
					tag: {
						value: item.get("Id"),
						displayValue: item.get("Name"),
						sandbox: this.sandbox,
						Symbol: item.get("Symbol"),
						ShortName: item.get("ShortName")
					},
					caption: item.get("Name"),
					click: {bindTo: clickHandler}
				}
			));
		}, this);
	}
});
