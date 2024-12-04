 require(["CampaignElementSchemaManager",
		  	"ProcessLandingConditionalTransitionSchema",
			"CampaignLandingSchema",
		  	"CampaignStartLandingSchema",
		  	"CampaignStartFacebookFormSchema",
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.ProcessLandingConditionalTransitionSchema" },
		{ itemType: "Terrasoft.CampaignStartLandingSchema" },
		{ itemType: "Terrasoft.CampaignLandingSchema" },
		{ itemType: "Terrasoft.CampaignStartFacebookFormSchema" }
	);
});