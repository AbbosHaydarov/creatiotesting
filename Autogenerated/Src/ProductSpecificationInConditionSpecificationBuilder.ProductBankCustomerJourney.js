define("ProductSpecificationInConditionSpecificationBuilder", [
		"ProductSpecificationInConditionSpecificationBuilderResources", "ViewUtilities", "SpecificationValue",
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
					"name": "SpecificationRowContainerProductSpecificationInCondition",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"id": "specificationRowContainerProductSpecificationInCondition",
						"selectors": {"wrapEl": "#specificationRowContainerProductSpecificationInCondition"},
						"items": []
					}
				},
				{
					"operation": "remove",
					"name": "SpecificationRowContainerList"
				},
				{
					"operation": "insert",
					"name": "SpecificationRowContainerListProductSpecificationInCondition",
					"parentName": "SpecificationRowContainerProductSpecificationInCondition",
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
					"parentName": "SpecificationRowContainerProductSpecificationInCondition",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.BLUE,
						"classes": {"textClass": ["add-specification-row"]},
						"caption": {"bindTo": "Resources.Strings.AddRowButtonCaption"},
						"click": {"bindTo": "onAddSpecificationRowClickHandler"}
					}
				}
			]
		};
	});
