define("AccountFinIndicatorDetailV2", [], function() {
	return {
		entitySchemaName: "FinIndicator",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"rowDataItemMarkerColumnName": "Type"
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
