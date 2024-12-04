define("CtiPanelLazyLoaderModule", ["BaseSchemaModuleV2"], function() {
	/**
	 * @class Terrasoft.configuration.CtiPanelLazyLoaderModule
	 * CTI panel page class to work with calls.
	 */
	Ext.define("Terrasoft.configuration.CtiPanelLazyLoaderModule", {
		alternateClassName: "Terrasoft.CtiPanelLazyLoaderModule",
		extend: "Terrasoft.BaseSchemaModule",

		/**
		 * ########## ###### ## ####### ########## ######### ######## ############.
		 * @private
		 * @param {String} sysMsgLibId Identifier of message library.
		 * @return {Terrasoft.EntitySchemaQuery} Select query for User if it has telephony integration enabled.
		 */
		_getMsgUserSettingsSelect: function(sysMsgLibId) {
			var select = Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "SysMsgUserSettings"
			});
			select.addColumn("ConnectionParams");
			select.filters.add("userFilter", Terrasoft.createColumnFilterWithParameter(
				Terrasoft.ComparisonType.EQUAL, "User", Terrasoft.SysValue.CURRENT_USER.value));
			select.filters.add("libFilter", Terrasoft.createColumnFilterWithParameter(
				Terrasoft.ComparisonType.EQUAL, "SysMsgLib", sysMsgLibId));
			return select;
		},

		/**
		 * Check if user has telephony integration enabled for particular library.
		 * @private
		 */
		_initTelephonyIntegrationCheck: function(callback) {
			Terrasoft.SysSettings.querySysSettings([
				"SysMsgLib",],
			function(settings) {
				var sysMsgLib = settings.SysMsgLib;
				if (!sysMsgLib || (sysMsgLib.value === Terrasoft.GUID_EMPTY)) {
					callback(false);
					return;
				}

				this._getMsgUserSettingsSelect(sysMsgLib.value)
					.getEntityCollection(function(response) {
						const collection = response.collection;
						if (response.success && collection && collection.getCount() > 0) {
							this.isTelephonyIntegrationEnabled = true;
							callback(true);
						} else {
							callback(false);
						}
					}, this);
			}, this);
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#init
		 * @overridden
		 */
		init: function (callback, scope) {
			if(!Terrasoft.Features.getIsEnabled("PersistentCtiPanel")){
				if(this.isTelephonyIntegrationEnabled === undefined){
					this.isTelephonyIntegrationEnabled = false;
					this.callParent([function() {
						this._initTelephonyIntegrationCheck(function(isTelephonyIntegrationEnabled) {			
							this.isTelephonyIntegrationEnabled = isTelephonyIntegrationEnabled;
							if(isTelephonyIntegrationEnabled === true){
								this.sandbox.loadModule("CtiPanelModule");
								callback.call(scope);
							}
						}.bind(this));
					}, this]);
				}
			} else {
				this.sandbox.loadModule("CtiPanelModule");
				this.callParent(arguments);
			}
		},
		

		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#initSchemaName
		 * @overridden
		 */
		initSchemaName: function() {
			this.schemaName = "CtiPanelLazyStub";
		},


		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#initSchemaName
		 * @overridden
		 */
		render: function(renderTo) {
			this.callParent(arguments);
			this.sandbox.loadModule("CtiPanelModule", { renderTo: "CtiPanelLazyStubContainer" });
		 },

		/**
		 * Replaces the last element in the chain of states, if the identifier module is different from the current.
		 * @protected
		 * @overridden
		 */
		initHistoryState: Ext.emptyFn

	});
	return Terrasoft.CtiPanelLazyLoaderModule;
});
