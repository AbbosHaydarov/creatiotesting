define("DocListInConditionDetailV2", ["ConfigurationEnums", "GridHelper"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "DocListInCondition",
			attributes: {},
			mixins: {GridHelper: "Terrasoft.GridHelper"},
			diff: /**SCHEMA_DIFF*/[
			],/**SCHEMA_DIFF*/
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
				 * ############ ######### # ############# ######## ######.
				 * @param {Terrasoft.MessageBoxButtons} returnCode ####### ###### # #### #########.
				 * @protected
				 */
				onClearDetailMessageCallback: function(returnCode) {
					if (returnCode === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
						var deleteQuery = this.Ext.create("Terrasoft.DeleteQuery", {
							rootSchemaName: "DocListInCondition"
						});
						deleteQuery.filters.addItem(deleteQuery.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "ProductCondition",
							this.get("MasterRecordId")));
						deleteQuery.execute(this.fillDetail, this);
					}
				},

				/**
				 * ######### ####### ####### ## ###### # ####### ##### ######### ########### #####.
				 * @protected
				 */
				checkDetail: function() {
					var gridData = this.getGridData();
					if (!gridData.isEmpty()) {
						this.showConfirmationDialog(this.get("Resources.Strings.ClearDetailMessage"),
							this.onClearDetailMessageCallback,
							[
								this.Terrasoft.MessageBoxButtons.YES.returnCode,
								this.Terrasoft.MessageBoxButtons.NO.returnCode
							]);
					} else {
						this.fillDetail();
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#onCardSaved
				 * @overridden
				 */
				onCardSaved: function() {
					if (this.get("NeedFillDocumentList")) {
						this.fillDetail();
						this.set("NeedFillDocumentList", false);
					} else {
						this.callParent(arguments);
					}
				},

				/**
				 * Execute service method for creating a list of documents.
				 * @protected
				 */
				fillDetail: function() {
					var cardState = this.sandbox.publish("GetCardState", null, [this.sandbox.id]);
					var isNew = (cardState.state === ConfigurationEnums.CardStateV2.ADD ||
						cardState.state === ConfigurationEnums.CardStateV2.COPY);
					if (isNew && this.get("NeedFillDocumentList") !== true) {
						var args = {
							isSilent: true,
							messageTags: [this.sandbox.id]
						};
						this.set("NeedFillDocumentList", true);
						this.sandbox.publish("SaveRecord", args, [this.sandbox.id]);
						return;
					}
					var dataSend = {
						productConditionId:  this.get("MasterRecordId")
					};
					var config = {
						serviceName: "ProductHelperService",
						methodName: "FillDocListInConditionDetail",
						data: dataSend
					};
					this.callService(config, this.onFillDetailCallback, this);
				},

				/**
				 * ######### ###### ##### ########## ######## ############ ##### ##########.
				 * @param {Object} response ##### #######.
				 * @protected
				 */
				onFillDetailCallback: function(response) {
					var result = this.Ext.decode(response.FillDocListInConditionDetailResult);
					var success = result.Success;
					var exceptionMessage = result.ExceptionMessage;
					if (success && this.Ext.isEmpty(exceptionMessage)) {
						this.reloadGridData();
					} else {
						this.showInformationDialog(this.get("Resources.Strings.FillDetailErrorMessage"));
					}
				},

				/**
				 * ######### ######## ############ ##### ##########.
				 * @protected
				 * @param {Object} toolsButtonMenu #### ######.
				 */
				addFillDetailMenuItem: function(toolsButtonMenu) {
					var menuItem = this.getButtonMenuItem({
						Caption: {"bindTo": "Resources.Strings.FillDetailMenuCaption"},
						Click: {"bindTo": "checkDetail"},
						Enabled: true
					});
					toolsButtonMenu.addItem(menuItem);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addToolsButtonMenuItems
				 * @overridden
				 */
				addToolsButtonMenuItems: function(toolsButtonMenu) {
					this.addFillDetailMenuItem(toolsButtonMenu);
					this.callParent(arguments);
				}
			}
		};
	});
