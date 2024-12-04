define("OBSWPendingConsultationPanelSchema", ["OBSWPendingConsultationPanelSchemaResources", "Case",
		"GridUtilitiesV2", "ConfigurationVerticalGridGenerator", "OBSWConsultationPanelMixin"
	],
	function(resources) {
		return {
			entitySchemaName: "Case",
			mixins: {
				GridUtilities: "Terrasoft.GridUtilities",
				OBSWConsultationPanelMixin: "Terrasoft.OBSWConsultationPanelMixin"
			},
			messages: {

				/**
				 * @message GetHistoryState
				 * ######### ########### ####### ######### #######.
				 * @param {Object} config ################ ######.
				 */
				"GetHistoryState": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message PushHistoryState
				 * ######### ############# ##### ######### #######.
				 * @param {Object} config ################ ###### ###### #########.
				 */
				"PushHistoryState": {
					mode: this.Terrasoft.MessageMode.BROADCAST,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message ContinueConsultation
				 * ######### #### ####### ########## ############.
				 * @param {Object} config ################ ######.
				 */
				"ContinueConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message LoadPendingConsultations
				 * ######### ######### ###### ############ ## #########.
				 * @param {Object} config ###### # ##########.
				 * @param {Guid} excludeCaseId ############# ############ #########.
				 * @param {Object} owner ####### ############# ## #########.
				 */
				"LoadPendingConsultations": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message GetCurrentConsultation
				 * ######### ########### ####### ############.
				 * {Object} config ################ ######.
				 */
				"GetCurrentConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {

				/**
				 * ######### ######.
				 * @type {Terrasoft.BaseViewModelCollection}
				 */
				"Collection": {
					"dataValueType": Terrasoft.DataValueType.COLLECTION
				},

				/**
				 * ######## ######### ####### ######## ###### #######.
				 * @type {Guid}
				 */
				"ActiveRow": {
					"dataValueType": Terrasoft.DataValueType.GUID
				},

				/**
				 * ####### "#### ######".
				 * @type {Boolean}
				 */
				"IsGridEmpty": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN
				},

				/**
				 * ####### "#### # ######## ########".
				 * @type {Boolean}
				 */
				"IsGridLoading": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN
				},

				/**
				 * ########### ####### ########## # #######.
				 * @type {Number}
				 */
				"RowCount": {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": 5
				},

				/**
				 * ############ ########.
				 * @type {Boolean}
				 */
				"IsPageable": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": true
				},

				/**
				 * ############ ## ######### ### ##########.
				 * @type {Object}
				 */
				"FilteredOwner": {
					"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT
				},

				/**
				 * ######## ############ ######### ### ##########.
				 * @type {Guid}
				 */
				"ExcludeCaseId": {
					"dataValueType": Terrasoft.DataValueType.GUID
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function(callback, scope) {
					var currentConsultationConfig = this.getCurrentConsultation();
					var excludeCaseId = currentConsultationConfig.caseId;
					var loadPendingConfig = {
						owner: this.Terrasoft.SysValue.CURRENT_USER_CONTACT,
						excludeCaseId: excludeCaseId
					};
					this.callParent([function() {
						this.initData(function() {
							this.subscribeSandboxEvents();
							this.mixins.GridUtilities.init.call(this);
							callback.call(scope);
							this.loadPendingConsultations(loadPendingConfig);
						}, this);
					}, this]);
				},

				/**
				 * ############## ######### ###### ############# ########.
				 * @protected
				 */
				initData: function(callback, scope) {
					this.set("Collection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
					callback.call(scope);
				},

				/**
				 * ########## ###### ####### ############.
				 * @protected
				 * @return {Object} ###### ####### ############
				 */
				getCurrentConsultation: function() {
					return this.sandbox.publish("GetCurrentConsultation", null, [this.getOBSWModuleId()]);
				},

				/**
				 * ############# ## #########, ########### ### ######.
				 * @protected
				 */
				subscribeSandboxEvents: function() {
					var sandbox = this.sandbox;
					sandbox.subscribe("LoadPendingConsultations", function(config) {
						this.loadPendingConsultations(config);
					}, this, this.getSandboxTags(sandbox.id));
				},

				/**
				 * ########## ############# ###### ####### ####.
				 * @protected
				 * @return {String} ############# ###### ####### ####.
				 */
				getOBSWModuleId: function() {
					return this.sandbox.id.replace("_OBSWPendingConsultationPanelSchemaModule", "");
				},

				/**
				 * ########## ######### #######.
				 * @protected
				 * @return {Object}
				 */
				getGridData: function() {
					return this.get("Collection");
				},

				/**
				 * ######### ###### # ###### # ############ ######### ######.
				 * @protected
				 */
				onLoadMoreClick: function() {
					this.loadGridData();
				},

				loadPendingConsultations: function(config) {
					config = config || {};
					this.set("FilteredOwner", config.owner);
					this.set("ExcludeCaseId", config.excludeCaseId);
					this.reloadGridData();
				},

				/**
				 * ########## ########### ####### ### ###### ########## ############.
				 * @protected
				 * @return {Terrasoft.FilterGroup} ########### ####### ### ###### ########## ############.
				 */
				getFilters: function() {
					var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
					var excludeCaseId = this.get("ExcludeCaseId");
					var filteredOwner = this.get("FilteredOwner");
					filteredOwner = this.Ext.isEmpty(filteredOwner) ? this.Terrasoft.SysValue.CURRENT_USER_CONTACT : filteredOwner;
					filteredOwner = this.Ext.isObject(filteredOwner) ? filteredOwner.value : filteredOwner;
					filterGroup.add("ownerFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"Owner",
						filteredOwner,
						this.Terrasoft.DataValueType.GUID));
					filterGroup.add("statusFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.NOT_EQUAL,
						"Status.IsFinal",
						true,
						this.Terrasoft.DataValueType.BOOLEAN));
					if (excludeCaseId) {
						filterGroup.add("excludeCaseFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.NOT_EQUAL,
							"Id",
							excludeCaseId,
							this.Terrasoft.DataValueType.GUID));
					}
					return filterGroup;
				},

				/**
				 * ########## #######, ####### ###### ########## ########.
				 * @protected
				 * @return {Object} ########## ###### ########-############ #######.
				 */
				getGridDataColumns: function() {
					var defColumnsConfig = this.mixins.GridUtilities.getGridDataColumns.call(this);
					var columnsConfig = {
						Contact: {
							path: "Contact",
							orderDirection: this.Terrasoft.core.enums.OrderDirection.ASC,
							orderPosition: 0
						},
						PostponedOn: {
							path: "PostponedOn"
						}
					};
					this.Ext.apply(defColumnsConfig, columnsConfig);
					return defColumnsConfig;
				},

				/**
				 * ############ ####### "########" ######## ######.
				 * @protected
				 * @param {String} buttonTag ### "########".
				 * @param {String} primaryColumnValue ########## ############# ######## ######.
				 */
				onActiveRowAction: function(buttonTag, primaryColumnValue) {
					var gridData = this.getGridData();
					var activeRow = gridData.get(primaryColumnValue);
					switch (buttonTag) {
						case "continue":
							this.continueConsultation(primaryColumnValue, activeRow.get("Contact"));
							break;
					}
				},

				/**
				 * ######## ######### ### ########### ############.
				 * @protected
				 * @param {Guid} caseId ############# #########.
				 * @param {Object} contact ####### #########.
				 */
				continueConsultation: function(caseId, contact) {
					var config = {
						caseId: caseId,
						contact: contact
					};
					this.sandbox.publish("ContinueConsultation",
						config, [this.getOBSWModuleId()]);
				},

				/**
				 * ########## #### #######.
				 * @return {String} ####.
				 */
				getProfileKey: function() {
					return this.name + "GridSettings";
				},

				/**
				 * ############ ####### ## ###### # ####### ########## ######.
				 * @protected
				 * @param {String} rowId ############# ######.
				 * @param {String} columnName ### #######.
				 * @return {Boolean} ########## ####### ######## ## ######.
				 */
				onLinkClicked: function(rowId, columnName) {
					var result = true;
					var contactColumnName = "Contact";
					if (columnName === contactColumnName) {
						var gridData = this.getGridData();
						var activeRow = gridData.get(rowId);
						this.continueConsultation(rowId, activeRow.get(contactColumnName));
						result = false;
					}
					return result;
				}
			},
			diff: [{
				"operation": "insert",
				"name": "DataGrid",
				"values": {
					"generator": "ConfigurationVerticalGridGenerator.generatePartial",
					"itemType": Terrasoft.ViewItemType.GRID,
					"listedZebra": true,
					"collection": {
						"bindTo": "Collection"
					},
					"activeRow": {
						"bindTo": "ActiveRow"
					},
					"primaryColumnName": "Id",
					"isEmpty": {
						"bindTo": "IsGridEmpty"
					},
					"isLoading": {
						"bindTo": "IsGridLoading"
					},
					"activeRowAction": {
						"bindTo": "onActiveRowAction"
					},
					"linkClick": {
						"bindTo": "onLinkClicked"
					},
					"activeRowActions": [],
					"type": "tiled",
					"isEmptyRowVisible": false,
					"isVertical": true,
					"listedConfig": {
						"name": "DataGridListedConfig",
						"items": [{
							"name": "ContactListedGridColumn",
							"bindTo": "Contact",
							"type": Terrasoft.GridCellType.TITLE,
							"position": {
								"column": 1,
								"colSpan": 24
							}
						}]
					},
					"tiledConfig": {
						"name": "DataGridTiledConfig",
						"grid": {
							"columns": 24,
							"rows": 2
						},
						"items": [{
							"name": "ContactTiledGridColumn",
							"bindTo": "Contact",
							"type": Terrasoft.GridCellType.TITLE,
							"captionConfig": {
								"visible": false
							},
							"position": {
								"row": 1,
								"column": 1,
								"colSpan": 24
							}
						}, {
							"name": "PostponedOnTiledGridColumn",
							"bindTo": "PostponedOn",
							"type": Terrasoft.GridCellType.Text,
							"position": {
								"row": 2,
								"column": 1,
								"colSpan": 24
							}
						}]
					}
				}
			}, {
				"operation": "insert",
				"name": "LoadMoreButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.LoadMoreButtonCaption"
					},
					"click": {
						"bindTo": "onLoadMoreClick"
					},
					"controlConfig": {
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"imageConfig": resources.localizableImages.LoadMoreIcon
					},
					"classes": {
						"wrapperClass": ["load-more-button-class"]
					},
					"visible": {
						"bindTo": "CanLoadMoreData"
					}
				}
			}, {
				"operation": "insert",
				"name": "DataGridActiveRowContinueConsultationAction",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": resources.localizableStrings.ContinueConsultationGridRowButtonCaption,
					"tag": "continue"
				}
			}]
		};
	});
