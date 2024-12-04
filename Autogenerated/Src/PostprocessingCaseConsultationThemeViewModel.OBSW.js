define("PostprocessingCaseConsultationThemeViewModel", ["ext-base", "terrasoft", "CaseConsultationTheme"],
	function(Ext, Terrasoft, CaseConsultationTheme) {
		/**
		 * @class Terrasoft.configuration.PostprocessingCaseConsultationThemeViewModel
		 */
		Ext.define("Terrasoft.configuration.PostprocessingCaseConsultationThemeViewModel", {
			extend: "Terrasoft.BaseViewModel",
			alternateClassName: "Terrasoft.PostprocessingCaseConsultationThemeViewModel",

			//region Fields: Protected

			/**
			 * Suffix list of reference fields.
			 * @protected
			 * @type {String}
			 */
			lookupColumnListSuffix: "List",

			/**
			 * Link to the root system of the essence.
			 * @protected
			 * @type {Object}
			 */
			entitySchema: CaseConsultationTheme,

			//endregion

			//region Methods: Private

			_clearQueries: function() {
				var entityDataModel = this.dataModelCollection.findPrimary();
				if (!entityDataModel) { return; }
				entityDataModel._insertQuery = null;
				entityDataModel._updateQuery = null;
				entityDataModel._deleteQuery = null;
			},

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#constructor
			 * @override
			 */
			constructor: function() {
				this.callParent(arguments);
				this.addColumnsType();
				this.addColumnsPath();
				this.addLookupList();
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
			 * @override
			 */
			getLookupQuery: function(filterValue, columnName) {
				var esq = this.callParent(arguments);
				if (columnName === "Theme") {
					esq.addColumn("Block");
					esq.addColumn("Parent");
					esq.filters.add("IsFolderFilter", Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"IsFolder", false));
					esq.filters.add("UseInOBSWFilter", Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Block.UseInOBSW", true));
				}
				return esq;
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#onLookupDataLoaded
			 * @override
			 */
			onLookupDataLoaded: function(config) {
				this.callParent(arguments);
				if (config && config.columnName === "Theme" && config.objects) {
					var objects = config.objects;
					for (var property in objects) {
						if (objects.hasOwnProperty(property)) {
							var object = objects[property];
							this.setThemeDisplayValue(object);
						}
					}
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#onLookupDataLoaded
			 * @override
			 */
			loadFromColumnValues: function(values) {
				if (values && Ext.isObject(values.Theme)) {
					var block, parent;
					var blockPropertyName = "Theme.Block";
					var parentPropertyName = "Theme.Parent";
					if (values.hasOwnProperty(blockPropertyName)) {
						block = values[blockPropertyName];
					}
					if (values.hasOwnProperty(parentPropertyName)) {
						parent = values[parentPropertyName];
					}
					var config = {
						Block: block,
						Parent: parent,
						displayValue: values.Theme.displayValue
					};
					this.setThemeDisplayValue(config);
					values.Theme.displayValue = config.displayValue;
				}
				this.callParent(arguments);
			},

			/**
			 * Sets theme display value.
			 * @protected
			 * @param {Object} config Configuration object.
			 */
			setThemeDisplayValue: function(config) {
				config = config || {};
				var blockName = Ext.isObject(config.Block) ? config.Block.displayValue : "";
				var parentName = Ext.isObject(config.Parent) ? config.Parent.displayValue : "";
				var displayValue = config.displayValue;
				if (parentName) {
					displayValue = Ext.String.format("{0} / {1}", parentName, displayValue);
				}
				if (blockName) {
					displayValue = Ext.String.format("{0} / {1}", blockName, displayValue);
				}
				config.displayValue = displayValue;
			},

			/**
			 * Adds lists for lookup fields.
			 * @protected
			 */
			addLookupList: function() {
				Terrasoft.each(this.columns, function(column, columnName) {
					if (column.dataValueType === Terrasoft.DataValueType.LOOKUP) {
						var lookupColumnName = columnName + this.lookupColumnListSuffix;
						this.set(lookupColumnName, new Terrasoft.Collection());
						delete this.changedValues[lookupColumnName];
					}
				}, this);
			},

			/**
			 * Adds columns type.
			 * @protected
			 */
			addColumnsType: function() {
				var defaultConfig = {
					Id: {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN
					},
					Theme: {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN
					},
					Result: {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN
					},
					Comment: {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN
					},
					Case: {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN
					},
					DateTimeStart: {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN
					},
					DateTimeEnd: {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN
					}
				};
				this.columns = Ext.Object.merge(defaultConfig, this.columns);
			},

			/**
			 * Adds columns path.
			 * @protected
			 */
			addColumnsPath: function() {
				var defaultConfig = {
					Id: {
						columnPath: "Id"
					},
					Theme: {
						columnPath: "Theme"
					},
					Result: {
						columnPath: "Result"
					},
					Comment: {
						columnPath: "Comment"
					},
					Case: {
						columnPath: "Case"
					},
					DateTimeStart: {
						columnPath: "DateTimeStart"
					},
					DateTimeEnd: {
						columnPath: "DateTimeEnd"
					}
				};
				this.columns = Ext.Object.merge(defaultConfig, this.columns);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
			 * @override
			 */
			getSaveQuery: function() {
				this._clearQueries();
				return this.callParent(arguments);
			}

			//endregion

		});

		return Terrasoft.PostprocessingCaseConsultationThemeViewModel;
	});
