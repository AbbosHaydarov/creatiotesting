define("ContactsSearchResultDetailV2", [
		"ContactsSearchResultDetailV2Resources", "ConfigurationEnums",
		"LookupUtilities", "GridUtilitiesV2"
	],
	function() {
		return {
			entitySchemaName: "Contact",
			diff: [
				{
					"operation": "merge",
					"name": "SearchButton",
					"values": {
						"markerValue": "ContactSearchButton"
					}
				},
				{
					"operation": "merge",
					"name": "FoundLabel",
					"values": {
						"markerValue": "ContactFoundLabel"
					}
				}
			]
		}
			;
	}
)
;
