define("ProductConditionMatrixIntegerItemViewModel", ["ProductConditionMatrixIntegerItemViewModelResources",
		"ProductConditionIntegerItemViewModel"],
	function() {
		/**
		 * @class Terrasoft.ProductConditionMatrixIntegerItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionMatrixIntegerItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionMatrixIntegerItemViewModel",
			extend: "Terrasoft.ProductConditionIntegerItemViewModel",

			/**
			 * @inheritdoc Terrasoft.BaseModel#columns
			 * @overridden
			 */
			columns: {
				SpecTableValueX: {
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					columnPath: "SpecTableValueX"
				},
				SpecTableValueY: {
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					columnPath: "SpecTableValueY"
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#getToolsConfig
			 * @overridden
			 */
			getToolsConfig: function() {
				return [];
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#markerConverter
			 * @overridden
			 */
			markerConverter: function() {
				var markerValue = "Row-" + this.get("RowPosition") + "-Col-" + this.get("ValuePosition") + "-";
				var displayValue = this.callParent(arguments);
				return markerValue + displayValue;
			}
		});

		return Terrasoft.ProductConditionMatrixIntegerItemViewModel;
	});
