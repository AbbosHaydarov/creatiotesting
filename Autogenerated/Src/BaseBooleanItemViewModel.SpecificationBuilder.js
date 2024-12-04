define("BaseBooleanItemViewModel", ["BaseSpecificationItemViewModel"],
	function() {
		/**
		 * @class Terrasoft.BaseBooleanItemViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseBooleanItemViewModel", {
			alternateClassName: "Terrasoft.BaseBooleanItemViewModel",
			extend: "Terrasoft.BaseSpecificationItemViewModel",

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#getItemViewConfig
			 * @overridden
			 */
			getItemViewConfig: function() {
				return {
					"className": "Terrasoft.SpecificationValue",
					"readControlConfig": this.getReadControlConfig(),
					"editControlConfig": {
						"className": "Terrasoft.Switcher",
						"markerValue": this.getMarkerConfig(),
						"checked": {"bindTo": "Value"}
					},
					"canSwitchMode": false,
					"isReadMode": false,
					"focusAfterRender": true
				};
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#initValues
			 * @overridden
			 */
			initValues: function() {
				if (!this.get("Value")) {
					this.set("Value", false);
				}
			}

		});

		return Terrasoft.BaseBooleanItemViewModel;
	});
