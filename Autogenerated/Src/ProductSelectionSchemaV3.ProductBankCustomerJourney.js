define("ProductSelectionSchemaV3", ["BankProductSelectionPageComponent", "ProductSelectionSchemaMixin"], function() {
	return {
		messages: {
			"NeedHeaderCaption": {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},
			"GetHistoryState": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},
			"UpdatePageHeaderCaption": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		mixins: {
			productSelectionMixin: "Terrasoft.ProductSelectionSchemaMixin"
		},
		methods: {
			
			// region Methods: Public

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
			 * @override
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.initMixin();
					this.Ext.callback(callback, scope);
				}, this]);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#onRender
			 * @override
			 */
			onRender: function() {
				this.callParent(arguments);
				this.initializeProductSelectionHeader();
			},

			/**
			 * @inheritdoc Terrasoft.Configuration.BaseSchemaViewModel#destroy
			 * @override
			 */
			destroy: function() {
				this.mixins.productSelectionMixin.onMixinDestroy.call(this);
				this.callParent(arguments);
			}

			// endregion

		},
		diff: [{
			"operation": "insert",
			"name": "NGComponent",
			"values": {
				"itemType": Terrasoft.ViewItemType.COMPONENT,
				"className": "Terrasoft.BankProductSelectionPageComponent"
			}
		}]
	};
});
