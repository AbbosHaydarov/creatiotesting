define("OpportunityConditionDetail", ["ResponseExceptionHelper", "ConfigurationEnums",
	"OpportunityConditionServiceRequest"],
	function(ResponseExceptionHelper, enums) {
		return {
			entitySchemaName: "OpportunityCondition",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"type": "listed",
						"listedConfig": {
							"name": "DataGridListedConfig",
							"items": [
								{
									"name": "NameListedGridColumn",
									"bindTo": "Name",
									"type": "text",
									"position": {
										"column": 0,
										"colSpan": 24
									}
								}
							]
						},
						"tiledConfig": {
							"name": "DataGridTiledConfig",
							"grid": {
								"columns": 24,
								"rows": 1
							},
							"items": [
								{
									"name": "NameTiledGridColumn",
									"bindTo": "Name",
									"type": "text",
									"position": {
										"row": 1,
										"column": 0,
										"colSpan": 24
									},
									"captionConfig": {
										"visible": false
									}
								}
							]
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			mixins: {
				GridHelper: "Terrasoft.GridHelper"
			},
			methods: {

				/**
				 * @inheritDoc GridUtilitiesV2#addColumnLink
				 * @overridden
				 */
				addColumnLink: function(item, column) {
					var columnPath = column.columnPath;
					if (columnPath === item.primaryDisplayColumnName) {
						return this.addOpenCardColumnLink(item, column);
					} else {
						this.callParent(arguments);
					}
				},

				/**
				 * ######### ######## ###### ####### # #######.
				 * @protected
				 * @param {Object} response ##### #######.
				 */
				validateResponse: function(response) {
					var isSuccess = response && response.success;
					if (!isSuccess) {
						this.hideBodyMask();
						var errorMessage = (this.Ext.isEmpty(response.errorInfo))
							? response.message
							: ResponseExceptionHelper.GetExceptionMessage(response.errorInfo);
						if (errorMessage) {
							this.showInformationDialog(errorMessage);
						}
					}
					return isSuccess;
				},

				/**
				 * ######## ###### ## ########### ####### #######.
				 * @protected
				 * @param {Terrasoft.GUID} copiedRecordId ############# ######, ####### ##########.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ####### ######### ######.
				 */
				executeCopyOpportunityRequest: function(copiedRecordId, callback, scope) {
					var serviceRequest = this.Ext.create("Terrasoft.OpportunityConditionServiceRequest", {
						contractName: "CopyOpportunityCondition",
						sourceEntityId: copiedRecordId
					});
					serviceRequest.execute(function(response) {
						callback.call(scope || this, response);
					});
				},

				/**
				 * @inheritDoc Terrasoft.BaseGridDetail#copyRecord
				 * @overridden
				 */
				copyRecord: function(editPageUId) {
					if (!this.isAnySelected()) {
						return;
					}
					if (!editPageUId) {
						var editPages = this.getEditPages();
						if (editPages.getCount() === 0) {
							return;
						}
						editPageUId = editPages.getByIndex(0).get("Tag");
					}
					var selectedItems = this.getSelectedItems();
					var copiedRecordId = selectedItems[0];
					this.executeCopyOpportunityRequest(copiedRecordId, function(response) {
						if (this.validateResponse(response)) {
							this.loadGridDataRecord(response.copiedRecordId);
							this.openCard(enums.CardStateV2.EDIT, editPageUId, response.copiedRecordId);
						}
					}, this);
				}
			}
		};
	});
