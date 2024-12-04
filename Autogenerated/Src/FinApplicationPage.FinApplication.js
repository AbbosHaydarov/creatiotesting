define("FinApplicationPage", [],
	function() {
		return {
			attributes: {
				/**
				 * Contract.
				 * @type {Object}
				 */
				"Contract": {
					"lookupListConfig": {
						"columns": ["Account", "Product", "[Product:Id:Product].Category", "[Product:Id:Product].Type",
							"ContactContract", "Package", "[ProductInPackage:Product:Product].Id"
						],
						"filters": [{
							method: function() {
								return this.getContractFilter();
							}
						}]
					},
					"dependencies": [{
						"columns": ["Contract"],
						"methodName": "onContractChange"
					}]
				},
			},
			methods: {

				//region Methods: Protected

				/**
				 * Returns a filters group for contracts by contact and product.
				 * @protected
				 * @return {Terrasoft.FilterGroup} Filter group.
				 */
				getContractFilter: function() {
					var contact = this.get("Contact");
					var product = this.get("Product");
					var filters = this.Terrasoft.createFilterGroup();
					if (!this.Ext.isEmpty(contact)) {
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "ContactContract", contact.value));
					}
					if (!this.Ext.isEmpty(product)) {
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Product", product.value));
					}
					return filters;
				},

				/**
				 * Sets the value for the product and product condition when changing contract.
				 * @protected
				 */
				onContractChange: function() {
					var contract = this.get("Contract");
					if (!this.Ext.isEmpty(contract)) {
						this.set("Contact", contract.ContactContract);
						this.set("Package", contract.Package);
						this.set("Product", this.getProductFromContract(contract));
					} else {
						this.set("Contact", null);
						this.set("Package", null);
						this.set("Product", null);
					}
				}

				//endregion
			},
			diff: [{
				"operation": "insert",
				"parentName": "AdditionalProfileInfoContainer",
				"propertyName": "items",
				"name": "ClientInProfile",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24,
						"rowSpan": 1
					},
					"controlConfig": {
						"enableLeftIcon": true,
						"leftIconConfig": {
							"bindTo": "getMultiLookupIconConfig"
						}
					},
					"bindTo": "Client"
				}
			}, {
				"operation": "merge",
				"name": "BranchDivision",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			}, {
				"operation": "merge",
				"name": "FillingDateInProfile",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			}, {
				"operation": "merge",
				"name": "OwnerInProfile",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4
					}
				}
			}, {
				"operation": "merge",
				"name": "Source",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5
					}
				}
			}]
		};
	});
