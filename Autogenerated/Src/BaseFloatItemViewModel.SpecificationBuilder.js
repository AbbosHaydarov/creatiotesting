define("BaseFloatItemViewModel", ["BaseSpecificationItemViewModel"],
	function() {
		/**
		 * @class Terrasoft.BaseFloatItemViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseFloatItemViewModel", {
			alternateClassName: "Terrasoft.BaseFloatItemViewModel",
			extend: "Terrasoft.BaseSpecificationItemViewModel",

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#initValues
			 * @overridden
			 */
			initValues: function() {
				this.set("HideItems", true);
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#getReadControlConfig
			 * @overridden
			 */
			getReadControlConfig: function() {
				return {
					"className": "Terrasoft.Label",
					"markerValue": this.getMarkerConfig(),
					"classes": {"labelClass": ["specification-value-label"]},
					"caption": {
						"bindTo": "Value",
						"bindConfig": {
							"converter": this.Terrasoft.getFormattedNumberValue
						}
					}
				};
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#getEditControlConfig
			 * @overridden
			 */
			getEditControlConfig: function() {
				return {
					"className": "Terrasoft.FloatEdit",
					"markerValue": this.getMarkerConfig(),
					"decimalPrecision": 2,
					"value": {"bindTo": "Value"}
				};
			}
		});

		return Terrasoft.BaseFloatItemViewModel;
	});
