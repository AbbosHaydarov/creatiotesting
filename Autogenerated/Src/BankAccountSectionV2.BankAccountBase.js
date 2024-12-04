define("BankAccountSectionV2", ["GridUtilitiesV2"], function() {
	return {
		entitySchemaName: "BankAccount",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		methods: {
			/**
			 * ############# ######## ############## ########### ####### ### ####### "#####"
			 * @overridden
			 */
			initContextHelp: function() {
				this.set("ContextHelpId", 1077);
				this.callParent(arguments);
			}
		}
	};
});
