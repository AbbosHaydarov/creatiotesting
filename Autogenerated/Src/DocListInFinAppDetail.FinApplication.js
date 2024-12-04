define("DocListInFinAppDetail", ["GridHelper"],
	function() {
		return {
			entitySchemaName: "DocListInFinApp",
			attributes: {
				/**
				 * Flag that indicates that card containing this detail needs a filling of this detail after saving.
				 */
				"NeedFillDocumentList": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			mixins: {
				GridHelper: "Terrasoft.GridHelper"
			},
			diff: /**SCHEMA_DIFF*/ [],
			/**SCHEMA_DIFF*/
			methods: {

				//region Methods: Private

				/**
				 * Adds action "Generate package" to detail menu button.
				 * @private
				 * @param {Object} toolsButtonMenu Detail menu button.
				 */
				addFillDetailMenuItem: function(toolsButtonMenu) {
					var menuItem = this.getButtonMenuItem({
						Caption: {
							"bindTo": "Resources.Strings.FillDetailMenuCaption"
						},
						Click: {
							"bindTo": "fillDetail"
						},
						Enabled: true
					});
					toolsButtonMenu.addItem(menuItem);
				},

				/**
				 * Fills details by records from active condition of selected product.
				 * @private
				 */
				fillDetail: function() {
					var isNewCard = this.getIsCardNewRecordState();
					var isCardChanged = this.getIsCardChanged();
					var isNeedSave = (isNewCard || isCardChanged);
					if (isNeedSave && this.get("NeedFillDocumentList") !== true) {
						this.saveWithFillingDocList();
					} else {
						var config = this.getFillDetailServiceConfig();
						if (this.Terrasoft.isEmptyObject(config)) {
							this.showInformationDialog(this.get("Resources.Strings.FillDetailErrorMessage"));
						} else {
							this.showBodyMask();
							this.callService(config, this.onFillDetailCallback, this);
						}
					}
				},

				/**
				 * Sets 'NeedFillDocumentList' property to true and saves page containing detail silently.
				 * @private
				 */
				saveWithFillingDocList: function() {
					var args = {
						isSilent: true,
						messageTags: [this.sandbox.id]
					};
					this.set("NeedFillDocumentList", true);
					this.sandbox.publish("SaveRecord", args, [this.sandbox.id]);
				},

				/**
				 * Processes the result of fillDetail function.
				 * @private
				 * @param {Object} result Server response with method result.
				 */
				onFillDetailCallback: function(result) {
					this.hideBodyMask();
					var exceptionMessage = result.errorInfo || {};
					exceptionMessage = exceptionMessage.message;
					if (result.success && this.Ext.isEmpty(exceptionMessage)) {
						this.reloadGridData();
					} else {
						var message = this.Ext.isEmpty(exceptionMessage)
							? this.get("Resources.Strings.FillDetailErrorMessage")
							: exceptionMessage;
						this.showInformationDialog(message);
					}
				},

				//endregion

				//region Methods: Protected

				/**
				 * Creates config for calling service for filling detail.
				 * @protected
				 * @return {Object} Config for calling the service.
				 */
				getFillDetailServiceConfig: function() {
					var data = {
						finApplicationId: this.get("MasterRecordId")
					};
					var config = {
						serviceName: "DocListHelperService",
						methodName: "FillDocListInFinApplication",
						data: data
					};
					return config;
				},

				/**
				 * @inheritdoc GridUtilitiesV2#addColumnLink
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
				 * @inheritdoc Terrasoft.BaseDetailV2#initDetailOptions
				 * @overridden
				 */
				initDetailOptions: function() {
					this.set("IsDetailCollapsed", false);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addToolsButtonMenuItems
				 * @overridden
				 */
				addToolsButtonMenuItems: function(toolsButtonMenu) {
					this.addFillDetailMenuItem(toolsButtonMenu);
					this.callParent(arguments);
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
				}

				//endregion

			}
		};
	});
