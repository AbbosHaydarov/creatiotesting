   define("OBSWConsultationPanelMixin", [],
	function() {
		/**
		 * @class Terrasoft.configuration.mixins.OBSWConsultationPanelMixin
		 * Mixin, implements to work with a consultation panel.
		 */
		Ext.define("Terrasoft.configuration.mixins.OBSWConsultationPanelMixin", {
			alternateClassName: "Terrasoft.OBSWConsultationPanelMixin",

			//region Methods: Protected

			/**
			 * Generates tags array for sandbox.
			 * @param {string} sanbox id.
			 */
			getSandboxTags: function(sandboxId) {
				const tags = [sandboxId]
				if(Terrasoft.isAngularHost) {
					tags.push("ViewModule_RightSideBarModule_OBSWModule");
				}
				return tags;
			},
			
			//endregion
		});
		return Terrasoft.OBSWConsultationPanelMixin;
	});
