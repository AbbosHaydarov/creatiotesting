define("ProductBankConstants", [], function() {
		Ext.define("Terrasoft.configuration.ProductBankConstants", {
			extend: "Terrasoft.BaseObject",
			alternateClassName: "Terrasoft.ProductBankConstants",
			ProductLevels: {
				CATEGORY: 0,
				TYPE: 1
			},
			AccountType: {
				INSURANCE_COMPANY: "2bce36df-a69f-45e2-bbd1-ca466c0f30cd"
			},
			CategoryKind: {
				PRODUCT: "97ec93bc-2a91-4dde-8a8b-34a0d7155de0",
				SERVICE_PACKAGE: "9550d90e-7126-4379-8e10-aba05205f8a9",
				INSURANCE_PRODUCT: "158b5056-88ed-480c-8d1b-ddecb6405908"
			},
			Specification: {
				CURRENCY: "45203c9b-b6e6-4e76-baf8-5807ba534d2b",
				AMOUNT: "e477d926-a5b9-43a5-97ff-62b9adc711d5",
				TERM_YEARS: "bcc6df5c-39c4-45eb-9530-6bad9a424b42",
				TERM_MONTH: "9695d5d9-74e7-4681-b735-17cbf9d92902"
			},
			ParticipantRole: {
				BORROWER: "2fd04eee-2932-4851-9f3b-5d66989c1e4a",
				COBORROWER: "f7da71f9-afb4-41ec-a925-0b581d389f0e",
				CONTACT_PERSON: "94dcafc0-690b-4517-87d7-b92109c04178",
				CUSTOMER: "875932f3-cc33-4a20-9c2e-8226c7fe8c8a",
				DEBTOR: "30ab2b31-e93e-4d01-8b12-852f67809893",
				SPOUSE: "5a304e2e-928b-40cc-8b5c-a0850b0e9aba",
				WARRANTER: "c692ca00-5470-4825-bff4-f5b7912d6ee2"
			},
			AddressType: {
				REGISTRATION: "24422a09-9b5c-413a-9a4f-8586ce9b56dd",
				PLACES_OF_RESIDENCE: "4f8b2d67-71d0-45fb-897e-cd4a308a97c0",
				BUSINESS: "fb7a3f6a-f36b-1410-6f81-1c6f65e50343"
			},
			AppFormObligationType: {
				CREDIT: "6b69d985-37a8-4a66-a7d0-9d6aef51d1bc",
				LOAN_GUARANTEE: "9532cf69-fcb1-4116-8135-258a3a61ea8c"
			}
		});
		return Ext.create("Terrasoft.ProductBankConstants");
	});

