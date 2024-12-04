define("LeadProductDetailV2", ["ConfigurationConstants"],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "LeadProduct",
			methods: {
				/**
				 * ############# ######## ## #########.
				 * @private
				 */
				setDefaultValues: function(callback, scope) {
					var defaultValues = this.get("DefaultValues");
					if (defaultValues) {
						this.Terrasoft.each(defaultValues, function(defValue) {
							this.set(defValue.name, defValue);
						}, this);
					}
					this.Ext.callback(callback, scope);
				},

				/**
				 * ######### ###### ######## ########## ##########
				 * @protected
				 * @overridden
				 */
				updateDetail: function() {
					this.callParent(arguments);
					this.setDefaultValues();
				},

				/**
				 * ######## ########## ### ######### ## #######.
				 * param callback {Function}
				 * @private
				 */
				initProductFolderFilter: function(callback) {
					var leadType = this.get("LeadType");
					if (!this.Ext.isEmpty(leadType)) {
						var productFolderFilterPath = "[ProductInLeadType:ProductFolder:Id].LeadType";
						// ###### ######## ## ########### # ############ #######
						var subProductFolderFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						subProductFolderFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
						var select = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "ProductFolder"
						});
						select.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
						select.addColumn("SearchData");
						select.addColumn("FolderType.Id");
						// ########## ## #### ###########, ### ###### #####
						var selectProductFolderFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						var productFolderFilter = this.Terrasoft.createColumnInFilterWithParameters(productFolderFilterPath,
							[leadType.value]);
						selectProductFolderFilterGroup.addItem(productFolderFilter);
						select.filters.addItem(this.Terrasoft.createExistsFilter("Id", selectProductFolderFilterGroup));
						select.getEntityCollection(function(response) {
							if (response && response.success) {
								var staticFolders = [];
								response.collection.each(function(responseItem) {
									var folderType = responseItem.get("FolderType.Id");
									var searchData = responseItem.get("SearchData");
									switch (folderType) {
										// ########## ########### ##### # ######
										case ConfigurationConstants.Folder.Type.General:
											staticFolders.push(responseItem.get("Id"));
											break;
											// ########## ############ ##### # ######
										case ConfigurationConstants.Folder.Type.Search:
											if (!this.Ext.isEmpty(searchData)) {
												subProductFolderFilterGroup.addItem(this.Terrasoft.deserialize(searchData));
											}
											break;
									}
								}, this);
								// ########## ########### ##### # ######
								if (staticFolders.length > 0) {
									var staticFoldersFilter = this.Terrasoft.createColumnInFilterWithParameters(
										"[ProductInFolder:Product].Folder", staticFolders);
									staticFoldersFilter.rootSchemaName = "Product";
									subProductFolderFilterGroup.addItem(staticFoldersFilter);
								}
								this.set("ProductFolderFilter", subProductFolderFilterGroup);
								if (this.Ext.isFunction(callback)) {
									callback.call(this);
								}
							} else {
								this.set("ProductFolderFilter", null);
							}
						}, this);
					} else {
						this.set("ProductFolderFilter", null);
					}
				},

				/**
				 * ############## ######### ###### ############# ########
				 * @protected
				 */
				initData: function() {
					this.callParent(arguments);
					this.setDefaultValues();
				},

				/**
				 * ######### ########## #########
				 * @private
				 */
				openProductLookup: function() {
					var config = {
						entitySchemaName: "Product",
						multiSelect: true,
						columns: ["Name", "Price", "Currency"]
					};
					var leadType = this.get("LeadType");
					var leadId = this.get("MasterRecordId");
					if (this.Ext.isEmpty(leadId) || this.Ext.isEmpty(leadType)) {
						return;
					}
					var handler = function() {
						var mainFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						var leadFilterPath = "[LeadProduct:Product:Id].Lead";
						var productFilterPath = "[ProductInLeadType:Product:Id].LeadType";
						// ###### ## ### ########### #########
						var subLeadFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						// ###### ## ######### # #### ###########
						var subProductFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						var existsFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						// ###### ## ####### ######### # #### ###########
						var subProductFolderFilterGroup = this.get("ProductFolderFilter");
						var leadFilter = this.Terrasoft.createColumnInFilterWithParameters(leadFilterPath, [leadId]);
						var productFilter = this.Terrasoft.createColumnInFilterWithParameters(productFilterPath,
							[leadType.value]);
						subLeadFilterGroup.addItem(leadFilter);
						subProductFilterGroup.addItem(productFilter);
						var notExistsFilter = this.Terrasoft.createNotExistsFilter("Id", subLeadFilterGroup);
						var existsFilter = this.Terrasoft.createExistsFilter("Id", subProductFilterGroup);
						existsFilterGroup.addItem(existsFilter);
						if (!this.Ext.isEmpty(subProductFolderFilterGroup)) {
							existsFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
							existsFilterGroup.addItem(subProductFolderFilterGroup);
						}
						mainFilterGroup.addItem(notExistsFilter);
						mainFilterGroup.addItem(existsFilterGroup);
						config.filters = mainFilterGroup;
						this.openLookup(config, this.addCallBack, this);
					};
					this.initProductFolderFilter(handler);
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	}
);
