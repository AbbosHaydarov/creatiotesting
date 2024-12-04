define("FinApplicationSpecificationDetail", ["terrasoft"],
	function() {
		return {
			entitySchemaName: "FinApplicationSpec",
			diff: [
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {"rowDataItemMarkerColumnName": "Specification"}
				}
			],
			methods: {
				getCopyRecordMenuItem: this.Terrasoft.emptyFn
			}
		};
	}
);
