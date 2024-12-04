define("FinApplicationActionsDashboard", ["SectionActionsDashboard", "AppValidationDashboardItemViewModel",
	"BaseDashboardItemViewConfig"
], function() {
	return {
		methods: {

			//region Methods: Private

			/**
			 * Returns the query to the "AppValidation" items of dashboard.
			 * @private
			 * @return {Terrasoft.EntitySchemaQuery} The Query to EntitySchema.
			 */
			getAppValidationItemsQuery: function() {
				var esq = this.createEntitySchemaQuery("AppValidation");
				this.addAppValidationColumns(esq);
				this.addAppValidationFilters(esq);
				return esq;
			},

			/**
			 * Adds columns of "AppValidation" items of dashboard to the query.
			 * @private
			 * @param {Terrasoft.EntitySchemaQuery} esq The Query to EntitySchema.
			 */
			addAppValidationColumns: function(esq) {
				var viewConfigClassName = this.getDashboardItemViewConfigClassName(esq.rootSchemaName);
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Caption");
				esq.addColumn("CreatedOn", "Date");
				esq.addColumn("CreatedBy.Name", "Owner");
				esq.addParameterColumn("AppValidation", this.Terrasoft.DataValueType.TEXT, "EntitySchemaName");
				esq.addParameterColumn(viewConfigClassName, this.Terrasoft.DataValueType.TEXT, "ViewConfigClassName");
				esq.addParameterColumn(true, this.Terrasoft.DataValueType.BOOLEAN, "EntityInitialized");
				esq.addColumn("[SysEntityCommonPrcEl:RecordId:Id].ProcessElement.Id", "ProcessElementId");
			},

			/**
			 * Adds filters of "AppValidation" items of dashboard to the query.
			 * @private
			 * @param {Terrasoft.EntitySchemaQuery} esq The Query to EntitySchema.
			 */
			addAppValidationFilters: function(esq) {
				esq.filters = this.Terrasoft.createFilterGroup();
				this.addMasterColumnFilter(esq);
				this.addAppValidationDefaultFilters(esq);
			},

			/**
			 * Adds default filters of "AppValidation" items of dashboard to the query.
			 * @private
			 * @param {Terrasoft.EntitySchemaQuery} esq The Query to EntitySchema.
			 */
			addAppValidationDefaultFilters: function(esq) {
				var filters = esq.filters;
				filters.add("ValidationResultFilter", esq.createColumnIsNullFilter("ValidationResult"));
			},

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseActionsDashboard#initDashboardConfig
			 * @overridden
			 */
			initDashboardConfig: function() {
				this.callParent(arguments);
				var dashboardConfig = this.get("DashboardConfig");
				var appValidationItemsConfig = {
					"AppValidation": {
						masterColumnName: "Id",
						referenceColumnName: "FinApplication",
						viewModelClassName: "Terrasoft.AppValidationDashboardItemViewModel",
						viewConfigClassName: "Terrasoft.BaseDashboardItemViewConfig"
					}
				};
				var extendedConfig = this.values.dashboardConfig || {};
				this.Ext.merge(dashboardConfig, appValidationItemsConfig);
				this.Ext.merge(dashboardConfig, extendedConfig);
				this.set("DashboardConfig", dashboardConfig);
			},

			/**
			 * @inheritdoc Terrasoft.SectionActionsDashboard#getItemsQuery
			 * @overridden
			 */
			getItemsQuery: function() {
				var bq = this.callParent(arguments);
				var appValidationItemsQuery = this.getAppValidationItemsQuery();
				if (appValidationItemsQuery) {
					bq.add(appValidationItemsQuery);
				}
				return bq;
			}

			//endregion

		},
		diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
	};
});
