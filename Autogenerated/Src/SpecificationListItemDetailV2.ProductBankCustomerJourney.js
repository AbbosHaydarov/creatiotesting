define("SpecificationListItemDetailV2", ["ResponseExceptionHelper"], function(ResponseExceptionHelper) {
	return {
		entitySchemaName: "SpecificationListItem",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		attributes: {
			/**
			 * ### #######, # ####### ######## ########## ############## ####### ###########.
			 * @type {String}
			 */
			LookupValueColumnName: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: "LookupValueId"
			}
		},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#init
			 * @overridden
			 */
			init: function() {
				this.callParent(arguments);
				this.setLookupValues();
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilitiesV2#initQueryColumns
			 * @overridden
			 */
			initQueryColumns: function(esq) {
				this.callParent(arguments);
				this.addGridDataColumn(esq, this.get("LookupValueColumnName"));
			},

			/**
			 * ######### # ####### #######, ########## # ######### column.
			 * @protected
			 * @param {Terrasoft.EntitySchemaQuery} esq ###### ## ####### ######## ## ######.
			 * @param {String} column ######## #######.
			 */
			addGridDataColumn: function(esq, column) {
				if (!esq.columns.contains(column)) {
					esq.addColumn(column, column);
				}
			},

			/**
			 * ########### # ###### ####### Lookup # LookupSchemaName ########## ## ########.
			 * @protected
			 */
			setLookupValues: function() {
				this.set("Lookup", this.getDefaultValueByName("Lookup"));
				var lookupSchemaName = this.getDefaultValueByName("LookupSchemaName");
				this.set("LookupSchemaName", lookupSchemaName && lookupSchemaName.value);
			},

			/**
			 * ########## ## ####### ######## ##-######### ######## # ######## ######.
			 * @protected
			 * @param {String} name ### # ####### ######## ##-#########.
			 * @return {Object} ######## ##-#########.
			 */
			getDefaultValueByName: function(name) {
				return this.Ext.Array.findBy(this.get("DefaultValues"), function(item) {
					return item.name === name;
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addToolsButtonMenuItems
			 * @overridden
			 */
			addToolsButtonMenuItems: function(toolsButtonMenu) {
				this.addRecordOperationsMenuItems(toolsButtonMenu);
				this.addLookupValuesMenuItem(toolsButtonMenu);
				this.addGridOperationsMenuItems(toolsButtonMenu);
				this.addDetailWizardMenuItems(toolsButtonMenu);
			},

			/**
			 * ######### # #### ############## ###### ##### "######### ########## ## ###########".
			 * @protected
			 * @param {Terrasoft.BaseViewModelCollection} toolsButtonMenu ######### ####### ####.
			 */
			addLookupValuesMenuItem: function(toolsButtonMenu) {
				var addLookupValuesMenuItem = this.getAddLookupValuesMenuItem();
				if (addLookupValuesMenuItem) {
					toolsButtonMenu.addItem(this.getButtonMenuSeparator());
					toolsButtonMenu.addItem(addLookupValuesMenuItem);
				}
			},

			/**
			 * ########## ####### ########### ###### ############## ######, ########## ## ######## ########
			 * ###### ## ###########.
			 * @protected
			 * @return {Terrasoft.BaseViewModel} ####### ########### ###### ############## ######.
			 */
			getAddLookupValuesMenuItem: function() {
				return this.getButtonMenuItem({
					Caption: {"bindTo": "Resources.Strings.AddLookupValues"},
					Click: {"bindTo": "addLookupValues"},
					Enabled: {
						"bindTo": "Lookup",
						"bindConfig": {"converter": "enabledByLookup"}
					}
				});
			},

			/**
			 * ######### ########### ######## "######### ########## ## ###########". #### # ######## #########
			 * #### "####### ## ############", ######## ########, ##### ###.
			 * @protected
			 * @param {Object} value ######## ######## Lookup ## ########.
			 * @return {Boolean} True, #### value ## #####, ##### false.
			 */
			enabledByLookup: function(value) {
				return !this.Ext.isEmpty(value);
			},

			/**
			 * ############ ######## "######### ########## ## ###########".
			 * @protected
			 */
			addLookupValues: function() {
				var config = this.getLookupPageConfig();
				this.openLookup(config, this.onLookupResult, this);
			},

			/**
			 * ########## ###### ############ ### ######## ###### ## ###########.
			 * @protected
			 * @return {Object} ###### ############.
			 */
			getLookupPageConfig: function() {
				var rowsIds = this.getLookupValuesIds();
				return {
					entitySchemaName: this.get("LookupSchemaName"),
					multiSelect: true,
					filters: this.getLookupQueryFilters(rowsIds)
				};
			},

			/**
			 * ########## ###### ############### ####### ########### ## ######.
			 * @protected
			 * @return {Array} ###### ########## ############### ####### # ###########.
			 */
			getLookupValuesIds: function() {
				var selectedIds = [];
				var gridData = this.getGridData();
				var columnName = this.get("LookupValueColumnName");
				gridData.each(function(item) {
					selectedIds.push(item.get(columnName));
				}, this);
				return selectedIds;
			},

			/**
			 * ########## ###### ######## ### ######## ###### ## ###########.
			 * @protected
			 * @param {Array} rowsIds ###### ############### ######## ###########, ########### ## ######.
			 * @return {Terrasoft.FilterGroup} ###### ########.
			 */
			getLookupQueryFilters: function(rowsIds) {
				var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
				var notInFilter = this.Terrasoft.createColumnInFilterWithParameters("Id", rowsIds,
					this.Terrasoft.DataValueType.GUID);
				notInFilter.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
				filterGroup.addItem(notInFilter);
				return filterGroup;
			},

			/**
			 * ############ ##### ######## ###########.
			 * @protected
			 * @param {Object} args ######### ###### ###### ###### ## ###########.
			 * @param {Terrasoft.Collection} args.selectedRows ######### ######### #######.
			 */
			onLookupResult: function(args) {
				var batchQuery = this.getBatchQuery(args.selectedRows);
				if (batchQuery.queries.length) {
					this.showBodyMask();
					batchQuery.execute(this.onRowsInserted, this);
				}
			},

			/**
			 * ########## ######## ######.
			 * @protected
			 * @param {Terrasoft.Collection} selectedRows ######### ######### #######.
			 * @return {Terrasoft.BatchQuery} ######## ######.
			 */
			getBatchQuery: function(selectedRows) {
				var batchQuery = this.Ext.create("Terrasoft.BatchQuery");
				selectedRows.each(function(item) {
					batchQuery.add(this.getEntitySchemaInsertQuery(item));
				}, this);
				return batchQuery;
			},

			/**
			 * ########## ###### {@link Terrasoft.InsertQuery} ## ########## ###### # ####### SpecificationListItem.
			 * @protected
			 * @param {Object} item ######### ###### # ###########.
			 * @param {String} item.Name ############ ######## ### ###### # ###########.
			 * @param {String} item.Id ############# ###### # ###########.
			 * @return {Terrasoft.InsertQuery} ###### ## ########## ######.
			 */
			getEntitySchemaInsertQuery: function(item) {
				var insert = this.Ext.create("Terrasoft.InsertQuery", {
					rootSchemaName: this.entitySchemaName
				});
				insert.setParameterValue("Specification", this.get("MasterRecordId"),
					this.Terrasoft.DataValueType.GUID);
				insert.setParameterValue("Name", item.Name, this.Terrasoft.DataValueType.TEXT);
				insert.setParameterValue(this.get("LookupValueColumnName"), item.Id, this.Terrasoft.DataValueType.GUID);
				return insert;
			},

			/**
			 * ############ ########## ####### ## ######.
			 * @protected
			 * @param {Object} response ##### #######.
			 */
			onRowsInserted: function(response) {
				if (this.validateResponse(response)) {
					this.updateDetail({reloadAll: true});
				}
			},

			/**
			 * ######### ######## ###### #######.
			 * @protected
			 * @param {Object} response ##### #######.
			 * @return {Boolean} False, #### ###### ########## # ########, ##### true.
			 */
			validateResponse: function(response) {
				this.hideBodyMask();
				var isSuccess = response && response.success;
				if (!isSuccess) {
					this.showErrorMessage(response);
				}
				return isSuccess;
			},

			/**
			 * ########## ######### ## ######.
			 * @protected
			 * @param {Object} response ##### #######.
			 */
			showErrorMessage: function(response) {
				var errorMessage = this.Ext.isEmpty(response.errorInfo)
					? response.message
					: ResponseExceptionHelper.GetExceptionMessage(response.errorInfo);
				if (errorMessage) {
					this.showInformationDialog(errorMessage);
				}
			}

		}
	};
});
