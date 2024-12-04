define("NBOWidgetMixin", ["NBOWidgetComponent", "css!NBOWidgetMixin"], function() {
	Ext.define("Terrasoft.configuration.mixins.NBOWidgetMixin", {
		alternateClassName: "Terrasoft.NBOWidgetMixin",

		// region Methods: Protected

		/**
		 * Creates state object for product selection.
		 * @returns {Object} State object.
		 */
		createProductSelectionState: function() {
			return {
				nbo: {
					schemaName: this.entitySchemaName,
					recordId: this.$PrimaryColumnValue
				}
			}
		},

		// endregion

		// region Methods: Public

		/**
		 * Initializes widget.
		 */
		initializeNBOWidget: function() {
			this.set("NBOWidgetData", {
				schemaName: this.entitySchemaName,
				recordId: this.$PrimaryColumnValue
			});
		},

		/**
		 * Returns widget visible value.
		 * @returns 
		 */
		isNBOWidgetVisible: function () {
			return this.getIsFeatureEnabled("UseNewProductSelection") && !this.isAddOrCopyMode();
		},

		/**
		 * Handles click on widget.
		 */
		onNBOWidgetClick: function () {
			const sandbox = this.sandbox;
			sandbox.publish("PushHistoryState", {
				hash: "ProductSelectionModuleV3",
				stateObj: this.createProductSelectionState()
			});
		}

		// endregion
	});
});
