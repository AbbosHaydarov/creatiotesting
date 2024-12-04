define("LeadTypeSpecificationDetailV2", ["ConfigurationEnums"],
	function(configurationEnums) {
		return {
			entitySchemaName: "SpecificationInLeadType",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "Specification.Name"
					}
				},
				{
					"operation": "merge",
					"name": "EditRecordMenu",
					"parentName": "ActionsButton",
					"propertyName": "menu",
					"values": {
						"visible": { "bindTo": "getEditRecordButtonVisible" }
					}
				},
				{
					"operation": "merge",
					"name": "AddRecordButton",
					"values": {
						"visible": {"bindTo": "getToolsVisible"}
					}
				},
				{
					"operation": "merge",
					"name": "EditRecordMenu",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "remove",
					"name": "CopyRecordMenu"
				}
			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * ########## #######, ####### ###### ########## ########
				 * @return {Object} ########## ###### ########-############ #######
				 */
				getGridDataColumns: function() {
					return {
						"Id": {path: "Id"},
						"Specification": {path: "Specification"},
						"Specification.Name": {path: "Specification.Name"}
					};
				},

				/**
				 * ######### ########## #########
				 * @private
				 */
				openItemLookup: function() {
					var config = {
						entitySchemaName: "Specification",
						multiSelect: true,
						columns: ["Name"]
					};
					var leadTypeId = this.get("MasterRecordId");
					if (this.Ext.isEmpty(leadTypeId)) {
						return;
					}
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName
					});
					esq.addColumn("Id");
					esq.addColumn("Specification.Id", "SpecificationId");
					esq.filters.add("filterLeadType", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "LeadType", leadTypeId));
					esq.getEntityCollection(function(result) {
						var existsProductsCollection = [];
						if (result.success) {
							result.collection.each(function(item) {
								existsProductsCollection.push(item.get("SpecificationId"));
							});
						}
						if (existsProductsCollection.length > 0) {
							var existsFilter = this.Terrasoft.createColumnInFilterWithParameters("Id",
								existsProductsCollection);
							existsFilter.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
							existsFilter.Name = "existsFilter";
							config.filters = existsFilter;
						}
						this.openLookup(config, this.addCallBack, this);
					}, this);
				},

				/**
				 * @overridden
				 */
				onCardSaved: function() {
					this.openItemLookup();
				},

				/*
				 * ######### ########## ######### # ###### #### ######## #### #### ##### #########
				 * @overridden
				 * */
				addRecord: function() {
					var masterCardState = this.sandbox.publish("GetCardState", null, [this.sandbox.id]);
					var isNewRecord = (masterCardState.state === configurationEnums.CardStateV2.ADD ||
					masterCardState.state === configurationEnums.CardStateV2.COPY);
					if (isNewRecord === true) {
						var args = {
							isSilent: true,
							messageTags: [this.sandbox.id]
						};
						this.sandbox.publish("SaveRecord", args, [this.sandbox.id]);
						return;
					}
					this.openItemLookup();
				},

				/*
				 * ########## ######## #########
				 * @private
				 * */
				addCallBack: function(args) {
					var bq = this.Ext.create("Terrasoft.BatchQuery");
					var leadTypeId = this.get("MasterRecordId");
					this.selectedRows = args.selectedRows.getItems();
					this.selectedItems = [];
					this.selectedRows.forEach(function(item) {
						item.LeadTypeId = leadTypeId;
						item.SpecificationId = item.value;
						bq.add(this.getItemInsertQuery(item));
						this.selectedItems.push(item.value);
					}, this);
					if (bq.queries.length) {
						this.showBodyMask.call(this);
						bq.execute(this.onItemInsert, this);
					}
				},

				/*
				 * ########## ###### ## ########## ########
				 * @param item {Object} ############# #### # ######### # ########### #######   {LeadId, value}
				 * @private
				 * */
				getItemInsertQuery: function(item) {
					var insert = Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: this.entitySchemaName
					});
					insert.setParameterValue("LeadType", item.LeadTypeId, this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue("Specification", item.SpecificationId, this.Terrasoft.DataValueType.GUID);
					return insert;
				},

				/*
				 * ######## ########## ######### # ######
				 * @private
				 * */
				onItemInsert: function(response) {
					this.hideBodyMask.call(this);
					this.beforeLoadGridData();
					var filterCollection = [];
					response.queryResults.forEach(function(item) {
						filterCollection.push(item.id);
					});
					var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName
					});
					this.initQueryColumns(esq);
					esq.filters.add("recordId", Terrasoft.createColumnInFilterWithParameters("Id", filterCollection));
					esq.getEntityCollection(function(response) {
						this.afterLoadGridData();
						if (response.success) {
							var responseCollection = response.collection;
							this.prepareResponseCollection(responseCollection);
							this.getGridData().loadAll(responseCollection);
						}
					}, this);
				},

				/*
				 * ######## ######### #######
				 * @overridden
				 * */
				deleteRecords: function() {
					var selectedRows = this.getSelectedItems();
					if (selectedRows.length > 0) {
						this.set("SelectedRows", selectedRows);
						this.callParent(arguments);
					}
				}
			}
		};
	}
);
