define("BankAccountTimelineItemView", ["BaseTimelineItemView"], function() {
	/**
	 * @class Terrasoft.configuration.BankAccountTimelineItemView
	 * BankAccount timeline item view class.
	 */
	Ext.define("Terrasoft.configuration.BankAccountTimelineItemView", {
		extend: "Terrasoft.BaseTimelineItemView",
		alternateClassName: "Terrasoft.BankAccountTimelineItemView",

		// region Methods: Protected

		/**
		 * Returns BankAccount info view config.
		 * @protected
		 * @return {Object} BankAccount info view config.
		 */
		getBankAccountInfoContainerViewConfig: function() {
			return {
				"name": "BankAccountInfoContainer",
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"classes": {
					"wrapClassName": ["timeline-tile-info-container"]
				},
				"items": [
					this.getTextWithLabelContainerViewConfig("Resources.Strings.TypeLabel", "Type"),
					this.getTextWithLabelContainerViewConfig("Resources.Strings.BalanceLabel", "Balance", {
						"labelConverter": "getBalanceWithCurrencyCaption",
						"textValueConverter": "getBalanceFormattedValue"

					}),
					this.getTextWithLabelContainerViewConfig("Resources.Strings.StatusLabel", "Status")
				]
			};
		},

		/**
		 * @inheritdoc Terrasoft.BaseTimelineItemView#getBodyViewConfig
		 * @override
		 */
		getBodyViewConfig: function() {
			var bodyConfig = this.callParent(arguments);
			bodyConfig.items = [
				this.getBankAccountInfoContainerViewConfig()
			];
			return bodyConfig;
		}

		// endregion

	});
});
