define("ProductSectionV2", ["ConfigurationEnums"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "Product",
			attributes: {
				/**
				 * #########, ########## ### #### # ######### #########.
				 * @protected
				 * @type {Terrasoft.COLLECTION}
				 */
				"TypeList": {dataValueType: Terrasoft.DataValueType.COLLECTION},
				/**
				 * ######### ###### ### ############# ###### ######### #########.
				 * @protected
				 * @type {Terrasoft.COLLECTION}
				 */
				"CategoryMenuList": {dataValueType: Terrasoft.DataValueType.COLLECTION},
				/**
				 * Can bind data
				 */
				"IsBindDataActionVisible": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "SeparateModeAddRecordButton",
					"parentName": "SeparateModeActionButtonsLeftContainer",
					"propertyName": "items",
					"values": {
						"controlConfig": {
							"menu": {
								"items": {"bindTo": "CategoryMenuList"}
							}
						}
					}
				},
				{
					"operation": "merge",
					"name": "CombinedModeAddRecordButton",
					"parentName": "CombinedModeActionButtonsSectionContainer",
					"propertyName": "items",
					"values": {
						"style": Terrasoft.controls.ButtonEnums.style.GREEN,
						"controlConfig": {
							"menu": {
								"items": {"bindTo": "CategoryMenuList"}
							}
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSectionV2#init
				 * @override
				 */
				init: function() {
					this.set("CategoryMenuList", this.Ext.create("Terrasoft.BaseViewModelCollection"));
					this.initializeBindDataActionVisible();
					this.callParent(arguments);
				},

				/**
				 * Initialize bind data action visible.
				 * @protected
				 */
				initializeBindDataActionVisible: function() {
					var isFeatureEnabled = this.Terrasoft.Features.getIsEnabled("ProductDataBindingEnabled");
					var isNetCore = this.Terrasoft.appFramework === "NETCOREAPP";
					var isBindDataActionVisible = isFeatureEnabled && !isNetCore;
					this.set("IsBindDataActionVisible", isBindDataActionVisible);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.ProductSectionV2#getSectionActions
				 * @override
				 */
				getSectionActions: function() {
					var actionMenuItems = this.callParent(arguments);
					this.removeConfigureProductTypesAction(actionMenuItems);
					this.addProductSelectionAction(actionMenuItems);
					return actionMenuItems;
				},

				/**
				 * Removes product types action.
				 * @param {Terrasoft.Collection} actionMenuItems Menu actions.
				 */
				removeConfigureProductTypesAction: function(actionMenuItems) {
					var bindTo = "Resources.Strings.ConfigureProductTypes";
					actionMenuItems.each(function(item) {
						var caption = item.get("Caption");
						if (caption && caption.bindTo === bindTo) {
							actionMenuItems.remove(item);
							return false;
						}
					});
				},

				/**
				 * Adds product selection action.
				 * @param {Terrasoft.Collection} actionMenuItems Menu actions.
				 */
				addProductSelectionAction: function(actionMenuItems) {
					if (!this.getIsFeatureEnabled("UseNewProductSelection")) {
						return;
					}
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Caption": {
							"bindTo": "Resources.Strings.ProductSelectionCaption"
						},
						"Click": {
							"bindTo": "navigateToProductSelection"
						}
					}));
				},

				/**
				 * Navigates to product selection.
				 */
				navigateToProductSelection: function() {
					const sandbox = this.sandbox;
					sandbox.publish("PushHistoryState", {
						hash: "ProductSelectionModuleV3"
					});
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSectionV2#initAddRecordButtonParameters
				 * @override
				 */
				initAddRecordButtonParameters: function() {
					this.callParent(arguments);
					var esq = this.getAddButtonMenuESQ();
					esq.getEntityCollection(function(response) {
						if (response.success) {
							this.onAddButtonMenuLoaded(response.collection);
						}
					}, this);
				},

				/**
				 * ####### ######### ###### Terrasoft.EntitySchemaQuery.
				 * @protected
				 * @return {Terrasoft.EntitySchemaQuery} ########## ######### ###### Terrasoft.EntitySchemaQuery.
				 */
				getAddButtonMenuESQ: function() {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "ProductType"
					});
					esq.addColumn("Name");
					esq.addColumn("Category");
					return esq;
				},

				/**
				 * ####### ######## ######, ########### ##### ###### ########## ######.
				 * @param {Terrasoft.Collection} collection ######### #####, ####### ###### ######.
				 * @protected
				 */
				onAddButtonMenuLoaded: function(collection) {
					this.set("TypeList", collection);
					var categoryCollection = this.Ext.create("Terrasoft.BaseViewModelCollection");
					var typeCollection = {};
					collection.each(this.fillTypeAndCategoryCollections.bind(this, typeCollection, categoryCollection));
					var categoryMenuList = this.get("CategoryMenuList");
					categoryMenuList.loadAll(categoryCollection);
				},

				/**
				 * ######### ########## ######### ##### # ######### ## ######### ###### #####, ########## ## #######.
				 * @param {Object} typeCollection ######, # ######## # ######## #### ####### ######### #############
				 * #########, # # ######## ########### #### - ##### #####, ############# #### #########.
				 * @param {Terrasoft.BaseViewModelCollection} categoryCollection ######### #########.
				 * @param {Object} item ###, ####### ###### ######.
				 * @protected
				 */
				fillTypeAndCategoryCollections: function(typeCollection, categoryCollection, item) {
					var category = item.get("Category");
					if (!this.Ext.isEmpty(category)) {
						var typeMenuItem = typeCollection[category.value] ||
							this.Ext.create("Terrasoft.BaseViewModelCollection");
						typeMenuItem.addItem(this.getButtonMenuItem({
							Caption: item.get("Name"),
							Tag: item.get("Id"),
							Click: {bindTo: "addNewProductForType"}
						}));
						if (this.Ext.isEmpty(typeCollection[category.value])) {
							categoryCollection.addItem(this.getButtonMenuItem({
								Caption: category.displayValue,
								Items: typeMenuItem
							}));
							typeCollection[category.value] = typeMenuItem;
						}
					}
				},

				/**
				 * ####### ##### ####### ########## ####.
				 * @param {String} id ############# ####.
				 * @protected
				 */
				addNewProductForType: function(id) {
					this.showBodyMask();
					var types = this.get("TypeList");
					var currentType = types.get(id);
					var currentCategory = currentType.get("Category");
					this.set("CurrentCategory", currentCategory.value);
					var query = this.getInsertQuery();
					var columnValues = query.columnValues;
					columnValues.clear();
					var productName = currentCategory.displayValue + " / " + currentType.get("Name");
					columnValues.setParameterValue("Name", productName, this.getColumnDataType("Name"));
					columnValues.setParameterValue("Type", currentType.get("Id"), this.getColumnDataType("Type"));
					columnValues.setParameterValue("Category", currentCategory.value,
						this.getColumnDataType("Category"));
					query.execute(this.onSaveProductResponse, this);
				},

				/**
				 * ########## ########## ########.
				 * @param {Object} response ##### ## #######.
				 * @protected
				 */
				onSaveProductResponse: function(response) {
					this.hideBodyMask();
					if (response.success) {
						if (this.get("MultiSelect")) {
							this.saveMultiSelectState();
							this.unSetMultiSelect();
						}
						const cardSchemaName = this.getEditPageSchemaName(this.$CurrentCategory);
						this.openCard(cardSchemaName, ConfigurationEnums.CardStateV2.EDIT, response.id);
						this.loadGridDataRecord(response.id);
					}
				},

				/**
				 * Shows copy product confirmation dialog.
				 * If user press Yes, then call copy service, else call base copy method.
				 * @param {Guid} primaryColumnValue Primary column value.
				 * @param {Function} baseCopyMethod Base copy method
				 */
				copyProductRecord: function(primaryColumnValue, baseCopyMethod) {
					var messageBoxButtons = this.Terrasoft.MessageBoxButtons;
					var message = this.get("Resources.Strings.CopyProductRecordConfirmationMessage");
					this.showConfirmationDialog(message, function(returnCode) {
						if (returnCode === messageBoxButtons.YES.returnCode) {
							this.callCopyRecordService(primaryColumnValue);
							return;
						}
						baseCopyMethod();
					}, [messageBoxButtons.YES.returnCode, messageBoxButtons.NO.returnCode]);
				},

				/**
				 * Get config with parameters for copy service.
				 * @protected
				 * @param {Guid} primaryColumnValue Primary column value.
				 * @return {Object} with parameters for copying.
				 */
				getCopyRecordConfig: function(primaryColumnValue) {
					return {
						serviceName: "HierarchyDataCopyingService",
						methodName: "CreateRecordCopy",
						data: {
							schemaName: this.entitySchemaName,
							recordId: primaryColumnValue
						},
						scope: this
					};
				},

				/**
				 * Call service that creates records copy.
				 * @protected
				 * @param {Guid} primaryColumnValue Primary column value.
				 */
				callCopyRecordService: function(primaryColumnValue) {
					this.showBodyMask();
					var config = this.getCopyRecordConfig(primaryColumnValue);
					this.callService(config, this.copyRecordServiceCallBack, this);
				},

				/**
				 * Handles copy record service callback.
				 * @param {Object} response Response.
				 */
				copyRecordServiceCallBack: function(response) {
					response = response || {};
					response = response.CreateRecordCopyResult || {};
					this.hideBodyMask();
					if (!response.success) {
						var errorMessage = response.errorInfo && response.errorInfo.message;
						if (response.errorInfo) {
							this.showInformationDialog(errorMessage);
						}
						return;
					}
					const copiedRecordId = response.recordId;
					this.openCopiedRecord(copiedRecordId);
				},

				/**
				 * Opens copied record.
				 * @protected
				 * @param {Guid} copiedRecordId Copied record id.
				 */
				openCopiedRecord: function(copiedRecordId) {
					const activeRow = this.getActiveRow(copiedRecordId);
					const typeColumnValue = this.getTypeColumnValue(activeRow);
					const schemaName = this.getEditPageSchemaName(typeColumnValue);
					this.openCardInChain({
						id: copiedRecordId,
						schemaName: schemaName,
						operation: ConfigurationEnums.CardStateV2.EDIT,
						moduleId: this.getChainCardModuleSandboxId(typeColumnValue),
						defaultValues: [{
							name: "IsCopied",
							value: true
						}]
					});
					this.setButtonsVisibilityForCopiedRecord();
				},

				/**
				 * Sets buttons visibility for copied record.
				 * @protected
				 */
				setButtonsVisibilityForCopiedRecord: function() {
					this.set("ShowCloseButton", false);
					this.set("IsCardInEditMode", true);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSectionV2#addRecord
				 * @override
				 */
				addRecord: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseDataView#copyRecord
				 * @override
				 */
				copyRecord: function(primaryColumnValue) {
					var parentMethod = this.getParentMethod(this, arguments);
					if (!this.getIsFeatureEnabled("CopyProduct")) {
						parentMethod();
						return;
					}
					this.copyProductRecord(primaryColumnValue, parentMethod);
				}
			}
		};
	});
