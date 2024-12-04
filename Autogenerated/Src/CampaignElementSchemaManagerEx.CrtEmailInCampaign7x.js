  require(["CampaignElementSchemaManager", 
			"ProcessEmailConditionalTransitionSchema",
			"MarketingEmailSchema",
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.unshift(
		{ itemType: "Terrasoft.ProcessEmailConditionalTransitionSchema" },
		{ itemType: "Terrasoft.MarketingEmailSchema" }
	);
});