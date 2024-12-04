define("BankSalesIntroPage", ["BankSalesIntroPageResources"], function() {
	return {
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "FinApplicationSection"
			},
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "AnalyticsTile",
				"name": "FinIndicatorSection",
				"index": 0,
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.FinIndicatorSectionCaption"},
					"tag": "SectionModuleV2/FinIndicatorSection/",
					"click": {"bindTo": "onNavigateTo"}
				}
			},
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "SalesTile",
				"name": "OpportunitySectionV2",
				"index": 2,
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.OpportunitySectionCaption"},
					"tag": "SectionModuleV2/OpportunitySectionV2/",
					"click": {"bindTo": "onNavigateTo"}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

