define("ContactFieldConverterMixin", ["BaseFinanceConstants", "ContactFirstMiddleLastNamingStrategy",
	"ContactLastFirstMiddleNamingStrategy"],
	function(BaseFinanceConstants) {
		Ext.define("Terrasoft.configuration.mixins.ContactFieldConverterMixin", {
			alternateClassName: "Terrasoft.ContactFieldConverterMixin",

			/**
			 * The strategy of contact naming.
			 * @type {Terrasoft.BaseObject}
			 */
			contactNamingStrategy: null,

			/**
			 * Init contact field converter.
			 * @protected
			 * @param {String} contactFieldName Full contact name field.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Execution context.
			 */
			initContactFieldConverter: function(contactFieldName, callback, scope) {
				this.set("ContactFieldName", contactFieldName);
				this.Terrasoft.SysSettings.querySysSettingsItem("ContactFieldConverter", function(value) {
					this.set("ContactFieldConverter", value);
					this.setContactNamingStrategy();
					this.Ext.callback(callback, scope);
				}, this);
			},

			/**
			 * Set current contact naming strategy due to ContactFieldConverter value.
			 * @protected
			 */
			setContactNamingStrategy: function() {
				var contactFieldConverter = this.get("ContactFieldConverter");
				switch (contactFieldConverter && contactFieldConverter.value) {
					case BaseFinanceConstants.ContactFieldConverter.FirstNameMiddleNameLastName:
						this.contactNamingStrategy = this.Ext.create("Terrasoft.ContactFirstMiddleLastNamingStrategy");
						break;
					case BaseFinanceConstants.ContactFieldConverter.LastNameFirstNameMiddleName:
						this.contactNamingStrategy = this.Ext.create("Terrasoft.ContactLastFirstMiddleNamingStrategy");
						break;
					default:
						this.contactNamingStrategy = this.Ext.create("Terrasoft.ContactLastFirstMiddleNamingStrategy");
				}
			},

			/**
			 * Generate full name.
			 * @protected
			 */
			generateFullName: function() {
				this.contactNamingStrategy.generateFullName(this);
			},

			/**
			 * Split full name.
			 * @protected
			 */
			splitFullName: function() {
				this.contactNamingStrategy.splitFullName(this);
			}
		});
	});
