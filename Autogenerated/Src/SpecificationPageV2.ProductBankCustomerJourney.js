define("SpecificationPageV2", ["SpecificationBuilderConstants", "BusinessRuleModule"],
	function(SpecificationBuilderConstants, BusinessRuleModule) {
		return {
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Lookup",
					"values": {
						"bindTo": "Lookup",
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 18
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Unit",
					"values": {
						"bindTo": "Unit",
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 18
						},
						"contentType": Terrasoft.ContentType.ENUM
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "SpecInConditionType",
					"values": {
						"bindTo": "SpecInConditionType",
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 18
						},
						"contentType": Terrasoft.ContentType.ENUM
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Code",
					"values": {
						"bindTo": "Code",
						"contentType": Terrasoft.ContentType.TEXT,
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 18
						}
					}
				},
				{
					"operation": "merge",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Description",
					"values": {
						"layout": {
							"column": 0,
							"row": 6,
							"colSpan": 18
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			details: /**SCHEMA_DETAILS*/{
				SpecificationListItemDetail: {
					schemaName: "SpecificationListItemDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Specification"
					},
					defaultValues: {
						Lookup: {
							masterColumn: "Lookup"
						},
						LookupSchemaName: {
							masterColumn: "LookupSchemaName"
						}
					}
				}
			}/**SCHEMA_DETAILS*/,
			rules: {
				Lookup: {
					EnabledLookup: {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "Type"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: SpecificationBuilderConstants.SpecificationType.Lookup
							}
						}]
					}
				}
			},
			attributes: {
				"SpecInConditionType": {
					lookupListConfig: {
						filter: function() {
							return this.getSpecInConditionTypeFilter();
						}
					}
				}
			},
			methods: {

				// #region Methods: Private

				/**
				 * ############# ######## LookupSchemaName.
				 * @private
				 * @param {Terrasoft.BaseViewModel} entity ######### ########.
				 */
				_setLookupSchemaName: function(entity) {
					this.set("LookupSchemaName", entity.get("LookupSchemaName"));
				},

				// #endregion

				// #region Methods: Protected

				/**
				 * ########## #### # #######, ########## ### ####### ###########, ############ ####### Specification.
				 * @protected
				 * @return {Strign} #### # #######.
				 */
				getLookupSchemaNameColumnPath: function() {
					return "[Lookup:Id:Lookup].[SysSchema:UId:SysEntitySchemaUId].Name";
				},

				// #endregion

				// #region Methods: Public

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getEntitySchemaQuery
				 * @overridden
				 */
				getEntitySchemaQuery: function() {
					var esq = this.callParent(arguments);
					esq.addColumn(this.getLookupSchemaNameColumnPath(), "LookupSchemaName");
					return esq;
				},

				/**
				 * @inheritDoc Terrasoft.BasePageV2#setColumnValues
				 * @overridden
				 */
				setColumnValues: function(entity) {
					this._setLookupSchemaName(entity);
					this.callParent(arguments);
				},

				/**
				 * Get SpecInConditionType filter.
				 * @public
				 * @return {Terrasoft.Filter} .
				 */
				getSpecInConditionTypeFilter: function() {
					var customerTypeId = SpecificationBuilderConstants.SpecInConditionType.SpecificationCustomerDetail;
					var productTypeId = SpecificationBuilderConstants.SpecInConditionType.SpecificationProductDetail;
					return Terrasoft.createColumnInFilterWithParameters("Id", [customerTypeId, productTypeId]);
				}

				// #endregion

			}
		};
	});
