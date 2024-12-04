define("ProductConditionAxisComboBoxItemViewModel", ["SpecTableValue", "ProductConditionComboBoxItemViewModel",
	"ProductConditionAxisDbMixin"],
	function(SpecTableValue) {
		/**
		 * @class Terrasoft.ProductConditionAxisComboBoxItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionAxisComboBoxItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionAxisComboBoxItemViewModel",
			extend: "Terrasoft.ProductConditionComboBoxItemViewModel",

			mixins: {
				dbMixin: "Terrasoft.ProductConditionAxisDbMixin"
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: SpecTableValue,

			/**
			 * @inheritdoc Terrasoft.ProductConditionComboBoxItemViewModel#valueColumnName
			 * @overridden
			 */
			valueColumnName: "SpecificationListItem",

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
			 * @overridden
			 */
			getSaveQuery: function() {
				var query = this.getSpecTableValueQuery();
				query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.LOOKUP);
				return query;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#markerConverter
			 * @overridden
			 */
			markerConverter: function() {
				var displayValue = this.callParent(arguments);
				return this.get("AxisMarkerName") + "-Value-" + displayValue;
			}

		});
		return Terrasoft.ProductConditionAxisComboBoxItemViewModel;
	});
