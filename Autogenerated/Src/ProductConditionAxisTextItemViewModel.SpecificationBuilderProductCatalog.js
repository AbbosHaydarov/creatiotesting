define("ProductConditionAxisTextItemViewModel", ["SpecTableValue", "ProductConditionTextItemViewModel",
	"ProductConditionAxisDbMixin"],
	function(SpecTableValue) {
		/**
		 * @class Terrasoft.ProductConditionAxisTextItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionAxisTextItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionAxisTextItemViewModel",
			extend: "Terrasoft.ProductConditionTextItemViewModel",

			mixins: {
				dbMixin: "Terrasoft.ProductConditionAxisDbMixin"
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: SpecTableValue,

			/**
			 * @inheritdoc Terrasoft.ProductConditionTextItemViewModel#valueColumnName
			 * @overridden
			 */
			valueColumnName: "TextValue",

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
				query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.TEXT);
				return query;
			}

		});

		return Terrasoft.ProductConditionAxisTextItemViewModel;
	});
