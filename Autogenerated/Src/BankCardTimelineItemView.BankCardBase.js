define("BankCardTimelineItemView", ["BaseTimelineItemView"], function() {
	/**
	 * @class Terrasoft.configuration.BankCardTimelineItemView
	 * BankCard timeline item view class.
	 */
	Ext.define("Terrasoft.configuration.BankCardTimelineItemView", {
		extend: "Terrasoft.BaseTimelineItemView",
		alternateClassName: "Terrasoft.BankCardTimelineItemView",

		// region Methods: Protected

		/**
		 * Returns BankCard info view config.
		 * @protected
		 * @return {Object} BankCard info view config.
		 */
		getBankCardInfoContainerViewConfig: function() {
			return {
				"name": "BankCardInfoContainer",
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"classes": {
					"wrapClassName": ["timeline-tile-info-container"]
				},
				"items": [
					this.getTextWithLabelContainerViewConfig("Resources.Strings.BankCardTypeLabel", "BankCardType"),
					this.getTextWithLabelContainerViewConfig("Resources.Strings.BankCardCategoryLabel", "BankCardCategory"),
					this.getTextWithLabelContainerViewConfig("Resources.Strings.BankCardStatusLabel", "BankCardStatus")
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
				this.getBankCardInfoContainerViewConfig()
			];
			return bodyConfig;
		}

		// endregion

	});
});
