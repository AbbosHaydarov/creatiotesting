define("AdditionalElementConnectorManager", [], function() {
	Ext.define("Terrasoft.AdditionalElementConnectorManager", {
		override: "Terrasoft.CampaignConnectorManager",
		initMappingCollection: function() {
			this.callParent(arguments);
			this.connectorTypesMappingCollection.addIfNotExists("CampaignAddToEventSchema",
				"Terrasoft.ProcessEventConditionalTransitionSchema");
			this.connectorTypesMappingCollection.addIfNotExists("CampaignStartEventSchema",
				"Terrasoft.ProcessEventConditionalTransitionSchema");
			this.connectorTypesMappingCollection.addIfNotExists("CampaignEventSchema",
				"Terrasoft.ProcessEventConditionalTransitionSchema");
			this.connectorTypesMappingCollection.addIfNotExists("MarketingEmailSchema",
				"Terrasoft.ProcessEmailConditionalTransitionSchema");
			this.connectorTypesMappingCollection.addIfNotExists("CampaignLandingSchema",
				"Terrasoft.ProcessLandingConditionalTransitionSchema");
		},
		additionalBeforeChange: function(prevTransition, sourceItem, targetItem) {
			var connectorTypeName = connectorType.split(".")[1];
			if (transition.getTypeInfo().typeName === connectorTypeName &&
					sourceItem.getTypeInfo().typeName === "MarketingEmailSchema") {
				transition.hyperlinkId = null;
			}
		},
		fillAdditionalProperties: function(prevElement, newElement) {
			if (newElement.getTypeInfo().typeName === "ProcessEventConditionalTransitionSchema") {
				newElement.hasResponseCondition = this._setValue(prevElement.hasResponseCondition, false);
				newElement.eventResponseCollection = this._setValue(prevElement.eventResponseCollection, null);
			}
			if (newElement.getTypeInfo().typeName === "ProcessEmailConditionalTransitionSchema") {
				newElement.emailResponseId = this._setValue(prevElement.emailResponseId, null);
				newElement.isResponseBasedStart = this._setValue(prevElement.isResponseBasedStart, false);
				newElement.hyperlinkId = this._setValue(prevElement.hyperlinkId, null);
			}
			if (newElement.getTypeInfo().typeName === "ProcessLandingConditionalTransitionSchema") {
				newElement.stepCompletedCondition = this._setValue(prevElement.stepCompletedCondition, 0);
			}
		}
	});
});
