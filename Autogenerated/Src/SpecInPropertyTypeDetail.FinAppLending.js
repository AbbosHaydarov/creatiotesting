define("SpecInPropertyTypeDetail", ["ConfigurationEnums"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "SpecInPropertyType",
			/**SCHEMA_DIFF*/
			diff: [
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "Specification"
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
				 * Returns config for lookupPage.
				 * @protected
				 * @return {Object} config for lookupPage.
				 */
				getLookupPageConfig: function() {
					var config = {
						entitySchemaName: "Specification",
						multiSelect: true,
						columns: ["Name"],
						filters: this.getSpecificationLookupFilter(),
						hideActions: false
					};
					return config;
				},

				/**
				 * Returns specification filters group.
				 * @protected
				 * @return {Terrasoft.data.filters.FilterGroup} Returns filters group.
				 */
				getSpecificationLookupFilter: function() {
					var filters = this.Terrasoft.createFilterGroup();
					var notExistsFilter = this.Terrasoft.createNotExistsFilter(
						"[SpecInPropertyType:Specification:Id].Id");
					var subFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						this.get("DetailColumnName"),
						this.get("MasterRecordId"));
					notExistsFilter.subFilters.addItem(subFilter);
					filters.addItem(notExistsFilter);
					return filters;
				},

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

				/*
				 * Returns insert query for SpecInProperty.
				 * @protected
				 * @param {Object} item Selected lookup value.
				 * @return {Terrasoft.InsertQuery} Insert query.
				 */
				getSpecInPropertyTypeInsertQuery: function(item) {
					var insert = this.Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: this.entitySchemaName
					});
					insert.setParameterValue("Specification", item.value,
						this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue(this.get("DetailColumnName"), this.get("MasterRecordId"),
						this.Terrasoft.DataValueType.GUID);
					return insert;
				},

				/**
				 * Handles lookup page selection.
				 * @protected
				 * @param {Object} args Function arguments.
				 */
				addCallback: function(args) {
					var bq = this.Ext.create("Terrasoft.BatchQuery");
					var selectedRows = args.selectedRows.getItems();
					selectedRows.forEach(function(item) {
						bq.add(this.getSpecInPropertyTypeInsertQuery(item));
					}, this);
					if (bq.queries.length > 0) {
						this.showBodyMask();
						bq.execute(this.onDataLoaded, this);
					}
				},

				/*
				 * Handles data loaded event.
				 * @param {Object} response Response from server.
				 * @protected
				 */
				onDataLoaded: function(response) {
					this.hideBodyMask();
					response.queryResults.forEach(function(item) {
						this.loadGridDataRecord(item.id);
					}, this);
				}

				//endregion

			}
		};
	});

