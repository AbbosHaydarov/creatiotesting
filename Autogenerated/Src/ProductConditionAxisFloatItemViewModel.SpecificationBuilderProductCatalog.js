define("ProductConditionAxisFloatItemViewModel", ["SpecTableValue", "ProductConditionFloatItemViewModel",
	"ProductConditionAxisDbMixin"],
	function(SpecTableValue) {
		/**
		 * @class Terrasoft.ProductConditionAxisFloatItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionAxisFloatItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionAxisFloatItemViewModel",
			extend: "Terrasoft.ProductConditionFloatItemViewModel",

			mixins: {
				dbMixin: "Terrasoft.ProductConditionAxisDbMixin"
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: SpecTableValue,

			/**
			 * @inheritdoc Terrasoft.ProductConditionFloatItemViewModel#valueColumnName
			 * @overridden
			 */
			valueColumnName: "FloatValue",

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
				query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.FLOAT);
				return query;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#initValues
			 * @overridden
			 */
			initValues: this.Terrasoft.emptyFn
		});

		return Terrasoft.ProductConditionAxisFloatItemViewModel;
	});
