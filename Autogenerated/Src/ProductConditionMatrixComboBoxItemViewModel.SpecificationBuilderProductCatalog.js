define("ProductConditionMatrixComboBoxItemViewModel", ["ProductConditionComboBoxItemViewModel"],
	function() {
		/**
		 * @class Terrasoft.ProductConditionMatrixComboBoxItemViewModel
		 */
		Ext.define("Terrasoft.configuration.ProductConditionMatrixComboBoxItemViewModel", {
			alternateClassName: "Terrasoft.ProductConditionMatrixComboBoxItemViewModel",
			extend: "Terrasoft.ProductConditionComboBoxItemViewModel",

			focusAfterRender: false,

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
			 * @inheritDoc Terrasoft.BaseComboBoxItemViewModel#prepareList
			 * @overridden
			 */
			prepareList: function(value, list) {
				var schemaName = "SpecificationListItem";
				var specification = this.get("Specification");
				var filterGroup = this.Terrasoft.createFilterGroup();
				filterGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "Specification", specification.value));
				filterGroup.addItem(this.getUniqueFilter());
				var config = {
					value: value,
					list: list,
					schemaName: schemaName,
					columnNames: null,
					filter: filterGroup
				};
				this.fillList(config);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#markerConverter
			 * @overridden
			 */
			markerConverter: function() {
				var markerValue = "Row-" + this.get("RowPosition") + "-Col-" + this.get("ValuePosition") + "-";
				var displayValue = this.callParent(arguments);
				return markerValue + displayValue;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSpecificationItemViewModel#getRemoveButtonConfig
			 * @overridden
			 */
			getRemoveButtonConfig: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.ProductConditionComboBoxItemViewModel#getUniqueFilter
			 * @overridden
			 */
			getUniqueFilter: function() {
				return this.Terrasoft.createFilterGroup();
			}
		});

		return Terrasoft.ProductConditionMatrixComboBoxItemViewModel;
	});
