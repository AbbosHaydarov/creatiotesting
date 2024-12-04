define("BankAccountSectionV2", [],
	function() {
		return {
			entitySchemaName: "BankAccount",
			attributes: {
				/**
				 * Use filter by consultation contact flag.
				 */
				"UseConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": true
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});
