define("AxisSpecificationRowViewModel", ["AxisSpecificationRowViewModelResources", "AxisParameterItemViewModel",
	"ProductConditionAxisComboBoxItemViewModel", "ProductConditionAxisFloatItemViewModel",
	"ProductConditionAxisIntegerItemViewModel", "ProductConditionAxisTextItemViewModel",
	"ProductConditionSpecificationRowViewModel", "ProductConditionAxisFloatItemRangeViewModel",
	"ProductConditionAxisIntegerItemRangeViewModel"],
	function(resources) {
	/**
	 * @class Terrasoft.AxisSpecificationRowViewModel
	 */
	Ext.define("Terrasoft.configuration.AxisSpecificationRowViewModel", {
		alternateClassName: "Terrasoft.AxisSpecificationRowViewModel",
		extend: "Terrasoft.ProductConditionSpecificationRowViewModel",

		/**
		 * @inheritdoc Terrasoft.ProductConditionSpecificationRowViewModel#floatItemClassName
		 * @overridden
		 */
		floatItemClassName: "Terrasoft.ProductConditionAxisFloatItemViewModel",

		/**
		 * @inheritdoc Terrasoft.ProductConditionSpecificationRowViewModel#floatItemRangeClassName
		 * @overridden
		 */
		floatItemRangeClassName: "Terrasoft.ProductConditionAxisFloatItemRangeViewModel",

		/**
		 * @inheritdoc Terrasoft.ProductConditionSpecificationRowViewModel#integerItemClassName
		 * @overridden
		 */
		integerItemClassName: "Terrasoft.ProductConditionAxisIntegerItemViewModel",

		/**
		 * @inheritdoc Terrasoft.ProductConditionSpecificationRowViewModel#integerItemRangeClassName
		 * @overridden
		 */
		integerItemRangeClassName: "Terrasoft.ProductConditionAxisIntegerItemRangeViewModel",

		/**
		 * @inheritdoc Terrasoft.ProductConditionSpecificationRowViewModel#comboBoxItemClassName
		 * @overridden
		 */
		comboBoxItemClassName: "Terrasoft.ProductConditionAxisComboBoxItemViewModel",

		/**
		 * @inheritdoc Terrasoft.ProductConditionSpecificationRowViewModel#textItemClassName
		 * @overridden
		 */
		textItemClassName: "Terrasoft.ProductConditionAxisTextItemViewModel",

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#parameterViewModelClassName
		 * @overridden
		*/
		parameterViewModelClassName: "Terrasoft.AxisParameterItemViewModel",

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#constructor
		 * @overridden
		 */
		constructor: function() {
			this.callParent(arguments);
			this.initResourcesValues(resources);
			this.addEvents("Scroll");
		},

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#onToolsClick
		 * @overridden
		 */
		onToolsClick: function() {
			this.callParent(arguments);
			this.fireEvent("Scroll", {scrollRight: this.calculateRightScrollOffset()});
		},

		/**
		 * ######### ###### ###### ############## ###### #########, ########### ## ########## ######### # ######.
		 * @protected
		 * @return {Number} ###### ###### ############## ###### #########.
		 */
		calculateRightScrollOffset: function() {
			return 0;
		},

		/**
		 * ############# ######## ####### ### ######### ###.
		 * @protected
		 * @param {Object} config ###### ############ ### ############# ######.
		 * @return {Object} ################ ##### ############ ### ############# ######.
		 */
		setAxisMarkerName: function(config) {
			var values = config && config.values;
			values.AxisMarkerName = this.get("AxisMarkerName");
		},

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#getParameterViewModelConfig
		 * @overridden
		 */
		getParameterViewModelConfig: function() {
			var config = this.callParent(arguments);
			this.setAxisMarkerName(config);
			return config;
		},

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#getRowItemViewModelConfig
		 * @overridden
		 */
		getRowItemViewModelConfig: function() {
			var config = this.callParent(arguments);
			this.setAxisMarkerName(config);
			return config;
		},

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#setAddButtonVisibleByType
		 * @overridden
		 */
		setAddButtonVisibleByType: function() {
			this.setToolsVisible(true);
		}
	});

	return Terrasoft.AxisSpecificationRowViewModel;
});
