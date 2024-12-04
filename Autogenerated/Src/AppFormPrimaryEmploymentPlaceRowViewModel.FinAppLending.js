define("AppFormPrimaryEmploymentPlaceRowViewModel", ["AppFormPrimaryEmploymentPlaceRowViewModelResources",
	"BaseFieldRowViewModel"], function(resources) {
	/**
	 * @class Terrasoft.configuration.AppFormPrimaryEmploymentPlaceRowViewModel
	 */
	Ext.define("Terrasoft.configuration.AppFormPrimaryEmploymentPlaceRowViewModel", {
		extend: "Terrasoft.BaseFieldRowViewModel",
		alternateClassName: "Terrasoft.AppFormPrimaryEmploymentPlaceRowViewModel",

		//region Methods: Protected

		/**
		 * Validation that the number is greater than zero.
		 * @Protected
		 * @param {Object} columnValue Value of column.
		 * @return {Object} Validation object.
		 */
		validateNumberMoreThenZero: function(columnValue) {
			var invalidMessage;
			if (columnValue < 0) {
				invalidMessage = resources.localizableStrings.NumberMustBeGreaterThenZeroMessage;
			}
			return {
				fullInvalidMessage: invalidMessage,
				invalidMessage: invalidMessage
			};
		},

		/**
		 * Sets validation column configuration.
		 * @Protected
		 */
		setValidationConfig: function() {
			this.addColumnValidator("YearsOfEmployment", this.validateNumberMoreThenZero);
			this.addColumnValidator("MonthOfEmployment", this.validateNumberMoreThenZero);
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			this.setValidationConfig();
		}

		//endregion

	});

	return Terrasoft.AppFormPrimaryEmploymentPlaceRowViewModel;
});
