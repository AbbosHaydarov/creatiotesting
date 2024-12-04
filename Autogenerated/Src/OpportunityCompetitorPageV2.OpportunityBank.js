define("OpportunityCompetitorPageV2", [],
	function() {
		return {
			entitySchemaName: "OpportunityCompetitor",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "Supplier"
				},
				{
					"operation": "merge",
					"name": "IsWinner",
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
					"name": "Competitor",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "merge",
					"name": "CompetitorProduct",
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
					"name": "Strengths",
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
					"name": "Weakness",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseRequest#validate
				 * @overridden
				 */
				validate: function() {
					return true;
				}
			}
		};
	}
);
