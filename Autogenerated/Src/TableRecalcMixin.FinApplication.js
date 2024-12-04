define("TableRecalcMixin", [], function() {
	Ext.define("Terrasoft.configuration.mixins.TableRecalcMixin", {
		alternateClassName: "Terrasoft.TableRecalcMixin",

		//region Fields: Private

		/**
		 * Collection of data for table recalculation.
		 * @private
		 * @type {Terrasoft.Collection}
		 */
		collection: this.Ext.create("Terrasoft.Collection"),

		/**
		 * Name of field in collection item that contains matching condition for X axis value.
		 * @private
		 * @type {String}
		 */
		xFieldName: null,

		/**
		 * Name of field in collection item that contains matching condition for Y axis value.
		 * @private
		 * @type {String}
		 */
		yFieldName: null,

		/**
		 * Name of field in collection item that contains dependent value.
		 * @private
		 * @type {String}
		 */
		dependentValueFieldName: null,

		//endregion

		//region Methods: Protected

		/**
		 * Returns collection of table recalculation data.
		 * @protected
		 * @return {Terrasoft.Collection} Table recalculation collection.
		 */
		getTableRecalcCollection: function() {
			return this.collection;
		},

		/**
		 * Returns name of field in collection item that contains matching condition for X axis value.
		 * @protected
		 * @return {String} String containing field name of X axis matching condition.
		 */
		getXFieldName: function() {
			return this.xFieldName;
		},

		/**
		 * Returns name of field in collection item that contains matching condition for Y axis value.
		 * @protected
		 * @return {String} String containing field name of Y axis matching condition.
		 */
		getYFieldName: function() {
			return this.yFieldName;
		},

		/**
		 * Returns name of field in collection item that contains dependent value.
		 * @protected
		 * @return {String} String containing field name of dependent value.
		 */
		getDependentValueFieldName: function() {
			return this.dependentValueFieldName;
		},

		/**
		 * Sets recalculation collection and field names by specified values.
		 * @protected
		 * @param {Terrasoft.Collection} collection Table recalculation collection.
		 * @param {String} xFieldName Name of field in collection item that contains matching condition for X axis value.
		 * @param {String} yFieldName Name of field in collection item that contains matching condition for Y axis value.
		 * @param {String} dependentValueFieldName Name of field in collection item that contains dependent value.
		 */
		setTableRecalcCollection: function(collection, xFieldName, yFieldName, dependentValueFieldName) {
			this.collection.clear();
			this.collection.loadAll(collection);
			this.xFieldName = xFieldName;
			this.yFieldName = yFieldName;
			this.dependentValueFieldName = dependentValueFieldName;
		},

		/**
		 * Processes table recalculation. Applies specified matching function to passed axis values and both axis
		 * conditions of each item in inner collection. Returns dependent values which has X axis condition matching
		 * one passed axis value and Y axis condition mathicng another passed axis value.
		 * @protected
		 * @param {Object} firstAxisValue Object containing value of one axis.
		 * @param {Object} secondAxisValue Object containing value of another axis.
		 * @param {Function} matchingFunction Function that checks that axis value matchs condition.
		 * @return {Array} Array of dependent values axis conditions of which matches passed values.
		 */
		processTableRecalc: function(firstAxisValue, secondAxisValue, matchingFunction) {
			if (!this.Ext.isFunction(matchingFunction)) {
				return;
			}
			var result = [];
			this.Terrasoft.each(this.collection.getItems(), function(tableRecalcRow) {
				var isMatch =
					(matchingFunction(firstAxisValue, tableRecalcRow[this.xFieldName]) &&
						matchingFunction(secondAxisValue, tableRecalcRow[this.yFieldName])) ||
					(matchingFunction(firstAxisValue, tableRecalcRow[this.yFieldName]) &&
						matchingFunction(secondAxisValue, tableRecalcRow[this.xFieldName]));
				if (isMatch) {
					var dependentValue = tableRecalcRow[this.dependentValueFieldName];
					if (result.indexOf(dependentValue) === -1) {
						result.push(dependentValue);
					}
				}
			}, this);
			return result;
		}

		//endregion

	});
	return Ext.create("Terrasoft.TableRecalcMixin");
});
