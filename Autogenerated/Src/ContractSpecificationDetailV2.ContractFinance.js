define("ContractSpecificationDetailV2", ["ConfigurationEnums"], function() {
	return {
		entitySchemaName: "SpecificationInContract",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"rowDataItemMarkerColumnName": "Specification"
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
