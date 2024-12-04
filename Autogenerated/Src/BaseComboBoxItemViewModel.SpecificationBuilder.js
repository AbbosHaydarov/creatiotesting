define("BaseComboBoxItemViewModel", ["BaseComboBoxItemViewModelResources", "BaseSpecificationItemViewModel"],
	function(resources) {
		/**
		 * @class Terrasoft.BaseComboBoxItemViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseComboBoxItemViewModel", {
			alternateClassName: "Terrasoft.BaseComboBoxItemViewModel",
			extend: "Terrasoft.BaseSpecificationItemViewModel",

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#constructor
			 * @overridden
			 */
			constructor: function() {
				this.callParent(arguments);
				this.initResourcesValues(resources);
				if (this.Ext.isEmpty(this.get("ValueList"))) {
					this.set("ValueList", this.Ext.create("Terrasoft.Collection"));
				}
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#getEditControlConfig
			 * @overridden
			 */
			getEditControlConfig: function() {
				return {
					"className": "Terrasoft.ComboBoxEdit",
					"value": {"bindTo": "Value"},
					"list": {"bindTo": "ValueList"},
					"prepareList": {"bindTo": "prepareList"},
					"markerValue": this.getMarkerConfig()
				};
			},

			/**
			 * ######## ######## ###########.
			 * ################ # ###########.
			 * @protected
			 * @abstract
			 * @throws Terrasoft.NotImplementedException
			 * @param {String} value #####, ######### # ##########.
			 * @param {Terrasoft.Collection} list ######### ######## ## ######.
			 */
			prepareList: function() {
				var message = this.get("Resources.Strings.NotImplementedExceptionMessage");
				throw new Terrasoft.NotImplementedException({
					message: this.Ext.String.format(message, "\"prepareList\"", this.$className)
				});
			},

			/**
			 * ######### ValueList ##########.
			 * @protected
			 * @virtual
			 * @throws Terrasoft.NullOrEmptyException
			 * @param {Object} config ###### # ########### ######.
			 * @param {String} config.value #####, ######### # ##########.
			 * @param {Terrasoft.Collection} config.list ######### ######## ## ######.
			 * @param {String} config.schemaName ######## ##### #######.
			 * @param {Array} config.columnNames ###### #### #######, ####### ##### ######## # ######.
			 * @param {Terrasoft.FilterGroup|Terrasoft.CompareFilter} config.filter ######(#), ####### #####
			 * ######## # #######.
			 * @param {Function} callback ####### ######### ######.
			 * @param {Terrasoft.BaseViewModel} scope ######## ####### ######### ######.
			 */
			fillList: function(config, callback, scope) {
				var schemaName = config.schemaName;
				var columnNames = config.columnNames;
				if (this.Ext.isEmpty(schemaName)) {
					var message = this.Ext.String.format(this.get("Resources.Strings.NullOrEmptyArgumentException"),
						schemaName);
					throw new Terrasoft.NullOrEmptyException(message);
				}
				var esq = this.createLookupQuery(config);
				esq.getEntityCollection(function(result) {
					if (result.success) {
						this.lookupQueryCallback(config.list, columnNames, result);
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}
				}, this);
			},

			/**
			 * ######### ###### ## ####### ######## ## schemaName.
			 * @private
			 * @param {Object} config ###### # ########### ######.
			 * @param {String} config.value #####, ######### # ##########.
			 * @param {String} config.schemaName ######## ##### #######.
			 * @param {Array} config.columnNames ###### #### #######, ####### ##### ######## # ######.
			 * @param {Terrasoft.FilterGroup|Terrasoft.CompareFilter} config.filter ######(#), ####### #####
			 * ######## # #######.
			 * @return {Terrasoft.EntitySchemaQuery} ######, ############ ######### ######## ## ###########.
			 */
			createLookupQuery: function(config) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: config.schemaName
				});
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "value");
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "displayValue");
				var columnNames = config.columnNames;
				if (this.Ext.isArray(columnNames)) {
					this.Terrasoft.each(columnNames, function(columnName) {
						if (!esq.columns.contains(columnName)) {
							esq.addColumn(columnName);
						}
					});
				}
				var lookupFilter = esq.createPrimaryDisplayColumnFilterWithParameter(
					this.Terrasoft.SysSettings.lookupFilterType, config.value, this.Terrasoft.DataValueType.TEXT);
				esq.filters.addItem(lookupFilter);
				var filter = config.filter;
				if (!this.Ext.isEmpty(filter)) {
					esq.filters.addItem(filter);
				}
				return esq;
			},

			/**
			 * ######### ###### ########## ## ###########.
			 * @private
			 * @param {Terrasoft.Collection} list ######### ######## ## ######.
			 * @param {Array} columnNames ###### #### #######, ####### ##### ######### #############.
			 * @param {Object} result ##### #######.
			 */
			lookupQueryCallback: function(list, columnNames, result) {
				var objects = {};
				var collection = result.collection;
				collection.each(function(item) {
					var value = item.get("value");
					var displayValue = item.get("displayValue");
					var object = objects[value] = {};
					object.value = value;
					object.displayValue = displayValue;
					if (this.Ext.isArray(columnNames)) {
						this.Terrasoft.each(columnNames, function(columnName) {
							object[columnName] = item.get(columnName);
						});
					}
				}, this);
				list.clear();
				list.loadAll(objects);
			}

		});

		return Terrasoft.BaseComboBoxItemViewModel;
	});
