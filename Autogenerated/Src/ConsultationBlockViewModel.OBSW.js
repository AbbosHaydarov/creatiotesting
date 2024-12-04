define("ConsultationBlockViewModel", [],
	function() {

		/**
		 * @class Terrasoft.configuration.ConsultationBlockViewModel
		 */
		Ext.define("Terrasoft.configuration.ConsultationBlockViewModel", {
			extend: "Terrasoft.BaseViewModel",
			alternateClassName: "Terrasoft.ConsultationBlockViewModel",

			//region Fields: Protected

			Ext: null,
			Terrasoft: null,
			sandbox: null,

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#constructor
			 * @overridden
			 */
			constructor: function() {
				this.callParent(arguments);
				this.on("change:CurrentFolder", this.onCurrentFolderChange, this);
			},

			/**
			 * ########## ####### ######### ####### ######.
			 * @protected
			 */
			onCurrentFolderChange: function() {
				this.updateBlockCaption();
				this.updateItemsVisible();
				this.updateCloseButtonVisible();
			},

			/**
			 * ######### ######### #####.
			 * @protected
			 */
			updateBlockCaption: function() {
				this.set("BlockCaption", this.getBlockCaption());
			},

			/**
			 * ########## ######### #####.
			 * @protected
			 * @return {String} ######### #####.
			 */
			getBlockCaption: function() {
				var currentFolder = this.get("CurrentFolder");
				var items = this.get("Items");
				if (items.contains(currentFolder)) {
					var item = items.get(currentFolder);
					return (this.get("Name") + " : " + item.get("Name"));
				} else {
					return this.get("Name");
				}
			},

			/**
			 * ######### ######### ###### ####### ######.
			 * @protected
			 */
			updateCloseButtonVisible: function() {
				var currentFolder = this.get("CurrentFolder");
				this.set("CloseButtonVisible", (currentFolder !== ""));
			},

			/**
			 * ######### ######### ### ####### ######.
			 * @protected
			 */
			updateItemsVisible: function() {
				var currentFolder = this.get("CurrentFolder");
				var items = this.get("Items");
				items.each(function(item) {
					item.set("Visible", currentFolder === item.get("ParentId"));
				}, this);
			},

			/**
			 * ########## ##### ## #########.
			 * @protected
			 */
			onCloseButtonClick: function() {
				this.set("CurrentFolder", "");
			}

			//endregion
		});
		return Terrasoft.ConsultationBlockViewModel;
	});
