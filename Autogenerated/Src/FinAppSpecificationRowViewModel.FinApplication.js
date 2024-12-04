define("FinAppSpecificationRowViewModel", ["SpecificationBankConstants", "SpecificationBuilderConstants",
		"BaseFieldRowViewModel"
	],
	function(SpecificationBankConstants, SpecificationBuilderConstants) {
		/**
		 * @class Terrasoft.configuration.FinAppSpecificationRowViewModel
		 */
		Ext.define("Terrasoft.configuration.FinAppSpecificationRowViewModel", {
			extend: "Terrasoft.BaseFieldRowViewModel",
			alternateClassName: "Terrasoft.FinAppSpecificationRowViewModel",

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.setValidation();
				this.setValidationConfig();
				this.callParent([function() {
					this.Ext.callback(callback, scope);
				}, this]);
			},

			/**
			 * Sets validation column configuration.
			 * @protected
			 */
			setValidationConfig: function() {
				this.addColumnValidator("FloatValue", this.validateRangeValue);
				this.addColumnValidator("IntegerValue", this.validateRangeValue);
				this.addColumnValidator("FloatValue", this.validateIsInPossibleValues);
				this.addColumnValidator("IntegerValue", this.validateIsInPossibleValues);
				this.addColumnValidator("SpecificationListItem", this.validateRequiredValue);
				this.addColumnValidator("TextValue", this.validateRequiredValue);
				this.addColumnValidator("FloatValue", this.validateRequiredValue);
				this.addColumnValidator("IntegerValue", this.validateRequiredValue);
			},

			/**
			 * Returns configuration object for number formatting.
			 * @param {Object} column Column object that number value should be setting for.
			 * @return {Object} Number display config.
			 */
			getDisplayNumberConfig: function(column) {
				var cultureSettings = this.Terrasoft.Resources.CultureSettings;
				return {
					"decimalPrecision": column.precision || 0,
					"decimalSeparator": cultureSettings.decimalSeparator,
					"useThousandSeparator": true,
					"thousandSeparator": cultureSettings.thousandSeparator,
					"numberGroupSizes": cultureSettings.numberGroupSizes
				};
			},

			/**
			 * Validates that the value included in the interval.
			 * @protected
			 * @param {Object} columnValue Value of column.
			 * @param {Object} column Column object.
			 * @return {Object} Validation object.
			 */
			validateRangeValue: function(columnValue, column) {
				var invalidMessage = "";
				var type = this.getValueType();
				var isRange = this.getIsRange();
				var needValidation =
					isRange &&
					type === column.name &&
					!this.get("IsMatrixValue");
				if (needValidation) {
					var minValue = this.get("Min" + column.name);
					var maxValue = this.get("Max" + column.name);
					var isValid =
						!this.Ext.isEmpty(minValue) &&
						!this.Ext.isEmpty(maxValue) &&
						this.Ext.isNumber(columnValue) &&
						columnValue >= minValue &&
						columnValue <= maxValue;
					if (!isValid) {
						var config = this.getDisplayNumberConfig(column);
						invalidMessage = this.Terrasoft.getFormattedNumberValue(minValue, config) +
							" - " + this.Terrasoft.getFormattedNumberValue(maxValue, config);
					}
				}
				return {
					invalidMessage: invalidMessage
				};
			},

			/**
			 * Validates that the field value is in possible values.
			 * @protected
			 * @param {Object} columnValue Value of column.
			 * @param {Object} column Column object.
			 * @return {Object} Validation object.
			 */
			validateIsInPossibleValues: function(columnValue, column) {
				var invalidMessage = "";
				var columnName = column.name;
				var type = this.getValueType();
				var possibleValues = this.get("PossibleValues");
				var isNumberValue = type === "IntegerValue" || type === "FloatValue";
				var needValidation =
					isNumberValue &&
					type === columnName &&
					!this.Ext.isEmpty(possibleValues) &&
					!this.getIsRange();
				if (needValidation) {
					var isValid = possibleValues.indexOf(columnValue) !== -1;
					if (!isValid) {
						var config = this.getDisplayNumberConfig(column);
						invalidMessage = possibleValues.sort(function(a, b) {
							return a - b;
						}).map(function(possibleValue) {
							return this.Terrasoft.getFormattedNumberValue(possibleValue, config);
						}).join("; ");
					}
				}
				return {
					invalidMessage: invalidMessage
				};
			},

			/**
			 * Validates that the required field is filled in.
			 * @protected
			 * @param {Object} columnValue Value of column.
			 * @param {Object} column Column object.
			 * @return {Object} Validation object.
			 */
			validateRequiredValue: function(columnValue, column) {
				var invalidMessage = "";
				var type = this.getValueType();
				var needValidation =
					type === column.name &&
					!this.get("IsCustom");
				if (needValidation) {
					if (this.Ext.isString(columnValue)) {
						columnValue = this.Ext.String.trim(columnValue);
					}
					var isValid = !this.Ext.isEmpty(columnValue);
					if (!isValid) {
						var isMatrixValue = this.get("IsMatrixValue");
						invalidMessage = isMatrixValue
							? this.get("Resources.Strings.ImpossibleDetermineValueError")
							: this.Terrasoft.Resources.BaseViewModel.columnRequiredValidationMessage;
					}
				}
				return {
					invalidMessage: invalidMessage
				};
			},

			/**
			 * @inheritdoc Terrasoft.BaseFieldRowViewModel#setConfigLookupDefaultValues
			 * @overridden
			 */
			setConfigLookupDefaultValues: function(callback, scope) {
				if (this.get("IsCustom")) {
					this.callParent(arguments);
					return;
				}
				this.Ext.callback(callback, scope);
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
			 * @overridden
			 */
			getLookupQuery: function(filterValue, columnName) {
				var esq = this.callParent(arguments);
				this.setSpecificationListItemESQFilters(esq.filters, columnName);
				return esq;
			},

			/**
			 * Sets Entity schema query filters.
			 * @protected
			 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
			 * @param {String} columnName The name of column.
			 */
			setSpecificationListItemESQFilters: function(filters, columnName) {
				var specification = this.get("Specification");
				if (columnName === "SpecificationListItem" && this.Ext.isObject(specification)) {
					var specificationFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"Specification", specification.value);
					filters.add("SpecificationFilter", specificationFilter);
					var possibleValues = this.get("PossibleValues");
					if (!this.Ext.isEmpty(possibleValues)) {
						var idFilter = this.Terrasoft.createColumnInFilterWithParameters("Id", possibleValues);
						filters.add("IdFilter", idFilter);
					}
				}
			},

			/**
			 * Sets control validation.
			 * @protected
			 */
			setValidation: function() {
				var type = this.getValueType();
				if (this.Ext.isEmpty(type)) {
					return;
				}
				if (this.getIsRange()) {
					var columnValue = this.get(type);
					var column = this.columns[type];
					var info = this.validateRangeValue(columnValue, column);
					if (!Ext.isEmpty(info.invalidMessage)) {
						this.setValidationInfo(type, false, info.invalidMessage);
					}
				}
			},

			/**
			 * Returns control visible value.
			 * @protected
			 * @param {String} [tag] Control tag.
			 * @return {Boolean} Flag that indicates that control is visible.
			 */
			getControlVisible: function(tag) {
				var type = this.getValueType();
				return tag === type;
			},

			/**
			 * Returns control enabled value.
			 * @protected
			 * @return {Boolean} Flag that indicates that control is enabled.
			 */
			getControlEnable: function() {
				var isMatrix = this.get("IsMatrixValue");
				var isCustom = this.get("IsCustom");
				var possibleValues = this.get("PossibleValues");
				var hasSinglePossibleValue = !this.Ext.isEmpty(possibleValues) && possibleValues.length === 1;
				return (!isMatrix && !hasSinglePossibleValue) || isCustom;
			},

			/**
			 * Returns control required value.
			 * @protected
			 * @return {Boolean} Flag that indicates that control is required.
			 */
			getControlRequired: function() {
				return !this.get("IsCustom");
			},

			/**
			 * Returns visibility of delete button.
			 * @protected
			 * @return {Boolean} Flag that indicates that control has a visible delete button.
			 */
			getDeleteButtonVisible: function() {
				return this.get("IsCustom");
			},

			//endregion

			//Methods: Public

			/**
			 * Returns value type.
			 * @public
			 * @return {String} Value type.
			 */
			getValueType: function() {
				var dataType = this.get("SpecificationType") || {};
				var type;
				switch (dataType.value) {
					case SpecificationBuilderConstants.SpecificationType.Lookup:
						type = "SpecificationListItem";
						break;
					case SpecificationBuilderConstants.SpecificationType.Text:
						type = "TextValue";
						break;
					case SpecificationBuilderConstants.SpecificationType.Float:
						type = "FloatValue";
						break;
					case SpecificationBuilderConstants.SpecificationType.Integer:
						type = "IntegerValue";
						break;
					case SpecificationBuilderConstants.SpecificationType.Boolean:
						type = "BooleanValue";
						break;
					default:
						break;
				}
				return type;
			},

			/**
			 * Returns flag that value type is lookup.
			 * @public
			 * @return {Boolean} Flag that value type is lookup.
			 */
			getIsLookupType: function() {
				var valueType = this.getValueType();
				return valueType === "SpecificationListItem";
			},

			/**
			 * Returns flag indicating that the view model represents field for entering a value from some range.
			 * @public
			 * @return {Boolean} Flag indicating that the view type is "RangeValue".
			 */
			getIsRange: function() {
				return !this.getIsLookupType() &&
					this.get("CurrentType") === SpecificationBuilderConstants.ViewType.RangeValue;
			}

			//endregion

		});

		return Terrasoft.FinAppSpecificationRowViewModel;
	});
