define("ProductConditionTextItemViewModel", ["SpecInCondition",
	"BaseTextItemViewModel", "ProductConditionDbMixin"],
	function(SpecInCondition) {
		/**
		 * @class Terrasoft.ProductCatalogTextItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionTextItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionTextItemViewModel",
			extend: "Terrasoft.BaseTextItemViewModel",

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
			valueColumnName: "TextValue",

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
			 * @overridden
			 */
			getSaveQuery: function() {
				var query = this.getDefSaveQuery();
				query.setParameterValue(this.valueColumnName, this.get("Value"), this.Terrasoft.DataValueType.TEXT);
				return query;
			}
		});

		return Terrasoft.ProductConditionTextItemViewModel;
	});
