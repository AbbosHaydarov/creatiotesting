define("FinApplicationSpecificationPage", ["FinApplicationConstants"],
	function(FinApplicationConstants) {
		return {
			entitySchemaName: "FinApplicationSpec",
			diff: [
				{
					"operation": "insert",
					"name": "Specification",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.LOOKUP,
						"value": {"bindTo": "Specification"},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "SpecificationValueContainer",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"visible": true,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 10
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "TextValue",
					"parentName": "SpecificationValueContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.TEXT,
						"value": {"bindTo": "TextValue"},
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 10
						},
						"visible": {
							"bindTo": "Specification",
							"bindConfig": {"converter": "isTextValueVisible"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "IntegerValue",
					"parentName": "SpecificationValueContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.INTEGER,
						"value": {"bindTo": "IntegerValue"},
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 10
						},
						"visible": {
							"bindTo": "Specification",
							"bindConfig": {"converter": "isIntegerValueVisible"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "BooleanValue",
					"parentName": "SpecificationValueContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 10
						},
						"visible": {
							"bindTo": "Specification",
							"bindConfig": {"converter": "isBooleanValueVisible"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "FloatValue",
					"parentName": "SpecificationValueContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.FLOAT,
						"value": {"bindTo": "FloatValue"},
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 10
						},
						"visible": {
							"bindTo": "Specification",
							"bindConfig": {"converter": "isFloatValueVisible"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "SpecificationListItem",
					"parentName": "SpecificationValueContainer",
					"propertyName": "items",
					"values": {
						"contentType": Terrasoft.ContentType.ENUM,
						"dataValueType": Terrasoft.DataValueType.LOOKUP,
						"value": {"bindTo": "SpecificationListItem"},
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 10
						},
						"visible": {
							"bindTo": "Specification",
							"bindConfig": {"converter": "isSpecificationListItemVisible"}
						}
					}
				},
				{
					"operation": "remove",
					"name": "Tabs"
				}
			],
			attributes: {
				"Specification": {
					lookupListConfig: {
						columns: ["Name", "Type"],
						filter: function() {
							var finApplication = this.get("FinApplication");
							var filterGroup = this.Terrasoft.createFilterGroup();
							var filterNotExist = this.Terrasoft.createNotExistsFilter(
								"[FinApplicationSpec:Specification:Id].Id");
							filterNotExist.subFilters.addItem(Terrasoft.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL, "FinApplication", finApplication.value));
							filterGroup.addItem(filterNotExist);
							return filterGroup;
						}
					},
					isRequired: true
				},
				"SpecificationListItem": {
					lookupListConfig: {
						filter: function() {
							var specification = this.get("Specification");
							var filter = this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Specification", specification.value);
							return filter;
						}
					}
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#onEntityInitialized
				 * @overriden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.subscribeOnColumnChange("Specification", this.onSpecificationChanged);
				},

				/**
				 * Clears attributes when changing parameter.
				 * @protected
				 */
				onSpecificationChanged: function() {
					this.set("SpecificationListItem", undefined);
					this.set("FloatValue", undefined);
					this.set("TextValue", undefined);
					this.set("IntegerValue", undefined);
					this.set("BooleanValue", undefined);
				},

				/**
				 * Displays the control to enter lookup value.
				 * @param {Object} value Value of Specification attribute.
				 * @return {Boolean} Returns true, when lookup control is needed.
				 * @protected
				 */
				isSpecificationListItemVisible: function(value) {
					return value && value.Type.value === FinApplicationConstants.SpecificationType.LookupType;
				},

				/**
				 * Displays the control to enter float values.
				 * @param {Object} value Value of Specification attribute.
				 * @return {Boolean} Returns true, when float control is needed.
				 * @protected
				 */
				isFloatValueVisible: function(value) {
					return value && value.Type.value === FinApplicationConstants.SpecificationType.FloatType;
				},

				/**
				 * Displays the control to enter integer values.
				 * @param {Object} value Value of Specification attribute.
				 * @return {Boolean} Returns true, when integer control is needed.
				 * @protected
				 */
				isIntegerValueVisible: function(value) {
					return value && value.Type.value === FinApplicationConstants.SpecificationType.IntegerType;
				},

				/**
				 * Displays the control to enter text values.
				 * @param {Object} value Value of Specification attribute.
				 * @return {Boolean} Returns true, when text control is needed.
				 * @protected
				 */
				isTextValueVisible: function(value) {
					return value && value.Type.value === FinApplicationConstants.SpecificationType.StringType;
				},

				/**
				 * Displays the control to enter boolean values.
				 * @param {Object} value Value of Specification attribute.
				 * @return {Boolean} Returns true, when boolean control is needed.
				 * @protected
				 */
				isBooleanValueVisible: function(value) {
					return value && value.Type.value === FinApplicationConstants.SpecificationType.BooleanType;
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSchemaModuleV2#destroy
				 * @overriden
				 */
				destroy: function() {
					this.unsubscribeOnColumnChange("Specification", this.onSpecificationChanged);
					this.callParent(arguments);
				}
			}
		};
	});
