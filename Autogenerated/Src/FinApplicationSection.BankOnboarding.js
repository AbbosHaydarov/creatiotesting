define("FinApplicationSection", [],
	function() {
		return {
			entitySchemaName: "FinApplication",
			attributes: {
				/**
				 * ####### ############# ####### ## ######## ############.
				 */
				"UseConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": true
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});
