define("FinAppSpecificationFieldsDetail", ["SpecTableInherited", "SpecificationBuilderConstants",
		"FinAppSpecificationRowViewModel", "TableRecalcMixin"
	],
	function(SpecTableInherited, SpecificationBuilderConstants) {
		return {
			entitySchemaName: "FinApplicationSpec",
			mixins: {
				tableRecalcMixin: "Terrasoft.TableRecalcMixin"
			},
			messages: {
				/**
				 * @message SetDetailCollapsed
				 */
				"SetDetailCollapsed": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message ClearDetail
				 */
				"ClearDetail": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message GenerateProductSpecification
				 */
				"GenerateProductSpecification": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message ConfirmRegenerateProductSpecification
				 */
				"ConfirmRegenerateProductSpecification": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			attributes: {
				"SpecValueColumns": {
					dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
					value: ["Id", "Specification", "CurrentType", "MinFloatValue", "MaxFloatValue",
						"MinIntegerValue", "MaxIntegerValue", "BooleanValue"
					]
				},
				"TableRecalcFieldNames": {
					dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
					value: {
						x: "xAxisValue",
						y: "yAxisValue",
						dependent: "dependentValue"
					}
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * Returns not exists specification filter.
				 * @private
				 * @return {Terrasoft.FilterGroup} Not exists specification filter.
				 */
				getNotExistsSpecificationsFilter: function() {
					var collection = this.getCollection();
					var addedSpecification = [];
					var filter = null;
					this.Terrasoft.each(collection.getItems(), function(item) {
						var specification = item.get("Specification");
						if (this.Ext.isObject(specification) && !item.isDeleted) {
							addedSpecification.push(specification.value);
						}
					}, this);
					if (addedSpecification.length > 0) {
						filter = this.Terrasoft.createColumnInFilterWithParameters("Id", addedSpecification);
						filter.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
					}
					return filter;
				},

				/**
				 * Finds item with specified specification in view collection.
				 * @private
				 * @param {Terrasoft.BaseViewModelCollection} collection Detail collection.
				 * @param {String} specificationId Specification Id.
				 * @return {Terrasoft.FinAppSpecificationRowViewModel} Found view item.
				 */
				findItemBySpecification: function(collection, specificationId) {
					var result = null;
					this.Terrasoft.each(collection.getItems(), function(item) {
						var itemSpecificationId = this.getValueFromLookupValue(item, "Specification");
						if (!item.isDeleted && itemSpecificationId === specificationId) {
							result = item;
							return false;
						}
					}, this);
					return result;
				},

				/**
				 * Returns flag that item is matrix value.
				 * @private
				 * @param {Object} item Item of specifications collection.
				 */
				isMatrixItem: function(item) {
					var xColumnPrefix = this.getAxisColumnPrefix("X") + "Id";
					var yColumnPrefix = this.getAxisColumnPrefix("Y") + "Id";
					return !this.Ext.isEmpty(item.get(xColumnPrefix)) && !this.Ext.isEmpty(item.get(yColumnPrefix));
				},

				/**
				 * Returns value from lookup value.
				 * @private
				 * @param {Object} item Item of specifications collection.
				 * @param {String} columnName Name of lookup column.
				 * @return {String} Value of lookup value.
				 */
				getValueFromLookupValue: function(item, columnName) {
					var lookupValue = item.get(columnName);
					var value = this.Ext.isObject(lookupValue) ? lookupValue.value : lookupValue;
					return value;
				},

				/**
				 * Returns array of column names to display.
				 * @private
				 * @return {Array} Array of column names.
				 */
				getVisibleControls: function() {
					return ["SpecificationListItem", "TextValue", "FloatValue", "IntegerValue", "BooleanValue"];
				},

				/**
				 * Returns column prefix for specified axis.
				 * @private
				 * @param {String} axis Axis name.
				 * @return {String} Column prefix.
				 */
				getAxisColumnPrefix: function(axis) {
					return !this.Ext.isEmpty(axis) ? "SpecTableInherited" + axis + "." : "";
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDisplayColumns
				 * @overridden
				 */
				getDisplayColumns: function() {
					return this.getVisibleControls();
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#onAddRecordButtonClick
				 * @overridden
				 */
				onAddRecordButtonClick: function() {
					var isNewCardState = this.getIsCardNewRecordState();
					if (isNewCardState) {
						this.saveCard();
					} else {
						this.loadSpecificationsLookup();
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDeleteButtonConfig
				 * @overridden
				 */
				getDeleteButtonConfig: function() {
					var deleteButtonConfig = this.callParent(arguments);
					deleteButtonConfig = this.Ext.apply(deleteButtonConfig, {
						visible: {
							bindTo: "getDeleteButtonVisible"
						}
					});
					return deleteButtonConfig;
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#onCardSaved
				 * @overridden
				 */
				onCardSaved: function() {
					this.loadSpecificationsLookup();
				},

				/**
				 * Open lookup window when adding a parameter.
				 * @protected
				 */
				loadSpecificationsLookup: function() {
					var filterGroup = this.Terrasoft.createFilterGroup();
					var notExistsFilter = this.getNotExistsSpecificationsFilter();
					if (!this.Ext.isEmpty(notExistsFilter)) {
						filterGroup.addItem(notExistsFilter);
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
				 * The callback function for adding of a parameter by "add" button.
				 * @protected
				 * @param {Object} args Object with specified parameters.
				 */
				loadSpecificationsLookupCallback: function(args) {
					var collection = args.selectedRows;
					this.Terrasoft.each(collection.getItems(), function(item) {
						this.addRow({
							defaultValues: [{
								name: "Specification",
								value: item.Id,
								displayValue: item.Name
							}, {
								name: "CurrentType",
								value: SpecificationBuilderConstants.ViewType.SingleValue
							}, {
								name: "IsCustom",
								value: true
							}],
							rawData: {
								Caption: item.Name,
								SpecificationType: item.Type
							}
						});
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getLeftRowContainerWrapClass
				 * @overridden
				 */
				getLeftRowContainerWrapClass: function() {
					return ["field-detail-row-left", "singlecolumn"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDetailRowItemsViewConfig
				 * @overridden
				 */
				getDetailRowItemsViewConfig: function() {
					var rowViewConfig = [];
					this.Terrasoft.each(this.getVisibleControls(), function(displayColumn) {
						var column = this.findEntityColumn(displayColumn);
						if (column) {
							var columnName = column.name;
							var dataValueType = column.dataValueType;
							var defaultItemConfig = {
								itemType: this.Terrasoft.ViewItemType.MODEL_ITEM,
								dataValueType: dataValueType,
								name: columnName,
								wrapClass: ["field-detail-row-left-item"],
								caption: {
									bindTo: "Caption"
								},
								visible: {
									bindTo: "ControlVisible",
									bindConfig: {
										converter: function() {
											return this.getControlVisible(columnName);
										}
									}
								},
								enabled: {
									bindTo: "getControlEnable"
								},
								markerValue: {
									bindTo: "Caption"
								}
							};
							if (columnName !== "BooleanValue") {
								defaultItemConfig.isRequired = {
									"bindTo": "getControlRequired"
								};
							}
							if (dataValueType === Terrasoft.DataValueType.LOOKUP) {
								defaultItemConfig.contentType = Terrasoft.ContentType.ENUM;
							}
							rowViewConfig.push(defaultItemConfig);
						}
					}, this);
					return rowViewConfig;
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#initESQColumns
				 * @overridden
				 */
				initESQColumns: function(esq) {
					this.callParent(arguments);
					esq.addColumn("Specification");
					esq.addColumn("CurrentType");
					esq.addColumn("MinIntegerValue");
					esq.addColumn("MaxIntegerValue");
					esq.addColumn("MinFloatValue");
					esq.addColumn("MaxFloatValue");
					esq.addColumn("IsCustom");
					esq.addColumn("Specification.Name", "Caption");
					esq.addColumn("Specification.Type", "SpecificationType");
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#loadDetailData
				 * @overridden
				 */
				loadDetailData: function(callback, scope) {
					this.callParent([function () {
						this.loadSpecInheritedCollection((response)=>{
							this.initSpecInheritedRecordsCallback(response, callback, scope);
						}, this);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
				 * @overridden
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.FinAppSpecificationRowViewModel";
				},

				/**
				 * Loads specifications of product by product in application.
				 * @protected
				 */
				loadSpecificationRecords: function() {
					this.showBodyMask();
					var config = this.getFinAppSpecServiceConfig();
					this.callService(config, this.finAppSpecServiceCallBack, this);
				},

				/**
				 * @protected
				 * @param {Object} response Query response.
				 */
				finAppSpecServiceCallBack: function(response) {
					this.hideBodyMask();
					var exceptionMessage = response.errorInfo || {};
					exceptionMessage = exceptionMessage.message;
					if (response.success && this.Ext.isEmpty(exceptionMessage)) {
						this.loadSpecInheritedCollection(this.reloadSpecInheritedRecordsCallback, this);
					} else {
						var message = this.Ext.isEmpty(exceptionMessage)
							? this.get("Resources.Strings.FillDetailErrorMessage")
							: exceptionMessage;
						this.showInformationDialog(message);
					}
				},

				/**
				 * Creates config for calling service for filling detail.
				 * @protected
				 * @return {Object} Config for calling the service.
				 */
				getFinAppSpecServiceConfig: function() {
					var data = {
						finApplicationId: this.get("MasterRecordId")
					};
					var config = {
						serviceName: "FinAppSpecService",
						methodName: "InheritSpecificationsForFinApp",
						data: data
					};
					return config;
				},

				/**
				 * Reloads inherited specification values to details collection.
				 * @protected
				 * @param {Object} response Response of query to "SpecInherited" table.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				reloadSpecInheritedRecordsCallback: function(response, callback, scope) {
					if (response.success && response.collection) {
						var newViewCollection = this.generateViewCollection(response.collection);
						var viewCollection = this.getCollection();
						viewCollection.loadAll(newViewCollection);
						this.generateTableRecalcCollection(response.collection);
						var newViewCollectionItems = newViewCollection.getItems();
						this.Terrasoft.each(newViewCollectionItems, function(item) {
							var valueType = item.getValueType();
							item.subscribeOnColumnChange(valueType,
								this.recalcItemDependentValues.bind(this, item), this);
						}, this);
						this.Terrasoft.each(newViewCollectionItems, function(item) {
							var valueType = item.getValueType();
							var value = item.get(valueType);
							if (!this.Ext.isEmpty(value)) {
								this.recalcItemDependentValues(item);
							}
						}, this);
						this.setSaveDiscardButtonsVisible(true);
					} else {
						var errorInfo = response.errorInfo || {};
						this.showInformationDialog(errorInfo.message);
					}
					this.Ext.callback(callback, scope);
					this.hideBodyMask();
				},

				/**
				 * Loads inherited specification values to details collection on detail initialization.
				 * @protected
				 * @param {Object} response Response of query to specInherited table.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				initSpecInheritedRecordsCallback: function(response, callback, scope) {
					if (response.success && response.collection) {
						this.generateTableRecalcCollection(response.collection);
						var collection = this.getCollection();
						this.Terrasoft.each(collection.getItems(), function(item) {
							this.fillDetailItemPossibleValues(item, response.collection);
							var valueType = item.getValueType();
							item.subscribeOnColumnChange(valueType,
								this.recalcItemDependentValues.bind(this, item), this);
						}, this);
						this.setSaveDiscardButtonsVisible(false);
					} else {
						var errorInfo = response.errorInfo || {};
						this.showInformationDialog(errorInfo.message);
					}
					this.Ext.callback(callback, scope);
					this.hideBodyMask();
				},

				/**
				 * Generates collection for table recalculating.
				 * @protected
				 * @param {Terasoft.Collection} specCollection Collection of specification values.
				 */
				generateTableRecalcCollection: function(specCollection) {
					var dependentValueColumns = [
						"CurrentType", "SpecificationListItem", "FloatValue", "IntegerValue", "TextValue"
					];
					var axisValueColumns = dependentValueColumns.concat([
						"MinFloatValue", "MaxFloatValue", "MinIntegerValue", "MaxIntegerValue"
					]);
					var tableRecalcCollection = this.Ext.create("Terrasoft.Collection");
					var tableRecalcFieldNames = this.get("TableRecalcFieldNames");
					this.Terrasoft.each(specCollection.getItems(), function(specValue) {
						if (!this.isMatrixItem(specValue)) {
							return;
						}
						var xAxisValue = this.createTableRecalcObject(specValue, axisValueColumns, "X");
						var yAxisValue = this.createTableRecalcObject(specValue, axisValueColumns, "Y");
						var dependentValue = this.createTableRecalcObject(specValue, dependentValueColumns, "");
						var tableRecalcRow = {};
						tableRecalcRow[tableRecalcFieldNames.x] = xAxisValue;
						tableRecalcRow[tableRecalcFieldNames.y] = yAxisValue;
						tableRecalcRow[tableRecalcFieldNames.dependent] = dependentValue;
						tableRecalcCollection.add(tableRecalcRow);
					}, this);
					this.setTableRecalcCollection(tableRecalcCollection, tableRecalcFieldNames.x,
						tableRecalcFieldNames.y, tableRecalcFieldNames.dependent);
				},

				/**
				 * Creates an object of table recalculating colllection.
				 * @protected
				 * @param {Object} specValue Specification value object.
				 * @param {Array} columnsToCopy Array of columns that should be copied from specification value object.
				 * @param {String} axis Axis name.
				 */
				createTableRecalcObject: function(specValue, columnsToCopy, axis) {
					var columnPrefix = this.getAxisColumnPrefix(axis);
					var result = {};
					this.Terrasoft.each(columnsToCopy, function(columnName) {
						var fullColumnName = columnPrefix + columnName;
						result[columnName] = specValue.get(fullColumnName);
					}, this);
					var specificationId = this.getValueFromLookupValue(specValue, columnPrefix + "Specification");
					result.SpecificationId = specificationId;
					this.setMatrixFlags(specificationId, axis);
					return result;
				},

				/**
				 * Sets flags that specification item is table value (axis or matrix value).
				 * @protected
				 * @param {String} specificationId specification identifier.
				 * @param {String} axis Axis name.
				 */
				setMatrixFlags: function(specificationId, axis) {
					var viewCollection = this.getCollection();
					this.Terrasoft.each(viewCollection.getItems(), function(item) {
						var itemSpecificationId = this.getValueFromLookupValue(item, "Specification");
						if (!item.isDeleted && itemSpecificationId === specificationId) {
							if (this.Ext.isEmpty(axis)) {
								item.set("IsMatrixValue", true);
							}
							return false;
						}
					}, this);
				},

				/**
				 * Calculates dependencies for specified specification by collection of table recalculating.
				 * @protected
				 * @param {String} specificationId Axis specification identifier.
				 * @return {[{secondAxisSpecId: String, dependentValueSpecIds: Array}]} Array, each record of which
				 * contains specification identifier of second axis for table recalculating and array of identifiers
				 * of specifications that depends on this both axis specifications.
				 */
				getSpecDependencies: function(specificationId) {
					var tableRecalcFieldNames = this.get("TableRecalcFieldNames");
					var tableRecalcCollection = this.getTableRecalcCollection();
					var dependencies = [];
					this.Terrasoft.each(tableRecalcCollection.getItems(), function(tableRecalcRow) {
						var secondAxisSpecId = null;
						if (tableRecalcRow[tableRecalcFieldNames.x].SpecificationId === specificationId) {
							secondAxisSpecId = tableRecalcRow[tableRecalcFieldNames.y].SpecificationId;
						} else if (tableRecalcRow[tableRecalcFieldNames.y].SpecificationId === specificationId) {
							secondAxisSpecId = tableRecalcRow[tableRecalcFieldNames.x].SpecificationId;
						}
						if (secondAxisSpecId === null) {
							return;
						}
						var dependentValueSpecId = tableRecalcRow[tableRecalcFieldNames.dependent].SpecificationId;
						var dependenciesWithSameAxis = dependencies.filter(function(dependency) {
							return dependency.secondAxisSpecId === secondAxisSpecId;
						});
						if (dependenciesWithSameAxis.length === 0) {
							dependencies.push({
								secondAxisSpecId: secondAxisSpecId,
								dependentValueSpecIds: [dependentValueSpecId]
							});
						} else {
							var dependencyWithSameAxis = dependenciesWithSameAxis[0];
							if (dependencyWithSameAxis.dependentValueSpecIds.indexOf(dependentValueSpecId) === -1) {
								dependencyWithSameAxis.dependentValueSpecIds.push(dependentValueSpecId);
							}
						}
					}, this);
					return dependencies;
				},

				/**
				 * Applies result of table recalculation.
				 * @protected
				 * @param {Array} dependentValueSpecIds Identifiers of dependent value specifications.
				 * @param {Array} calculatedValueObjects Objects with result of table recalculation for each
				 * dependent specififcation.
				 */
				applyTableRecalcResult: function(dependentValueSpecIds, calculatedValueObjects) {
					var collection = this.getCollection();
					this.Terrasoft.each(dependentValueSpecIds, function(dependentValueSpecId) {
						var dependentValueDetailItem = this.findItemBySpecification(collection, dependentValueSpecId);
						var dependentValueType = dependentValueDetailItem.getValueType();
						var calculatedValueObject =
							calculatedValueObjects.filter(function(dependentValueObject) {
								return dependentValueObject.SpecificationId === dependentValueSpecId;
							})[0];
						var calculatedDependentValue = this.Ext.isEmpty(calculatedValueObject)
							? null
							: calculatedValueObject[dependentValueType];
						var currentDependentValue = dependentValueDetailItem.get(dependentValueType);
						if (this.Ext.isEmpty(currentDependentValue) && this.Ext.isEmpty(calculatedDependentValue)) {
							return;
						}
						dependentValueDetailItem.set(dependentValueType, calculatedDependentValue);
					}, this);
				},

				/**
				 * Recalculates values of specifications depend on specififcation of specified detail item.
				 * @protected
				 * @param {Terrasoft.FinAppSpecificationRowViewModel} detailItem Detail item.
				 */
				recalcItemDependentValues: function(detailItem) {
					var itemSpecificationId = this.getValueFromLookupValue(detailItem, "Specification");
					var dependencies = this.getSpecDependencies(itemSpecificationId);
					var collection = this.getCollection();
					this.Terrasoft.each(dependencies, function(dependency) {
						var secondAxisDetailItem = this.findItemBySpecification(collection, dependency.secondAxisSpecId);
						var calculatedValueObjects = this.processTableRecalc(detailItem, secondAxisDetailItem,
							this.tableRecalcMatchingFunction.bind(this));
						this.applyTableRecalcResult(dependency.dependentValueSpecIds, calculatedValueObjects);
					}, this);
				},

				/**
				 * Checks that value of specified detail item matchs the value of some specififcation in specififed
				 * object of table recalculation collection.
				 * @protected
				 * @param {Terrasoft.FinAppSpecificationRowViewModel} actualValueObject Detail item with actual
				 * specififcation value.
				 * @param {Object} recalcCollectionObject Object of table recalculation collection.
				 * @return {Boolean} Flag indicating that the value of specification matchs recalculation object.
				 */
				tableRecalcMatchingFunction: function(actualValueObject, recalcCollectionObject) {
					var specificationId = this.getValueFromLookupValue(actualValueObject, "Specification");
					if (specificationId !== recalcCollectionObject.SpecificationId) {
						return false;
					}
					var valueType = actualValueObject.getValueType();
					var isLookup = actualValueObject.getIsLookupType();
					var viewType = recalcCollectionObject.CurrentType;
					var value;
					var result;
					if (viewType === SpecificationBuilderConstants.ViewType.RangeValue && !isLookup) {
						value = actualValueObject.get(valueType);
						result =
							this.Ext.isNumber(value) &&
							value >= recalcCollectionObject["Min" + valueType] &&
							value <= recalcCollectionObject["Max" + valueType];
					} else {
						var recalcCollectionValue = recalcCollectionObject[valueType];
						if (!isLookup) {
							value = actualValueObject.get(valueType);
							result = value === recalcCollectionValue;
						} else {
							value = this.getValueFromLookupValue(actualValueObject, "SpecificationListItem");
							result = value === (this.Ext.isObject(recalcCollectionValue)
								? recalcCollectionValue.value
								: recalcCollectionValue);
						}
					}
					return result;
				},

				/**
				 * Returns details data by selected collection.
				 * @protected
				 * @param {Terrasoft.Collection} specCollection Specifications collection.
				 * @return {Terrasoft.BaseViewModelCollection} Details data.
				 */
				generateViewCollection: function(specCollection) {
					var viewCollection = this.Ext.create("Terrasoft.BaseViewModelCollection");
					specCollection.each(function(specification) {
						specification.isNew = true;
						var isMatrixValue = this.isMatrixItem(specification);
						if (isMatrixValue) {
							this.addAxisDetailItem(specification, "X", viewCollection, specCollection);
							this.addAxisDetailItem(specification, "Y", viewCollection, specCollection);
						}
						var specificationId = this.getValueFromLookupValue(specification, "Specification");
						var existingItem = this.findItemBySpecification(viewCollection, specificationId);
						var needRewrite =
							!this.Ext.isEmpty(existingItem) &&
							!existingItem.get("IsMatrixValue") &&
							isMatrixValue;
						if (existingItem === null || needRewrite) {
							var item = this.generateDetailItem(specification, specCollection);
							if (needRewrite) {
								viewCollection.remove(existingItem);
							}
							viewCollection.add(item.get(this.primaryColumnName), item);
						}
					}, this);
					viewCollection.sort(null, null, function(firstItem, secondItem) {
						var firstIsMatrix = firstItem.get("IsMatrixValue");
						var secondIsMatrix = secondItem.get("IsMatrixValue");
						if (!firstIsMatrix && secondIsMatrix) {
							return -1;
						}
						if (firstIsMatrix && !secondIsMatrix) {
							return 1;
						}
						return 0;
					});
					return viewCollection;
				},

				/**
				 * Adds axis items of matrix to details data collection.
				 * @protected
				 * @param {Object} specification Matrix value.
				 * @param {String} axis Axis name.
				 * @param {Terrasoft.BaseViewModelCollection} viewCollection Details data.
				 * @param {Terrasoft.Collection} specCollection Specifications collection.
				 */
				addAxisDetailItem: function(specification, axis, viewCollection, specCollection) {
					var columnPrefix = this.getAxisColumnPrefix(axis) + "Specification";
					var specificationId = this.getValueFromLookupValue(specification, columnPrefix);
					var existingItem = this.findItemBySpecification(viewCollection, specificationId);
					if (existingItem === null) {
						var axisItem = this.createAxisValueItem(specification, axis, specCollection);
						viewCollection.add(axisItem.get(this.primaryColumnName), axisItem);
					}
				},

				/**
				 * Generates item for detail collection by specified specification value object.
				 * @protected
				 * @param {Object} specification Specification value object.
				 * @param {Terrasoft.Collection} specCollection Specifications collection.
				 * @return {Terrasoft.FinAppSpecificationRowViewModel} Final detail item.
				 */
				generateDetailItem: function(specification, specCollection) {
					var extraColumns = !this.isMatrixItem(specification)
						? ["FloatValue", "IntegerValue", "TextValue"]
						: null;
					var item = this.createDetailItem(specification, "", extraColumns);
					var isMatrixValue = this.isMatrixItem(specification);
					item.set("IsMatrixValue", isMatrixValue);
					this.fillDetailItemPossibleValues(item, specCollection);
					item.set("SpecTableInheritedX", null);
					item.set("SpecTableInheritedY", null);
					return item;
				},

				/**
				 * Creates detail item with column values from specification value object.
				 * @protected
				 * @param {Object} specification Specification value object.
				 * @param {String} columnPrefix Column name prefix.
				 * @param {Array} extraColumns Extra columns to copy.
				 * @return {Terrasoft.FinAppSpecificationRowViewModel} Detail item.
				 */
				createDetailItem: function(specification, columnPrefix, extraColumns) {
					var item = this.createRowViewModel({
						isNew: specification.isNew
					});
					var specValueColumns = this.get("SpecValueColumns") || [];
					var columnsToCopy = specValueColumns.concat(["SpecificationType", "Caption"]);
					if (this.Ext.isArray(extraColumns)) {
						columnsToCopy = columnsToCopy.concat(extraColumns);
					}
					this.Terrasoft.each(columnsToCopy, function(columnName) {
						var fullColumnName = columnPrefix + columnName;
						var value = specification.get(fullColumnName);
						item.set(columnName, value);
					}, this);
					if (specification.isNew) {
						item.set(this.primaryColumnName, this.Terrasoft.generateGUID());
					}
					return item;
				},

				/**
				 * Returns axis detail item value by axis name and specification.
				 * @protected
				 * @param {Object} item Item of specifications collection.
				 * @param {String} axis Name of axis.
				 * @param {Terrasoft.Collection} specCollection Specifications collection.
				 * @return {Terrasoft.FinAppSpecificationRowViewModel} Final axis detail item.
				 */
				createAxisValueItem: function(item, axis, specCollection) {
					var columnPrefix = this.getAxisColumnPrefix(axis);
					var axisItem = this.createDetailItem(item, columnPrefix);
					var specification = axisItem.get("Specification");
					var caption = this.Ext.isObject(specification) ? specification.displayValue : specification;
					axisItem.set("SpecificationType", item.get(columnPrefix + "SpecificationType"));
					axisItem.set("Caption", caption);
					var type = axisItem.getValueType();
					var isRange = axisItem.getIsRange();
					this.fillDetailItemPossibleValues(axisItem, specCollection);
					if (type === "IntegerValue" || type === "FloatValue") {
						if (isRange) {
							var specificationId = this.getValueFromLookupValue(item, columnPrefix + "Specification");
							var minMaxValues = this.getMinMaxValues(specCollection, type, axis, specificationId);
							axisItem.set("Max" + type, minMaxValues.max);
							axisItem.set("Min" + type, minMaxValues.min);
						}
						var axisValue = axisItem.get(type);
						if (this.Ext.isEmpty(axisValue)) {
							axisItem.set(type, null);
						}
					}
					return axisItem;
				},

				/**
				 * Calculates minimum and maximum values of axis collection.
				 * @protected
				 * @param {Terrasoft.Collection} specCollection Specifications collection.
				 * @param {String} type Type of items value.
				 * @param {String} axis Name of axis.
				 * @param {String} specificationId Axis specification identifier.
				 * @return {Object} Object with minimum and maximum values.
				 */
				getMinMaxValues: function(specCollection, type, axis, specificationId) {
					var columnPrefix = this.getAxisColumnPrefix(axis);
					var maxCollection = [];
					var minCollection = [];
					this.Terrasoft.each(specCollection.getItems(), function(item) {
						if (this.getValueFromLookupValue(item, columnPrefix + "Specification") === specificationId) {
							maxCollection.push(item.get(columnPrefix + "Max" + type));
							minCollection.push(item.get(columnPrefix + "Min" + type));
						}
					}, this);
					return {
						max: Math.max.apply(Math, maxCollection),
						min: Math.min.apply(Math, minCollection)
					};
				},

				/**
				 * Fills possible values for detail item from collection of specification values.
				 * @protected
				 * @param {Terrasoft.FinAppSpecificationRowViewModel} detailItem Detail item.
				 * @param {Terrasoft.Collection} specCollection Specifications collection.
				 */
				fillDetailItemPossibleValues: function(detailItem, specCollection) {
					var isRange = detailItem.getIsRange();
					var isMatrixValue = detailItem.get("IsMatrixValue");
					if (isRange || isMatrixValue) {
						return;
					}
					var valueType = detailItem.getValueType();
					var possibleValues = [];
					var axises = [null, "X", "Y"];
					var specificationId = this.getValueFromLookupValue(detailItem, "Specification");
					var singleValue = null;
					this.Terrasoft.each(axises, function(axis) {
						var columnPrefix = this.getAxisColumnPrefix(axis);
						this.Terrasoft.each(specCollection.getItems(), function(item) {
							var itemSpecificationId = this.getValueFromLookupValue(item, columnPrefix + "Specification");
							if (itemSpecificationId === specificationId) {
								var value = this.getValueFromLookupValue(item, columnPrefix + valueType);
								if (!this.Ext.isEmpty(value) && possibleValues.indexOf(value) === -1) {
									if (this.Ext.isEmpty(singleValue)) {
										singleValue = item.get(columnPrefix + valueType);
									}
									possibleValues.push(value);
								}
							}
						}, this);
						if (possibleValues.length > 0) {
							return false;
						}
					}, this);
					detailItem.set("PossibleValues", possibleValues);
					if (possibleValues.length === 1) {
						detailItem.set(valueType, singleValue);
					}
				},

				/**
				 * Loads specifications collection.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				loadSpecInheritedCollection: function(callback, scope) {
					this.showBodyMask();
					var finApplicationId = this.get("MasterRecordId");
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SpecInherited"
					});
					this.addSpecInheritedColumns(esq, "");
					this.addSpecInheritedColumns(esq, "X");
					this.addSpecInheritedColumns(esq, "Y");
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "FinApplication", finApplicationId));
					esq.getEntityCollection(function(response) {
						this.Ext.callback(callback, scope, [response]);
					}, this);
				},

				/**
				 * Adds specification value columns to SpecInherited query.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq SpecInherited entity schema query.
				 * @param {String} axis Axis name.
				 */
				addSpecInheritedColumns: function(esq, axis) {
					var columnPrefix = this.getAxisColumnPrefix(axis);
					var specValueColumns = this.get("SpecValueColumns") || [];
					var columns = specValueColumns.concat([
						"SpecificationListItem", "FloatValue", "IntegerValue", "TextValue"
					]);
					columns.forEach(function(columnName) {
						esq.addColumn(columnPrefix + columnName);
					}, this);
					esq.addColumn(columnPrefix + "Specification.Type", columnPrefix + "SpecificationType");
					esq.addColumn(columnPrefix + "Specification.Name", columnPrefix + "Caption");
				},

				/**
				 * Generate button click handler.
				 * @protected
				 */
				onGenerateSpecButtonClick: function() {
					this.onConfirmRegenerateSpecification({
						callback: this.onGenerateSpecButtonClickCallback,
						scope: this
					});
				},

				/**
				 * Generates detail data from current product.
				 * @protected
				 */
				onGenerateSpecButtonClickCallback: function() {
					var saveMasterEntityConfig = this.getSaveMasterEntityConfig();
					this.clearCollection();
					this.sandbox.publish("SaveRecord", saveMasterEntityConfig, [this.sandbox.id]);
				},

				/**
				 * Returns config for the "SaveRecord" message.
				 * @protected
				 * @return {Object} Config.
				 */
				getSaveMasterEntityConfig: function() {
					return {
						isSilent: true,
						messageTags: [this.sandbox.id],
						callback: this.loadSpecificationRecords,
						scope: this
					};
				},

				/**
				 * Inits item for tools menu.
				 * @protected
				 */
				initToolsButtonMenu: function() {
					var toolsButtonMenu = this.get("ToolsButtonMenu");
					toolsButtonMenu.add("GenerateSpecButton",
						this.getButtonMenuItem({
							"Caption": {
								"bindTo": "Resources.Strings.FillsMenuCaption"
							},
							"Click": {
								"bindTo": "onGenerateSpecButtonClick"
							},
							"Enabled": true
						})
					);
				},

				/**
				 * Inits detail collapsed.
				 * @protected
				 */
				initDetailCollapsed: function() {
					var collection = this.getCollection();
					var detailInfo = this.getDetailInfo();
					var product = detailInfo.product;
					var isCollapsed = collection.isEmpty() && this.Ext.isEmpty(product);
					this.setDetailCollapsed(isCollapsed);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#initData
				 * @overridden
				 */
				initData: function(callback, scope) {
					this.callParent([function() {
						var toolsButtonMenu = this.Ext.create("Terrasoft.BaseViewModelCollection");
						this.set("ToolsButtonMenu", toolsButtonMenu);
						this.initToolsButtonMenu();
						this.initDetailCollapsed();
						this.Ext.callback(callback, scope);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					var sandbox = this.sandbox;
					sandbox.subscribe("SetDetailCollapsed", this.setDetailCollapsed, this, [sandbox.id]);
					sandbox.subscribe("GenerateProductSpecification", this.onGenerateSpecButtonClickCallback, this,
						[sandbox.id]);
					sandbox.subscribe("ConfirmRegenerateProductSpecification", this.onConfirmRegenerateSpecification,
						this, [sandbox.id]);
				},

				/**
				 * Confirms changing ActiveProduct field.
				 * @protected
				 * @param {Object} config Config for callback execute.
				 * @param {Function} config.callback Callback function.
				 * @param {Object} config.scope Execution context.
				 */
				onConfirmRegenerateSpecification: function(config) {
					var viewCollection = this.getCollection();
					var callback = config.callback;
					var viewCollectionItems = viewCollection.filterByFn(function(item) {
						return item.isDeleted === false;
					}, this);
					if (viewCollectionItems.isEmpty()) {
						this.Ext.callback(callback, config.scope, [config]);
					} else {
						this.showConfirmationDialog(this.get("Resources.Strings.ClearCpecificationConfirmMessage"),
							function(returnCode) {
								if (returnCode === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
									this.Ext.callback(callback, config.scope, [config]);
								}
							},
							[this.Terrasoft.MessageBoxButtons.YES.returnCode,
								this.Terrasoft.MessageBoxButtons.NO.returnCode], null
						);
					}
				},

				/**
				 * Sets IsDetailCollapsed property.
				 * @protected
				 * @param {Object} isDetailCollapsed Value of IsDetailCollapsed property.
				 */
				setDetailCollapsed: function(isDetailCollapsed) {
					this.set("IsDetailCollapsed", isDetailCollapsed);
					if (isDetailCollapsed) {
						this.clearCollection();
					}
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "ToolsButton",
				"parentName": "Detail",
				"propertyName": "tools",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"visible": {
						"bindTo": "getToolsVisible"
					},
					"enabled": true,
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.ToolsButtonImage"
					},
					"classes": {
						"wrapperClass": ["detail-tools-button-wrapper"],
						"menuClass": ["detail-tools-button-menu"]
					},
					"menu": {
						"items": {
							"bindTo": "ToolsButtonMenu"
						}
					}
				}
			}]
		}; /**SCHEMA_DIFF*/
	}
);
