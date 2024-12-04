define("FinApplicationConstants", [], function() {
	/**
	* @class Terrasoft.configuration.FinApplicationConstants
	* FinApplication class provides configuration constants specific to fin application operations.
	*/
	Ext.define("Terrasoft.configuration.FinApplicationConstants", {
		extend: "Terrasoft.BaseObject",
		alternateClassName: "Terrasoft.FinApplicationConstants",

		SpecificationType: {
			LookupType: "ecf578a0-4b4d-40e6-909c-39af2a798d32",
			FloatType: "beb46531-4f29-452c-be18-1ed5f1aa8b80",
			BooleanType: "359e0e35-bb39-4f07-9b9f-aec6ad076828",
			StringType: "7aad419a-9e7a-4785-8d13-c7ff1402e13d",
			IntegerType: "2212241a-71eb-468b-a3d5-c0f39dfe51c9"
		},

		IncomeOrExpenseType: {
			Income: "f0d6e5fb-465c-41c3-a296-f5bff652bc62",
			Expense: "9bf0e2e9-18db-47b7-9606-005ffabd4b91"
		}
	});

	return Ext.create("Terrasoft.FinApplicationConstants");
});
