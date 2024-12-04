define("RelatedBankCardDetailV2", ["terrasoft", "ConfigurationEnums"], function(Terrasoft, configurationEnums) {
		return {
			entitySchemaName: "BankCardRelated",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "AddRecordButton",
					"values": {
						"visible": {"bindTo": "getToolsVisible"}
					}
				},
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "RelatedBankCard.Number"
					}
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"MasterSchemaName": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"value": "BankCard"
				},
				"MasterColumnName": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"value": "BankCard"
				},
				"ChildColumnName": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"value": "RelatedBankCard"
				}
			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addRecord
				 * @overridden
				 */
				addRecord: function() {
					var masterCardState = this.sandbox.publish("GetCardState", null, [this.sandbox.id]);
					if (masterCardState.state === configurationEnums.CardStateV2.ADD ||
						masterCardState.state === configurationEnums.CardStateV2.COPY) {
						var args = {
							isSilent: true,
							messageTags: [this.sandbox.id]
						};
						this.sandbox.publish("SaveRecord", args, [this.sandbox.id]);
						return;
					}
					this.openItemLookup(this.addRecordCallback, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#onCardSaved
				 * @overridden
				 */
				onCardSaved: function() {
					this.openItemLookup(this.addRecordCallback, this);
				},

				/**
				 * Open lookup.
				 * @protected
				 * @param {function} callback - callback function.
				 * @param {Object} scope - execution context callback.
				 */
				openItemLookup: function(callback, scope) {
					var masterRecordId = this.get("MasterRecordId");
					if (!masterRecordId) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
						return;
					}
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName
					});
					esq.addColumn("Id");
					esq.addColumn(this.get("ChildColumnName") + ".Id", "ChildRecordId");
					esq.filters.add("filter", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, this.get("MasterColumnName"), masterRecordId));
					esq.getEntityCollection(function(result) {
						var existsContacts = [masterRecordId];
						if (result.success) {
							result.collection.each(function(item) {
								existsContacts.push(item.get("ChildRecordId"));
							});
						}
						var config = this.getLookupConfig();
						if (existsContacts.length > 0) {
							var existsFilter = Terrasoft.createColumnInFilterWithParameters("Id", existsContacts);
							existsFilter.comparisonType = Terrasoft.ComparisonType.NOT_EQUAL;
							existsFilter.Name = "existsFilter";
							config.filters = existsFilter;
						}
						this.openLookup(config, callback, scope);
					}, this);
				},

				/**
				 * Lookup config.
				 * @abstract
				 * @return {Object}
				 */
				getLookupConfig: function() {
					return {
						entitySchemaName: this.get("MasterSchemaName"),
						multiSelect: true,
						columns: ["Number"]
					};
				},

				/**
				 * Addition of selected records in a table interchanges.
				 * @private
				 * @param {Object} selectedRecords - selected records in lookup window.
				 * */
				addRecordCallback: function(selectedRecords) {
					var bq = this.Ext.create("Terrasoft.BatchQuery");
					var masterRecordId = this.get("MasterRecordId");
					this.selectedRows = selectedRecords.selectedRows.getItems();
					this.selectedItems = [];
					this.selectedRows.forEach(function(item) {
						bq.add(this.getInsertRelatedBankCardsQuery(masterRecordId, item.value));
						this.selectedItems.push(item.value);
					}, this);
					if (bq.queries.length > 0) {
						bq.execute(this.onItemInserted, this);
					}
				},

				/**
				 * Returns the request to add records in the table interchanges.
				 * @private
				 * @param {GUID} masterRecordId - Id main bank card.
				 * @param {GUID} childRecordId - Id related bank card.
				 * @return {Terrasoft.InsertQuery} InsertQuery to add records in the table interchanges.
				 * */
				getInsertRelatedBankCardsQuery: function(masterRecordId, childRecordId) {
					var insert = Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: this.entitySchemaName
					});
					insert.setParameterValue(this.get("MasterColumnName"), masterRecordId,
						this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue(this.get("ChildColumnName"), childRecordId,
						this.Terrasoft.DataValueType.GUID);
					return insert;
				},

				/**
				 * After adding records to display them in detail.
				 * @protected
				 * @param {Object} result - result of insertion.
				 * */
				onItemInserted: function(result) {
					if (this.Ext.isObject(result) && result.success === true) {
						var queryResults = result.queryResults;
						queryResults.forEach(function(item) {
							this.updateDetail({primaryColumnValue: item.id});
						}, this);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: Terrasoft.emptyFn
			}
		};
	}
);
