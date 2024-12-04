define("AppFormCommunicationDetail", ["ConfigurationConstants", "ViewUtilities", "DetailEntityMappingMixin",
		"BaseCommunicationDetail", "css!FinAppLendingCSS"
	],
	function(ConfigurationConstants, ViewUtilities) {
		return {
			entitySchemaName: "AppFormCommunication",
			mixins: {
				DetailEntityMappingMixin: "Terrasoft.DetailEntityMappingMixin"
			},
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#initCommunicationTypesFilters
				 * @overridden
				 */
				initCommunicationTypesFilters: function(esq) {
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"UseforContacts",
						true));
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.NOT_EQUAL,
						"[ComTypebyCommunication:CommunicationType:Id].Communication",
						ConfigurationConstants.Communication.SMS));
				},

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#initQueryFilters
				 * @overridden
				 */
				initQueryFilters: function(esq) {
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"CommunicationType.UseforContacts", true));
					esq.filters.addItem(this.get("Filter"));
				},

				/**
				 * Returns delete button config.
				 * @protected
				 * @return {Object} Delete button config.
				 */
				getDeleteButtonConfig: function() {
					var deleteButtonConfig = {
						className: "Terrasoft.Button",
						click: {
							bindTo: "deleteItem"
						},
						style: this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						imageConfig: this.get("Resources.Images.DeleteIcon"),
						classes: {
							wrapperClass: ["delete-button-class"]
						},
						markerValue: "delete-detail-item-button"
					};
					return deleteButtonConfig;
				},

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#getCommunicationItemViewConfig
				 * @overridden
				 */
				getCommunicationItemViewConfig: function() {
					var itemViewConfig = ViewUtilities.getContainerConfig("item-view",
						["detail-edit-container-user-class", "control-width-15"]);
					var typeRowContainer = ViewUtilities.getContainerConfig("type-delete-item-view",
						["type-delete-container-user-class"]);
					var typeMenuItems = this.getTypeMenuItems();
					var typeButtonConfig = this.getTypeButtonConfig(typeMenuItems);
					var deleteButtonConfig = this.getDeleteButtonConfig();
					var textEditConfig = this.getTextEditConfig();
					typeRowContainer.items.push(typeButtonConfig, deleteButtonConfig);
					itemViewConfig.items.push(typeRowContainer, textEditConfig);
					return itemViewConfig;
				},

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#addDeleteMenuItem
				 * @overridden
				 */
				addDeleteMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#initDetailOptions
				 * @overridden
				 */
				initDetailOptions: function() {
					this.callParent(arguments);
					this.set("IsDetailCollapsed", false);
				},

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#getTextEditConfig
				 * @overridden
				 */
				getTextEditConfig: function() {
					var config = this.callParent(arguments);
					delete config.href;
					delete config.linkclick;
					return config;
				},

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#getDetailRowItemsViewConfig
				 * @overridden
				 */
				getDetailRowItemsViewConfig: function() {
					var rowViewConfig = [];
					this.Terrasoft.each(this.getDisplayColumns(), function(displayColumn) {
						var column = this.findEntityColumn(displayColumn);
						if (column) {
							var columnName = column.name;
							var dataValueType = column.dataValueType;
							var defaultItemConfig = {
								itemType: this.Terrasoft.ViewItemType.MODEL_ITEM,
								dataValueType: dataValueType,
								name: columnName,
								wrapClass: ["field-detail-row-left-item"],
								markerValue: columnName
							};
							rowViewConfig.push(defaultItemConfig);
						}
					}, this);
					return rowViewConfig;
				},

				/**
				 * Returns row view model configuration.
				 * @protected
				 * @param {Object} config Row configuration.
				 * @return {Object} Row view model configuration.
				 */
				getRowViewModelConfig: function(config) {
					config = config || {};
					config.rawData = config.rawData || {};
					var isNew = config.isNew || false;
					if (isNew) {
						this.Ext.apply(config.rawData, {
							Id: this.Terrasoft.generateGUID()
						});
					}
					this.Ext.apply(config.rawData, {
						DetailColumnName: this.get("DetailColumnName"),
						DefaultValues: this.get("DefaultValues")
					});
					var gridRowViewModelConfig = {
						entitySchema: this.entitySchema,
						isNew: isNew,
						isDeleted: false,
						Ext: this.Ext,
						Terrasoft: this.Terrasoft,
						sandbox: this.sandbox,
						columns: this.columns,
						rowConfig: config.rowConfig,
						values: config.rawData
					};
					return gridRowViewModelConfig;
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.initStateMixinMessages();
				},

				/**
				 * @inheritdoc Terrasoft.mixins.DetailEntityMappingMixin#addDetailItem
				 * @overridden
				 */
				addDetailItem: function(columnValues) {
					columnValues = columnValues || [];
					var communicationType = columnValues.filter(function(item) {
						if (item.Key === "CommunicationType") {
							return true;
						}
					});
					var typeId = communicationType[0];
					typeId = this.Ext.isObject(typeId) ? typeId.Value : typeId;
					typeId = this.Ext.isObject(typeId) ? typeId.value : typeId;
					return this.addItem(typeId);
				},

				/**
				 * Clears detail collection.
				 * @protected
				 */
				clearCollection: function() {
					var collection = this.get("Collection");
					collection.each(function(item) {
						this.deleteItem(item);
					}, this);
				}

				//endregion

			}
		};
	});
