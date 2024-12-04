define("AppFormExpensesDetail", ["FinApplicationConstants",
	"ExpensesDetailRowViewModel"], function(FinApplicationConstants) {
	return {
		diff: /**SCHEMA_DIFF*/[
		], /**SCHEMA_DIFF*/
		methods: {

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
			 * @overridden
			 */
			getRowViewModelClassName: function() {
				return "Terrasoft.ExpensesDetailRowViewModel";
			},

			/**
			 * @inheritdoc Terrasoft.BaseFieldsDetail#addTypeColumnFilter
			 * @overridden
			 */
			addTypeColumnFilter: function(filters) {
				var expensesFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"Source.Type",
					FinApplicationConstants.IncomeOrExpenseType.Expense
				);
				filters.addItem(expensesFilter);
			},

			/**
			 * @inheritdoc Terrasoft.AppFormIncomeAndExpenseBaseDetail#addIncomeOrExpensesTypeFilter
			 * @overridden
			 */
			addIncomeOrExpensesTypeFilter: function(filters) {
				var expenseFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"Type",
					FinApplicationConstants.IncomeOrExpenseType.Expense
				);
				filters.addItem(expenseFilter);
			}

			//endregion

		}
	};
});
