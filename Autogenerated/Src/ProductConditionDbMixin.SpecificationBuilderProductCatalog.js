define("ProductConditionDbMixin", [], function() {
	Ext.define("Terrasoft.configuration.mixins.ProductConditionDbMixin", {

		alternateClassName: "Terrasoft.ProductConditionDbMixin",

		/**
		 * ######### ###### (## #########) ########## ########.
		 * @protected
		 * @return  {Terrasoft.BaseQuery} ###### ########## ########
		 */
		getDefSaveQuery: function() {
			var parentItem = this.get("ParentItem");
			var parameterViewModel = parentItem.get("ParameterViewModel");
			var specification = parameterViewModel.get("Value")
				? parameterViewModel.get("Value")
				: this.get("Specification");
			var specificationId = specification.value;
			var productConditionId = this.get("ProductCondition");
			var specificationInConditionTypeId = this.get("SpecificationInConditionType");
			var opportunityConditionId = this.get("OpportunityCondition");
			var specTableValueXId = this.get("SpecTableValueX");
			var specTableValueYId = this.get("SpecTableValueY");
			var query = null;
			if (this.isNew) {
				query = this.getInsertQuery();
			} else {
				query = this.getUpdateQuery();
				query.enablePrimaryColumnFilter(this.get(this.primaryColumnName));
			}
			query.columnValues.clear();
			query.setParameterValue(this.primaryColumnName, this.get("Id"), this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("ProductCondition", productConditionId, this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("Specification", specificationId, this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("SpecInConditionType", specificationInConditionTypeId,
				this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("OpportunityCondition", opportunityConditionId, this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("RowPosition", this.get("RowPosition"), this.Terrasoft.DataValueType.INTEGER);
			query.setParameterValue("ValuePosition", this.get("ValuePosition"), this.Terrasoft.DataValueType.INTEGER);
			query.setParameterValue("SpecTableValueX", specTableValueXId, this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("SpecTableValueY", specTableValueYId, this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("CurrentType", parameterViewModel.get("CurrentType"),
				this.Terrasoft.DataValueType.TEXT);
			query.setParameterValue("IsEmptyValue", this.Ext.isEmpty(this.get("Value")),
				this.Terrasoft.DataValueType.BOOLEAN);
			return query;
		},

		/**
		 * ######### ###### ########## ######## ### ######### ########.
		 * @protected
		 * @param {Terrasoft.DataValueType} dataValueType ### #########.
		 * @return {Terrasoft.BaseQuery} ###### ########## ########.
		 */
		getRangeSaveQuery: function(dataValueType) {
			var query = this.getDefSaveQuery();
			this.modifyRangeQuery(query, dataValueType);
			this.setRangeIsEmptyValue(query);
			return query;
		},

		/**
		 * ######### # ###### ####### ### ######### ########.
		 * @private
		 * @param {Terrasoft.BaseQuery} query ###### ########## ########.
		 * @param {Terrasoft.DataValueType} dataValueType ### #########.
		 */
		modifyRangeQuery: function(query, dataValueType) {
			var minValue = this.get("MinValue");
			var maxValue = this.get("MaxValue");
			query.setParameterValue(this.minValueColumnName, minValue, dataValueType);
			query.setParameterValue(this.maxValueColumnName, maxValue, dataValueType);
			query.setParameterValue("IsEmptyMinValue", this.Ext.isEmpty(minValue),
				this.Terrasoft.DataValueType.BOOLEAN);
			query.setParameterValue("IsEmptyMaxValue", this.Ext.isEmpty(maxValue),
				this.Terrasoft.DataValueType.BOOLEAN);
		},

		/**
		 * ########### # ####### ####### IsEmptyValue ### ######### ########.
		 * @private
		 * @param {Terrasoft.BaseQuery} query ###### ########## ########.
		 */
		setRangeIsEmptyValue: function(query) {
			var minValue = this.get("MinValue");
			var maxValue = this.get("MaxValue");
			query.columnValues.removeByKey("IsEmptyValue");
			query.setParameterValue("IsEmptyValue", this.Ext.isEmpty(minValue) && this.Ext.isEmpty(maxValue),
				this.Terrasoft.DataValueType.BOOLEAN);
		}
	});

	return Terrasoft.ProductConditionDbMixin;
});
