define("ProductConditionUtilitiesMixin", [], function() {
	Ext.define("Terrasoft.configuration.mixins.ProductConditionUtilitiesMixin", {
		alternateClassName: "Terrasoft.ProductConditionUtilitiesMixin",

		/**
		 * Get configuration object for product condition validation.
		 */
		getValidationDueDateConfig: Terrasoft.emptyFn,

		/**
		 * Get entity schema query for product condition validation.
		 * @returns {Terrasoft.EntitySchemaQuery} Entity schema query.
		 */
		getValidateConditionsEsq: function() {
			var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: this.entitySchemaName,
				rowCount: 1
			});
			esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
			esq.addColumn("StartDate");
			return esq;
		},

		/**
		 * Add filters to product condition validation esq.
		 * @param esq {Terrasoft.EntitySchemaQuery} Entity schema query.
		 * @param config {Object} Validation config.
		 */
		addValidateConditionsFilters: function(esq, config) {
			esq.filters.addItem(esq.createColumnIsNullFilter("DueDate"));
			if (!this.Ext.isEmpty(config.productId)) {
				esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
					"Product", config.productId, this.Terrasoft.DataValueType.GUID));
			}
			if (!this.Ext.isEmpty(config.productConditionId)) {
				esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.NOT_EQUAL,
					"Id", config.productConditionId, this.Terrasoft.DataValueType.GUID));
			}
		},

		/**
		 * Verifies that all product condition records must have a date of termination.
		 * @param {Function} callback Callback function.
		 * @param {Object} scope The context of the callback function.
		 */
		validateConditionsDueDate: function(callback, scope) {
			var config = this.getValidationDueDateConfig();
			var esq = this.getValidateConditionsEsq();
			this.addValidateConditionsFilters(esq, config);
			esq.getEntityCollection(this.validateConditionsCollection.bind(this, callback, config), this);
		},

		/**
		 * Check response and return validation result.
		 * @param {Function} callback Callback function.
		 * @param config {Object} Validation config.
		 * @param response {Object} ESQ response.
		 */
		validateConditionsCollection: function(callback, config, response) {
			var result = {
				success: true
			};
			if (response.success && response.collection.getCount() > 0) {
				var items = response.collection.getItems();
				if (this.get("DueDate") >= items[0].get("StartDate") ||
					this.Ext.isEmpty(this.get("DueDate"))) {
					result.message = config.message;
					result.success = false;
				}
			}
			callback.call(this, result);
		}
	});
});
