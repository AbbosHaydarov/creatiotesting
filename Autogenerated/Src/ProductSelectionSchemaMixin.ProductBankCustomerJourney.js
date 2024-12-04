define("ProductSelectionSchemaMixin", ["ProductSelectionSchemaMixinResources", "css!ProductSelectionSchemaMixin"], function(resources) {
	/**
	 * @class Terrasoft.configuration.mixins.ProductSelectionSchemaMixin
	 */
	Ext.define("Terrasoft.configuration.mixins.ProductSelectionSchemaMixin", {
		alternateClassName: "Terrasoft.ProductSelectionSchemaMixin",


		// region Fields: Private

		/**
		 * @private
		 */
		_resources: resources,

		// endregion

		// region Fields: Protected

		/**
		 * Custom events.
		 */
		customEvent: null,

		// endregion

		// region Methods: Private

		/**
		 * @private
		 * @param {String} schemaName NBO schema name.
		 * @return {Terrasoft.EntitySchemaQuery}
		 */
		_getEsqForNboSchema: function(schemaName) {
			const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: schemaName
			});
			esq.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "displayValue");
			return esq;
		},

		/**
		 * @private
		 * @param {Object} nboData NBO data.
		 */
		_setHeaderCaptionByNbo: function(nboData) {
			const nboSchemaEsq = this._getEsqForNboSchema(nboData.schemaName);
			nboSchemaEsq.getEntity(nboData.recordId, function(response) {
				if (response?.success) {
					const esqDisplayValue = response.entity.get("displayValue");
					this.setNboHeaderCaption(esqDisplayValue);
				} else {
					this.setDefaultHeaderCaption();
				}
			}, this);
		},

		/**
		 * @private
		 * @param {String} headerCaption Caption of the schema header.
		 */
		_setHeaderCaption: function(headerCaption) {
			const sandbox = this.sandbox;
			sandbox.publish("UpdatePageHeaderCaption", {
				pageHeaderCaption: headerCaption
			});
		},

		/**
		 * @private
		 */
		_initMixinResources: function() {
			Terrasoft.each(this._resources.localizableStrings, function(item, key) {
				this.set("Resources.Strings." + key, item);
			}, this);
		},

		// endregion

		// region Methods: Protected

		/**
		 * Returns custom events instance.
		 * @returns Custom events.
		 */
		getCustomEvent: function() {
			if (!this.customEvent) {
				this.customEvent = Ext.create("Terrasoft.CustomEventDomMixin");
			}
			return this.customEvent;
		},

		/**
		 * Initializes component data.
		 */
		initComponentData: function() {
			const historyState = this.sandbox.publish("GetHistoryState");
			const stateObj = historyState?.state;
			const data = stateObj?.nbo ? stateObj : null;
			this.set("ProductSelectionData", data);
		},

		/**
		 * Subscribes sanbox events.
		 */
		subscribeSandboxEvents: function() {
			this.sandbox.subscribe("NeedHeaderCaption", function() {
				this.initializeProductSelectionHeader();
			}, this);
		},

		/**
		 * Subscribes custom events.
		 */
		subscribeCustomEvents: function() {
			const customEvent = this.getCustomEvent();
			customEvent.subscribe("GetNBOData").subscribe(this.onGetNBOData.bind(this));
			customEvent.subscribe("GetProductLevelData").subscribe(this.onGetProductCatalogLevelData.bind(this));
		},

		/**
		 * Get product catalog level data.
		 */
		getProductCatalogLevelData: function() { },

		/**
		 * Publishes product catalog level data.
		 */
		onGetProductCatalogLevelData: function() {
			const productLevelData = this.getProductCatalogLevelData();
			const customEvent = this.getCustomEvent();
			customEvent.publish("GetProductLevelData", productLevelData);
		},

		/**
		 * Publishes NBO data.
		 */
		onGetNBOData: function() {
			const productSelectionData = this.get("ProductSelectionData");
			const customEvent = this.getCustomEvent();
			customEvent.publish("GetNBOData", productSelectionData?.nbo);
		},

		/**
		 * Initializes header caption.
		 */
		initializeProductSelectionHeader: function() {
			this.showPageHeader();
			const productSelectionData = this.get("ProductSelectionData");
			Ext.Object.isEmpty(productSelectionData?.nbo) ?
				this.setDefaultHeaderCaption() :
				this._setHeaderCaptionByNbo(productSelectionData.nbo);
		},

		/**
		 * Shows page header.
		 */
		showPageHeader: function() {
			const isMainHeaderVisibleAttribute = this.getIsMainHeaderVisibleAttribute();
			const isCardOpenAttribute = this.getIsCardOpenAttribute();
			Terrasoft.utils.dom.setAttributeToBody(isCardOpenAttribute, true);
			Terrasoft.utils.dom.setAttributeToBody(isMainHeaderVisibleAttribute, false);
		},

		/**
		 * Clears page header caption.
		 */
		clearPageHeaderCaption: function() {
			this._setHeaderCaption(Ext.emptyString);
		},

		/**
		 * Get header caption mask for NBO.
		 * @returns {String} Returns header caption mask.
		 */
		getHeaderCaptionMaskForNBO: function() {
			return Terrasoft.getIsRtlMode() ? "{1} {0}" : "{0} {1}";
		},

		/**
		 * Get is card open attribute.
		 * @returns {String} Returns is card open attribute.
		 */
		getIsCardOpenAttribute: function() {
			return "is-card-opened";
		},

		/**
		 * Get is main header visible attribute.
		 * @returns {String} Returns is main header visible attribute.
		 */
		getIsMainHeaderVisibleAttribute: function() {
			return "is-main-header-visible";
		},

		/**
		 * Setting default caption for header.
		 */
		setDefaultHeaderCaption: function() {
			this._setHeaderCaption(this.get("Resources.Strings.HeaderCaption"));
		},

		/**
		 * Setting NBO caption for header.
		 * @param {String} NBO client name.
		 */
		setNboHeaderCaption: function(clientName) {
			const headerCaptionMask = this.getHeaderCaptionMaskForNBO();
			const headerCaptionByNbo = Ext.String.format(headerCaptionMask,
				this.get("Resources.Strings.HeaderCaptionByNbo"), clientName);
			this._setHeaderCaption(headerCaptionByNbo);
		},

		/**
		 * Resets body attributes.
		 */
		resetBodyAttributes: function() {
			Terrasoft.utils.dom.setAttributeToBody(this.getIsCardOpenAttribute(), false);
			Terrasoft.utils.dom.setAttributeToBody(this.getIsMainHeaderVisibleAttribute(), true);
		},

		/**
		 * Initializes custom events for ng component.
		 */
		initCustomEvent: function() {
			const customEvent = this.getCustomEvent();
			customEvent.init();
			this.initNgComponentTranslation();
		},

		/**
		 * Initializes product selection ng component translation.
		 */
		initNgComponentTranslation: function() {
			const translation = this.getProductSelectionTranslation();
			this.getCustomEvent().publish("GetProductSelectionTranslation", translation);
		},

		/**
		* Returns product selection ng component translation.
		*/
		getProductSelectionTranslation: function() {
			return {
				"BankProductSelectionPageComponent": {
					"AccountFilterCaption": this.get("Resources.Strings.AccountFilterCaption"),
					"ContactFilterCaption": this.get("Resources.Strings.ContactFilterCaption")
				},
				"ProductDialogComponent": {
					"Application": this.get("Resources.Strings.ProductApplicationCaption"),
					"Benefits": this.get("Resources.Strings.BenefitsCaption"),
					"Conditions": this.get("Resources.Strings.ConditionsCaption"),
					"Detail": this.get("Resources.Strings.DetailCaption"),
					"Close": this.get("Resources.Strings.CloseCaption"),
					"NoData": this.get("Resources.Strings.NoDataCaption"),
					"SuccessRegistration": this.get("Resources.Strings.SuccessRegistrationCaption"),
					"MissingProcessNameForProductRegistration": this.get("Resources.Strings.MissingProcessNameForProductRegistrationCaption"),
					"NotFoundProcessProductRegistration": this.get("Resources.Strings.NotFoundProcessProductRegistrationCaption"),
					"Probability": this.get("Resources.Strings.ProbabilityCaption"),
					"NotInterested": this.get("Resources.Strings.NotInterestedCaption"),
					"Cancel": this.get("Resources.Strings.CancelCaption"),
					"Save": this.get("Resources.Strings.SaveCaption"),
					"NotInterestedDescription": this.get("Resources.Strings.NotInterestedDescriptionCaption"),
					"Description": this.get("Resources.Strings.DescriptionCaption")
				},
				"ProductSelectionPageComponent": {
					"Back": this.get("Resources.Strings.BackButtonCaption")
				},
				"ProductFolderViewComponent": {
					"AllFolderCaption": this.get("Resources.Strings.AllFolderCaption"),
					"NBOFolderCaption": this.get("Resources.Strings.NBOFolderCaption"),
					"ToSpecificationCaption": this.get("Resources.Strings.ToSpecificationCaption")
				},
				"ProductListComponent": {
					"BlankSlateDescription": this.get("Resources.Strings.BlankSlateDescription")
				},
				"ProductSpecification": {
					"Values": {
						"Yes": this.get("Resources.Strings.ProductSpecificationValueYes"),
						"No": this.get("Resources.Strings.ProductSpecificationValueNo")
					}
				},
				"SearchInput.Placeholder": this.get("Resources.Strings.SearchPlaceHolder")
			};
		},

		/**
		 * Initializes mixin events and resources.
		 */
		initMixin: function() {
			this.initComponentData();
			this._initMixinResources();
			this.initCustomEvent();
			this.subscribeCustomEvents();
			this.subscribeSandboxEvents();
		},

		/**
		 * Destroy custom events.
		 */
		onMixinDestroy: function() {
			this.resetBodyAttributes();
			this.clearPageHeaderCaption();
			const customEvent = this.getCustomEvent();
			if (customEvent) {
				customEvent.destroy();
			}
			this.customEvent = null;
		}

		// endregion

	});

	return Terrasoft.ProductSelectionSchemaMixin;
});
