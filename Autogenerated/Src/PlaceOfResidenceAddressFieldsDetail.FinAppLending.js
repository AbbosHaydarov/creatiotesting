﻿define("PlaceOfResidenceAddressFieldsDetail", ["ProductBankConstants", "TimezoneMixin"],
	function(ProductBankConstants) {
		return {
			entitySchemaName: "AppFormAddress",
			attributes: {},
			diff: /**SCHEMA_DIFF*/[
			],/**SCHEMA_DIFF*/
			methods: {

				//region Properties: Protected

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getTypeColumnConfig
				 * @overridden
				 */
				getTypeColumnConfig: function() {
					return {
						name: "AddressType",
						value: ProductBankConstants.AddressType.PLACES_OF_RESIDENCE
					};
				}

				//endregion

			}
		};
	});
