define("BaseTextItemViewModel", ["BaseSpecificationItemViewModel"],
	function() {
		/**
		 * @class Terrasoft.BaseTextItemViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseTextItemViewModel", {
			alternateClassName: "Terrasoft.BaseTextItemViewModel",
			extend: "Terrasoft.BaseSpecificationItemViewModel",

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#getEditControlConfig
			 * @overridden
			 */
			getEditControlConfig: function() {
				return {
					"className": "Terrasoft.TextEdit",
					"markerValue": this.getMarkerConfig(),
					"value": {"bindTo": "Value"}
				};
			}

		});

		return Terrasoft.BaseTextItemViewModel;
	});
