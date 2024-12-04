define("SpecificationBuilderConstants", [], function() {
	Ext.define("Terrasoft.configuration.SpecificationBuilderConstants", {
		extend: "Terrasoft.BaseObject",
		alternateClassName: "Terrasoft.SpecificationBuilderConstants",

		SpecificationType: {
			Lookup: "ecf578a0-4b4d-40e6-909c-39af2a798d32",
			Float: "beb46531-4f29-452c-be18-1ed5f1aa8b80",
			Integer: "2212241a-71eb-468b-a3d5-c0f39dfe51c9",
			Boolean: "359e0e35-bb39-4f07-9b9f-aec6ad076828",
			Text: "7aad419a-9e7a-4785-8d13-c7ff1402e13d"
		},

		SpecInConditionType: {
			SpecificationCustomerDetail: "467b2e4c-65e0-4b03-ad5a-ef9f52e2b464",
			SpecificationProductDetail: "4a7a7e5f-8577-4de5-85f3-efc0d526d307",
			SpecificationOpportunityDetail: "6de93d0c-a4ba-469f-8bac-9893a86116fb"
		},

		ViewType: {
			TableValue: "table",
			RangeValue: "range",
			SingleValue: "single"
		}
	});

	return Ext.create("Terrasoft.SpecificationBuilderConstants");
});
