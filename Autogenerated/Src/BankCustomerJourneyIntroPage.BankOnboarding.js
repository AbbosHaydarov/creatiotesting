define("BankCustomerJourneyIntroPage", ["BankCustomerJourneyIntroPageResources"], function(resources) {
	return {
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "remove",
			"name": "BasicTile"
		}, {
			"operation": "insert",
			"name": "AcquisitionTile",
			"propertyName": "items",
			"parentName": "LeftContainer",
			"index": 0,
			"values": {
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"generator": "MainMenuTileGenerator.generateMainMenuTile",
				"caption": {
					"bindTo": "Resources.Strings.AcquisitionCaption"
				},
				"cls": "basis",
				"icon": resources.localizableImages.AcquisitionIcon,
				"items": []
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "AcquisitionTile",
			"name": "ContactSectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.ContactSectionCaption"
				},
				"tag": "SectionModuleV2/ContactSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "AcquisitionTile",
			"name": "AccountSectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.AccountSectionCaption"
				},
				"tag": "SectionModuleV2/AccountSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "AcquisitionTile",
			"name": "ActivitySectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.ActivitySectionCaption"
				},
				"tag": "SectionModuleV2/ActivitySectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "AcquisitionTile",
			"name": "EmployeeSection",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.EmployeeSectionCaption"
				},
				"tag": "SectionModuleV2/EmployeeSection/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "AcquisitionTile",
			"name": "KnowledgeBaseSectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.KnowlegebaseSectionCaption"
				},
				"tag": "SectionModuleV2/KnowledgeBaseSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "AcquisitionTile",
			"name": "ESNFeedSectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.ESNFeedSectionCaption"
				},
				"tag": "SectionModuleV2/ESNFeedSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"name": "SalesTile",
			"propertyName": "items",
			"parentName": "LeftContainer",
			"index": 1,
			"values": {
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"generator": "MainMenuTileGenerator.generateMainMenuTile",
				"caption": {
					"bindTo": "Resources.Strings.SalesCaption"
				},
				"cls": "basis",
				"icon": resources.localizableImages.SalesIcon,
				"items": []
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "SalesTile",
			"name": "OperatorSingleWindowModule",
			"index": 0,
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.OperatorSingleWindowModuleCaption"
				},
				"tag": "OperatorSingleWindowModule/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "SalesTile",
			"name": "ProductSectionV2",
			"index": 1,
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.ProductSectionCaption"
				},
				"tag": "SectionModuleV2/ProductSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "SalesTile",
			"name": "FinApplicationSection",
			"index": 2,
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.FinApplicationSectionCaption"
				},
				"tag": "SectionModuleV2/FinApplicationSection/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"name": "ServiceTile",
			"propertyName": "items",
			"parentName": "LeftContainer",
			"index": 2,
			"values": {
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"generator": "MainMenuTileGenerator.generateMainMenuTile",
				"caption": {
					"bindTo": "Resources.Strings.ServiceCaption"
				},
				"cls": "basis",
				"icon": resources.localizableImages.ServiceIcon,
				"items": []
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "ServiceTile",
			"name": "BankAccountSectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.BankAccountSectionCaption"
				},
				"tag": "SectionModuleV2/BankAccountSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "ServiceTile",
			"name": "BankCardSectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.BankCardSectionCaption"
				},
				"tag": "SectionModuleV2/BankCardSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "ServiceTile",
			"name": "CaseSection",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.CaseSectionCaption"
				},
				"tag": "SectionModuleV2/CaseSection/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "insert",
			"propertyName": "items",
			"parentName": "ServiceTile",
			"name": "ContractSectionV2",
			"values": {
				"itemType": Terrasoft.ViewItemType.LINK,
				"caption": {
					"bindTo": "Resources.Strings.ContractSectionCaption"
				},
				"tag": "SectionModuleV2/ContractSectionV2/",
				"click": {
					"bindTo": "onNavigateTo"
				}
			}
		}, {
			"operation": "merge",
			"name": "AnalyticsTile",
			"index": 3,
			"values": {}
		}, {
			"operation": "merge",
			"name": "SettingsTile",
			"index": 4,
			"values": {}
		}] /**SCHEMA_DIFF*/
	};
});
