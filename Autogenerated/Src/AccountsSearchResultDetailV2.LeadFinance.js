define("AccountsSearchResultDetailV2", ["AccountsSearchResultDetailV2Resources", "ConfigurationEnums",
		"LookupUtilities", "GridUtilitiesV2"],
	function() {
		return {
			entitySchemaName: "Account",
			diff: [
				{
					"operation": "merge",
					"name": "SearchButton",
					"values": {
						"markerValue": "AccountSearchButton"
					}
				},
				{
					"operation": "merge",
					"name": "FoundLabel",
					"values": {
						"markerValue": "AccountFoundLabel"
					}
				}
			]
		};
	}
);
