define("LendingIntroPage", ["LendingIntroPageResources", "css!LendingIntroPage"], function(resources) {
	return {
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "LendingTile",
				"propertyName": "items",
				"parentName": "LeftContainer",
				"index": 1,
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"generator": "MainMenuTileGenerator.generateMainMenuTile",
					"caption": {"bindTo": "Resources.Strings.LendingCaption"},
					"cls": "lending-tile",
					"icon": resources.localizableImages.LendingIcon,
					"items": []
				}
			},
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "LendingTile",
				"name": "ProductSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.ProductSectionCaption"},
					"tag": "SectionModuleV2/ProductSectionV2/",
					"click": {"bindTo": "onNavigateTo"}
				}
			},
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "LendingTile",
				"name": "FinApplicationSection",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.FinApplicationSectionCaption"},
					"tag": "SectionModuleV2/FinApplicationSection/",
					"click": {"bindTo": "onNavigateTo"}
				}
			},
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "LendingTile",
				"name": "ContractSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.ContractSectionCaption"},
					"tag": "SectionModuleV2/ContractSectionV2/",
					"click": {"bindTo": "onNavigateTo"}
				}
			},
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "LendingTile",
				"name": "BankAccountSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.BankAccountSectionCaption"},
					"tag": "SectionModuleV2/BankAccountSectionV2/",
					"click": {"bindTo": "onNavigateTo"}
				}
			},
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "LendingTile",
				"name": "BankCardSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.BankCardSectionCaption"},
					"tag": "SectionModuleV2/BankCardSectionV2/",
					"click": {"bindTo": "onNavigateTo"}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
