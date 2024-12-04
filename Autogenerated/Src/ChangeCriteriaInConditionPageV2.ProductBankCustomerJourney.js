define("ChangeCriteriaInConditionPageV2", ["SpecificationBuilderConstants", "BusinessRuleModule",
		"ChangeCriteriaInConditionPageV2Resources"
	],
	function(SpecificationBuilderConstants, BusinessRuleModule) {
		return {
			entitySchemaName: "ChangeCriteriaInCondition",
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "ChangeCriteria",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"value": {
						"bindTo": "ChangeCriteria"
					},
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 10
					}
				}
			}, {
				"operation": "insert",
				"name": "VariableSpecification",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"value": {
						"bindTo": "VariableSpecification"
					},
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 10
					}
				}
			}, {
				"operation": "insert",
				"name": "CorrectionValue",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.FLOAT,
					"value": {
						"bindTo": "CorrectionValue"
					},
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 10
					}
				}
			}, {
				"operation": "insert",
				"name": "SpecificationValueContainer",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 10
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "IntegerValue",
				"parentName": "SpecificationValueContainer",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": {
						"bindTo": "IntegerValue"
					},
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 10
					},
					"visible": {
						"bindTo": "ChangeCriteria",
						"bindConfig": {
							"converter": "setIsIntegerValueVisible"
						}
					}
				}
			}, {
				"operation": "insert",
				"name": "BooleanValue",
				"parentName": "SpecificationValueContainer",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"layout": {
						"column": 12,
						"row": 3,
						"colSpan": 10
					},
					"visible": {
						"bindTo": "ChangeCriteria",
						"bindConfig": {
							"converter": "setIsBooleanValueVisible"
						}
					}
				}
			}, {
				"operation": "insert",
				"name": "FloatValue",
				"parentName": "SpecificationValueContainer",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.FLOAT,
					"value": {
						"bindTo": "FloatValue"
					},
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 10
					},
					"visible": {
						"bindTo": "ChangeCriteria",
						"bindConfig": {
							"converter": "setIsFloatValueVisible"
						}
					}
				}
			}, {
				"operation": "insert",
				"name": "SpecificationListItem",
				"parentName": "SpecificationValueContainer",
				"propertyName": "items",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"value": {
						"bindTo": "SpecificationListItem"
					},
					"layout": {
						"column": 12,
						"row": 5,
						"colSpan": 10
					},
					"visible": {
						"bindTo": "ChangeCriteria",
						"bindConfig": {
							"converter": "setIsSpecificationListItemVisible"
						}
					}
				}
			}, {
				"operation": "insert",
				"name": "StringValue",
				"parentName": "SpecificationValueContainer",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"value": {
						"bindTo": "StringValue"
					},
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 10
					},
					"visible": {
						"bindTo": "ChangeCriteria",
						"bindConfig": {
							"converter": "setIsStringValueVisible"
						}
					}
				}
			}, {
				"operation": "remove",
				"name": "actions"
			}] /**SCHEMA_DIFF*/ ,
			attributes: {
				"IsIntegerValueVisible": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dependencies": [{
						"columns": ["ChangeCriteria"],
						"methodName": "setIsIntegerValueVisible"
					}]
				},
				"IsBooleanValueVisible": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dependencies": [{
						"columns": ["ChangeCriteria"],
						"methodName": "setIsBooleanValueVisible"
					}]
				},
				"IsFloatValueVisible": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dependencies": [{
						"columns": ["ChangeCriteria"],
						"methodName": "setIsFloatValueVisible"
					}]
				},
				"IsSpecificationListItemVisible": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dependencies": [{
						"columns": ["ChangeCriteria"],
						"methodName": "setIsSpecificationListItemVisible"
					}]
				},
				"IsStringValueVisible": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dependencies": [{
						"columns": ["ChangeCriteria"],
						"methodName": "setIsStringValueVisible"
					}]
				},
				/**
				 * Change criteria field.
				 */
				"ChangeCriteria": {
					"lookupListConfig": {
						"columns": ["Specification", "Specification.Type", "DisplayValue"],
						"filter": function() {
							var category = this.get("ProductCategory");
							var type = this.get("ProductType");
							var filterGroup = this.Terrasoft.createFilterGroup();
							filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
							var filterByCategory = this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "ProductCategory", category);
							filterGroup.addItem(filterByCategory);
							var filterByType = this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "ProductType", type);
							filterGroup.addItem(filterByType);
							return filterGroup;
						}
					},
					"isRequired": true
				},
				/**
				 * Lookup value for SpecificationListItem field.
				 */
				"SpecificationListItem": {
					"lookupListConfig": {
						"filter": function() {
							var сhangeCriteria = this.get("ChangeCriteria");
							var specification = сhangeCriteria.Specification;
							var filter = this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Specification", specification.value);
							return filter;
						}
					}
				},
				/**
				 * Variable specification.
				 */
				"VariableSpecification": {
					"lookupListConfig": {
						"filter": function() {
							return this.getVariableSpecificationFilter();
						}
					}
				}
			},
			methods: {

				/**
				 * Returns filters for VariableSpecification field.
				 * @protected
				 * @return {Terrasoft.FilterGroup} Filters for VariableSpecification field.
				 */
				getVariableSpecificationFilter: function() {
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					var typeFilterGroup = this.Terrasoft.createFilterGroup();
					typeFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					var floatFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Specification.Type",
							SpecificationBuilderConstants.SpecificationType.Float);
					typeFilterGroup.add("FloatFilter", floatFilter);
					var integerFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Specification.Type",
							SpecificationBuilderConstants.SpecificationType.Integer);
					typeFilterGroup.add("IntegerFilter", integerFilter);
					filterGroup.add("TypeFilterGroup", typeFilterGroup);
					var category = this.get("ProductCategory");
					var type = this.get("ProductType");
					var productCategoryTypeFilterGroup = this.Terrasoft.createFilterGroup();
					productCategoryTypeFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					var productCategoryFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "ProductCategory", category);
					productCategoryTypeFilterGroup.add("ProductCategoryFilter", productCategoryFilter);
					var productTypeFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "ProductType", type);
					productCategoryTypeFilterGroup.add("ProductTypeFilter", productTypeFilter);
					filterGroup.add("ProductCategoryTypeFilterGroup", productCategoryTypeFilterGroup);
					return filterGroup;
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.subscribeOnColumnChange("ChangeCriteria", this.onChangeCriteriaChanged);
				},

				/**
				 * ###### ######## ### ##### #########.
				 * @protected
				 */
				onChangeCriteriaChanged: function() {
					this.set("SpecificationListItem", undefined);
					this.set("FloatValue", undefined);
					this.set("StringValue", undefined);
					this.set("IntegerValue", undefined);
					this.set("BooleanValue", undefined);
				},

				/**
				 * ########## ####### ### ##### ########### ########.
				 * @protected
				 * @return {Boolean} ########## true, #### ##### ######## #######.
				 */
				setIsSpecificationListItemVisible: function() {
					var isVisible = this.isVisibleByType(SpecificationBuilderConstants.SpecificationType.Lookup);
					this.set("IsSpecificationListItemVisible", isVisible);
					return isVisible;
				},

				/**
				 * ########## ####### ### ##### ######## ########.
				 * @protected
				 * @return {Boolean} ########## true, #### ##### ######## #######.
				 */
				setIsFloatValueVisible: function() {
					var isVisible = this.isVisibleByType(SpecificationBuilderConstants.SpecificationType.Float);
					this.set("IsFloatValueVisible", isVisible);
					return isVisible;
				},

				/**
				 * ########## ####### ### ##### ########## ########.
				 * @protected
				 * @return {Boolean} ########## true, #### ##### ######## #######.
				 */
				setIsStringValueVisible: function() {
					var isVisible = this.isVisibleByType(SpecificationBuilderConstants.SpecificationType.Text);
					this.set("IsStringValueVisible", isVisible);
					return isVisible;
				},

				/**
				 * ########## ####### ### ##### ############## ########.
				 * @protected
				 * @return {Boolean} ########## true, #### ##### ######## #######.
				 */
				setIsIntegerValueVisible: function() {
					var isVisible = this.isVisibleByType(SpecificationBuilderConstants.SpecificationType.Integer);
					this.set("IsIntegerValueVisible", isVisible);
					return isVisible;
				},

				/**
				 * ########## ####### ### ##### ########### ########.
				 * @protected
				 * @return {Boolean} ########## true, #### ##### ######## #######.
				 */
				setIsBooleanValueVisible: function() {
					var isVisible = this.isVisibleByType(SpecificationBuilderConstants.SpecificationType.Boolean);
					this.set("IsBooleanValueVisible", isVisible);
					return isVisible;
				},

				/**
				 * ########## ####### ### ##### ########### ########.
				 * @protected
				 * @param {Terrasoft.SpecificationBuilderConstants} type ######### ###.
				 * @return {Boolean} ########## true, #### ##### ######## #######.
				 */
				isVisibleByType: function(type) {
					var value = this.get("ChangeCriteria");
					return value && value["Specification.Type"].value === type;
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSchemaModuleV2#destroy
				 * @overridden
				 */
				destroy: function() {
					this.unsubscribeOnColumnChange("ChangeCriteria", this.onChangeCriteriaChanged);
					this.callParent(arguments);
				}
			},
			rules: {
				"StringValue": {
					"BindParameterRequiredStringValue": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsStringValueVisible"
							},
							"comparisonType": Terrasoft.core.enums.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"SpecificationListItem": {
					"BindParameterRequiredSpecificationListItem": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsSpecificationListItemVisible"
							},
							"comparisonType": Terrasoft.core.enums.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"FloatValue": {
					"BindParameterRequiredFloatValue": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsFloatValueVisible"
							},
							"comparisonType": Terrasoft.core.enums.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"IntegerValue": {
					"BindParameterRequiredIntegerValue": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsIntegerValueVisible"
							},
							"comparisonType": Terrasoft.core.enums.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				}
			}
		};
	});
