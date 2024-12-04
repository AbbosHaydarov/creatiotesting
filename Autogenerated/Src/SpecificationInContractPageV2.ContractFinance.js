define("SpecificationInContractPageV2", [], function() {
	return {
		entitySchemaName: "SpecificationInContract",
		methods: {
			/**
			 * ######### #######, ####### ############# ## ########## ####.
			 * @private
			 * @param {String} columnName ######## #######.
			 * @return {Terrasoft.FilterGroup} ########## ###### ########.
			 */
			getLookupQueryFilters: function(columnName) {
				var mainFilterGroup = this.callParent(arguments);
				var contract = this.get("Contract");
				if (columnName === "Specification" && !this.Ext.isEmpty(contract)) {
					var contractFilterPath = "[SpecificationInContract:Specification:Id].Contract";
					var subContractFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
					var contractFilter = this.Terrasoft.createColumnInFilterWithParameters(contractFilterPath,
						[contract.value]);
					subContractFilterGroup.addItem(contractFilter);
					var notExistsFilter = this.Terrasoft.createNotExistsFilter("Id", subContractFilterGroup);
					mainFilterGroup.addItem(notExistsFilter);
				}
				return mainFilterGroup;
			},

			/**
			 * ######### ######### ######### ##############.
			 * ######## ############ ############## ### ########.
			 * @protected
			 * @virtual
			 * @param {Function} callback ####### ######### ###### ### ########### #########
			 * @param {object} scope ######## ##########
			 */
			validateSpecification: function(callback, scope) {
				var result = {
					success: true
				};
				var contract = this.get("Contract");
				var specification = this.get("Specification");
				if (this.Ext.isEmpty(contract) || this.Ext.isEmpty(specification)) {
					result.message = this.get("Resources.Strings.CantCheckSpecificationError");
					result.success = false;
					callback.call(scope || this, result);
					return;
				}
				if (this.isNewMode() || this.changedValues.Specification) {
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SpecificationInContract"
					});
					select.addAggregationSchemaColumn("Id", Terrasoft.AggregationType.COUNT, "IdCOUNT");
					select.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Contract", contract.value));
					select.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Specification", specification.value));
					select.getEntityCollection(function(response) {
						if (response.success) {
							if (response.collection.getCount() < 1) {
								result.message = this.get("Resources.Strings.CantCheckSpecificationError");
								result.success = false;
							} else {
								var selectResult = response.collection.getByIndex(0);
								var specificationsCount = selectResult.get("IdCOUNT");
								if (specificationsCount > 0) {
									result.message = this.get("Resources.Strings.SpecificationExists");
									result.success = false;
								}
							}
						} else {
							result.message = this.get("Resources.Strings.CantCheckSpecificationError");
							result.success = false;
						}
						callback.call(scope || this, result);
					}, this);
				} else {
					callback.call(scope || this, result);
				}
			},

			/**
			 * ######### ########### ######### ########
			 * @protected
			 * @override
			 * @param {Function} callback ####### ######### ######
			 * @param {object} scope ######## ##########
			 */
			asyncValidate: function(callback, scope) {
				this.callParent([function(response) {
					if (!this.validateResponse(response)) {
						return;
					}
					Terrasoft.chain(
						function(next) {
							this.validateSpecification(function(response) {
								if (this.validateResponse(response)) {
									next();
								}
							}, this);
						},
						function(next) {
							callback.call(scope, response);
							next();
						}, this);
				}, this]);
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Contract",
				"values": {
					"bindTo": "Contract",
					"layout": {"column": 0, "row": 0, "colSpan": 12},
					"enabled": false,
					"controlConfig": {
						"enableRightIcon": false
					}
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {
			"Contract": {
				lookupListConfig: {
					columns: ["Product"]
				}
			}
		}
	};
});
