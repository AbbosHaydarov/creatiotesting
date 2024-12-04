define("FilterEntitiesCatalogSectionV2", ["BusinessRulesApplierV2",
	"ConfigurationGridLookupUtilities"],
	function() {
		return {
			attributes: {
				/**
				 * ########### ####### ##### ###########.
				 */
				"SysEntitySchema": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			mixins: {
				/**
				 * ###### ######### ###### ######### ######## ########### ####### ####.
				 */
				ConfigurationGridLookupUtilities: "Terrasoft.ConfigurationGridLookupUtilities"
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.configuration.BaseSchemaViewModel#getEditPageSchemaName
				 * @overridden
				 */
				getEditPageSchemaName: function() {
					return "FilterEntitiesCatalogPageV2";
				},

				/**
				 * @inheritDoc BaseLookupConfigurationSection#getDefaultConfigurationGridItemSchemaName
				 * @overridden
				 */
				getDefaultConfigurationGridItemSchemaName: function() {
					return "FilterEntitiesCatalogPageV2";
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#actualizeTiledGridConfig
				 * @overridden
				 */
				actualizeListedGridConfig: function(viewGenerator, gridConfig) {
					this.callParent(arguments);
					this.applyConfig(gridConfig);
				},

				/**
				 * ######### # ############ ####### ########## ####### ########### ####### SysEntitySchema.
				 * @param {Object} gridConfig ######, ########## ######### ####### #######.
				 */
				applyConfig: function(gridConfig) {
					var listedConfig = gridConfig.listedConfig;
					var caption = {
						"cols": 12,
						"name": this.get("Resources.Strings.SysEntitySchemaCaption")
					};
					var column = {
						"cols": 12,
						"key": [
							{
								"name": {"bindTo": "SysEntitySchema"},
								"type": this.Terrasoft.GridCellType.TEXT
							}
						]
					};
					this.Ext.Array.insert(listedConfig.captionsConfig, 0, [caption]);
					this.Ext.Array.insert(listedConfig.columnsConfig, 0, [column]);
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#onGridLoaded
				 * @overridden
				 */
				onGridLoaded: function() {
					this.reloadGridColumnsConfig(false);
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#getGridRowViewModelConfig
				 * @overridden
				 */
				getGridRowViewModelConfig: function(config) {
					this.applyGridRowViewModelConfig(config);
					var gridRowViewModelConfig = this.callParent(arguments);
					return gridRowViewModelConfig;
				},

				/**
				 * ####### # ############ ###### ###### ####### ######## SysEntitySchema # ######## ###.
				 * @private
				 * @param {Object} config ############ ###### ###### #######.
				 */
				applyGridRowViewModelConfig: function(config) {
					var rowData = config.rawData;
					if (rowData && rowData.hasOwnProperty("SysEntitySchema")) {
						rowData.SysEntitySchema = {
							displayValue: rowData.SysEntitySchema,
							value: rowData.SysEntitySchemaUId
						};
					}
					var rowConfig = config.rowConfig;
					if (rowConfig && rowConfig.hasOwnProperty("SysEntitySchema")) {
						this.Ext.apply(rowConfig.SysEntitySchema, {
							dataValueType: this.Terrasoft.DataValueType.LOOKUP,
							isLookup: true,
							referenceSchemaName: "VwSysSchemaInfo"
						});
					}
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#initQueryColumns
				 * @overridden
				 */
				initQueryColumns: function(esq) {
					esq.addColumn("[VwSysSchemaInfo:UId:SysEntitySchemaUId].Caption", "SysEntitySchema");
					this.callParent(arguments);
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilities#initQueryOptions
				 * @overridden
				 */
				initQueryOptions: function(esq) {
					esq.isDistinct = true;
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilities#sortColumn
				 * @overridden
				 */
				sortColumn: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.ConfigurationGridUtilities#setDefaultFocus
				 * @overridden
				 */
				setDefaultFocus: function() {
					this.focusActiveRowControl("SysEntitySchema");
				}

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "SeparateModeViewOptionsButton"
				},
				{
					"operation": "remove",
					"name": "activeRowActionCopy"
				}
			]/**SCHEMA_DIFF*/
		};
	});
