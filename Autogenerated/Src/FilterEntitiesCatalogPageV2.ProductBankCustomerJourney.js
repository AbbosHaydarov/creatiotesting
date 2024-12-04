define("FilterEntitiesCatalogPageV2", ["FilterEntitiesCatalogPageV2Resources", "ConfigurationGridLookupUtilities"],
	function(resources) {
		return {
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
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
							var filters = this.Ext.create("Terrasoft.FilterGroup");
							filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL,
								"SysWorkspace",
								this.Terrasoft.SysValue.CURRENT_WORKSPACE.value
							));
							filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL,
								"ManagerName",
								"EntitySchemaManager"
							));
							return filters;
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
						methodName: "sysEntitySchemaChanged"
					}]
				}
			},
			methods: {

				/**
				 * ############ ####### ######### #### SysEntitySchema.
				 * @private
				 */
				sysEntitySchemaChanged: function() {
					var entity = this.get("SysEntitySchema");
					var uid = this.Ext.isEmpty(entity) ? null : entity.UId;
					var name = this.Ext.isEmpty(entity) ? null : entity.Name;
					this.set("SysEntitySchemaUId", uid);
					this.set("SysEntitySchemaName", name);
					if (!this.Ext.isEmpty(entity)) {
						this.set("Caption", entity.Caption);
					}
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
