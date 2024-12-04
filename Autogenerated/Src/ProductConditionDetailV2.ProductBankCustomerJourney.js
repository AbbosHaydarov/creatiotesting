define("ProductConditionDetailV2", ["ConfigurationEnums", "RightUtilities",
		"GridHelper", "ProductConditionUtilitiesMixin"], function(configurationEnums, rightUtilities) {
	return {
		entitySchemaName: "ProductCondition",
		mixins: {
			GridHelper: "Terrasoft.GridHelper",
			ProductConditionUtilitiesMixin: "Terrasoft.ProductConditionUtilitiesMixin"
		},
		methods: {

			// region Methods: Protected

			/**
			 * @inheritdoc ProductConditionUtilitiesMixin#getValidationDueDateConfig
			 * @override
			 */
			getValidationDueDateConfig: function() {
				return {
					message: this.get("Resources.Strings.EmptyDueDateInOtherConditionsMessage"),
					productId: this.$MasterRecordId
				};
			},

			/**
			 * @inheritdoc GridUtilitiesV2#getGridDataColumns
			 * @override
			 */
			getGridDataColumns: function() {
				var config = this.callParent(arguments);
				config.StartDate = {path: "StartDate"};
				config.DueDate = {path: "DueDate"};
				return config;
			},

			/**
			 * @inheritdoc GridUtilitiesV2#addColumnLink
			 * @override
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
			 * @inheritdoc BaseGridDetailV2#init
			 * @override
			 * @protected
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.initializeSchemaOperationRights(callback, scope);
				}, this]);
			},

			/**
			 * Initializes schema operation rights.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope scope.
			 */
			initializeSchemaOperationRights: function(callback, scope) {
				rightUtilities.getSchemaOperationRightLevel(this.entitySchemaName, function(rightLevel) {
					this.set("SchemaOperationRights", rightLevel);
					this.Ext.callback(callback, scope);
				}, this);
			},

			/**
			 * Get config with parameters for copy service.
			 * @protected
			 * @return {Object} with parameters for copying.
			 */
			getCopyRecordConfig: function() {
				return {
					serviceName: "HierarchyDataCopyingService",
					methodName: "CreateRecordCopy",
					data: {
						schemaName: this.entitySchemaName,
						recordId: this.$ActiveRow
					},
					scope: this
				};
			},

			/**
			 * Call service that creates records copy.
			 * @protected
			 */
			callCopyRecordService: function() {
				this.showBodyMask();
				var config = this.getCopyRecordConfig();
				this.callService(config, this.copyRecordServiceCallback, this);
			},

			/**
			 * @inheritdoc BaseGridDetailV2#getOpenCardConfig
			 * @override
			 * @protected
			 */
			getOpenCardConfig: function(operation) {
				var config = this.callParent(arguments);
				var defaultValues = config.defaultValues;
				var isCopiedValue = this.Terrasoft.findItem(defaultValues, {name: "IsCopied"});
				var isCopiedValueExist = isCopiedValue && isCopiedValue.item;
				if (operation === configurationEnums.CardStateV2.COPY) {
					config.operation = configurationEnums.CardStateV2.EDIT;
					if (!isCopiedValueExist) {
						defaultValues.push({
							name: "IsCopied",
							value: true
						});
					}
				} else {
					if (isCopiedValueExist) {
						defaultValues = defaultValues.splice(isCopiedValue.index, 1);
					}
				}
				return config;
			},

			/**
			 * Extract error message from response.
			 * @param {Object} response Response from service.
			 * @protected
			 */
			extractErrorMessage: function(response) {
				var errorMessageText;
				errorMessageText = response.errorInfo && response.errorInfo.message;
				return !errorMessageText ? this.get("Resources.Strings.CopyServiceErrorMessage") : errorMessageText;
			},

			/**
			 * Open product condition card if copying was succesful.
			 * @param {Object} response Response from service.
			 * @protected
			 */
			copyRecordServiceCallback: function(response) {
				response = response || {};
				response = response.CreateRecordCopyResult || {};
				this.hideBodyMask();
				if (!response.success) {
					var errorMessage = this.extractErrorMessage(response);
					this.showInformationDialog(errorMessage);
					return;
				}
				const copiedRecordId = response.recordId;
				this.openCard(configurationEnums.CardStateV2.COPY, this.Terrasoft.GUID_EMPTY, copiedRecordId);
			},

			/**
			 * Checks is can copy record.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope scope.
			 */
			isCanCopyRecord: function(callback, scope) {
				rightUtilities.getSchemaRecordRightLevel(this.entitySchemaName, this.$ActiveRow, function(rights) {
					this.isCanCopyRecordCallback(rights, callback, scope);
				}, this);
			},

			/**
			 * Proccess rights service answer, an return if can copy record.
			 * @param {*} recordRights Record rights.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope scope.
			 */
			isCanCopyRecordCallback: function(recordRights, callback, scope) {
				var schemaOperationRights = this.$SchemaOperationRights;
				var isCan = rightUtilities.canSchemaReadData(schemaOperationRights) &&
					rightUtilities.canAppendSchemaData(schemaOperationRights) &&
					rightUtilities.isSchemaRecordCanReadRightConverter(recordRights);
				this.Ext.callback(callback, scope, [isCan]);
			},

			/**
			 * Get menu item if feature "CopyProduct" is enabled.
			 * @return {Object} whether the feature was enabled and menu item was defined.
			 * @override
			 */
			getCopyRecordMenuItem: function() {
				if (this.getIsFeatureEnabled("CopyProduct")) {
					return this.callParent();
				}
			},

			/**
			 * @inheritdoc BaseGridDetailV2#copyRecord
			 * @override
			 */
			copyRecord: function() {
				this.isCanCopyRecord(function(isCan) {
					if (!isCan) {
						var denyMessage = this.get("Resources.Strings.RecordRightsErrorMessage");
						this.showInformationDialog(denyMessage);
						return;
					}
					this.validateConditionsDueDate(this.validateConditionsDueDateCallback, this);
				}, this);
			},

			/**
			 * Callback for DueDate column validation.
			 * @param {Object} result Result of validation.
			 * @param {Boolean} result.success Is validation passed.
			 * @param {String} result.message Message to display if validation is not passed.
			 * @protected
			 */
			validateConditionsDueDateCallback: function(result) {
				if (result.success) {
					this.callCopyRecordService();
					return;
				}
				this.showInformationDialog(result.message);
			},

			/**
			 * @inheritdoc GridUtilitiesV2#prepareResponseCollection
			 * @override
			 */
			prepareResponseCollection: function(collection) {
				this.callParent(arguments);
				var productCompleteStatus = this.getDefaultValueByName("ProductCompleteStatus");
				var productStatus = this.getDefaultValueByName("ProductStatus");
				if (productCompleteStatus !== productStatus) {
					collection.each(function(item) {
						this.setCustomStyle(item);
					}, this);
				}
			},

			/**
			 * @inheritdoc GridUtilitiesV2#loadGridDataRecord
			 * @override
			 */
			loadGridDataRecord: function(primaryColumnValue, callback, scope) {
				var gridData = this.getGridData();
				gridData.removeByKey(primaryColumnValue);
				this.callParent([primaryColumnValue, function() {
					if (primaryColumnValue) {
						gridData = this.getGridData();
						var item = gridData.get(primaryColumnValue);
						this.setCustomStyle(item);
					}
					if (callback) {
						callback.call(scope);
					}
				}, this]);
			},

			/**
			 * Setup register style.
			 * @param {Object} item Register record.
			 * @protected
			 */
			setCustomStyle: function(item) {
				if (this.isActiveCondition(item)) {
					item.customStyle = {
						background: this.get("Resources.Strings.ActiveConditionBackground")
					};
				} else {
					item.customStyle =
					{
						background: this.isFeatureCondition(item) ?
							this.get("Resources.Strings.WhiteConditionBackground") :
							this.get("Resources.Strings.DisabledConditionBackground")
					};
				}
			},

			/**
			 * Check whether conditions will be activated.
			 * @param {Object} item Conditions parameter for checking.
			 * @return {Boolean} true whether conditions will be activated in the future.
			 * @protected
			 */
			isFeatureCondition: function(item) {
				var clearNow = this.Ext.Date.clearTime(new Date(this.Ext.Date.now()));
				var startDate = item.get("StartDate");
				startDate = this.Ext.isEmpty(startDate) ? startDate : this.Ext.Date.clearTime(startDate);
				return startDate > clearNow;
			},

			/**
			 * Checks if conditions are active currently.
			 * @param {Object} item Conditions.
			 * @return {Boolean} True, if conditions are active at this moment.
			 * @protected
			 */
			isActiveCondition: function(item) {
				var clearNow = this.Ext.Date.clearTime(new Date(this.Ext.Date.now()));
				var startDate = item.get("StartDate");
				startDate = this.Ext.isEmpty(startDate) ? startDate : this.Ext.Date.clearTime(startDate);
				var dueDate = item.get("DueDate");
				var isActive;
				if (!this.Ext.isEmpty(dueDate)) {
					dueDate = this.Ext.Date.clearTime(dueDate);
					isActive = startDate <= clearNow && clearNow <= dueDate;
				} else {
					isActive = startDate <= clearNow;
				}
				return isActive;
			},

			/**
			 * Get default value by column name.
			 * @protected
			 * @param {String} valueName Value name.
			 * @return {Object} with default column value.
			 */
			getDefaultValueByName: function(valueName) {
				var value = null;
				var defaultValues = this.get("DefaultValues") || this.getDefaultValues() || [];
				if (defaultValues) {
					var defaultValue = Terrasoft.findItem(defaultValues, {name: valueName});
					if (defaultValue) {
						defaultValue = defaultValue.item;
						if (defaultValue && !Ext.isEmpty(defaultValue.value)) {
							value = defaultValue.value;
						}
					}
				}
				return value;
			},
			
			/**
			* @inheritDoc Terrasoft.Configuration.BaseDetailV2#updateDetail
			* @overridden
			*/
			updateDetail: function(config) {
				config.reloadAll = true;
				this.callParent(arguments);
			}

			// endregion

		}
	};
});
