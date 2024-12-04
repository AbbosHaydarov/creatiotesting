define("DocListInFinAppPage", ["AppForm"],
	function(AppForm) {
		return {
			entitySchemaName: "DocListInFinApp",
			details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "AppForm",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"value": {"bindTo": "AppForm"},
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "merge",
					"name": "ParticipantRole",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"enabled": {"bindTo": "ParticipantRoleEnabled"}
					}
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"ParticipantRoleEnabled": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					value: true
				},
				"AppForm": {
					lookupListConfig: {
						columns: ["ParticipantRole"]
					},
					dependencies: [{
						columns: ["AppForm"],
						methodName: "onAppFormChange"
					}]
				}
			},
			methods: {

				//region Methods: protected

				/**
				 * Handles "change" event of the AppForm field.
				 * @protected
				 */
				onAppFormChange: function() {
					var appForm = this.get("AppForm");
					var participantRole = appForm && appForm.ParticipantRole;
					this.set("ParticipantRole", participantRole);
					this.set("ParticipantRoleEnabled", this.Ext.isEmpty(appForm) && this.Ext.isEmpty(participantRole));
					this.initPrintFormValues();
				},

				/**
				 * @inheritdoc Terrasoft.DocListInFinAppPage#getMatchedEntity
				 * @overridden
				 */
				getMatchedEntity: function(sysEntitySchemaUId) {
					var entityId;
					if (sysEntitySchemaUId === AppForm.uId) {
						entityId = this.get("AppForm");
					} else {
						entityId = this.callParent(arguments);
					}
					return entityId;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					if (this.isNewMode() && this.get("AppForm")) {
						this.onAppFormChange();
					}
				}

				//endregion

			}
		};
	});
