define("Switcher", ["SwitcherResources", "css!Switcher"], function(resources) {

	/**
	 * @class Terrasoft.controls.Switcher
	 * ##### ######## ########## ########### ####.
	 */
	Ext.define("Terrasoft.controls.Switcher", {
		extend: "Terrasoft.Component",
		alternateClassName: "Terrasoft.Switcher",

		/**
		 * ####### ### ########## ######## "######".
		 * @private
		 * @type {Object}
		 */
		trueValueItem: null,

		/**
		 * ######### ### ########## ######## "######".
		 * @protected
		 * @type {Object}
		 */
		trueValueItemConfig: null,

		/**
		 * ####### ### ########## ######## "####".
		 * @private
		 * @type {Object}
		 */
		falseValueItem: null,

		/**
		 * ######### ### ########## ######## "####".
		 * @protected
		 * @type {Object}
		 */
		falseValueItemConfig: null,

		/**
		 * CSS ##### ### ###### ########### ########.
		 * @protected
		 * @type {String}
		 */
		valueContainerClass: "t-switcher-value",

		/**
		 * CSS ##### ####### ########.
		 * @protected
		 * @type {String}
		 */
		wrapClass: "t-switcher-wrap",

		/**
		 * CSS ##### ########### ########### ####
		 * @protected
		 * @overridden
		 * @type {String}
		 */
		disabledClass: "t-switcher-disabled",

		/**
		 * CSS ##### ####### # ########## #########.
		 * @protected
		 * @type {String}
		 */
		disabledWrapClass: "t-switcher-wrap-disabled",

		/**
		 * CSS ##### ############## ########### ####
		 * @protected
		 * @type {String}
		 */
		checkedClass: "t-switcher-checked",

		/**
		 * ######## ########### ####
		 * @public
		 * @type {Boolean}
		 */
		checked: false,

		/**
		 * ######## ######## ##########
		 * @public
		 * @type {String}
		 */
		value: null,

		/**
		 * ##### ###### ########.
		 * @overridden
		 * @type {String[]}
		 */
		/* jshint ignore:start */
		/* jscs:disable */
		tpl: [
			'<div id="{id}-wrapEl" class="{wrapClass}" style="{wrapStyles}" tabindex="{tabIndex}" value="{value}"',
				'<tpl if="!enabled">',
				' disabled="disabled"',
				'</tpl> >',
				'<div id="{id}-innerWrapEl" class="{innerWrapClass}" style="{innerWrapStyles}" >',
					'<div id="{id}-trueValueEl" class="{trueValueClass}" style="{trueValueStyle}">',
						'{%this.renderValueItem(out, values, "trueValueItem")%}',
					'</div>',
					'<div id="{id}-falseValueEl" class="{falseValueClass}" style="{falseValueStyle}">',
						'{%this.renderValueItem(out, values, "falseValueItem")%}',
					'</div>',
				'</div>',
			'</div>'
		],
		/* jscs:enable */
		/* jshint ignore:end */

		/**
		 * ###### ### ############ inline-###### ########## ######### # #######.
		 * #### # {@link #tpl #######} ####### ### #####, ## # ####### ###### ###### #### ######## # ##### ## #######.
		 * #### ######## ## ####### ## ##### #######, ## ####### ## ####### ##### ###### ## #######. ###############
		 * ##### ########## ##### # ##### ## #### ####### {@link #getTpl getTpl()} # {@link #getTplData getTplData()}.
		 * @overridden
		 * @type {Object}
		 */
		styles: {
			wrapStyles: {},
			innerWrapStyles: {},
			trueValueStyle: {},
			falseValueStyle: {}
		},

		/**
		 * @inheritdoc Terrasoft.Component#initRenderData
		 * @protected
		 * @overridden
		 */
		initRenderData: function(renderData) {
			this.callParent(arguments);
			renderData.trueValueItem = this.trueValueItem;
			renderData.falseValueItem = this.falseValueItem;
			renderData.renderValueItem = this.renderValueItem;
		},

		/**
		 * ############ # ####### ##-######### ### ########## ######### ########## ### ###### # ##############.
		 * @param {String[]} buffer ##### ### ######### HTML.
		 * @param {Object} renderData ###### ########## ### #######.
		 * @param {String} propertyName ######## ########, ########### ######### ######## ##########, ######### ######
		 * ###### generateHtml() # ######## ##### ####### # #####.
		 * @protected
		 */
		renderValueItem: function(buffer, renderData, propertyName) {
			var self = renderData.self;
			var control = self[propertyName];
			var html = control.generateHtml();
			Ext.DomHelper.generateMarkup(html, buffer);
		},

		/**
		 * ##### ############## ####### ######### ########### "######"/"####".
		 * @protected
		 */
		prepareValueItems: function() {
			this.trueValueItem = Ext.create(this.trueValueItemConfig.className, this.trueValueItemConfig);
			this.trueValueItem.added(this);
			this.falseValueItem = Ext.create(this.falseValueItemConfig.className, this.falseValueItemConfig);
			this.falseValueItem.added(this);
		},

		/**
		 * @inheritDoc Terrasoft.Component#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			if (Ext.isEmpty(this.trueValueItemConfig) && Ext.isEmpty(this.falseValueItemConfig)) {
				this.setDefaultItemsConfig();
			}
			this.prepareValueItems();
			this.addEvents(
				/**
				 * @event
				 * #### ######
				 * @param {Terrasoft.Switcher} this
				 */
				"click",
				/**
				 * @event
				 * ########## ########## ########
				 * @param {Terrasoft.Switcher} this
				 * @param {Number} newValue ##### ######## ######## checked
				 */
				"checkedchanged"
			);
			this.on("click", this.onClick, this);
			this.on("checkedchanged", this.onCheckedChanged, this);
		},

		/**
		 * ######### ####### DOM.
		 * @private
		 * @param  {Ext.EventObjectImpl} event ###### #######
		 */
		onDomEvent: function(event) {
			if (this.enabled && this.rendered && this.visible) {
				this.fireEvent(event.type, this, event);
			}
		},

		/**
		 * ############# ####### DOM.
		 * @protected
		 * @overridden
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			if (!this.rendered) {
				return;
			}
			this.trueValueEl.on("click", this.onDomEvent, this);
			this.falseValueEl.on("click", this.onDomEvent, this);
		},

		/**
		 * ########## ##### ### #######
		 * @protected
		 * @return {Object} ###### ######.
		 */
		prepareTplClasses: function() {
			var classes = {
				wrapClass: [],
				innerWrapClass: [],
				trueValueClass: [this.valueContainerClass],
				falseValueClass: [this.valueContainerClass]
			};
			var wrapClass = classes.wrapClass;
			var trueValueClass = classes.trueValueClass;
			var falseValueClass = classes.falseValueClass;
			var innerWrapClass = classes.innerWrapClass;
			wrapClass.push(this.wrapClass);
			if (this.checked) {
				trueValueClass.push(this.checkedClass);
			} else {
				falseValueClass.push(this.checkedClass);
			}
			if (!this.enabled) {
				innerWrapClass.push(this.disabledWrapClass);
			}
			return classes;
		},

		/**
		 * ########## ###### ### ####### # ######## #########
		 * @protected
		 * @overridden
		 */
		getTplData: function() {
			var tplData = this.callParent(arguments);
			tplData.trueValueItem = this.trueValueItem;
			tplData.falseValueItem = this.falseValueItem;
			tplData.enabled = this.enabled;
			tplData.value = this.value;
			tplData.renderValueItem = this.renderValueItem;
			Ext.apply(tplData, this.prepareTplClasses());
			this.updateSelectors(tplData);
			return tplData;
		},

		/**
		 * ######## ######### ###### ## ###### ############## ### ######## ########
		 * @protected
		 */
		updateSelectors: function() {
			var selectors = this.selectors = this.selectors || {};
			selectors.wrapEl = "#" + this.id + "-wrapEl";
			selectors.innerWrapEl = "#" + this.id + "-innerWrapEl";
			selectors.trueValueEl = "#" + this.id + "-trueValueEl";
			selectors.falseValueEl = "#" + this.id + "-falseValueEl";
		},

		/**
		 * ########## ##### #####
		 * @protected
		 */
		onClick: function() {
			if (!this.enabled) {
				return;
			}
			this.setChecked(!this.checked);
		},

		/**
		 * ########## ######### ######## ############### #####.
		 * @protected
		 */
		onCheckedChanged: function() {
			if (!this.visible || !this.rendered) {
				return;
			}
			this.setStyles();
		},

		/**
		 * ############# CSS, # ########### ## ######### ######## ##########.
		 * @protected
		 */
		setStyles: function() {
			if (this.checked) {
				this.trueValueEl.addCls(this.checkedClass);
				this.falseValueEl.removeCls(this.checkedClass);
			} else {
				this.trueValueEl.removeCls(this.checkedClass);
				this.falseValueEl.addCls(this.checkedClass);
			}
			if (this.enabled) {
				this.innerWrapEl.removeCls(this.disabledWrapClass);
			} else {
				this.innerWrapEl.addCls(this.disabledWrapClass);
			}
		},

		/**
		 * ######### ########## ######## ##########.
		 * @overridden
		 */
		setEnabled: function() {
			this.callParent(arguments);
			if (this.rendered) {
				this.setStyles();
			}
		},

		/**
		 * ########## ######## #####.
		 * @param {Boolean} checked ##### ######## ############### #####.
		 */
		setChecked: function(checked) {
			if (this.checked === checked) {
				return;
			}
			this.checked = checked;
			this.fireEvent("checkedchanged", checked, this);
		},

		/**
		 * ########## ######## #####.
		 * @return {Boolean} checked ######## ############### #####.
		 */
		getValue: function() {
			return this.checked;
		},

		/**
		 * ####### ########## ## ######### ### ########### "######"/"####"
		 * @protected
		 */
		setDefaultItemsConfig: function() {
			var imageLink = Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.CheckBoxImage);
			var imageUrl = Ext.String.format("url({0})", imageLink);
			var imageContainer = {
				className: "Terrasoft.Container",
				styles: {
					wrapStyles: {
						"background-image": imageUrl,
						"background-repeat": "no-repeat"
					}
				}
			};
			this.trueValueItemConfig = {
				className: "Terrasoft.Container",
				items: [
					imageContainer,
					{
						className: "Terrasoft.Label",
						caption: resources.localizableStrings.YesButtonCaption
					}
				]
			};
			this.falseValueItemConfig = {
				className: "Terrasoft.Container",
				items: [
					imageContainer,
					{
						className: "Terrasoft.Label",
						caption: resources.localizableStrings.NoButtonCaption
					}
				]
			};
		},

		/**
		 * ########## ############ ######## # ######. ######### ######### ####### {@link Terrasoft.Bindable}.
		 * @overridden
		 */
		getBindConfig: function() {
			var bindConfig = this.callParent(arguments);
			var checkBoxBindConfig = {
				checked: {
					changeEvent: "checkedchanged",
					changeMethod: "setChecked"
				}
			};
			Ext.apply(checkBoxBindConfig, bindConfig);
			return checkBoxBindConfig;
		},

		/**
		 * @inheritDoc Terrasoft.Bindable#bind
		 * @overridden
		 */
		bind: function() {
			this.callParent(arguments);
			this.falseValueItem.bind(this.model);
			this.trueValueItem.bind(this.model);
		}

	});
	return Terrasoft.Switcher;
});
