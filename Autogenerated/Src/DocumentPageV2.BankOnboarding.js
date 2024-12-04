define("DocumentPageV2", [],
	function() {
		return {
			entitySchemaName: "Document",
			details: /**SCHEMA_DETAILS*/ {
				"Emails": {
					"schemaName": "EmailDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Document"
					},
					"defaultValues": {
						"Document": {
							"masterColumn": "Id"
						},
						"Account": {
							"masterColumn": "Account"
						},
						"Contact": {
							"masterColumn": "Contact"
						}
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "move",
				"name": "Activities",
				"parentName": "HistoryTabContainer",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "move",
				"name": "Emails",
				"parentName": "HistoryTabContainer",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "move",
				"name": "Documents",
				"parentName": "HistoryTabContainer",
				"propertyName": "items",
				"index": 2
			}] /**SCHEMA_DIFF*/
		};
	});
