define("ContractSectionV2", [],
	function() {
		return {
			entitySchemaName: "Contract",
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/ ,
			attributes: {
				/**
				 * ####### ############# ####### ## ######## ############.
				 */
				"UseConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": true
				}
			},
			methods: {

				/**
				 * ########## ### ####### ### ##########.
				 * @return {String} ### ####### ### ##########.
				 */
				getConsultationContactFilterColumnName: function() {
					return "ContactContract";
				}
			}
		};
	});
