define("AxisParameterItemViewModel", ["SpecificationBuilderConstants", "AxisParameterItemViewModelResources",
	"ProductConditionParameterItemViewModel"],
	function(SpecificationBuilderConstants) {
		/**
		 * @class Terrasoft.AxisParameterItemViewModel
		 */
		Ext.define("Terrasoft.configuration.AxisParameterItemViewModel", {
			alternateClassName: "Terrasoft.AxisParameterItemViewModel",
			extend: "Terrasoft.ProductConditionParameterItemViewModel",

			/**
			 * @inheritdoc Terrasoft.ProductConditionParameterItemViewModel#getToolsConfig
			 * @overridden
			 */
			getToolsConfig: function() {
				return [{
					"className": "Terrasoft.Button",
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {"bindTo": "Resources.Images.ChangeTypeButtonImage"},
					"menu": {"items": {"bindTo": "ChangeTypeMenuItems"}},
					"markerValue": "ChangeViewType",
					"visible": {
						"bindTo": "Value",
						"bindConfig": {"converter": this.changeTypeVisibilityConverter}
					}
				}];
			},

			/**
			 * @inheritdoc Terrasoft.ProductConditionParameterItemViewModel#getSelectedValues
			 * @overridden
			 */
			getSelectedValues: function() {
				var selectedValues = [];
				var row = this.get("ParentItem");
				var matrix = row.get("ParentItem");
				var horizontal = this.getRowParameterValue("HorizontalRowViewModel", matrix);
				if (horizontal) {
					selectedValues.push(horizontal);
				}
				var vertical = this.getRowParameterValue("VerticalRowViewModel", matrix);
				if (vertical) {
					selectedValues.push(vertical);
				}
				var parentRow = matrix.get("ParentItem");
				var matrixParameter = parentRow.get("ParameterViewModel");
				var matrixParameterValue = matrixParameter.get("Value");
				selectedValues.push(matrixParameterValue.value);
				return selectedValues;
			},

			/**
			 * ######## ######## ######### # ######### ###.
			 * @protected
			 * @param {String} rowName ### ###### ### # #######.
			 * @param {Terrasoft.SpecificationMatrixBuilderViewModel} matrix ###### #######.
			 * @return {String} ############# ########## ######### # ###.
			 */
			getRowParameterValue: function(rowName, matrix) {
				var row = matrix.get(rowName);
				var parameter = row.get("ParameterViewModel");
				var parameterValue = parameter.get("Value");
				parameterValue = parameterValue && parameterValue.value;
				return parameterValue;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#markerConverter
			 * @overridden
			 */
			markerConverter: function() {
				var displayValue = this.callParent(arguments);
				var markerValue = this.get("AxisMarkerName") + "-Parameter-";
				return markerValue + displayValue;
			},

			/**
			 * @inheritdoc Terrasoft.ProductConditionParameterItemViewModel#getLookupFilters
			 * @overridden
			 */
			getLookupFilters: function() {
				var filterGroup = this.callParent(arguments);
				var dataTypeFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.NOT_EQUAL,
					"[SpecificationType:Id:Type].Id",
					SpecificationBuilderConstants.SpecificationType.Boolean);
				filterGroup.addItem(dataTypeFilter);
				return filterGroup;
			}

		});

		return Terrasoft.AxisParameterItemViewModel;
	});
