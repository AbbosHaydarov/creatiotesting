define("CasePage", ["BusinessRuleModule"],
	function(BusinessRuleModule) {
		return {
			entitySchemaName: "Case",
			details: /**SCHEMA_DETAILS*/ {
				"ConsultationThemes": {
					"schemaName": "CaseConsultationThemeDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Case"
					}
				},
				"FinApplicationDetail": {
					"schemaName": "FinApplicationDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Case"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "ConsultationThemes",
				"parentName": "CaseInformationTab",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"index": 3,
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "FinApplicationDetail",
				"parentName": "CaseInformationTab",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"propertyName": "items"
			}] /**SCHEMA_DIFF*/ ,
			rules: {
				"ClosureCode": {
					"RequireClosureCodeOnFinalState": {
						ruleType: BusinessRuleModule.enums.RuleType.DISABLED
					}
				}
			}
		};
	}
);
