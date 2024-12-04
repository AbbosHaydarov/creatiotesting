define("RegDocumentDetailV2", [],
	function() {
		return {
			entitySchemaName: "RegDocument",
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"rowDataItemMarkerColumnName": "RegDocumentType"
					}
				}
			] /**SCHEMA_DIFF*/,
			methods: {
				/**
				 * @inheritDoc Terrasoft.Configuration.BaseDetailV2#updateDetail
				 * @overridden
				 */
				updateDetail: function(config) {
					config.reloadAll = true;
					this.callParent(arguments);
				}
			}
		};
	}
);
