define("WelcomeScreen", [], function() {
	return {
		methods: {
			/**
			 * ############## ######### ######## ######
			 * @protected
			 * @overriden
			 * @param {Function} callback ####### ######### ######
			 * @param {Object} scope ######## ##########
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					var sysSettingsNameArray = ["ProductName"];
					this.Terrasoft.SysSettings.querySysSettings(sysSettingsNameArray, function(values) {
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
