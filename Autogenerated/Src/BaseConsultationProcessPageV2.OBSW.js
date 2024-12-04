define("BaseConsultationProcessPageV2", ["MaskHelper", "BasePageV2", "CustomProcessPageV2Utilities"],
	function(MaskHelper) {
		return {
			messages: {

				/**
				 * @message CompleteConsultationProcess
				 * Message call closing current consultation process.
				 * @param {Object} config Configuration object.
				 */
				"CompleteConsultationProcess": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				BaseProcessViewModel: "Terrasoft.CustomProcessPageV2Utilities"
			},
			methods: {

				/**
				 * @inheritDoc Terrasoft.Configuration.BasePageV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("CompleteConsultationProcess", this.completeConsultationProcess,
						this, [this.getOBSWConsultationPanelId()]);
				},

				/**
				 * Continues the process.
				 * @protected
				 * @return {Object} Result object.
				 */
				completeConsultationProcess: function() {
					this.set("IsCompleteConsultationProcess", true);
					this.acceptProcessElement(arguments);
					return {
						success: true
					};
				},

				/**
				 * Returns consultation panel identificator.
				 * @protected
				 * @return {String} Consultation panel identificator.
				 */
				getOBSWConsultationPanelId: function() {
					return "ViewModule_RightSideBarModule_OBSWModule_OBSWConsultationPanelSchemaModule";
				},

				/**
				 * @inheritdoc Terrasoft.CustomProcessPageV2Utilities#onCompleteExecution
				 * @overridden
				 */
				onCompleteExecution: function(response) {
					var isCompleteConsultationProcess = this.get("IsCompleteConsultationProcess");
					MaskHelper.HideBodyMask();
					if (response.CompleteExecutionResult <= 0 && !isCompleteConsultationProcess) {
						this.Terrasoft.Router.back();
					}
					if (isCompleteConsultationProcess) {
						this.set("IsCompleteConsultationProcess", false);
					}
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});
