define("FinApplicationTimelineItemView", ["BaseTimelineItemView"], function() {
	/**
	 * @class Terrasoft.configuration.FinApplicationTimelineItemView
	 * FinApplication timeline item view class.
	 */
	Ext.define("Terrasoft.configuration.FinApplicationTimelineItemView", {
		extend: "Terrasoft.BaseTimelineItemView",
		alternateClassName: "Terrasoft.FinApplicationTimelineItemView",

		// region Methods: Protected

		/**
		 * Returns FinApplication info view config.
		 * @protected
		 * @return {Object} FinApplication info view config.
		 */
		getFinApplicationInfoContainerViewConfig: function() {
			return {
				"name": "FinApplicationInfoContainer",
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"classes": {
					"wrapClassName": ["timeline-tile-info-container"]
				},
				"items": [
					this.getTextWithLabelContainerViewConfig("Resources.Strings.ProductLabel", "Product"),
					this.getTextWithLabelContainerViewConfig("Resources.Strings.ProductTypeLabel", "ProductType"),
					this.getTextWithLabelContainerViewConfig("Resources.Strings.StageLabel", "Stage")
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
				this.getFinApplicationInfoContainerViewConfig()
			];
			return bodyConfig;
		}

		// endregion

	});
});
