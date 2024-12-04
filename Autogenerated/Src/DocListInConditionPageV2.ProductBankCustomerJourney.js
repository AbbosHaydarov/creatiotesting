define("DocListInConditionPageV2", ["FilterEditModule"],
	function() {
		return {
			entitySchemaName: "DocListInCondition",
			attributes: {
				/**
				 * Filtration object schema name.
				 */
				"FilterEntitySchemaName": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dependencies": [{
						"columns": ["DocumentListStage"],
						"methodName": "updateFilterModule"
					}]
				}
			},
			mixins: {},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Document",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.LOOKUP,
						"value": {"bindTo": "Document"},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "DocListGroup",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": this.Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "DocListGroup"},
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "DocumentListStage",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "DocumentListStage"},
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "ParticipantRole",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "ParticipantRole"},
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "DocumentType",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"value": {"bindTo": "DocumentType"},
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "SysModuleReport",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.LOOKUP,
						"value": {"bindTo": "SysModuleReport"},
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "IsRequired",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 6,
							"colSpan": 10
						}
					}
				},
				{
					"operation": "insert",
					"name": "FilterProperties",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"id": "FilterProperties",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"layout": {
							"column": 15,
							"row": 0,
							"colSpan": 9,
							"rowSpan": 12
						}
					}
				},
				{
					"operation": "remove",
					"name": "actions"
				}
			]/**SCHEMA_DIFF*/,
			messages: {
				/**
				 * Subscription on filter change.
				 */
				"OnFiltersChanged": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * Subscription on receiving of filter module configuration object.
				 */
				"GetFilterModuleConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * Publishing message about setting filter module.
				 */
				"SetFilterModuleConfig": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			methods: {

				/**
				 * Returns Id of filtration module.
				 * @protected
				 * @return {String} Filtration module Id.
				 */
				getFilterEditModuleId: function() {
					return this.sandbox.id + "_ExtendedFilterEditModule";
				},

				/**
				 * Loads filter module.
				 * @protected
				 */
				loadFilterModule: function() {
					var moduleId = this.getFilterEditModuleId();
					this.sandbox.subscribe("OnFiltersChanged", this.onFiltersChanged, this, [moduleId]);
					this.sandbox.subscribe("GetFilterModuleConfig", this.onGetFilterModuleConfig, this, [moduleId]);
					this.sandbox.loadModule("FilterEditModule", {
						renderTo: "FilterProperties",
						id: moduleId
					});
					this.set("FilterModuleLoaded", true);
				},

				/**
				 * Sets FilterConfig by filter that was received from filtration module.
				 * @param {Object} args Object with serialized filter.
				 * @protected
				 */
				onFiltersChanged: function(args) {
					this.hideBodyMask();
					this.setFilterConfig(args.serializedFilter);
				},

				/**
				 * Sets field FilterConfigand flag HasFilters in objects.
				 * @param {String} serializedFilter Serialized filter.
				 * @private
				 */
				setFilterConfig: function(serializedFilter) {
					this.set("FilterConfig", serializedFilter);
					var filters = this.Terrasoft.deserialize(serializedFilter);
					this.set("HasFilters", this.Ext.isEmpty(filters) ? false : filters.getCount() > 0);
				},

				/**
				 * Returns config for filtration module.
				 * @protected
				 * @return {Object} Cofiguration object.
				 */
				onGetFilterModuleConfig: function() {
					return {
						rootSchemaName: this.get("FilterEntitySchemaName"),
						filters: this.get("FilterConfig")
					};
				},

				/**
				 * Unloads filter module.
				 * @protected
				 */
				unloadFilterModule: function() {
					var moduleId = this.getFilterEditModuleId();
					this.sandbox.unloadModule(moduleId);
					this.set("FilterModuleLoaded", false);
				},

				/**
				 * Creates Terrasoft.EntitySchemaQuery instance for receiving SysEntitySchemaName of FilterEntity that
				 * is specified in DocumentListStage record.
				 * @protected
				 * @return {Terrasoft.EntitySchemaQuery} Terrasoft.EntitySchemaQuery instance with initialized
				 * rootSchemaName and columns
				 */
				getEsqForInitFilterEntityByDocListStage: function() {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "DocumentListStage"
					});
					esq.addColumn("FilterEntity.SysEntitySchemaName", "FilterEntitySchemaName");
					return esq;
				},

				/**
				 * Initializes FilterEntitySchemaName property depending on the DocumentListStage property and calls
				 * callback function.
				 * @protected
				 * @param {Function} callback The callback function.
				 * @param {Object} scope The scope of callback function.
				 */
				initFilterEntity: function(callback, scope) {
					var docListStage = this.get("DocumentListStage");
					if (docListStage && docListStage.value) {
						this.initFilterEntityByDocListStage(docListStage.value, callback, scope);
					} else {
						this.set("FilterEntitySchemaName", null);
						this.Ext.callback(callback, scope);
					}
				},

				/**
				 * Receives SysEntitySchemaName of FilterEntity that is specified in DocumentListStage record,
				 * sets is to FilterEntitySchemaName property and calls callback funcion.
				 * @protected
				 * @param {Guid} docListStageId Id of document list stage record.
				 * @param {Function} callback The callback function.
				 * @param {Object} scope The scope of callback function.
				 */
				initFilterEntityByDocListStage: function(docListStageId, callback, scope) {
					var esq = this.getEsqForInitFilterEntityByDocListStage();
					esq.getEntity(docListStageId, function(result) {
						var entity = result.success ? result.entity : null;
						this.initFilterEntityByDocListStageCallback(entity);
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * Processes result of query in initFilterEntityByDocListStage method.
				 * @protected
				 * @param {Object} entity Object with entity that returned by query.
				 */
				initFilterEntityByDocListStageCallback: function(entity) {
					var entitySchemaName = !this.Ext.isEmpty(entity)
						? entity.get("FilterEntitySchemaName")
						: null;
					this.set("FilterEntitySchemaName", entitySchemaName);
				},

				/**
				 * Updates filter module. Clears filter if filter object is changed.
				 * @protected
				 * @param {Function} callback The callback function.
				 * @param {Object} scope The scope of callback function.
				 */
				updateFilterModule: function(callback, scope) {
					this.showBodyMask();
					this.initFilterEntity(function() {
						var filterEntitySchemaName = this.get("FilterEntitySchemaName");
						if (this.Ext.isEmpty(filterEntitySchemaName)) {
							if (this.get("FilterModuleLoaded")) {
								this.setFilterConfig(null);
								this.unloadFilterModule();
							}
							this.hideBodyMask();
						} else if (!this.get("FilterModuleLoaded")) {
							this.loadFilterModule();
						} else {
							var config = this.get("IsEntityInitialized") ? null : this.get("FilterConfig");
							this.setFilterModuleConfig(filterEntitySchemaName, config);
						}
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * Publishes message SetFilterModuleConfig for filtration module.
				 * @param {String} entitySchemaName Name of object that conditions will be setting for.
				 * @param {String} filterConfig Serialized filter.
				 * @protected
				 */
				setFilterModuleConfig: function(entitySchemaName, filterConfig) {
					var moduleId = this.getFilterEditModuleId();
					this.sandbox.publish("SetFilterModuleConfig", {
						rootSchemaName: entitySchemaName,
						filters: filterConfig
					}, [moduleId]);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.updateFilterModule();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onDiscardChangesClick
				 * @overridden
				 */
				onDiscardChangesClick: function() {
					if (this.isNew) {
						this.sandbox.publish("BackHistoryState");
						return;
					}
					this.set("IsEntityInitialized", false);
					this.loadEntity(this.get("Id"), function() {
						this.updateButtonsVisibility(false, {
							force: true
						});
						this.initMultiLookup();
						this.updateFilterModule(function() {
							this.set("IsEntityInitialized", true);
							this.discardDetailChange();
						}, this);
					}, this);
					if (this.get("ForceUpdate")) {
						this.set("ForceUpdate", false);
					}
				}
			}
		};
	});
