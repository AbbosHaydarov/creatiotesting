define("ContractPageV2", ["BusinessRuleModule", "BaseFinanceConstants", "ContractPageV2Resources"],
	function() {
		return {
			entitySchemaName: "Contract",
			details: /**SCHEMA_DETAILS*/{
				"BankCard": {
					"schemaName": "BankCardDetailV2",
					"filter": {
						"detailColumn": "Contract",
						"masterColumn": "Id"
					},
					defaultValues: {
						BankCardOwner: {
							masterColumn: "Account"
						},
						Contact: {
							masterColumn: "ContactContract"
						},
						Product: {
							masterColumn: "Product"
						}
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "remove",
					"name": "Type"
				},
				{
					"operation": "remove",
					"name": "Account"
				},
				{
					"operation": "remove",
					"name": "Contact"
				},
				{
					"operation": "remove",
					"name": "SupplierBillingInfo"
				},
				{
					"operation": "move",
					"name": "CustomerBillingInfo",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tip": {
							"content": {"bindTo": "Resources.Strings.CustomerBillingInfoTip"}
						},
						"bindTo": "CustomerBillingInfo",
						"contentType": this.Terrasoft.ContentType.ENUM,
						"enabled": true
					},
					"parentName": "group_gridLayout",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "FinApplication",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 3
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Package",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"visible": {
							"bindTo": "IsPackageVisible"
						},
						"tabIndex": 6
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Client",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 4,
						"controlConfig": {
							"enableLeftIcon": true,
							"leftIconConfig": {
								"bindTo": "getMultiLookupIconConfig"
							}
						}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Department",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Department",
						"textSize": "Default",
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"labelConfig": {
							"visible": true
						},
						"enabled": true,
						"tabIndex": 13
					},
					"parentName": "group_gridLayout",
					"propertyName": "items"
				},
				{
					"operation": "merge",
					"name": "Product",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 5
					}
				},
				{
					"operation": "merge",
					"name": "OurCompany",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 12
					}
				},
				{
					"operation": "merge",
					"name": "Number",
					"values": {
						"tabIndex": 2
					}
				},
				{
					"operation": "move",
					"name": "State",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 7
					},
					"parentName": "group_gridLayout",
					"propertyName": "items"
				},
				{
					"operation": "move",
					"name": "SigningDate",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 8
					},
					"parentName": "group_gridLayout",
					"propertyName": "items"
				},
				{
					"operation": "move",
					"name": "StartDate",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 9
					},
					"parentName": "group_gridLayout",
					"propertyName": "items"
				},
				{
					"operation": "move",
					"name": "EndDate",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 10
					},
					"parentName": "group_gridLayout",
					"propertyName": "items"
				},
				{
					"operation": "move",
					"name": "Owner",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"tabIndex": 11
					},
					"parentName": "group_gridLayout",
					"propertyName": "items"
				}
			], /**SCHEMA_DIFF*/
			attributes: {
				"Package": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						"filters": [
							{
								method: function() {
									return this.getPackageFilter();
								}
							}
						]
					}
				},
				"Client": {
					"caption": {
						"bindTo": "Resources.Strings.ClientCaption"
					},
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"multiLookupColumns": ["ContactContract", "Account"],
					"isRequired": true
				}

			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.MultiLookupUtilitiesMixin#getLookupImageId
				 * @overridden
				 */
				getLookupImageId: function(columnName) {
					var lookupImageId = "";
					var columnsInfo = this.Terrasoft.configuration.ColumnsInfo;
					this.Terrasoft.each(columnsInfo, function(column, name) {
						if (name === columnName || (name === "Contact" && columnName === "ContactContract")) {
							lookupImageId = column.ImageId;
							return false;
						}
					}, this);
					return lookupImageId;
				},

				/**
				 * Returns a filter group to select the package of the selected product.
				 * @protected
				 * @return {Terrasoft.FilterGroup}
				 */
				getPackageFilter: function() {
					var product = this.get("Product");
					var filters = this.Terrasoft.createFilterGroup();
					if (!this.Ext.isEmpty(product)) {
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
							"[ProductInPackage:Package:Id].Product", product.value));
					}
					return filters;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.onProductChanged();
				},

				/**
				 * @inheritdoc Terrasoft.ContractPageV2#onProductChanged
				 * @overridden
				 */
				onProductChanged: function() {
					var product = this.get("Product");
					var oldProduct = this.get("OldProduct");
					if (!this.Ext.isEmpty(product)) {
						var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "ProductInPackage"
						});
						select.addColumn("Package");
						select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
							"Product", product.value));
						select.getEntityCollection(function(response) {
							if (response.success) {
								this.set("IsPackageVisible", !response.collection.isEmpty());
							}
							this.changeProduct(product, oldProduct);
						}, this);
					} else {
						this.set("IsPackageVisible", false);
						this.set("Package", null);
					}
				}
			}
		};
	}
);
