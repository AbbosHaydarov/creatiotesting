define("BaseFloatItemRangeViewModel", ["BaseItemRangeViewModel"],
	function() {
		/**
		 * @class Terrasoft.BaseFloatItemRangeViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseFloatItemRangeViewModel", {
			alternateClassName: "Terrasoft.BaseFloatItemRangeViewModel",
			extend: "Terrasoft.BaseItemRangeViewModel",

			/**
			 * @inheritDoc Terrasoft.BaseItemRangeViewModel#dataValueType
			 * @overridden
			 */
			dataValueType: this.Terrasoft.DataValueType.FLOAT,

			/**
			 * @inheritDoc Terrasoft.BaseItemRangeViewModel#getValueEditControlConfig
			 * @overridden
			 * @param {Object} config ###### ############ ######.
			 * @param {String} config.bindTo ######## ######## ########.
			 * @return {Object} ###### ############.
			 */
			getValueEditControlConfig: function(config) {
				return {
					"className": "Terrasoft.FloatEdit",
					"markerValue": this.getMarkerConfig(config),
					"decimalPrecision": 2,
					"value": {"bindTo": config.bindTo}
				};
			}
		});

		return Terrasoft.BaseFloatItemRangeViewModel;
	});
