define("ProductConditionComboBoxItemViewModel", ["SpecInCondition",
	"BaseComboBoxItemViewModel", "ProductConditionDbMixin"],
	function(SpecInCondition) {
		/**
		 * @class Terrasoft.ProductConditionComboBoxItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionComboBoxItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionComboBoxItemViewModel",
			extend: "Terrasoft.BaseComboBoxItemViewModel",

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
			valueColumnName: "SpecificationListItem",

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
			 * @overridden
			 */
			getSaveQuery: function() {
				var query = this.getDefSaveQuery();
				query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.LOOKUP);
				return query;
			},

			/**
			 * @inheritDoc Terrasoft.BaseComboBoxItemViewModel#prepareList
			 * @overridden
			 */
			prepareList: function() {
				this.fireEvent("change", this, {
					event: "prepareList",
					arguments: arguments
				});
			}
		});

		return Terrasoft.ProductConditionComboBoxItemViewModel;
	});
