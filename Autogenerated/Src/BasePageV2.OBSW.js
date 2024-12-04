define("BasePageV2", [], function() {
		return {
			messages: {

				/**
				 * @message SetForceChangeHistoryState
				 */
				"SetForceChangeHistoryState": {
					mode: this.Terrasoft.MessageMode.BROADCAST,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			attributes: {

				/**
				 * Can change history state manually.
				 * @protected
				 * @type {Boolean}
				 */
				"IsForceChangeHistoryState": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": false
				}

			},
			methods: {

				//region Methods: Protected

				/**
				 * Handles SetForceChangeHistoryState message. Sets IsForceChangeHistoryState property.
				 * @protected
				 * @param {Boolean} value IsForceChangeHistoryState property value.
				 */
				onSetForceChangeHistoryState: function(value) {
					if (this.get("IsProcessMode")) {
						this.set("IsForceChangeHistoryState", value);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePage#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("SetForceChangeHistoryState", this.onSetForceChangeHistoryState, this);
				},

				/**
				 * @inheritdoc Terrasoft.BasePage#getCanChangeHistoryState
				 * @overridden
				 */
				getCanChangeHistoryState: function(options) {
					options = options || {};
					var isForceChangeHistoryState = this.get("IsForceChangeHistoryState");
					if (isForceChangeHistoryState) {
						options.result = isForceChangeHistoryState;
					} else {
						this.callParent(arguments);
					}
				}

				//endregion
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});
