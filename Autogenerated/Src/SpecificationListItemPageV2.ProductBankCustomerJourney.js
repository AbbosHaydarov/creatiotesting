define("SpecificationListItemPageV2", ["ConfigurationGridLookupUtilities"], function() {
	return {
		entitySchemaName: "SpecificationListItem",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "LookupValue",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.LookupValueCaption"
					},
					"bindTo": "LookupValue",
					"controlConfig": {
						"prepareList": {
							"bindTo": "onPrepareLookupValues"
						}
					},
					"visible": {
						"bindTo": "Specification",
						"bindConfig": {
							"converter": "visibleBySpecificationLookup"
						}
					},
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 18
					},
					"contentType": Terrasoft.ContentType.ENUM
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {

			/**
			 * ######## ###########, ########## # ##########.
			 * @type {Object}
			 */
			LookupValue: {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				isLookup: true
			},

			/**
			 * ############# ######## ###########, ########## # ##########.
			 * @type {String}
			 */
			LookupValueId: {
				dependencies: [
					{
						columns: ["LookupValue"],
						methodName: "onLookupValueChanged"
					}
				]
			},

			/**
			 * ########.
			 * @type {Object}
			 */
			Specification: {
				lookupListConfig: {
					columns: ["Lookup"]
				}
			},

			/**
			 * ########.
			 * @type {String}
			 */
			Name: {
				dependencies: [
					{
						columns: ["LookupValue"],
						methodName: "onLookupValueChanged"
					}
				]
			}

		},
		mixins: {
			/**
			 * ###### ######### ###### ######### ######## ########### ####### ####.
			 */
			ConfigurationGridLookupUtilities: "Terrasoft.ConfigurationGridLookupUtilities"
		},
		methods: {

			/**
			 * ############ ##### ## ###### LookupValueList.
			 * @protected
			 * @param {Terrasoft.BaseFilter} filter ###### ## #### LookupValue.
			 * @param {Terrasoft.Collection} list ###### ######## ## ###########.
			 */
			onPrepareLookupValues: function(filter, list) {
				this.loadLookupData(filter, list, "LookupValue");
			},

			/**
			 * #########, ###### ### ### ###### ## ########## # ######### - #### ##,
			 * ########## true, ##### false.
			 * @protected
			 * @param {Object} value ######## #########.
			 * @return {Boolean} True, #### ###### ##########, ##### false.
			 */
			visibleBySpecificationLookup: function(value) {
				return !this.Ext.isEmpty(value && value.Lookup);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
			 * @overridden
			 */
			getLookupQuery: function(filterValue, columnName) {
				if (columnName === "LookupValue") {
					var column = this.getColumnByName(columnName);
					column.referenceSchemaName = this.getDefaultValueByName("LookupSchemaName");
				}
				return this.callParent(arguments);
			},

			/**
			 * ############ ####### ######### ####### LookupValue.
			 * @protected
			 */
			onLookupValueChanged: function() {
				var lookup = this.get("LookupValue");
				this.set("LookupValueId", lookup.value);
				this.set("Name", lookup.displayValue);
			},

			/**
			 * @inheritdoc Terrasoft.ConfigurationGridLookupUtilities#getQueryUniqueColumnFilter
			 * @overridden
			 */
			getQueryUniqueColumnFilter: function(columnValue) {
				return this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "Id", columnValue);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#loadEntity
			 * @overridden
			 */
			loadEntity: function(primaryColumnValue, callback, scope) {
				this.callParent([primaryColumnValue, this.loadLookupValue.bind(this, callback, scope), this]);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#copyEntity
			 * @overridden
			 */
			copyEntity: function(primaryColumnValue, callback, scope) {
				var entitySchemaQuery = this.getEntitySchemaQuery();
				entitySchemaQuery.getEntity(primaryColumnValue, function(result) {
					var entity = result.entity;
					if (!entity) {
						throw new Terrasoft.ItemNotFoundException();
					}
					this.setDefaultValues(function() {
						this.setCopyColumnValues(entity);
						this.loadLookupValue(callback, scope);
					}, this);
				}, this);
			},

			/**
			 * ######### ######## ########### ####### LookupValue, #### ######## ###### ## ############.
			 * @protected
			 * @param {Function} callback ####### ######### ######.
			 * @param {Terrasoft.BaseViewModel} scope ######## ####### ######### ######.
			 */
			loadLookupValue: function(callback, scope) {
				if (this.getDefaultValueByName("LookupSchemaName")) {
					this.loadVirtualColumnValues("LookupValue", "LookupValueId", callback, scope);
				} else if (this.Ext.isFunction(callback)) {
					callback.call(scope || this, this);
				}
			}
		}
	};
});
