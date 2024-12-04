define("BaseProductCategoryTypePageV2", [],
	function() {
		return {
			methods: {

				/**
				 * @inheritdoc BasePageV2#getPageHeaderCaption
				 * @overridden
				 */
				getPageHeaderCaption: function() {
					return " ";
				},

				/**
				 * @inheritdoc BasePageV2#clearPageHeaderCaption
				 * @overridden
				 */
				clearPageHeaderCaption: this.Terrasoft.emptyFn
			},
			details: /**SCHEMA_DETAILS*/{
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "ParametersTab",
					"values": {
						"caption": {"bindTo": "Resources.Strings.ParamtersTabCaption"},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "DocumentListTab",
					"values": {
						"caption": {"bindTo": "Resources.Strings.DocumentListTabCaption"},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "ChangeCriteriaTab",
					"values": {
						"caption": {"bindTo": "Resources.Strings.ChangeCriteriaTabCaption"},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 3
				}
			]/**SCHEMA_DIFF*/
		};
	});
