define("ProductConditionIntegerItemRangeViewModel", ["SpecInCondition", "BaseIntegerItemRangeViewModel",
	"ProductConditionDbMixin"],
	function(SpecInCondition) {
		/**
		 * @class Terrasoft.ProductConditionIntegerItemRangeViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionIntegerItemRangeViewModel", {
			alternateClassName: "Terrasoft.ProductConditionIntegerItemRangeViewModel",
			extend: "Terrasoft.BaseIntegerItemRangeViewModel",

			mixins: {
				dbMixin: "Terrasoft.ProductConditionDbMixin"
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: SpecInCondition,

			/**
			 * @inheritDoc Terrasoft.BaseIntegerItemRangeViewModel#minValueColumnName
			 * @overridden
			 */
			minValueColumnName: "MinIntegerValue",

			/**
			 * @inheritDoc Terrasoft.BaseIntegerItemRangeViewModel#maxValueColumnName
			 * @overridden
			 */
			maxValueColumnName: "MaxIntegerValue",

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
			 * @overridden
			 */
			getSaveQuery: function() {
				return this.getRangeSaveQuery(this.Terrasoft.DataValueType.INTEGER);
			}
		});

		return Terrasoft.ProductConditionIntegerItemRangeViewModel;
	});
