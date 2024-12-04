define("BaseIntegerItemViewModel", ["BaseSpecificationItemViewModel"],
	function() {
		/**
		 * @class Terrasoft.BaseIntegerItemViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseIntegerItemViewModel", {
			alternateClassName: "Terrasoft.BaseIntegerItemViewModel",
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
							"converter": this.getIntegerFormattedValue
						}
					}
				};
			},

			/**
			 * ########### ##### ### #####.
			 * @protected
			 * @param {Number} value ########, ####### ########## ###############.
			 * @return {String} ################# ######.
			 */
			getIntegerFormattedValue: function(value) {
				return this.Terrasoft.getFormattedNumberValue(value, {type: this.Terrasoft.DataValueType.INTEGER});
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#getEditControlConfig
			 * @overridden
			 */
			getEditControlConfig: function() {
				return {
					"className": "Terrasoft.IntegerEdit",
					"markerValue": this.getMarkerConfig(),
					"value": {"bindTo": "Value"}
				};
			}
		});

		return Terrasoft.BaseIntegerItemViewModel;
	});
