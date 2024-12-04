define("AppFormObligationRowViewModel", ["ProductBankConstants", "AppFormObligationRowViewModelResources",
	"BaseFieldRowViewModel"], function(ProductBankConstants, resources) {
	/**
	 * @class Terrasoft.configuration.AppFormObligationRowViewModel
	 */
	Ext.define("Terrasoft.configuration.AppFormObligationRowViewModel", {
		extend: "Terrasoft.BaseFieldRowViewModel",
		alternateClassName: "Terrasoft.AppFormObligationRowViewModel",

		//region Methods: Protected

		/**
		 * Handles Type field change.
		 * @protected
		 */
		onTypeChange: function() {
			var type = this.get("Type");
			if (type && type.value === ProductBankConstants.AppFormObligationType.CREDIT) {
				this.set("AmountCaption", resources.localizableStrings.MonthlyAmountPlaceholderCaption);
			} else {
				this.set("AmountCaption", resources.localizableStrings.AmountPlaceholderCaption);
			}
		},

		/**
		 * Initialize subscribe for model attributes events.
		 * @protected
		 */
		subscribeForColumnEvents: function() {
			this.subscribeOnColumnChange("Type", this.onTypeChange);
		},

		/**
		 * Unsubscribe handlers from event model attributes.
		 * @protected
		 */
		unsubscribeForColumnEvents: function() {
			this.unsubscribeOnColumnChange("Type", this.onTypeChange);
		},

		/**
		 * Initialize fields captions.
		 * @protected
		 */
		initFieldsCaptions: function() {
			var amountColumn = this.getColumnByName("Amount") || {};
			var expirationDateColumn = this.getColumnByName("ExpirationDate") || {};
			this.set("AmountCaption", amountColumn.caption);
			this.set("ExpirationDateCaption", expirationDateColumn.caption);
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			this.subscribeForColumnEvents();
			this.initFieldsCaptions();
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#destroy
		 * @overridden
		 */
		destroy: function() {
			this.unsubscribeForColumnEvents();
			this.callParent(arguments);
		}

		//endregion

	});

	return Terrasoft.AppFormObligationRowViewModel;
});
