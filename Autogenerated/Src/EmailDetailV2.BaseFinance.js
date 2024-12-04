define("EmailDetailV2", ["ConfigurationConstants"],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "Activity",
			methods: {
				getFilters: function() {
					var detailFilters = this.callParent(arguments);
					detailFilters.add("ActivityType", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Type", ConfigurationConstants.Activity.Type.Email));
					return detailFilters;
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	}
);
