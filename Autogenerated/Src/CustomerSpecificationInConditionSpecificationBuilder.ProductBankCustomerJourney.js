define("CustomerSpecificationInConditionSpecificationBuilder", [
		"CustomerSpecificationInConditionSpecificationBuilderResources", "ViewUtilities", "SpecificationValue",
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
					"name": "SpecificationRowContainerCustomerSpecificationInCondition",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"id": "specificationRowContainerCustomerSpecificationInCondition",
						"selectors": {"wrapEl": "#specificationRowContainerCustomerSpecificationInCondition"},
						"items": []
					}
				},
				{
					"operation": "remove",
					"name": "SpecificationRowContainerList"
				},
				{
					"operation": "insert",
					"name": "SpecificationRowContainerListCustomerSpecificationInCondition",
					"parentName": "SpecificationRowContainerCustomerSpecificationInCondition",
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
					"parentName": "SpecificationRowContainerCustomerSpecificationInCondition",
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
