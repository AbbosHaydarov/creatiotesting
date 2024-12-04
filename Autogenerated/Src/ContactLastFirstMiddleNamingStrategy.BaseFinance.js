define("ContactLastFirstMiddleNamingStrategy", ["ContactBaseNamingStrategy"], function() {
	/**
	 * @class Terrasoft.ContactLastFirstMiddleNamingStrategy
	 */
	Ext.define("Terrasoft.configuration.ContactLastFirstMiddleNamingStrategy", {
		extend: "Terrasoft.ContactBaseNamingStrategy",
		alternateClassName: "Terrasoft.ContactLastFirstMiddleNamingStrategy",

		/**
		 * Generates full name from last name, first name, middle name,
		 * using pattern [Last name First name [Middle name]].
		 * @param {Terrasoft.BaseViewModel} viewModel External model.
		 */
		generateFullName: function(viewModel) {
			var contactFieldName = viewModel.get("ContactFieldName");
			var surname = viewModel.get("Surname");
			var givenName = viewModel.get("GivenName");
			var middleName = viewModel.get("MiddleName");
			viewModel.set(contactFieldName, this.joinFields([surname, givenName, middleName]));
		},

		/**
		 * Splits full name on last name, first name, middle name,
		 * using pattern [Last name First name [Middle name]].
		 * @param {Terrasoft.BaseViewModel} viewModel External model.
		 */
		splitFullName: function(viewModel) {
			var contactFieldName = viewModel.get("ContactFieldName");
			var contactFieldValue = viewModel.get(contactFieldName);
			if (contactFieldValue) {
				var fields = this.getFields(contactFieldValue);
				viewModel.set("Surname", fields[0]);
				viewModel.set("GivenName", fields[1]);
				viewModel.set("MiddleName", fields[2]);
			}
		}
	});
	return Terrasoft.ContactLastFirstMiddleNamingStrategy;
});
