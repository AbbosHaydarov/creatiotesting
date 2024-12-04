define("BaseSpecificationItemViewModel", ["BaseSpecificationItemViewModelResources"],
	function(resources) {
	/**
	 * @class Terrasoft.BaseSpecificationItemViewModel
	 */
	Ext.define("Terrasoft.configuration.BaseSpecificationItemViewModel", {
		alternateClassName: "Terrasoft.BaseSpecificationItemViewModel",
		extend: "Terrasoft.BaseViewModel",

		Ext: null,
		Terrasoft: null,
		sandbox: null,

		/**
		 * ### ####### ### ########### ########.
		 * @protected
		 * @type {String}
		 */
		valueColumnName: null,

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#primaryColumnName
		 * @overridden
		 */
		primaryColumnName: "Id",

		/**
		 * #######, ###### ## ###### {@link Terrasoft.SpecificationValue} ######## ##### ##### #########.
		 * ############### # ###### {@link BaseSpecificationItemViewModel#getItemViewConfig}.
		 * @private
		 * @type {Boolean}
		 */
		focusAfterRender: true,

		/**
		 * ############## ###### ########## ######## ## ####### ########.
		 * @protected
		 * @param {Object} resourcesObj ###### ########.
		 */
		initResourcesValues: function(resourcesObj) {
			var resourcesSuffix = "Resources";
			Terrasoft.each(resourcesObj, function(resourceGroup, resourceGroupName) {
				resourceGroupName = resourceGroupName.replace("localizable", "");
				Terrasoft.each(resourceGroup, function(resourceValue, resourceName) {
					var viewModelResourceName = [resourcesSuffix, resourceGroupName, resourceName].join(".");
					this.set(viewModelResourceName, resourceValue);
				}, this);
			}, this);
		},

		/**
		 * #########, ##### ## ######### ######.
		 * @virtual
		 * @return {bool} #######, ##### ######### ### ###.
		 */
		canSave: function() {
			return !this.Ext.isEmpty(this.get("Value"));
		},

		/**
		 * ########### # ###### ######## ## #########.
		 * @protected
		 */
		setItemDefaultValues: function() {
			var defaultValues = this.get("DefaultValues");
			if (this.Ext.isArray(defaultValues)) {
				this.Terrasoft.each(defaultValues, function(defaultValue) {
					var propertyName = defaultValue.name;
					var value = defaultValue.value;
					if (!this.Ext.isEmpty(propertyName)) {
						this.set(propertyName, value);
					}
				}, this);
			}
		},

		/**
		 * ############## ######## View Model.
		 * @protected
		 */
		initValues: this.Terrasoft.emptyFn,

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#constructor
		 * @overridden
		 */
		constructor: function() {
			this.callParent(arguments);
			this.initValues();
			this.initResourcesValues(resources);
			this.setItemDefaultValues();
			this.subscribeOnColumnChange("Value", this.onValueChanged);
		},

		/**
		 * ########## ########## ######## ### ######### {@link Terrasoft.Label}.
		 * @protected
		 * @param  {Object} value ######, ########## ######## #########.
		 * @return {String} ########## ######## ### #########.
		 */
		getCaptionValue: function(value) {
			if (!this.Ext.isEmpty(value) && !this.Ext.isEmpty(value.displayValue)) {
				return value.displayValue;
			}
			return value;
		},

		/**
		 * ########## ###### ############ readControl ### {@link Terrasoft.SpecificationValue}.
		 * @protected
		 * @return {Object} ###### ############.
		 */
		getReadControlConfig: function() {
			return {
				"classes": {"labelClass": ["specification-value-label"]},
				"className": "Terrasoft.Label",
				"markerValue": {
					"bindTo": "Value",
					"bindConfig": {
						"converter": this.markerConverter
					}
				},
				"caption": {
					"bindTo": "Value",
					"bindConfig": {
						"converter": this.getCaptionValue
					}
				}
			};
		},

		/**
		 * ########## ###### ############ editControl ### {@link Terrasoft.SpecificationValue}.
		 * ################ # ###########.
		 * @abstract
		 * @protected
		 * @throws Terrasoft.NotImplementedException.
		 * @return {Object} ###### ############.
		 */
		getEditControlConfig: function() {
			var message = this.get("Resources.Strings.NotImplementedExceptionMessage");
			throw new Terrasoft.NotImplementedException({
				message: this.Ext.String.format(message, "\"getEditControlConfig\"", this.$className)
			});
		},

		/**
		 * ########## ###### ############ ###### #######. {@link Terrasoft.Button}.
		 * @protected
		 * @return {Object} ###### ############.
		 */
		getRemoveButtonConfig: function() {
			var config = null;
			if (!this.get("HideItems")) {
				config = {
					"className": "Terrasoft.Button",
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"tag": "remove",
					"click": {"bindTo": "onRemoveButtonClick"},
					"imageConfig": {"bindTo": "Resources.Images.RemoveButtonImage"}
				};
			}
			return config;
		},

		/**
		 * ########## ###### ######### ######## {@link Terrasoft.SpecificationValue}.
		 * @protected
		 * @return {Array} ######, ########## ####### ############ ### ######## {@link Terrasoft.SpecificationValue}.
		 */
		getToolsConfig: function() {
			var items = [];
			var removeButtonConfig = this.getRemoveButtonConfig();
			if (!this.Ext.isEmpty(removeButtonConfig)) {
				items.push(removeButtonConfig);
			}
			return items;
		},

		/**
		 * ######### ############ ####### ########.
		 * @protected
		 * @return {Object} ############ ####### ### ######## ##########.
		 */
		getMarkerConfig: function() {
			var markerConfig = {
				"bindTo": "Value",
				"bindConfig": {
					"converter": this.markerConverter
				}
			};
			return markerConfig;
		},

		/**
		 * ########## ######## data-item-marker ### ######## {@link Terrasoft.SpecificationValue}.
		 * protected
		 * @param {Object} value ######## #######.
		 * @return {String} ######## ### data-item-marker.
		 */
		markerConverter: function(value) {
			var displayValue = value && value.displayValue;
			return displayValue || value || this.get("Resources.Strings.DefMarkerValue");
		},

		/**
		 * ########## ###### ############ ### ########.
		 * @virtual
		 * @protected
		 * @return {Object} ###### ############ {@link Terrasoft.SpecificationValue}.
		 */
		getItemViewConfig: function() {
			return {
				"className": "Terrasoft.SpecificationValue",
				"placeholder": {"bindTo": "Resources.Strings.EmptyValueText"},
				"editControlConfig": this.getEditControlConfig(),
				"readControlConfig": this.getReadControlConfig(),
				"isReadMode": {"bindTo": "IsReadMode"},
				"focusAfterRender": this.focusAfterRender,
				"items": this.getToolsConfig()
			};
		},

		/**
		 * ########## ####### ######### ######### ######## Value.
		 * @protected
		 */
		onValueChanged: function(model, value, options) {
			if (options.silent || options.preventValidation) {
				return;
			}
			this.fireEvent("change", this, {
				event: "onChangeValue",
				arguments: {
					id: this.get("Id"),
					value: this.get("Value")
				}
			});
		},

		/**
		 * ############ ####### ## ###### ########.
		 * @protected
		 */
		onRemoveButtonClick: function() {
			this.fireEvent("change", this, {
				event: "onRemove",
				arguments: {id: this.get("Id")}
			});
		},

		/**
		 * ######### ####### # ######.
		 * protected
		 * @param  {String} columnName ######## #######.
		 */
		addEntityColumn: function(columnName) {
			var column = {
				columnPath: columnName,
				type: this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN
			};
			this.columns[columnName] = column;
		},

		/**
		 * ############# ####### ######.
		 * protected
		 */
		initColumns: function() {
			var entityColumns = [this.valueColumnName, this.primaryColumnName];
			entityColumns.forEach(function(columnName) {
				if (!this.Ext.isEmpty(columnName)) {
					this.addEntityColumn(columnName);
				}
			}, this);
		},

		/**
		 * ############# ######## ####### Value.
		 * @protected
		 */
		setItemValue: function() {
			var value = this.get("IsEmptyValue") ? null : this.get(this.valueColumnName);
			this.set("Value", value, {preventValidation: true});
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#loadEntity
		 * @overridden
		 */
		loadEntity: function(entity) {
			this.isNew = false;
			this.initColumns();
			this.set("IsReadMode", true, {silent: true});
			this.setColumnValues(entity, {preventValidation: true});
			this.setItemValue();
		}

	});

	return Terrasoft.BaseSpecificationItemViewModel;
});
