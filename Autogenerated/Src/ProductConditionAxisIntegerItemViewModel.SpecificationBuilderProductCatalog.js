define("ProductConditionAxisIntegerItemViewModel", ["SpecTableValue", "ProductConditionIntegerItemViewModel",
	"ProductConditionAxisDbMixin"],
	function(SpecTableValue) {
		/**
		 * @class Terrasoft.ProductConditionAxisIntegerItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionAxisIntegerItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionAxisIntegerItemViewModel",
			extend: "Terrasoft.ProductConditionIntegerItemViewModel",

			mixins: {
				dbMixin: "Terrasoft.ProductConditionAxisDbMixin"
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: SpecTableValue,

			/**
			 * @inheritdoc Terrasoft.ProductConditionIntegerItemViewModel#valueColumnName
			 * @overridden
			 */
			valueColumnName: "IntegerValue",

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#markerConverter
			 * @overridden
			 */
			markerConverter: function() {
				var displayValue = this.callParent(arguments);
				return this.get("AxisMarkerName") + "-Value-" + displayValue;
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
			 * @overridden
			 */
			getSaveQuery: function() {
				var query = this.getSpecTableValueQuery();
				query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.INTEGER);
				return query;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#initValues
			 * @overridden
			 */
			initValues: this.Terrasoft.emptyFn
		});

		return Terrasoft.ProductConditionAxisIntegerItemViewModel;
	});
