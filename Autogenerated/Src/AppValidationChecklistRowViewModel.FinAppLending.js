define("AppValidationChecklistRowViewModel", ["FinAppLendingConstants", "BaseFieldRowViewModel"],
	function(FinAppLendingConstants) {
	/**
	 * @class Terrasoft.configuration.AppValidationChecklistRowViewModel
	 */
	Ext.define("Terrasoft.configuration.AppValidationChecklistRowViewModel", {
		extend: "Terrasoft.BaseFieldRowViewModel",
		alternateClassName: "Terrasoft.AppValidationChecklistRowViewModel",

		//region Methods: Protected

		/**
		 * Validates that the AppValidationAnswer column is required.
		 * @protected
		 * @param {Number} columnValue Value of column.
		 * @return {Object} Validates object.
		 */
		validateRequiredAppValidationAnswer: function(columnValue) {
			var invalidMessage;
			if (this.get("IsRequired") && this.Ext.isEmpty(columnValue)) {
				invalidMessage = this.Terrasoft.Resources.BaseViewModel.columnRequiredValidationMessage;
			}
			return {
				fullInvalidMessage: invalidMessage,
				invalidMessage: invalidMessage
			};
		},

		/**
		 * Initialize column validators.
		 * @protected
		 */
		setValidationConfig: function() {
			this.addColumnValidator("AppValidationAnswer", this.validateRequiredAppValidationAnswer);
		},

		/**
		 * Handles Answer field change.
		 * @protected
		 */
		onAppValidationAnswerChange: function() {
			var appValidationAnswer = this.get("AppValidationAnswer");
			appValidationAnswer = appValidationAnswer && appValidationAnswer.value;
			this.set("DescriptionVisible", appValidationAnswer === FinAppLendingConstants.AppValidationAnswer.Other);
		},

		/**
		 * Initialize subscribe for model attributes events.
		 * @protected
		 */
		subscribeForColumnEvents: function() {
			this.subscribeOnColumnChange("AppValidationAnswer", this.onAppValidationAnswerChange);
		},

		/**
		 * Unsubscribe handlers from event model attributes.
		 * @protected
		 */
		unsubscribeForColumnEvents: function() {
			this.unsubscribeOnColumnChange("AppValidationAnswer", this.onAppValidationAnswerChange);
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			this.subscribeForColumnEvents();
			this.onAppValidationAnswerChange();
			this.setValidationConfig();
		},

		/**
		 * @inheritdoc Terrasoft.BaseFieldRowViewModel#destroy
		 * @overridden
		 */
		destroy: function() {
			this.unsubscribeForColumnEvents();
			this.callParent(arguments);
		}

		//endregion

	});

	return Terrasoft.AppFormObligationRowViewModel;
});
