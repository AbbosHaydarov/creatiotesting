define("OpportunityProductPageV2", ["ConfigurationConstants", "CurrencyHelper", "css!CurrencyViewGenerator"],
	function(ConfigurationConstants, CurrencyHelper) {
		return {
			entitySchemaName: "OpportunityProductInterest",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "Opportunity",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "merge",
					"name": "Product",
					"values": {
						"layout": {"column": 0, "row": 0, "colSpan": 12},
						"tabIndex": 2
					}
				},
				{
					"operation": "remove",
					"name": "Opportunity"

				},
				{
					"operation": "remove",
					"name": "Price"
				},
				{
					"operation": "remove",
					"name": "Quantity"
				},
				{
					"operation": "remove",
					"name": "Amount"
				},
				{
					"operation": "merge",
					"name": "OfferDate",
					"values": {
						"layout": {"column": 12, "row": 0, "colSpan": 12},
						"tabIndex": 6
					}
				},
				{
					"operation": "merge",
					"name": "OfferResult",
					"values": {
						"layout": {"column": 12, "row": 1, "colSpan": 12},
						"tabIndex": 7
					}
				},
				{
					"operation": "merge",
					"name": "Comment",
					"values": {
						"layout": {"column": 0, "row": 3, "colSpan": 12},
						"tabIndex": 5
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"name": "CurrencyWrapContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"layout": {"column": 0, "row": 1, "colSpan": 12},
						"id": "CurrencyWrapContainer",
						"selectors": {wrapEl: "#CurrencyWrapContainer"},
						"wrapClass": ["control-width-15", "control-right"]
					}
				},
				{
					"operation": "insert",
					"parentName": "CurrencyWrapContainer",
					"name": "CurrencyButtonWrapContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"id": "CurrencyButtonWrapContainer",
						"selectors": {wrapEl: "#CurrencyButtonWrapContainer"},
						"wrapClass": ["label-wrap"]
					}
				},
				{
					"operation": "insert",
					"name": "CustomCurrency",
					"parentName": "CurrencyButtonWrapContainer",
					"propertyName": "items",
					"values": {
						"caption": {
							"bindTo": "CurrencyButtonCaption"
						},
						"bindTo": "Currency",
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": {bindTo: "SelectedCurrencyName"},
						"click": "onCurrencyMenuClick",
						"generator": "CurrencyViewGenerator.generateCurrencyMenuControl"
					}
				},
				{
					"operation": "insert",
					"parentName": "CurrencyWrapContainer",
					"name": "AmountWrapContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"id": "AmountWrapContainer",
						"selectors": {wrapEl: "#AmountWrapContainer"},
						"wrapClass": ["control-wrap"]
					}
				},
				{
					"operation": "insert",
					"name": "Amount",
					"parentName": "AmountWrapContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "Amount",
						"labelConfig": {
							"visible": false
						},
						"tabIndex": 3
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"name": "CurrencyRevenueWrapContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"layout": {"column": 0, "row": 2, "colSpan": 12},
						"id": "CurrencyRevenueWrapContainer",
						"selectors": {wrapEl: "#CurrencyRevenueWrapContainer"},
						"wrapClass": ["control-width-15", "control-right"]
					}
				},
				{
					"operation": "insert",
					"parentName": "CurrencyRevenueWrapContainer",
					"name": "CurrencyRevenueButtonWrapContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"id": "CurrencyRevenueButtonWrapContainer",
						"selectors": {wrapEl: "#CurrencyRevenueButtonWrapContainer"},
						"wrapClass": ["label-wrap"]
					}
				},
				{
					"operation": "insert",
					"name": "CustomCurrencyRevenue",
					"parentName": "CurrencyRevenueButtonWrapContainer",
					"propertyName": "items",
					"values": {
						"caption": {
							"bindTo": "CurrencyRevenueButtonCaption"
						},
						"bindTo": "CurrencyRevenue",
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": {bindTo: "SelectedCurrencyRevenueName"},
						"click": "onCurrencyRevenueMenuClick",
						"generator": "CurrencyViewGenerator.generateCurrencyMenuControl"
					}
				},
				{
					"operation": "insert",
					"parentName": "CurrencyRevenueWrapContainer",
					"name": "RevenueWrapContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"id": "RevenueWrapContainer",
						"selectors": {wrapEl: "#RevenueWrapContainer"},
						"wrapClass": ["control-wrap"]
					}
				},
				{
					"operation": "insert",
					"name": "Revenue",
					"parentName": "RevenueWrapContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "Revenue",
						"labelConfig": {
							"visible": false
						},
						"tabIndex": 4
					}
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"Opportunity": {
					lookupListConfig: {
						columns: ["LeadType"]
					}
				},
				"CurrencyButtonCaption": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dependencies: [
						{
							columns: ["Currency", "IsEntityInitialized"],
							methodName: "onCurrencyChanged"
						}
					]
				},
				"CurrencyRevenueButtonCaption": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dependencies: [
						{
							columns: ["CurrencyRevenue", "IsEntityInitialized"],
							methodName: "onCurrencyRevenueChanged"
						}
					]
				},
				"Currency": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					lookupListConfig: {
						columns: ["Symbol", "ShortName"]
					},
					dependencies: [
						{
							columns: ["Currency"],
							methodName: "onCurrencyChanged"
						}
					]
				},
				"CurrencyRevenue": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					lookupListConfig: {
						columns: ["Symbol", "ShortName"]
					},
					dependencies: [
						{
							columns: ["CurrencyRevenue"],
							methodName: "onCurrencyRevenueChanged"
						}
					]
				}
			},
			methods: {
				/**
				 * ############ ####### ###### # ######### ######
				 * @param {object} value ######## ######### ######
				 */
				onCurrencyMenuClick: function(value) {
					this.set("Currency", value);
				},
				/**
				 * ############ ####### ###### # ######### ######
				 * @param {object} value ######## ######### ######
				 */
				onCurrencyRevenueMenuClick: function(value) {
					this.set("CurrencyRevenue", value);
				},
				/**
				 * ########## ######### ######.
				 */
				onCurrencyChanged: function() {
					CurrencyHelper.setCurrencyCaption("Currency", this);
				},
				/**
				 * ########## ######### ######.
				 */
				onCurrencyRevenueChanged: function() {
					CurrencyHelper.setCurrencyCaption("CurrencyRevenue", this);
				},
				/**
				 * ######## ########## ### ######### ## #######.
				 * @private
				 */
				initProductFolderFilter: function() {
					var opportunity = this.get("Opportunity");
					var leadType = this.Ext.isEmpty(opportunity) ? null : opportunity.LeadType;
					if (this.Ext.isEmpty(leadType)) {
						this.set("ProductFolderFilter", null);
					} else {
						var productFolderFilterPath = "[ProductInLeadType:ProductFolder:Id].LeadType";
						// ###### ######## ## ########### # ############ #######
						var subProductFolderFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						subProductFolderFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
						var select = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "ProductFolder"
						});
						select.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
						select.addColumn("SearchData");
						select.addColumn("FolderType.Id");
						// ########## ## #### ###########, ### ###### #####
						var selectProductFolderFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						var productFolderFilter = this.Terrasoft.createColumnInFilterWithParameters(productFolderFilterPath,
							[leadType.value]);
						selectProductFolderFilterGroup.addItem(productFolderFilter);
						select.filters.addItem(this.Terrasoft.createExistsFilter("Id", selectProductFolderFilterGroup));
						select.getEntityCollection(function(response) {
							if (response && response.success) {
								var staticFolders = [];
								response.collection.each(function(responseItem) {
									var folderType = responseItem.get("FolderType.Id");
									var searchData = responseItem.get("SearchData");
									switch (folderType) {
										// ########## ########### ##### # ######
										case ConfigurationConstants.Folder.Type.General:
											staticFolders.push(responseItem.get("Id"));
											break;
										// ########## ############ ##### # ######
										case ConfigurationConstants.Folder.Type.Search:
											if (!this.Ext.isEmpty(searchData)) {
												subProductFolderFilterGroup.addItem(this.Terrasoft.deserialize(searchData));
											}
											break;
									}
								}, this);
								// ########## ########### ##### # ######
								if (staticFolders.length > 0) {
									var staticFoldersFilter = this.Terrasoft.createColumnInFilterWithParameters(
										"[ProductInFolder:Product].Folder", staticFolders);
									staticFoldersFilter.rootSchemaName = "Product";
									subProductFolderFilterGroup.addItem(staticFoldersFilter);
								}
								this.set("ProductFolderFilter", subProductFolderFilterGroup);
							} else {
								this.set("ProductFolderFilter", null);
							}
						}, this);
					}
				},

				/**
				 * ######### ############# ######## # ####### ####### #######.
				 * @protected
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.onCurrencyChanged();
					this.onCurrencyRevenueChanged();
					if (this.isCopyMode() && this.get("Opportunity")) {
						this.loadLookupDisplayValueAsync("Opportunity", this.get("Opportunity").value,
							this.initProductFolderFilter);
					} else {
						this.initProductFolderFilter();
					}
				},

				/**
				 * ######### #######, ####### ############# ## ########## ####.
				 * @private
				 * @param {String} columnName ######## #######.
				 * @return {Terrasoft.FilterGroup} ########## ###### ########.
				 */
				getLookupQueryFilters: function(columnName) {
					var mainFilterGroup = this.callParent(arguments);
					var opportunity = this.get("Opportunity");
					var leadType = this.Ext.isEmpty(opportunity) ? null : opportunity.LeadType;
					if (columnName === "Product" && !this.Ext.isEmpty(opportunity) && !this.Ext.isEmpty(leadType)) {
						var opportunityFilterPath = "[OpportunityProductInterest:Product:Id].Opportunity";
						var productFilterPath = "[ProductInLeadType:Product:Id].LeadType";
						// ###### ## ### ########### #########
						var subOpportunityFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						// ###### ## ######### # #### ###########
						var subProductFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						var existsFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						// ###### ## ####### ######### # #### ###########
						var subProductFolderFilterGroup = this.get("ProductFolderFilter");
						var opportunityFilter = this.Terrasoft.createColumnInFilterWithParameters(opportunityFilterPath,
							[opportunity.value]);
						var productFilter = this.Terrasoft.createColumnInFilterWithParameters(productFilterPath,
							[leadType.value]);
						subOpportunityFilterGroup.addItem(opportunityFilter);
						subProductFilterGroup.addItem(productFilter);
						var notExistsFilter = this.Terrasoft.createNotExistsFilter("Id", subOpportunityFilterGroup);
						var existsFilter = this.Terrasoft.createExistsFilter("Id", subProductFilterGroup);
						existsFilterGroup.addItem(existsFilter);
						if (!this.Ext.isEmpty(subProductFolderFilterGroup)) {
							existsFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
							existsFilterGroup.addItem(subProductFolderFilterGroup);
						}
						if (!this.isCopyMode()) {
							mainFilterGroup.addItem(notExistsFilter);
						}
						mainFilterGroup.addItem(existsFilterGroup);
					}
					return mainFilterGroup;
				}
			}
		};
	});
