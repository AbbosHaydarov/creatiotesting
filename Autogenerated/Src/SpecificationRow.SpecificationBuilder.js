define("SpecificationRow", ["css!SpecificationRow", "SpecificationValue"], function() {
	Ext.ns("Terrasoft.controls.SpecificationRowEnums");

	/**
	 * ####### ########### ######## # ######.
	 * @enum {string} Terrasoft.controls.SpecificationRowEnums.ValueDirection
	 */
	Terrasoft.controls.SpecificationRowEnums.ValueDirection = {
		/** ############ ## ###########. */
		HORIZONTAL: "horizontal",
		/** ############ ## #########. */
		VERTICAL: "vertical"
	};

	/**
	 * ####### ########### ######### # ######.
	 * @enum {string} Terrasoft.controls.SpecificationRowEnums.HeaderPosition
	 */
	Terrasoft.controls.SpecificationRowEnums.HeaderPosition = {
		/** ############ #####. */
		LEFT: "left",
		/** ############ ######. */
		RIGHT: "right",
		/** ############ ######. */
		TOP: "top",
		/** ############ #####. */
		BOTTOM: "bottom"
	};

	/**
	 * ########## ### {@link Terrasoft.controls.SpecificationRowEnums}
	 * @member Terrasoft
	 * @inheritdoc Terrasoft.controls.SpecificationRowEnums
	 */
	Terrasoft.SpecificationRowEnums = Terrasoft.controls.SpecificationRowEnums;

	/**
	 * @class Terrasoft.controls.SpecificationRow
	 * ##### ######## ########## ###### ############ ##########.
	 */
	Ext.define("Terrasoft.controls.SpecificationRow", {
		extend: "Terrasoft.AbstractContainer",
		alternateClassName: "Terrasoft.SpecificationRow",

		//region Properties: Private

		/**
		 * ####### ########## #########.
		 * @private
		 * @type {Terrasoft.Component}
		 */
		specification: null,

		/**
		 * ####### #########.
		 * @private
		 * @type {Terrasoft.Component}
		 */
		topContainer: null,

		/**
		 * ###### #########.
		 * @private
		 * @type {Terrasoft.Component}
		 */
		bottomContainer: null,

		//endregion

		//region Properties: Public

		/**
		 * ####### ########### ######### ######.
		 * @public
		 * @type {Enum}
		 */
		headerPosition: Terrasoft.SpecificationRowEnums.HeaderPosition.LEFT,

		/**
		 * ########### ########### ######## ######.
		 * @public
		 * @type {Enum}
		 */
		valueDirection: Terrasoft.SpecificationRowEnums.ValueDirection.HORIZONTAL,

		/**
		 * ####### ########### ####### ######## ######.
		 * @public
		 * @type {Boolean}
		 */
		isRowToolsVisible: true,

		/**
		 * ######### ContainerList.
		 * @public
		 * @type {Object}
		 */
		containerListConfig: null,

		/**
		 * ######### #########.
		 * @public
		 * @type {Object}
		 */
		specificationConfig: null,

		/**
		 * ############## Css ##### ### ########## #########.
		 * @public
		 * @type {String}
		 */
		additionalSpecificationClass: "specification-row-additional",

		/**
		 * ####### ############# ############### Css ###### ### ########## #########.
		 * @public
		 * @type {Boolean}
		 */
		useAdditionalSpecificationClass: false,

		/**
		 * ###### ######### ######.
		 * @public
		 * @type {Object}
		 */
		parameterViewModel: null,

		/**
		 * Css ##### ### ## ######### ########## #########.
		 * @public
		 * @type {String}
		 */
		disabledClass: "specification-row-disabled",

		/**
		 * Css ##### ########## #########.
		 * @public
		 * @type {String}
		 */
		wrapClass: "specification-row-wrap",

		/**
		 * Css ##### ########### ########## #########.
		 * @public
		 * @type {String}
		 */
		innerWrapClass: "specification-row-innerWrap",

		/**
		 * Css ##### ########## #### #########.
		 * @public
		 * @type {String}
		 */
		specificationClass: "specification-row-type",

		/**
		 * Css ##### ########## ######## #########.
		 * @public
		 * @type {String}
		 */
		specificationValuesClass: "specification-row-values",

		/**
		 * Css ##### ########## ######## ######.
		 * @public
		 * @type {String}
		 */
		actionsWrapClass: "specification-row-actions",

		/**
		 * ######### ######## ##########.
		 * @public
		 * @type {Object}
		 */
		topContainerConfig: null,

		/**
		 * ######### ####### ##########.
		 * @public
		 * @type {Object}
		 */
		bottomContainerConfig: null,

		//endregion

		//region Properties: Protected

		// jscs:disable
		/* jshint ignore:start */
		tpl: [
			'<div id="{id}-wrapEl" class="{wrapClasses}" style="{wrapStyles}" tabindex="{tabIndex}">',
				'<div id="{id}-rowTopContainer" class="{rowTopClasses}" style="{rowTopStyles}">',
					'{%this.renderControl(out, values, "topContainer")%}',
				'</div>',
				'<div id="{id}-innerWrapEl" class="{innerWrapClasses}" style="{innerWrapStyles}" >',
					'<div id="{id}-specificationContainer" class="{specificationClasses}" style="{specificationStyles}">',
						'{%this.generateSpecificationControlMarkup(out, values)%}',
					'</div>',
					'<div id="{id}-valuesContainer" class="{specificationValuesClasses}" style="{specificationValuesStyles}">',
						'<div id="{id}-listContainer" class="{specificationListClasses}" style="{specificationListStyles}">',
							'{%this.generateContainerListMarkup(out, values)%}',
						'</div>',
						'<tpl if="hasActions">',
							'<div id="{id}-specification-row-actions" class="{actionsWrapClasses}">',
								'{%this.renderItems(out, values)%}',
							'</div>',
						'</tpl>',
					'</div>',
				'</div>',
				'<div id="{id}-rowBottomContainer" class="{rowBottomClasses}" style="{rowBottomStyles}">',
					'{%this.renderControl(out, values, "bottomContainer")%}',
				'</div>',
			'</div>'
		],
		/* jshint ignore:end */
		//jscs:enable

		/**
		 * @inheritDoc Terrasoft.Component#styles
		 * @overridden
		 */
		styles: {
			wrapStyles: {},
			innerWrapStyles: {},
			specificationStyles: {},
			specificationValuesStyles: {}
		},

		//endregion

		//region Methods: Protected

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
			if (Terrasoft.instanceOfClass(control, "Terrasoft.Component")) {
				var html = control.generateHtml();
				Ext.DomHelper.generateMarkup(html, buffer);
			}
		},

		/**
		 * @inheritdoc Terrasoft.AbstractContainer#getRenderToEl
		 * @protected
		 * @overridden
		 */
		getRenderToEl: function(component) {
			if (this.items.indexOf(component) !== -1) {
				return this.rowActionsEl;
			}
			var wrapEl = this.getWrapEl();
			var elementSelect = wrapEl.select("#" + this.id + this.itemDomIdSuffix + component.id);
			return elementSelect.first();
		},

		/**
		 * ########## ##### ###### ### ########## #########.
		 * @protected
		 * @return {String} ######## ###### ######.
		 */
		getHeaderClass: function() {
			return this.specificationClass + "-" + this.headerPosition;
		},

		/**
		 * ########## ##### ###### ### ########## ########.
		 * @protected
		 * @return {String} ######## ###### ######.
		 */
		getListClass: function() {
			return this.specificationValuesClass + "-" + this.valueDirection;
		},

		/**
		 * ######### ###### ###### # #######.
		 * @protected
		 * @return {Object} ###### ######.
		 */
		prepareTplClasses: function() {
			var classes = {
				wrapClasses: [this.wrapClass],
				innerWrapClasses: [this.innerWrapClass],
				specificationClasses: [this.specificationClass],
				specificationValuesClasses: [this.specificationValuesClass],
				specificationListClasses: [],
				actionsWrapClasses: [this.actionsWrapClass]
			};
			var specificationClasses = classes.specificationClasses;
			var wrapClasses = classes.wrapClasses;
			var innerWrapClasses = classes.innerWrapClasses;
			innerWrapClasses.push(this.getHeaderClass());
			if (!this.enabled) {
				wrapClasses.push(this.disabledClass);
			}
			if (this.useAdditionalSpecificationClass) {
				specificationClasses.push(this.additionalSpecificationClass);
			}
			return classes;
		},

		/**
		 * @inheritDoc Terrasoft.AbstractContainer#initRenderData
		 * @overridden
		 */
		initRenderData: function(renderData) {
			this.callParent(arguments);
			renderData.renderControl = this.renderControl;
			renderData.generateSpecificationControlMarkup = this.generateSpecificationControlMarkup;
			renderData.generateContainerListMarkup = this.generateContainerListMarkup;
		},

		/**
		 * ######## ######### ###### ## ###### ############## ### ######## ########.
		 * @protected
		 */
		updateSelectors: function() {
			var selectors = this.selectors = this.selectors || {};
			selectors.wrapEl = "#" + this.id + "-wrapEl";
			selectors.innerWrapEl = "#" + this.id + "-innerWrapEl";
			selectors.specificationEl = "#" + this.id + "-specificationContainer";
			selectors.valuesEl = "#" + this.id + "-valuesContainer";
			selectors.rowActionsEl = "#" + this.id + "-specification-row-actions";
		},

		/**
		 * @inheritDoc Terrasoft.Component#getTplData
		 * @overridden
		 */
		getTplData: function() {
			var tplData = this.callParent(arguments);
			Ext.apply(tplData, this.prepareTplClasses());
			tplData.generateSpecificationControlMarkup = this.generateSpecificationControlMarkup;
			tplData.generateContainerListMarkup = this.generateContainerListMarkup;
			tplData.hasActions = this.items && this.items.getCount() && this.isRowToolsVisible;
			this.updateSelectors(tplData);
			return tplData;
		},

		/**
		 * ##### ############ # ####### ### ########## #### #########.
		 * @param {String[]} buffer ##### ### ######### HTML.
		 * @param {Object} renderData ###### ########## ### #######.
		 * @protected
		 * @virtual
		 */
		generateSpecificationControlMarkup: function(buffer, renderData) {
			var self = renderData.self;
			var html = self.specification.generateHtml();
			Ext.DomHelper.generateMarkup(html, buffer);
		},

		/**
		 * ##### ############ # ####### ### ########## ######## ######.
		 * @param {String[]} buffer ##### ### ######### HTML.
		 * @param {Object} renderData ###### ########## ### #######.
		 * @protected
		 * @virtual
		 */
		generateContainerListMarkup: function(buffer, renderData) {
			var self = renderData.self;
			var html = self.valueContainerList.generateHtml();
			Ext.DomHelper.generateMarkup(html, buffer);
		},

		/**
		 * @inheritDoc Terrasoft.AbstractContainer#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			this.prepareControls();
		},

		/**
		 * ####### ######### ######## ########## ## ######### ####### #########.
		 * @protected
		 * @param {Object} config ###### ######### ######## ##########.
		 * @return {Terrasoft.Component} ####### ##########.
		 */
		createControl: function(config) {
			if (!config || !config.className) {
				config = {
					className: "Terrasoft.Container",
					items: []
				};
			}
			return Ext.create(config.className, config);
		},

		/**
		 * ####### ###### # ###### ## ########## ######### ##########
		 * ### ###### # ##############.
		 * # ####### ########## ######## ##### {@link Terrasoft.Component#added added}
		 * @protected
		 */
		prepareControls: function() {
			var specificationConfig = this.specificationConfig;
			this.specification = Ext.create(specificationConfig.className, specificationConfig);
			this.specification.added(this);
			var baseListConfig = {
				classes: {
					wrapClassName: [this.getListClass()]
				}
			};
			baseListConfig = Ext.apply(baseListConfig, this.containerListConfig);
			this.valueContainerList = Ext.create("Terrasoft.ContainerList", baseListConfig);
			this.valueContainerList.added(this);
			this.topContainer = this.createControl(this.topContainerConfig);
			this.topContainer.added(this);
			this.bottomContainer = this.createControl(this.bottomContainerConfig);
			this.bottomContainer.added(this);
		},

		/**
		 * ############# ######### ### ####### ########.
		 * @protected
		 * @param {Object} tools ###### ######## ### ####### ########.
		 */
		setToolItems: function(tools) {
			if (this.isRowToolsVisible) {
				this.items = tools;
				this.initItems();
				if (this.allowRerender()) {
					this.reRender();
				}
			}
		},

		/**
		 * ############# ##### ### ####### #########.
		 * @protected
		 * @param {Boolean} value #######, ############ ############# ############### #####.
		 */
		setAdditionalSpecificationClass: function(value) {
			if (this.useAdditionalSpecificationClass === value) {
				return;
			}
			this.useAdditionalSpecificationClass = value;
			var specificationContainer = this.specificationEl;
			if (this.rendered) {
				if (value) {
					specificationContainer.addCls(this.additionalSpecificationClass);
				} else {
					specificationContainer.removeCls(this.additionalSpecificationClass);
				}
			}
		},

		/**
		 * @inheritDoc Terrasoft.Bindable#getBindConfig
		 * @overridden
		 */
		getBindConfig: function() {
			var bindConfig = this.callParent(arguments);
			var specificationRowBindConfig = {
				items: {
					changeMethod: "setToolItems"
				},
				parameterViewModel: {
					changeMethod: "setParameterViewModel"
				},
				useAdditionalSpecificationClass: {
					changeMethod: "setAdditionalSpecificationClass"
				}

			};
			Ext.apply(specificationRowBindConfig, bindConfig);
			return specificationRowBindConfig;
		},

		/**
		 * ############# ###### ### ######### ######.
		 * @protected
		 * @param {Terrasoft.BaseSpecificationRowViewModel} model ######.
		 */
		setParameterViewModel: function(model) {
			if (this.parameterViewModel === model) {
				return;
			}
			this.parameterViewModel = model;
		},

		/**
		 * @inheritDoc Terrasoft.Bindable#bind
		 * @overridden
		 */
		bind: function() {
			this.callParent(arguments);
			this.valueContainerList.bind(this.model);
			this.specification.bind(this.parameterViewModel);
			this.topContainer.bind(this.model);
			this.bottomContainer.bind(this.model);
		},

		/**
		 * @inheritDoc Terrasoft.AbstractContainer#onDestroy
		 * @overridden
		 */
		onDestroy: function() {
			this.valueContainerList.destroy();
			this.specification.destroy();
			this.topContainer.destroy();
			this.bottomContainer.destroy();
			this.callParent(arguments);
		}

		//endregion
	});

	return Terrasoft.SpecificationRow;
});
