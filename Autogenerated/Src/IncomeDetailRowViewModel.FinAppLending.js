define("IncomeDetailRowViewModel", ["FinApplicationConstants", "BaseExpensesAndIncomeRowViewModel"],
	function(FinApplicationConstants) {
	/**
	 * @class Terrasoft.configuration.IncomeDetailRowViewModel
	 */
	Ext.define("Terrasoft.configuration.IncomeDetailRowViewModel", {
		extend: "Terrasoft.BaseExpensesAndIncomeRowViewModel",
		alternateClassName: "Terrasoft.IncomeDetailRowViewModel",

		//region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.BaseExpensesAndIncomeRowViewModel#getIncomeOrExpenseType
		 * @overridden
		 */
		getIncomeOrExpenseType: function() {
			return {
				"value": FinApplicationConstants.IncomeOrExpenseType.Income
			};
		}

		//endregion

	});

	return Terrasoft.IncomeDetailRowViewModel;
});
