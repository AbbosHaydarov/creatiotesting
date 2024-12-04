define("OpportunityProductDetailV2", [], function() {
	return {
		entitySchemaName: "OpportunityProductInterest",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"rowDataItemMarkerColumnName": "Product"
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
