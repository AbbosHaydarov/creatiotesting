define("AccountPageV2", ["NBOWidgetMixin"], function() {
	return {
		entitySchemaName: "Account",
		mixins: {
			NBOWidgetMixin: "Terrasoft.NBOWidgetMixin"
		},
		methods: {			
			/**
			 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
			 * @override
			 */
			 onEntityInitialized: function() {
				this.callParent(arguments);
				this.initializeNBOWidget();
			}
		},
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "insert",
			"name": "NBOWidgetProfileContainer",
			"parentName": "LeftModulesContainer",
			"propertyName": "items",
			"values": {
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"items": [],
				"classes": {
					"wrapClassName": ["nbo-widget-container", "hidden"]
				},
				"visible": {
					"bindTo": "isNBOWidgetVisible"
				}
			},
			"index": 0
		}, {
			"operation": "insert",
			"name": "NBOWidget",
			"parentName": "NBOWidgetProfileContainer",
			"propertyName": "items",
			"values": {
				"itemType": Terrasoft.ViewItemType.COMPONENT,
				"className": "Terrasoft.NBOWidgetComponent",
				"data": {
					"bindTo": "NBOWidgetData"
				},
				"onClick": {
					"bindTo": "onNBOWidgetClick"
				}
			}
		}] /**SCHEMA_DIFF*/ 
	};
});
