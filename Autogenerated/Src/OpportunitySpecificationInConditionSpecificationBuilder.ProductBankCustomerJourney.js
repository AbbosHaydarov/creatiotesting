define("OpportunitySpecificationInConditionSpecificationBuilder", [
		"OpportunitySpecificationInConditionSpecificationBuilderResources", "ViewUtilities", "SpecificationValue",
		"SpecificationRow", "BaseSpecificationItemViewModel"],
	function() {
		return {
			diff: [
				{
					"operation": "remove",
					"name": "SpecificationRowContainer"
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "SpecificationRowContainerOpportunitySpecificationInCondition",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"id": "specificationRowContainerOpportunitySpecificationInCondition",
						"selectors": {"wrapEl": "#specificationRowContainerOpportunitySpecificationInCondition"},
						"items": []
					}
				},
				{
					"operation": "remove",
					"name": "SpecificationRowContainerList"
				},
				{
					"operation": "insert",
					"name": "SpecificationRowContainerListOpportunitySpecificationInCondition",
					"parentName": "SpecificationRowContainerOpportunitySpecificationInCondition",
					"propertyName": "items",
					"values": {
						"generator": "ConfigurationItemGenerator.generateContainerList",
						"idProperty": "Id",
						"collection": "RowsCollection",
						"onGetItemConfig": "onGetRowViewConfig"
					}
				},
				{
					"operation": "remove",
					"name": "AddNewSpecificationRowButton"
				},
				{
					"operation": "insert",
					"name": "AddNewSpecificationRowButton",
					"parentName": "SpecificationRowContainerOpportunitySpecificationInCondition",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.BLUE,
						"classes": {"textClass": ["add-specification-row"]},
						"caption": {"bindTo": "Resources.Strings.AddRowButtonCaption"},
						"click": {"bindTo": "onAddSpecificationRowClickHandler"}
					}
				}
			],
			methods: {
				/**
				 * ########## ###### ######### ### ####### ######## # ######### ######.
				 * @protected
				 * @return {Object} ###### #########.
				 */
				getSpecificationToolsConfig: function() {
					var toolsConfig = {
						items: [{
							"className": "Terrasoft.Button",
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"imageConfig": {"bindTo": "Resources.Images.ChangeTypeButtonImage"},
							"menu": {
								"items": {"bindTo": "ChangeTypeMenuItems"}
							},
							"tag": "remove"
						},
						{
							"className": "Terrasoft.Button",
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"imageConfig": {"bindTo": "Resources.Images.RemoveButtonImage"},
							"tag": "remove",
							"click": {"bindTo": "onRemoveButtonClick"}
						}]
					};
					return toolsConfig;
				}
			}
		};
	});
