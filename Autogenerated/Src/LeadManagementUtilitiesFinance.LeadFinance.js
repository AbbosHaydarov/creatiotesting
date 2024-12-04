define("LeadManagementUtilitiesFinance", ["LeadManagementUtilities"],
	function() {
		Ext.define("Terrasoft.configuration.mixins.LeadManagementUtilitiesFinance", {
			extend: "Terrasoft.LeadManagementUtilities",
			alternateClassName: "Terrasoft.LeadManagementUtilitiesFinance",

			/**
			 * Validation field for qualification.
			 * @param {Object} scope - context execution.
			 * @protected
			 * @returns {Boolean} Result fo validation.
			 */
			validateQualification: function(scope) {
				var qualifiedContact = scope.get("QualifiedContact");
				var qualifiedAccount = scope.get("QualifiedAccount");
				var surname = scope.get("Surname");
				var mobilePhone = scope.get("MobilePhone");
				var account = scope.get("Account");
				return ((!this.Ext.isEmpty(qualifiedContact) || !this.Ext.isEmpty(qualifiedAccount) ||
					!this.Ext.isEmpty(account))	|| (!this.Ext.isEmpty(surname) && !this.Ext.isEmpty(mobilePhone)));
			},

			/**
			 * Qualification button click from Lead section.
			 * @param {function} callback - callback function.
			 * @param {Object} scope - execution context callback.
			 * @protected
			 */
			onLeadManagementFinanceSectionButtonClick: function(callback, scope) {
				var entity = scope.getEntity();
				if (this.validateQualification(entity)) {
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this);
					}
				} else {
					this.showInformationDialog(this.get("Resources.Strings.InsufficientDataForLeadQualificationMessage"));
				}
			},

			/**
			 * Qualification of lead.
			 * @protected
			 */
			onLeadManagementFinancePageButtonClick: function() {
				var columns = ["Surname", "MobilePhone"];
				var required = false;
				if (this.validateQualification(this)) {
					this.onLeadManagementButtonClick();
				} else {
					required = true;
					this.save({isSilent: true});
				}
				columns.forEach(function(columnName) {
					var column = this.columns[columnName];
					column.isRequired = required;
				}, this);
			},

			/**
			 * Calls method from the CardPage.
			 * @protected
			 */
			onLeadManagementFinanceButtonClick: function() {
				this.executeCardMethod("onLeadManagementFinancePageButtonClick");
			}
		});
		return Terrasoft.LeadManagementUtilitiesFinance;
	}
);
