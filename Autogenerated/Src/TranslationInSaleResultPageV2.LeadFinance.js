define("TranslationInSaleResultPageV2", ["BaseFiltersGenerateModule", "CustomProcessPageV2Utilities"],
	function(baseFiltersGenerateModule) {
		return {
			entitySchemaName: "Lead",
			messages: {
				/**
				 * @message LeadTypeChanged
				 * Tells about lead type change.
				 */
				"LeadTypeChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message DetailLoaded
				 * Tells about loading detail.
				 */
				"DetailLoaded": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			details: /**SCHEMA_DETAILS*/ {
				"LeadProduct": {
					"schemaName": "LeadProductDetailV2",
					"entitySchemaName": "LeadProduct",
					"filter": {
						"masterColumn": "LeadId",
						"detailColumn": "Lead"
					},
					"defaultValues": {
						"LeadType": {
							"masterColumn": "LeadType"
						}
					}
				},
				"SpecificationInLead": {
					"schemaName": "LeadEditableSpecificationDetailV2",
					"entitySchemaName": "SpecificationInLead",
					"filter": {
						"masterColumn": "LeadId",
						"detailColumn": "Lead"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			mixins: {
				BaseProcessViewModel: "Terrasoft.CustomProcessPageV2Utilities"
			},
			attributes: {
				"Id": {
					"dataValueType": this.Terrasoft.DataValueType.GUID,
					"value": this.Terrasoft.generateGUID()
				},
				"LeadId": {
					"dataValueType": this.Terrasoft.DataValueType.GUID
				},
				"LeadType": {
					"dataValueType": this.Terrasoft.DataValueType.ENUM,
					"caption": {
						"bindTo": "Resources.Strings.LeadTypeCaption"
					},
					"referenceSchemaName": "LeadType",
					"isLookup": true
				},
				"OpportunityResponsible": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"caption": {
						"bindTo": "Resources.Strings.OpportunityResponsibleCaption"
					},
					"referenceSchemaName": "Contact",
					"isLookup": true,
					"lookupListConfig": {
						"filter": baseFiltersGenerateModule.OwnerFilter
					}
				},
				"OpportunityDepartment": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"caption": {
						"bindTo": "Resources.Strings.OpportunityDepartmentCaption"
					},
					"referenceSchemaName": "OpportunityDepartment",
					"isLookup": true
				},
				"MeetingTime": {
					"dataValueType": this.Terrasoft.DataValueType.DATE_TIME,
					"caption": {
						"bindTo": "Resources.Strings.MeetingTimeCaption"
					}
				},
				"DecisionDate": {
					"dataValueType": this.Terrasoft.DataValueType.DATE,
					"caption": {
						"bindTo": "Resources.Strings.DecisionDateCaption"
					}
				},
				"Comment": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"caption": {
						"bindTo": "Resources.Strings.CommentCaption"
					}
				}
			},
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initHeaderCaption
				 * @overridden
				 */
				initHeaderCaption: this.Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initPrintButtonMenu
				 * @overridden
				 */
				initPrintButtonMenu: this.Ext.emptyFn,

				/**
				 * @inheritdoc ProcessEntryPointUtilities#initRunProcessButtonMenu
				 * @overridden
				 */
				initRunProcessButtonMenu: this.Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initActionButtonMenu
				 * @overridden
				 */
				initActionButtonMenu: this.Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initViewOptionsButtonMenu
				 * @overridden
				 */
				initViewOptionsButtonMenu: this.Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseEntityPage#saveEntityInChain
				 * @overridden
				 */
				saveEntityInChain: function(callback, scope) {
					this.Ext.callback(callback, scope);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overridden
				 */
				onSaved: function() {
					this.hideBodyMask();
					this.acceptProcessElement();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#updateButtonsVisibility
				 * @overridden
				 */
				updateButtonsVisibility: function() {
					this.set("ShowCloseButton", true);
					this.set("ShowSaveButton", true);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onCloseCardButtonClick
				 * @overridden
				 */
				onCloseCardButtonClick: function() {
					this.sandbox.publish("BackHistoryState");
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getHeader
				 * @overridden
				 */
				getHeader: function() {
					return this.get("Resources.Strings.PageCaption");
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getPageHeaderCaption
				 * @overridden
				 */
				getPageHeaderCaption: function() {
					return this.getHeader();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initEntity
				 * @overridden
				 */
				initEntity: function(callback, scope) {
					this.initData();
					this.callParent([function() {
						this.loadLookupDisplayValues(callback, scope || this);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#subscribeDetailsEvents
				 * @overridden
				 */
				subscribeDetailsEvents: function() {
					this.callParent(arguments);
					var detailId = this.getSpecificationInLeadDetailId();
					this.sandbox.subscribe("DetailLoaded", this.initLeadTypeSpecification, this, [detailId]);
				},

				/**
				 * Asynchronously loads lookup display values.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {[type]} scope Callback function scope.
				 */
				loadLookupDisplayValues: function(callback, scope) {
					var loadChain = [];
					this.Terrasoft.each(this.columns, function(column) {
						if (!column.isLookup) {
							return true;
						}
						var name = column.name;
						var value = this.get(name);
						if (this.Terrasoft.isGUID(value)) {
							loadChain.push(function(next) {
								this.loadLookupDisplayValue(name, value, next, this);
							});
						}
					}, this);
					loadChain.push(function() {
						this.Ext.callback(callback, scope);
					});
					this.Terrasoft.chain.apply(this, loadChain);
				},

				/**
				 * Initializes page data.
				 * @protected
				 */
				initData: function() {
					this.set("Operation", null);
					this.set("PrimaryColumnValue", this.get("LeadId"));
				},

				/**
				 * Initializes lead specifications.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {[type]} scope Callback function scope.
				 */
				initLeadTypeSpecification: function(callback, scope) {
					var leadId = this.get("LeadId");
					var leadTypeId = this.get("LeadType");
					leadId = this.Ext.isObject(leadId) ? leadId.value : leadId;
					leadTypeId = this.Ext.isObject(leadTypeId) ? leadTypeId.value : leadTypeId;
					if (!this.Terrasoft.isGUID(leadId) || !this.Terrasoft.isGUID(leadTypeId)) {
						this.Ext.callback(callback, scope);
						return;
					}
					this.getLeadSpecificationCount(leadId, function(result) {
						this.getLeadSpecificationCountCallback(result, callback, scope);
					}, this);
				},

				/**
				 * Returns lead specification count.
				 * @protected
				 * @param {[type]} leadId Lead identifier.
				 * @param {Function} callback Callback function.
				 * @param {[type]} scope Callback function scope.
				 */
				getLeadSpecificationCount: function(leadId, callback, scope) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SpecificationInLead"
					});
					esq.addAggregationSchemaColumn("Id", this.Terrasoft.AggregationType.COUNT, "Count");
					esq.filters.add("LeadFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Lead", leadId));
					esq.getEntityCollection(callback, scope);
				},

				/**
				 * Works after loading lead specification count.
				 * @protected
				 * @param {Object} result Request result.
				 * @param {Function} callback Callback function.
				 * @param {[type]} scope Callback function scope.
				 */
				getLeadSpecificationCountCallback: function(result, callback, scope) {
					if (result.success && result.collection.getCount() > 0) {
						var entity = result.collection.getByIndex(0);
						var count = entity.get("Count");
						if (count === 0) {
							this.loadDefaultLeadSpecifications();
						}
					}
					this.Ext.callback(callback, scope);
				},

				/**
				 * Loads default lead specifications.
				 * @protected
				 */
				loadDefaultLeadSpecifications: function() {
					var leadTypeChangedInfo = {
						leadType: this.get("LeadType"),
						isClearParams: true
					};
					var detailId = this.getSpecificationInLeadDetailId();
					this.sandbox.publish("LeadTypeChanged", leadTypeChangedInfo, [detailId]);
				},

				/**
				 * Returns specification in lead detail id.
				 * @protected
				 * @return {String} Detaild id.
				 */
				getSpecificationInLeadDetailId: function() {
					return this.getDetailId("SpecificationInLead");
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"name": "actions",
				"values": {
					"visible": false
				}
			}, {
				"operation": "merge",
				"name": "DelayExecutionButton",
				"values": {
					"visible": false
				}
			}, {
				"operation": "merge",
				"name": "DiscardChangesButton",
				"values": {
					"visible": false
				}
			}, {
				"operation": "merge",
				"name": "ViewOptionsButton",
				"values": {
					"visible": false
				}
			}, {
				"operation": "merge",
				"name": "DiscardChangesButton",
				"values": {
					"visible": false
				}
			}, {
				"operation": "merge",
				"name": "CloseButton",
				"values": {
					"visible": true
				}
			}, {
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"visible": true
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "LeadType",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "OpportunityResponsible",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "OpportunityDepartment",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "MeetingTime",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "DecisionDate",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 6,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Comment",
				"values": {
					"contentType": this.Terrasoft.ContentType.LONG_TEXT,
					"layout": {
						"column": 0,
						"row": 5,
						"colSpan": 12,
						"rowSpan": 1
					}
				}
			}, {
				"operation": "insert",
				"name": "DetailsContainer",
				"parentName": "HeaderContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "DetailsContainer",
				"propertyName": "items",
				"name": "SpecificationInLead",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"index": 0
			}, {
				"operation": "insert",
				"parentName": "DetailsContainer",
				"propertyName": "items",
				"name": "LeadProduct",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"index": 1
			}] /**SCHEMA_DIFF*/
		};
	});
