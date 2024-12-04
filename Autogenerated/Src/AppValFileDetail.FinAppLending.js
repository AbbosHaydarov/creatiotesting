define("AppValFileDetail", ["AppValImageListViewModel", "FileDetailV2"], function() {
	return {
		methods: {

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#getAddLinkMenuItem
			 * @overridden
			 */
			getAddLinkMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#addLinkRecord
			 * @overridden
			 */
			addLinkRecord: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#addEntityLinkRecord
			 * @overridden
			 */
			addEntityLinkRecord: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#upload
			 * @overridden
			 */
			upload: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#onUpload
			 * @overridden
			 */
			onUpload: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#initDropzoneEvents
			 * @overridden
			 */
			initDropzoneEvents: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#getUploadConfig
			 * @overridden
			 */
			getUploadConfig: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#addRecordOperationsMenuItems
			 * @overridden
			 */
			addRecordOperationsMenuItems: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#addEntityOperationsMenuItems
			 * @overridden
			 */
			addEntityOperationsMenuItems: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#initToolsButtonMenu
			 * @overridden
			 */
			initToolsButtonMenu: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#linkClicked
			 * @overridden
			 */
			linkClicked: function(rowId, functionName, url) {
				var result = this.callParent(arguments);
				if (result !== false) {
					var collection = this.getGridData();
					var record = collection.get(rowId);
					this.linkClickHandler(record.get("Name"), url);
					result = false;
				}
				return result;
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#createViewModel
			 * @overridden
			 */
			createViewModel: function(config) {
				this.callParent(arguments);
				config.viewModel.linkClickHandler = this.linkClickHandler.bind(this);
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#getGridRowViewModelClassName
			 * @overridden
			 */
			getGridRowViewModelClassName: function() {
				return "Terrasoft.AppValImageListViewModel";
			},

			/**
			 * Link click handler.
			 * @protected
			 * @param {String} name Display name.
			 * @param {String} url Url.
			 */
			linkClickHandler: function(name, url) {
				var link = document.createElement("a");
				link.target = "_blank";
				document.body.appendChild(link);
				link.download = name;
				link.href = url;
				link.click();
				document.body.removeChild(link);
				link = null;
			},

			/**
			 * @inheritdoc Terrasoft.BaseDetailV2#initDetailOptions
			 * @overridden
			 */
			initDetailOptions: function() {
				this.set("IsDetailCollapsed", false);
			}

			//endregion

		},
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "remove",
			"name": "DragAndDrop Container"
		}, {
			"operation": "remove",
			"name": "AddRecordButton"
		}, {
			"operation": "remove",
			"name": "ToolsButton"
		}] /**SCHEMA_DIFF*/
	};
});
