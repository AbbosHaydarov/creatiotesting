/**
 * Base fields detail.
 * Parent: BaseDetailV2
 */
define("BaseFieldsDetail", ["ConfigurationEnums", "ConfigurationItemGenerator",
		"ViewGeneratorV2", "BaseFieldRowViewModel", "css!BaseFieldsDetailCSS"
	],
	function(configurationEnums) {
		return {
			messages: {
				/**
				 */
				"LookupInfo": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message ResultSelectedRows
				 */
				"ResultSelectedRows": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message UpdateCardProperty
				 */
				"UpdateCardProperty": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message DiscardChanges
				 */
				"DiscardChanges": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message ValidateDetail
				 */
				"ValidateDetail": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message DetailValidated
				 */
				"DetailValidated": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message SaveDetail
				 */
				"SaveDetail": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message DetailValidated
				 */
				"DetailSaved": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message CardSaved
				 * Gets information that parent page is saved.
				 */
				"CardSaved": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message IsCardChanged
				 * Requests is card changed.
				 */
				"IsCardChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * Adding new detail item row.
				 * @private
				 * @param {Object} additionalConfig Additional item config.
				 * @return {Terrasoft.BaseViewModel} detail item viewModel.
				 */
				addRow: function(additionalConfig) {
					additionalConfig = additionalConfig || {};
					var config = this.Ext.apply({
						"isNew": true
					}, additionalConfig);
					var collection = this.getCollection();
					var viewModelItem = this.createRowViewModel(config);
					collection.add(viewModelItem.get(this.primaryColumnName), viewModelItem);
					if (!additionalConfig.isVirtual) {
						this.setSaveDiscardButtonsVisible(true);
					}
					return viewModelItem;
				},

				/**
				 * Returns true if card record is new.
				 * @private
				 * @return {Boolean} True if card record is new or copy state.
				 */
				getIsCardNewRecordState: function() {
					var cardState = this.sandbox.publish("GetCardState", null, [this.sandbox.id]);
					var state = cardState.state;
					var isAdd = configurationEnums.CardStateV2.ADD;
					var isCopy = configurationEnums.CardStateV2.COPY;
					return state === isAdd || state === isCopy;
				},

				/**
				 * Clear query events.
				 * @private
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
				 */
				initQueryEvents: function(esq) {
					esq.on("createviewmodel", this.createRowViewModel, this);
				},

				/**
				 * Clear query events.
				 * @private
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
				 */
				destroyQueryEvents: function(esq) {
					esq.un("createviewmodel", this.createRowViewModel, this);
				},

				/**
				 * Subscribe collection events.
				 * @private
				 */
				subscribeCollectionEvents: function() {
					var collection = this.getCollection();
					collection.on("itemChanged", this.onCollectionItemChanged, this);
				},

				/**
				 * Unsubscribe collection events.
				 * @private
				 */
				unSubscribeCollectionEvents: function() {
					var collection = this.getCollection();
					collection.un("itemChanged", this.onCollectionItemChanged, this);
				},

				getCollection: function() {
					return this.get("Collection");
				},

				/**
				 * Clears detail collection.
				 * @private
				 */
				clearCollection: function() {
					var collection = this.getCollection();
					collection.each(function(item) {
						item.isDeleted = true;
						item.set("isDeleted", true);
					});
				},

				/**
				 * Clears container list.
				 * @private
				 */
				clearContainerList: function() {
					var collection = this.getCollection();
					collection.clear();
				},

				/**
				 * Publish UpdateCardProperty message.
				 * @private
				 * @param {String} key Name of card property.
				 * @param {Object} value Button state visible.
				 * @param {Object} options Additional properties.
				 */
				updateCardProperty: function(key, value, options) {
					this.sandbox.publish("UpdateCardProperty", {
						key: key,
						value: value,
						options: options
					}, [this.sandbox.id]);
				},

				/**
				 * Sets discard and save button visible.
				 * @private
				 * @param {Boolean} isVisible Buttons state visible.
				 */
				setSaveDiscardButtonsVisible: function(isVisible) {
					var options = ["ShowSaveButton", "ShowDiscardButton"];
					this.Terrasoft.each(options, function(option) {
						this.updateCardProperty(option, isVisible, null);
					}, this);
					this.updateCardProperty("IsChanged", isVisible, {
						silent: true
					});
					this.updateCardProperty("Restored", true, {
						silent: true
					});
				},

				/**
				 * Publish a message about detail's saving.
				 * @private
				 * @param {Object} config Message params
				 */
				publishSaveResponse: function(config) {
					this.sandbox.publish("DetailSaved", config, [this.sandbox.id]);
				},

				/**
				 * Publishes message for change card state.
				 * @private
				 * @return {Boolean} True if card is changed.
				 */
				getIsCardChanged: function() {
					return this.sandbox.publish("IsCardChanged", null, [this.sandbox.id]);
				},

				/**
				 * Create instance of View Generator.
				 * @private
				 * @return {Terrasoft.ViewGenerator}
				 */
				createViewGeneratorInstance: function() {
					return this.Ext.create("Terrasoft.ViewGenerator");
				},

				/**
				 * Returns name of view model class for view generator.
				 * @private
				 * @return {String} Name of view model class for view generator.
				 */
				getViewGeneratorViewModelClassName: function() {
					return this.Ext.String.format("Terrasoft.{0}{1}ViewModel", this.name, this.entitySchemaName);
				},

				/**
				 * Returns required columns names array.
				 * @private
				 * @return {Array} Required columns names array.
				 */
				getRequiredColumns: function() {
					var requiredColumns = [];
					this.Terrasoft.each(this.columns, function(column) {
						if (column.isRequired && column.type === this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN) {
							requiredColumns.push(column.name);
						}
					}, this);
					return requiredColumns;
				},

				/**
				 * Removes item from array.
				 * @private
				 * @param {Array} array Array.
				 * @param {[type]} item Item.
				 * @return {Array} Array.
				 */
				removeArrayItem: function(array, item) {
					var index = array.indexOf(item);
					if (index > -1) {
						array.splice(index, 1);
					}
					return array;
				},

				//endregion

				//region Methods: Protected

				useVirtualRecord: function() {
					return false;
				},

				/**
				 * Adds detail record. If page was not saved - save detail parent page.
				 * @protected
				 */
				onAddRecordButtonClick: function() {
					var isNewCardState = this.getIsCardNewRecordState();
					if (isNewCardState) {
						this.saveCard();
					} else {
						this.addRow();
					}
				},

				/**
				 * Publishing message to save parent card.
				 * @protected
				 */
				saveCard: function() {
					var sandbox = this.sandbox;
					var args = {
						isSilent: true,
						messageTags: [sandbox.id]
					};
					sandbox.publish("SaveRecord", args, [sandbox.id]);
				},

				/**
				 * Handler of the saved card in which the detail.
				 * @protected
				 */
				onCardSaved: function() {
					this.addRow();
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#initData
				 * @overridden
				 */
				initData: function(callback, scope) {
					this.callParent([function() {
						this.subscribeCollectionEvents();
						this.loadDetailData(callback, scope);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#initDetailOptions
				 * @overridden
				 */
				initDetailOptions: function() {
					this.set("IsDetailCollapsed", false);
					this.addTypeColumnValue();
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					var sandbox = this.sandbox;
					sandbox.subscribe("DiscardChanges", this.onDiscardChanges, this, [sandbox.id]);
					sandbox.subscribe("ValidateDetail", this.validateDetail, this, [sandbox.id]);
					sandbox.subscribe("SaveDetail", this.save, this, [sandbox.id]);
					sandbox.subscribe("CardSaved", this.onCardSaved, this, [sandbox.id]);
				},

				/**
				 * Sets type column value to default values.
				 * @protected
				 */
				addTypeColumnValue: function() {
					var config = this.getTypeColumnConfig();
					var defaultValues = this.get("DefaultValues") || [];
					if (config) {
						defaultValues.push(config);
						this.set("DefaultValues", defaultValues);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#updateDetail
				 * @overridden
				 */
				updateDetail: function() {
					this.callParent(arguments);
					var detailInfo = this.getDetailInfo();
					this.set("MasterRecordId", detailInfo.masterRecordId);
					this.set("DetailColumnName", detailInfo.detailColumnName);
					this.set("Filter", detailInfo.filter);
					this.set("CardPageName", detailInfo.cardPageName);
					this.set("SchemaName", detailInfo.schemaName);
					this.set("DefaultValues", detailInfo.defaultValues);
					this.clearContainerList();
					this.loadDetailData();
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#destroy
				 * @overridden
				 */
				destroy: function() {
					this.unSubscribeCollectionEvents();
					this.callParent(arguments);
				},


				/**
				 * Handles discard button click.
				 * @protected
				 */
				onDiscardChanges: function() {
					this.updateDetail();
				},

				/**
				 * Handles change item event in collection.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} item Changed viewModel.
				 */
				onCollectionItemChanged: function(item) {
					if (!this.get("IsDataLoading") && item.get("EntityInitilized")) {
						this.setSaveDiscardButtonsVisible(true);
					}
				},

				/**
				 * Returns name of view model class.
				 * @protected
				 * @return {String} Name of view model class.
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.BaseFieldRowViewModel";
				},

				/**
				 * Returns row view model configuration.
				 * @protected
				 * @param {Object} config Row configuration.
				 * @return {Object} Row view model configuration.
				 */
				getRowViewModelConfig: function(config) {
					config = config || {};
					config.rawData = config.rawData || {};
					var isNew = config.isNew || false;
					var defaultValues = this.get("DefaultValues");
					if (config.defaultValues) {
						defaultValues = Ext.Array.merge(defaultValues, config.defaultValues);
					}
					this.Ext.apply(config.rawData, {
						DetailColumnName: this.get("DetailColumnName"),
						DefaultValues: defaultValues
					});
					var gridRowViewModelConfig = {
						entitySchema: this.entitySchema,
						isNew: isNew,
						isVirtual: config.isVirtual || false,
						isDeleted: false,
						Ext: this.Ext,
						Terrasoft: this.Terrasoft,
						sandbox: this.sandbox,
						columns: this.columns,
						rowConfig: config.rowConfig,
						values: config.rawData
					};
					return gridRowViewModelConfig;
				},

				/**
				 * Generate detail entity row view model.
				 * @protected
				 * @param {Object} config optional viewModel config.
				 * @return {Terrasoft.BaseViewModel} detail item viewModel.
				 */
				createRowViewModel: function(config) {
					config = config || {};
					var gridRowViewModelClassName = this.getRowViewModelClassName(config);
					var gridRowViewModelConfig = this.getRowViewModelConfig(config);
					var viewModel = this.Ext.create(gridRowViewModelClassName, gridRowViewModelConfig);
					config.viewModel = viewModel;
					return viewModel;
				},

				/**
				 * Create empty detail data esq.
				 * @protected
				 * @return {Terrasoft.EntitySchemaQuery} detail data eaq.
				 */
				getDetailDataESQ: function() {
					return this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchema: this.entitySchema,
						rowViewModelClassName: this.getRowViewModelClassName()
					});
				},

				/**
				 * Fills entity schema query columns.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
				 */
				initESQColumns: function(esq) {
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					this.Terrasoft.each(this.getDisplayColumns(), function(displayColumn) {
						var column = this.findEntityColumn(displayColumn);
						if (column) {
							esq.addColumn(displayColumn);
						}
					}, this);
				},

				/**
				 * Sets type column filter in detail entity schema query.
				 * @protected
				 * @param {Terrasoft.FilterGroup} filters Group of filters.
				 */
				addTypeColumnFilter: function(filters) {
					var typeColumnConfig = this.getTypeColumnConfig();
					if (typeColumnConfig && typeColumnConfig.name && typeColumnConfig.value) {
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, typeColumnConfig.name,
							typeColumnConfig.value));
					}
				},

				/**
				 * Fills entity schema query filters.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
				 */
				initESQFilters: function(esq) {
					var masterColumn = this.get("DetailColumnName");
					var masterRecordId = this.get("MasterRecordId");
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, masterColumn, masterRecordId));
					this.addTypeColumnFilter(esq.filters);
				},

				/**
				 * Adds new virtual record on detail.
				 * @protected
				 * @return {Terrasoft.BaseViewModel} added detail item viewModel.
				 */
				addVirtualRecord: function() {
					return this.addRow({
						isVirtual: true
					});
				},

				/**
				 * Gets data from DB and fill detail collection.
				 * @protected
				 * @param {Function} callback Callback-function.
				 * @param {Object} scope Callback-function scope.
				 */
				loadDetailData: function(callback, scope) {
					this.showBodyMask();
					var esq = this.getDetailDataESQ();
					this.initESQColumns(esq);
					this.initESQFilters(esq);
					this.initQueryEvents(esq);
					this.set("IsDataLoading", true);
					esq.getEntityCollection(function(result) {
						this.destroyQueryEvents(esq);
						this.onDetailDataLoaded(result, callback, scope);
					}, this);
				},

				/**
				 * Handles result of detail loading.
				 * @protected
				 * @param {Object} result Result of data loading.
				 * @param {Function} callback Callback-function.
				 * @param {Terrasoft.BaseViewModel} scope Calllback execution context.
				 */
				onDetailDataLoaded: function(result, callback, scope) {
					var collection;
					if (result.success && result.collection) {
						collection = this.getCollection();
						collection.loadAll(result.collection);
					}
					if (collection && collection.isEmpty() && this.useVirtualRecord()) {
						this.addVirtualRecord();
					}
					this.hideBodyMask();
					this.set("IsDataLoading", false);
					this.Ext.callback(callback, scope);
				},

				/**
				 * Returns columns names array to display.
				 * @protected
				 * @return {Array} Display columns names array.
				 */
				getDisplayColumns: function() {
					var columns = this.getRequiredColumns();
					this.removeArrayItem(columns, this.get("DetailColumnName"));
					this.removeArrayItem(columns, this.primaryColumnName);
					this.removeArrayItem(columns, this.primaryDisplayColumnName);
					if (this.primaryDisplayColumnName) {
						columns.unshift(this.primaryDisplayColumnName);
					}
					return columns;
				},

				/**
				 * Returns detail row items (controls) view configs.
				 * @protected
				 * @return {Array} Row items config array.
				 */
				getDetailRowItemsViewConfig: function() {
					var rowViewConfig = [];
					this.Terrasoft.each(this.getDisplayColumns(), function(displayColumn) {
						var column = this.findEntityColumn(displayColumn);
						if (column) {
							var columnName = column.name;
							var dataValueType = column.dataValueType;
							var defaultItemConfig = {
								itemType: this.Terrasoft.ViewItemType.MODEL_ITEM,
								dataValueType: dataValueType,
								name: columnName,
								wrapClass: ["field-detail-row-left-item"],
								markerValue: columnName
							};
							rowViewConfig.push(defaultItemConfig);
						}
					}, this);
					return rowViewConfig;
				},

				/**
				 * Returns delete button config.
				 * @protected
				 * @return {Object} Delete button config.
				 */
				getDeleteButtonConfig: function() {
					var deleteButtonConfig = {
						itemType: this.Terrasoft.ViewItemType.BUTTON,
						name: "DeleteButton",
						click: {
							bindTo: "deleteItem"
						},
						controlConfig: {
							style: this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							imageConfig: {
								bindTo: "Resources.Images.DeleteButtonImage"
							}
						},
						classes: {
							wrapperClass: ["delete-button-class"]
						}
					};
					return deleteButtonConfig;
				},

				/**
				 * Sets up detail view configuration.
				 * @protected
				 * @param {Object} itemConfig Item configuration.
				 * @param {Object} item ViewModel item.
				 */
				initDetailRowViewConfig: function(itemConfig, item) {
					var itemViewConfig = this.get("ItemViewConfig");
					if (itemViewConfig) {
						itemConfig.config = itemViewConfig;
						return;
					}
					var viewGenerator = this.createViewGeneratorInstance();
					var viewConfig = viewGenerator.generatePartial(this.getDetailRowViewConfig(item), {
						schemaName: this.name,
						viewModelClass: this.Ext.ClassManager.get(this.getViewGeneratorViewModelClassName()),
						schema: {}
					});
					viewConfig = viewConfig[0];
					itemConfig.config = viewConfig;
					this.set("ItemViewConfig", viewConfig);
					viewGenerator.destroy();
				},

				/**
				 * Returns detail row left container wrap class.
				 * @protected
				 * @param {Boolean} useSingleRecordMode Use single record mode.
				 * @return {Array} Wrap classes.
				 */
				getLeftRowContainerWrapClass: function(useSingleRecordMode) {
					var wrapClass = ["field-detail-row-left"];
					if (useSingleRecordMode) {
						wrapClass.push("singlecolumn");
					}
					return wrapClass;
				},

				/**
				 * Returns detail row right container wrap class.
				 * @protected
				 * @return {Array} Wrap classes.
				 */
				getRightRowContainerWrapClass: function() {
					return ["field-detail-row-right"];
				},

				/**
				 * Returns detail row main container wrap class.
				 * @protected
				 * @return {Array} Wrap classes.
				 */
				getRowContainerWrapClass: function() {
					return ["field-detail-row"];
				},

				/**
				 * Returns detail row view configuration.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} [item] Item viewModel item.
				 * @return {Object} Detail row view configuration.
				 */
				getDetailRowViewConfig: function(item) {
					var leftRowContainerViewConfig = this.getDetailRowItemsViewConfig(item);
					var rightRowContainerViewConfig = [];
					var deleteButtonConfig = this.getDeleteButtonConfig();
					if (deleteButtonConfig) {
						rightRowContainerViewConfig.push(deleteButtonConfig);
					}
					return {
						"id": "FieldDetailRow" + this.entitySchemaName,
						"name": "FieldDetailRow",
						"wrapClass": this.getRowContainerWrapClass(),
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"visible": {
							"bindTo": "getRowVisible"
						},
						"items": [{
							"id": "LeftFieldDetailRowContainer",
							"name": "LeftFieldDetailRowContainer",
							"wrapClass": this.getLeftRowContainerWrapClass(leftRowContainerViewConfig.length < 2),
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"items": leftRowContainerViewConfig
						}, {
							"id": "RightFieldDetailRowContainer",
							"name": "RightFieldDetailRowContainer",
							"wrapClass": this.getRightRowContainerWrapClass(),
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"items": rightRowContainerViewConfig
						}]
					};
				},

				/**
				 * Validates detail's fields.
				 * @protected
				 * @return {Boolean} True if detail is not valid, otherwise false.
				 */
				validateDetail: function() {
					var resultObject = {
						success: this.validateItems()
					};
					if (!resultObject.success) {
						resultObject.message = this.getValidationMessage();
					}
					this.sandbox.publish("DetailValidated", resultObject, [this.sandbox.id]);
					return true;
				},

				/**
				 * Initializes validation of all items before detail's saving.
				 * @protected
				 * @return {Boolean} Validation result. True if all items is valid.
				 */
				validateItems: function() {
					var collection = this.getCollection();
					var result = true;
					collection.each(function(item) {
						if (item.changedValues && !item.isDeleted && !item.validate()) {
							result = false;
							return !result;
						}
					}, this);
					return result;
				},

				/**
				 * Generates message for failing of validation.
				 * @protected
				 */
				getValidationMessage: function() {
					var messageTemplate = this.get("Resources.Strings.ValidationErrorTemplate");
					var detailCaption = this.get("Caption");
					return this.Ext.String.format(messageTemplate, detailCaption);
				},

				/**
				 * Saves detail's changes. Fires by clicking on saving button on page, that contains detail.
				 * @protected
				 * @return {Boolean} True if changes saved succesfull or if detail has no changes.
				 */
				save: function() {
					this.saveSilent(this.onSaved, this);
					return true;
				},

				/**
				 * Saves detail's changes in silent mode (without publishing any messages) and calls callback function.
				 * @protected
				 * @param {Function} callback The callback function.
				 * @param {Object} scope Scope for the callback function.
				 */
				saveSilent: function(callback, scope) {
					var queries = this.getSaveItemsQueries();
					if (this.Ext.isEmpty(queries)) {
						this.Ext.callback(callback, scope, [{
							success: true
						}]);
						return;
					}
					var batchQuery = this.Ext.create("Terrasoft.BatchQuery");
					this.Terrasoft.each(queries, function(query) {
						batchQuery.add(query);
					}, this);
					batchQuery.execute(callback, scope);
				},

				/**
				 * Returns type column configuration object.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} item Item of rows collection.
				 * @return {Boolean}
				 */
				canSaveVirtualItem: function(item) {
					if (!item.isVirtual) {
						return true;
					}
					var canSave = true;
					var displayColumns = this.getDisplayColumns();
					this.Terrasoft.each(item.changedValues, function(changedValue, columnName) {
						canSave = !this.Ext.isEmpty(changedValue) &&
							this.Ext.Array.contains(displayColumns, columnName);
						return !canSave;
					}, this);
					return canSave;
				},

				/**
				 * Returns type column configuration object.
				 * @protected
				 * @return {Object} Configuration object.
				 */
				getTypeColumnConfig: this.Terrasoft.emptyFn,

				/**
				 * Generates array of queries for editing/adding/deleting.
				 * @protected
				 * @return {Array} Array of queries.
				 */
				getSaveItemsQueries: function() {
					var collection = this.getCollection();
					var saveQueries = [];
					collection.each(function(item) {
						var isChanged = !this.Ext.isEmpty(item.changedValues) || item.isDeleted;
						var isValid = item.isDeleted || item.validate();
						if (isChanged && isValid && this.canSaveVirtualItem(item)) {
							var query = item.getSaveQuery();
							if (this.Terrasoft.isInstanceOfClass(query, "Terrasoft.BaseQuery")) {
								saveQueries.push(query);
							}
						}
					}, this);
					return saveQueries;
				},

				/**
				 * Updates detail items state after save.
				 * @protected
				 */
				updateItemsState: function() {
					var collection = this.getCollection();
					collection.each(function(item) {
						var isNotModified = this.Ext.isEmpty(item.insertQuery) &&
							this.Ext.isEmpty(item.updateQuery) && this.Ext.isEmpty(item.deleteQuery);
						item.isNew = item.isNew && isNotModified;
						item.isVirtual = item.isVirtual && isNotModified;
						if (!item.isNew && !item.isVirtual) {
							item.changedValues = null;
						}
					}, this);
				},

				/**
				 * Handles detail's saving.
				 * @protected
				 * @param {Object} response Object with saving result.
				 */
				onSaved: function(response) {
					var message = response.errorInfo && response.errorInfo.message;
					if (response.success && !message) {
						this.updateItemsState(response);
						this.publishSaveResponse(response);
					} else {
						this.publishSaveResponse({
							success: false,
							message: this.getErrorMessage(message)
						});
					}
				},

				/**
				 * Creates error message.
				 * @protected
				 * @param {String} message Message.
				 * @return {String} Result string with error message.
				 */
				getErrorMessage: function(message) {
					var messageTemplate = this.get("Resources.Strings.ErrorTemplate");
					return this.Ext.String.format(messageTemplate,
						this.get("Resources.Strings.Caption") + (message ? ":" + message : ""));
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"parentName": "Detail",
				"name": "FieldsDetailContainer",
				"propertyName": "items",
				"values": {
					"generator": "ConfigurationItemGenerator.generateContainerList",
					"idProperty": "Id",
					"collection": "Collection",
					"dataItemIdPrefix": "field-detail-item",
					"onGetItemConfig": "initDetailRowViewConfig",
					"classes": {
						"wrapClassName": ["fields-detail-container"]
					}
				}
			}, {
				"operation": "insert",
				"name": "AddRecordButton",
				"parentName": "Detail",
				"propertyName": "tools",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"click": {
						"bindTo": "onAddRecordButtonClick"
					},
					"visible": {
						"bindTo": "getToolsVisible"
					},
					"enabled": true,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.AddButtonImage"
					}
				}
			}]
		}; /**SCHEMA_DIFF*/
	}
);
