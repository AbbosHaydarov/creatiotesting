define("BankCustomerJourneyConstants", [], function() {
	Ext.define("Terrasoft.configuration.BankCustomerJourneyConstants", {
		extend: "Terrasoft.BaseObject",
		alternateClassName: "Terrasoft.BankCustomerJourneyConstants",
		BankCardType: {
			DEBIT: "e0baa286-9159-4626-8ad3-66ad3726e314",
			CREDIT: "a9d8b41a-8954-460c-b0fa-896496313d7e"
		}
	});
	return Ext.create("Terrasoft.BankCustomerJourneyConstants");
	}
);
