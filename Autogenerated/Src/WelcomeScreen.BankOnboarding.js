define("WelcomeScreen", [], function() {
	return {
		methods: {

			/**
			 * @inheritdoc Terrasoft.WelcomeScreen#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.Terrasoft.SysSettings.querySysSettings(["ProductName"], function(values) {
						if (values) {
							var productName = values.ProductName;
							if (!this.Ext.isEmpty(productName)) {
								productName = productName.replace(/&#39;/g, "'");
							}
							this.set("Product", productName);
						}
						callback.call(scope);
					}, this);
				}, this]);
			}
		}
	};
});
