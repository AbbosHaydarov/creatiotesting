define("SchedulerProcessPageV2", ["SchedulerProcessPageV2Resources", "ConfigurationGridLookupUtilities"],
	function(resources) {
		return {
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			entitySchemaName: "SchedulerProcess",
			mixins: {
				/**
				 * ###### ######### ###### ######### ######## ########### ####### ####.
				 */
				ConfigurationGridLookupUtilities: "Terrasoft.ConfigurationGridLookupUtilities"
			},
			attributes: {
				/**
				 * ########### ####### ##### ###########.
				 */
				"SysEntitySchema": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					caption: resources.localizableStrings.SysEntitySchemaCaption,
					isLookup: true,
					isRequired: true,
					lookupListConfig: {
						columns: ["UId", "Caption", "Name"],
						filter: function() {
							return this.getSysWorkspaceFilter();
						}
					},
					referenceSchema: {
						name: "VwSysSchemaInfo",
						primaryColumnName: "Name",
						primaryDisplayColumnName: "Caption"
					},
					referenceSchemaName: "VwSysSchemaInfo"
				},
				/**
				 * ####### ##### ###########.
				 */
				"SysEntitySchemaUId": {
					dependencies: [{
						columns: ["SysEntitySchema"],
						methodName: "onSysEntitySchemaChanged"
					}]
				}
			},
			methods: {

				/**
				 * ######### ####### ### ####### ## ######### ###### #########.
				 * @private
				 * @return {Terrasoft.FilterGroup} ####### ### ####### ## ######### ###### #########.
				 */
				getSysWorkspaceFilter: function() {
					var filters = this.Ext.create("Terrasoft.FilterGroup");
					filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"SysWorkspace",
						this.Terrasoft.SysValue.CURRENT_WORKSPACE.value
					));
					filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"ManagerName",
						"ProcessSchemaManager"
					));
					return filters;
				},

				/**
				 * ############ ####### ######### #### SysEntitySchema.
				 * @private
				 */
				onSysEntitySchemaChanged: function() {
					var entity = this.get("SysEntitySchema");
					var uid = entity && entity.UId;
					this.set("SysEntitySchemaUId", uid);
					var name = entity && entity.Caption;
					this.set("Name", name);
				},

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#loadEntity
				 * @overridden
				 */
				loadEntity: function(primaryColumnValue, callback, scope) {
					this.callParent([primaryColumnValue, function() {
						this.loadVirtualColumnValues("SysEntitySchema", "SysEntitySchemaUId", callback, scope);
					}, this]);
				}

			},
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/

		};
	});
