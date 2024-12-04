define("AppFormMainContactRowViewModel", ["AppFormMainContactRowViewModelResources",
	"BaseFieldRowViewModel"], function() {
	/**
	 * @class Terrasoft.configuration.AppFormMainContactRowViewModel
	 */
	Ext.define("Terrasoft.configuration.AppFormMainContactRowViewModel", {
		extend: "Terrasoft.BaseFieldRowViewModel",
		alternateClassName: "Terrasoft.AppFormMainContactRowViewModel",

		//region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.LookupQuickAddMixin#getLookupQueryFilters
		 * @overridden
		 */
		getLookupQueryFilters: function(columnName) {
			var filters = this.callParent(arguments);
			this.setMainContactESQFilters(filters, columnName);
			return filters;
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
		 * @overridden
		 */
		getLookupQuery: function(filterValue, columnName) {
			var esq = this.callParent(arguments);
			this.setMainContactESQFilters(esq.filters, columnName);
			return esq;
		},

		/**
		 * Sets entity schema query filters for RelationType.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 */
		setRelationTypeFilter: function(filters) {
			filters.add("ForContactContactFilter", this.Terrasoft.createColumnFilterWithParameter(
				this.Terrasoft.ComparisonType.EQUAL,
				"ForContactContact", true));
		},

		/**
		 * Sets entity schema query filters for CommunicationType.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 */
		setCommunicationTypeFilter: function(filters) {
			filters.add("UseForContactsFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"UseforContacts", true));
		},

		/**
		 * Sets Entity schema query filters.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 * @param {String} columnName The name of column.
		 */
		setMainContactESQFilters: function(filters, columnName) {
			switch (columnName) {
				case "RelationType":
					this.setRelationTypeFilter(filters);
					break;
				case "CommunicationType1":
				case "CommunicationType2":
				case "CommunicationType3":
					this.setCommunicationTypeFilter(filters);
					break;
			}
		}

		//endregion

	});

	return Terrasoft.AppFormMainContactRowViewModel;
});
