define("ProductConditionAxisFloatItemRangeViewModel", ["SpecTableValue", "BaseFloatItemRangeViewModel",
	"ProductConditionAxisDbMixin", "ProductConditionDbMixin"],
	function(SpecTableValue) {
		/**
		 * @class Terrasoft.ProductConditionAxisFloatItemRangeViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionAxisFloatItemRangeViewModel", {
			alternateClassName: "Terrasoft.ProductConditionAxisFloatItemRangeViewModel",
			extend: "Terrasoft.BaseFloatItemRangeViewModel",

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
				this.modifyRangeQuery(query, this.Terrasoft.DataValueType.FLOAT);
				return query;
			}
		});

		return Terrasoft.ProductConditionAxisFloatItemRangeViewModel;
	});
