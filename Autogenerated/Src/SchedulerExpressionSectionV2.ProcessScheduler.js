define("SchedulerExpressionSectionV2", ["ConfigurationEnums"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "SchedulerExpression",
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#addSectionDesignerViewOptions
				 * @overridden
				 */
				addSectionDesignerViewOptions: this.Terrasoft.emptyFn,

				/**
				 * ######## ###### #### ###### "######### #######".
				 * @inheritdoc ProcessEntryPointUtilities#initRunProcessButtonMenu
				 * @overridden
				 */
				initRunProcessButtonMenu: this.Terrasoft.emptyFn,

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
					var eventName = (historyState.workAreaMode === ConfigurationEnums.WorkAreaMode.COMBINED)
						? "ReplaceHistoryState"
						: "PushHistoryState";
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
				 * @inheritDoc Terrasoft.GridUtilities#onGridLoaded
				 * @overridden
				 */
				onGridLoaded: function() {
					this.reloadGridColumnsConfig(false);
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
					if (this.entitySchema) {
						var headerTemplate = this.get("Resources.Strings.HeaderCaptionTemplate");
						return Ext.String.format(headerTemplate, this.entitySchema.caption);
					}
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
				 * @inheritdoc Terrasoft.BaseSectionV2#getProfileKey
				 * @overridden
				 */
				getProfileKey: function() {
					var currentTabName = this.getActiveViewName();
					var schemaName = this.name;
					return schemaName + this.entitySchemaName + "GridSettings" + currentTabName;
				},

				/**
				 * ########## ####### ## ########### #########.
				 * @protected
				 * @virtual
				 */
				closeSection: function() {
					this.sandbox.publish("PushHistoryState", {
						hash: this.Terrasoft.combinePath("SectionModuleV2", "LookupSection")
					});
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "SeparateModeBackButton",
					"parentName": "SeparateModeActionButtonsLeftContainer",
					"propertyName": "items",
					"index": 2,
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": {"bindTo": "Resources.Strings.BackButtonCaption"},
						"click": {"bindTo": "closeSection"},
						"classes": {
							"textClass": ["actions-button-margin-right"],
							"wrapperClass": ["actions-button-margin-right"]
						},
						"visible": {"bindTo": "SeparateModeActionsButtonVisible"}
					}
				},
				{
					"operation": "remove",
					"name": "CombinedModeActionsButton"
				}
			]/**SCHEMA_DIFF*/
		};
	});
