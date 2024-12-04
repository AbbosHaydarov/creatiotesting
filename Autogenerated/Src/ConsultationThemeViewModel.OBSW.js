define("ConsultationThemeViewModel", ["ProcessModuleUtilities", "ConfigurationConstants"],
	function(ProcessModuleUtilities, ConfigurationConstants) {
		/**
		 * @class Terrasoft.configuration.ConsultationThemeViewModel
		 */
		Ext.define("Terrasoft.configuration.ConsultationThemeViewModel", {
			extend: "Terrasoft.BaseViewModel",
			alternateClassName: "Terrasoft.ConsultationThemeViewModel",

			//region Fields: Protected

			Ext: null,
			Terrasoft: null,
			sandbox: null,

			//endregion

			//region Methods: Protected

			/**
			 * Generates the parameters for the start of the process.
			 * @protected
			 * @param {Guid} processId Process identificator.
			 * @return {Object} Options to start the process.
			 */
			getProcessExecuteConfig: function(processId) {
				var config = {
					sysProcessId: processId,
					parameters: {
						CaseId: this.get("CaseId"),
						ContactId: this.get("ContactId"),
						ConsultationThemeId: this.get("Id")
					}
				};
				return config;
			},

			/**
			 * Handler click on the link, starts the process.
			 * @protected
			 */
			onItemClick: function() {
				var processSchemaId = this.get("ProcessSchemaId");
				if (!processSchemaId) {
					return false;
				}
				this.sandbox.publish("SetForceChangeHistoryState", true);
				this.sandbox.publish("CompleteConsultationProcess", null, [this.sandbox.id]);
				this.executeConsultationProcess();
				return false;
			},

			/**
			 * Executes consultation process.
			 * @protected
			 */
			executeConsultationProcess: function() {
				var processSchemaId = this.get("ProcessSchemaId");
				if (this.isProcessMode()) {
					this.replaceHistoryState();
				}
				ProcessModuleUtilities.executeProcess(this.getProcessExecuteConfig(processSchemaId));
			},

			/**
			 * Checks for the process mode.
			 * protected
			 * @return {Boolean} Result of checking.
			 */
			isProcessMode: function() {
				var currentState = this.sandbox.publish("GetHistoryState") || {};
				var hash = currentState.hash || {};
				var hashHistoryState = hash.historyState || "";
				return (!Ext.isEmpty(hashHistoryState.match("ProcessCardModuleV2/?")));
			},

			/**
			 * Replaces history state.
			 * @protected
			 */
			replaceHistoryState: function() {
				this.sandbox.publish("ReplaceHistoryState", {
					pageTitle: null,
					hash: this.getIntroPagePath(),
					silent: true
				});
			},

			/**
			 * Returns intro page path.
			 * @protected
			 * @return {String} Intro page path.
			 */
			getIntroPagePath: function() {
				var defaultIntroPageName = this.Terrasoft.configuration.defaultIntroPageName;
				var defaultHomeModule = ConfigurationConstants.DefaultHomeModule;
				return this.Terrasoft.combinePath(defaultHomeModule, defaultIntroPageName);
			}

			//endregion
		});
		return Terrasoft.ConsultationThemeViewModel;
	});
