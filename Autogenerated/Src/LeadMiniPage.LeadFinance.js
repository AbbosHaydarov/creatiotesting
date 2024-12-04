define("LeadMiniPage", ["SpecificationUtilitiesV2"],
	function() {
		return {
			mixins: {
				SpecificationUtilities: "Terrasoft.SpecificationUtilities"
			},
			properties: {
				loadObjectSpecificationSchemaName: "LeadType"
			},
			details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
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
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	}
);
