define("AppValidationItemPage", ["HtmlEditModule", "ConfigurationFileApi", "AppValidationQuestionDetail",
		"FileDetailV2"],
	function() {
		return {
			entitySchemaName: "AppValidationItem",
			details: /**SCHEMA_DETAILS*/{
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "AppValidationItemFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppValidationItem"
					}
				},
				"Questions": {
					"schemaName": "AppValidationQuestionDetail",
					"entitySchemaName": "AppValidationQuestion",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppValidationItem"
					}
				}
			}, /**SCHEMA_DETAILS*/
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "Description"
				},
				{
					"operation": "remove",
					"name": "actions"
				},
				{
					"operation": "remove",
					"name": "ViewOptionsButton"
				},
				{
					"operation": "insert",
					"name": "QuestionsTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.QuestionTabCaption"
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "Questions",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "QuestionsTab",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "SceneryNotesTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.SpeechSceneryTabCaption"
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "SceneryNotesTab",
					"propertyName": "items",
					"name": "Scenery",
					"dataItemMarker": "Notes",
					"values": {
						"contentType": this.Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						}
					}
				},
				{
					"operation": "insert",
					"name": "FileNotesTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.FileTabCaption"
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "Files",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "FileNotesTab",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/
		};
	});
