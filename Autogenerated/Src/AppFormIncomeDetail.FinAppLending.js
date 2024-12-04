define("AppFormIncomeDetail", ["FinApplicationConstants",
	"IncomeDetailRowViewModel"], function(FinApplicationConstants) {
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
				return "Terrasoft.IncomeDetailRowViewModel";
			},

			/**
			 * @inheritdoc Terrasoft.BaseFieldsDetail#addTypeColumnFilter
			 * @overridden
			 */
			addTypeColumnFilter: function(filters) {
				var incomeFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"Source.Type",
					FinApplicationConstants.IncomeOrExpenseType.Income
				);
				filters.addItem(incomeFilter);
			},

			/**
			 * @inheritdoc Terrasoft.AppFormIncomeAndExpenseBaseDetail#initMoneyFlowTypesFilters
			 * @overridden
			 */
			addIncomeOrExpensesTypeFilter: function(filters) {
				var incomeFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"Type",
					FinApplicationConstants.IncomeOrExpenseType.Income
				);
				filters.addItem(incomeFilter);
			}

			//endregion

		}
	};
});
