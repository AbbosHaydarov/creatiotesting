define("BaseItemRangeViewModel", ["BaseItemRangeViewModelResources", "BaseSpecificationItemViewModel",
	"css!BaseItemRangeViewModel"],
	function(resources) {
		/**
		 * @class Terrasoft.BaseItemRangeViewModel
		 */
		Ext.define("Terrasoft.configuration.BaseItemRangeViewModel", {
			alternateClassName: "Terrasoft.BaseItemRangeViewModel",
			extend: "Terrasoft.BaseSpecificationItemViewModel",

			/**
			 * ### ######## - Terrasoft.DataValueType.FLOAT ### Terrasoft.DataValueType.INTEGER.
			 * @type {Terrasoft.DataValueType}
			 */
			dataValueType: null,

			/**
			 * ###### ######## ### ######## {@link Terrasoft.HtmlControl}.
			 * @type {String}
			 */
			htmlControlTemplate: "<div class=\"spec-range-html-content\">" +
				"<div class=\"spec-range-prefix\">{0}</div><div class=\"spec-range-value\">{1}</div></div>",

			/**
			 * ### ####### ### ########### ############ ########.
			 * @protected
			 * @type {String}
			 */
			minValueColumnName: null,

			/**
			 * ### ####### ### ########### ############# ########.
			 * @protected
			 * @type {String}
			 */
			maxValueColumnName: null,

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#initValues
			 * @overridden
			 */
			initValues: function() {
				if (this.Ext.isEmpty(this.get("HideItems"))) {
					this.set("HideItems", true);
				}
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#initColumns
			 * @overridden
			 */
			initColumns: function() {
				var entityColumns = [this.minValueColumnName, this.maxValueColumnName, this.primaryColumnName,
					"IsEmptyMinValue", "IsEmptyMaxValue"];
				entityColumns.forEach(function(columnName) {
					if (!this.Ext.isEmpty(columnName)) {
						this.addEntityColumn(columnName);
					}
				}, this);
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#setItemValue
			 * @overridden
			 */
			setItemValue: function(callback, scope) {
				var minValue = this.get("IsEmptyMinValue") ? null : this.get(this.minValueColumnName);
				this.set("MinValue", minValue, {preventValidation: true});
				var maxValue = this.get("IsEmptyMaxValue") ? null : this.get(this.maxValueColumnName);
				this.set("MaxValue", maxValue, {preventValidation: true});
				if (this.Ext.isFunction(callback)) {
					callback.call(scope || this, this);
				}
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#canSave
			 * @overridden
			 */
			canSave: function() {
				return !this.Ext.isEmpty(this.get("MinValue")) || !this.Ext.isEmpty(this.get("MaxValue"));
			},

			/**
			 * ########## ###### ####### ### ######## ##########.
			 * @protected
			 * @return {Array} ###### #######.
			 */
			getWrapClasses: function() {
				return ["spec-range-container"];
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#getItemViewConfig
			 * @overridden
			 */
			getItemViewConfig: function() {
				return {
					"className": "Terrasoft.SpecificationValue",
					"readControlConfig": this.getReadControlConfig(),
					"editControlConfig": {
						"className": "Terrasoft.Container",
						"classes": {
							"wrapClassName": this.getWrapClasses()
						},
						"items": this.getInnerItems()
					},
					"canSwitchMode": false,
					"isReadMode": false,
					"focusAfterRender": true
				};
			},

			/**
			 * ########## ###### ######### ######### ### ########### # {@link Terrasoft.Container}.
			 * @protected
			 * @return {Array} ###### #########.
			 */
			getInnerItems: function() {
				var items = [
					this.getValueControlConfig({
						bindTo: "MinValue",
						wrapClassName: "range-value-wrap spec-range-left",
						prefix: resources.localizableStrings.MinValuePrefix,
						tabIndex: 1
					}),
					this.getValueControlConfig({
						bindTo: "MaxValue",
						wrapClassName: "range-value-wrap spec-range-right",
						prefix: resources.localizableStrings.MaxValuePrefix,
						tabIndex: 1
					})
				];
				var removeButtonConfig = this.getRemoveButtonConfig();
				if (!this.Ext.isEmpty(removeButtonConfig)) {
					removeButtonConfig.classes = {wrapperClass: "remove-range-button"};
					items.push(removeButtonConfig);
				}
				return items;
			},

			/**
			 * ########## ###### ############ {@link Terrasoft.SpecificationValue} ### ########## ######## ##########.
			 * @protected
			 * @param {Object} config ###### ############ ######.
			 * @param {String} config.wrapClassName ###### wrap-########.
			 * @return {Object} ###### ############.
			 */
			getValueControlConfig: function(config) {
				return {
					"className": "Terrasoft.SpecificationValue",
					"wrapClass": config.wrapClassName,
					"readControlConfig": this.getValueReadControlConfig(config),
					"editControlConfig": this.getValueEditControlConfig(config),
					"tabIndex": config.tabIndex
				};
			},

			/**
			 * ########## ###### ############ ### ###### ######.
			 * @virtual
			 * @protected
			 * @param {Object} config ###### ############ ######.
			 * @param {String} config.bindTo ######## ######## ########.
			 * @param {String} config.prefix #####, ####### ########## ##### #########.
			 * @return {Object} ###### ############.
			 */
			getValueReadControlConfig: function(config) {
				return {
					"className": "Terrasoft.HtmlControl",
					"markerValue": this.getMarkerConfig(config),
					"htmlContent": {
						"bindTo": config.bindTo,
						"bindConfig": {
							"converter": this.htmlContentConverter.bind(this, config.prefix)
						}
					}
				};
			},

			/**
			 * @inheritDoc Terrasoft.BaseSpecificationItemViewModel#getMarkerConfig
			 * @overridden
			 */
			getMarkerConfig: function(config) {
				var markerConfig = {
					"bindTo": config.bindTo,
					"bindConfig": {
						"converter": this.markerConverter.bind(this, config.prefix)
					}
				};
				return markerConfig;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#markerConverter
			 * @overridden
			 */
			markerConverter: function(prefix, value) {
				var displayValue = value && value.displayValue;
				var markerValue = displayValue || value;
				return markerValue ? prefix + "-" + markerValue : prefix;
			},

			/**
			 * ########## ###### ############ ### ###### ##############.
			 * @abstract
			 * @protected
			 * @throws Terrasoft.NotImplementedException.
			 */
			getValueEditControlConfig: function() {
				var message = this.get("Resources.Strings.NotImplementedExceptionMessage");
				throw new Terrasoft.NotImplementedException({
					message: this.Ext.String.format(message, "\"getValueEditControlConfig\"", this.$className)
				});
			},

			/**
			 * ######### ######## ### ######## {@link Terrasoft.HtmlControl}.
			 * @protected
			 * @param {String} prefix #######, ####### ##### ######## # ######## ##### #########.
			 * @param {Number} value ########.
			 * @return {String} ##### ### ########### ###### {@link Terrasoft.HtmlControl}.
			 */
			htmlContentConverter: function(prefix, value) {
				var formattedValue = this.Terrasoft.getFormattedNumberValue(value, {type: this.dataValueType});
				return this.Ext.String.format(this.htmlControlTemplate, prefix, formattedValue);
			}

		});

		return Terrasoft.BaseItemRangeViewModel;
	});
