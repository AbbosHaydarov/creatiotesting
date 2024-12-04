define("BankAccountTimelineItemViewModel", ["BankAccountTimelineItemViewModelResources", "BaseTimelineItemViewModel"],
	function() {
		/**
		 * @class Terrasoft.configuration.BankAccountTimelineItemViewModel
		 * BankAccount timeline item view model class.
		 */
		Ext.define("Terrasoft.configuration.BankAccountTimelineItemViewModel", {
			alternateClassName: "Terrasoft.BankAccountTimelineItemViewModel",
			extend: "Terrasoft.BaseTimelineItemViewModel",

			// region Methods: Public

			/**
			 * Concatenates amount caption text with current currency symbol.
			 * @param {String} label Label text.
			 * @return {String} Amount caption text with currency symbol suffix.
			 */
			getBalanceWithCurrencyCaption: function(label) {
				var currencySymbol = this.get("CurrencySymbol");
				return label + ", " + currencySymbol;
			},

			/**
			 * Returns formatted value.
			 * @param {Number} balance Balance value.
			 * @return {String} Formatted balance caption.
			 */
			getBalanceFormattedValue: function(balance) {
				return Terrasoft.getFormattedNumberValue(balance);
			}

			// endregion
		});

	});
