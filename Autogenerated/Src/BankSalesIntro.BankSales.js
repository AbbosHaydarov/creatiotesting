define("BankSalesIntro", ["BankSalesIntroResources", "css!BankSalesIntroCss"],
	function(resources) {
		return {
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "remove",
				"name": "ESNFeedSectionV2"
			}, {
				"operation": "move",
				"name": "ActivitySectionV2",
				"parentName": "BasicTile",
				"propertyName": "items",
				"index": 4
			}, {
				"operation": "move",
				"name": "KnowledgeBaseSectionV2",
				"parentName": "BasicTile",
				"propertyName": "items",
				"index": 5
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BasicTile",
				"name": "LeadSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {
						"bindTo": "Resources.Strings.LeadSectionCaption"
					},
					"tag": "SectionModuleV2/LeadSectionV2/",
					"click": {
						"bindTo": "onNavigateTo"
					}
				},
				"index": 0
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BasicTile",
				"name": "ESNFeedSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {
						"bindTo": "Resources.Strings.FeedSectionCaption"
					},
					"tag": "SectionModuleV2/ESNFeedSectionV2/",
					"click": {
						"bindTo": "onNavigateTo"
					}
				},
				"index": 6
			}, {
				"operation": "insert",
				"name": "BankSalesTile",
				"propertyName": "items",
				"parentName": "LeftContainer",
				"index": 1,
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"generator": "MainMenuTileGenerator.generateMainMenuTile",
					"caption": {
						"bindTo": "Resources.Strings.SalesCaption"
					},
					"cls": "bank-sales-tile",
					"icon": resources.localizableImages.SalesIcon,
					"items": []
				}
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BankSalesTile",
				"name": "OpportunitySectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {
						"bindTo": "Resources.Strings.OpportunitySectionCaption"
					},
					"tag": "SectionModuleV2/OpportunitySectionV2/",
					"click": {
						"bindTo": "onNavigateTo"
					},
					"index": 0
				}
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BankSalesTile",
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
				},
				"index": 1
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BankSalesTile",
				"name": "DocumentSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {
						"bindTo": "Resources.Strings.DocumentSectionCaption"
					},
					"tag": "SectionModuleV2/DocumentSectionV2/",
					"click": {
						"bindTo": "onNavigateTo"
					}
				},
				"index": 2
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BankSalesTile",
				"name": "ProductSectionV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {
						"bindTo": "Resources.Strings.ProductSectionCaption"
					},
					"tag": "SectionModuleV2/ProductSectionV2/",
					"click": {
						"bindTo": "onNavigateTo"
					}
				},
				"index": 4
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BankSalesTile",
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
				},
				"index": 5
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "BankSalesTile",
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
				},
				"index": 6
			}, {
				"operation": "remove",
				"name": "DashboardsModule"
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "AnalyticsTile",
				"name": "FinIndicatorSection",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {
						"bindTo": "Resources.Strings.FinIndicatorSectionCaption"
					},
					"tag": "SectionModuleV2/FinIndicatorSection/",
					"click": {
						"bindTo": "onNavigateTo"
					},
					"index": 1
				}
			}, {
				"operation": "insert",
				"propertyName": "items",
				"parentName": "AnalyticsTile",
				"name": "DashboardsModule",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {
						"bindTo": "Resources.Strings.DashboardsSectionCaption"
					},
					"tag": "DashboardsModule/",
					"click": {
						"bindTo": "onNavigateTo"
					}
				}
			}] /**SCHEMA_DIFF*/
		};
	});
