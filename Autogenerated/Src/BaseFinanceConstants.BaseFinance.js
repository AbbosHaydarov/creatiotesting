define("BaseFinanceConstants", [], function() {
	var periodType = {
		Day: "2ad34068-a46e-4c73-8c0d-bd8509e7865b",
		Week: "8b0aeafc-2e4a-4a73-a724-ec7904061e91",
		Month: "b5658987-ec37-4354-a5ab-6dbf4caad95b",
		Quarter: "60713eea-4aee-4703-851e-341afd578574",
		HalfYear: "00f0b1c8-e1eb-4e42-932e-9e343d369aed",
		Year: "ca1e64b5-fb81-413e-8e33-abe2457d5f46",
		Custom: "c3503c27-f0dd-444a-8543-764bce654183"
	};
	var accountType = {
		Bank: "e1167a19-0aa8-4081-9ccf-f3c9ad151eca",
		OurBank: "57412fad-53e6-df11-971b-001d60e938c6"
	};
	var bankAccountStatus = {
		Opened: "970a7566-4e5d-4585-9513-bf512c72938c",
		Closed: "0c3e28cb-0f3c-4ac8-b0ce-44d3df525d4a",
		Blocked: "17abcebc-48df-4b95-b6f1-e9ddaa36420f"
	};
	var productStatus = {
		IsActual: "78955f70-7819-48ec-b96b-fc00c4dc7d30",
		IsNotActual: "f57e3a00-93e3-446c-8ce8-98fd3d45f66d",
		InDevelop: "76013cb0-53bb-43dd-88af-1db13dbb1411"
	};
	var contractType = {
		Contract: "42b49a15-1d6c-4fa3-b24a-45711ba90cb3",
		SubAgreement: "009c6fa7-2e35-4a94-afd5-03ad8c3eff38"
	};
	var contractState = {
		AwaitingSignature: "8d54a3df-fcd7-4d89-b182-593bd84b8821",
		Canceled: "bb08517b-c579-4831-975a-e9e870ccdceb",
		Preparation: "8f7197fb-af9c-4674-9c7d-3d7d32aa3d2e",
		Signed: "1f703f42-f7e8-4e3f-9b54-2b85f62ea507"
	};
	var contactFieldConverter = {
		FirstNameMiddleNameLastName: "ec4ddb4c-1707-454c-8bdd-a66b45ca154e",
		LastNameFirstNameMiddleName: "d3d7bfce-8e7c-468a-8c64-c2865fc55ad6"
	};
	return {
		PeriodType: periodType,
		AccountType: accountType,
		BankAccountStatus: bankAccountStatus,
		ProductStatus: productStatus,
		ContractType: contractType,
		ContractState: contractState,
		ContactFieldConverter: contactFieldConverter
	};
});
