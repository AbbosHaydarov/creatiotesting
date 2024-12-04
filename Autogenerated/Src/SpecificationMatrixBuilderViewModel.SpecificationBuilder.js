define("SpecificationMatrixBuilderViewModel", ["ViewUtilities", "SpecificationMatrixBuilderViewModelResources"],
	function(ViewUtilities, resources) {
		Ext.define("Terrasoft.configuration.SpecificationMatrixBuilderViewModel", {
			alternateClassName: "Terrasoft.SpecificationMatrixBuilderViewModel",
			extend: "Terrasoft.BaseViewModel",

			Ext: null,
			Terrasoft: null,
			sandbox: null,

			/**
			 * ### ###### ### ###### ############## ###.
			 * @virtual
			 * @type {String}
			 */
			horizontalAxisViewModelName: "Terrasoft.BaseSpecificationRowViewModel",

			/**
			 * ### ###### ### ###### ############ ###.
			 * @virtual
			 * @type {String}
			 */
			verticalAxisViewModelName: "Terrasoft.BaseSpecificationRowViewModel",

			/**
			 * ### ###### ### ###### ###### # #######.
			 * @virtual
			 * @type {String}
			 */
			matrixViewModel: "Terrasoft.BaseSpecificationRowViewModel",

			/**
			 * ### ###### ### ######## ######## ######.
			 * @type {String}
			 */
			floatItemClassName: "Terrasoft.BaseFloatItemViewModel",

			/**
			 * ### ###### ### ###### ######## ######.
			 * @type {String}
			 */
			integerItemClassName: "Terrasoft.BaseIntegerItemViewModel",

			/**
			 * ### ###### ### ########### ######## ######.
			 * @type {String}
			 */
			comboBoxItemClassName: "Terrasoft.BaseComboBoxItemViewModel",

			/**
			 * ### ###### ### ########## ######## ######.
			 * @type {String}
			 */
			textItemClassName: "Terrasoft.BaseTextItemViewModel",

			/**
			 * ### ###### ### ########### ######## ######.
			 * @type {String}
			 */
			booleanItemClassName: "Terrasoft.BaseBooleanItemViewModel",

			/**
			 * ######## ###### ViewModel'# ### ######### ##-#########.
			 * @type {String}
			 */
			defaultRowItemViewModelName: "Terrasoft.BaseSpecificationItemViewModel",

			/**
			 * ########## ##### ###### ######## ## ####.
			 * @protected
			 * @param {Terrasoft.DataValueType} dataValueType ### #########.
			 * @return {String} ######## ###### ###### ### ########.
			 */
			getMatrixRowItemViewModelName: function(dataValueType) {
				var viewModelName;
				switch (dataValueType) {
					case this.Terrasoft.DataValueType.ENUM:
						viewModelName = this.comboBoxItemClassName;
						break;
					case this.Terrasoft.DataValueType.FLOAT:
						viewModelName = this.floatItemClassName;
						break;
					case this.Terrasoft.DataValueType.INTEGER:
						viewModelName = this.integerItemClassName;
						break;
					case this.Terrasoft.DataValueType.BOOLEAN:
						viewModelName = this.booleanItemClassName;
						break;
					case this.Terrasoft.DataValueType.TEXT:
						viewModelName = this.textItemClassName;
						break;
					default:
						viewModelName = this.defaultRowItemViewModelName;
						break;
				}
				return viewModelName;
			},

			/**
			 * ########## ###### ############ ### ########.
			 * ################ # ###########.
			 * @abstract
			 * @throws Terrasoft.NotImplementedException.
			 * @return {Object} ###### ############.
			 */
			getItemViewConfig: function() {
				var message = this.get("Resources.Strings.NotImplementedExceptionMessage");
				throw new Terrasoft.NotImplementedException({
					message: this.Ext.String.format(message, "\"getItemViewConfig\"", this.$className)
				});
			},

			/**
			 * ######### ###### ############ ######## ######## # #######.
			 * @protected
			 * @param {Object} itemConfig ###### ############ ######.
			 * @param {Object} viewModel ###### ######## ########.
			 */
			onGetMatrixItemConfig: function(itemConfig, viewModel) {
				var config = ViewUtilities.getContainerConfig("row-view-container", []);
				var valueConfig = viewModel.getRowViewConfig();
				config.items.push(valueConfig);
				itemConfig.config = config;
			},

			/**
			 * ############## ###### ########## ######## ## ####### ########.
			 * @protected
			 * @virtual
			 * @param {Object} resourcesObj ###### ########.
			 */
			initResourcesValues: function(resourcesObj) {
				var resourcesSuffix = "Resources";
				Terrasoft.each(resourcesObj, function(resourceGroup, resourceGroupName) {
					resourceGroupName = resourceGroupName.replace("localizable", "");
					Terrasoft.each(resourceGroup, function(resourceValue, resourceName) {
						var viewModelResourceName = [resourcesSuffix, resourceGroupName, resourceName].join(".");
						this.set(viewModelResourceName, resourceValue);
					}, this);
				}, this);
			},

			/**
			 * ####### ###### #### #######.
			 * @protected
			 */
			createMatrixAxis: function() {
				var horizontalAxisConfig = {
					viewModelName: "HorizontalRowViewModel",
					viewModelClassName: this.horizontalAxisViewModelName,
					addHandler: this.onAddColumn,
					removeHandler: this.onRemoveColumn,
					clearHandler: this.onClearRowCollection,
					changeHandler: this.onItemChanged
				};
				this.setAxisViewModel(horizontalAxisConfig);
				var verticalAxisConfig = {
					viewModelName: "VerticalRowViewModel",
					viewModelClassName: this.verticalAxisViewModelName,
					addHandler: this.onAddRow,
					removeHandler: this.onRemoveRow,
					clearHandler: this.onClearRowCollection,
					changeHandler: this.onItemChanged
				};
				this.setAxisViewModel(verticalAxisConfig);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#constructor
			 * @overridden
			 */
			constructor: function() {
				this.callParent(arguments);
				this.initResourcesValues(resources);
				var collectionAttributeNames = ["MatrixCollection", "DeletedItemMatrixCollection",
					"DeletedColumnCollection", "DeletedRowCollection"];
				this.Terrasoft.each(collectionAttributeNames, function(collectionAttributeName) {
					if (this.Ext.isEmpty(this.get(collectionAttributeName))) {
						this.createCollection(collectionAttributeName);
					}
				}, this);
				var matrixCollection = this.get("MatrixCollection");
				this.subscribeOnCollectionEvents(matrixCollection, this.Terrasoft.emptyFn, this.Terrasoft.emptyFn,
					this.Terrasoft.emptyFn, this.onItemChanged);
				this.createMatrixAxis();
				if (this.Ext.isFunction(this.init)) {
					this.init();
				}
			},

			/**
			 * ######### ############ ####### ########.
			 * @public
			 * @param {Boolean} isLookup #######, ### ######### ###### ### ###########.
			 * @return {Object} ############ ####### ### ######## ##########.
			 */
			getMarkerConfig: function() {
				var markerConfig = {
					"bindTo": "Value",
					"bindConfig": {
						"converter": this.markerConverter
					}
				};
				return markerConfig;
			},

			/**
			 * ############# ##### ########## ####### ### ############## # ############ ######, ######## ### ####
			 * ######## ## ######### ## #########.
			 * @protected
			 * @param {String} config.viewModelName ### ########, # ####### ##### ########### ######.
			 * @param {String} config.viewModelClassName ### ###### ### ###### ###.
			 * @param {Function} config.addHandler ##########, ####### ##### ###### ### ########## ###### ######## # #########.
			 * @param {Function} config.removeHandler ##########, ####### ##### ###### ### ######## ######## ## #########.
			 * @param {Function} config.clearHandler ##########, ####### ##### ###### ### ####### ######### ######.
			 * @param {Function} config.changeHandler ##########, ####### ##### ###### ### ######### ######### ######.
			 */
			setAxisViewModel: function(config) {
				var model = this.createAxisViewModel(config.viewModelName, config.viewModelClassName);
				this.subscribeOnCollectionEvents(model.getRowValuesCollection(), config.addHandler,
					config.removeHandler, config.clearHandler, config.changeHandler);
				this.set(config.viewModelName, model);
			},

			getDefaultAxisMethods: this.Terrasoft.emptyFn,

			/**
			 * ####### ######### {@link Terrasoft.BaseSpecificationRowViewModel}, ############## ##### ########## # ######
			 * ### #######.
			 * @protected
			 * @param {String} viewModelName ######## ############# ###### ###.
			 * @param {String} axisViewModelClassName ######## ###### ###### ###.
			 * @return {Terrasoft.BaseSpecificationRowViewModel} ######### #########.
			 */
			createAxisViewModel: function(viewModelName, axisViewModelClassName) {
				var addButtonMarkerValue = viewModelName + "-AddButton";
				var instance = this.Ext.create(axisViewModelClassName, {
					Ext: this.Ext,
					Terrasoft: this.Terrasoft,
					sandbox: this.sandbox,
					values: {
						AxisMarkerName: viewModelName,
						DefaultValues: this.get("DefaultValues"),
						ParentItem: this,
						RowValuesCollection: this.Ext.create("Terrasoft.BaseViewModelCollection"),
						ToolItemsConfig: [
							{
								"className": "Terrasoft.Button",
								"markerValue": addButtonMarkerValue,
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"caption": this.get("Resources.Strings.AddValueButtonCaption"),
								"tag": "add"
							}
						]
					}
				});
				return instance;
			},

			/**
			 * ####### ##### ######### # ############# ## # ######### ########.
			 * @protected
			 * @param {String} collectionName ### ########, # ####### ##### ########### #########.
			 * @return {Terrasoft.BaseViewModelCollection} ######### #########.
			 */
			createCollection: function(collectionName) {
				var collection = Ext.create("Terrasoft.BaseViewModelCollection");
				this.set(collectionName, collection);
				return collection;
			},

			/**
			 * ###### ### ###### #######.
			 * @protected
			 */
			onClearRowCollection: function() {
				var collection = this.get("MatrixCollection");
				collection.clear();
			},

			/**
			 * ######### ########## ##### ###### # #######.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationItemViewModel} item ######, ####### ### ######## # #########
			 * ##########.
			 */
			onAddRow: function(item) {
				if (item.get("IsTools")) {
					return;
				}
				var horizontalCollection = this.getAxisValueCollection("HorizontalRowViewModel");
				var horizontalItems = horizontalCollection.getItems();
				if (this.isAddRowInClearedMatrix()) {
					this.recreateRowsInMatrix();
				} else {
					var itemId = item.get("Id");
					this.createRowInMatrix(itemId, horizontalItems);
				}
			},

			/**
			 * #########, ### ######### ####### #### ######## # ### #### # ############ ######### #### #### ## ####
			 * ######.
			 * @protected
			 * @return {Boolean} ########## true, #### ######### ####### #### ######## # ### #### # ############
			 * ######### #### #### ## #### ######.
			 */
			isAddRowInClearedMatrix: function() {
				var vetricalCollection = this.getAxisValueCollection("VerticalRowViewModel");
				var matrixCollection = this.get("MatrixCollection");
				return vetricalCollection.getCount() > 2 && matrixCollection.getCount() === 0;
			},

			/**
			 * ####### ###### ########## ##### # ######, ########### ## ########## ########.
			 * @protected
			 * @param {String} verticalItemId ############# ############# #########, ### ######## ######### ###### #
			 * #######.
			 * @param {Array} horizontalItems ########## ############## ######.
			 */
			createRowInMatrix: function(verticalItemId, horizontalItems) {
				var newRowValuesCollection = this.Ext.create("Terrasoft.BaseViewModelCollection");
				var matrixCollection = this.get("MatrixCollection");
				var specificationRowViewModel = this.createMatrixRow(verticalItemId, matrixCollection);
				for (var i = 0; i < horizontalItems.length; i++) {
					var horizontalItem = horizontalItems[i];
					if (!horizontalItem.get("IsTools")) {
						var id = horizontalItem.get("Id");
						var itemModelConfig =  this.getMatrixItemConfig(id, i, specificationRowViewModel);
						var rowViewModelName = this.getMatrixRowItemClassName();
						var rowItem = this.Ext.create(rowViewModelName, itemModelConfig);
						newRowValuesCollection.add(id, rowItem);
					}
				}
				var rowValuesCollection = specificationRowViewModel.getRowValuesCollection();
				rowValuesCollection.loadAll(newRowValuesCollection);
				matrixCollection.add(verticalItemId, specificationRowViewModel);
			},

			/**
			 * ######## ### ###### ###### ### ######## ######, ########### ## #### #########.
			 * @protected
			 * @return {String} ### ###### ######.
			 */
			getMatrixRowItemClassName: function() {
				var parent = this.get("ParentItem");
				var parameter = parent.get("ParameterViewModel");
				var parameterValue = parameter.get("Value");
				var type = parameterValue.Type;
				var dataType = parent.getDataValueTypeBySpecificationType(type.value);
				return parent.getRowItemViewModelName(dataType);
			},

			/**
			 * ########## ######## ######### (##############).
			 * @protected
			 * @return {Object} ######## #########.
			 */
			getSpecification: function() {
				var parent = this.get("ParentItem");
				var parameter = parent.get("ParameterViewModel");
				var parameterValue = parameter.get("Value");
				return parameterValue;
			},

			/**
			 * ########## ############ ### ######## #######.
			 * @protected
			 * @param {String} id ############# ######## ######## ######### ## ### X.
			 * @param {Number} valuePosition ####### ######## # ######### ######.
			 * @param {Terrasoft.SpecificationRowViewModel} parentItem ###### ######, # ####### ##### ########
			 * #######.
			 * @return {Object} ############ ######## #######.
			 */
			getMatrixItemConfig: function(id, valuePosition, parentItem) {
				return {
					Ext: this.Ext,
					Terrasoft: this.Terrasoft,
					sandbox: this.sandbox,
					values: {
						ElementId: this.Terrasoft.generateGUID(),
						ParentItem: parentItem,
						IsReadMode: true,
						DefaultValues: this.get("DefaultValues"),
						Specification: this.getSpecification(),
						SpecTableValueX: id,
						SpecTableValueY: parentItem.get("Id"),
						ValuePosition: valuePosition,
						RowPosition: parentItem.get("RowPosition")
					}
				};
			},

			/**
			 * ####### ##### ######.
			 * @protected
			 * @param {String} itemId ############# ######.
			 * @return {Terrasoft.SpecificationRowViewModel} ######### ##### ###### ### #######.
			 */
			createMatrixRow: function(itemId) {
				var collection = this.get("MatrixCollection");
				var rowPosition = collection.getCount();
				var instance = this.Ext.create(this.matrixViewModel, {
					Ext: this.Ext,
					Terrasoft: this.Terrasoft,
					sandbox: this.sandbox,
					values: {
						Id: itemId,
						ParentItem: this,
						RowPosition: rowPosition
					}
				});
				return instance;
			},

			/**
			 * ####### ###### ## #######, ########### ## ############## ########## ######### ## ######### ############
			 * ######.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationItemViewModel} item ######### #######.
			 */
			onRemoveRow: function(item) {
				var id = item.get("Id");
				var matrixCollection = this.get("MatrixCollection");
				var row = matrixCollection.get(id);
				var collection = row.getRowValuesCollection();
				var deletedItemMatrixCollection = this.get("DeletedItemMatrixCollection");
				collection.each(function(specificationRow) {
					deletedItemMatrixCollection.add(specificationRow);
				}, this);
				var deletedRowCollection = this.get("DeletedRowCollection");
				deletedRowCollection.add(item);
				matrixCollection.removeByKey(id);
			},

			/**
			 * ######### ##### ##### ####### # ######### # ### ##### ########.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationItemViewModel} item ######, ####### ### ######## # #########
			 * ##########.
			 */
			onAddColumn: function(item) {
				if (item.get("IsTools")) {
					return;
				}
				var id = item.get("Id");
				var matrixCollection = this.get("MatrixCollection");
				var vetricalCollection = this.getAxisValueCollection("VerticalRowViewModel");
				if (vetricalCollection.getCount() > 1 && matrixCollection.getCount() === 0) {
					this.recreateRowsInMatrix(item);
					return;
				}
				matrixCollection.each(function(specificationRow) {
					var collection = specificationRow.getRowValuesCollection();
					var valuePosition = collection.getCount();
					var itemModelConfig = this.getMatrixItemConfig(id, valuePosition, specificationRow);
					var rowViewModelName = this.getMatrixRowItemClassName();
					collection.add(id,
						this.Ext.create(rowViewModelName, itemModelConfig));
				}, this);
			},

			/**
			 * ####### ###### ### ####### # ######### ## ##### ####### ### ########## ############### #########.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationItemViewModel} item ######, ####### ### ######## # #########
			 * ##########.
			 */
			recreateRowsInMatrix: function(item) {
				var vetricalCollection = this.getAxisValueCollection("VerticalRowViewModel");
				var keys = vetricalCollection.getKeys();
				var horizontalItems = item ? [item] : [];
				for (var i = 1; i < keys.length; i++) {
					this.createRowInMatrix(keys[i], horizontalItems);
				}
			},

			/**
			 * ########## ## ######### #########.
			 * @protected
			 */
			changeFireEvent: function() {
				this.fireEvent("change", this, {
					event: "change",
					arguments: null
				});
			},

			/**
			 * ############ ####### {@link Terrasoft.Collection#itemChanged}.
			 * @protected
			 * @virtual
			 * @param {Terrasoft.BaseViewModel} item ####### #########, # ####### ######### #########.
			 * @param {Object} config ######### #######.
			 */
			onItemChanged: function(item, config) {
				if (!config.silent && !config.preventValidation) {
					this.changeFireEvent();
				}
			},

			/**
			 * ######### ##### ##### ####### # ####### ## ###### ########, ########### ## ############## ##########
			 * ######### ## ######### ############## ######.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationItemViewModel} item ######### #######.
			 */
			onRemoveColumn: function(item) {
				var id = item.get("Id");
				var matrixCollection = this.get("MatrixCollection");
				var deletedItemMatrixCollection = this.get("DeletedItemMatrixCollection");
				matrixCollection.each(function(specificationRow) {
					var collection = specificationRow.getRowValuesCollection();
					var matrixItem = collection.get(id);
					deletedItemMatrixCollection.add(matrixItem);
					collection.removeByKey(id);
				}, this);
				var deletedColumnCollection = this.get("DeletedColumnCollection");
				deletedColumnCollection.add(item);
			},

			/**
			 * ######### ######## ## ####### #########.
			 * @protected
			 * @param {Terrasoft.BaseViewModelCollection} collection #########, ### ####### ##### ######### ########.
			 * @param {Function} addHandler ##########, ####### ##### ###### ### ########## ###### ######## # #########.
			 * @param {Function} removeHandler ##########, ####### ##### ###### ### ######## ######## ## #########.
			 * @param {Function} clearHandler ##########, ####### ##### ###### ### ####### #########.
			 * @param {Function} changeHandler ##########, ####### ##### ###### ### ######### #########.
			 */
			subscribeOnCollectionEvents: function(collection, addHandler, removeHandler, clearHandler, changeHandler) {
				collection.on("add", addHandler, this);
				collection.on("remove", removeHandler, this);
				collection.on("clear", clearHandler, this);
				collection.on("itemChanged", changeHandler, this);
			},

			/**
			 * ######### ####### ## ####### #########.
			 * @protected
			 * @param {Terrasoft.BaseViewModelCollection} collection #########, ### ####### ##### ######### ########.
			 * @param {Function} addHandler ##########, ####### ##### ###### ### ########## ###### ######## # #########.
			 * @param {Function} removeHandler ##########, ####### ##### ###### ### ######## ######## ## #########.
			 * @param {Function} clearHandler ##########, ####### ##### ###### ### ####### #########.
			 * @param {Function} changeHandler ##########, ####### ##### ###### ### ######### #########.
			 */
			unsubscribeOnCollectionEvents: function(collection, addHandler, removeHandler, clearHandler, changeHandler) {
				collection.un("add", addHandler, this);
				collection.un("remove", removeHandler, this);
				collection.un("clear", clearHandler, this);
				collection.un("itemChanged", changeHandler, this);
			},

			/**
			 * ######## ######### ######## ## ###### ### #######.
			 * @protected
			 * @param {String} name ### ########, # ####### ############# ###### ###### ### #######.
			 * @return {Terrasoft.Collection} ######### ######## # ####### ######.
			 */
			getAxisValueCollection: function(name) {
				var row = this.get(name);
				return row.getRowValuesCollection();
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#onDestroy
			 * @overridden
			 */
			onDestroy: function() {
				var matrixCollection = this.get("MatrixCollection");
				this.unsubscribeOnCollectionEvents(matrixCollection, this.Terrasoft.emptyFn, this.Terrasoft.emptyFn,
					this.Terrasoft.emptyFn, this.onItemChanged);
				this.unsubscribeOnCollectionEvents(this.getAxisValueCollection("HorizontalRowViewModel"),
					this.onAddColumn, this.onRemoveColumn, this.onClearRowCollection);
				this.unsubscribeOnCollectionEvents(this.getAxisValueCollection("VerticalRowViewModel"), this.onAddRow,
					this.onRemoveRow, this.onClearRowCollection);
				var horizontalRow = this.get("HorizontalRowViewModel");
				horizontalRow.destroy();
				var verticalRow = this.get("VerticalRowViewModel");
				verticalRow.destroy();
				this.callParent(arguments);
			}
		});

		return Terrasoft.SpecificationMatrixBuilderViewModel;
	});
