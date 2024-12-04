define("ContactBaseNamingStrategy", [], function() {
	/**
	 * @class Terrasoft.ContactBaseNamingStrategy
	 */
	Ext.define("Terrasoft.configuration.ContactBaseNamingStrategy", {
		extend: "Terrasoft.BaseObject",
		alternateClassName: "Terrasoft.ContactBaseNamingStrategy",

		/**
		 * Joins strings to string with space as separator.
		 * @protected
		 * @param {Array} fields Array of fields to join.
		 * @return {String} Joined fields.
		 */
		joinFields: function(fields) {
			var filteredArray = fields.filter(this.getIsNotEmptyFilter);
			return filteredArray.join(" ");
		},

		/**
		 * Returns non-empty fields from full name.
		 * @protected
		 * @param {String} fullName Contact's full name.
		 * @return {Array} Array of splitted fields.
		 */
		getFields: function(fullName) {
			var fields = fullName.split(" ");
			var filteredArray = fields.filter(this.getIsNotEmptyFilter);
			return filteredArray;
		},

		/**
		 * Returns true, if item is not empty.
		 * @private
		 * @param {String} item Part of contact's full name.
		 * @return {Boolean} True, if item is empty, otherwise false.
		 */
		getIsNotEmptyFilter: function(item) {
			return !Ext.isEmpty(item);
		}
	});
	return Terrasoft.ContactBaseNamingStrategy;
});
