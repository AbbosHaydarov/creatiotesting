define("BaseAddressFieldsDetail", ["BaseAddressFieldRowViewModel", "DetailEntityMappingMixin", "css!FinAppLendingCSS"],
	function() {
		return {
			entitySchemaName: "BaseAddress",
			attributes: {
				"IsCollapseLock": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": false
				}
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"name": "AddRecordButton",
				"propertyName": "tools",
				"values": {
					"visible": false
				}
			}],
			/**SCHEMA_DIFF*/
			messages: {

				/**
				 * @message SetCollapseLock
				 */
				"SetCollapseLock": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message SetDetailCollapsed
				 */
				"SetDetailCollapsed": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message GetFieldsDetailItems
				 */
				"GetAddressRecordInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message UpdateFieldsDetailItems
				 */
				"SetAddressRecordInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message DetailLoaded
				 * Tells about loading detail.
				 */
				"DetailLoaded": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			mixins: {
				DetailEntityMappingMixin: "Terrasoft.DetailEntityMappingMixin"
			},
			methods: {

				//region Properties: Protected

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.Ext.callback(callback, scope);
						this.sandbox.publish("DetailLoaded", null, [this.sandbox.id]);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetail#onDetailCollapsedChanged
				 * @overridden
				 */
				onDetailCollapsedChanged: function(isCollapsed) {
					var isDetailCollapsedOld = this.get("IsDetailCollapsed");
					this.set("IsDetailCollapsed", isCollapsed);
					var isCollapseLock = this.get("IsCollapseLock");
					if (isCollapseLock && isCollapsed !== isDetailCollapsedOld) {
						this.set("IsDetailCollapsed", isDetailCollapsedOld);
					}
				},

				/**
				 * Returns first record in detail collection.
				 * @protected
				 * @return {Terrasoft.BaseViewModel} View model or first record.
				 */
				getFirstRecordItem: function() {
					var collection = this.get("Collection");
					return collection.isEmpty() ? null : collection.getByIndex(0);
				},

				/**
				 * Returns first record address info.
				 * @protected
				 * @return {Object} First record address info.
				 */
				getAddressRecordInfo: function() {
					var item = this.getFirstRecordItem();
					var recordInfo = {};
					this.Terrasoft.each(this.getDisplayColumns(), function(columnName) {
						recordInfo[columnName] = item.get(columnName);
					}, this);
					return recordInfo;
				},

				/**
				 * Sets first record address info.
				 * @protected
				 * @param {Object} recordInfo First record address info.
				 */
				setAddressRecordInfo: function(recordInfo) {
					var item = this.getFirstRecordItem();
					this.Terrasoft.each(this.getDisplayColumns(), function(columnName) {
						item.set(columnName, recordInfo[columnName]);
					}, this);
				},

				/**
				 * Sets IsCollapseLock property.
				 * @protected
				 * @param {Object} isCollapseLock Value of IsCollapseLock property.
				 */
				setCollapseLock: function(isCollapseLock) {
					this.set("IsCollapseLock", isCollapseLock);
				},

				/**
				 * Sets IsDetailCollapsed property.
				 * @protected
				 * @param {Object} isDetailCollapsed Value of IsDetailCollapsed property.
				 */
				setDetailCollapsed: function(isDetailCollapsed) {
					this.set("IsDetailCollapsed", isDetailCollapsed);
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					var sandbox = this.sandbox;
					sandbox.subscribe("GetAddressRecordInfo", this.getAddressRecordInfo, this, [sandbox.id]);
					sandbox.subscribe("SetAddressRecordInfo", this.setAddressRecordInfo, this, [sandbox.id]);
					sandbox.subscribe("SetCollapseLock", this.setCollapseLock, this, [sandbox.id]);
					sandbox.subscribe("SetDetailCollapsed", this.setDetailCollapsed, this, [sandbox.id]);
					this.initStateMixinMessages();
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
				 * @overridden
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.BaseAddressFieldRowViewModel";
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDeleteButtonConfig
				 * @overridden
				 */
				getDeleteButtonConfig: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#useVirtualRecord
				 * @overridden
				 */
				useVirtualRecord: function() {
					return true;
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDisplayColumns
				 * @overridden
				 */
				getDisplayColumns: function() {
					return ["Address", "Zip", "Country", "Region", "City"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowContainerWrapClass
				 * @overridden
				 */
				getRowContainerWrapClass: function() {
					return ["address-field-detail-row"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getLeftRowContainerWrapClass
				 * @overridden
				 */
				getLeftRowContainerWrapClass: function() {
					return ["address-field-detail-row-left"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDisplayColumns
				 * @overridden
				 */
				getDetailRowItemsViewConfig: function() {
					return [{
						"id": "AddressDetailItemsContainer" + this.entitySchemaName,
						"name": "AddressDetailItemsContainer",
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [{
							"name": "Zip",
							"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 6
							}
						}, {
							"name": "Country",
							"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
							"layout": {
								"column": 6,
								"row": 0,
								"colSpan": 6
							}
						}, {
							"name": "Region",
							"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
							"layout": {
								"column": 12,
								"row": 0,
								"colSpan": 6
							}
						}, {
							"name": "City",
							"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
							"layout": {
								"column": 18,
								"row": 0,
								"colSpan": 6
							}
						}, {
							"name": "Address",
							"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 24
							}
						}]
					}];
				},

				/**
				 * @inheritdoc Terrasoft.DetailEntityMappingMixin#onSetDetailMappingDataComplete
				 * @overridden
				 */
				onSetDetailMappingDataComplete: function() {
					var collection = this.getCollection();
					var newItemsCollection = collection.filter(function(item) {
						return !item.isDeleted;
					});
					if (newItemsCollection && newItemsCollection.isEmpty() && this.useVirtualRecord()) {
						this.addVirtualRecord();
					}
				}

				//endregion
			}
		};
	});
