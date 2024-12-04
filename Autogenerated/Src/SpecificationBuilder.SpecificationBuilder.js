define("SpecificationBuilder", ["SpecificationBuilderResources", "ViewUtilities", "SpecificationValue",
	"SpecificationRow", "BaseSpecificationItemViewModel"],
	function(resources, ViewUtilities) {
	return {
		attributes: {
			/**
			 * ######### ####### ##### {@link Terrasoft.BaseSpecificationRowViewModel}.
			 */
			"RowsCollection": {
				"dataValueType": Terrasoft.DataValueType.COLLECTION
			}
		},
		messages: {

			/**
			 * @message LoadRowsConfig
			 * ######## # SpecificationBuilder ######### ####### ##### # ### ############## #######
			 * (###############, ########## ######## ###### # #####).
			 */
			"LoadRowsConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message GetBuilderConfig
			 * ########### # ###### ###### ## ######### ####### #########, ### ###### ### ##### # ##### defaultValues.
			 * ### ###### ########## # ####### ######### {@link SetBuilderConfig}.
			 */
			"GetBuilderConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message SetBuilderConfig
			 * # ####### ####### ####### ## ######## # SpecificationBuilder ###### ## ######### ####### #########,
			 * ### ###### ### #####, # ### ## ##### defaultValues.
			 */
			"SetBuilderConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		methods: {

			/**
			 * @inheritDoc BaseSchemaViewModel#init
			 * @overridden
			 */
			init: function() {
				this.subscribeOnMessages();
				this.sandbox.publish("GetBuilderConfig", {}, [this.sandbox.id]);
				this.callParent(arguments);
				var rowsCollection = this.getRowsCollection();
				this.subscribeForItemsCollectionEvents(rowsCollection);
			},

			/**
			 * ############# ###### ####### ######### #########.
			 * @protected
			 */
			refreshPositionIndex: function() {
				var rowsCollection = this.getRowsCollection();
				var items = rowsCollection.getItems();
				for (var index = 0; index < items.length; index++) {
					var item = items[index];
					item.set("RowPosition", index);
					item.refreshPositionIndex();
				}
			},

			/**
			 * ############ ####### ######## ######.
			 * @protected
			 * @param {Object} id ############# ######.
			 */
			onRowRemove: function(id) {
				var rowsCollection = this.getRowsCollection();
				rowsCollection.removeByKey(id);
				this.refreshPositionIndex();
			},

			/**
			 * ############ ####### {@link Terrasoft.Collection#itemChanged}.
			 * @protected
			 * @virtual
			 * @param {Terrasoft.BaseViewModel} item ####### #########, # ####### ######### #########.
			 * @param {Object} config ######### #######.
			 */
			onItemChanged: function(item, config) {
				var itemConfig = config.arguments;
				var id = itemConfig && itemConfig.id;
				if (config.event === "onRemove") {
					this.onRowRemove(id);
				}
			},

			/**
			 * ########## ######### #####.
			 * @protected
			 * @return {Terrasoft.BaseViewModelCollection} ######### #####.
			 */
			getRowsCollection: function() {
				return this.get("RowsCollection");
			},

			/**
			 * ######### ######### #####.
			 * @param {Array} rowsConfigCollection ###### ########### {@link Terrasoft.BaseViewModel}.
			 * @protected
			 */
			loadRowsCollection: function(rowsConfigCollection) {
				var rowsCollection = this.getRowsCollection();
				this.Terrasoft.each(rowsConfigCollection, function(values) {
					var id = this.Terrasoft.generateGUID();
					var rowViewModel = this.getRowViewModel(id);
					rowViewModel.loadEntity(values);
					rowsCollection.add(id, rowViewModel);
				}, this);
			},

			/**
			 * ############# ## ####### ######### ######## ######### #####.
			 * @protected
			 * @virtual
			 * @param {Terrasoft.BaseViewModelCollection} items ######### #####.
			 */
			subscribeForItemsCollectionEvents: function(items) {
				items.on("itemChanged", this.onItemChanged, this);
			},

			/**
			 * ############# ## ######### {@link SetBuilderConfig} # {@link LoadRowsConfig}.
			 * @protected
			 */
			subscribeOnMessages: function() {
				this.sandbox.subscribe("SetBuilderConfig", function(config) {
					this.onGetBuilderConfig(config);
				}, this, [this.sandbox.id]);
				this.sandbox.subscribe("LoadRowsConfig", function(rowsConfig) {
					this.loadRowsCollection(rowsConfig);
				}, this, [this.sandbox.id]);
			},

			/**
			 * ######## ###### ######### ###### # ############## ######### #####,
			 * ##### ###### ### ###### # ######## ##-#########.
			 * @protected
			 * @param {Object} config ###### ######### ######.
			 */
			onGetBuilderConfig: function(config) {
				this.set("RowsCollection", config.rowsCollection);
				this.set("RowViewModelClassName", config.rowViewModelClassName);
				this.set("DefaultValues", config.defaultValues);
			},

			/**
			 * ######### ###### ############ ######.
			 * @protected
			 * @param {Object} itemConfig ###### ############ ######.
			 */
			onGetRowViewConfig: function(itemConfig, viewModel) {
				var config = ViewUtilities.getContainerConfig("row-view-container", []);
				var valueConfig = viewModel.getRowViewConfig();
				config.items.push(valueConfig);
				itemConfig.config = config;
			},

			/**
			 * ######### # ######### ##### ##### ######### {@link Terrasoft.BaseSpecificationRowViewModel}.
			 * @protected
			 */
			onAddSpecificationRowClickHandler: function() {
				var collection = this.getRowsCollection();
				var id = this.Terrasoft.generateGUID();
				collection.add(id, this.getRowViewModel(id));
			},

			/**
			 * ########## ######### {@link Terrasoft.BaseSpecificationRowViewModel}.
			 * @protected
			 * @param {String} id ############# ######.
			 * @return {Terrasoft.BaseSpecificationRowViewModel} ##### ######### ###### ######.
			 */
			getRowViewModel: function(id) {
				var collection = this.getRowsCollection();
				var rowPosition = collection.getCount();
				var specificationViewModelConfig = {
					Ext: this.Ext,
					Terrasoft: this.Terrasoft,
					sandbox: this.sandbox,
					values: {
						"DefaultValues": this.get("DefaultValues"),
						"ParentItem": this,
						"RowValuesCollection": this.Ext.create("Terrasoft.BaseViewModelCollection"),
						"Id": id,
						"RowPosition": rowPosition,
						"ToolItemsConfig": [
							{
								"className": "Terrasoft.Button",
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"caption": this.get("Resources.Strings.AddValueButtonCaption"),
								"tag": "add"
							}
						]
					}
				};
				return this.Ext.create(this.get("RowViewModelClassName"), specificationViewModelConfig);
			}
		},
		diff: [
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "SpecificationRowContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"id": "specificationRowContainer",
					"selectors": {"wrapEl": "#specificationRowContainer"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "SpecificationRowContainerList",
				"parentName": "SpecificationRowContainer",
				"propertyName": "items",
				"values": {
					"generator": "ConfigurationItemGenerator.generateContainerList",
					"idProperty": "ElementId",
					"collection": "RowsCollection",
					"onGetItemConfig": "onGetRowViewConfig"
				}
			},
			{
				"operation": "insert",
				"name": "AddNewSpecificationRowButton",
				"parentName": "SpecificationRowContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"classes": {"textClass": ["add-specification-row"]},
					"caption": {"bindTo": "Resources.Strings.AddRowButtonCaption"},
					"click": {"bindTo": "onAddSpecificationRowClickHandler"}
				}
			}
		]
	};
});
