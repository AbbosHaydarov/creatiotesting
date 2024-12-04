define("ProductConditionAxisIntegerItemRangeViewModel", ["SpecTableValue", "BaseIntegerItemRangeViewModel",
	"ProductConditionAxisDbMixin", "ProductConditionDbMixin"],
	function(SpecTableValue) {
		/**
		 * @class Terrasoft.ProductConditionAxisIntegerItemRangeViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionAxisIntegerItemRangeViewModel", {
			alternateClassName: "Terrasoft.ProductConditionAxisIntegerItemRangeViewModel",
			extend: "Terrasoft.BaseIntegerItemRangeViewModel",

			mixins: {
				dbMixin: "Terrasoft.ProductConditionDbMixin",
				axisDbMixin: "Terrasoft.ProductConditionAxisDbMixin"
			},

			/**
			 * @inheritDoc Terrasoft.BaseViewModel#entitySchema
			 * @overridden
			 */
			entitySchema: SpecTableValue,

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
			 * @inheritDoc Terrasoft.BaseItemRangeViewModel#initValues
			 * @overridden
			 */
			initValues: this.Terrasoft.emptyFn,

			/**
			 * @inheritDoc Terrasoft.BaseItemRangeViewModel#getWrapClasses
			 * @overridden
			 */
			getWrapClasses: function() {
				var classes = this.callParent(arguments);
				classes.push("range-values-container");
				return classes;
			},

			/**
			 * @inheritdoc Terrasoft.BaseItemRangeViewModelResources#markerConverter
			 * @overridden
			 */
			markerConverter: function() {
				var displayValue = this.callParent(arguments);
				return this.get("AxisMarkerName") + "-Value-" + displayValue;
			},

			/**
			 * @inheritDoc Terrasoft.BaseViewModel#getSaveQuery
			 * @overridden
			 */
			getSaveQuery: function() {
				var query = this.getSpecTableValueQuery();
				this.modifyRangeQuery(query, this.Terrasoft.DataValueType.INTEGER);
				return query;
			}
		});

		return Terrasoft.ProductConditionAxisIntegerItemRangeViewModel;
	});
