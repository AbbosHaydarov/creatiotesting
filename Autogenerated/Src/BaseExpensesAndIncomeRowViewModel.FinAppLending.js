define("BaseExpensesAndIncomeRowViewModel", ["BaseFieldRowViewModel"],
	function() {
	/**
	 * @class Terrasoft.configuration.BaseExpensesAndIncomeRowViewModel
	 */
	Ext.define("Terrasoft.configuration.BaseExpensesAndIncomeRowViewModel", {
		extend: "Terrasoft.BaseFieldRowViewModel",
		alternateClassName: "Terrasoft.BaseExpensesAndIncomeRowViewModel",

		//region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
		 * @overridden
		 */
		getLookupQuery: function(filterValue, columnName) {
			var esq = this.callParent(arguments);
			this.setLookupQueryColumns(esq, columnName);
			this.setIncomeOrExpenseTypeESQFilters(esq.filters, columnName);
			return esq;
		},

		/**
		 * Adds columns to entity schema query for LookupPage.
		 * @protected
		 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
		 * @param {String} columnName Column name.
		 */
		setLookupQueryColumns: function(esq, columnName) {
			if (columnName === "Source") {
				esq.addColumn("Name");
				esq.addColumn("Type");
			}
		},

		/**
		 * Sets Entity schema query filters.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 * @param {String} columnName The name of column.
		 */
		setIncomeOrExpenseTypeESQFilters: function(filters, columnName) {
			if (columnName === "Source") {
				this.setESQIncomeOrExpenseTypeFilter(filters);
			}
		},

		/**
		 * Sets entity schema query filters for income or expense type.
		 * @protected
		 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
		 */
		setESQIncomeOrExpenseTypeFilter: function(filters) {
			var incomeOrExpenseType = this.getIncomeOrExpenseType();
			if (this.Ext.isObject(incomeOrExpenseType)) {
				var incomeOrExpenseTypeFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
					"Type", incomeOrExpenseType.value);
				filters.add("IncomeOrExpenseTypeFilter", incomeOrExpenseTypeFilter);
			}
		},

		/**
		 * Returns filtration object config. Like this:
		 *{
		 *	value: FinApplicationConstants.IncomeOrExpenseType.Income
		 *}
		 * @virtual
		 * @return {Object}
		 */
		getIncomeOrExpenseType: this.Terrasoft.emptyFn

		//endregion

	});

	return Terrasoft.BaseExpensesAndIncomeRowViewModel;
});
