define("ConsultationThemePage", ["OBSWConstants", "ProcessValidationHelper"],
	function(OBSWConstants, ProcessValidationHelper) {
		return {
			entitySchemaName: "ConsultationTheme",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Parent",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"visible": {
							"bindTo": "IsThemeFieldVisible"
						}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Description",
					"values": {
						"contentType": Terrasoft.ContentType.LONG_TEXT,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "ProcessSchema",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"visible": {
							"bindTo": "IsThemeFieldVisible"
						},
						"isRequired": true
					},
					"parentName": "Header",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"Parent": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						"filters": [
							{
								method: function() {
									return this.getParentRecordFilter();
								}
							}
						]
					}
				},
				"ProcessSchema": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						"filters": [
							{
								method: function() {
									return this.getProcessSchemaFilter();
								}
							}
						]
					}
				}
			},
			methods: {
				/**
				 * Create a group filter to select the parent group for theme.
				 * @protected
				 * @return {Terrasoft.FilterGroup}
				 */
				getParentRecordFilter: function() {
					var block = this.get("Block");
					var filters = this.Terrasoft.createFilterGroup();
					if (!Ext.isEmpty(block)) {
						filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
							"Block", block.value));
					}
					filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"IsFolder", true));
					return filters;
				},

				/**
				 * Create a group filter to select the business process.
				 * @protected
				 * @return {Terrasoft.FilterGroup}
				 */
				getProcessSchemaFilter: function() {
					var filters = this.Terrasoft.createFilterGroup();
					filters.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					filters.addItem(Terrasoft.createNotExistsFilter("[ConsultationTheme:ProcessSchema:Id].Id"));
					filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
							"[ConsultationTheme:ProcessSchema:Id].Id", this.get("Id")));
					return filters;
				},

				/**
				 * Set default values by selected type(Group or theme).
				 * @private
				 */
				setDefaultValuesByRecordType: function() {
					var recordType = this.getDefaultValueByName("RecordType");
					var isGroup = (recordType === OBSWConstants.ConsultationThemesInBlock.Group);
					this.set("IsThemeFieldVisible", !isGroup);
					this.set("IsFolder", isGroup);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.setDefaultValuesByRecordType();
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getActions
				 * @overridden
				 */
				getActions: function() {
					var actionMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					return actionMenuItems;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initHeaderCaption
				 * @overridden
				 */
				initHeaderCaption: function() {
					var caption = this.get("IsFolder") ? this.get("Resources.Strings.GroupPageCaption") :
						this.get("Resources.Strings.ThemePageCaption");
					this.sandbox.publish("InitDataViews", {caption: caption});
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#setValidationConfig
				 * @overridden
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("ProcessSchema", this.validateProcessSchema);
				},

				/**
				 * Validation ProcessSchema.
				 * @protected
				 * @return {Object} Validation message.
				 */
				validateProcessSchema: function() {
					var invalidMessage = "";
					if (!this.validateProcessSchemaIsNotNull()) {
						invalidMessage = this.get("Resources.Strings.EmptyFieldValidateMessage");
					}
					return {
						fullInvalidMessage: invalidMessage,
						invalidMessage: invalidMessage
					};
				},

				/**
				 * Validation of emptiness field ProcessSchema.
				 * @protected
				 * @return {Boolean} is process schema field not empty.
				 */
				validateProcessSchemaIsNotNull: function() {
					return !(this.get("IsThemeFieldVisible") && this.Ext.isEmpty(this.get("ProcessSchema")));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#asyncValidate
				 * @overridden
				 */
				asyncValidate: function(callback, scope) {
					this.callParent([function(response) {
						if (!this.validateResponse(response)) {
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this, response);
							}
							return;
						}
						Terrasoft.chain(
							function(next) {
								this.checkProcessParameters(function(response) {
									if (this.validateResponse(response)) {
										next();
									}
								}, this);
							},
							function() {
								if (this.Ext.isFunction(callback)) {
									callback.call(scope || this, response);
								}
							}, this);
					}, this]);
				},

				/**
				 * Validates the parameters of the business process.
				 * @private
				 * @param {Function} callback - callback function.
				 * @param {Object} scope - execution context callback.
				 */
				checkProcessParameters: function(callback, scope) {
					var result = {
						success: true
					};
					var processSchema = this.get("ProcessSchema");
					if (!processSchema) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this, result);
						}
						return;
					}
					var data = {
						processUId: processSchema.value,
						checkParameters: [
							{
								name: "CaseId",
								dataValueTypes: ["Guid", "Lookup"]
							},
							{
								name: "ContactId",
								dataValueTypes: ["Guid", "Lookup"]
							},
							{
								name: "ConsultationThemeId",
								dataValueTypes: ["Guid", "Lookup"]
							}
						]
					};
					ProcessValidationHelper.checkProcessParameters(data, function(response) {
						this.onCheckProcessParameters(response, callback);
					}.bind(this));
				},

				/**
				 * Processes the validation parameters of the business process.
				 * @private
				 * @param {Object} response - result of validation parameters of the business process.
				 * @param {Boolean} response.isValid - sign of the correctness of the parameters.
				 * @param {Object[]} response.invalidParameters - array of incorrect parameters.
				 * @param {Function} callback - callback function.
				 * @param {Object} scope - execution context callback.
				 */
				onCheckProcessParameters: function(response, callback, scope) {
					response.success = response.isValid;
					if (!response.success) {
						var parametersNames = [];
						Terrasoft.each(response.invalidParameters, function(parameter) {
							parametersNames.push(parameter.name);
						});
						var processSchema = this.get("ProcessSchema");
						var message = Ext.String.format(this.get("Resources.Strings.InvalidParametersMessage"),
							processSchema.displayValue, parametersNames.join(", "));
						Terrasoft.showInformation(message);
					}
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this, response);
					}
				}
			}
		};
	}
);
