define("ProductTypeLookupSectionV2", ["ProductTypeLookupSectionV2Resources", "ProductBankConstants",
		"ConfigurationEnums", "ModalBox", "css!ProductTypeLookupSectionCSSV2"],
	function(resources, constants, ConfigurationEnums, ModalBox) {
		return {
			entitySchemaName: "VwProductType",
			attributes: {
				/**
				 * Hierarchical column name.
				 */
				"HierarchicalColumnName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: "ParentId"
				}
			},
			methods: {

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#switchActiveRowActions
				 * @overridden
				 */
				switchActiveRowActions: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#hideActiveRowActions
				 * @overridden
				 */
				hideActiveRowActions: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#loadFiltersModule
				 * @overridden
				 */
				loadFiltersModule: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.GridUtilities#sortColumn
				 * @overridden
				 */
				sortColumn: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.BaseSection#init
				 * @overridden
				 */
				init: function() {
					this.subscribeMessages();
					this.callParent(arguments);
				},

				/**
				 * Subscribes on messages.
				 * @protected
				 */
				subscribeMessages: function() {
					var moduleId = this.getCategoryOrTypeModalBoxModuleId();
					this.sandbox.subscribe("GetSchemaName", this.getSchemaName, this, [moduleId]);
					this.sandbox.subscribe("GetEntityInfo", this.getEntityInfo, this, [moduleId]);
					this.sandbox.subscribe("SaveEntity", this.onEntitySaved, this, [moduleId]);
				},

				/**
				 * Returns the name of category or type page schema.
				 * @protected
				 * @return {String} Page schema name.
				 */
				getSchemaName: function() {
					return this.get("SchemaName");
				},

				/**
				 * Returns an object containing information about the current operation and the ID of
				 * the selected record.
				 * @protected
				 * @return {Object} An object that contains the ID of the selected record and the current operation.
				 * @return {String} return.PrimaryColumnValue ID of the selected record.
				 * @return {ConfigurationEnums.CardStateV2} return.Operation Current operation,
				 * ConfigurationEnums.CardStateV2.ADD or ConfigurationEnums.CardStateV2.EDIT.
				 * @return {Object} return.DefaultValues Object with default values.
				 */
				getEntityInfo: function() {
					return {
						PrimaryColumnValue: this.get("ActiveRow"),
						Operation: this.get("Operation"),
						DefaultValues: this.get("DefaultValues")
					};
				},

				/**
				 * Handles response from the server after the record is saved.
				 * @protected
				 * @param {Object} response Server response.
				 */
				onEntitySaved: function(response) {
					if (response.success) {
						var activeRowId = this.get("ActiveRow");
						this.loadGridDataRecord(response.id || activeRowId);
					} else {
						this.showInformationDialog(resources.localizableStrings.InsertErrorMessage);
					}
				},

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#addRecord
				 * @overridden
				 */
				addRecord: function() {
					this.addCategory();
				},

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#loadGridDataView
				 * @overridden
				 */
				loadGridDataView: function() {
					this.callParent([true]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getDefaultDataViews
				 * @overridden
				 */
				getDefaultDataViews: function() {
					var dataViews = this.callParent(arguments);
					delete dataViews.AnalyticsDataView;
					return dataViews;
				},

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#initIsPageable
				 * @overridden
				 */
				initIsPageable: function() {
					this.set("IsPageable", false);
				},

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#initRowCount
				 * @overridden
				 */
				initRowCount: function() {
					this.set("RowCount", 1000);
				},

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#initData
				 * @overridden
				 */
				initData: function() {
					this.set("ExpandHierarchyLevels", []);
					this.callParent(arguments);
				},

				/**
				 * Returns listed grid setting.
				 * @private
				 * @return {Object} Object of grid setting.
				 */
				getGridListedConfig: function() {
					var primaryDisplayColumn = this.entitySchema.primaryDisplayColumn;
					return {
						"items": [
							{
								"bindTo": primaryDisplayColumn.columnPath,
								"caption": primaryDisplayColumn.caption,
								"position": {
									"column": 0,
									"colSpan": 22,
									"row": 1
								},
								"dataValueType": this.Terrasoft.DataValueType.TEXT,
								"metaCaptionPath": primaryDisplayColumn.caption,
								"metaPath": primaryDisplayColumn.columnPath,
								"path": primaryDisplayColumn.columnPath
							}
						]
					};
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#reloadGridColumnsConfig
				 * @overridden
				 */
				reloadGridColumnsConfig: function() {
					var listedConfig = this.getGridListedConfig();
					var profile = this.get("Profile");
					var propertyName = this.getDataGridName();
					profile[propertyName] = {
						type: this.Terrasoft.GridType.LISTED,
						listedConfig: this.Ext.encode(listedConfig)
					};
					this.set("Profile", profile);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getModuleCaption
				 * @overridden
				 */
				getModuleCaption: function() {
					var historyState = this.sandbox.publish("GetHistoryState");
					var state = historyState.state;
					if (state && state.caption) {
						return state.caption;
					}
					return this.get("Resources.Strings.LookupSectionCaption");
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getActiveViewCaption
				 * @overridden
				 */
				getActiveViewCaption: function() {
					return this.getModuleCaption();
				},

				/**
				 * Returns records with the type "Category".
				 * @private
				 * @param {Terrasoft.Collection} dataCollection Grid record collection.
				 * @return {Terrasoft.Collection} Returns records with the type "Category".
				 */
				getCategories: function(dataCollection) {
					return dataCollection.filter(function(item) {
						return item.get("Type") === constants.ProductLevels.CATEGORY;
					});
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#initCurrentModuleReports
				 * @overridden
				 */
				initCurrentModuleReports: this.Terrasoft.emptyFn,

				/**
				 * Opens editing card for vertical grid.
				 * @param {String} newRecordId New record ID.
				 * @protected
				 */
				openCardInCombinedMode: function(newRecordId) {
					if (!this.Ext.isEmpty(newRecordId)) {
						this.set("ActiveRow", newRecordId);
					}
					var primaryId = this.get("ActiveRow");
					var gridData = this.getGridData();
					var categories = this.getCategories(gridData);
					var firstRecord = categories.isEmpty() ? null : categories.getByIndex(0);
					if (this.Ext.isEmpty(primaryId)) {
						primaryId = firstRecord ? firstRecord.get(this.entitySchema.primaryColumnName) : null;
						this.set("ActiveRow", primaryId);
					}
					var historyState = this.getHistoryStateInfo();
					var isNewRowSelected = historyState.primaryColumnValue !== primaryId;
					var editPageName = this.getEditPageName(primaryId);
					var grid = this.getCurrentGrid();
					if (grid && grid.rendered && !this.Ext.isEmpty(primaryId) && isNewRowSelected) {
						this.openCard(editPageName, ConfigurationEnums.CardStateV2.EDIT, primaryId);
						this.addSectionHistoryState();
					}
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#onAfterReRender
				 * @overridden
				 */
				onAfterReRender: function() {
					this.callParent(arguments);
					this.showSection();
				},

				/**
				 * @inheritdoc BasePageV2#onRender
				 * @overridden
				 */
				onRender: function() {
					this.callParent(arguments);
					this.showSection();
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#onDataChanged
				 * @overridden
				 */
				onDataChanged: function() {
					this.callParent(arguments);
					this.openCardInCombinedMode();
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#afterLoadGridDataUserFunction
				 * @overridden
				 */
				afterLoadGridDataUserFunction: function(primaryColumnValue) {
					this.callParent(arguments);
					this.openCardInCombinedMode(primaryColumnValue);
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#onDeleted
				 * @overridden
				 */
				onDeleted: function() {
					this.openCardInCombinedMode();
				},

				/**
				 * Returns edit page name for selected record.
				 * @param {String} recordId ID type/category record.
				 * @return {String} Edit page name.
				 */
				getEditPageName: function(recordId) {
					var pageName = "";
					var gridData = this.getGridData();
					if (gridData.isEmpty() || this.Ext.isEmpty(recordId)) {
						return pageName;
					}
					var record = gridData.get(recordId);
					switch (record.get("Type")) {
						case constants.ProductLevels.TYPE:
							pageName = "DefProductTypePageV2";
							break;
						case constants.ProductLevels.CATEGORY:
							pageName = "DefProductCategoryPageV2";
							break;
					}
					return pageName;
				},

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#rowSelected
				 * @overridden
				 */
				rowSelected: function(primaryColumnValue) {
					if (this.get("IsCardVisible")) {
						var historyState = this.getHistoryStateInfo();
						var isNewRowSelected = historyState.primaryColumnValue !== primaryColumnValue;
						if (primaryColumnValue && isNewRowSelected && !this.get("IsCardInChain")) {
							var schemaName = this.getEditPageName(primaryColumnValue);
							this.openCard(schemaName, ConfigurationEnums.CardStateV2.EDIT, primaryColumnValue);
							this.addSectionHistoryState();
						}
					}
					this.set("IsCardInChain", false);
				},

				/**
				 * Adds columns in query instance to build a hierarchy.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq Query instance.
				 */
				addHierarchicalColumns: function(esq) {
					var columns = ["Type", "EntitySchemaName"];
					columns.push(this.get("HierarchicalColumnName"));
					this.Ext.Array.forEach(columns, function(column) {
						if (!esq.columns.contains(column)) {
							esq.addColumn(column, column);
						}
					});
				},

				/**
				 * @inheritDoc GridUtilitiesV2#initQueryColumns
				 * @overridden
				 */
				initQueryColumns: function(esq) {
					this.callParent(arguments);
					this.addHierarchicalColumns(esq);
				},

				/**
				 * Handles adding categories and types.
				 * @protected
				 * @param {String} tag
				 */
				onActiveRowAction: function(tag) {
					switch (tag) {
						case "addCategory":
							this.addCategory();
							break;
						case "addType":
							this.addType();
							break;
						case "edit":
							this.editRecord();
							break;
						case "remove":
							this.deleteRecords();
							break;
					}
				},

				/**
				 * Show a modal window to rename the category or type of product.
				 * @protected
				 */
				editRecord: function() {
					var activeRow = this.getActiveRow();
					var type = activeRow.get("Type");
					this.set("Operation", ConfigurationEnums.CardStateV2.EDIT);
					if (type === constants.ProductLevels.CATEGORY) {
						this.showEditCategoryDialog();
					} else {
						this.showEditTypeDialog();
					}
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#onDeleteAccept
				 * @overridden
				 */
				onDeleteAccept: function() {
					var activeRow = this.getActiveRow();
					var entitySchemaName = activeRow.get("EntitySchemaName");
					this.showBodyMask();
					this.callService({
						serviceName: "GridUtilitiesService",
						methodName: "DeleteRecords",
						data: {
							primaryColumnValues: this.getSelectedItems(),
							rootSchema: entitySchemaName
						}
					}, function(responseObject) {
						var result = this.Ext.decode(responseObject.DeleteRecordsResult);
						var success = result.Success;
						var deletedItems = result.DeletedItems;
						this.removeGridRecords(deletedItems);
						this.hideBodyMask();
						if (!success) {
							this.showDeleteExceptionMessage(result);
						}
						this.onDeleted(result);
						this.onDataChanged();
					}, this);
				},

				/**
				 * Sets active record by parent.
				 * @private
				 */
				setActiveRowByParentRecord: function() {
					var activeRow = this.getActiveRow();
					var parentId = this.getParentRecordId(activeRow);
					this.set("ActiveRow", this.Ext.isEmpty(parentId) ? null : parentId);
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#removeGridRecords
				 * @overridden
				 */
				removeGridRecords: function(records) {
					if (records && records.length) {
						var gridData = this.getGridData();
						var activeRow = this.getActiveRow();
						var primaryColumnName = this.entitySchema.primaryColumnName;
						var activeRowId = this.Ext.isEmpty(activeRow) ? null : activeRow.get(primaryColumnName);
						records.forEach(function(record) {
							this.removeParentItemFromExpandHierarchyLevels(record);
							if (activeRowId === record) {
								this.setActiveRowByParentRecord();
							}
							gridData.removeByKey(record);
						}, this);
						this.set("IsGridEmpty", !gridData.getCount());
					}
				},

				/**
				 * Returns ID of the parent element.
				 * @protected
				 * @param {String} record ID of grid record.
				 * @return {String} ID of the parent element.
				 */
				getParentRecordId: function(record) {
					return record.get(this.get("HierarchicalColumnName"));
				},

				/**
				 * Returns children records.
				 * @protected
				 * @param {String} recordId ID of grid record.
				 * @param {String} parentRecordId ID of grid parent record.
				 * @return {Array} Array of children records.
				 */
				getChildren: function(recordId, parentRecordId) {
					var gridData = this.getGridData();
					var hierarchicalColumnName = this.get("HierarchicalColumnName");
					var children = gridData.filterByFn(function(child) {
						return child.get(hierarchicalColumnName) === parentRecordId &&
							child.get(this.entitySchema.primaryColumnName) !== recordId;
					}, this);
					return children;
				},

				/**
				 *  Removes parent item from the expandHierarchyLevels collection,
				 * if it has no child elements.
				 * @protected
				 * @param {String} record Id of record.
				 */
				removeParentItemFromExpandHierarchyLevels: function(record) {
					var gridData = this.getGridData();
					var row = gridData.get(record);
					var parentId = this.getParentRecordId(row);
					if (this.Ext.isEmpty(parentId)) {
						return;
					}
					var children = this.getChildren(record, parentId);
					if (children.getCount() === 0) {
						var parent = gridData.get(parentId);
						var expandHierarchyLevels = this.get("ExpandHierarchyLevels");
						expandHierarchyLevels = expandHierarchyLevels.slice(0);
						this.Ext.Array.remove(expandHierarchyLevels, parentId);
						this.set("ExpandHierarchyLevels", expandHierarchyLevels);
						this.unsetHasNesting(parent);
					}
				},

				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#initQuerySorting
				 * @overridden
				 */
				initQuerySorting: function(esq) {
					var gridDataColumns = this.getGridDataColumns();
					var primaryDisplayColumnName = this.entitySchema.primaryDisplayColumnName;
					this.Terrasoft.each(gridDataColumns, function(column) {
						if (primaryDisplayColumnName === column.path) {
							var sortedColumn = esq.columns.collection.get(column.path);
							sortedColumn.orderPosition = 1;
							sortedColumn.orderDirection = this.Terrasoft.OrderDirection.DESC;
						}
					}, this);
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#addItemsToGridData
				 * @overridden
				 */
				addItemsToGridData: function(dataCollection, options) {
					if (options && !dataCollection.isEmpty()) {
						var addedItem = dataCollection.getByIndex(0);
						var parentId = this.getParentRecordId(addedItem);
						if (!this.Ext.isEmpty(parentId)) {
							options = {
								mode: "child",
								target: parentId
							};
							this.addItemToExpandHierarchyLevels(parentId);
						}
					}
					this.callParent(arguments);
					this.openCardInCombinedMode();
				},

				/**
				 * Adds an item to the grid expandHierarchyLevels.
				 * @protected
				 * @param {String} record Id of record.
				 */
				addItemToExpandHierarchyLevels: function(record) {
					var gridData = this.getGridData();
					var item = gridData.get(record);
					var expandHierarchyLevels = this.get("ExpandHierarchyLevels");
					expandHierarchyLevels = expandHierarchyLevels.slice(0);
					if (!this.Ext.Array.contains(expandHierarchyLevels, record)) {
						expandHierarchyLevels.push(record);
						this.set("ExpandHierarchyLevels", expandHierarchyLevels);
						this.unsetHasNesting(item);
						this.setHasNesting(item);
					}
				},

				/**
				 * Sets item's property HasNesting = 1.
				 * @private
				 * @param {BaseViewModel} item Item of grid's collection.
				 */
				setHasNesting: function(item) {
					item.set("HasNesting", 1);
				},

				/**
				 * Sets item's property HasNesting = 0 with sign {silent: true}.
				 * @private
				 * @param  {BaseViewModel} item Item of grid's collection.
				 */
				unsetHasNesting: function(item) {
					item.set("HasNesting", 0, {silent: true});
				},

				/**
				 * Opens a modal window to add a new category.
				 * @protected
				 */
				addCategory: function() {
					this.set("Operation", ConfigurationEnums.CardStateV2.ADD);
					this.showEditCategoryDialog();
				},

				/**
				 * Opens a modal window to add a new type.
				 * @protected
				 */
				addType: function() {
					this.set("Operation", ConfigurationEnums.CardStateV2.ADD);
					this.showEditTypeDialog();
				},

				/**
				 * Opens a modal window for editing categories.
				 * @protected
				 */
				showEditCategoryDialog: function() {
					this.set("SchemaName", "ProductCategoryEditPage");
					this.set("DefaultValues", undefined);
					this.loadCategoryOrTypeModalBoxModule(250, 410);
				},

				/**
				 * Opens a modal window for editing type.
				 * @protected
				 */
				showEditTypeDialog: function() {
					this.set("SchemaName", "ProductCategoryTypeEditPage");
					var activeRow = this.getActiveRow();
					this.set("DefaultValues", {
						Category: {
							name: "Category",
							value: {
								value: activeRow.get("Id"),
								displayValue: activeRow.get("Name")
							}
						}
					});
					this.loadCategoryOrTypeModalBoxModule(210, 410);
				},

				/**
				 * Returns the ID of the category modal box module.
				 * @protected
				 * @return {String} Module Id.
				 */
				getCategoryOrTypeModalBoxModuleId: function() {
					return this.sandbox.id + "CategoryOrTypeModalBoxModule";
				},

				/**
				 * Loads page for category or type in a modal window.
				 * @private
				 * @param {Integer} height The height of the window in pixels.
				 * @param {Integer} width The width of the window in pixels.
				 */
				loadCategoryOrTypeModalBoxModule: function(height, width) {
					var config = {
						heightPixels: height,
						widthPixels: width,
						boxClasses: ["category-page-modal-box"]
					};
					var moduleId = this.getCategoryOrTypeModalBoxModuleId();
					var renderTo = ModalBox.show(config, function() {
						this.sandbox.unloadModule(moduleId, renderTo);
					}.bind(this));
					this.sandbox.loadModule("CategoryOrTypeModalBoxModule", {
						id: moduleId,
						renderTo: renderTo
					});
				},

				/**
				 * Handles click on close button.
				 * @protected
				 * @virtual
				 */
				closeSection: function() {
					this.sandbox.publish("PushHistoryState", {
						hash: this.Terrasoft.combinePath("SectionModuleV2", "LookupSection")
					});
				},

				/**
				 * @inheritDoc Terrasoft.BaseSection#getToggleSectionButtonIsVisible
				 * @overridden
				 */
				getToggleSectionButtonIsVisible: function() {
					return false;
				},

				/**
				 * @inheritDoc Terrasoft.BaseSection#loadSummaryModule
				 * @overridden
				 */
				loadSummaryModule: Terrasoft.emptyFn

			},
			messages: {
				/**
				 * @message GetEntityInfo
				 */
				"GetEntityInfo": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message SaveEntity
				 */
				"SaveEntity": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message GetSchemaName
				 */
				"GetSchemaName": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "SectionWrapContainer",
					"values": {
						"wrapClass": ["ProductTypeLookupSectionV2", "section-wrap"]
					}
				},
				{
					"operation": "merge",
					"name": "CombinedModeActionButtonsSectionContainer",
					"values": {
						"wrapClass": ["product-type-lookup-combined-action-buttons-section-container-wrapClass"]
					}
				},
				{
					"operation": "remove",
					"name": "CombinedModeActionButtonsCardContainer"
				},
				{
					"operation": "merge",
					"name": "SeparateModeAddRecordButton",
					"values": {
						"caption": {"bindTo": "Resources.Strings.AddCategoryMenuCaption"}
					}
				},
				{
					"operation": "merge",
					"name": "CombinedModeAddRecordButton",
					"values": {
						"caption": {"bindTo": "Resources.Strings.AddCategoryMenuCaption"}
					}
				},
				{
					"operation": "merge",
					"name": "DataViewsContainer",
					"values": {
						"wrapClass": [
							"product-type-lookup-views-container-wrapClass",
							"data-view-border-right",
							"right-inner-el"
						]
					}
				},
				{
					"operation": "remove",
					"name": "CloseButton"
				},
				{
					"operation": "remove",
					"name": "SeparateModeActionsButton"
				},
				{
					"operation": "remove",
					"name": "CombinedModeActionsButton"
				},
				{
					"operation": "remove",
					"name": "SeparateModeViewOptionsButton"
				},
				{
					"operation": "remove",
					"name": "CombinedModeViewOptionsButton"
				},
				{
					"operation": "remove",
					"name": "DataGridActiveRowOpenAction"
				},
				{
					"operation": "remove",
					"name": "DataGridActiveRowCopyAction"
				},
				{
					"operation": "remove",
					"name": "DataGridActiveRowDeleteAction"
				},
				{
					"operation": "merge",
					"name": "DataGridContainer",
					"values": {
						"classes": {
							"wrapClassName": ["product-type-lookup-left-container"]
						}
					}
				},
				{
					"operation": "remove",
					"name": "GridUtilsContainer"
				},
				{
					"operation": "merge",
					"name": "DataGrid",
					"parentName": "DataGridContainer",
					"propertyName": "items",
					"values": {
						"listedZebra": false,
						"hierarchical": true,
						"hierarchicalColumnName": "ParentId",
						"expandHierarchyLevels": {"bindTo": "ExpandHierarchyLevels"}
					},
					"activeRowActions": []
				},
				{
					"operation": "insert",
					"name": "SettingsButton",
					"parentName": "DataGrid",
					"propertyName": "activeRowActions",
					"values": {
						"className": "Terrasoft.Button",
						"classes": {"wrapperClass": "settings-menu-actions-icon"},
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"tag": "settings",
						"markerValue": "SettingsButton",
						"imageConfig": resources.localizableImages.SettingsImageV2,
						"menu": {
							"items": [
								{
									"caption": resources.localizableStrings.AddTypeMenuCaption,
									"markerValue": resources.localizableStrings.AddTypeMenuCaption,
									"tag": "addType",
									"visible": {
										"bindTo": "Type",
										"bindConfig": {
											"converter": function(type) {
												return type === constants.ProductLevels.CATEGORY;
											}
										}
									}
								},
								{
									"caption": resources.localizableStrings.EditMenuCaption,
									"markerValue": resources.localizableStrings.EditMenuCaption,
									"tag": "edit"
								},
								{
									"caption": resources.localizableStrings.RemoveMenuCaption,
									"markerValue": resources.localizableStrings.RemoveMenuCaption,
									"tag": "remove"
								}
							]
						}
					}
				},
				{
					"operation": "insert",
					"name": "SeparateModeCloseButton",
					"parentName": "CombinedModeActionButtonsSectionContainer",
					"propertyName": "items",
					"index": 2,
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": {"bindTo": "Resources.Strings.CloseButtonCaption"},
						"click": {"bindTo": "closeSection"},
						"classes": {
							"textClass": ["actions-button-margin-right"],
							"wrapperClass": ["actions-button-margin-right"]
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
