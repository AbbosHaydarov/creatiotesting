define("BankCardSectionV2", ["GridUtilitiesV2"],
	function() {
		return {
			entitySchemaName: "BankCard",
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * ############# ######## ############## ########### ####### ### ####### "#####"
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1075);
					this.callParent(arguments);
				}
			}
		};
	});
