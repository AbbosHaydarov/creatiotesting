define("BaseBankCardBankAccountDetailV2", ["ConfigurationEnums"], function(configurationEnums) {
	return {
		entitySchemaName: "BankCardBankAccount",
		methods: {
			/**
			 * ########## #######, ####### ###### ########## ########
			 * @return {Object} ########## ###### ########-############ #######
			 */
			getGridDataColumns: function() {
				return {
					"Id": {path: "Id"}
				};
			},
			/**
			 * ######### ##########
			 * @private
			 */
			openItemLookup: function() {
				var masterRecordId = this.get("MasterRecordId");
				if (!masterRecordId) {
					return;
				}
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: this.entitySchemaName
				});
				esq.addColumn("Id");
				esq.addColumn(this.get("ChildSchemaName") + ".Id", "ChildRecordId");
				esq.filters.add("filter", Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, this.get("MasterSchemaName"), masterRecordId));
				esq.getEntityCollection(function(result) {
					var existsContactsCollection = [];
					if (result.success) {
						result.collection.each(function(item) {
							existsContactsCollection.push(item.get("ChildRecordId"));
						});
					}
					var config = this.getLookupConfig();
					if (existsContactsCollection.length > 0) {
						var existsFilter = Terrasoft.createColumnInFilterWithParameters("Id",
							existsContactsCollection);
						existsFilter.comparisonType = Terrasoft.ComparisonType.NOT_EQUAL;
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
			 * ######### ########## # ###### #### ######## #### ##### #########
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
			 * ########## ######## ####### # ####### ########
			 * @private
			 * */
			addCallBack: function(args) {
				var bq = this.Ext.create("Terrasoft.BatchQuery");
				var masterRecordId = this.get("MasterRecordId");
				this.selectedRows = args.selectedRows.getItems();
				this.selectedItems = [];
				this.selectedRows.forEach(function(item) {
					item.ChildRecordId = item.value;
					item.MasterRecordId = masterRecordId;
					bq.add(this.getInsertQuery(item));
					this.selectedItems.push(item.value);
				}, this);
				if (bq.queries.length) {
					this.showBodyMask.call(this);
					bq.execute(this.onItemInserted, this);
				}
			},

			/*
			 * ########## ###### ## ########## ###### # ###### ########
			 * @param args {Object} ###### ########## #### {BankCardId, BankAccountId} ### ########## ###### # ###### ########
			 * @private
			 * */
			getInsertQuery: function(item) {
				var insert = Ext.create("Terrasoft.InsertQuery", {
					rootSchemaName: this.entitySchemaName
				});
				insert.setParameterValue(this.get("MasterSchemaName"), item.MasterRecordId,
					this.Terrasoft.DataValueType.GUID);
				insert.setParameterValue(this.get("ChildSchemaName"), item.ChildRecordId,
					this.Terrasoft.DataValueType.GUID);
				return insert;
			},

			/*
			 * ######## #######
			 * @private
			 * */
			onItemInserted: function(response) {
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
			},
			/**
			 * ########## ####### ########### ###### ############## ######, ########## ## ############## ######.
			 * @protected
			 * @overridden
			 * @return {BaseViewModel} ####### ########### ###### ############## ######, ########## ##
			 * ############## ######.
			 */
			getEditRecordMenuItem: Terrasoft.emptyFn,
			/**
			 * ########## ########### ###### #### ########### ######
			 * @return {Boolean}
			 */
			getCopyRecordMenuItem: Terrasoft.emptyFn
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "EditRecordMenu",
				"parentName": "ActionsButton",
				"propertyName": "menu",
				"values": {
					"visible": {"bindTo": "getEditRecordButtonVisible"}
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
		]/**SCHEMA_DIFF*/
	};
});
