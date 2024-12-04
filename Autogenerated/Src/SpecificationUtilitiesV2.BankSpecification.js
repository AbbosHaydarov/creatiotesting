define("SpecificationUtilitiesV2", [],
	function() {
		Ext.define("Terrasoft.configuration.mixins.SpecificationUtilities", {

			alternateClassName: "Terrasoft.SpecificationUtilities",

			//region Properties: Private

			/**
			 * Object specification schema name mask.
			 * @private
			 * @type {String}
			 */
			specificationInObjectSchemaNameMask: "SpecificationIn{0}",

			//endregion

			//region Methods: Private

			/**
			 * Returns specification in object schema name.
			 * @private
			 * @param {String} entitySchemaName Object entity schema name.
			 * @return {String} Specification in object schema name.
			 */
			getSpecificationInObjectSchemaName: function(entitySchemaName) {
				return this.Ext.String.format(this.specificationInObjectSchemaNameMask, entitySchemaName);
			},

			//endregion

			//region Methods: Protected

			/**
			 * Loads object specification.
			 * @protected
			 * @param {String} objectId Object identifier.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			loadObjectSpecifications: function(objectId, callback, scope) {
				var rootSchemaName = this.getSpecificationInObjectSchemaName(this.loadObjectSpecificationSchemaName);
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: rootSchemaName
				});
				esq.addColumn("Specification");
				esq.filters.add("ObjectFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, this.loadObjectSpecificationSchemaName, objectId));
				esq.getEntityCollection(callback, scope);
			},

			/**
			 * Returns specification in object insert query.
			 * @protected
			 * @param {Terrasoft.BaseViewModel} item Specification.
			 * @return {Terrasoft.InsertQuery} Specification in object insert query.
			 */
			getSpecificationInObjectInsertQuery: function(item) {
				var rootSchemaName = this.getSpecificationInObjectSchemaName(this.entitySchemaName);
				var query = this.Ext.create("Terrasoft.InsertQuery", {
					rootSchemaName: rootSchemaName
				});
				var columnValues = query.columnValues;
				var guidDataValueType = this.Terrasoft.DataValueType.GUID;
				var specification = item.get("Specification");
				specification = this.Ext.isObject(specification) ? specification.value : specification;
				columnValues.setParameterValue(this.entitySchemaName, this.get(this.primaryColumnName), guidDataValueType);
				columnValues.setParameterValue("Specification", specification, guidDataValueType);
				return query;
			},

			/**
			 * Saves specifications.
			 * @protected
			 * @param {Terrasoft.Collection} collection Specifications collection.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			saveSpecifications: function(collection, callback, scope) {
				var batchQuery = this.Ext.create("Terrasoft.BatchQuery");
				collection.each(function(item) {
					batchQuery.add(this.getSpecificationInObjectInsertQuery(item));
				}, this);
				batchQuery.execute(callback, scope);
			},

			/**
			 * Works after initializing object specifications.
			 * @protected
			 * @param {Object} result Request result.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			loadObjectSpecificationsCallback: function(result, callback, scope) {
				if (result.success) {
					this.saveSpecifications(result.collection, callback, scope);
				} else if (result.errorInfo) {
					this.showInformationDialog(result.errorInfo.message);
				}
			},

			//endregion

			//region Methods: Public

			/**
			 * Initializes specifications.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			initSpecifications: function(callback, scope) {
				var objectId = this.get(this.loadObjectSpecificationSchemaName);
				objectId = this.Ext.isObject(objectId) ? objectId.value : objectId;
				if (!this.Ext.isEmpty(objectId)) {
					this.loadObjectSpecifications(objectId, function(result) {
						this.loadObjectSpecificationsCallback(result, callback, scope);
					}, this);
				} else {
					this.Ext.callback(callback, scope);
				}
			}

			//endregion
		});
	});
