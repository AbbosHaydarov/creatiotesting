define("FinIndicatorSection", ["GridUtilitiesV2"],
	function() {
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
			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * ############# ######## ############## ########### ####### ### ####### "###. ##########"
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1079);
					this.callParent(arguments);
				}
			}
		};
	});
