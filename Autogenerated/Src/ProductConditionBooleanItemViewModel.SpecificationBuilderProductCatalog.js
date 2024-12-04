define("ProductConditionBooleanItemViewModel", ["SpecInCondition",
	"BaseBooleanItemViewModel", "ProductConditionDbMixin"],
	function(SpecInCondition) {
	/**
	 * @class Terrasoft.ProductConditionBooleanItemViewModel
	 */
	Ext.define("Terrasoft.configuration.ProductConditionBooleanItemViewModel", {
		alternateClassName: "Terrasoft.ProductConditionBooleanItemViewModel",
		extend: "Terrasoft.BaseBooleanItemViewModel",

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
		valueColumnName: "BooleanValue",

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
		 * @overridden
		 */
		getSaveQuery: function() {
			var query = this.getDefSaveQuery();
			query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.BOOLEAN);
			return query;
		}
	});

	return Terrasoft.ProductConditionBooleanItemViewModel;
});
