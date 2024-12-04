define("ActivitySectionV2", [],
	function() {
		return {
			entitySchemaName: "Activity",
			attributes: {
				/**
				 * Sign of the filter on the consultation contact.
				 */
				"UseConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": true
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});
