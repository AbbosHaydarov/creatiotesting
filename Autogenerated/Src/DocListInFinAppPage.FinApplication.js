define("DocListInFinAppPage", ["FinApplication", "Contract"],
	function(FinApplication, Contract) {
		return {
			entitySchemaName: "DocListInFinApp",
			details: /**SCHEMA_DETAILS*/ {
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "DocListInFinAppFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "DocListInFinApp"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			attributes: {
				"SysModuleReport": {
					"lookupListConfig": {
						"columns": ["SysModule", "SysModule.SysModuleEntity",
							"SysModule.SysModuleEntity.SysEntitySchemaUId"]
					}
				},
				"FinApplication": {
					"lookupListConfig": {
						"columns": ["Contract"]
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Document",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
						"value": {"bindTo": "Document"},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "DocumentListStage",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": this.Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "DocumentListStage"},
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "ParticipantRole",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": this.Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "ParticipantRole"},
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "DocumentType",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": this.Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "DocumentType"},
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "DocListGroup",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": this.Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "DocListGroup"},
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "DocumentLink",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 10
						},
						"value": {"bindTo": "DocumentLink"},
					}
				},
				{
					"operation": "insert",
					"name": "IsRequired",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "remove",
					"name": "actions"
				},
				{
					"operation": "insert",
					"name": "NotesTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.NotesTabCaption"
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "NotesTab",
					"propertyName": "items",
					"name": "Files",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"name": "NotesControlGroup",
					"parentName": "NotesTab",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.NotesGroupCaption"
						},
						"controlConfig": {
							"collapsed": false
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "NotesControlGroup",
					"propertyName": "items",
					"name": "Notes",
					"values": {
						"contentType": this.Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"controlConfig": {
							"imageLoaded": {
								"bindTo": "insertImagesToNotes"
							},
							"images": {
								"bindTo": "NotesImagesCollection"
							}
						}
					}
				},
				{
					"operation": "merge",
					"name": "PrintButton",
					"values": {
						"click": {"bindTo": "generateCardPrintForm"},
						"controlConfig": {}
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {

				//region Methods: Private

				/**
				 * Sets values necessary for report print.
				 * @private
				 */
				initPrintFormValues: function() {
					var report = this.get("SysModuleReport");
					var reportModuleEntityId;
					if (report && report["SysModule.SysModuleEntity.SysEntitySchemaUId"]) {
						reportModuleEntityId = report["SysModule.SysModuleEntity.SysEntitySchemaUId"];
					}
					var reportEntityId = this.getMatchedEntity(reportModuleEntityId);
					this.set("ReportModuleEntityId", reportModuleEntityId);
					if (reportEntityId && reportEntityId.value) {
						this.set("ReportPrimaryColumnValue", reportEntityId.value);
					}
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.PrintReportUtilities#initCardPrintFormsEsqFilters
				 * @overridden
				 */
				initCardPrintFormsEsqFilters: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.PrintReportUtilities#initCardPrintForms
				 * @overridden
				 */
				initCardPrintForms: function(callback, scope) {
					var sysModuleReport = this.get("SysModuleReport") || {};
					if (this.Ext.isEmpty(sysModuleReport.value)) {
						this.Ext.callback(callback, scope);
						return;
					}
					this.initPrintFormValues();
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.PrintReportUtilities#getEntitySchemaUId
				 * @overridden
				 */
				getEntitySchemaUId: function() {
					return this.get("ReportModuleEntityId");
				},

				/**
				 * @inheritdoc Terrasoft.PrintReportUtilities#getPrintRecordId
				 * @overridden
				 */
				getPrintRecordId: function() {
					return this.get("ReportPrimaryColumnValue");
				},

				/**
				 * @inheritdoc Terrasoft.PrintReportUtilities#getESQCacheName
				 * @overridden
				 */
				getESQCacheName: this.Terrasoft.emptyFn,

				/**
				 * Returns entity primary column value by SysEntitySchemaUId.
				 * @param {String} sysEntitySchemaUId EntitySchemaUId defined in SysModuleReport.
				 * @return {String} Matched Entity UId.
				 * @protected
				 */
				getMatchedEntity: function(sysEntitySchemaUId) {
					var matchedEntity;
					var finApp = this.get("FinApplication") || {};
					switch (sysEntitySchemaUId) {
						case FinApplication.uId:
							matchedEntity = this.Terrasoft.isEmptyObject(finApp) ? null : finApp;
							break;
						case Contract.uId:
							matchedEntity = finApp.Contract;
							break;
						default:
							break;
					}
					return matchedEntity;
				},

				/**
				 * @inheritdoc Terrasoft.PrintReportUtilities#generateCardPrintForm
				 * @overridden
				 */
				generateCardPrintForm: function() {
					if (this.get("ReportPrimaryColumnValue")) {
						var cardPrintFormsCollection = this.get(this.moduleCardPrintFormsCollectionName);
						if (!this.Ext.isEmpty(cardPrintFormsCollection) && !cardPrintFormsCollection.isEmpty()) {
							var printForm = cardPrintFormsCollection.getByIndex(0);
							this.generatePrintForm(printForm);
						}
					} else {
						this.showInformationDialog(this.get("Resources.Strings.RequiredColumnsNotFilled"));
					}
				},

				/**
				 * @inheritdoc Terrasoft.PrintReportUtilities#getModulePrintFormsESQ
				 * @overridden
				 */
				getModulePrintFormsESQ: function() {
					var sysModuleReport = this.get("SysModuleReport");
					var esq = this.callParent(arguments);
					esq.filters.clear();
					esq.filters.add(this.Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Id", sysModuleReport.value));
					return esq;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.initCardPrintForms();
				}

				//endregion

			}
		};
	});
