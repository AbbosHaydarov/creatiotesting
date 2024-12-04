define("BaseAddressFieldRowViewModel", ["BaseFieldRowViewModel"], function() {
	/**
	 * @class Terrasoft.configuration.BaseAddressFieldRowViewModel
	 */
	Ext.define("Terrasoft.configuration.BaseAddressFieldRowViewModel", {
		extend: "Terrasoft.BaseFieldRowViewModel",
		alternateClassName: "Terrasoft.BaseAddressFieldRowViewModel",

		//region Methods: Protected

		/**
		 * Sets entity schema query filters for Region.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 */
		setESQRegionFilters: function(filters) {
			var country = this.get("Country");
			if (this.Ext.isObject(country)) {
				var countryFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
					"Country", country.value);
				filters.add("CountryFilter", countryFilter);
			}
		},

		/**
		 * Sets entity schema query filters for City.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 */
		setESQCityFilters: function(filters) {
			var country = this.get("Country");
			var region = this.get("Region");
			if (this.Ext.isObject(country)) {
				var countryFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"Country", country.value);
				filters.add("CountryFilter", countryFilter);
			}
			if (this.Ext.isObject(region)) {
				var regionFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"Region", region.value);
				filters.add("RegionFilter", regionFilter);
			}
		},

		/**
		 * Sets Entity schema query filters.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 * @param {String} columnName The name of column.
		 */
		setAddressESQFilters: function(filters, columnName) {
			switch (columnName) {
				case "Region":
					this.setESQRegionFilters(filters);
					break;
				case "City":
					this.setESQCityFilters(filters);
					break;
			}
		},

		/**
		 * Handles Country field change.
		 * @protected
		 */
		onCountryChange: function() {
			this.set("Region", null);
			this.set("City", null);
		},

		/**
		 * Handles Region field change.
		 * @protected
		 * @param {Terrasoft.BaseFieldRowViewModel} modelItem Row view model.
		 * @param {Object} value Current column value.
		 */
		onRegionChange: function(modelItem, value) {
			this.set("City", null);
			var country = value && value.Country;
			if (!this.Ext.isEmpty(country)) {
				this.set("Country", country);
			}
		},

		/**
		 * Handles City field change.
		 * @protected
		 * @param {Terrasoft.BaseFieldRowViewModel} modelItem Row view model.
		 * @param {Object} value Current column value.
		 */
		onCityChange: function(modelItem, value) {
			value = value || {};
			var country = value.Country;
			var region = value.Region;
			if (!this.Ext.isEmpty(country)) {
				this.set("Country", country);
			}
			if (!this.Ext.isEmpty(region)) {
				this.set("Region", region);
			}
		},

		/**
		 * Initialize lookup columns.
		 * @protected
		 */
		initLookupColumns: function() {
			var cityColumn = this.getColumnByName("City");
			cityColumn.lookupListConfig = {
				columns: ["Country", "Region"]
			};
			var regionColumn = this.getColumnByName("Region");
			regionColumn.lookupListConfig = {
				columns: ["Country"]
			};
		},

		/**
		 * Initialize subscribe for model attributes events.
		 * @protected
		 */
		subscribeForColumnEvents: function() {
			this.subscribeOnColumnChange("Country", this.onCountryChange);
			this.subscribeOnColumnChange("Region", this.onRegionChange);
			this.subscribeOnColumnChange("City", this.onCityChange);
		},

		/**
		 * Unsubscribe handlers from event model attributes.
		 * @protected
		 */
		unsubscribeForColumnEvents: function() {
			this.unsubscribeOnColumnChange("Country", this.onCountryChange);
			this.unsubscribeOnColumnChange("Region", this.onRegionChange);
			this.unsubscribeOnColumnChange("City", this.onCityChange);
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			this.subscribeForColumnEvents();
			this.initLookupColumns();
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#destroy
		 * @overridden
		 */
		destroy: function() {
			this.unsubscribeForColumnEvents();
			this.callParent(arguments);
		},

		/**
		 * @inheritdoc Terrasoft.LookupQuickAddMixin#getLookupQueryFilters
		 * @overridden
		 */
		getLookupQueryFilters: function(columnName) {
			var filters = this.callParent(arguments);
			this.setAddressESQFilters(filters, columnName);
			return filters;
		},

		/**
		 * Adds columns to entity schema query for LookupPage.
		 * @protected
		 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
		 * @param {String} columnName Column name.
		 */
		setLookupQueryColumns: function(esq, columnName) {
			switch (columnName) {
				case "Region":
					esq.addColumn("Country");
					break;
				case "City":
					esq.addColumn("Region");
					esq.addColumn("Country");
					break;
			}
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
		 * @overridden
		 */
		getLookupQuery: function(filterValue, columnName) {
			var esq = this.callParent(arguments);
			this.setLookupQueryColumns(esq, columnName);
			this.setAddressESQFilters(esq.filters, columnName);
			return esq;
		}

		//endregion

	});

	return Terrasoft.BaseAddressFieldRowViewModel;
});
