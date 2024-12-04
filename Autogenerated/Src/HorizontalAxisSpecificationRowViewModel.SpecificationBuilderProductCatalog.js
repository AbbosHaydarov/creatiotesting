define("HorizontalAxisSpecificationRowViewModel", ["AxisSpecificationRowViewModel"],
	function() {
		/**
		 * @class Terrasoft.HorizontalAxisSpecificationRowViewModel
		 */
		Ext.define("Terrasoft.configuration.HorizontalAxisSpecificationRowViewModel", {
			alternateClassName: "Terrasoft.HorizontalAxisSpecificationRowViewModel",
			extend: "Terrasoft.AxisSpecificationRowViewModel",

			/**
			 * ###### ######## ####### (px).
			 * @type {Number}
			 */
			columnWidth: 250,

			/**
			 * @inheritdoc Terrasoft.AxisSpecificationRowViewModel#calculateRightScrollOffset
			 * @overridden
			 */
			calculateRightScrollOffset: function() {
				var items = this.getRowValuesCollection();
				var itemsCount = items.getCount();
				return itemsCount * this.columnWidth;
			}
		});

		return Terrasoft.HorizontalAxisSpecificationRowViewModel;
	});
