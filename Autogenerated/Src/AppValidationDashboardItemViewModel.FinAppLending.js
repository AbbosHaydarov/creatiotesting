define("AppValidationDashboardItemViewModel", ["AppValidationDashboardItemViewModelResources", "ProcessModuleUtilities",
		"ConfigurationEnums", "FinAppLendingConstants", "EntityDashboardItemViewModel",
		"PreconfiguredAppValidationPage", "AppValidationUtilities"],
	function(resources, ProcessModuleUtilities, ConfigurationEnums, FinAppLendingConstants) {
		Ext.define("Terrasoft.configuration.AppValidationDashboardItemViewModel", {
			extend: "Terrasoft.EntityDashboardItemViewModel",
			alternateClassName: "Terrasoft.AppValidationDashboardItemViewModel",

			mixins: {
				AppValidationUtilities: "Terrasoft.AppValidationUtilities"
			},

			//region Properties: Protected

			/**
			 * Entity process element idd attribute name.
			 * @protected
			 * @type {String}
			 */
			entityProcessElementIdAttributeName: "ProcessElementId",

			/**
			 * Primary coulmn name.
			 * @protected
			 * @type {String}
			 */
			primaryColumnName: "Id",

			//endregion

			//region Methods: Private

			/**
			 * Returns default appValidation page schema name.
			 * @private
			 * @return {String} Default appValidation page schema name.
			 */
			getDefaultAppValidationPageSchemaName: function() {
				return FinAppLendingConstants.AppValidation.DefaultAppValidationPage.name;
			},

			/**
			 * Receives page schema name by Uid.
			 * @private
			 * @param {String} pageUId Page UId.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			loadPageSchemaNameByUId: function(pageUId, callback, scope) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "SysSchema"
				});
				esq.addColumn("Name");
				esq.filters.addItem(esq.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"UId",
					pageUId));
				esq.getEntityCollection(function(result) {
					var pageSchemaName;
					if (result && result.success) {
						var collection = result.collection;
						var item = collection.first();
						pageSchemaName = item.get("Name");
					}
					this.Ext.callback(callback, scope, [pageSchemaName]);
				}, this);
			},

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseDashboardItemViewModel#initIconSrc
			 * @overridden
			 */
			initIconSrc: function() {
				var iconSrc = resources.localizableImages.IconImage;
				this.set("IconSrc", iconSrc);
			},

			/**
			 * @inheritdoc Terrasoft.EntityDashboardItemViewModel#onEntityLoaded
			 * @overridden
			 */
			onEntityLoaded: function() {
				this.callParent(arguments);
				this.initExecutionData();
			},

			/**
			 * @inheritdoc Terrasoft.EntityDashboardItemViewModel#initEntity
			 * @overridden
			 */
			initEntity: function() {
				if (this.get("EntityInitialized")) {
					this.initExecutionData();
				}
				this.callParent(arguments);
			},

			/**
			 * Receives appValidation page schema name.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			loadAppValidationPageSchemaName: function(callback, scope) {
				var executionPageSchemaName = this.get("ExecutionPageSchemaName");
				if (!this.Ext.isEmpty(executionPageSchemaName)) {
					this.Ext.callback(callback, scope, [executionPageSchemaName]);
					return;
				}
				var executionData = this.get("ExecutionData") || {};
				var pageUId = executionData.pageUId;
				if (!this.Ext.isEmpty(pageUId)) {
					this.loadPageSchemaNameByUId(pageUId, callback, scope);
				} else {
					this.Ext.callback(callback, scope, [this.getDefaultAppValidationPageSchemaName()]);
				}
			},

			/**
			 * Returns default appValidation mini page options.
			 * @protected
			 * @return {Object} Configuration object for mini page.
			 */
			getAppValidationMiniPageOptions: function() {
				return {
					operation: ConfigurationEnums.CardStateV2.EDIT,
					targetId: "DashboardTab"
				};
			},

			/**
			 * @inheritdoc Terrasoft.BaseDashboardItemViewModel#execute
			 * @overridden
			 */
			execute: function() {
				this.loadAppValidationPageSchemaName(function(pageSchemaName) {
					this.set("ExecutionPageSchemaName", pageSchemaName);
					if (this.Ext.isEmpty(pageSchemaName)) {
						return;
					}
					var miniPageOptions = this.getAppValidationMiniPageOptions();
					miniPageOptions.miniPageSchemaName = pageSchemaName;
					this.showMiniPage(miniPageOptions);
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.BaseDashboardItemViewModel#getProcessElementUId
			 * @overridden
			 */
			getProcessElementUId: function() {
				return this.get("ProcessElementId");
			}

			//endregion

		});
	});
