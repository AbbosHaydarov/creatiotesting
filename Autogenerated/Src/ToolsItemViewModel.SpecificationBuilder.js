define("ToolsItemViewModel", [], function() {
	/**
	 * @class Terrasoft.ToolsItemViewModel
	 */
	Ext.define("Terrasoft.configuration.ToolsItemViewModel", {
		alternateClassName: "Terrasoft.ToolsItemViewModel",
		extend: "Terrasoft.BaseViewModel",

		/**
		 * ############ ####### ## ###### ########.
		 * @protected
		 */
		onToolsClick: function() {
			this.fireEvent("change", this, {
				event: "onToolsClick",
				arguments: arguments[3]
			});
		},

		/**
		 * #######, ##### ## ######### ######.
		 * @protected
		 */
		canSave: function() {
			return false;
		}
	});

	return Terrasoft.ToolsItemViewModel;
});
