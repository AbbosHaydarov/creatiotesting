define("ContactPageV2", [], function() {
	return {
		details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/ [
			{
				"operation": "merge",
				"name": "Dear",
				"values": {
					"layout": {
						"column": 12,
						"row": 3
					}
				}
			},
			{
				"operation": "merge",
				"name": "Age",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "merge",
				"name": "Language",
				"values": {
					"layout": {
						"column": 12,
						"row": 4
					}
				}
			},
			{
				"operation": "merge",
				"name": "Type",
				"values": {
					"layout": {
						"column": 4,
						"row": 0,
						"colSpan": 20
					}
				}
			},
			{
				"operation": "merge",
				"name": "Owner",
				"values": {
					"layout": {
						"column": 4,
						"row": 3,
						"colSpan": 20
					}
				}
			},
			{
				"operation": "merge",
				"name": "Gender",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12
					},
				}
			},
			{
				"operation": "merge",
				"name": "PlaceOfBirth",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					},
				}
			},
			{
				"operation": "merge",
				"name": "SalutationType",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					},
				}
			},
			{
				"operation": "merge",
				"name": "Job",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "merge",
				"name": "JobTitle",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "merge",
				"name": "Department",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "merge",
				"name": "DecisionRole",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "move",
				"name": "CommunicationChannelsTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 7
			}
		] /**SCHEMA_DIFF*/
	};
});