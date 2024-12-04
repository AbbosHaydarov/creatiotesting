/**
 * Schema of campaign web page element page
 * Parent: EntityCampaignSchemaElementPage
 */
define("CampaignWebPagePropertiesPage", ["CampaignWebPagePropertiesPageResources", "BaseFiltersGenerateModule",
		"LookupUtilities", "MarketingEnums"],
	function(resources) {
		return {
			properties: {
				entityDisplayColumnName: "Caption",
				formSubmitTargetEntityId: "aafd9a22-102c-4c2d-9f0c-086cb3e75dc1",
				formSubmitEntitySchemaName: "FormSubmit",
				defaultContactTargetEntityId: "5b229e55-8ebf-414a-8dee-26e2b059025b"
			},
			attributes: {

				/**
				 * Web page URL.
				 * @type {Terrasoft.dataValueType.TEXT}
				 */
				"WebPageUrl": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isRequired": true
				},
				/**
				 * Web page URL path for filters.
				 * @type {Terrasoft.dataValueType.TEXT}
				 */
				"WebPageUrlColumn": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isRequired": true
				},
				/**
				 * Web page URL column caption
				 * @type {Terrasoft.dataValueType.TEXT}
				 */
				"CurrentWebPageColumnCaption": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#getColumnsForEntitySelect
				 * @overridden
				 */
				getColumnsForEntitySelect: function() {
					return ["Id", "Caption", "WebPageURLColumn"];
				},

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#getEntityRecordIdFromElement
				 * @overridden
				 */
				getEntityRecordIdFromElement: function(element) {
					return element.webPageTargetEntityId;
				},

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#setRecordIdToElement
				 * @overridden
				 */
				setRecordIdToElement: function(element, recordId) {
					element.webPageTargetEntityId = recordId;
				},

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#getEntityLookupCaption
				 * @overridden
				 */
				getEntityLookupCaption: function() {
					return this.get("Resources.Strings.CampaignWebPageText");
				},

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#getEntitySchemaName
				 * @overridden
				 */
				getEntitySchemaName: function() {
					return "CampaignSignalEntity";
				},

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#setPageParameters
				 * @overridden
				 */
				setPageParameters: function(eventEntity) {
					this.callParent(arguments);
					this.set("WebPageUrlColumn", eventEntity.get("WebPageURLColumn"));
				},

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#clearPageParameters
				 * @overridden
				 */
				clearPageParameters: function() {
					this.callParent(arguments);
					this.set("WebPageUrl", "");
					this.set("WebPageUrlColumn", null);
				},

				/**
				 * Returns current web page url value for the element.
				 * @protected
				 * @param {ProcessElement} element Current schema element.
				 * @returns {string} Url value.
				 */
				readWebPageUrlValue: function(element) {
					return element.webPageUrl;
				},

				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#initPageAsync
				 * @override
				 */
				initPageAsync: function(element, callback, scope) {
					this.set("WebPageUrl", this.readWebPageUrlValue(element));
					if (!element.webPageTargetEntityId) {
						const isFormSubmitAvailable =
							Terrasoft.EntitySchemaManager.findItemByName(this.formSubmitEntitySchemaName);
						element.webPageTargetEntityId = isFormSubmitAvailable
							? this.formSubmitTargetEntityId
							: this.defaultContactTargetEntityId;
					}
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#getContextHelpCode
				 * @override
				 */
				getContextHelpCode: function() {
					return "CampaignWebPageElement";
				},

				/**
				 * Prepare link for open entity settings lookup
				 * @protected
				 */
				getLookupLinkWebPageURLColumnHref: function () {
					return `ViewModule.aspx#LookupSectionModule/BaseLookupConfigurationSection/CampaignSignalEntity`
				},

				hasWebPageUrlPath: function() {
					return Boolean(this.isEntitySelected() && this.get("WebPageUrlColumn"));
				},

				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#saveValues
				 * @override
				 */
				saveValues: function() {
					this.callParent(arguments);
					var element = this.$ProcessElement;
					element.webPageUrlColumn = this.$WebPageUrlColumn;
					element.webPageUrl = this.$WebPageUrl;
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "EntityRecord",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "EntityRecord",
						"dataValueType": this.Terrasoft.DataValueType.ENUM,
						"isRequired": true,
						"controlConfig": {
							"className": "Terrasoft.ComboBoxEdit",
							"change": {
								"bindTo": "onEntityLookupChanged"
							},
							"list": "$RecordCollection",
							"prepareList": "$prepareEntityList"
						},
						"wrapClass": ["no-caption-control"],
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"enabled": "$IsEntityLoaded"
					}
				},
				{
					"operation": "insert",
					"name": "WebPageUrlLabel",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.WebPageUrlTitle",
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"visible": "$hasWebPageUrlPath"
					}
				},
				{
					"operation": "insert",
					"name": "WebPageUrl",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"labelConfig": {
							"visible": false
						},
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 22
						},
						"itemType": this.Terrasoft.ViewItemType.TEXT,
						"classes": {
							"wrapClassName": ["placeholderOpacity"],
						},
						"classes": {
							"labelClass": ["label-small"]
						},
						"visible": "$hasWebPageUrlPath",
						"placeholder": "$Resources.Strings.WebPageURLPlaceholder",
						"controlConfig": {"tag": "WebPageURL"}
					}
				},
				{
					"operation": "insert",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"name": "WebPageURLHint",
					"values": {
						"layout": {"column": 22, "row": 3, "colSpan": 1},
						"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
						"content": "$Resources.Strings.WebPageURLHint",
						"controlConfig": {
							"visible": "$hasWebPageUrlPath"
						}
					}
				},
				{
					"operation": "insert",
					"name": "LookupLinkWebPageURLColumnLabel",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.HYPERLINK,
						"caption": "$CurrentWebPageColumnCaption",
						"markerValue": "LookupLinkWebPageURLColumnLabel",
						"target": this.Terrasoft.controls.HyperlinkEnums.target.BLANK,
						"tpl": resources.localizableStrings.CampaignSignalEntityLookupLinkTemplate,
						"href": "$getLookupLinkWebPageURLColumnHref",
						"visible": {
							"bindTo": "WebPageUrlColumn",
							"bindConfig": {"converter": "isNotEmptyValue"}
						},
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						},
					}
				},
				{
					"operation": "insert",
					"name": "LookupLinkEmptyWebPageURLColumnLabel",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.HYPERLINK,
						"markerValue": "LookupLinkEmptyWebPageURLColumnLabel",
						"visible": {
							"bindTo": "WebPageUrlColumn",
							"bindConfig": {"converter": "isEmptyValue"}
						},
						"target": this.Terrasoft.controls.HyperlinkEnums.target.BLANK,
						"tpl": resources.localizableStrings.EmptyPathCampaignSignalEntityLookupLinkTemplate,
						"href": "$getLookupLinkWebPageURLColumnHref",
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
