define("BankAccountPageV2", [],
	function() {
		return {
			entitySchemaName: "BankAccount",
			diff: /**SCHEMA_DIFF*/ [
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
					"operation": "merge",
					"name": "Product",
					"values": {
						"isRequired": true,
						"enabled": true,
						"tabIndex": 5
					}
				},
				{
					"operation": "merge",
					"name": "Type",
					"values": {
						"tabIndex": 7
					}
				},
				{
					"operation": "merge",
					"name": "Currency",
					"values": {
						"tabIndex": 8
					}
				},
				{
					"operation": "merge",
					"name": "Balance",
					"values": {
						"tabIndex": 9
					}
				},
				{
					"operation": "merge",
					"name": "Branch",
					"values": {
						"tabIndex": 10
					}
				},
				{
					"operation": "merge",
					"name": "Division",
					"values": {
						"tabIndex": 11
					}
				},
				{
					"operation": "merge",
					"name": "OpenedOn",
					"values": {
						"tabIndex": 12
					}
				},
				{
					"operation": "merge",
					"name": "ActivatedOn",
					"values": {
						"tabIndex": 13
					}
				},
				{
					"operation": "merge",
					"name": "Status",
					"values": {
						"tabIndex": 14
					}
				},
				{
					"operation": "merge",
					"name": "ClosedOn",
					"values": {
						"tabIndex": 15
					}
				},
				{
					"operation": "merge",
					"name": "ReasonForClosing",
					"values": {
						"tabIndex": 16
					}
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
					"operation": "remove",
					"name": "Account"
				}
			] /**SCHEMA_DIFF*/,
			attributes: {
				"Package": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {
						filters: [
							{
								method: function() {
									return this.getPackageFilter();
								}
							}
						]
					}
				},
				"ProductChange": {
					name: "Product",
					dependencies: [{
						columns: ["Product"],
						methodName: "onProductChanged"
					}]
				},
				"Client": {
					"caption": {
						"bindTo": "Resources.Strings.ClientCaption"
					},
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"multiLookupColumns": ["Contact", "Account"],
					"isRequired": true
				}
			},
			methods: {
				/**
				 * Set Package visibility.
				 * @protected
				 */
				onProductChanged: function() {
					var product = this.get("Product");
					if (!Ext.isEmpty(product)) {
						var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "ProductInPackage"
						});
						select.addColumn("Package");
						select.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
								"Product", product.value));
						select.getEntityCollection(function(response) {
							if (response.success) {
								var responseItems = response.collection.getItems();
								this.set("IsPackageVisible", (responseItems.length > 0));
							}
						}, this);
					} else {
						this.set("IsPackageVisible", false);
						this.set("Package", null);
					}
				},

				/**
				 * Create a group filter to select the package of the selected product.
				 * @protected
				 * @return {Terrasoft.FilterGroup}
				 */
				getPackageFilter: function() {
					var product = this.get("Product");
					var filters = this.Terrasoft.createFilterGroup();
					if (!Ext.isEmpty(product)) {
						filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
							"[ProductInPackage:Package:Id].Product", product.value));
					}
					return filters;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.onProductChanged();
					this.callParent(arguments);
				}
			}
		};
	}
);
