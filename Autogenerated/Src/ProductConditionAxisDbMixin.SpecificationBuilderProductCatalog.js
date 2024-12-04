define("ProductConditionAxisDbMixin", [], function() {
	Ext.define("Terrasoft.configuration.mixins.ProductConditionAxisDbMixin", {
		alternateClassName: "Terrasoft.ProductConditionAxisDbMixin",

		/**
		 * ######### ###### ########## ######## SpecTableValue.
		 * @protected
		 * @return  {Terrasoft.BaseQuery} ###### ########## ########.
		 */
		getSpecTableValueQuery: function() {
			var query = null;
			if (this.isNew) {
				query = this.getInsertQuery();
			} else {
				query = this.getUpdateQuery();
				query.enablePrimaryColumnFilter(this.get(this.primaryColumnName));
			}
			query.columnValues.clear();
			query.setParameterValue(this.primaryColumnName, this.get("Id"),
				this.Terrasoft.DataValueType.GUID);
			var parentItem = this.get("ParentItem");
			var parameterViewModel = parentItem.get("ParameterViewModel");
			var specification = parameterViewModel.get("Value");
			query.setParameterValue("Specification", specification.value,
				this.Terrasoft.DataValueType.GUID);
			query.setParameterValue("CurrentType", parameterViewModel.get("CurrentType"),
				this.Terrasoft.DataValueType.TEXT);
			return query;
		}
	});

	return Terrasoft.ProductConditionAxisDbMixin;
});
