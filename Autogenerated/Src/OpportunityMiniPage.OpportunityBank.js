define("OpportunityMiniPage", ["SpecificationUtilitiesV2"],
	function() {
		return {
			mixins: {
				SpecificationUtilities: "Terrasoft.SpecificationUtilities"
			},
			properties: {
				loadObjectSpecificationSchemaName: "LeadType"
			},
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseMiniPage#onSaved
				 * @overridden
				 */
				onSaved: function() {
					var parentOnSaved = this.getParentMethod(this, arguments);
					this.initSpecifications(function() {
						parentOnSaved();
					}, this);
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "remove",
				"name": "Budget"
			}, {
				"operation": "merge",
				"name": "AccountContainer",
				"values": {
					"layout": {
						"row": 4
					}
				}
			}, {
				"operation": "merge",
				"name": "Account",
				"values": {
					"layout": {
						"row": 4
					}
				}
			}, {
				"operation": "merge",
				"name": "Contact",
				"values": {
					"layout": {
						"row": 5
					}
				}
			}, {
				"operation": "merge",
				"name": "ContactContainer",
				"values": {
					"layout": {
						"row": 5
					}
				}
			}, {
				"operation": "merge",
				"name": "Owner",
				"values": {
					"layout": {
						"row": 6
					}
				}
			}, {
				"operation": "merge",
				"name": "OwnerButtonContainer",
				"values": {
					"layout": {
						"row": 6
					}
				}
			}, {
				"operation": "merge",
				"name": "PrimaryContact",
				"values": {
					"layout": {
						"row": 7
					}
				}
			}, {
				"operation": "merge",
				"name": "PrimaryContactButtonContainer",
				"values": {
					"layout": {
						"row": 7
					}
				}
			}, {
				"operation": "merge",
				"name": "LastActivity",
				"values": {
					"layout": {
						"row": 8
					}
				}
			}] /**SCHEMA_DIFF*/
		};
	});
