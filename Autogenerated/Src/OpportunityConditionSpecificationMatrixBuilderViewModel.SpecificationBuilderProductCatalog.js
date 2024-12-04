define("OpportunityConditionSpecificationMatrixBuilderViewModel", ["SpecificationMatrixBuilderViewModel",
	"OpportunityConditionSpecificationMatrixBuilderViewModelResources", "AxisSpecificationRowViewModel",
	"MatrixSpecificationRowViewModel", "ProductConditionMatrixComboBoxItemViewModel",
	"ProductConditionMatrixIntegerItemViewModel", "ProductConditionMatrixFloatItemViewModel",
	"ProductConditionMatrixTextItemViewModel", "HorizontalAxisSpecificationRowViewModel"],
	function() {
		Ext.define("Terrasoft.configuration.OpportunityConditionSpecificationMatrixBuilderViewModel", {
			alternateClassName: "Terrasoft.OpportunityConditionSpecificationMatrixBuilderViewModel",
			extend: "Terrasoft.SpecificationMatrixBuilderViewModel",

			/**
			 * @inheritdoc Terrasoft.SpecificationMatrixBuilderViewModel#horizontalAxisViewModelName
			 * @overridden
			 */
			horizontalAxisViewModelName: "Terrasoft.HorizontalAxisSpecificationRowViewModel",

			/**
			 * @inheritdoc Terrasoft.SpecificationMatrixBuilderViewModel#verticalAxisViewModelName
			 * @overridden
			 */
			verticalAxisViewModelName: "Terrasoft.AxisSpecificationRowViewModel",

			/**
			 * @inheritdoc Terrasoft.SpecificationMatrixBuilderViewModel#matrixViewModel
			 * @overridden
			 */
			matrixViewModel: "Terrasoft.MatrixSpecificationRowViewModel",

			/**
			 * @inheritDoc Terrasoft.SpecificationMatrixBuilderViewModel#floatItemClassName
			 * @overridden
			 */
			floatItemClassName: "Terrasoft.ProductConditionMatrixFloatItemViewModel",

			/**
			 * @inheritDoc Terrasoft.SpecificationMatrixBuilderViewModel#integerItemClassName
			 * @overridden
			 */
			integerItemClassName: "Terrasoft.ProductConditionMatrixIntegerItemViewModel",

			/**
			 * @inheritDoc Terrasoft.SpecificationMatrixBuilderViewModel#comboBoxItemClassName
			 * @overridden
			 */
			comboBoxItemClassName: "Terrasoft.ProductConditionMatrixComboBoxItemViewModel",

			/**
			 * @inheritDoc Terrasoft.SpecificationMatrixBuilderViewModel#textItemClassName
			 * @overridden
			 */
			textItemClassName: "Terrasoft.ProductConditionMatrixTextItemViewModel",

			/**
			 * @inheritDoc Terrasoft.SpecificationMatrixBuilderViewModel#booleanItemClassName
			 * @overridden
			 */
			booleanItemClassName: "Terrasoft.ProductConditionMatrixBooleanItemViewModel",

			/**
			 * @inheritdoc Terrasoft.SpecificationMatrixBuilderViewModel#constructor
			 * @overridden
			 */
			constructor: function() {
				this.callParent(arguments);
				this.subscribeForScroll();
			},

			/**
			 * ######### ######## ## ####### Scroll, ### ############# ######## ########## ######## #########
			 * ###### ######### # #######.
			 * @protected
			 */
			subscribeForScroll: function() {
				var horizontalRowViewModel = this.get("HorizontalRowViewModel");
				var verticalRowViewModel = this.get("VerticalRowViewModel");
				horizontalRowViewModel.on("Scroll", this.onScroll, this);
				verticalRowViewModel.on("Scroll", this.onScroll, this);
			},

			/**
			 * @inheritdoc Terrasoft.SpecificationMatrixBuilderViewModel#getItemViewConfig
			 * @overridden
			 */
			getItemViewConfig: function() {
				var horizontalRowViewModel = this.get("HorizontalRowViewModel");
				var verticalRowViewModel = this.get("VerticalRowViewModel");
				return {
					"className": "Terrasoft.SpecificationMatrixBuilder",
					"caption": {"bindTo": "Resources.Strings.MatrixBuilderCaption"},
					"matrixCollection": {"bindTo": "MatrixCollection"},
					"horizontalRowViewModel": {"bindTo": "HorizontalRowViewModel"},
					"verticalRowViewModel": {"bindTo": "VerticalRowViewModel"},
					"horizontalSpecificationConfig": horizontalRowViewModel.getParameterViewConfig(),
					"verticalSpecificationConfig": verticalRowViewModel.getParameterViewConfig(),
					"rightContainerScroll": {"bindTo": "RightContainerScroll"}
				};
			},

			/**
			 * @inheritdoc Terrasoft.BaseModel#onDataChange
			 * @overridden
			 */
			onDataChange: function(obj, options) {
				var changedValues = this.changedValues = this.changedValues || {};
				for (var key in obj.changed) {
					changedValues[key] = obj.changed[key];
				}
				if (!obj.changed.hasOwnProperty("RightContainerScroll")) {
					this.fireEvent("change", this, options);
				}
			},

			/**
			 * ######## ###### ####### ######## ## ######## ######.
			 * @param {Number} value ####### ####### ###### ##### #######.
			 * @protected
			 */
			onScroll: function(value) {
				this.set("RightContainerScroll", value.scrollRight);
			},

			/**
			 * ########## ######## ####### ############ ##########.
			 * @protected
			 * @param {String} xPositionId ########## ## ### X.
			 * @param {String} yPositionId ########## ## ### Y.
			 * @return {Terrasoft.BaseViewModel} ###### ###### #######.
			 */
			getMatrixValueItem: function(xPositionId, yPositionId) {
				var matrixCollection = this.get("MatrixCollection");
				var row = matrixCollection.get(yPositionId);
				var rowValuesCollection = row.getRowValuesCollection();
				return rowValuesCollection.get(xPositionId);
			},

			/**
			 * ######### ######## ####### ############ ######### ########.
			 * @protected
			 * @param {Terrasoft.BaseViewModelCollection} valuesCollection ######### ###### ### #######.
			 */
			loadMatrixValues: function(valuesCollection) {
				valuesCollection.each(function(item) {
					var xPosition = item.get("SpecTableValueX");
					xPosition = xPosition && xPosition.value;
					var yPosition = item.get("SpecTableValueY");
					yPosition = yPosition && yPosition.value;
					var valueItem = this.getMatrixValueItem(xPosition, yPosition);
					var isEmptyValue = item.get("IsEmptyValue");
					valueItem.set("IsEmptyValue", isEmptyValue);
					valueItem.loadEntity(item);
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#loadEntity
			 * @overridden
			 */
			loadEntity: function(entity) {
				this.isNew = false;
				var horizontalRowViewModel = this.get("HorizontalRowViewModel");
				var horizontalRowEntity = entity.get("XAxisEntity");
				horizontalRowViewModel.loadEntity(horizontalRowEntity);
				var verticalRowViewModel = this.get("VerticalRowViewModel");
				var verticalRowEntity = entity.get("YAxisEntity");
				verticalRowViewModel.loadEntity(verticalRowEntity);
				var valuesCollection = entity.get("MatrixValuesCollection");
				this.loadMatrixValues(valuesCollection);
			},

			/**
			 * @inheritdoc Terrasoft.SpecificationMatrixBuilderViewModel#getMatrixRowItemClassName
			 * @overridden
			 */
			getMatrixRowItemClassName: function() {
				var parent = this.get("ParentItem");
				var parameter = parent.get("ParameterViewModel");
				var parameterValue = parameter.get("Value");
				var type = parameterValue.Type;
				var dataType = parent.getDataValueTypeBySpecificationType(type.value);
				return this.getMatrixRowItemViewModelName(dataType);
			},

			/**
			 * #########, ##### ## ######### ######.
			 * @return {bool} #######, ##### ######### ### ###.
			 */
			canSave: function() {
				return true;
			},

			/**
			 * ######### ##### ## ######### ######.
			 * @virtual
			 * @param {Terrasoft.BaseViewModel} item #######, ####### ##### #########.
			 * @return {bool} ####### ##### ######### ### ###.
			 */
			canSaveItem: function(item) {
				return !(item.get("IsTools"));
			},

			/**
			 * ######### ####### ##########.
			 * @private
			 * @param {Array} chainArguments ####### ##########.
			 * @param {Terrasoft.Collection} collection ######### ######### ### ##########.
			 */
			fillChainArguments: function(chainArguments, collection) {
				this.Terrasoft.each(collection, function(item) {
					chainArguments.push(function(next) {
						if (this.canSaveItem(item)) {
							item.saveEntity(function(response) {
								this.validateEntityResponse(response);
								next();
							}, this);
						} else {
							next();
						}
					});
				}, this);
			},

			/**
			 * ######### ########## ####### ## ######.
			 * @private
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ####### ######### ######.
			 */
			saveRecords: function(callback, scope) {
				var chainArguments = [];
				var verticalRowViewModel = this.get("VerticalRowViewModel");
				var verticalRowValuesCollection = verticalRowViewModel.get("RowValuesCollection");
				this.fillChainArguments(chainArguments, verticalRowValuesCollection.getItems());
				var horizontalRowViewModel = this.get("HorizontalRowViewModel");
				var horizontalRowValuesCollection = horizontalRowViewModel.get("RowValuesCollection");
				this.fillChainArguments(chainArguments, horizontalRowValuesCollection.getItems());
				var matrixCollection = this.get("MatrixCollection");
				this.Terrasoft.each(matrixCollection.getItems(), function(matrixItem) {
					var matrixRowValuesCollection = matrixItem.get("RowValuesCollection");
					this.fillChainArguments(chainArguments, matrixRowValuesCollection.getItems());
				}, this);
				chainArguments.push(function() {
					callback.call(scope);
				});
				chainArguments.push(this);
				this.Terrasoft.chain.apply(this, chainArguments);
			},

			/**
			 * ############ ######### ###### ## #######.
			 * @private
			 * @param {Object} response ###### - ##### ## #######.
			 */
			validateEntityResponse: function(response) {
				if (!response.success) {
					throw new this.Terrasoft.QueryExecutionException();
				}
			},

			/**
			 * ######### ####### ########.
			 * @private
			 * @param {Array} chainArguments ####### ##########.
			 * @param {Terrasoft.Collection} collection ######### ######### ### ########.
			 */
			deleteEntities: function(chainArguments, collection) {
				collection.each(function(item) {
					if (item.isNew) {
						collection.remove(item);
					} else {
						chainArguments.push(function(next) {
							item.deleteEntity(function(response) {
								this.validateEntityResponse(response);
								next();
							}, this);
						});
					}
				}, this);
			},

			/**
			 * ######### ######## #######, ########## ## ########.
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ##########.
			 * @private
			 */
			deleteRecords: function(callback, scope) {
				var chainArguments = [];
				var deletedItemMatrixCollection = this.get("DeletedItemMatrixCollection");
				this.deleteEntities(chainArguments, deletedItemMatrixCollection);
				var deletedColumnCollection = this.get("DeletedColumnCollection");
				this.deleteEntities(chainArguments, deletedColumnCollection);
				var deletedRowCollection = this.get("DeletedRowCollection");
				this.deleteEntities(chainArguments, deletedRowCollection);
				chainArguments.push(function() {
					callback.call(scope);
				});
				chainArguments.push(this);
				this.Terrasoft.chain.apply(this, chainArguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#saveEntity
			 * @overridden
			 */
			saveEntity: function(callback, scope) {
				this.Terrasoft.chain(
					function(next) {
						this.deleteRecords(next, this);
					},
					function(next) {
						this.saveRecords(next, this);
					},
					function() {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope, {
								success: true
							});
						}
					},
					this
				);
			},

			/**
			 * ######### ######### ### ########.
			 * @param  {String} targetCollectionName ### #########, # ####### ##### ######### ######## ### ########.
			 * @param  {String} sourceViewModelName ### ######, ####### ######## ########, ####### ##### #######.
			 * @private
			 */
			fillDeletedCollection: function(targetCollectionName, sourceViewModelName) {
				var viewModel = this.get(sourceViewModelName);
				var valuesCollection = viewModel.get("RowValuesCollection");
				var deletedCollection = this.get(targetCollectionName);
				deletedCollection.loadAll(valuesCollection);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#deleteEntity
			 * @overridden
			 */
			deleteEntity: function(callback, scope) {
				this.Terrasoft.chain(
					function(next) {
						this.fillDeletedCollection("DeletedRowCollection", "VerticalRowViewModel");
						this.fillDeletedCollection("DeletedColumnCollection", "HorizontalRowViewModel");
						var matrixCollection = this.get("MatrixCollection");
						var deletedItemMatrixCollection = this.get("DeletedItemMatrixCollection");
						matrixCollection.each(function(matrixItem) {
							var matrixRowValuesCollection = matrixItem.get("RowValuesCollection");
							matrixRowValuesCollection.each(function(matrixRowValues) {
								deletedItemMatrixCollection.add(matrixRowValues);
							});
						}, this);
						this.deleteRecords(next, this);
					},
					function() {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope, {
								success: true
							});
						}
					},
					this
				);
			}
		});

		return Terrasoft.OpportunityConditionSpecificationMatrixBuilderViewModel;
	});
