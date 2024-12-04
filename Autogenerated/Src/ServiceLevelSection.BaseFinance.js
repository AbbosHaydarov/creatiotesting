define("ServiceLevelSection", ["ConfigurationEnums", "ServiceLevelSectionResources",
		"GridUtilitiesV2", "ServiceLevelSectionGridRowViewModel", "css!ServiceLevelCSS"
	],
	function(configurationEnums, resources) {
		return {
			entitySchemaName: "ServiceLevel",
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"name": "DataGridContainer",
				"parentName": "GridDataView",
				"propertyName": "items",
				"values": {
					"wrapClass": ["service-level-grid-dataview-container-wrapClass", "grid-dataview-container-wrapClass"]
				}
			}, {
				"operation": "merge",
				"name": "SeparateModeAddRecordButton",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.AddButtonCaption"
					}
				}
			}, {
				"operation": "remove",
				"name": "CombinedModeAddRecordButton"
			}, {
				"operation": "insert",
				"name": "SeparateModeBackButton",
				"parentName": "SeparateModeActionButtonsLeftContainer",
				"propertyName": "items",
				"index": 2,
				"values": {
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.BackButtonCaption"
					},
					"click": {
						"bindTo": "closeSection"
					},
					"classes": {
						"textClass": ["actions-button-margin-right"],
						"wrapperClass": ["actions-button-margin-right"]
					},
					"visible": {
						"bindTo": "SeparateModeActionsButtonVisible"
					}
				}
			}] /**SCHEMA_DIFF*/ ,
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#addSectionDesignerViewOptions
				 * @overridden
				 */
				addSectionDesignerViewOptions: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#addSectionHistoryState
				 * @overridden
				 */
				addSectionHistoryState: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#removeSectionHistoryState
				 * @overridden
				 */
				removeSectionHistoryState: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc ProcessEntryPointUtilities#initRunProcessButtonMenu
				 * @overridden
				 */
				initRunProcessButtonMenu: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#addCardHistoryState
				 * @overridden
				 */
				addCardHistoryState: function(schemaName, operation, primaryColumnValue) {
					if (!schemaName) {
						return;
					}
					var cardOperationConfig = {
						schemaName: schemaName,
						operation: operation,
						primaryColumnValue: primaryColumnValue
					};
					var historyState = this.getHistoryStateInfo();
					var stateConfig = this.getCardHistoryStateConfig(cardOperationConfig);
					var isCombined = (historyState.workAreaMode === configurationEnums.WorkAreaMode.COMBINED);
					var eventName = isCombined ? "ReplaceHistoryState" : "PushHistoryState";
					this.sandbox.publish(eventName, stateConfig);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#removeCardHistoryState
				 * @overridden
				 */
				removeCardHistoryState: function() {
					var module = "LookupSectionModule";
					var schema = this.name;
					var historyState = this.sandbox.publish("GetHistoryState");
					var currentState = historyState.state;
					var newState = {
						moduleId: currentState.moduleId
					};
					var hash = [module, schema].join("/");
					this.sandbox.publish("PushHistoryState", {
						hash: hash,
						stateObj: newState,
						silent: true
					});
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#isMultiSelectVisible
				 * @overridden
				 */
				isMultiSelectVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#isSingleSelectVisible
				 * @overridden
				 */
				isSingleSelectVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#isUnSelectVisible
				 * @overridden
				 */
				isUnSelectVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getGridRowViewModelClassName
				 * @overridden
				 */
				getGridRowViewModelClassName: function() {
					return "Terrasoft.ServiceLevelSectionGridRowViewModel";
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getProfileKey
				 * @overridden
				 */
				getProfileKey: function() {
					var currentTabName = this.getActiveViewName();
					var schemaName = this.name;
					return schemaName + this.entitySchemaName + "GridSettings" + currentTabName;
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
				 * Rolls back the chain to its previous state.
				 * @protected
				 * @virtual
				 */
				closeSection: function() {
					var module = "LookupSection";
					this.sandbox.publish("PushHistoryState", {
						hash: this.Terrasoft.combinePath("SectionModuleV2", module)
					});
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getModuleCaption
				 * @overridden
				 */
				getModuleCaption: function() {
					return resources.localizableStrings.HeaderCaption;
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilities#actualizeTiledGridConfig
				 * @overridden
				 */
				actualizeTiledGridConfig: function(viewGenerator, gridConfig) {
					this.callParent([viewGenerator, gridConfig]);
					this.modifyConfig(gridConfig);
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilities#onGridLoaded
				 * @overridden
				 */
				onGridLoaded: function() {
					this.reloadGridColumnsConfig(false);
				},

				/**
				 * Adds a tiled configuration registry with the image of a string.
				 * @protected
				 * @param {Object} gridConfig Tiled list config.
				 */
				modifyConfig: function(gridConfig) {
					var item = gridConfig.isVertical ? this.getImageConfigForTiledVerticalGrid() : this.getImageConfigForTiledGrid();
					var columnsConfig = gridConfig.tiledConfig.columnsConfig;
					this.Ext.Array.insert(columnsConfig, 0, [item]);
				},

				/**
				 * Returns vertical list image config.
				 * @protected
				 * @return {*[]} config.
				 */
				getImageConfigForTiledVerticalGrid: function() {
					return [
						[{
							"cols": 24,
							"key": [{
								"name": {
									"bindTo": "Image"
								},
								"type": "grid-icon-128x64"
							}]
						}]
					];
				},

				/**
				 * Returns tiled list image config.
				 * @protected
				 * @return {Object} config.
				 */
				getImageConfigForTiledGrid: function() {
					return {
						"cols": 24,
						"key": [{
							"name": {
								"bindTo": "Image"
							},
							"type": "grid-icon-128x128"
						}]
					};
				}
			}
		};
	});
