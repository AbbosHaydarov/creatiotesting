define("DetailEntityMappingMixin", [],
	function() {
		/**
		 * @class Terrasoft.configuration.mixins.DetailEntityMappingMixin
		 * Update Detail State Mixin.
		 */
		Ext.define("Terrasoft.configuration.mixins.DetailEntityMappingMixin", {
			alternateClassName: "Terrasoft.DetailEntityMappingMixin",

			//region Properties: Private

			/**
			 * Detail messages.
			 * @private
			 * @property {Object} detailEntityMappingMixinMessages
			 */
			detailEntityMappingMixinMessages: {
				/**
				 * @message SetDetailMappingData
				 * Gets new detail fields data.
				 */
				"SetDetailMappingData": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},

			//endregion

			//region Methods: Protected

			/**
			 * Deletes all detail items.
			 * @protected
			 * @virtual
			 */
			clearCollection: this.Terrasoft.emptyFn,

			/**
			 * Updates detail item fields with new values.
			 * @param {Terrasoft.BaseViewModel} rowItem Item.
			 * @param {Array} columns Key-value pairs array.
			 * @protected
			 */
			setRowData: function(rowItem, columns) {
				this.Terrasoft.each(columns, function(column) {
					var columnConfig = this.columns[column.Key] || {};
					column.Value = column.Value || undefined;
					var isDateTime = columnConfig.dataValueType === Terrasoft.DataValueType.DATE ||
						columnConfig.dataValueType === Terrasoft.DataValueType.TIME ||
						columnConfig.dataValueType === Terrasoft.DataValueType.DATE_TIME;
					if (!Ext.isEmpty(column.Value) && isDateTime) {
						column.Value = Terrasoft.parseDate(column.Value);
					}
					rowItem.set(column.Key, column.Value);
				}, rowItem);
			},

			/**
			 * Updates detail with new detail items.
			 * @param {Array} items Detail row items data array.
			 * @protected
			 */
			onSetDetailMappingData: function(items) {
				this.clearCollection();
				this.Terrasoft.each(items, function(columns) {
					var newItem = this.addDetailItem(columns);
					this.setRowData(newItem, columns);
				}, this);
				this.onSetDetailMappingDataComplete();
			},

			/**
			 * Necessary actions on detail data filled.
			 * @protected
			 */
			onSetDetailMappingDataComplete: this.Terrasoft.emptyFn,

			/**
			 * Add new detail item wrapper.
			 * @param {Array} columnValues Detail row item column values array.
			 * @protected
			 * @virtual
			 * @return {Terrasoft.BaseViewModel} Detail new item viewModel.
			 */
			addDetailItem: function(columnValues) {
				return this.addRow(columnValues);
			},

			/**
			 * Subscribe mixin events
			 * @protected
			 */
			initStateMixinMessages: function() {
				var sandbox = this.sandbox;
				sandbox.registerMessages(this.detailEntityMappingMixinMessages);
				sandbox.subscribe("SetDetailMappingData", this.onSetDetailMappingData, this, [sandbox.id]);
			}

			//endregion

		});
		return Terrasoft.DetailEntityMappingMixin;
	});
