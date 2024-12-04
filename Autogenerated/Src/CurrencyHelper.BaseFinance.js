define("CurrencyHelper", [], function() {
	/**
	 * ######### ######## ###### ######
	 * @param {string} attributeName ### ####
	 * @param {object} scope ######## ########
	 * @returns {*}
	 */
	function setCurrencyCaption(attributeName, scope) {
		var caption = scope.get("Resources.Strings." + attributeName + "Caption");
		var currency = scope.get(attributeName);
		var markerValue = scope.Ext.String.format("{0} {1}", attributeName, caption);
		scope.set("Selected" + attributeName + "Name", markerValue);
		if (currency) {
			var suffix = currency.Symbol || currency.ShortName;
			if (suffix === undefined) {
				this.loadPrimaryCurrency(currency, attributeName, scope);
			}
			if (suffix) {
				caption = scope.Ext.String.format("{0}, {1}", caption, suffix);
			}
		}
		scope.set(attributeName + "ButtonCaption", caption);
	}

	/**
	 * ######### ########## # ######, # ###### #########
	 * @param {object} currency
	 * @param {string} attributeName
	 * @param {object} scope
	 */
	function loadPrimaryCurrency(currency, attributeName, scope) {
		var moduleContext = this;
		var esq = Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "Currency"});
		esq.addColumn("Id");
		esq.addColumn("Symbol");
		esq.addColumn("ShortName");
		esq.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, "Id",
			currency.value));
		esq.getEntityCollection(function(result) {
			if (result.success) {
				currency.Symbol = result.collection.getItems()[0].get("Symbol");
				currency.ShortName = result.collection.getItems()[0].get("ShortName");
				moduleContext.setCurrencyCaption(attributeName, this);
				scope.set(attributeName, currency);
			}
		}, scope);
	}

	return {
		loadPrimaryCurrency: loadPrimaryCurrency,
		setCurrencyCaption: setCurrencyCaption
	};
});
