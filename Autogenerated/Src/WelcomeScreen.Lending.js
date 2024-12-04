define("WelcomeScreen", [], function() {
	return {
		methods: {

			/**
			 * @inheritdoc WelcomeScreen#setProduct
			 * @overridden
			 */
			setProduct: function(productName) {
				if (productName) {
					productName = this.Ext.String.htmlDecode(productName);
				}
				this.set("Product", productName);
			}

		}
	};
});
