define("ProductConditionFloatItemRangeViewModel", ["SpecInCondition", "BaseFloatItemRangeViewModel",
	"ProductConditionDbMixin"],
	function(SpecInCondition) {
		/**
		 * @class Terrasoft.ProductConditionFloatItemRangeViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionFloatItemRangeViewModel", {
			alternateClassName: "Terrasoft.ProductConditionFloatItemRangeViewModel",
			extend: "Terrasoft.BaseFloatItemRangeViewModel",

			mixins: {
				dbMixin: "Terrasoft.ProductConditionDbMixin"
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: SpecInCondition,

			/**
			 * @inheritDoc Terrasoft.BaseFloatItemRangeViewModel#minValueColumnName
			 * @overridden
			 */
			minValueColumnName: "MinFloatValue",

			/**
			 * @inheritDoc Terrasoft.BaseFloatItemRangeViewModel#maxValueColumnName
			 * @overridden
			 */
			maxValueColumnName: "MaxFloatValue",

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getSaveQuery
			 * @overridden
			 */
			getSaveQuery: function() {
				return this.getRangeSaveQuery(this.Terrasoft.DataValueType.FLOAT);
			}
		});

		return Terrasoft.ProductConditionFloatItemRangeViewModel;
	});
