define("ConfigurationOBSWConsultationBlockListGenerator", ["ext-base", "terrasoft", "ViewGeneratorV2", "ContainerList",
		"OBSWConsultationBlockList"
	],
	function(Ext) {
		Ext.define("Terrasoft.configuration.ConfigurationOBSWConsultationBlockListGenerator", {
			extend: "Terrasoft.ViewGenerator",
			alternateClassName: "Terrasoft.ConfigurationOBSWConsultationBlockListGenerator",

			//region Methods: Protected

			/*
			 * ########## ############ ########## OBSWConsultationBlockList.
			 * @protected
			 * @param {Object} config ############, ####### ######## ######## ### ######### OBSWConsultationBlockList.
			 * @return {Object} ############ ########## OBSWConsultationBlockList.
			 */
			generateOBSWConsultationBlockList: function(config) {
				var id = config.name || "OBSWConsultationBlockList";
				var obswConsultationBlockList = {
					className: "Terrasoft.OBSWConsultationBlockList"
				};
				this.applyControlId(obswConsultationBlockList, config, id);
				var serviceProperties = this.getConfigWithoutServiceProperties(config, ["generator"]);
				Ext.apply(obswConsultationBlockList, serviceProperties);
				this.applyControlConfig(obswConsultationBlockList, config);
				return obswConsultationBlockList;
			}

			//endregion

		});

		return Ext.create("Terrasoft.ConfigurationOBSWConsultationBlockListGenerator");
	});
