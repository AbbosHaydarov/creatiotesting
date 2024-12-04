define("NBOWidgetComponent", [
	"NBOWidgetComponentResources",
	...(Terrasoft.UseMfForAngularElements ? ["mf!NGBankProductSelection", "css-ltr!NGBankProductSelectionStyles"] : ["NGBankProductSelectionOld"])
], function(resources) {
	Ext.define("Terrasoft.NBOWidgetComponent", {
		extend: "Terrasoft.Component",

		/**
		 * @protected
		 */
		data: null,

		/**
		 * Custom events.
		 */
		 customEvent: null,

		/**
		 * The control resources.
		 * @protected
		 */
		 controlResources: resources,

		 /**
		  * The control resources receive event name.
		  * @protected
		  */
		 getControlResourcesEventName: "GetProductSelectionTranslation",

		/**
		 * @inheritdoc Terrasoft.controls.Container#tpl
		 */
		tpl: [
			"<div id=\"nbo-widget-{id}-wrap\" class=\"{wrapClassName}\">" +
				"<ts-nbo-widget id=\"nbo-widget-{id}\" class=\"nbo-widget\"></ts-nbo-widget>" +
			"</div>"
		],

		// region Methods: Protected

		/**
		 * Returns custom events instance.
		 * @returns Custom events.
		 */
		 getCustomEvent: function () {
			if (!this.customEvent) {
				this.customEvent = Ext.create("Terrasoft.CustomEventDomMixin");
			}
			return this.customEvent;
		},

		/**
		 * @inheritdoc Terrasoft.Component#init
		 * @override
		 */
		 init: function() {
			this.callParent(arguments);
			this.addEvents("onClick", "onItemInitialized");
			this.initControlResources();
		},

		/**
		 * Initializes ng component resources.
		 */
		initControlResources: function() {
			const customEvent = this.getCustomEvent();
			customEvent.init();
			const resources = {
				"NBOWidgetComponent": Ext.merge({}, this.controlResources.localizableStrings)
			};
			customEvent.publish(this.getControlResourcesEventName, resources);
		},
		
		/**
		 * @inheritdoc Terrasoft.Component#getSelectors
		 * @override
		 */
		getSelectors: function() {
			return {
				wrapEl: "#nbo-widget-" + this.id + "-wrap",
				widgetEl: "#nbo-widget-" + this.id
			};
		},

		/**
		 * @inheritdoc Terrasoft.Component#getTplData
		 * @override
		 */
		getTplData: function() {
			const tplData = this.callParent(arguments);
			this.selectors = this.getSelectors();
			return tplData;
		},

		/**
		 * @inheritDoc Terrasoft.Component#getBindConfig
		 * @override
		 */
		getBindConfig: function() {
			const bindConfig = this.callParent(arguments);
			const widgetBindConfig = {
				data: {
					changeMethod: "setData"
				},
				onClick: {
					changeEvent: "onClick"
				},
				onItemInitialized: {
					changeEvent: "onItemInitialized"
				}
			};
			Ext.apply(widgetBindConfig, bindConfig);
			return widgetBindConfig;
		},

		/**
		 * @inheritDoc Terrasoft.Component#initDomEvents
		 * @override
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			const el = this.widgetEl;
			if (el) {
				el.on("widgetClick", this.widgetClick, this);
				el.on("itemInitialized", this.widgetItemInitialized, this);
			}
		},

		/**
		 * @inheritDoc Terrasoft.Component#clearDomListeners
		 * @override
		 */
		clearDomListeners: function() {
			this.callParent(arguments);
			const el = this.widgetEl;
			if (el) {
				el.un("widgetClick", this.widgetClick, this);
				el.un("itemInitialized", this.widgetItemInitialized, this);
			}
		},

		/**
		 * Sets element data.
		 * @protected
		 */
		setElementData: function() {
			this.widgetEl.dom.data = this.data;
		},

		/**
		 * Handles click on widget.
		 */
		widgetClick: function () {
			this.fireEvent("onClick", null, this);
		},
		
		/**
		 * Handles widget item initialized.
		 */
		 widgetItemInitialized: function (event) {
			const nboItem = event?.browserEvent?.detail;
			this.fireEvent("onItemInitialized", nboItem, this);
		},

		/**
		 * @inheritDoc Terrasoft.Component#onDestroy
		 * @override
		 */
		 onDestroy: function() {
			const customEvent = this.getCustomEvent();
			if (customEvent) {
				customEvent.destroy();
			}
			this.customEvent = null;
			this.callParent(arguments);
		},

		// endregion

		// region Methods: Public

		/**
		 * @inheritDoc Terrasoft.Component#onAfterRender
		 * @override
		 */
		onAfterRender: function() {
			this.callParent(arguments);
			if (this.data) {
				this.setElementData();
			}
		},

		/**
		 * Sets widget data.
		 * @param {Object} data Data.
		 */
		setData: function(data) {
			if (!data) {
				return;
			}
			this.data = data;
			if (this.allowRerender()) {
				this.setElementData();
			}
		}

		// endregion

	});
});
