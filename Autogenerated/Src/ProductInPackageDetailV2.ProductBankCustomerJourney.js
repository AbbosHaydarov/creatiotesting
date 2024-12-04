define("ProductInPackageDetailV2", ["ConfigurationEnums", "ProductBankConstants"],
	function(ConfigurationEnums, ProductBankConstants) {
		return {
			entitySchemaName: "ProductInPackage",
			/**SCHEMA_DIFF*/
			diff: [
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "Package"
					}
				},
				{
					"operation": "merge",
					"name": "AddRecordButton",
					"values": {
						"visible": {"bindTo": "getToolsVisible"}
					}
				}
			],
			/**SCHEMA_DIFF*/
			methods: {

				//region Methods: Private

				/**
				 * Returns config for lookupPage.
				 * @private
				 * @return {Object} Config for lookupPage.
				 */
				getLookupPageConfig: function() {
					var config = {
						entitySchemaName: "Product",
						multiSelect: true,
						columns: ["Name"],
						filters: this.getPackageLookupFilter(),
						hideActions: true
					};
					return config;
				},

				/**
				 * Generates filters, for display packeges services.
				 * @private
				 * @return {Terrasoft.data.filters.FilterGroup} Group filter.
				 */
				getPackageLookupFilter: function() {
					var filters = this.Terrasoft.createFilterGroup();
					var categoryFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"Category.Kind",
							ProductBankConstants.CategoryKind.SERVICE_PACKAGE);
					filters.addItem(categoryFilter);
					var notExistsFilter = this.Terrasoft.createNotExistsFilter(
							"[ProductInPackage:Package:Id].Id");
					var subFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							this.get("DetailColumnName"),
							this.get("MasterRecordId"));
					notExistsFilter.subFilters.addItem(subFilter);
					filters.addItem(notExistsFilter);
					return filters;
				},

				/**
				 * Returns request to add entries in object ProductInPackage.
				 * @private
				 * @param item {Object} Selected element of catalog.
				 * @return {Terrasoft.InsertQuery} Request to add entries.
				 */
				getProductInPackageInsertQuery: function(item) {
					var insert = this.Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: this.entitySchemaName
					});
					insert.setParameterValue("Package", item.value,
							this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue(this.get("DetailColumnName"), this.get("MasterRecordId"),
							this.Terrasoft.DataValueType.GUID);
					return insert;
				},

				/**
				 * Loads added entries in section.
				 * @private
				 * @param {Object} response Object, contain response from server.
				 */
				onDataLoaded: function(response) {
					this.hideBodyMask();
					response.queryResults.forEach(function(item) {
						this.loadGridDataRecord(item.id);
					}, this);
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
				 * @overridden
				 */
				addDetailWizardMenuItems: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addRecord
				 * @overridden
				 */
				addRecord: function() {
					var cardState = this.sandbox.publish("GetCardState", null, [this.sandbox.id]);
					var isNew = (cardState.state === ConfigurationEnums.CardStateV2.ADD ||
					cardState.state === ConfigurationEnums.CardStateV2.COPY);
					if (isNew) {
						var args = {
							isSilent: true,
							messageTags: [this.sandbox.id]
						};
						this.sandbox.publish("SaveRecord", args, [this.sandbox.id]);
						return;
					}
					var config = this.getLookupPageConfig();
					this.openLookup(config, this.addCallback, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#onCardSaved
				 * @overridden
				 */
				onCardSaved: function() {
					var config = this.getLookupPageConfig();
					this.openLookup(config, this.addCallback, this);
				},

				/**
				 * Callback-function, which called after close window select of catalog.
				 * @virtual
				 * @param {Object} args Object, contain collection selected entries.
				 */
				addCallback: function(args) {
					var bq = this.Ext.create("Terrasoft.BatchQuery");
					var selectedRows = args.selectedRows.getItems();
					selectedRows.forEach(function(item) {
						bq.add(this.getProductInPackageInsertQuery(item));
					}, this);
					if (bq.queries.length > 0) {
						this.showBodyMask();
						bq.execute(this.onDataLoaded, this);
					}
				}

				//endregion

			}
		};
	});

