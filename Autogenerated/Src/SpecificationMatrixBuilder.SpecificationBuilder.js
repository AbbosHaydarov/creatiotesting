define("SpecificationMatrixBuilder", ["SpecificationRow", "css!SpecificationMatrixBuilder"],
	function() {
		/**
		 * @class Terrasoft.controls.SpecificationMatrixBuilder
		 * ##### ######## ########## ### ####### ######### ######## ############ ##########.
		 */
		Ext.define("Terrasoft.controls.SpecificationMatrixBuilder", {
			extend: "Terrasoft.AbstractContainer",
			alternateClassName: "Terrasoft.SpecificationMatrixBuilder",

			//region Properties: Private

			/**
			 * ###### ########## ## ###########.
			 * @private
			 * @type {Terrasoft.SpecificationRow}
			 */
			horizontalRow: null,

			/**
			 * ###### ########## ## #########.
			 * @private
			 * @type {Terrasoft.SpecificationRow}
			 */
			verticalRow: null,

			/**
			 * ####### ########.
			 * @private
			 * @type {Terrasoft.ContainerList}
			 */
			valueContainerList: null,

			//endregion Properties: Private

			//region Properties: Public

			/**
			 * ######### ##### ## ##########.
			 * @public
			 * @type {Terrasoft.BaseViewModelCollection}
			 */
			matrixCollection: null,

			/**
			 * ######## ###### ######, ####### ########## ############ {@link Terrasoft.ContainerList} ### #######
			 * ########.
			 * @public
			 * @type {String}
			 */
			onGetMatrixItemConfig: null,

			/**
			 * ###### ###### ########## ## ###########.
			 * @type {Terrasoft.BaseSpecificationRowViewModel}
			 */
			horizontalRowViewModel: null,

			/**
			 * ###### ############ ######### ### ###### ## ###########.
			 * @type {Object}
			 */
			horizontalSpecificationConfig: null,

			/**
			 * ###### ###### ########## ## #########.
			 * @type {Terrasoft.BaseSpecificationRowViewModel}
			 */
			verticalRowViewModel: null,

			/**
			 * ###### ############ ######### ### ###### ## #########.
			 * @type {Object}
			 */
			verticalSpecificationConfig: null,

			/**
			 * ######### ######## ##########.
			 * @public
			 * @type {String}
			 */
			caption: null,

			/**
			 * ######### ######## # #######.
			 * @public
			 * @type {Ext.util.MixedCollection}
			 */
			columnTools: null,

			/**
			 * ######### ######## # ######.
			 * @public
			 * @type {Ext.util.MixedCollection}
			 */
			rowTools: null,

			/**
			 * ######### SpecificationRow ## ###########.
			 * @public
			 * @type {Object}
			 */
			horizontalRowConfig: null,

			/**
			 * ######### SpecificationRow ## #########.
			 * @public
			 * @type {Object}
			 */
			verticalRowConfig: null,

			/**
			 * ######### ContainerList.
			 * @public
			 * @type {Object}
			 */
			containerListConfig: null,

			//endregion Properties: Public

			//region Properties: Protected

			/* jshint ignore:start */
			// jscs:disable
			tpl: [
				'<div id="{id}-wrapEl" class="{wrapClasses}" style="{wrapStyles}" tabindex="{tabIndex}">',
				'<div id="{id}-leftWrapEl" class="{leftWrapClasses}" style="{leftWrapStyles}" >',
				'<div id="{id}-captionContainer" class="{captionContainerClasses}" style="{captionContainerStyles}">',
				'<label id="{id}-caption" class="{captionClasses}" style="{captionStyles}">',
				'{caption}',
				'</label>',
				'</div>',
				'<div id="{id}-verticalRowContainer" class="{verticalRowClasses}" style="{verticalRowStyles}">',
				'{%this.generateVerticalRowControlMarkup(out, values)%}',
				'</div>',
				'</div>',
				'<div id="{id}-rightWrapEl" class="{rightWrapClasses}" style="{rightWrapStyles}">',
				'<div id="{id}-horizontalRowContainer" class="{horizontalRowClasses}" style="{horizontalRowStyles}">',
				'{%this.generateHorizontalRowControlMarkup(out, values)%}',
				'</div>',
				'<div id="{id}-valuesContainer" class="{specificationValuesClasses}" style="{specificationValuesStyles}">',
				'{%this.generateContainerListMarkup(out, values)%}',
				'</div>',
				'</div>',
				'</div>'
			],
			// jscs:enable
			/* jshint ignore:end */

			/**
			 * ### ######## ######, ####### ######## ###############.
			 * @type {String}
			 */
			idProperty: "Id",

			/**
			 * ####### ####### ###### ##### #######.
			 * @type {Number}
			 */
			rightContainerScroll: null,

			/**
			 * Css-##### wrap-########.
			 * @type {String}
			 */
			wrapClass: "specification-matrix-wrap",

			/**
			 * Css-##### ######### ######## ##########.
			 * @type {String}
			 */
			captionClass: "caption",

			/**
			 * Css-##### ########## # ##########.
			 * @type {String}
			 */
			captionContainerClass: "captionContainer",

			/**
			 * Css-##### ####### ##########.
			 * @type {String}
			 */
			rightWrapClass: "rightContainer",

			/**
			 * Css-##### ###### ##########.
			 * @type {String}
			 */
			leftWrapClass: "leftContainer",

			/**
			 * Css-##### ########## ## ##########.
			 * @type {String}
			 */
			valuesContainerClass: "valuesContainer",

			/**
			 * Css-##### ### ###### # ###### ######.
			 * @type {String}
			 */
			labelClass: "specification-value-label",

			//endregion Properties: Protected

			//region Methods: Protected

			/**
			 * ########## ####### ######### ####### ###### #########.
			 * @protected
			 */
			onRightWrapElScroll: function() {
				var rightContainerScroll = this.rightWrapEl.dom.scrollLeft;
				if (rightContainerScroll !== this.rightContainerScroll) {
					this.rightContainerScroll = rightContainerScroll;
					this.fireEvent("rightContainerScrollChanged", this.rightContainerScroll, this);
				}
			},

			/**
			 * @inheritDoc Terrasoft.AbstractContainer#init
			 * @overridden
			 */
			init: function() {
				this.callParent(arguments);
				this.horizontalRowConfig = this.horizontalRowConfig || this.getDefaultHorizontalRowConfig();
				this.verticalRowConfig = this.verticalRowConfig || this.getDefaultVerticalRowConfig();
				this.containerListConfig = this.containerListConfig || this.getDefaultValuesContainerListConfig();
				this.prepareControls();
				this.addEvents(
					/**
					 * @event rightContainerScrollChanged
					 * C###### ######### ####### ###### #########.
					 */
					"rightContainerScrollChanged"
				);
			},

			/**
			 * @inheritDoc Terrasoft.Component#initDomEvents
			 * @overridden
			 */
			initDomEvents: function() {
				this.callParent(arguments);
				this.rightWrapEl.on("scroll", this.onRightWrapElScroll, this);
			},

			/**
			 * ############ ######## ######### # ############ ########.
			 * @protected
			 * @param {Terrasoft.DataValueType.LOOKUP} value ######## #########.
			 * @return {String} ######## ### ###########.
			 */
			valueConverter: function(value) {
				return value && value.displayValue;
			},

			/**
			 * ########## ############ ##-######### ### ######### ######.
			 * @protected
			 * @return {Object} ############ {@link Terrasoft.SpecificationValue}.
			 */
			getDefaultSpecificationConfig: function() {
				return {
					"className": "Terrasoft.SpecificationValue",
					"readControlConfig": {
						"className": "Terrasoft.Label",
						"classes": {"labelClass": [this.labelClass]},
						"caption": {
							"bindTo": "Value",
							"bindConfig": {"converter": this.valueConverter}
						}
					},
					"placeholder": {"bindTo": "Resources.Strings.EmptyValueText"},
					"editControlConfig": {
						"className": "Terrasoft.ComboBoxEdit",
						"value": {"bindTo": "Value"},
						"list": {"bindTo": "ValueList"},
						"prepareList": {"bindTo": "prepareList"}
					},
					"focusAfterRender": true
				};
			},

			/**
			 * ########## ############ ##-######### ### ###### ########## ## ###########.
			 * @protected
			 * @return {Object} ############ SpecificationRow.
			 */
			getDefaultHorizontalRowConfig: function() {
				var defSpecificationConfig = this.horizontalSpecificationConfig || this.getDefaultSpecificationConfig();
				var config = {
					"className": "Terrasoft.SpecificationRow",
					"headerPosition": Terrasoft.controls.SpecificationRowEnums.HeaderPosition.TOP,
					"valueDirection": Terrasoft.controls.SpecificationRowEnums.ValueDirection.HORIZONTAL,
					"specificationConfig": defSpecificationConfig,
					"parameterViewModel": {"bindTo": "ParameterViewModel"},
					"containerListConfig": {
						"itemPrefix": "row-value",
						"idProperty": this.idProperty,
						"collection": {"bindTo": "RowValuesCollection"},
						"onGetItemConfig": {"bindTo": "getRowItemViewConfig"}
					},
					"isRowToolsVisible": false,
					"items": {
						"bindTo": "ToolItemsConfig"
					}
				};
				if (!Ext.isEmpty(this.columnTools)) {
					Ext.apply(config, {"items": this.columnTools});
				}
				return config;
			},

			/**
			 * ########## ############ ##-######### ### ###### ########## ## #########.
			 * @protected
			 * @return {Object} ############ SpecificationRow.
			 */
			getDefaultVerticalRowConfig: function() {
				var defSpecificationConfig = this.verticalSpecificationConfig || this.getDefaultSpecificationConfig();
				var config = {
					"className": "Terrasoft.SpecificationRow",
					"headerPosition": Terrasoft.controls.SpecificationRowEnums.HeaderPosition.TOP,
					"valueDirection": Terrasoft.controls.SpecificationRowEnums.ValueDirection.VERTICAL,
					"specificationConfig": defSpecificationConfig,
					"parameterViewModel": {"bindTo": "ParameterViewModel"},
					"containerListConfig": {
						"itemPrefix": "row-value",
						"idProperty": this.idProperty,
						"collection": {"bindTo": "RowValuesCollection"},
						"onGetItemConfig": {"bindTo": "getRowItemViewConfig"}
					},
					"isRowToolsVisible": false,
					"items": {
						"bindTo": "ToolItemsConfig"
					}
				};
				if (!Ext.isEmpty(this.rowTools)) {
					Ext.apply(config, {"items": this.rowTools});
				}
				return config;
			},

			/**
			 * ########## ############ ##-######### ### ####### ########.
			 * @protected
			 * @return {Object} ############ ContainerList.
			 */
			getDefaultValuesContainerListConfig: function() {
				return {
					"className": "Terrasoft.ContainerList",
					"itemPrefix": "matrix-value",
					"idProperty": this.idProperty,
					"collection": {"bindTo": this.bindings.matrixCollection.modelItem},
					"onGetItemConfig": {"bindTo": "onGetMatrixItemConfig"}
				};
			},

			/**
			 * ####### ########## Terrasoft.SpecificationRow ### ########## # Terrasoft.ContainerList ### ########.
			 * @protected
			 */
			prepareControls: function() {
				this.horizontalRow = Ext.create(this.horizontalRowConfig.className, this.horizontalRowConfig);
				this.horizontalRow.added(this);
				this.verticalRow = Ext.create(this.verticalRowConfig.className, this.verticalRowConfig);
				this.verticalRow.added(this);
				this.valueContainerList = Ext.create(this.containerListConfig.className, this.containerListConfig);
				this.valueContainerList.added(this);
			},

			/**
			 * ############# ######## ####### ### ###### ##### #######.
			 * @protected
			 * @param {Number} scrollValue ######## ####### #######.
			 */
			setRightContainerScroll: function(scrollValue) {
				scrollValue = scrollValue || 0;
				if (this.rendered) {
					this.rightWrapEl.dom.scrollLeft = this.rightContainerScroll = scrollValue;
				}
			},

			/**
			 * ########## ############ ######## # ######. ######### ######### ####### {@link Terrasoft.Bindable}.
			 * @overridden
			 */
			getBindConfig: function() {
				var bindConfig = this.callParent(arguments);
				var controlBindConfig = {
					caption: {
						changeMethod: "setCaption"
					},
					matrixCollection: {},
					horizontalRowViewModel: {
						changeMethod: "setHorizontalRowViewModel"
					},
					verticalRowViewModel: {
						changeMethod: "setVerticalRowViewModel"
					},
					rightContainerScroll: {
						changeEvent: "rightContainerScrollChanged",
						changeMethod: "setRightContainerScroll"
					}
				};
				Ext.apply(controlBindConfig, bindConfig);
				return controlBindConfig;
			},

			/**
			 * ############# ###### ### ###### ########## ## ###########.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationRowViewModel} model ######.
			 */
			setHorizontalRowViewModel: function(model) {
				if (this.horizontalRowViewModel === model) {
					return;
				}
				this.horizontalRowViewModel = model;
			},

			/**
			 * ############# ###### ### ###### ########## ## #########.
			 * @protected
			 * @param {Terrasoft.BaseSpecificationRowViewModel} model ######.
			 */
			setVerticalRowViewModel: function(model) {
				if (this.verticalRowViewModel === model) {
					return;
				}
				this.verticalRowViewModel = model;
			},

			/**
			 * ############# ######### ######## ##########.
			 * @protected
			 * @param {String} caption #########.
			 */
			setCaption: function(caption) {
				if (this.caption === caption) {
					return;
				}
				this.caption = caption;
				if (this.allowRerender()) {
					this.reRender();
				}
			},

			/**
			 * ######### #########, ###### ## ######, ############## ### ######## ########.
			 * @protected
			 */
			updateSelectors: function() {
				var selectors = this.selectors = this.selectors || {};
				selectors.wrapEl = "#" + this.id + "-wrapEl";
				selectors.rightWrapEl = "#" + this.id + "-rightWrapEl";
			},

			/**
			 * ######### ###### ###### # #######.
			 * @protected
			 * @param {Object} tplData ###### ########## ####### ########## ######## ##########.
			 */
			applyTplClasses: function(tplData) {
				var classes = {
					wrapClasses: [this.wrapClass],
					captionContainerClasses: [this.captionContainerClass],
					captionClasses: [this.captionClass],
					leftWrapClasses: [this.leftWrapClass],
					rightWrapClasses: [this.rightWrapClass],
					specificationValuesClasses: [this.valuesContainerClass]
				};
				Ext.apply(tplData, classes);
			},

			/**
			 * ############ # ####### ### ########## ###### ########## ## ###########.
			 * @protected
			 * @virtual
			 * @param {String[]} buffer ##### ### ######### HTML.
			 * @param {Object} renderData ###### ########## ### #######.
			 */
			generateHorizontalRowControlMarkup: function(buffer, renderData) {
				var self = renderData.self;
				var html = self.horizontalRow.generateHtml();
				Ext.DomHelper.generateMarkup(html, buffer);
			},

			/**
			 * ############ # ####### ### ########## ###### ########## ## #########.
			 * @protected
			 * @virtual
			 * @param {String[]} buffer ##### ### ######### HTML.
			 * @param {Object} renderData ###### ########## ### #######.
			 */
			generateVerticalRowControlMarkup: function(buffer, renderData) {
				var self = renderData.self;
				var html = self.verticalRow.generateHtml();
				Ext.DomHelper.generateMarkup(html, buffer);
			},

			/**
			 * ############ # ####### ### ########## ######## #######.
			 * @protected
			 * @virtual
			 * @param {String[]} buffer ##### ### ######### HTML.
			 * @param {Object} renderData ###### ########## ### #######.
			 */
			generateContainerListMarkup: function(buffer, renderData) {
				var self = renderData.self;
				var html = self.valueContainerList.generateHtml();
				Ext.DomHelper.generateMarkup(html, buffer);
			},

			/**
			 * @inheritDoc Terrasoft.Component#getTplData
			 * @overridden
			 */
			getTplData: function() {
				var tplData = this.callParent(arguments);
				this.applyTplClasses(tplData);
				tplData.generateHorizontalRowControlMarkup = this.generateHorizontalRowControlMarkup;
				tplData.generateVerticalRowControlMarkup = this.generateVerticalRowControlMarkup;
				tplData.generateContainerListMarkup = this.generateContainerListMarkup;
				tplData.caption = this.caption;
				this.updateSelectors(tplData);
				return tplData;
			},

			/**
			 * @inheritDoc Terrasoft.Bindable#bind
			 * @overridden
			 */
			bind: function() {
				this.callParent(arguments);
				this.horizontalRow.bind(this.horizontalRowViewModel);
				this.verticalRow.bind(this.verticalRowViewModel);
				this.valueContainerList.bind(this.model);
			},

			/**
			 * @inheritDoc Terrasoft.AbstractContainer#onDestroy
			 * @overridden
			 */
			onDestroy: function() {
				this.horizontalRow.destroy();
				this.verticalRow.destroy();
				this.valueContainerList.destroy();
				this.callParent(arguments);
			}

			//endregion Methods: Protected
		});

		return Terrasoft.SpecificationMatrixBuilder;
	});
