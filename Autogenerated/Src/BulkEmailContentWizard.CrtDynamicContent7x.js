﻿define("BulkEmailContentWizard", ["BulkEmailContentWizardResources", "RightUtilities", "ContentBlockDesigner",
	"BulkEmailContentBuilder", "PreviewDefaultReplicaViewModel", "css!BulkEmailContentBuilderCSS",
	"css!ContentBlockCSS", "IssueViewer", "ImageView", "css!BulkEmailContentWizardCSS", "SendTestEmailContentSchema",
	"css!SendTestEmailContentSchemaCSS"],
	function(resources, RightUtilities) {
	/** @enum
	 * Wizard actions */
	Terrasoft.BulkEmailContentWizardActions = {
		GetReplicaHeadersFromPreview: 1,
		GetReplicaHeaders: 2,
		GetDefaultHeadersFromBulkEmail: 3,
		GetDefaultHeadersFromPreview: 4,
		ShowTestEmailDialog: 5
	};
	/** @enum
	 * Viewer tabs */
	var wizardTabs = {
		Design: "Design",
		Headers: "Headers",
		Preview: "Preview"
	};
	return {
		modules: {
			ContentBuilderModule: {
				moduleId: "BulkEmailContentBuilderModule",
				moduleName: "ConfigurationModuleV2",
				reload: false,
				config: {
					schemaName: "BulkEmailContentBuilder",
					isSchemaConfigInitialized: true,
					useHistoryState: false,
					showMask: true,
					autoGeneratedContainerSuffix: "-content-block-designer",
					parameters: {
						viewModelConfig: {
							IsWizardMode: true
						}
					}
				}
			},
			DynamicHeadersModule: {
				moduleId: "BulkEmailContentWizardHeadersModule",
				moduleName: "ConfigurationModuleV2",
				reload: false,
				config: {
					schemaName: "BulkEmailContentWizardHeaders",
					isSchemaConfigInitialized: true,
					useHistoryState: false,
					showMask: true,
					autoGeneratedContainerSuffix: "-dynamic-headers"
				}
			},
			InboxPreviewModule: {
				moduleId: "BulkEmailContentWizardPreviewModule",
				moduleName: "ConfigurationModuleV2",
				reload: false,
				config: {
					schemaName: "BulkEmailContentWizardPreview",
					isSchemaConfigInitialized: true,
					useHistoryState: false,
					showMask: true,
					autoGeneratedContainerSuffix: "-content-preview"
				}
			},
			IssueViewerModule: {
				moduleId: "IssueViewerModule",
				moduleName: "ConfigurationModuleV2",
				reload: false,
				config: {
					schemaName: "IssueViewer",
					isSchemaConfigInitialized: true,
					useHistoryState: false,
					showMask: true,
					autoGeneratedContainerSuffix: "-issue-viewer"
				}
			},
			TestEmail: {
				config: {
					schemaName: "SendTestEmailContentSchema",
					isSchemaConfigInitialized: true,
					useHistoryState: false,
					parameters: {
						viewModelConfig: {
							BulkEmail: {
								"attributeValue": "BulkEmailId"
							},
							ReplicaMask: {
								"attributeValue": "ActiveReplicaMask"
							},
							ReplicaCount: {
								"attributeValue": "ReplicaCount"
							},
							LimitedView: true
						}
					}
				}
			}
		},
		attributes: {

			/**
			 * Indicates weather notification panes is visible after saving.
			 */
			"IsNotificationPanelVisible": {
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value:false
			},

			/**
			 * Indicates weather template has validation errors.
			 */
			"HasValidationErrors": {
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value: false
			},

			/**
			 * Collection of tabs.
			 */
			"TabsCollection": {
				"dataValueType": Terrasoft.DataValueType.COLLECTION,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Name of the active tab.
			 */
			"ActiveTabName": {
				"dataValueType": this.Terrasoft.DataValueType.TEXT,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Visibility of test email module.
			 */
			"IsTestEmailVisible": {
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value: false
			},

			/**
			 * Email identifier.
			 */
			"BulkEmailId": {
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				dataValueType: Terrasoft.DataValueType.GUID,
			},

			/**
			 * Number of dynamic content replicas.
			 */
			"ReplicaCount": {
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				dataValueType: Terrasoft.DataValueType.INTEGER,
			},

			/**
			 * Mask of replica that is visible or activated at content builder.
			 */
			"ActiveReplicaMask": {
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				dataValueType: Terrasoft.DataValueType.INTEGER,
			}
		},
		messages: {

			/**
			 * @message BulkEmailContentBuilderAction
			 * Sends specific action to content builder.
			 */
			"BulkEmailContentBuilderAction": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message UpdatePreview
			 * Sets template config to the preview/headers modules.
			 */
			"UpdatePreview": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message UpdatePreview
			 * Sets template config to the preview/headers modules.
			 */
			"UpdatePreviewWithRender": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message UpdatePreview
			 * Sets headers to the preview module.
			 */
			"UpdateHeaders": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message UpdateTemplateSubject
			 * Sets new default template subject.
			 */
			"UpdateTemplateSubject": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message BulkEmailSubjectUpdated
			 * Sets new default template subject.
			 */
			"BulkEmailSubjectUpdated": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message GetContentBuilderConfig
			 * Gets content builder config.
			 */
			"GetContentBuilderConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message SetBulkEmailTitle
			 * Sets bulk email title.
			 */
			"BulkEmailContentBuilderLoaded": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message GetReplicaHeaders
			 * Gets updated replica headers collection from preview module.
			 */
			"GetReplicaHeaders": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message GetBulkEmailDefaultHeaders
			 * Gets updated default headers collection from preview module.
			 */
			"GetBulkEmailDefaultHeaders": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message BulkEmailContentWizardAction
			 * Handles bulk email content wizard actions.
			 */
			"BulkEmailContentWizardAction": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message ValidationStateChanged
			 * Publish validation massages.
			 */
			"SetIssuesDataCollection": {
				direction: Terrasoft.MessageDirectionType.PUBLISH,
				mode: Terrasoft.MessageMode.PTP
			},

			/**
			 * @message UpdateContentBuilderConfig
			 * Updates content config after adding unsubscribe block.
			 */
			"UpdateContentBuilderConfig": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message BulkEmailContentBuilderSaved
			 * Sends event on content saved.
			 */
			"BulkEmailContentBuilderSaved": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message CloseTestEmail
			 * Message will be fired when test email container is closing.
			 */
			"CloseTestEmail": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message SendTestEmail
			 * Opens modal view for sending test message.
			 */
			"SendTestEmail": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},
		},
		methods: {

			// region Methods: Private

			_checkRightsForBulkEmail: function(callback) {
				var bulkEmailId = this.sandbox.publish("BulkEmailContentBuilderAction",
					Terrasoft.BulkEmailContentBuilderActions.GetBulkEmailId);
				var rightReqConfig = {
					schemaName: "BulkEmail",
					primaryColumnValue: bulkEmailId,
					isNew: false
				};
				RightUtilities.checkCanEdit(rightReqConfig, function(result) {
					if (result) {
						Terrasoft.utils.showInformation(result);
					} else {
						callback.call(this);
					}
				}, this);
			},

			_openTestEmailContainer: function(config) {
				this.set("BulkEmailId", config.bulkEmailId);
				this.set("ReplicaCount", config.replicaCount);
				this.set("ActiveReplicaMask", config.activeReplicaMask);
				this.set("IsTestEmailVisible", true);
				this.sandbox.subscribe("CloseTestEmail", this._closeTestEmailContainer, this,
					[this.getSendTestEmailContentSchemaId()]);
			},

			_closeTestEmailContainer: function() {
				this.sandbox.unsubscribePtp("CloseTestEmail", [this.getSendTestEmailContentSchemaId()]);
				this.set("IsTestEmailVisible", false);
			},

			_getContentBuilderConfig: function() {
				return this.sandbox.publish("BulkEmailContentBuilderAction",
					Terrasoft.BulkEmailContentBuilderActions.GetContentBuilderConfig);
			},

			_isTabVisible: function(tag) {
				return this.$ActiveTabName === tag;
			},

			_updateDefaultTemplateSubject: function(templateSubject) {
				this.sandbox.publish("UpdateTemplateSubject", templateSubject);
			},

			_getEmailHeaders: function() {
				var emailHeaders = [];
				var headers = this.getReplicaHeadersFromPreview() || this.getReplicaHeadersFromContentBuilder();
				var defaultHeaders = this.getDefaultHeadersFromPreview() || this.getDefaultHeadersFromBulkEmail();
				Terrasoft.each(headers, function(item) {
					emailHeaders.push(item);
				}, this);
				if (defaultHeaders) {
					emailHeaders.push(defaultHeaders);
				}
				return emailHeaders;
			},

			_getValidationConfig: function() {
				var templateConfig = this._getContentBuilderConfig();
				var bulkEmailId = this.sandbox.publish("BulkEmailContentBuilderAction",
					Terrasoft.BulkEmailContentBuilderActions.GetBulkEmailId);
				var emailHeaders = this._getEmailHeaders();
				return {
					templateConfig: templateConfig,
					bulkEmailId: bulkEmailId,
					emailHeaders: emailHeaders,
					applyUnsubscribeAction: function(config, html, applied, flags) {
						this.sandbox.publish("UpdateContentBuilderConfig", {
							config: config,
							html: html,
							flags: flags || {}
						});
					}
				};
			},

			_isSuccessValidation: function(validationResult) {
				var errors = validationResult.filter(function(message) {
					return message.Level === Terrasoft.BulkEmailValidationLevel.ERROR;
				});
				return Ext.isEmpty(errors);
			},

			_onNotificationCloseButtonClick: function() {
				this.$IsNotificationPanelVisible = false;
			},

			_getNotificationPanelCaption: function() {
				return this.$HasValidationErrors ?
					resources.localizableStrings.SavedWithErrorsMessage :
					resources.localizableStrings.SavedSuccessFullyMessage;
			},

			_getNotificationPanelDomAttributes: function() {
				var panelType = this.$HasValidationErrors ? "error" : "info";
				return {
					"data-notification-type": panelType
				};
			},

			_getNotificationErrorImageSrc: function() {
				return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.NotificationError"));
			},

			_getLogoImageConfig: function(logoName) {
				var config = {
					params: {
						r: logoName
					},
					source: this.Terrasoft.ImageSources.SYS_SETTING
				};
				return this.Terrasoft.ImageUrlBuilder.getUrl(config);
			},

			_getMenuItem: function(tag, clickHandler, caption) {
				return this.getButtonMenuItem({
					"Tag": tag,
					"Click": {"bindTo": clickHandler},
					"Caption": {"bindTo": caption}
				});
			},

			// endregion

			// region Methods: Protected

			/**
			 * Returns SendTestEmailContentSchema identifier for ModalBoxSchemaModule.
			 * @protected
			 */
			getSendTestEmailContentSchemaId: function() {
				return this.sandbox.id + "_module_TestEmail";
			},

			/**
			 * Subscribes to events.
			 * @protected
			 */
			subscribeMessages: function() {
				this.sandbox.subscribe("GetContentBuilderConfig", this.onGetContentBuilderConfig, this);
				this.sandbox.subscribe("BulkEmailContentBuilderLoaded", this.onBulkEmailContentBuilderLoaded, this);
				this.sandbox.subscribe("BulkEmailContentWizardAction", this.onBulkEmailContentWizardAction, this);
				this.sandbox.subscribe("BulkEmailSubjectUpdated", this._updateDefaultTemplateSubject, this);
				this.sandbox.subscribe("BulkEmailContentBuilderSaved", this.onBulkEmailContentBuilderSaved, this);
				this.sandbox.subscribe("BulkEmailContentBuilderSaved", this.onBulkEmailContentBuilderSaved, this);
				this.sandbox.subscribe("SendTestEmail", this._openTestEmailContainer, this);
			},

			/**
			 * Handles content builder saved message.
			 * @protected
			 */
			onBulkEmailContentBuilderSaved: function() {
				this.$IsNotificationPanelVisible = true;
			},

			/**
			 * Handles wizard actions.
			 * @protected
			 * @param action Represents wizard action type.
			 */
			onBulkEmailContentWizardAction: function(action) {
				switch(action) {
					case Terrasoft.BulkEmailContentWizardActions.GetReplicaHeaders:
						return this.getReplicaHeadersFromContentBuilder();
						break;
					case Terrasoft.BulkEmailContentWizardActions.GetReplicaHeadersFromPreview:
						return this.getReplicaHeadersFromPreview();
						break;
					case Terrasoft.BulkEmailContentWizardActions.GetDefaultHeadersFromBulkEmail:
						return this.getDefaultHeadersFromBulkEmail();
						break;
					case Terrasoft.BulkEmailContentWizardActions.GetDefaultHeadersFromPreview:
						return this.getDefaultHeadersFromPreview();
						break;
					case Terrasoft.BulkEmailContentWizardActions.ShowTestEmailDialog:
						this.openSendTestEmailContentModalBox();
						break;
					default:
						break;
				}
			},

			/**
			 * Returns default headers from Preview module.
			 * @protected
			 */
			getDefaultHeadersFromPreview: function() {
				return this.sandbox.publish("GetBulkEmailDefaultHeaders");
			},

			/**
			 * Returns default headers from BulkEmailContentBuilder module.
			 * @protected
			 */
			getDefaultHeadersFromBulkEmail: function() {
				var headersValuesConfig = this.sandbox.publish("BulkEmailContentBuilderAction",
					Terrasoft.BulkEmailContentBuilderActions.GetBulkEmailDefaultHeaders);
				var headersViewModel = Ext.create("Terrasoft.PreviewDefaultReplicaViewModel");
				headersViewModel.$Subject = headersValuesConfig.Subject;
				headersViewModel.$SenderEmail = headersValuesConfig.SenderEmail;
				headersViewModel.$SenderName = headersValuesConfig.SenderName;
				headersViewModel.$PreHeader = headersValuesConfig.Preheader;
				return headersViewModel;
			},

			/**
			 * Returns replica headers collection from BulkEmailContentBuilder module.
			 * @protected
			 */
			getReplicaHeadersFromContentBuilder: function() {
				return this.sandbox.publish("BulkEmailContentBuilderAction",
					Terrasoft.BulkEmailContentBuilderActions.GetReplicaHeaders);
			},

			/**
			 * Returns actual replica headers collection from BulkEmailContentWizardHeaders module.
			 * @protected
			 */
			getReplicaHeadersFromPreview: function() {
				return this.sandbox.publish("GetReplicaHeaders");
			},

			/**
			 * Event handler to get content builder config.
			 * @protected
			 */
			onGetContentBuilderConfig: function() {
				return this._getContentBuilderConfig();
			},

			/**
			 * Event handler to set wizard caption.
			 * @protected
			 */
			onBulkEmailContentBuilderLoaded: function() {
				if (this.$ActiveTabName != wizardTabs.Design) {
					this.updatePreview(this.$ActiveTabName, this.$ActiveTabName === wizardTabs.Preview);
				}
			},

			/**
			 * Saves content builder config.
			 * @protected
			 */
			onSaveButtonClick: function() {
				Terrasoft.chain(
					function(next) {
						this._checkRightsForBulkEmail(next);
					},
					function () {
						this.$IsNotificationPanelVisible = false;
						this.validateTemplate(function(isTemplateValid) {
							this.$HasValidationErrors = !isTemplateValid;
							this.sandbox.publish("BulkEmailContentBuilderAction", {
								actionType : Terrasoft.BulkEmailContentBuilderActions.Save,
								config: {
									isTemplateValid: isTemplateValid
								}
							});
						}, this);
					}
				,this);
			},

			/**
			 * Closes window with confirmation.
			 * @protected
			 */
			onCloseButtonClick: function() {
				this.sandbox.publish("BulkEmailContentBuilderAction", Terrasoft.BulkEmailContentBuilderActions.Close);
			},

			/**
			 * Event handler for select from lookup button.
			 * @protected
			 */
			onSelectTemplateFromLookupButtonClick: function() {
				this.sandbox.publish("BulkEmailContentBuilderAction",
					Terrasoft.BulkEmailContentBuilderActions.SelectTemplateFromLookup);
			},

			/**
			 * Initializes preview module.
			 * @protected
			 */
			updatePreview: function(tabName, renderPreview) {
				var contentConfig = this._getContentBuilderConfig();
				if (renderPreview) {
					this.sandbox.publish("UpdatePreviewWithRender", contentConfig, [tabName]);
				} else {
					this.sandbox.publish("UpdatePreview", contentConfig, [tabName]);
				}
			},

			/**
			 * Initializes preview module.
			 * @protected
			 */
			updateHeaders: function() {
				this.sandbox.publish("UpdateHeaders");
			},

			/**
			 * Opens test email modal dialog box.
			 * @protected
			 */
			openSendTestEmailContentModalBox: function(){
				this.validateTemplate(function(isTemplateValid) {
					if (isTemplateValid) {
						this.sandbox.publish("BulkEmailContentBuilderAction",
							Terrasoft.BulkEmailContentBuilderActions.OpenTestEmailDialog);
					}
				}, this);
			},

			/**
			 * Creates instance of validator.
			 * @protected
			 * @returns {Terrasoft.configuration.BulkEmailTemplateValidator}
			 */
			createValidator: function() {
				return new Terrasoft.BulkEmailTemplateValidator();
			},

			/**
			 * Calls validations on template and dynamic headers. Publishes result with ValidationStateChanged message.
			 * @protected
			 * @param {Function} successCallback Callback function to call if validation result does not have errors.
			 * @param {Object} scope Callback scope.
			 */
			validateTemplate: function(successCallback, scope) {
				this.showBodyMask();
				var validationConfig = this._getValidationConfig();
				var validator = this.createValidator();
				validator.validateInCollectMode(validationConfig, function(validationResult) {
					this.sandbox.publish("SetIssuesDataCollection", validationResult);
					var isTemplateValid = this._isSuccessValidation(validationResult);
					successCallback.call(scope, isTemplateValid);
					this.hideBodyMask();
				}, scope);
			},

			/**
			 * Handles event of changing the active tab.
			 * @protected
			 * @param {Terrasoft.BaseViewModel} activeTab ViewModel of the active tab.
			 */
			onActiveTabChange: function(activeTab) {
				var activeTabName = activeTab.get("Name");
				this.set("ActiveTabName", activeTabName);
				switch (activeTabName) {
					case wizardTabs.Headers:
						this.updatePreview(wizardTabs.Headers);
						break;
					case wizardTabs.Preview:
						this.updatePreview(wizardTabs.Headers);
						this.updatePreview(wizardTabs.Preview);
						this.updateHeaders();
						break;
					default:
				}
			},

			/**
			 * Return wizard actions collection.
			 * @protected
			 * @virtual
			 * @return {Terrasoft.BaseViewModelCollection} Returns actions collection.
			 */
			getActions: function() {
				var actionMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
				actionMenuItems.addItem(this._getMenuItem("sendTestEmail", "openSendTestEmailContentModalBox",
					"Resources.Strings.SendTestEmailButtonCaption"));
				actionMenuItems.addItem(this._getMenuItem("selectFromLookup", "onSelectTemplateFromLookupButtonClick",
					"Resources.Strings.SelectTemplateFromLookupButtonCaption"));
				return actionMenuItems;
			},

			/**
			 * Initializes wizard actions.
			 * @protected
			 */
			initActionButtonMenu: function() {
				var actionMenuItems = this.getActions();
				var actionsButtonVisible = !actionMenuItems.isEmpty();
				this.set("ActionsButtonVisible", actionsButtonVisible);
				this.set("ActionsButtonMenuItems", actionMenuItems);
			},

			// endregion

			// region Methods: Public

			/**
			 * @inheritdoc Terrasoft.core.BaseSchemaViewModel#init
			 * @override
			 * @param {function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 */
			init: function(callback, scope) {
				this.callParent([
					function() {
						this.subscribeMessages();
						this.$ActiveTabName = wizardTabs.Design;
						this.initActionButtonMenu();
						callback.call(this, scope);
					}, this
				]);
			}

			// endregion

		},
		diff: [
			{
				"operation": "insert",
				"name": "MainContainer",
				"values": {
					"classes": {
						"textClass": "center-panel",
						"wrapClassName": ["wizard-wrap"]
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "NotificationPanelContainer",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"classes": {
						"wrapClassName": ["notification-message-panel"]
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"visible":"$IsNotificationPanelVisible",
					"items": [],
					"domAttributes":"$_getNotificationPanelDomAttributes"
				}
			},
			{
				"operation": "insert",
				"name": "NotificationErrorImageContainer",
				"parentName": "NotificationPanelContainer",
				"propertyName": "items",
				"values": {
					"className": "Terrasoft.Container",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {
						"wrapClassName": ["error-static-image"]
					},
					"visible":"$HasValidationErrors",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "NotificationErrorImage",
				"parentName": "NotificationErrorImageContainer",
				"propertyName": "items",
				"values": {
					"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
					"onPhotoChange": this.Terrasoft.emptyFn,
					"getSrcMethod": "_getNotificationErrorImageSrc",
					"classes": {
						"wrapClass": ["not-selected-image"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "NotificationMessageLabel",
				"parentName": "NotificationPanelContainer",
				"propertyName": "items",
				"values": {
					"className": "Terrasoft.Label",
					"caption": "$_getNotificationPanelCaption",
					"itemType": Terrasoft.ViewItemType.LABEL,
					"classes": {
						"labelClass": ["t-label"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "NotificationCloseButtonContainer",
				"parentName": "NotificationPanelContainer",
				"propertyName": "items",
				"values": {
					"className": "Terrasoft.Container",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {
						"wrapClassName": ["message-panel-buttons"]
					},
					"items": [
						{
							"className": "Terrasoft.Button",
							"itemType": this.Terrasoft.ViewItemType.BUTTON,
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"markerValue": "CloseMessagePanel",
							"imageConfig": "$Resources.Images.CloseButton",
							"click": "$_onNotificationCloseButtonClick"
						}
					]
				}
			},
			{
				"operation": "insert",
				"name": "HeaderContainer",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {"wrapClassName": ["wizard-header-container"]},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "HeaderGridLayout",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				},
				"parentName": "HeaderContainer",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "LeftHeadPanelContainer",
				"parentName": "HeaderGridLayout",
				"propertyName": "items",
				"values": {
					"classes": {"wrapClassName": ["button-group-container"]},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 8,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "CenterHeadPanelContainer",
				"parentName": "HeaderGridLayout",
				"propertyName": "items",
				"values": {
					"classes": {"wrapClassName": ["wizard-buttons-container"]},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 8,
						"row": 0,
						"colSpan": 8,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "RightHeadPanelContainer",
				"parentName": "HeaderGridLayout",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {"wrapClassName": ["main-header-logo-container"]},
					"items": [],
					"layout": {
						"column": 22,
						"row": 0,
						"colSpan": 2,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "SaveButton",
				"parentName": "LeftHeadPanelContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.SaveButtonCaption"
					},
					"classes": {
						"textClass": "actions-button-margin-right"
					},
					"click": {"bindTo": "onSaveButtonClick"},
					"style": Terrasoft.controls.ButtonEnums.style.GREEN,
					"tips": []
				}
			},
			{
				"operation": "insert",
				"name": "CloseButton",
				"parentName": "LeftHeadPanelContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.CloseButtonCaption"
					},
					"classes": {
						"textClass": "actions-button-margin-right"
					},
					"click": {"bindTo": "onCloseButtonClick"}
				}
			},
			{
				"operation": "insert",
				"name": "ActionsButton",
				"parentName": "LeftHeadPanelContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.ActionsButtonCaption"
					},
					"classes": {
						"textClass": ["actions-button-margin-right"],
						"wrapperClass": ["actions-button-margin-right"]
					},
					"menu": {
						"items": {"bindTo": "ActionsButtonMenuItems"}
					},
					"visible": {"bindTo": "ActionsButtonVisible"}
				}
			},
			{
				"operation": "insert",
				"name": "LogoImage",
				"parentName": "RightHeadPanelContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.COMPONENT,
					"className": "Terrasoft.ImageView",
					"imageSrc": {"bindTo": "_getLogoImageConfig"},
					"tag": "HeaderLogoImage",
					"classes": {
						"wrapClass": ["main-header-logo-image", "cursor-pointer"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "TabsContainer",
				"parentName": "CenterHeadPanelContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "Tabs",
				"parentName": "TabsContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.TAB_PANEL,
					"activeTabChange": "$onActiveTabChange",
					"activeTabName": "$ActiveTabName",
					"collection": {"bindTo": "TabsCollection"},
					"isScrollVisible": false,
					"tabs": []
				}
			},
			{
				"operation": "insert",
				"name": wizardTabs.Design,
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"generateId": false,
					"caption": {
						"bindTo": "Resources.Strings.DesignTabCaption"
					},
					"wrapClass": ["tab-container"],
					"items": []
				}
			},

			{
				"operation": "insert",
				"name": wizardTabs.Headers,
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"generateId": false,
					"caption": {
						"bindTo": "Resources.Strings.HeadersTabCaption"
					},
					"wrapClass": ["tab-container"],
					"items": []
				}
			},

			{
				"operation": "insert",
				"name": wizardTabs.Preview,
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"generateId": false,
					"caption": {
						"bindTo": "Resources.Strings.PreviewTabCaption"
					},
					"wrapClass": ["tab-container"],
					"items": []
				}
			},

			{
				"operation": "insert",
				"name": "CenterContainer",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {"wrapClassName": ["wizard-container"]},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "DesignContainer",
				"parentName": "CenterContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {"wrapClassName": ["wizard-design-container"]},
					"items": [],
					"tag": wizardTabs.Design,
					"visible":"$_isTabVisible"
				}
			},
			{
				"operation": "insert",
				"name": "HeadersContainer",
				"parentName": "CenterContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {"wrapClassName": ["headers-container"]},
					"items": [],
					"tag": wizardTabs.Headers,
					"visible":  "$_isTabVisible"
				}
			},
			{
				"operation": "insert",
				"name": "InboxPreviewContainer",
				"parentName": "CenterContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {"wrapClassName": ["preview-builder-container"]},
					"items": [],
					"tag": wizardTabs.Preview,
					"visible":  "$_isTabVisible"
				}
			},
			{
				"operation": "insert",
				"name": "ContentBuilderModule",
				"parentName": "DesignContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE,
					"classes": {
						"wrapClassName": "content-item-panel-wrapper"
					}
				}
			},
			{
				"operation": "insert",
				"name": "DynamicHeadersModule",
				"parentName": "HeadersContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE,
					"classes": {
						"wrapClassName": "content-item-panel-wrapper"
					}
				}
			},
			{
				"operation": "insert",
				"name": "InboxPreviewModule",
				"parentName": "InboxPreviewContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE,
					"classes": {
						"wrapClassName": "content-item-panel-wrapper"
					}
				}
			},
			{
				"operation": "insert",
				"name": "WizardIssuesContainer",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {"wrapClassName": ["wizard-issues-container"]},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "IssueViewerModule",
				"parentName": "WizardIssuesContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE,
					"classes": {
						"wrapClassName": "content-item-panel-wrapper"
					}
				}
			},
			{
				"operation": "insert",
				"name": "TestEmailMaskContainer",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"id": "TestEmailMask",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"visible": {"bindTo": "IsTestEmailVisible"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "TestEmail",
				"parentName": "MainContainer",
				"propertyName": "items",
				"values": {
					"id": "TestEmail",
					"itemType": Terrasoft.ViewItemType.MODULE,
					"classes": {
						"wrapClassName": "send-test-email-content-schema-body"
					},
					"visible": {"bindTo": "IsTestEmailVisible"},
					"items": []
				}
			}
		]
	};
});
