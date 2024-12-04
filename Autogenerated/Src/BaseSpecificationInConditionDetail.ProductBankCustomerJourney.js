define("BaseSpecificationInConditionDetail", ["SpecificationBuilderConstants", "SpecInCondition", "SpecTableValue",
	"SpecificationBuilderModule", "Switcher", "BaseSpecificationInConditionDetailResources",
	"ProductConditionSpecificationRowViewModel"],
	function(SpecificationBuilderConstants, SpecInCondition, SpecTableValue) {
		return {
			entitySchemaName: "Specification",
			messages: {

				/**
				 * @message RerenderBuilder
				 */
				"RerenderBuilder": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message DetailSaved
				 */
				"DetailSaved": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message LoadRowsConfig
				 */
				"LoadRowsConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message UpdateCardProperty
				 */
				"UpdateCardProperty": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message GetBuilderConfig
				 */
				"GetBuilderConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message SetBuilderConfig
				 */
				"SetBuilderConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message DiscardChanges
				 */
				"DiscardChanges": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message SaveDetail
				 * ########## ########## ######.
				 */
				"SaveDetail": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "Detail",
					"values": {
						"caption": ""
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {

				/**
				 * @inheritdoc BaseGridDetailV2#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initRowCollection();
					this.subscribeOnEvents();
				},

				/**
				 * ######### ###### ############ ##########.
				 * @protected
				 * @param {Object} config ###### ## ########## ### #########.
				 */
				onAfterRender: function(config) {
					this.loadModule(config);
				},

				/**
				 * ######### ########### SpecificationBuilder.
				 * @protected
				 * @param {Object} config ###### ## ########## ### #########.
				 */
				onAfterReRender: function(config) {
					var buiderModuleId = this.getModuleId("SpecificationBuilderModule");
					this.sandbox.publish("RerenderBuilder", config, [buiderModuleId]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#initDetailOptions
				 * @overridden
				 */
				initDetailOptions: function() {
					this.callParent(arguments);
					this.set("IsDetailCollapsed", false);
				},

				/**
				 * ########## ######### #####.
				 * @protected
				 * @return {Terrasoft.BaseViewModelCollection} ######### #####.
				 */
				getRowsCollection: function() {
					return this.get("RowsCollection");
				},

				/**
				 * ######## ###### ###### ## ##.
				 * @private
				 */
				loadDetailRecords: function() {
					var rowsCollection = this.getRowsCollection();
					rowsCollection.clear();
					this.showBodyMask();
					this.loadRowsCollection(function(configCollection) {
						var builderModuleId = this.getModuleId("SpecificationBuilderModule");
						this.sandbox.publish("LoadRowsConfig", configCollection, [builderModuleId]);
						this.hideBodyMask();
					});
				},

				/**
				 * ######### ############ ######.
				 * @private
				 */
				getModuleId: function(moduleName) {
					return this.sandbox.id + "_" + moduleName;
				},

				/**
				 * ######## ## #########.
				 * @protected
				 */
				subscribeOnEvents: function() {
					var builderModuleId = this.getModuleId("SpecificationBuilderModule");
					this.sandbox.subscribe("GetBuilderConfig", function(config) {
						this.setBuilderConfig(config);
						this.loadDetailRecords();
					}, this, [builderModuleId]);
					this.sandbox.subscribe("DiscardChanges", this.onDiscardChanges, this, [this.sandbox.id]);
					this.sandbox.subscribe("SaveDetail", this.save, this, [this.sandbox.id]);
				},

				/**
				 * ######### ############ ###### ### ###### ######### # ########.
				 * @protected
				 */
				onDiscardChanges: function() {
					this.updateDetail();
				},

				/**
				 * ######### ############ ######.
				 * @protected
				 */
				updateDetail: function() {
					this.loadDetailRecords();
					var deletedRecords = this.getDeletedRecords();
					deletedRecords.clear();
				},

				/**
				 * ########## ######### ######### ### ########.
				 * @protected
				 * @return {Terrasoft.BaseViewModelCollection} ######### ######### ### ########.
				 */
				getDeletedRecords: function() {
					return this.get("DeletedRowsCollection");
				},

				/**
				 * ############ ######## ######.
				 * @private
				 * @param {Guid} id ############# ######## ######### ######### ### ########.
				 * @param {Terrasoft.Collection} deletedRecords ######### ######### ### ########.
				 * @param {Object} response ###### - ##### ## #######.
				 * @param {Function} next ####### - ######### # ####### #######.
				 * @param {Object} scope ######## ##########.
				 */
				deleteRecordCallback: function(id, deletedRecords, response, next, scope) {
					if (response.success) {
						deletedRecords.removeByKey(id);
						if (deletedRecords.getCount() === 0) {
							if (this.Ext.isFunction(next)) {
								next.call(scope || this);
							}
						}
					} else {
						throw new this.Terrasoft.QueryExecutionException();
					}
				},

				/**
				 * ######### ######## #######, ########## ## ########.
				 * @param {Function} next ####### - ######### # ####### #######.
				 * @private
				 */
				deleteRecords: function(next) {
					var deletedRecords = this.getDeletedRecords();
					if (deletedRecords.isEmpty()) {
						next();
					}
					deletedRecords.each(function(item) {
						var id = item.get("Id");
						if (item.isNew) {
							deletedRecords.removeByKey(id);
							if (deletedRecords.getCount() === 0) {
								next();
							}
						} else {
							item.deleteEntity(function(response) {
								this.deleteRecordCallback(id, deletedRecords, response, next, this);
							}, this);
						}
					}, this);
				},

				/**
				 * ############ ########## ######.
				 * @private
				 * @param {Object} response ###### - ##### ## #######.
				 */
				validateSaveEntityResponse: function(response) {
					if (!response.success) {
						throw new this.Terrasoft.QueryExecutionException();
					}
				},

				/**
				 * ######### ########## ####### ## ######.
				 * @private
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ####### ######### ######.
				 */
				saveRecords: function(callback, scope) {
					var rowsCollection = this.getRowsCollection();
					var rowsItems = rowsCollection.getItems();
					var chainArguments = [];
					this.Terrasoft.each(rowsItems, function(rowItem) {
						var rowValuesCollection = rowItem.getRowValuesCollection();
						var rowValues = rowValuesCollection.getItems();
						this.Terrasoft.each(rowValues, function(item) {
							chainArguments.push(function(next) {
								if (item.canSave()) {
									item.saveEntity(function(response) {
										this.validateSaveEntityResponse(response);
										next();
									}, this);
								} else {
									next();
								}
							});
						}, this);
					}, this);
					chainArguments.push(function() {
						callback.call(scope);
					});
					this.Terrasoft.chain.apply(this, chainArguments);
				},

				/**
				 * ########## #### ## ## ### ####### ###### ########.
				 * @private
				 * @param  {Terrasoft.BaseViewModel} viewModel ###### ####### ######## ######## #### #######.
				 * @return {bool} ########## true, #### ###### ###### ####### ## ### #######.
				 */
				hasEmptyValue: function(viewModel) {
					var values = viewModel.get("RowValuesCollection");
					var result = values.filterByFn(function(item) {
						if (!item.get("IsTools")) {
							return !item.canSave();
						}
					}, this);
					return values.getCount() === 1 || !result.isEmpty();
				},

				/**
				 * ########## #### ## # #### ####### ###### ########.
				 * @private
				 * @param  {Terrasoft.BaseViewModel} item ###### ####### ######## ######## #### #######.
				 * @return {bool} ########## true, #### # ####### #### ###### ########.
				 */
				hasMatrixEmptyValue: function(item) {
					var horizontalRowViewModel = item.get("HorizontalRowViewModel");
					var verticalRowViewModel = item.get("VerticalRowViewModel");
					if (!this.Ext.isEmpty(horizontalRowViewModel) &&
						!this.Ext.isEmpty(verticalRowViewModel)) {
						return this.hasEmptyValue(horizontalRowViewModel) ||
							this.hasEmptyValue(verticalRowViewModel);
					}
				},

				/**
				 * ######### ########### ########## ########## #############.
				 * @private
				 * @return {bool} ########## true, #### ##### ######### #######.
				 */
				canSaveMatrix: function() {
					var rowsCollection = this.get("RowsCollection");
					var emptyValues = rowsCollection.filterByFn(function(row) {
						var rowValuesCollection = row.get("RowValuesCollection");
						var emptyValues = rowValuesCollection.filterByFn(function(item) {
							if (!item.get("IsTools")) {
								return this.hasMatrixEmptyValue(item);
							}
						}, this);
						return !emptyValues.isEmpty();
					}, this);
					return emptyValues.isEmpty();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#save
				 * @overridden
				 */
				save: function() {
					if (this.canSaveMatrix()) {
						this.Terrasoft.chain(
							function(next) {
								this.deleteRecords(next);
							},
							function(next) {
								this.saveRecords(next, this);
							},
							function() {
								this.publishSaveResponse({
									success: true
								});
							},
							this
						);
					} else {
						this.showInformationDialog(this.get("Resources.Strings.CanNotSaveEmptyValue"));
						this.hideBodyMask();
					}
					return true;
				},

				/**
				 * ######### ######### # ###, ### ###### #########.
				 * @private
				 * @param {Object} config ######### #########.
				 */
				publishSaveResponse: function(config) {
					this.sandbox.publish("DetailSaved", config, [this.sandbox.id]);
				},

				/**
				 * ############# ######### ###### SpecificationBuilderModule.
				 * @protected
				 */
				setBuilderConfig: function() {
					var builderModuleId = this.getModuleId("SpecificationBuilderModule");
					var defValues = this.get("DefaultValues");
					defValues.push(
						{
							name: "ProductCondition",
							value: this.get("MasterRecordId")
						},
						{
							name: "SpecificationInConditionType",
							value: this.getSpecInConditionType()
						}
					);
					this.sandbox.publish("SetBuilderConfig", {
						rowsCollection: this.getRowsCollection(),
						rowViewModelClassName: "Terrasoft.ProductConditionSpecificationRowViewModel",
						defaultValues: this.get("DefaultValues")
					}, [builderModuleId]);
				},

				/**
				 * ############## ######### #####.
				 * @protected
				 */
				initRowCollection: function() {
					var collection = this.Ext.create("Terrasoft.BaseViewModelCollection");
					var deletedRecordsCollection = this.Ext.create("Terrasoft.BaseViewModelCollection");
					collection.on("itemChanged", this.onChangeRowsCollection, this);
					this.set("RowsCollection", collection);
					this.set("DeletedRowsCollection", deletedRecordsCollection);
				},

				/**
				 * ######### ######### ######## # ############# ######## ###### ######### # ######.
				 * @protected
				 */
				showSaveDiscardButton: function() {
					var options = ["ShowSaveButton", "ShowDiscardButton"];
					this.Terrasoft.each(options, function(option) {
						this.sandbox.publish("UpdateCardProperty", {
							key: option,
							value: true
						}, [this.sandbox.id]);
					}, this);
				},

				/**
				 * ############ ####### ######### ######### ########.
				 * @protected
				 */
				onChangeRowsCollection: function(item, eventConfig) {
					this.showSaveDiscardButton();
					var deletedRecords = this.getDeletedRecords();
					switch (eventConfig.event) {
						case "onRemove":
							var args = eventConfig.arguments;
							var rowItemValues = args.rowItemValues;
							var removedItems = rowItemValues.getItems();
							this.Terrasoft.each(removedItems, function(item) {
								deletedRecords.add(item.get("Id"), item);
							}, this);
							break;
						case "onRemoveRowItem":
							var removedItem = eventConfig.arguments;
							deletedRecords.add(removedItem.get("Id"), removedItem);
							break;
					}
				},

				/**
				 * ######### ######### ############.
				 * @protected
				 * @param {Terrasoft.Collection} collection ######### ######## ######.
				 * @return {Terrasoft.Collection} ######### ##########.
				 */
				getSpecifications: function(collection) {
					var specifications = this.Ext.create("Terrasoft.Collection");
					var items = collection.getItems();
					this.Terrasoft.each(items, function(item) {
						var specificationId = item.get("Specification");
						specificationId = specificationId && specificationId.value;
						if (!specifications.contains(specificationId)) {
							specifications.add(specificationId, item);
						}
					}, this);
					return specifications;
				},

				/**
				 * ######### ###### ### ########## SpecificationBuilder.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} item ####### #########.
				 * @param {Terrasoft.BaseViewModelCollection} resultCollection ######### ######### ####### ######.
				 * @return {Terrasoft.BaseViewModel} ###### ######## ### SpecificationBuilder.
				 */
				generateSpecificationRowEntity: function(item, resultCollection) {
					var id = item.get("Id");
					var rowValues = this.getSpecificationRowValues(item, resultCollection);
					var value = item.get("Specification") || {};
					value.Type = item.get("SpecificationType");
					var rowEntityConfig = {
						values: {
							Id: id,
							RowValuesCollection: rowValues,
							Value: value,
							CurrentType: item.get("CurrentType")
						}
					};
					return this.Ext.create("Terrasoft.BaseViewModel", rowEntityConfig);
				},

				/**
				 * ########## ######### ######## ### ### # SpecificationMatrixBuilder.
				 * @protected
				 * @param {String} axis ### ###.
				 * @param {Terrasoft.BaseViewModelCollection} collection ######### ######### #######.
				 * @return {Terrasoft.BaseViewModelCollection} ######### ######## ### ### # SpecificationMatrixBuilder.
				 */
				getAxisValues: function(axis, collection) {
					var axisValuesCollection = this.Ext.create("Terrasoft.BaseViewModelCollection");
					var columnPrefix = "SpecTableValue" + axis + ".";
					var axisNameId = columnPrefix + "Id";
					var typeColumnName = axis + "SpecificationTypeId";
					var axisCurrentTypeName = columnPrefix + "CurrentType";
					collection.each(function(item) {
						var id = item.get(axisNameId);
						if (!axisValuesCollection.contains(id)) {
							var type = item.get(typeColumnName);
							var axisCurrentType = item.get(axisCurrentTypeName);
							var dataValueType = this.getDataValueTypeBySpecificationType(type);
							var entity = this.createAxisValueEntity(item, columnPrefix);
							entity.set("DataValueType", dataValueType);
							entity.set("CurrentType", axisCurrentType);
							axisValuesCollection.add(id, entity);
						}
					}, this);
					return axisValuesCollection;
				},

				/**
				 * ########## ######### ######## ### SpecificationMatrixBuilder.
				 * @protected
				 * @param {Terrasoft.BaseViewModelCollection} matrixItems ######### ######### ####### ######### ########.
				 * @return {Terrasoft.BaseViewModelCollection} ######### ######## ### SpecificationMatrixBuilder.
				 */
				getMatrixValues: function(matrixItems) {
					var matrixValues = this.Ext.create("Terrasoft.BaseViewModelCollection");
					matrixItems.each(function(item) {
						var id = item.get("Id");
						if (!matrixValues.contains(id)) {
							var matrixEntity = this.createSpecificationValueEntity(item);
							matrixValues.add(id, matrixEntity);
						}
					}, this);
					return matrixValues;
				},

				/**
				 * ########## ###### ######## ### SpecificationMatrixBuilder.
				 * @protected
				 * @param {String} axisName ######## ### SpecificationMatrixBuilder.
				 * @param {Terrasoft.BaseViewModelCollection} matrixItems ######### ######### ####### ###.
				 * @return {Terrasoft.BaseViewModel} ###### ######## ### ### SpecificationMatrixBuilder.
				 */
				createAxisEntity: function(axisName, matrixItems) {
					var axisValuesCollection = this.getAxisValues(axisName, matrixItems);
					var firstItem = matrixItems.getByIndex(0);
					var columnPrefix = "SpecTableValue" + axisName + ".";
					var axisParameterValue, axisCurrentType, dataValueType;
					if (!this.Ext.isEmpty(firstItem)) {
						axisParameterValue = firstItem.get(columnPrefix + "Specification") || {};
						var typeId = firstItem.get(axisName + "SpecificationTypeId");
						axisParameterValue.Type = {value: typeId};
						axisCurrentType = firstItem.get(columnPrefix + "CurrentType");
						dataValueType = this.getDataValueTypeBySpecificationType(typeId);
					}
					var entityConfig = {
						primaryColumnName: "Id",
						values: {
							Value: axisParameterValue,
							DataValueType: dataValueType,
							CurrentType: axisCurrentType,
							RowValuesCollection: axisValuesCollection
						}
					};
					return this.Ext.create("Terrasoft.BaseViewModel", entityConfig);
				},

				/**
				 * ####### ###### ### ######## ###.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} item ####### ######## ###.
				 * @param {String} columnPrefix ####### ######## #######.
				 * @return {Terrasoft.BaseViewModel} ######-###### ### ######## ### # SpecificationMatrixBuilder.
				 */
				createAxisValueEntity: function(item, columnPrefix) {
					var entity = this.Ext.create("Terrasoft.BaseViewModel", {
						primaryColumnName: "Id"
					});
					var itemColumns = item.columns;
					var entityColumns = entity.columns;
					this.Terrasoft.each(SpecTableValue.columns, function(column, columnName) {
						var fullColumnName = columnPrefix + columnName;
						if (itemColumns.hasOwnProperty(fullColumnName)) {
							entityColumns[columnName] = column;
							var value = item.get(fullColumnName);
							entity.set(columnName, value);
						}
					}, this);
					return entity;
				},

				/**
				 * ########## ######### ######### ## ###### #### #########.
				 * @public
				 * @param {Terrasoft.BaseViewModel} specificationId ############# #### #########.
				 * @param {Terrasoft.BaseViewModelCollection} collection ######## ######.
				 * @return {Terrasoft.BaseViewModelCollection} ######### ######### #######.
				 */
				getMatrixItemsBySpecification: function(specificationId, collection) {
					var rowItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					collection.each(function(item) {
						var itemSpecification = item.get("Specification");
						var itemSpecificationId = itemSpecification && itemSpecification.value;
						if (itemSpecificationId === specificationId) {
							var typeId = item.get("SpecificationTypeId");
							var dataValueType = this.getDataValueTypeBySpecificationType(typeId);
							item.set("DataValueType", dataValueType);
							rowItems.add(item.get("Id"), item);
						}
					}, this);
					return rowItems;
				},

				/**
				 * ######### ###### ######## ### ########## SpecificationMatrixBuilder.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} item ####### #########.
				 * @param {Terrasoft.Collection} resultCollection ######### ######### #######.
				 * @return {Terrasoft.BaseViewModel} ###### ######## ### SpecificationMatrixBuilder.
				 */
				generateMatrixEntity: function(item, resultCollection) {
					var id = item.get("Id");
					var specification = item.get("Specification");
					var specificationId = specification && specification.value;
					var matrixItems = this.getMatrixItemsBySpecification(specificationId, resultCollection);
					var matrixValues = this.getMatrixValues(matrixItems);
					var value = item.get("Specification");
					value.Type = item.get("SpecificationType");
					var rowEntityConfig = {
						values: {
							Id: id,
							MatrixValuesCollection: matrixValues,
							XAxisEntity: this.createAxisEntity("X", matrixItems),
							YAxisEntity: this.createAxisEntity("Y", matrixItems),
							Value: value
						}
					};
					return this.Ext.create("Terrasoft.BaseViewModel", rowEntityConfig);
				},

				/**
				 * ######### ######### ##### ### ########## SpecificationBuilder.
				 * @protected
				 * @param {Terrasoft.BaseViewModelCollection} resultCollection ######### ######### ####### ######.
				 * @return {Array} ###### ######## ### #####.
				 */
				generateRowEntities: function(resultCollection) {
					var rowsCollection = this.Ext.create("Terrasoft.Collection");
					var specifications = this.getSpecifications(resultCollection);
					specifications.each(function(item) {
						var entity;
						var id = item.get("Id");
						if (this.Ext.isEmpty(item.get("SpecTableValueY.Id")) &&
							this.Ext.isEmpty(item.get("SpecTableValueX.Id"))) {
							entity = this.generateSpecificationRowEntity(item, resultCollection);
						} else {
							entity = this.generateMatrixEntity(item, resultCollection);
						}
						rowsCollection.add(id, entity);
					}, this);
					return rowsCollection.getItems();
				},

				/**
				 * ######### ####### ######## #### # #######.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq ###### #######.
				 * @param {String} axisName ######## ###.
				 */
				addSpecTableValueColumns: function(esq, axisName) {
					var columns = ["Id", "Specification", "CurrentType", "TextValue", "FloatValue", "IntegerValue",
						"BooleanValue", "SpecificationListItem", "MinFloatValue", "MaxFloatValue", "MinIntegerValue",
						"MaxIntegerValue", "IsEmptyMinValue", "IsEmptyMaxValue"];
					var columnPrefix = "SpecTableValue" + axisName + ".";
					esq.addColumn("SpecTableValue" + axisName);
					esq.addColumn(columnPrefix + "Specification.Type.Id", axisName + "SpecificationTypeId");
					columns.forEach(function(columnName) {
						esq.addColumn(columnPrefix + columnName);
					}, this);
				},

				/**
				 * ######### ####### # #######.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq ###### #######.
				 */
				addQueryColumns: function(esq) {
					var columns = ["Id", "Specification", "IsEmptyValue", "CurrentType", "TextValue", "FloatValue",
						"IntegerValue", "BooleanValue", "SpecificationListItem", "MinFloatValue", "MaxFloatValue",
						"MinIntegerValue", "MaxIntegerValue", "IsEmptyMinValue", "IsEmptyMaxValue"];
					columns.forEach(function(columnName) {
						esq.addColumn(columnName);
					}, this);
					esq.addColumn("Specification.Type", "SpecificationType");
					esq.addColumn("Specification.Type.Id", "SpecificationTypeId");
					this.addSpecTableValueColumns(esq, "Y");
					this.addSpecTableValueColumns(esq, "X");
					var rowPositionColumn = esq.addColumn("RowPosition");
					var valuePositionColumn = esq.addColumn("ValuePosition");
					rowPositionColumn.orderDirection = this.Terrasoft.OrderDirection.ASC;
					valuePositionColumn.orderDirection = this.Terrasoft.OrderDirection.ASC;
					rowPositionColumn.orderPosition = 0;
					valuePositionColumn.orderPosition = 1;
				},

				/**
				 * ######### ######### ##### # ##.
				 * @protected
				 * @param {Function} callback ####### ######### ######.
				 */
				loadRowsCollection: function(callback) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SpecInCondition"
					});
					this.addQueryColumns(esq);
					var detailFilters = this.getDetailFilters();
					esq.filters.addItem(detailFilters);
					esq.getEntityCollection(function(result) {
						if (result.success) {
							var resultCollection = result.collection;
							var rows = this.generateRowEntities(resultCollection);
							if (this.Ext.isFunction(callback)) {
								callback.call(this, rows);
							}
						}
					}, this);
				},

				/**
				 * ########## ####### ### ####### ####### ### ######.
				 * @public
				 * @return {Terrasoft.FilterGroup} ####### ### ######.
				 */
				getDetailFilters: function() {
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					var detailFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"ProductCondition.Id",
						this.get("MasterRecordId"));
					var typeFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"SpecInConditionType.Id", this.getSpecInConditionType());
					filterGroup.addItem(detailFilter);
					filterGroup.addItem(typeFilter);
					return filterGroup;
				},

				/**
				 * ####### ###### ######## #########.
				 * @public
				 * @param {Terrasoft.BaseViewModel} item ######-###### #########.
				 * @return {Terrasoft.BaseViewModel} ###### ######## #########.
				 */
				createSpecificationValueEntity: function(item) {
					var entity = this.Ext.create("Terrasoft.BaseViewModel", {
						primaryColumnName: "Id"
					});
					var specInConditionColumns = SpecInCondition.columns;
					var entityColumns = entity.columns;
					this.Terrasoft.each(item.columns, function(column, columnName) {
						if (specInConditionColumns.hasOwnProperty(columnName)) {
							entityColumns[columnName] = column;
							var value = item.get(columnName);
							entity.set(columnName, value);
						}
					}, this);
					return entity;
				},

				/**
				 * ########## ######### ######### ## ###### #### #########.
				 * @public
				 * @param {Terrasoft.BaseViewModel} specificationId ############# #### #########.
				 * @param {Terrasoft.BaseViewModelCollection} collection ######## ######.
				 * @return {Terrasoft.BaseViewModel} ###### ######## #########.
				 */
				getRowValuesBySpecification: function(specificationId, collection) {
					var rowItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					collection.each(function(item) {
						var itemSpecification = item.get("Specification");
						var itemSpecificationId = itemSpecification && itemSpecification.value;
						if (itemSpecificationId === specificationId) {
							var typeId = item.get("SpecificationTypeId");
							var dataValueType = this.getDataValueTypeBySpecificationType(typeId);
							var entity = this.createSpecificationValueEntity(item);
							entity.set("DataValueType", dataValueType);
							rowItems.add(entity.get("Id"), entity);
						}
					}, this);
					return rowItems;
				},

				/**
				 * ##### ########## ### ######## ## #### ##############.
				 * @protected
				 * @param {Guid} typeId ######## #### ##############.
				 * @return {Terrasoft.DataValueType} ### ########.
				 */
				getDataValueTypeBySpecificationType: function(typeId) {
					var dataValueType;
					switch (typeId.toLowerCase()) {
						case SpecificationBuilderConstants.SpecificationType.Lookup:
							dataValueType = this.Terrasoft.DataValueType.ENUM;
							break;
						case SpecificationBuilderConstants.SpecificationType.Float:
							dataValueType = this.Terrasoft.DataValueType.FLOAT;
							break;
						case SpecificationBuilderConstants.SpecificationType.Boolean:
							dataValueType = this.Terrasoft.DataValueType.BOOLEAN;
							break;
						case SpecificationBuilderConstants.SpecificationType.Text:
							dataValueType = this.Terrasoft.DataValueType.TEXT;
							break;
						case SpecificationBuilderConstants.SpecificationType.Integer:
							dataValueType = this.Terrasoft.DataValueType.INTEGER;
							break;
						default:
							break;
					}
					return dataValueType;
				},

				/**
				 * ########## ######### ######## ###### # ##.
				 * @public
				 * @param {Terrasoft.BaseViewModel} rowSpecification ######## ######.
				 * @param {Terrasoft.Collection} resultCollection ######### ######.
				 * @return {Terrasoft.BaseViewModelCollection} ######### ######## ######.
				 */
				getSpecificationRowValues: function(rowSpecification, resultCollection) {
					var specification = rowSpecification.get("Specification");
					var specificationId = specification && specification.value;
					var rowValues = this.getRowValuesBySpecification(specificationId, resultCollection);
					return rowValues;
				}
			}
		};
	});
