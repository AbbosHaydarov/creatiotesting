define("BaseFieldRowViewModel", ["LookupUtilities", "LookupQuickAddMixin"], function() {
	/**
	 * @class Terrasoft.configuration.BaseFieldRowViewModel
	 */
	Ext.define("Terrasoft.configuration.BaseFieldRowViewModel", {
		extend: "Terrasoft.BaseViewModel",
		alternateClassName: "Terrasoft.BaseFieldRowViewModel",

		mixins: {
			LookupQuickAddMixin: "Terrasoft.LookupQuickAddMixin"
		},

		//region Properties: Private

		Ext: null,

		Terrasoft: null,

		sandbox: null,

		//endregion

		//region Properties: Protected

		/**
		 * Virtual record characteristic.
		 * @protected
		 * @type {Boolean}
		 */
		isVirtual: false,

		/**
		 * Postfix for lookup columns list column.
		 * @protected
		 * @type {String}
		 */
		lookupColumnListSuffix: "List",

		//endregion

		//region Methods: Private

		/**
		 * Adds validator for specified column.
		 * @protected
		 * @param {String} columnName Column name for validation.
		 * @param {Function} validatorFn Validation function.
		 */
		addColumnValidator: function(columnName, validatorFn) {
			var columnValidationConfig = this.validationConfig[columnName];
			if (this.Ext.isEmpty(columnValidationConfig)) {
				columnValidationConfig = this.validationConfig[columnName] = [];
			}
			columnValidationConfig.push(validatorFn);
		},

		/**
		 * Gets lookup default values query columns.
		 * @private
		 * @param {Array} defaultValues Entity default values array.
		 * @return {Array} Entity lookup default values query columns.
		 */
		getLookupDefaultValuesQueryColumns: function(defaultValues) {
			var queryColumns = [];
			this.Terrasoft.each(defaultValues, function(defaultValue) {
				var queryColumn = this.getLookupDefaultValueQueryColumn(defaultValue);
				if (queryColumn) {
					queryColumns.push(queryColumn);
				}
			}, this);
			return queryColumns;
		},

		/**
		 * Gets lookup default value query column.
		 * @private
		 * @param {Object} value Entity default value.
		 * @return {Object} Entity column lookup value object.
		 */
		getLookupDefaultValueQueryColumn: function(value) {
			var entityColumn = this.findEntityColumn(value.name);
			if (entityColumn && this.Terrasoft.isLookupDataValueType(entityColumn.dataValueType)) {
				return this.Ext.apply({}, value, entityColumn);
			}
		},

		/**
		 * Gets entity lookup default values query.
		 * @private
		 * @param {Array} queryColumns Entity lookup query columns.
		 * @return {Terrasoft.BatchQuery} Entity lookup default values query.
		 */
		getEntityLookupDefaultValuesQuery: function(queryColumns) {
			var query = this.Ext.create("Terrasoft.BatchQuery");
			this.Terrasoft.each(queryColumns, function(queryColumn) {
				query.add(this.getLookupDisplayValueQuery(queryColumn));
			}, this);
			return query;
		},

		/**
		 * Gets lookup query for display value.
		 * @private
		 * @param {Object} config Entity lookup query columns.
		 * @return {Terrasoft.EntitySchemaQuery} Lookup query.
		 */
		getLookupDisplayValueQuery: function(config) {
			var result = this.getLookupQuery(null, config.name, config.isLookup);
			result.enablePrimaryColumnFilter(config.value);
			return result;
		},

		/**
		 * Sets entity lookup query results to entity columns.
		 * @private
		 * @param {Array} queryResults Entity lookup query results.
		 * @param {Array} queryColumns Entity lookup query columns.
		 */
		setConfigDefaultValuesToColumns: function(queryResults, queryColumns) {
			this.Terrasoft.each(queryResults, function(queryResult, index) {
				if (this.Ext.isEmpty(queryResult) || this.Ext.isEmpty(queryResult.rows)) {
					return;
				}
				this.set(queryColumns[index].name, queryResult.rows[0]);
			}, this);
		},

		/**
		 * Sets new value for each lookup list columns. It's necessary because default value, that sets in view
		 * model generator, is the same object for each generated view model.
		 * @private
		 */
		initLookupListColumn: function() {
			var columns = this.columns || {};
			this.Terrasoft.each(columns, function(column) {
				if (column.dataValueType === this.Terrasoft.DataValueType.LOOKUP) {
					var columnName = column.name || column.columnPath;
					var lookupColumnName = columnName + this.lookupColumnListSuffix;
					this.set(lookupColumnName, this.Ext.create("Terrasoft.Collection"));
				}
			}, this);
		},

		//endregion

		//region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#constructor
		 * @overridden
		 */
		constructor: function() {
			this.callParent(arguments);
			this.init();
		},

		/**
		 * Initializes the initial values of the model.
		 * @protected
		 * @virtual
		 * @param {Function} callback The callback function.
		 * @param {Object} scope Scope for the callback function.
		 */
		init: function(callback, scope) {
			this.initLookupListColumn();
			if (this.isNew) {
				this.set("EntityInitilized", false, {
					silent: true
				});
				this.Terrasoft.chain(
					this.setDefaultValues,
					this.setConfigDefaultValues,
					this.setConfigLookupDefaultValues,
					function() {
						this.set("EntityInitilized", true, {
							silent: true
						});
						this.Ext.callback(callback, scope);
					}, this);
			} else {
				this.set("EntityInitilized", true, {
					silent: true
				});
				this.Ext.callback(callback, scope);
			}
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#setDefaultValues
		 * @overridden
		 */
		setDefaultValues: function() {
			this.set(this.primaryColumnName, this.Terrasoft.generateGUID());
			this.callParent(arguments);
		},

		/**
		 * Loads default values to lookup data columns.
		 * @protected
		 * @virtual
		 * @param {Function} callback Callback-function.
		 * @param {Object} scope Execution context.
		 */
		setConfigLookupDefaultValues: function(callback, scope) {
			var defaultValues = this.get("DefaultValues");
			if (Ext.isEmpty(defaultValues)) {
				this.Ext.callback(callback, scope);
				return;
			}
			var queryColumns = this.getLookupDefaultValuesQueryColumns(defaultValues);
			if (queryColumns.length === 0) {
				this.Ext.callback(callback, scope);
				return;
			}
			var query = this.getEntityLookupDefaultValuesQuery(queryColumns);
			query.execute(function(result) {
				if (result && result.success) {
					this.setConfigDefaultValuesToColumns(result.queryResults, queryColumns);
				}
				this.Ext.callback(callback, scope);
			}, this);
		},

		/**
		 * Sets default values to non lookup data columns.
		 * @protected
		 * @virtual
		 * @param {Function} callback Callback-function.
		 * @param {Object} scope Execution context.
		 */
		setConfigDefaultValues: function(callback, scope) {
			var defaultValues = this.get("DefaultValues");
			this.Terrasoft.each(defaultValues, function(defaultValue) {
				var name = defaultValue.name;
				var schemaColumn = this.getColumnByName(name);
				if (schemaColumn && name === this.get("DetailColumnName")) {
					this.set(name, defaultValue);
					return;
				}
				if (schemaColumn && this.Terrasoft.isLookupDataValueType(schemaColumn.dataValueType)) {
					return;
				}
				this.set(name, defaultValue.value);
			}, this);
			this.Ext.callback(callback, scope);
		},

		/**
		 * Event of changing value in LookupEdit.
		 * @protected
		 * @virtual
		 */
		onLookupChange: Ext.emptyFn,

		/**
		 * Open selection page from the directory.
		 * @protected
		 * @param {Object} args Params.
		 * @param {Object} columnName Column name.
		 */
		loadVocabulary: function(args, columnName) {
			var config = this.getLookupPageConfig(args, columnName);
			this.Terrasoft.LookupUtilities.Open({
				"lookupConfig": config,
				"sandbox": this.sandbox,
				"keepAlive": config.keepAlive,
				"lookupModuleId": config.lookupModuleId,
				"lookupPageName": config.lookupPageName
			}, this.onLookupResult, this);
		},

		/**
		 * Event of selecting values from directory.
		 * @protected
		 * @param {Object} args The result of the selection of the module directory.
		 * @param {Terrasoft.Collection} args.selectedRows Collection of selected records.
		 * @param {String} args.columnName Column name which the selection was carried out.
		 */
		onLookupResult: function(args) {
			var columnName = args.columnName;
			var selectedRows = args.selectedRows;
			if (!selectedRows.isEmpty()) {
				this.set(columnName, selectedRows.getByIndex(0));
			}
		},

		/**
		 * Returns is row item visible.
		 * @protected
		 * @return {Boolean} Item visible value.
		 */
		getRowVisible: function() {
			return !this.get("isDeleted");
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
		 * @overridden
		 */
		getSaveQuery: function() {
			if (this.isDeleted) {
				var query = this.getDeleteQuery();
				query.enablePrimaryColumnFilter(this.get(this.primaryColumnName));
				return query;
			} else {
				return this.callParent();
			}
		},

		/**
		 * Sets isDelete property and fire delete event.
		 * @protected
		 */
		deleteItem: function() {
			this.isDeleted = true;
			this.set("isDeleted", true);
			this.fireEvent("change", this, {
				OperationType: "Delete"
			});
		}

		//endregion

	});

	return Terrasoft.BaseFieldRowViewModel;
});
