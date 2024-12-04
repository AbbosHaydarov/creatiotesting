define("DocumentSectionV2", [],
	function() {
		return {
			entitySchemaName: "Document",
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
