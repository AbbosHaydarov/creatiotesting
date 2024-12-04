define("BaseEditableSpecificationDetailV2", ["ViewUtilities", "BaseEditableSpecificationDetailV2Resources",
		"LookupUtilities", "ConfigurationEnums", "SpecificationInObject", "SpecificationBankConstants",
		"BaseEditableSpecificationInObjectViewModel", "css!BaseEditableSpecificationInObjectViewModel", "BaseDetailV2"
	], function(ViewUtilities, resources, LookupUtilities, enums, SpecificationInObject, SpecificationBankConstants) {
		return {
			entitySchemaName: "SpecificationInObject",
			messages: {
				/**
				 * @message LeadTypeChanged
				 * ### ######### #### ########### - ######### #########.
				 */
				"LeadTypeChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message LookupInfo
				 * ### ###### LookupUtilities.
				 */
				"LookupInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message ResultSelectedRows
				 * ### ###### LookupUtilities.
				 */
				"ResultSelectedRows": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message UpdateCardProperty
				 * ############# ######## ######## ##############.
				 */
				"UpdateCardProperty": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message ValidateDetail
				 * ########## ############# ############### ######## ######.
				 */
				"ValidateDetail": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message DetailValidated
				 * ########## ######### ######### ######.
				 */
				"DetailValidated": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message SaveDetail
				 * ########## ########## ######.
				 */
				"SaveDetail": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message DetailValidated
				 * ########## ######### ##########.
				 */
				"DetailSaved": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message CardChanged
				 * ######## ## ######### ######### ########.
				 */
				"CardChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message GetRecordInfo
				 * ######## ###### # #######.
				 */
				"GetRecordInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message DetailLoaded
				 * Tells about loading detail.
				 */
				"DetailLoaded": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onRender
				 * @overridden
				 */
				onRender: function() {
					this.callParent(arguments);
					this.sandbox.publish("DetailLoaded", null, [this.sandbox.id]);
				},

				/**
				 * Opens a lookup in modal window.
				 * @protected
				 * @param {Object} config Lookup configuration.
				 * @param {Function} callback The callback function.
				 * @param {Object} scope Scope for the callback function.
				 */
				openLookup: function(config, callback, scope) {
					LookupUtilities.Open(this.sandbox, config, callback, scope || this, null, false, false);
				},

				/**
				 * Initializes detail's collection.
				 * @protected
				 */
				initCollection: function() {
					var collection = this.get("Collection");
					collection.on("itemChanged", this.onItemChanged, this);
				},

				/**
				 * Clears collection.
				 * @protected
				 */
				clearContainerList: function() {
					var collection = this.get("Collection");
					collection.clear();
				},

				/**
				 * Loads data collection.
				 * @protected
				 * @param {GUID} copiedRecordId Id of record for copying.
				 * @param {Function} callback Function for postprocessing of loading.
				 */
				loadContainerListData: function(copiedRecordId, callback) {
					this.Terrasoft.chain(
						function(next) {
							this.loadSpecificationsInObject(copiedRecordId, next);
						},
						function() {
							this.Ext.callback(callback, this);
						},
						this);
				},

				/**
				 * Gets class name of view model for the returned object.
				 * @protected
				 * @return {String} View model class name.
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.BaseEditableSpecificationInObjectViewModel";
				},

				/**
				 * Creates Terrasoft.EntitySchemaQuery instance for receiving detail data, initializes rootSchemaName
				 * and rowViewModelClassName properties.
				 * @protected
				 * @param {String} rootSchemaName Root schema name
				 * @return {Terrasoft.EntitySchemaQuery} Instance of Terrasoft.EntitySchemaQuery class.
				 */
				getDetailDataEsq: function(rootSchemaName) {
					return this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: rootSchemaName,
						rowViewModelClassName: this.getRowViewModelClassName()
					});
				},

				/**
				 * Adds columns to entity schema query.
				 * @protected
				 * @throws {Terrasoft.ArgumentNullOrEmptyException} If any argument is empty.
				 * @param {Terrasoft.EntitySchemaQuery} esq Instance of Terrasoft.EntitySchemaQuery class.
				 * @param {{ path: String, alias: String }[]} columns Array of paths and aliases for columns.
				 */
				addEsqColumns: function(esq, columns) {
					if (this.Ext.isEmpty(esq)) {
						throw new Terrasoft.ArgumentNullOrEmptyException({argumentName: "esq"});
					}
					if (this.Ext.isEmpty(columns)) {
						throw new Terrasoft.ArgumentNullOrEmptyException({argumentName: "columns"});
					}
					this.Terrasoft.each(columns, function(column) {
						esq.addColumn(column.path, column.alias);
					}, this);
				},

				/**
				 * Filters entity schema query for loading specifications by master record.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query instance.
				 * @param {Guid} masterRecordId Id of master record to filter.
				 */
				addMasterRecordFilter: function(esq, masterRecordId) {
					var masterColumn = this.get("DetailColumnName");
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, masterColumn, masterRecordId));
				},

				/**
				 * Loads collection of saved specifications.
				 * @param {Guid} entityId Id of record for loading specifications.
				 * @param {Function} callback Function for postprocessing of the loading.
				 */
				loadSpecificationsInObject: function(entityId, callback) {
					var esq = this.getDetailDataEsq(this.entitySchemaName);
					var columns = [
						{path: "Specification"},
						{
							path: "Specification.Type",
							alias: "DataType"
						},
						{path: "StringValue"},
						{path: "IntValue"},
						{path: "FloatValue"},
						{path: "BooleanValue"},
						{path: "ListItemValue"},
						{path: this.get("DetailColumnName")}
					];
					this.addEsqColumns(esq, columns);
					this.addMasterRecordFilter(esq, entityId || this.get("MasterRecordId"));
					esq.getEntityCollection(function(result) {
						this.specificationsInObjectLoadedCallback(result, entityId, callback);
					}, this);
				},

				/**
				 * Handles loading specifications in object.
				 * @protected
				 * @param {Object} result Object with the result of specifications loading.
				 * @param {Guid} entityId Id of record for loading specifications.
				 * @param {Function} callback Function that must be called after specifications loading.
				 */
				specificationsInObjectLoadedCallback: function(result, entityId, callback) {
					if (result.success) {
						this.loadSpecificationsCollection(result.collection, !this.Ext.isEmpty(entityId));
						this.Ext.callback(callback, this);
					}
				},

				/**
				 * Loads the collection of specification.
				 * @protected
				 * @param {Terrasoft.Collection} collection Collection of specifications.
				 * @param {Boolean} needsToSetChangedValues If true, will be set "changedValues" for each specification.
				 */
				loadSpecificationsCollection: function(collection, needsToSetChangedValues) {
					if (this.Ext.isEmpty(collection) || this.Ext.isEmpty(collection.getItems())) {
						return;
					}
					collection.each(function(item) {
						if (needsToSetChangedValues) {
							this.setChangedValues(item);
						}
						item.entitySchema = this.entitySchema;
						item.sandbox = this.sandbox;
						item.columns = this.columns;
						item.set("DetailColumnName", this.get("DetailColumnName"));
					}, this);
					var currentCollection = this.get("Collection");
					currentCollection.loadAll(collection);
				},

				/**
				 * Sets changedValues for element using decoration.
				 * @protected
				 * @param {object} item Element for decoration.
				 */
				setChangedValues: function(item) {
					item.isNew = true;
					item.changedValues = {};
					item.changedValues.Specification = item.get("Specification");
					var type = item.get("DataType").value;
					var dataType = SpecificationBankConstants.DataTypes[type].type;
					this.setChangedValue(item, dataType + "Value");
					var name = this.values.DefaultValues[0].name;
					if (item.get(name)) {
						item.set("CopiedRecordId", item.get(name).value);
					}
					item.set(name, {
						"value": this.values.DefaultValues[0].value
					});
				},

				/**
				 * Sets column value to changedValues object for passed element.
				 * @protected
				 * @param {object} item Model for setting values.
				 */
				setChangedValue: function(item) {
					var columns = Array.prototype.slice.call(arguments, 1);
					columns.forEach(function(column) {
						var value = item.get(column);
						value = this.Ext.isObject(value) ? value.value : value;
						if (!this.Ext.isEmpty(value)) {
							item.changedValues[column] = value;
						}
					});
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					var sandboxId = this.sandbox.id;
					this.sandbox.subscribe("ValidateDetail", this.validateDetail, this, [sandboxId]);
					this.sandbox.subscribe("SaveDetail", this.save, this, [sandboxId]);
					this.sandbox.subscribe("LeadTypeChanged", this.leadTypeChanged, this, [sandboxId]);
				},

				/**
				 * Filters entity schema query for lead specifications by lead type.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query instance.
				 * @param {Guid} leadTypeId Id of lead type to filter.
				 */
				addLeadTypeFilter: function(esq, leadTypeId) {
					esq.filters.add("LeadTypeFilter", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "LeadType", leadTypeId));
				},

				/**
				 * Handles lead type changing.
				 * @protected
				 * @param {Object} leadTypeInfo Object with additional information.
				 */
				leadTypeChanged: function(leadTypeInfo) {
					if (this.Ext.isEmpty(leadTypeInfo) || this.Ext.isEmpty(leadTypeInfo.leadType)) {
						return;
					}
					if (leadTypeInfo.isClearParams) {
						var collection = this.get("Collection");
						collection.each(function(item) {
							item.isDeleted = true;
							item.set("isDeleted", true);
						});
					}

					var esq = this.getDetailDataEsq("SpecificationInLeadType");
					var columns = [
						{path: "Specification"},
						{
							path: "Specification.Type",
							alias: "DataType"
						},
						{path: "LeadType"}
					];
					this.addEsqColumns(esq, columns);
					this.addLeadTypeFilter(esq, leadTypeInfo.leadType.value);
					esq.getEntityCollection(this.specificationsForLeadTypeLoadedCallback, this);
				},

				/**
				 * Handles loading specifications for lead type.
				 * @protected
				 * @param {Object} result Object with result data.
				 */
				specificationsForLeadTypeLoadedCallback: function(result) {
					if (result.success) {
						this.saveSilent(function() {
							this.clearContainerList();
							this.loadSpecificationsCollection(result.collection, true);
						}, this);
					}
				},

				/**
				 * Validates detail's fields.
				 * @protected
				 * @return {Boolean} True if detail is valid, otherwise false.
				 */
				validateDetail: function() {
					var invalidFields = this.validateItems();
					var result = invalidFields.length > 0;
					var resultObject = {
						success: !result
					};
					if (!resultObject.success) {
						var message = "";
						this.Terrasoft.each(invalidFields, function(field) {
							message += this.getValidationMessage(field) + "\n";
						}, this);
						resultObject.message = message;
					}
					this.sandbox.publish("DetailValidated", resultObject, [this.sandbox.id]);
					return !result;
				},

				/**
				 * Generates message for failing of validation.
				 * @protected
				 * @param {String} fieldName Field name.
				 */
				getValidationMessage: function(fieldName) {
					var messageTemplate = this.get("Resources.Strings.ValidationErrorTemplate");
					return this.Ext.String.format(messageTemplate, fieldName);
				},

				/**
				 * Initializes validation of all parameters before detail's saving.
				 * @protected
				 * @return {Array} Collection of non-valid fields.
				 */
				validateItems: function() {
					var collection = this.get("Collection");
					var invalidFields = [];
					collection.each(function(item) {
						var isChanged = item.changedValues ? true : false;
						var isDeleted = item.isDeleted;
						if (isChanged && !isDeleted && !item.validate()) {
							var specification = item.get("Specification");
							invalidFields.push(specification.displayValue);
						}
					}, this);
					return invalidFields;
				},

				/**
				 * Generates array of queries for editing/adding/deleting.
				 * @protected
				 * @return {Array} Array of queries.
				 */
				getSaveItemsQueries: function() {
					var collection = this.get("Collection");
					var saveQueries = [];
					collection.each(function(item) {
						var isChanged = item.changedValues || item.isDeleted;
						var isValid = item.isDeleted || item.validate();
						if (isChanged && isValid) {
							var query = item.getSaveQuery();
							if (query) {
								saveQueries.push(query);
							}
						}
					}, this);
					return saveQueries;
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
						this.Ext.callback(callback, scope || this, [{success: true}]);
						return;
					}
					var batchQuery = this.Ext.create("Terrasoft.BatchQuery");
					this.Terrasoft.each(queries, function(query) {
						batchQuery.add(query);
					}, this);
					batchQuery.execute(callback, scope);
				},

				/**
				 * Handles detail's saving.
				 * @protected
				 * @param {Object} response Object with saving result.
				 */
				onSaved: function(response) {
					var message = response.ResponseStatus && response.ResponseStatus.Message;
					if (response.success && !message) {
						var collection = this.get("Collection");
						collection.each(function(item) {
							item.isNew = false;
							item.changedValues = null;
						}, this);
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
				},

				/**
				 * Publish a message about detail's saving.
				 * @protected
				 * @param {Object} config Message params
				 */
				publishSaveResponse: function(config) {
					this.sandbox.publish("DetailSaved", config, [this.sandbox.id]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#updateDetail
				 * @overridden
				 */
				updateDetail: function() {
					this.callParent(arguments);
					var detailInfo = this.sandbox.publish("GetDetailInfo", null, [this.sandbox.id]) || {};
					this.set("MasterRecordId", detailInfo.masterRecordId);
					this.set("DetailColumnName", detailInfo.detailColumnName);
					this.set("Filter", detailInfo.filter);
					this.set("CardPageName", detailInfo.cardPageName);
					this.set("SchemaName", detailInfo.schemaName);
					this.set("DefaultValues", detailInfo.defaultValues);
					this.initCollection();
					this.clearContainerList();
					this.loadContainerListData(null, function() {});
				},

				/**
				 * Set detail's collapsing.
				 * @protected
				 * @param {Boolean} isCollapsed Flag that shows detail's collapsing/uncollapsing.
				 */
				setDetailCollapse: function(isCollapsed) {
					this.set("IsDetailCollapsed", isCollapsed);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#init
				 * @overridden
				 */
				init: function(callback) {
					this.callParent([function() {
						this.initCollection();
						this.setDetailCollapse(false);
						this.clearContainerList();
						var copiedRecordId = null;
						var args = this.sandbox.publish("GetRecordInfo", null, [this.sandbox.id]);
						if (args && args.operation === enums.CardStateV2.COPY) {
							copiedRecordId = args.copiedRecordId;
						}
						this.loadContainerListData(copiedRecordId, callback);
					}, this]);
				},

				/**
				 * Creates view configuration of element in depend on section.
				 * @protected
				 * @param {Object} itemConfig Link on element configuration in ContainerList.
				 */
				getItemViewConfig: function(itemConfig) {
					var itemViewConfig = this.get("itemViewConfig");
					if (itemViewConfig) {
						itemConfig.config = itemViewConfig;
						return;
					}
					var config = ViewUtilities.getContainerConfig("item-view",
						["detail-edit-container-user-class", "control-width-15"]);
					config.visible = {
						bindTo: "isDeleted",
						bindConfig: {
							"converter": "getConfigVisible"
						}
					};
					config.markerValue = {
						bindTo: "getLabelCaption"
					};
					var labelConfig = {
						className: "Terrasoft.Label",
						classes: {
							labelClass: ["label-wrap", "control-left", "label-specificationInObject-user-class"]
						},
						caption: {
							bindTo: "getLabelCaption"
						},
						click: {
							bindTo: "onLabelClick"
						}
					};
					var stringEditConfig = {
						id: "StringEdit",
						className: "Terrasoft.TextEdit",
						classes: {
							wrapClass: ["base-edit-specificationInObject-user-class"]
						},
						value: {
							bindTo: "StringValue"
						},
						visible: {
							bindTo: "getControlVisible"
						},
						tag: "String"
					};
					var intEditConfig = {
						id: "IntEdit",
						className: "Terrasoft.IntegerEdit",
						classes: {
							wrapClass: ["base-edit-specificationInObject-user-class"]
						},
						value: {
							bindTo: "IntValue"
						},
						visible: {
							bindTo: "getControlVisible"
						},
						tag: "Int"
					};
					var floatEditConfig = {
						id: "FloatEdit",
						className: "Terrasoft.FloatEdit",
						classes: {
							wrapClass: ["base-edit-specificationInObject-user-class"]
						},
						value: {
							bindTo: "FloatValue"
						},
						visible: {
							bindTo: "getControlVisible"
						},
						tag: "Float"
					};
					var booleanEditConfig = {
						id: "BooleanEdit",
						className: "Terrasoft.CheckBoxEdit",
						classes: {
							wrapClass: ["check-box-edit-specificationInObject-user-class"]
						},
						checked: {
							bindTo: "BooleanValue"
						},
						visible: {
							bindTo: "getControlVisible"
						},
						tag: "Boolean"
					};
					var lookupEditConfig = {
						id: "ComboBoxEdit",
						className: "Terrasoft.ComboBoxEdit",
						classes: {
							wrapClass: ["base-edit-specificationInObject-user-class"]
						},
						value: {
							bindTo: "ListItemValue"
						},
						visible: {
							bindTo: "getControlVisible"
						},
						list: {
							bindTo: "ListItemValues"
						},
						prepareList: {
							bindTo: "prepareListItemValues"
						},
						tag: "ListItem"
					};
					var deleteButtonConfig = {
						id: "delete",
						className: "Terrasoft.Button",
						classes: {
							wrapperClass: "detail-delete-btn-user-class",
							imageClass: ["detail-delete-btn-image-user-class", "close-button-background-no-repeat"]
						},
						imageConfig: resources.localizableImages.DeleteIcon,
						style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						selectors: {
							wrapEl: "#delete"
						},
						click: {
							bindTo: "deleteItem"
						},
						markerValue: {
							bindTo: "getDeleteMarkerValue"
						}
					};
					config.items.push(labelConfig, stringEditConfig, intEditConfig, floatEditConfig,
						booleanEditConfig, lookupEditConfig, deleteButtonConfig);
					itemConfig.config = config;
				},

				/**
				 * ########## ### #######, ############ ### #### ### ######### ######## ## #######.
				 * @return {String}
				 */
				getDataGridName: function() {
					return "";
				},

				/**
				 * ########## ######### ######### ######.
				 */
				onItemChanged: function() {
					this.changeStateCard(true);
				},

				/**
				 * ############# ######## ######## ## ####### ######### ######.
				 * @param {String} key ############ ########
				 * @param {bool} value ######## ########
				 * @param {Object} options ############## ########
				 */
				updateCardProperty: function(key, value, options) {
					this.sandbox.publish("UpdateCardProperty", {
						key: key,
						value: value,
						options: options
					}, [this.sandbox.id]);
				},

				/**
				 * ######## ######### ########.
				 * @param {Boolean} isVisible #### ###### ###### "#########" # "######" ######## ############.
				 */
				changeStateCard: function(isVisible) {
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
				 * ######## #### ########### ### ########## #########.
				 */
				loadSpecificationsLookup: function() {
					var filterGroup = this.Terrasoft.createFilterGroup();
					var existsFilter = this.getNotExistsFilter("Id");
					if (existsFilter) {
						filterGroup.addItem(existsFilter);
					}
					var config = {
						entitySchemaName: "Specification",
						filters: filterGroup,
						multiSelect: true,
						columns: ["Name", "Type"]
					};
					this.openLookup(config, this.loadSpecificationsLookupCallback, this);
				},

				/**
				 * ###### ### ########## ### ########### ##########
				 * @param {String} column - ## ##### ####### ###########
				 * @return {Object} ######
				 */
				getNotExistsFilter: function(column) {
					var collection = this.get("Collection");
					var addedSpecification = [];
					var filter = null;
					collection.each(function(item) {
						var specification = item.get("Specification");
						if (!this.Ext.isEmpty(specification) && !item.isDeleted) {
							addedSpecification.push(specification.value);
						}
					}, this);
					if (addedSpecification.length) {
						filter = this.Terrasoft.createColumnInFilterWithParameters(column, addedSpecification);
						filter.comparisonType = Terrasoft.ComparisonType.NOT_EQUAL;
					}
					return filter;
				},

				/**
				 * The callback function for adding of a parameter from lookup.
				 * @param {Object} args Object with specified parameters
				 */
				loadSpecificationsLookupCallback: function(args) {
					var collection = args.selectedRows;
					collection.each(function(item) {
						var specification = {
							value: item.Id,
							displayValue: item.Name
						};
						var dataType = item.Type;
						var tag = {
							Specification: specification,
							DataType: dataType
						};
						var newItem = this.Ext.create("Terrasoft.BaseEditableSpecificationInObjectViewModel", {
							entitySchema: this.entitySchema,
							columns: this.columns
						});
						var newItemId = this.Terrasoft.generateGUID();
						var masterColumn = this.get("DetailColumnName");
						var masterRecordId = this.get("MasterRecordId");
						newItem.set(masterColumn, {
							value: masterRecordId
						});
						newItem.set("Specification", tag.Specification);
						newItem.set("DataType", tag.DataType);
						newItem.set("DetailColumnName", this.get("DetailColumnName"));
						newItem.sandbox = this.sandbox;
						newItem.set("Id", newItemId);
						collection = this.get("Collection");
						var indexNewItem = collection.getCount();
						collection.add(newItemId, newItem, indexNewItem);
						this.changeStateCard(true);
					}, this);
				}
			},
			diff: [{
				"operation": "insert",
				"parentName": "Detail",
				"name": "OpportunitySpecificationsContainer",
				"propertyName": "items",
				"values": {
					"generator": "ConfigurationItemGenerator.generateContainerList",
					"idProperty": "Id",
					"collection": "Collection",
					"observableRowNumber": 100,
					"onGetItemConfig": "getItemViewConfig"
				}
			}, {
				"operation": "insert",
				"name": "AddRecordButton",
				"parentName": "Detail",
				"propertyName": "tools",
				"values": {
					"visible": {
						bindTo: "getToolsVisible"
					},
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"click": {
						bindTo: "loadSpecificationsLookup"
					},
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.AddButtonImage"
					}
				}
			}]
		};
	}
);
