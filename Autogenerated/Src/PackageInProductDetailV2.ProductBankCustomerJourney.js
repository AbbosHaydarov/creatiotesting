define("PackageInProductDetailV2", ["ProductBankConstants"],
	function(ProductBankConstants) {
		return {
			entitySchemaName: "ProductInPackage",
			/**SCHEMA_DIFF*/
			diff: [
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "Product"
					}
				}
			],
			/**SCHEMA_DIFF*/
			methods: {

				/**
				 * @inheritdoc Terrasoft.ProductInPackageDetailV2#getPackageLookupFilter
				 * @overridden
				 */
				getPackageLookupFilter: function() {
					var filters = this.Terrasoft.createFilterGroup();
					var categoryFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.NOT_EQUAL,
						"Category.Kind",
						ProductBankConstants.CategoryKind.SERVICE_PACKAGE);
					filters.addItem(categoryFilter);
					var notExistsFilter = this.Terrasoft.createNotExistsFilter(
						"[ProductInPackage:Product:Id].Id");
					var subFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						this.get("DetailColumnName"),
						this.get("MasterRecordId"));
					notExistsFilter.subFilters.addItem(subFilter);
					filters.addItem(notExistsFilter);
					return filters;
				},

				/**
				 * @inheritdoc Terrasoft.ProductInPackageDetailV2#getProductInPackageInsertQuery
				 * @overridden
				 */
				getProductInPackageInsertQuery: function(item) {
					var insert = this.Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: this.entitySchemaName
					});
					insert.setParameterValue("Product", item.value,
						this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue(this.get("DetailColumnName"), this.get("MasterRecordId"),
						this.Terrasoft.DataValueType.GUID);
					return insert;
				}
			}
		};
	});
