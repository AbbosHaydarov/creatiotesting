define("BaseIntegerItemRangeViewModel", ["BaseItemRangeViewModel"],
	function() {
		/**
		 * @class Terrasoft.BaseIntegerItemRangeViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseIntegerItemRangeViewModel", {
			alternateClassName: "Terrasoft.BaseIntegerItemRangeViewModel",
			extend: "Terrasoft.BaseItemRangeViewModel",

			/**
			 * @inheritDoc Terrasoft.BaseItemRangeViewModel#dataValueType
			 * @overridden
			 */
			dataValueType: this.Terrasoft.DataValueType.INTEGER,

			/**
			 * @inheritDoc Terrasoft.BaseItemRangeViewModel#getValueEditControlConfig
			 * @overridden
			 * @param {Object} config ###### ############ ######.
			 * @param {String} config.bindTo ######## ######## ########.
			 * @return {Object} ###### ############.
			 */
			getValueEditControlConfig: function(config) {
				return {
					"className": "Terrasoft.IntegerEdit",
					"markerValue": this.getMarkerConfig(config),
					"value": {"bindTo": config.bindTo}
				};
			}
		});

		return Terrasoft.BaseIntegerItemRangeViewModel;
	});
