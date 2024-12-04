define("CaseSection", [],
	function() {
		return {
			entitySchemaName: "Case",
			attributes: {
				/**
				 * Consultation contact filter usage boolean attribute.
				 */
				"UseConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": true
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});
