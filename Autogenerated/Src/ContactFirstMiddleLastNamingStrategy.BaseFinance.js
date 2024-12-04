define("ContactFirstMiddleLastNamingStrategy", ["ContactBaseNamingStrategy"], function() {
	/**
	 * @class Terrasoft.ContactFirstMiddleLastNamingStrategy
	 */
	Ext.define("Terrasoft.configuration.ContactFirstMiddleLastNamingStrategy", {
		extend: "Terrasoft.ContactBaseNamingStrategy",
		alternateClassName: "Terrasoft.ContactFirstMiddleLastNamingStrategy",

		/**
		 * Generates full name from first name, middle name, last name,
		 * using pattern [First name [Middle name] Last name].
		 * @param {Terrasoft.BaseViewModel} viewModel External model.
		 */
		generateFullName: function(viewModel) {
			var contactFieldName = viewModel.get("ContactFieldName");
			var givenName = viewModel.get("GivenName");
			var middleName = viewModel.get("MiddleName");
			var surname = viewModel.get("Surname");
			viewModel.set(contactFieldName, this.joinFields([givenName, middleName, surname]));
		},

		/**
		 * Splits full name on first name, middle name, last name,
		 * using pattern [First name [Middle name] Last name].
		 * @param {Terrasoft.BaseViewModel} viewModel External model.
		 */
		splitFullName: function(viewModel) {
			var contactFieldName = viewModel.get("ContactFieldName");
			var contactFieldValue = viewModel.get(contactFieldName);
			if (contactFieldValue) {
				var fields = this.getFields(contactFieldValue);
				viewModel.set("GivenName", fields[0]);
				if (fields.length > 2) {
					viewModel.set("MiddleName", fields[1]);
					viewModel.set("Surname", fields[2]);
				} else {
					viewModel.set("Surname", fields[1]);
				}
			}
		}
	});
	return Terrasoft.ContactFirstMiddleLastNamingStrategy;
});
