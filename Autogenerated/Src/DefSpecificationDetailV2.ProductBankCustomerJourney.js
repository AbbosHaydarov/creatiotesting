define("DefSpecificationDetailV2", ["ConfigurationEnums", "GridHelper"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "DefSpecification",
			mixins: {GridHelper: "Terrasoft.GridHelper"},
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

				//region Methods: Private

				/**
				 * Returns edit pages sandbox id array.
				 * @private
				 * @return {Array} Sandbox id.
				 */
				getEditPagesSandboxIds: function() {
					return [this.sandbox.id + "_SpecificationPageV2"];
				},

				/**
				 * Returns config for lookupPage.
				 * @private
				 * @return {Object} Config for lookupPage.
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
				 * Generates filters, for display parameters.
				 * @private
				 * @return {Terrasoft.data.filters.FilterGroup} Return Group filters.
				 */
				getSpecificationLookupFilter: function() {
					var filters = this.Terrasoft.createFilterGroup();
					var notExistsFilter = this.Terrasoft.createNotExistsFilter(
							"[DefSpecification:Specification:Id].Id");
					var subFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							this.get("DetailColumnName"),
							this.get("MasterRecordId"));
					notExistsFilter.subFilters.addItem(subFilter);
					filters.addItem(notExistsFilter);
					return filters;
				},

				/**
				 * Returns request to add entries in object DefSpecification.
				 * @private
				 * @param item {Object} Selected elements from  catalog.
				 * @return {Terrasoft.InsertQuery} Request to add entries.
				 */
				getDefSpecificationInsertQuery: function(item) {
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
				 * Loads added entries in section.
				 * @private
				 * @param {Object} response Object, comprising response of server.
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
				 * @inheritdoc Terrasoft.BaseGridDetailV2#linkClicked
				 * @overridden
				 */
				linkClicked: function(recordId) {
					this.set("ClickedRecordId", recordId);
					return this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#updateDetail
				 * @overridden
				 */
				updateDetail: function(config) {
					config.primaryColumnValue = this.get("ClickedRecordId") || config.primaryColumnValue;
					this.callParent(arguments);
				},

				/**
				 * @inheritDoc GridUtilitiesV2#addColumnLink
				 * @overridden
				 */
				addColumnLink: function(item, column) {
					var columnPath = column.columnPath;
					if (columnPath === "Specification") {
						this.addOpenCardColumnLink(item, column);
					} else {
						this.callParent(arguments);
					}
				},

				/**
				 * @inheritDoc GridHelper#createPrimaryDisplayColumnLink
				 * @overridden
				 */
				createPrimaryDisplayColumnLink: function(item) {
					var specification = item.get("Specification");
					var recordId = specification && specification.value;
					var displayValue = specification && specification.displayValue;
					var schemaName = "SpecificationPageV2";
					var linkPartArray = ["CardModuleV2", schemaName, "edit", recordId];
					var link = this.Terrasoft.workspaceBaseUrl + "/NUI/ViewModule.aspx#" + linkPartArray.join("/");
					return {
						caption: displayValue,
						target: "_self",
						title: displayValue,
						url: link
					};
				},

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
				 * Callback-function, which called after close window select from catalog.
				 * @virtual
				 * @param {Object} args Object, comprising collection selected entries.
				 */
				addCallback: function(args) {
					var bq = this.Ext.create("Terrasoft.BatchQuery");
					var selectedRows = args.selectedRows.getItems();
					selectedRows.forEach(function(item) {
						bq.add(this.getDefSpecificationInsertQuery(item));
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

