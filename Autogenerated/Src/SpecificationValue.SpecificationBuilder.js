define("SpecificationValue", ["SpecificationValueResources", "css!SpecificationValue"], function(resources) {
	/**
	 * @class Terrasoft.controls.SpecificationValue
	 * ##### ######## ########## ###### ############ ##########.
	 */
	Ext.define("Terrasoft.controls.SpecificationValue", {
		extend: "Terrasoft.AbstractContainer",
		alternateClassName: "Terrasoft.SpecificationValue",

		//region Properties: Private

		/**
		 * ####### ### ###########.
		 * @private
		 * @type {Terrasoft.Component}
		 */
		readControl: null,

		/**
		 * ####### ### ##############.
		 * @private
		 * @type {Terrasoft.Component}
		 */
		editControl: null,

		//endregion

		//region Properties: Protected

		/*jshint ignore:start */
		//jscs:disable
		tpl: [
			'<div id="{id}-specification-value-wrap" class="{wrapClasses}" style="{wrapStyles}" tabindex="{tabIndex}">',
			'<div id="{id}-specification-value-content" class="{contentWrapClasses}">',
			'<div id="{id}-specification-value-readContainer" class="{readContainerClasses}" ',
			'style="{readContainerStyles}">',
			'<div id="{id}-specification-value-placeholder" class="{placeholderClasses}">',
			'<tpl if="isReadMode">{placeholder}</tpl>',
			'</div>',
			'<tpl if="isReadMode">',
			'{%this.renderControl(out, values, "readControl")%}',
			'</tpl>',
			'</div>',
			'<div id="{id}-specification-value-editContainer" class="{editContainerClasses}" ',
			'style="{editContainerStyles}">',
			'<tpl if="!isReadMode">',
			'{%this.renderControl(out, values, "editControl")%}',
			'</tpl>',
			'</div>',
			'</div>',
			'<tpl if="isReadMode">',
			'<div id="{id}-specification-value-disabled-el-icon" class="{disabledElIconClasses}" ',
			'style="{disabledElIconStyles}"></div>',
			'</tpl>',
			'<tpl if="hasActions && isReadMode">',
			'<div id="{id}-specification-value-actions" class="{actionsWrapClasses}">',
			'{%this.renderItems(out, values)%}',
			'</div>',
			'</tpl>',
			'</div>'
		],
		//jscs:enable
		/*jshint ignore:end */

		/**
		 * Css ##### ####### ########.
		 * @protected
		 * @type {String}
		 */
		wrapClass: "specification-value-wrap",

		/**
		 * Css ##### ########## #########.
		 * @protected
		 * @type {String}
		 */
		contentWrapClass: "specification-value-content",

		/**
		 * Css ##### ########## ########.
		 * @protected
		 * @type {String}
		 */
		actionsWrapClass: "specification-value-actions",

		/**
		 * ##### Css ##### "############" ######## ##########.
		 * @protected
		 * @type {String}
		 */
		disabledClass: "specification-value-disabled",

		/**
		 * Css ##### ### ###### "############" ######## ##########.
		 * @protected
		 * @type {String}
		 */
		disabledIconClass: "specification-value-disabled-icon",

		/**
		 * Css-##### ########## ### placeholder'a.
		 * @protected
		 * @type {String}
		 */
		placeholderClass: "specification-value-placeholder",

		/**
		 * Css-##### ########## ### placeholder'a, #### ######### ########.
		 * @protected
		 * @type {String}
		 */
		removedPlaceholderClass: "specification-value-placeholder-hide",

		//endregion

		//region Properties: Public

		/**
		 * ##### ##-#########, #### ######## ## #########.
		 * @public
		 * @type {String}
		 */
		placeholder: null,

		/**
		 * #######, ### ####### ########## ######### # ###### "######".
		 * @public
		 * @type {Boolean}
		 */
		isReadMode: true,

		/**
		 * #######, ### ####### ########## ##### ############ # ##### ###### ### ###### ######.
		 * @public
		 * @type {Boolean}
		 */
		canSwitchMode: true,

		/**
		 * #######, ### # ####### ########## ##### ########## ##### ### #########.
		 * @public
		 * @type {Boolean}
		 */
		focusAfterRender: true,

		/**
		 * ###### ######## ### ###########.
		 * @public
		 * @type {Object}
		 */
		readControlConfig: null,

		/**
		 * ###### ######## ### ##############.
		 * @public
		 * @type {Object}
		 */
		editControlConfig: null,

		/**
		 * Css ##### #######, # ####### ######## #### ####.
		 * @public
		 * @type {String}
		 */
		wrapBackgroundClass: "specification-value-background-wrap",

		/**
		 * ############## Css ##### #######.
		 * @public
		 * @type {String}
		 */
		additionalWrapClass: "specification-value-additional-wrap",

		/**
		 * #######, ### ####### ##### ############ ############## Css ##### ### #######.
		 * @public
		 * @type {Boolean}
		 */
		useAdditionalWrapClass: false,

		//endregion

		//region Methods: Private

		/**
		 * #########, ######## ## ############ ##### ######## ###### / ##############.
		 * @private
		 * @return {Boolean} True, #### ###### ## ####### enabled, rendered, visible # canSwitchMode
		 * ##### True, ##### False.
		 */
		canSwitchReadMode: function() {
			return this.enabled && this.rendered && this.visible && this.canSwitchMode;
		},

		/**
		 * ######### ####### ##### #####.
		 * @private
		 * @param {Ext.EventObjectImpl} event ###### #######.
		 */
		onClick: function(event) {
			if (this.canSwitchReadMode()) {
				if (this.isOutWrapperClick(event)) {
					this.setIsReadMode(true);
				} else {
					this.setIsReadMode(false);
				}
			}
		},

		/**
		 * ######### ######### ######.
		 * @private
		 */
		onFocus: function() {
			if (this.canSwitchReadMode()) {
				this.setIsReadMode(false);
			}
		},

		/**
		 * ########, ### ## ####### ### wrapper'a.
		 * @private
		 * @param {Ext.EventObjectImpl} event ###### #######.
		 * @return {Boolean} True, #### ## ####### ### wrapper'a, ##### false.
		 */
		isOutWrapperClick: function(event) {
			return !event.within(this.wrapEl.id);
		},

		/**
		 * ############ ####### {@link Terrasoft.Component#afterrender event} # ######## ##########
		 * ### ##############.
		 * @private
		 */
		onEditControlAfterRender: function() {
			if (this.focusAfterRender && Terrasoft.instanceOfClass(this.editControl, "Terrasoft.BaseEdit")) {
				this.editControl.setFocused(true);
				var el = this.editControl.getWrapEl();
				el.dom.click();
			}
		},

		/**
		 * ######## ### ########## div # placeholder'##.
		 * @private
		 * @param {String} value ######## ######## ########## editControl.
		 */
		onValueChanged: function(value) {
			if (Ext.isEmpty(this.placeholderContainer)) {
				return;
			}
			if (Ext.isEmpty(value)) {
				this.placeholderContainer.removeCls(this.removedPlaceholderClass);
			} else {
				this.placeholderContainer.addCls(this.removedPlaceholderClass);
			}
		},

		/**
		 * ####### ######### ######## ########## ## ######### ####### #########.
		 * @private
		 * @param {Object} config ###### ######### ######## ##########.
		 * @return {Terrasoft.Component} ####### ##########.
		 */
		createControl: function(config) {
			if (!config.className) {
				throw new Terrasoft.UnsupportedTypeException();
			}
			return Ext.create(config.className, config);
		},

		//endregion

		//region Methods: Protected

		/**
		 * @inheritDoc Terrasoft.AbstractContainer#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			this.prepareControls();
			this.editControl.on("afterrerender", this.onEditControlAfterRender.bind(this));
			this.editControl.on("afterrender", this.onEditControlAfterRender.bind(this));
			if (Terrasoft.instanceOfClass(this.editControl, "Terrasoft.BaseEdit")) {
				this.editControl.on("change", this.onValueChanged.bind(this));
			}
		},

		/**
		 * ############ # ####### ##-######### ### ########## ######### ########## ### ###### # ##############.
		 * @param {String[]} buffer ##### ### ######### HTML.
		 * @param {Object} renderData ###### ########## ### #######.
		 * @param {String} propertyName ######## ########, ########### ######### ######## ##########, ######### ######
		 * ###### generateHtml() # ######## ##### ####### # #####.
		 * @protected
		 */
		renderControl: function(buffer, renderData, propertyName) {
			var self = renderData.self;
			var control = self[propertyName];
			var html = control.generateHtml();
			Ext.DomHelper.generateMarkup(html, buffer);
		},

		/**
		 * ######### ###### ###### # #######.
		 * @protected
		 * @return {Object} ###### ######.
		 */
		prepareTplClasses: function() {
			var classes = {
				wrapClasses: [this.wrapClass],
				contentWrapClasses: [this.contentWrapClass],
				actionsWrapClasses: [this.actionsWrapClass],
				placeholderClasses: [this.placeholderClass],
				disabledElIconClasses: []
			};
			var wrapClasses = classes.wrapClasses;
			if (this.isReadMode) {
				wrapClasses.push(this.wrapBackgroundClass);
			}
			if (!this.enabled) {
				wrapClasses.push(this.disabledClass);
				var disabledElIconClasses = classes.disabledElIconClasses;
				disabledElIconClasses.push(this.disabledIconClass);
			}
			if (!Ext.isEmpty(this.editControl.value)) {
				var placeholderClasses = classes.placeholderClasses;
				placeholderClasses.push(this.removedPlaceholderClass);
			}
			if (this.useAdditionalWrapClass) {
				wrapClasses.push(this.additionalWrapClass);
			}
			return classes;
		},

		/**
		 * ######### inline-##### # #######.
		 * @protected
		 * @return {Object} ###### inline-######.
		 */
		prepareTplStyles: function() {
			var styles = {
				wrapStyles: {},
				disabledElIconStyles: {}
			};
			var imageLink = Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.ReadOnlyIcon);
			var imageUrl = Ext.String.format("url({0})", imageLink);
			styles.disabledElIconStyles = {
				"background-image": imageUrl,
				"background-repeat": "no-repeat"
			};
			return styles;
		},

		/**
		 * ######### #########, ###### ## ######, ############## ### ######## ########.
		 * @protected
		 */
		updateSelectors: function() {
			var selectors = this.selectors = this.selectors || {};
			selectors.wrapEl = Ext.String.format("#{0}-specification-value-wrap", this.id);
			selectors.actionsEl = Ext.String.format("#{0}-specification-value-actions", this.id);
			selectors.readContainer = Ext.String.format("#{0}-specification-value-readContainer", this.id);
			selectors.editContainer = Ext.String.format("#{0}-specification-value-editContainer", this.id);
			selectors.placeholderContainer = Ext.String.format("#{0}-specification-value-placeholder", this.id);
			selectors.disabledElIcon = Ext.String.format("#{0}-specification-value-disabled-el-icon", this.id);
		},

		/**
		 * @inheritDoc Terrasoft.AbstractContainer#initRenderData
		 * @overridden
		 */
		initRenderData: function(renderData) {
			this.callParent(arguments);
			renderData.renderControl = this.renderControl;
		},

		/**
		 * @inheritDoc Terrasoft.Component#getTplData
		 * @overridden
		 */
		getTplData: function() {
			var tplData = this.callParent(arguments);
			Ext.apply(tplData, this.prepareTplClasses());
			Ext.apply(tplData, this.prepareTplStyles());
			tplData.placeholder = this.placeholder;
			tplData.isReadMode = this.isReadMode;
			tplData.hasActions = this.items && this.items.getCount();
			tplData.enabled = this.enabled;
			this.updateSelectors(tplData);
			return tplData;
		},

		/**
		 * @inheritDoc Terrasoft.Component#initDomEvents
		 * @overridden
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			if (!this.rendered) {
				return;
			}
			this.wrapEl.on("focus", this.onFocus, this);
			Ext.EventManager.on(Ext.getBody(), "click", this.onClick, this);
		},

		/**
		 * ####### ###### # ###### ## ########## ######### ##########
		 * ### ###### # ##############.
		 * # ####### ########## ######## ##### {@link Terrasoft.Component#added added}
		 * @protected
		 */
		prepareControls: function() {
			this.readControl = this.createControl(this.readControlConfig);
			this.readControl.added(this);
			this.editControl = this.createControl(this.editControlConfig);
			this.editControl.added(this);
		},

		/**
		 * @inheritDoc Terrasoft.Bindable#bind
		 * @overridden
		 */
		bind: function() {
			this.callParent(arguments);
			this.readControl.bind(this.model);
			this.editControl.bind(this.model);
		},

		/**
		 * ######### ####### ########## # ##### ###### ### ##############.
		 * ######### ########### ######## ##########.
		 * @param {Boolean} value ##### ######## ########.
		 * @protected
		 */
		setIsReadMode: function(value) {
			if (this.isReadMode === value) {
				return;
			}
			this.isReadMode = value;
			if (this.allowRerender()) {
				this.readControl.setVisible(value);
				this.editControl.setVisible(!value);
				this.reRender();
			}
		},

		/**
		 * @inheritDoc Terrasoft.Component#setEnabled
		 * @overridden
		 */
		setEnabled: function(enabled) {
			if (this.enabled === enabled) {
				return;
			}
			this.callParent(arguments);
			var disabledElIcon = this.disabledElIcon;
			if (disabledElIcon && this.disabledIconClass && this.rendered) {
				if (enabled) {
					disabledElIcon.removeCls(this.disabledIconClass);
				} else {
					disabledElIcon.addCls(this.disabledIconClass);
				}
			}
		},

		/**
		 * ############# ##### ### ###### ######, ##### ######## ## #########.
		 * @protected
		 * @param {String} value ##### ##-#########, #### ######## ## #########.
		 */
		setPlaceholder: function(value) {
			if (this.placeholder === value) {
				return;
			}
			this.placeholder = value;
			if (this.allowRerender()) {
				this.reRender();
			}
		},

		/**
		 * ############# ############## Css ##### ### #######.
		 * @protected
		 * @param {Boolean} value ####### ############# ############### ######.
		 */
		setAdditionalWrapClass: function(value) {
			if (this.useAdditionalWrapClass === value) {
				return;
			}
			this.useAdditionalWrapClass = value;
			var wrapEl = this.wrapEl;
			if (this.rendered) {
				if (value) {
					wrapEl.addCls(this.additionalWrapClass);
				} else {
					wrapEl.removeCls(this.additionalWrapClass);
				}
			}
		},

		/**
		 * @inheritdoc Terrasoft.AbstractContainer#getRenderToEl
		 * @protected
		 */
		getRenderToEl: function(component) {
			if (this.items.contains(component)) {
				return this.actionsEl;
			}
			return this.wrapEl;
		},

		/**
		 * @inheritDoc Terrasoft.Bindable#getBindConfig
		 * @overridden
		 */
		getBindConfig: function() {
			var bindConfig = this.callParent(arguments);
			var specificationValueBindConfig = {
				isReadMode: {
					changeMethod: "setIsReadMode"
				},
				placeholder: {
					changeMethod: "setPlaceholder"
				},
				useAdditionalWrapClass: {
					changeMethod: "setAdditionalWrapClass"
				}
			};
			Ext.apply(specificationValueBindConfig, bindConfig);
			return specificationValueBindConfig;
		},

		/**
		 * @inheritdoc Terrasoft.Component#clearDomListeners
		 * @overridden
		 */
		clearDomListeners: function() {
			Ext.EventManager.un(Ext.getBody(), "click", this.onClick, this);
			this.wrapEl.un("focus", this.onFocus, this);
			this.editControl.un("afterrerender", this.onEditControlAfterRender);
			this.editControl.un("afterrender", this.onEditControlAfterRender);
			this.callParent(arguments);
		},

		/**
		 * @inheritDoc Terrasoft.AbstractContainer#onDestroy
		 * @overridden
		 */
		onDestroy: function() {
			this.readControl.destroy();
			this.editControl.destroy();
			this.callParent(arguments);
		}

		//endregion
	});

	return Terrasoft.SpecificationValue;
});
