define("ProductConditionIntegerItemViewModel", ["SpecInCondition",
	"BaseIntegerItemViewModel", "ProductConditionDbMixin"],
	function(SpecInCondition) {
	/**
	 * @class Terrasoft.ProductConditionIntegerItemViewModel
	 */
	Ext.define("Terrasoft.configuration.ProductConditionIntegerItemViewModel", {
		alternateClassName: "Terrasoft.ProductConditionIntegerItemViewModel",
		extend: "Terrasoft.BaseIntegerItemViewModel",

		mixins: {
			dbMixin: "Terrasoft.ProductConditionDbMixin"
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
		 * @overridden
		 */
		entitySchema: SpecInCondition,

		/**
		 * ### ####### ### ########### ########.
		 * @type {String}
		 */
		valueColumnName: "IntegerValue",

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
		 * @overridden
		 */
		getSaveQuery: function() {
			var query = this.getDefSaveQuery();
			query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.INTEGER);
			return query;
		}
	});

	return Terrasoft.ProductConditionIntegerItemViewModel;
});
