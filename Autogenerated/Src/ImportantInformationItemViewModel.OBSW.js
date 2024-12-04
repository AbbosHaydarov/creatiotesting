define("ImportantInformationItemViewModel", ["NetworkUtilities", "ModuleUtils",
		"css!ImportantInformationItemViewModel"
	],
	function(NetworkUtilities, ModuleUtils) {
		/**
		 * @class Terrasoft.configuration.ImportantInformationItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ImportantInformationItemViewModel", {
			extend: "Terrasoft.BaseViewModel",
			alternateClassName: "Terrasoft.ImportantInformationItemViewModel",

			//region Fields: Protected

			Ext: null,
			Terrasoft: null,
			sandbox: null,

			//endregion

			//region Methods: Protected

			/**
			 * ######### ######, #### ######## ########.
			 * @protected
			 */
			onNavigateTo: function() {
				var count = this.get("EntityCount");
				var entityId = this.get("EntityId");
				var schemaName = this.get("SchemaName");
				if (count > 1) {
					var moduleStructure = ModuleUtils.getModuleStructureByName(schemaName);
					if (moduleStructure && moduleStructure.hide === "false") {
						var sectionSchema = moduleStructure.sectionSchema;
						var sectionHash = moduleStructure.sectionModule + "/";
						if (sectionSchema) {
							sectionHash += moduleStructure.sectionSchema + "/";
						}
						this.openSectionPage(sectionHash);
					}
				} else if (count === 1 && entityId) {
					this.openEntityPageInChain(schemaName, entityId);
				}
				return false;
			},

			/**
			 * ######### ######## #######.
			 * @protected
			 * @param {String} sectionModule ### ###### ######## #######.
			 */
			openSectionPage: function(sectionModule) {
				this.sandbox.publish("SelectedSideBarItemChanged", sectionModule, ["sectionMenuModule"]);
				this.sandbox.publish("PushHistoryState", {
					hash: sectionModule
				});
			},

			/**
			 * ######### ######## ############## ########.
			 * @protected
			 * @param {String} schemaName ### ##### ######## ########.
			 * @param {Guid} entityId ############# ########.
			 */
			openEntityPageInChain: function(schemaName, entityId) {
				var historyState = this.sandbox.publish("GetHistoryState") || {};
				var config = {
					sandbox: this.sandbox,
					entityId: entityId,
					entitySchemaName: schemaName
				};
				var hash = historyState.hash || {};
				var hashHistoryState = hash.historyState || "";
				if (entityId === hash.recordId || hashHistoryState.indexOf(entityId) > -1) {
					return;
				}
				NetworkUtilities.openEntityPage(config);
			}

			//endregion
		});
		return Terrasoft.ImportantInformationItemViewModel;
	});
