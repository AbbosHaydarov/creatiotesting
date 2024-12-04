define("ExpensesDetailRowViewModel", ["FinApplicationConstants", "BaseExpensesAndIncomeRowViewModel"],
	function(FinApplicationConstants) {
	/**
	 * @class Terrasoft.configuration.ExpensesDetailRowViewModel
	 */
	Ext.define("Terrasoft.configuration.ExpensesDetailRowViewModel", {
		extend: "Terrasoft.BaseExpensesAndIncomeRowViewModel",
		alternateClassName: "Terrasoft.ExpensesDetailRowViewModel",

		//region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.BaseExpensesAndIncomeRowViewModel#getIncomeOrExpenseType
		 * @overridden
		 */
		getIncomeOrExpenseType: function() {
			return {
				"value": FinApplicationConstants.IncomeOrExpenseType.Expense
			};
		}

		//endregion

	});

	return Terrasoft.ExpensesDetailRowViewModel;
});
