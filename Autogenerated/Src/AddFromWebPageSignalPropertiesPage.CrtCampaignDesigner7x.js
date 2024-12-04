 define("AddFromWebPageSignalPropertiesPage", ["AddFromWebPageSignalPropertiesPageResources"],
    function(resources) {
        return {
			properties: {
				/**
				 * Default filter entity schema identifier for filter (contact).
				 * @type {Guid}
				 */
				defaultContactEntitySchemaId: "5b229e55-8ebf-414a-8dee-26e2b059025b",
				/**
				 * Default filter entity schema name for filter.
				 * @type {Guid}
				 */
				defaultContactEntitySchemaName: "Contact",
				/**
				 * Default filter entity schema identifier for filter (contact).
				 * @type {Guid}
				 */
				defaultFormSubmitEntitySchemaId: "aafd9a22-102c-4c2d-9f0c-086cb3e75dc1",
				/**
				 * Default filter entity schema name for filter.
				 * @type {Guid}
				 */
				defaultFormSubmitEntitySchemaName: "FormSubmit"
			},
            attributes: {
				/**
				 * Web page URL for filters.
				 * @type {Terrasoft.dataValueType.TEXT}
				 */
				"WebPageURL": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},
				/**
				 * Web page URL path for filters.
				 * @type {Terrasoft.dataValueType.TEXT}
				 */
				"WebPageURLColumn": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},
				/**
				 * Web page URL column caption
				 * @type {Terrasoft.dataValueType.TEXT}
				 */
				"CurrentWebPageColumnCaption": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
            },
            methods: {
				/**
				 * @inheritdoc Terrasoft.ProcessFlowElementPropertiesPage#initParameters
				 * @override
				 */
                initParameters: function(element) {
                    this.callParent(arguments);
					if (!this.$SignalEntities.hasOwnProperty(element.signalEntityId)) {
						return;
					}
                    this.set("WebPageURL", element.webPageURL);
					this.set("WebPageURLColumn", element.webPageURLColumn);
                },
				/**
				 * @inheritdoc Terrasoft.ProcessFlowElementPropertiesPage#saveValues
				 * @override
				 */
				saveValues: function() {
                    this.callParent(arguments);
                    var element = this.get("ProcessElement");
                    element.webPageURL = this.getWebPageURL();
                },
				/**
				 * Reading current attribute values.
				 * @protected
				 */
				getWebPageURL: function() {
                    var webPageURL = this.get("WebPageURL");
                    return webPageURL ? webPageURL : "";
                },
				/**
				 * Saves element entity filters property.
				 * @overriden
				 * @protected
				 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
				 */
				saveEntityFilters: function(element) {
					var webPageURL = this.get("WebPageURL") || "";
					const filterGroup = Terrasoft.createFilterGroup();
					var columnPath = this.get("WebPageURLColumn") || "";
					filterGroup.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.CONTAIN,
						columnPath, webPageURL));
					var isEmpty = filterGroup.isEmpty();
					var serializedFilter = filterGroup.serialize({
						serializeFilterManagerInfo: true
					});
					var filterData = {
						className: "Terrasoft.FilterGroup",
						serializedFilterEditData: serializedFilter,
						dataSourceFilters: filterGroup.serialize(),
					};
					this.set("HasEntityFilters", !isEmpty);
					element.setPropertyValue("hasEntityFilters", !isEmpty);
					element.setPropertyValue("entityFilters", JSON.stringify(filterData));
					element.setPropertyValue("webPageURLColumn", columnPath);
				},
				/**
				 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#initSignalEntity
				 * @override
				 */
				initSignalEntity: function(element) {
					if (Ext.isEmpty(element.signalEntityId)) {
						const contactSchema = Terrasoft.EntitySchemaManager.findItemByName(this.defaultContactEntitySchemaName);
						if (contactSchema != null) {
								element.signalEntityId = this.defaultContactEntitySchemaId;
								element.entitySchemaUId = contactSchema.uId;
						}
						const formSubmitSchema = Terrasoft.EntitySchemaManager.findItemByName(this.defaultFormSubmitEntitySchemaName);
						if (formSubmitSchema != null) {
							element.signalEntityId = this.defaultFormSubmitEntitySchemaId;
							element.entitySchemaUId = formSubmitSchema.uId;
						}
					}
					if (element.signalEntityId === this.defaultFormSubmitEntitySchemaId) {
						element.entitySignal = Terrasoft.EntityChangeType.Updated;
					} else {
						element.entitySignal = Terrasoft.EntityChangeType.Inserted;
					}
					this.callParent(arguments);
				},
				/**
				 * @inheritdoc Terrasoft.CampaignStartSignalPage#prepareSignalESQ
				 * @override
				 */
				prepareSignalESQ: function() {
					var esq = this.callParent(arguments);
					esq.addColumn("WebPageURLColumn");
					esq.addColumn("ContactColumn");
					return esq;
				},
				/**
				 * @inheritdoc Terrasoft.CampaignStartSignalPage#extendSignalEntityInfo
				 * @override
				 */
				extendSignalEntityInfo: function(entity) {
					return {
						webPageURLColumn: entity.get("WebPageURLColumn"),
						contactColumn: entity.get("ContactColumn")
					}
				},
				/**
				 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#getClearAttributesOnEntitySchemaSelectChanged
				 * @override
				 */
				getClearAttributesOnEntitySchemaSelectChanged: function () {
					return [
						"FilterEditData",
						"EntityFilters"
					];
				},
				/**
				 * @inheritdoc CampaignStartSignalPage#onElementDataLoad
				 * @override
				 */
				onElementDataLoad: function(element, callback, scope) {
					var parentMethod = this.getParentMethod();
					this.initSignalEntityList(function() {
						parentMethod.call(this, element, function() {
							callback.call(scope);
							if (this.$IsReadOnly) {
								this.setControlsReadOnly(this.$IsReadOnly, this.editorsContainerId);
							}
						}, this);
					}, this);
				},
				/**
				 * @inheritdoc CampaignStartSignalPage#onEntitySchemaSelectChanged
				 * @override
				 */
				onEntitySchemaSelectChanged: function() {
					this.callParent(arguments);
					this.clearAttributes(["WebPageURL"]);
					this.initValuesFromEntitySchemaSelect(true);
				},
				/**
				 * @inheritdoc CampaignStartSignalPage#initValuesFromEntitySchemaSelect
				 * @override
				 */
				initValuesFromEntitySchemaSelect: function (isSchemaChanged) {
					this.validAttributes(["WebPageURL"]);
					var entity = this.get("EntitySchemaSelect");
					if (!entity) {
						this.set("WebPageURLColumn", "");
						return;
					}
					// TODO allow to change column from right panel
					if (!this.$WebPageURLColumn || isSchemaChanged) {
						this.set("WebPageURLColumn", entity.webPageURLColumn);
					}
					var signalEntityId = Ext.isObject(entity) ? entity.value : entity;
					var signalMode = signalEntityId === this.defaultFormSubmitEntitySchemaId 
						? Terrasoft.EntityChangeType.Updated
						: Terrasoft.EntityChangeType.Inserted;
					this.setEntityChangeType(signalMode);
					Terrasoft.EntitySchemaManager.getInstanceByUId(entity.schemaUId, function(schema) {
						this.getEntitySchemaByName(schema.name, function(currentSchema) {
							this.$CurrentWebPageColumnCaption = currentSchema.getColumnByName(entity.webPageURLColumn)?.caption
								|| this.get("Resources.Strings.WebPageURLLabelCaption");
							if (signalMode === Terrasoft.EntityChangeType.Updated) {
								var columnNames = [entity.webPageURLColumn, entity.contactColumn.replace(/\.Id$/, "")];
								var changedColumns = columnNames.map((columnName) =>
									currentSchema.getColumnByName(columnName)?.uId
								).filter((uId) => !!uId);
								this.$NewEntityChangedColumns = changedColumns;
							} else { 
								this.clearEntitySchemaColumns();
								this.$NewEntityChangedColumns = [];
							}
						}, this);
					}, this);
				},
				/**
				 * @inheritdoc CampaignStartSignalPage#saveEntityColumns
				 * @override
				 */
				saveEntityColumns: function(element) {
					var changedColumns = this.$NewEntityChangedColumns;
					element.newEntityChangedColumns = changedColumns;
					var anySelectedField = Terrasoft.process.constants.SignalExpectChanges.AnySelectedField;
					var anyField = Terrasoft.process.constants.SignalExpectChanges.AnyField;
					var expectChanges = changedColumns && changedColumns.length > 0 ? anySelectedField : anyField;
					var expectChangesList = this.getExpectChangesList();
					this.$ExpectChanges = expectChangesList[expectChanges];
					element.hasEntityColumnChange = expectChanges === anySelectedField;
				},
				/**
				 * Prepare link for open entity settings lookup
				 * @protected
				 */
				getLookupLinkWebPageURLColumnHref: function () {
					return `ViewModule.aspx#LookupSectionModule/BaseLookupConfigurationSection/CampaignSignalEntity`
				}
            },
            diff: [
				{
					"operation": "remove",
					"name": "ObjectSignalPropertiesControlGroup"
				},
				{
					"operation": "remove",
					"name": "ObjectSignalFiltersControlGroup"
				},
				{
					"operation": "merge",
					"name": "EntityTextLabel",
					"values": {
						"classes": {
							"labelClass": ["label-small"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "WebPageURLContainer",
					"parentName": "MainControlContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"wrapClass": ["placeholderOpacity"],
					},
					"index": 1
				},
				{
					"operation": "insert",
					"name": "WebPageURLLayout",
					"propertyName": "items",
					"parentName": "WebPageURLContainer",
					"className": "Terrasoft.GridLayoutEdit",
					"values": {
						"visible": {
							"bindTo": "WebPageURLColumn",
							"bindConfig": {"converter": "isNotEmptyValue"}
						},
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "WebPageURLLabel",
					"parentName": "WebPageURLLayout",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": "$CurrentWebPageColumnCaption",
						"classes": {
							"labelClass": ["label-small"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "WebPageURL",
					"parentName": "WebPageURLLayout",
					"propertyName": "items",
					"values": {
						"labelConfig": {
							"visible": false
						},
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 23
						},
						"itemType": this.Terrasoft.ViewItemType.TEXT,
						"classes": {
							"wrapClassName": ["placeholderOpacity"],
						},
						"classes": {
							"labelClass": ["label-small"]
						},
						"placeholder": "$Resources.Strings.WebPageURLPlaceholder",
						"markerValue": "WebPageUrl",
						"controlConfig": {"tag": "WebPageURL"}
					}
				},
				{
					"operation": "insert",
					"parentName": "WebPageURLLayout",
					"propertyName": "items",
					"name": "WebPageURLHint",
					"values": {
						"layout": {"column": 23, "row": 1, "colSpan": 1},
						"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
						"content": "$Resources.Strings.WebPageURLHint",
					}
				},
				{
					"operation": "insert",
					"name": "SettingsLookupLinkLayout",
					"propertyName": "items",
					"parentName": "WebPageURLContainer",
					"className": "Terrasoft.GridLayoutEdit",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "LookupLinkWebPageURLColumnLabel",
					"parentName": "SettingsLookupLinkLayout",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.HYPERLINK,
						"caption": "$CurrentWebPageColumnCaption",
						"markerValue": "LookupLinkWebPageURLColumnLabel",
						"target": this.Terrasoft.controls.HyperlinkEnums.target.BLANK,
						"tpl": resources.localizableStrings.CampaignSignalEntityLookupLinkTemplate,
						"href": "$getLookupLinkWebPageURLColumnHref",
						"visible": {
							"bindTo": "WebPageURLColumn",
							"bindConfig": {"converter": "isNotEmptyValue"}
						},
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						},
					}
				},
				{
					"operation": "insert",
					"name": "LookupLinkEmptyWebPageURLColumnLabel",
					"parentName": "SettingsLookupLinkLayout",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.HYPERLINK,
						"markerValue": "LookupLinkEmptyWebPageURLColumnLabel",
						"visible": {
							"bindTo": "WebPageURLColumn",
							"bindConfig": {"converter": "isEmptyValue"}
						},
						"target": this.Terrasoft.controls.HyperlinkEnums.target.BLANK,
						"tpl": resources.localizableStrings.EmptyPathCampaignSignalEntityLookupLinkTemplate,
						"href": "$getLookupLinkWebPageURLColumnHref",
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						},
					}
				},
				
            ]
        };
    }
);