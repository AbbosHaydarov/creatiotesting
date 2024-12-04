define("ProductSelectionProcessPage", ["BankProductSelectionProcessPageComponent", "ProductSelectionSchemaMixin"], function() {
	return {
		entitySchemaName: "",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		messages: {
			"NeedHeaderCaption": {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},
			"UpdatePageHeaderCaption": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		mixins: {
			productSelectionMixin: "Terrasoft.ProductSelectionSchemaMixin"
		},
		methods: {

			// region Methods: Private

			_publishSetProcessExecutionDataEvent: function() {
				const customEvent = this.getCustomEvent();
				customEvent.publish("SetProcessExecutionData", true);
			},

			// endregion

			// region Methods: Protected

			/**
			 * Skip event buttom handler.
			 */
			onSkipClick: function() {
				this.completeExecution("Skip");
			},

			/**
			 * Set parameters.
			 * @param {Object} processData Data.
			 */
			setParameters: function(processData) {
				Object.keys(processData).map(key => {
					this.set(key, processData[key]);
				});
			},

			/**
			 * Set process execution data.
			 * @param {Object} processData Data.
			 */
			setProcessExecutionData: function(processData) {
				this.setParameters(processData);
				this._publishSetProcessExecutionDataEvent();
				this.completeProcessElementWithVerification("Application");
			},

			/**
			 * Initializes process page events
			 */
			initProcessPageEvents: function() {
				const customEvent = this.getCustomEvent();
				customEvent.subscribeHandler("Close", this.onCloseClick, this);
				customEvent.subscribeHandler("Skip", this.onSkipClick, this);
				customEvent.subscribeHandler("SetProcessExecutionData", this.setProcessExecutionData, this);
			},

			/**
			 * Returns web component translations.
			 * @returns Translations.
			 */
			getProductSelectionTranslation: function() {
				const productSelectionTranslation = this.mixins.productSelectionMixin.getProductSelectionTranslation.call(this);
				productSelectionTranslation.BankProductSelectionProcessPageComponent = {
					"Close": this.get("Resources.Strings.CloseButtonCaption"),
					"Skip": this.get("Resources.Strings.SkipButtonCaption")
				};
				return productSelectionTranslation;
			},

			/**
			 * Returns true if Contact or Account parameters is not empty.
			 */
			isNeedSetNboData: function() {
				return !!this.$Contact || !!this.$Account;
			},

			/**
			 * Returns nbo data from Contact or Account parameters.
			 */
			getNboData: function() {
				const recordId = this.$Contact?.value || this.$Account?.value;
				const schemaName = this.$Contact ? "Contact" : "Account";
				return {
					recordId: recordId,
					schemaName: schemaName
				};
			},

			/**
			 * Returns product catalog level data from page parameters.
			 */
			getProductCatalogLevelData: function() {
				return {
					productTypeId: this.$Type?.value,
					productCategoryId: this.$Category?.value,
					productAvailableFor: this.$ProductAvailableFor?.value
				};
			},

			/**
			 * Initializes component data.
			 */
			initComponentData: function() {
				if (!this.isNeedSetNboData()) {
					return;
				}
				const data = {
					nbo: this.getNboData()
				};
				this.set("ProductSelectionData", data);
			},

			/**
			 * @inheritdoc Terrasoft.ProductSelectionSchemaMixin#subscribeCustomEvents
			 * @override
			 */
			subscribeCustomEvents: function() {
				this.mixins.productSelectionMixin.subscribeCustomEvents.call(this);
				this.initProcessPageEvents();
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
			 * @override
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.initMixin();
					this.Ext.callback(callback, scope);
				}, this]);
			},

			/**
			 * @inheritdoc Terrasoft.Configuration.BaseSchemaViewModel#destroy
			 * @override
			 */
			destroy: function() {
				this.mixins.productSelectionMixin.onMixinDestroy.call(this);
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#onRender
			 * @override
			 */
			onRender: function() {
				this.callParent(arguments);
				this.initializeProductSelectionHeader();
			},

			/**
			 * @inheritdoc Terrasoft.BasePageProcessTemplate#getHeader
			 * @override
			 */
			getHeader: function() {
				return Ext.emptyString;
			}

			// endregion

		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "Tabs"
			}, {
				"operation": "remove",
				"name": "ProcessActionButtons"
			}, {
				"operation": "remove",
				"name": "CardContentWrapper"
			},
			{
				"operation": "insert",
				"name": "NGComponent",
				"values": {
					"itemType": 23,
					"className": "Terrasoft.BankProductSelectionProcessPageComponent"
				},
				"parentName": "CardContentContainer",
				"propertyName": "items",
				"index": 6
			}
		]/**SCHEMA_DIFF*/
	};
});
