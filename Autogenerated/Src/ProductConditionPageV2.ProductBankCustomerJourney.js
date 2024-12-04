define("ProductConditionPageV2", ["BusinessRuleModule", "BaseFinanceConstants", "ProductConditionUtilitiesMixin"],
	function() {
		return {
			entitySchemaName: "ProductCondition",
			details: {
				DocListInConditionDetailV2: {
					schemaName: "DocListInConditionDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "ProductCondition"
					}
				},
				ProductSpecificationInConditionDetail: {
					schemaName: "ProductSpecificationInConditionDetail",
					defaultValues: {
						Product: {
							masterColumn: "Product"
						}
					}
				},
				CustomerSpecificationInConditionDetail: {
					schemaName: "CustomerSpecificationInConditionDetail",
					defaultValues: {
						Product: {
							masterColumn: "Product"
						}
					}
				},
				OpportunityConditionDetail: {
					schemaName: "OpportunityConditionDetail",
					defaultValues: {
						Product: {
							masterColumn: "Product"
						}
					},
					filter: {
						masterColumn: "Id",
						detailColumn: "ProductCondition"
					}
				},
				ChangeCriteriaInConditionDetailV2: {
					schemaName: "ChangeCriteriaInConditionDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "ProductCondition"
					},
					defaultValues: {
						ProductCategory: {
							masterColumn: "Category"
						},
						ProductType: {
							masterColumn: "Type"
						}
					}
				}
			},
			attributes: {
				/**
				 * A message that will be displayed as a prompt to the user.
				 * @type {String}
				 */
				HelpMessage: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				/**
				 * A product for which we create conditions.
				 * @type {Object}
				 */
				Product: {
					lookupListConfig: {
						columns: ["Category", "Type"]
					}
				},
				/**
				 * The category of the current product.
				 * @type {Object}
				 */
				Category: {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
				},
				/**
				 * The type of the current product.
				 * @type {Object}
				 */
				Type: {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
				},
				/**
				 * Is record was copied.
				 * @type {Boolean}
				 */
				IsCopied: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				}
			},
			messages: {
				/**
				 * @message ReloadDetail.
				 */
				"ReloadProductConditionDetail": {
					"mode": this.Terrasoft.MessageMode.PTP,
					"direction": this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			mixins: {
				ProductConditionUtilitiesMixin: "Terrasoft.ProductConditionUtilitiesMixin"
			},
			methods: {

				//region Methods: Private

				/**
				 * Updates the details on the product conditions page.
				 * @private
				 */
				updateProductConditionDetails: function() {
					this.updateDetail({detail: "DocListInConditionDetailV2"});
				},

				/**
				 * Sets Name value.
				 * @private
				 * @param {Boolean} isSilent is sets value silent.
				 */
				_setConditionName: function(isSilent) {
					var name = this.generateConditionName();
					this.set("Name", name, {silent: isSilent});
				},

				_createSuccessValidateResult: function() {
					return {
						success: true
					};
				},

				_createDateValidateEsq: function() {
					return this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName,
						rowCount: 1
					});
				},

				_addColumnToDateValidateEsq: function(esq) {
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					esq.addColumn("StartDate");
					var dueDateColumn = esq.addColumn("DueDate");
					dueDateColumn.orderDirection = Terrasoft.OrderDirection.DESC;
				},

				_processValidationDateCallback: function(response, callback, scope) {
					var result;
					if (response.success) {
						result = this._processSuccessValidationDateResponse(response);
					} else {
						result.success = false;
					}
					this.Ext.callback(callback, scope, [result]);
				},

				_processSuccessValidationDateResponse: function(response) {
					var collection = response.collection;
					if (collection.getCount() > 0) {
						var item = collection.getByIndex(0);
						return this._createUnSuccessValidationDateResultByItem(item);
					}
					return this._createSuccessValidateResult();
				},

				_createUnSuccessValidationDateResultByItem: function(item) {
					var startDate = this._convertDateToString(item.$StartDate);
					var dueDate = this._convertDateToString(item.$DueDate);
					var resultMessage = this.get("Resources.Strings.CrossConditionsNotAllowedValidationMessage");
					// var messageTemplate = this.get("Resources.Strings.UnSuccessValidationDateResultTemplate");
					// var resultMessage = this.Ext.String.format(messageTemplate, startDate, dueDate);
					return {
						success: false,
						message: resultMessage
					};
				},

				_convertDateToString: function(date) {
					if (!this.Ext.isDate(date)) {
						return "";
					}
					date = this.Ext.Date.clearTime(date);
					var cultureName = this.Terrasoft.Resources.CultureSettings.currentCultureName;
					return this.Terrasoft.toLocaleDate(date, cultureName);
				},

				_addCrossConditionsNotExistsFiltersToEsq: function(esq) {
					var dueDate = this.get("DueDate");
					var startDateFilter = this.createColumnBetweenFilter(this.get("StartDate"),
						this.Terrasoft.DataValueType.DATE, "StartDate", "DueDate");
					var dueDateFilter = this.createColumnBetweenFilter(dueDate,
						this.Terrasoft.DataValueType.DATE, "StartDate", "DueDate");
					var filterGroup = Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = Terrasoft.LogicalOperatorType.OR;
					filterGroup.addItem(startDateFilter);
					filterGroup.addItem(dueDateFilter);
					esq.filters.addItem(filterGroup);
					var product = this.get("Product");
					esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"Product", product.value, this.Terrasoft.DataValueType.GUID));
					esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.NOT_EQUAL,
							"Id", this.getPrimaryColumnValue(), this.Terrasoft.DataValueType.GUID));
				},

				/**
				 * Checks that there should not be two overlapping conditions for the product, if
				 * completed completion date.
				 * @private
				 * @param {Function} callback Callback function.
				 * @param {Object} scope The context of the callback function.
				 */
				validateCrossConditionsNotExists: function(callback, scope) {
					var dueDate = this.get("DueDate");
					if (this.Ext.isEmpty(dueDate)) {
						this.Ext.callback(callback, scope, [this._createSuccessValidateResult()]);
						return;
					}
					var esq = this._createDateValidateEsq();
					this._addColumnToDateValidateEsq(esq);
					this._addCrossConditionsNotExistsFiltersToEsq(esq);
					esq.getEntityCollection(function(response) {
						this._processValidationDateCallback(response, callback, scope);
					}, this);
				},

				_addValidationStartDateFiltersToEsq: function(esq) {
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.GREATER_OR_EQUAL, "DueDate", this.get("StartDate"),
						this.Terrasoft.DataValueType.DATE));
					var product = this.get("Product");
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Product", product.value));
					esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.NOT_EQUAL,
							"Id", this.getPrimaryColumnValue(), this.Terrasoft.DataValueType.GUID));
				},

				/**
				 * Verifies that the start date does not overlap with existing conditions,
				 * if the completion date is not completed.
				 * @private
				 * @param {Function} callback Callback function.
				 * @param {Object} scope The context of the callback function.
				 */
				validateStartDate: function(callback, scope) {
					var dueDate = this.get("DueDate");
					if (!this.Ext.isEmpty(dueDate)) {
						this.Ext.callback(callback, scope, [this._createSuccessValidateResult()]);
						return;
					}
					var esq = this._createDateValidateEsq();
					this._addColumnToDateValidateEsq(esq);
					this._addValidationStartDateFiltersToEsq(esq);
					esq.getEntityCollection(function(response) {
						this._processValidationDateCallback(response, callback, scope);
					}, this);
				},

				/**
				 * Creates an instance of the Between filter to check whether the value falls within the specified range,
				 * for example:
				 * '2015-08-18' BETWEEN [ProductCondition].[StartDate] AND [ProductCondition].[DueDate].
				 * @private
				 * @param {Mixed} parameterValue Value.
				 * @param {Terrasoft.DataValueType} parameterDataType The type of the parameter value.
				 * @param {String} lessParameterPath The path to the column, the value of which will be the initial.
				 * @param {String} greaterParameterPath The path to the column, the value of which will be finite.
				 * @return {Terrasoft.BetweenFilter} Returns the created filter object.
				 */
				createColumnBetweenFilter: function(parameterValue, parameterDataType,
					lessParameterPath, greaterParameterPath) {
					var leftExpression = this.Ext.create("Terrasoft.ParameterExpression", {
						parameterValue: parameterValue,
						parameterDataType: parameterDataType
					});
					var rightLessExpression = this.Ext.create("Terrasoft.ColumnExpression", {
						columnPath: lessParameterPath
					});
					var rightGreaterExpression = this.Ext.create("Terrasoft.ColumnExpression", {
						columnPath: greaterParameterPath
					});
					return this.Terrasoft.createBetweenFilter(leftExpression, rightLessExpression,
						rightGreaterExpression);
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc ProductConditionUtilitiesMixin#getValidationDueDateConfig
				 * @override
				 */
				getValidationDueDateConfig: function() {
					return {
						message: this.get("Resources.Strings.VerifyConditionMessage"),
						productId: this.$Product.value,
						productConditionId: this.getPrimaryColumnValue()
					};
				},

				/**
				 * @inheritdoc BaseSchemaViewModel#setValidationConfig
				 * @override
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("DueDate", this.dueDateValidator);
				},

				/**
				 * Performs validation for a new end date value.
				 * @param {Date} value Column value.
				 * @return {Object} An object containing the error text when validating.
				 * @protected
				 */
				dueDateValidator: function(value) {
					var result = this.dueDateBiggerThenStartDateValidator(value);
					if (this.Ext.isEmpty(result.invalidMessage)) {
						result = this.dueDateLessThenProductDueDateValidator(value);
					}
					return result;
				},

				/**
				 * Validation of the completion date in view of the start date.
				 * @protected
				 * @param {Date} value Column value.
				 * @return {Object} An object containing the error text when validating.
				 */
				dueDateBiggerThenStartDateValidator: function(value) {
					var startDate = this.get("StartDate");
					var message = this.get("Resources.Strings.DueDateValidationMessage");
					return this.validateDueDate(startDate, value, message);
				},

				/**
				 * Validation of the completion date in view of the completion date of the product.
				 * @protected
				 * @param {Date} value Column value.
				 * @return {Object} An object containing the error text when validating.
				 */
				dueDateLessThenProductDueDateValidator: function(value) {
					var productDueDate = this.getDefaultValueByName("ProductDueDate");
					var message = this.get("Resources.Strings.DueDateLessThenProductDueDateValidationMessage");
					return this.validateDueDate(value, productDueDate, message);
				},

				/**
				 * Performs validation for dates.
				 * @protected
				 * @param {Date} lessDate Date with a lower value.
				 * @param {Date} biggerDate Date with a larger value.
				 * @param {String} validationMessage A string used as a validation message.
				 * @return {Object} If lessDate is larger than biggerDate, then the object with the validation message
				 * will be returned.
				 */
				validateDueDate: function(lessDate, biggerDate, validationMessage) {
					var result = {
						invalidMessage: ""
					};
					if (this.Ext.isEmpty(lessDate) || this.Ext.isEmpty(biggerDate)) {
						return result;
					}
					var clearLesserDate = this.Ext.Date.clearTime(lessDate);
					var clearBiggerDate = this.Ext.Date.clearTime(biggerDate);
					if (clearLesserDate > clearBiggerDate) {
						result.invalidMessage = validationMessage;
					}
					return result;
				},

				/**
				 * @inheritdoc BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.generateHelpMessage();
					this.setCategoryAndType();
					this._setConditionName(true);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#updateButtonsVisibility
				 * @override
				 */
				updateButtonsVisibility: function() {
					if (this.destroyed) {
						return;
					}
					this.callParent(arguments);
					var isNeedSave = this.isEditMode() && !this.get("ShowSaveButton") && this.$IsCopied;
					if (!isNeedSave) {
						return;
					}
					this.set("ShowDiscardButton", false);
					this.set("ShowSaveButton", true);
					this.set("ShowCloseButton", false);
				},

				/**
				 * Fills in the attributes for the defaultValues details.
				 * @protected
				 */
				setCategoryAndType: function() {
					var product = this.get("Product");
					this.set("Category", product.Category);
					this.set("Type", product.Type);
				},

				/**
				 * Creates a hint for the product conditions page.
				 * @protected
				 */
				generateHelpMessage: function() {
					var message = this.get("Resources.Strings.ProductConditionsHelpMessage");
					var product = this.get("Product");
					message += product.displayValue;
					this.set("HelpMessage", message);
				},

				/**
				 * @inheritdoc BasePageV2#save
				 * @override
				 */
				save: function(config) {
					this._setConditionName(false);
					this.showBodyMask();
					this.Terrasoft.chain(
						this.saveCheckCanEditRight,
						this.saveAsyncValidate,
						this.saveEntityInChain,
						function(next) {
							this.saveDetails(function(response) {
								if (this.validateResponse(response)) {
									next();
								}
							}, this);
						},
						function(next) {
							if (this.isCopyMode()) {
								this.copyProductConditionDetails(function(response) {
									this.copyProductConditionDetailsCallback(response, config, next);
								}, this);
							} else {
								next();
							}
						},
						function() {
							this.onSaved(this.cardSaveResponse, config);
							this.cardSaveResponse = null;
							delete this.cardSaveResponse;
							this.sandbox.publish("ReloadProductConditionDetail", null);
						},
						this
					);
				},

				/**
				 * @inheritdoc BasePageV2#save
				 * @override
				 */
				onSaved: function() {
					this.callParent(arguments);
					this.$IsCopied = false;
				},

				/**
				 * Processes the results of a service call for copying the details of the product condition.
				 * @protected
				 * @param {Object} response The server response.
				 * @param {Object} config The configuration object.
				 * @param {Function} callback Callback function.
				 */
				copyProductConditionDetailsCallback: function(response, config, callback) {
					if (this.validateResponse(response)) {
						if (config && config.isSilent) {
							this.updateProductConditionDetails();
						}
						if (this.Ext.isFunction(callback)) {
							callback();
						}
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#asyncValidate
				 * @override
				 */
				asyncValidate: function(callback, scope) {
					this.callParent([function(response) {
						if (!this.validateResponse(response)) {
							return;
						}
						this.Terrasoft.chain(
							function(next) {
								this.validateCrossConditionsNotExists(function(response) {
									if (this.validateResponse(response)) {
										next();
									}
								}, this);
							},
							function(next) {
								this.validateConditionsDueDate(function(response) {
									if (this.validateResponse(response)) {
										next();
									}
								}, this);
							},
							function(next) {
								this.validateStartDate(function(response) {
									if (this.validateResponse(response)) {
										next();
									}
								}, this);
							},
							function(next) {
								callback.call(scope, response);
								next();
							}, this);
					}, this]);
				},

				/**
				 * Calls the service to copy the records to the details of the Package of documents.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope The context of the callback function.
				 */
				copyProductConditionDetails: function(callback, scope) {
					var requestConfig = {
						serviceName: "EntityUtilsService",
						methodName: "CopyEntities",
						data: {
							sourceEntityId: this.get("SourceEntityPrimaryColumnValue"),
							recipientEntityId: this.getPrimaryColumnValue(),
							columnName: "ProductCondition",
							entitySchemaName: "ProductCondition",
							sourceEntitySchemaNames: ["DocListInCondition"]
						}
					};
					this.callService(requestConfig, function(response) {
						var errorInfo = response.CopyEntitiesResult;
						callback.call(scope || this, {
							success: this.Ext.isEmpty(errorInfo),
							errorInfo: errorInfo
						});
					}, this);
				},

				/**
				 * Forms a name for the conditions, based on the product name, as well as the start and end date.
				 * @protected
				 * @return {String} The name of the product conditions.
				 */
				generateConditionName: function() {
					var product = this.get("Product");
					var productName = product.displayValue;
					var dateFormat = this.get("Resources.Strings.DateFormat");
					var startDate = this.Ext.Date.format(this.get("StartDate"), dateFormat);
					var dueDate = this.Ext.Date.format(this.get("DueDate"), dateFormat);
					var conditionName, message;
					if (this.Ext.isEmpty(dueDate)) {
						message = this.get("Resources.Strings.ProductConditionName");
						conditionName = this.Ext.String.format(message, productName, startDate);
					} else {
						message = this.get("Resources.Strings.ProductConditionNameWithDueDate");
						conditionName = this.Ext.String.format(message, productName, startDate, dueDate);
					}
					return conditionName;
				}

				//endregion
			},
			diff: [
				{
					"operation": "remove",
					"name": "actions"
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "NameLabel",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "HelpMessage"
						},
						"layout": {
							"column": 0,
							"row": 0,
							"rowSpan": 1,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "insert",
					"name": "StartDate",
					"propertyName": "items",
					"parentName": "Header",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "StartDate"
					}
				},
				{
					"operation": "insert",
					"name": "DueDate",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "DueDate"
					}
				},
				{
					"operation": "insert",
					"name": "CustomerParametersTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.CustomerParametersTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "CustomerParametersTab",
					"propertyName": "items",
					"name": "CustomerSpecificationInConditionDetail",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"name": "ProductParametersTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.ProductParametersTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ProductParametersTab",
					"propertyName": "items",
					"name": "ProductSpecificationInConditionDetail",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"name": "OpportunityConditionsTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.OpportunityConditionsTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "OpportunityConditionsTab",
					"propertyName": "items",
					"name": "OpportunityConditionDetail",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"name": "DocumentListTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.DocumentListTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "DocumentListTab",
					"propertyName": "items",
					"name": "DocListInConditionDetailV2",
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				},
				{
					"operation": "insert",
					"name": "ParametersChangeCriteriaTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.ParametersChangeCriteriaTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ParametersChangeCriteriaTab",
					"propertyName": "items",
					"name": "ChangeCriteriaInConditionDetailV2",
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				}
			]
		};
	});
