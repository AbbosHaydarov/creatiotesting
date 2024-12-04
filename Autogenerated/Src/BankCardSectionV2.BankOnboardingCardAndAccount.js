define("BankCardSectionV2", [],
	function() {
		return {
			entitySchemaName: "BankCard",
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/,
			attributes: {
				/**
				 * Use filter by consultation contact flag.
				 */
				"UseConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": true
				}
			},
			methods: {

				/**
				 * Returns column name for filtration.
				 * @return {String} Column name for filtration.
				 */
				getConsultationContactFilterColumnName: function() {
					return "Holder";
				}
			}
		};
	});
