define("ProductConditionFloatItemViewModel", ["SpecInCondition",
	"BaseFloatItemViewModel", "ProductConditionDbMixin"],
	function(SpecInCondition) {
	/**
	 * @class Terrasoft.ProductConditionFloatItemViewModel
	 */
	Ext.define("Terrasoft.configuration.ProductConditionFloatItemViewModel", {
		alternateClassName: "Terrasoft.ProductConditionFloatItemViewModel",
		extend: "Terrasoft.BaseFloatItemViewModel",

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
		valueColumnName: "FloatValue",

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
		 * @overridden
		 */
		getSaveQuery: function() {
			var query = this.getDefSaveQuery();
			query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.FLOAT);
			return query;
		}
	});

	return Terrasoft.ProductConditionFloatItemViewModel;
});
