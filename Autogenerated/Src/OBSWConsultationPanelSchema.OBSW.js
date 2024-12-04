define("OBSWConsultationPanelSchema", ["OBSWConsultationPanelSchemaResources", "CtiConstants", "OBSWConstants",
		"ConfigurationConstants", "ModalBox", "Case", "ConfigurationItemGenerator", "CtiBaseHelper",
		"ImageCustomGeneratorV2", "OBSWImportantInformationMixin", "ConfigurationOBSWConsultationBlockListGenerator",
		"OBSWConsultationThemeMixin", "ConsultationPostprocessingWindow", "css!OBSWConsultationPanelSchemaCSS"
	],
	function(resources, CtiConstants, OBSWConstants, ConfigurationConstants, ModalBox) {
		return {
			entitySchemaName: "Case",
			messages: {

				/**
				 * @message GetHistoryState
				 * Gets current history state.
				 * @param {Object} config Configuration object.
				 */
				"GetHistoryState": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message CompleteConsultationProcess
				 * Message call closing current consultation process.
				 * @param {Object} config Configuration object.
				 */
				"CompleteConsultationProcess": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message SetForceChangeHistoryState
				 * Sets IsForceChangeHistoryState property value.
				 */
				"SetForceChangeHistoryState": {
					mode: this.Terrasoft.MessageMode.BROADCAST,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message PushHistoryState
				 * Sets new history state.
				 * @param {Object} config New history state configuration object.
				 */
				"PushHistoryState": {
					mode: this.Terrasoft.MessageMode.BROADCAST,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message OpenConsultation
				 * Opens consultation.
				 * {Object} config Configuration object.
				 */
				"OpenConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message GetCurrentConsultationInfo
				 * Message sends the information of the current consultation.
				 * {Object} config Configuration object.
				 */
				"GetCurrentConsultationInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message PostponeConsultation
				 * Postpones consultation.
				 * {Object} config Configuration object.
				 */
				"PostponeConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message ClearConsultationPanelData
				 * Clears consultation panel data.
				 */
				"ClearConsultationPanelData": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message GetCurrentConsultation
				 * Gets current consultation.
				 * {Object} config Configuration object.
				 */
				"GetCurrentConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message ConsultationDurationChanged
				 * Send consultation duration string.
				 * @param {String} Consultation duration.
				 */
				"ConsultationDurationChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message SelectedSideBarItemChanged
				 * Change selected section on new, on left panel.
				 * @param {String} Section structure.
				 */
				"SelectedSideBarItemChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message GetConsultaionStartedOn
				 * Message sends the information of the start consultation datetime.
				 * {Object} config Configuration object.
				 */
				"GetConsultaionStartedOn": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			mixins: {
				ImportantInformationMixin: "Terrasoft.OBSWImportantInformationMixin",
				ConsultationThemesMixin: "Terrasoft.OBSWConsultationThemeMixin",
			},
			attributes: {

				/**
				 * Case identifier.
				 * @protected
				 * @type {Guid}
				 */
				"CaseId": {
					"dataValueType": Terrasoft.DataValueType.GUID
				},

				/**
				 * Contact branch name.
				 * @type {String}
				 */
				"BranchName": {
					"name": "BranchName",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Contact social status name.
				 * @type {String}
				 */
				"SocialStatusName": {
					"name": "SocialStatusName",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Contact photo.
				 * @type {Object}
				 */
				"ContactPhoto": {
					"name": "ContactPhoto",
					"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Service level image.
				 * @type {Object}
				 */
				"ServiceLevelImage": {
					"name": "ServiceLevelImage",
					"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Contact name.
				 * @type {Object}
				 */
				"ContactName": {
					"name": "ContactName",
					"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Consultation total seconds.
				 * @type {Number}
				 */
				"TotalSeconds": {
					"name": "TotalSeconds",
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Case last active date.
				 * @type {Date}
				 */
				"LastActiveDate": {
					"name": "LastActiveDate",
					"dataValueType": Terrasoft.DataValueType.DATE_TIME,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Number of days to show significant event before its occurrence.
				 * @type {Number}
				 */
				"OBSWAnniversaryDaysUntil": {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": 3
				},

				/**
				 * Number of days to show significant event after its occurrence.
				 * @type {Number}
				 */
				"OBSWAnniversaryDaysAfter": {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": 3
				}
			},
			methods: {

				/**
				 * @param eventData
				 * @private
				 */
				_sendCurrentConsultationStartDate: function(eventData) {
					this.sandbox.publish("GetConsultaionStartedOn", eventData, [this.getOBSWModuleId()]);
				},

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
			 	 * @override
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.subscribeSandboxEvents();
						this.mixins.ImportantInformationMixin.initImportantInformation.call(this);
						this.mixins.ConsultationThemesMixin.initConsultationThemes.call(this);
						this.initSysSettings(function() {
							this.getCurrentConsultation();
							this.Ext.callback(callback, scope);
						}, this);
					}, this]);
				},

				/**
				 * Subscribe to the messages needed to work.
				 * @protected
				 */
				subscribeSandboxEvents: function() {
					var sandbox = this.sandbox;
					sandbox.subscribe("OpenConsultation", function(config) {
						this.openConsultation(config.caseId);
					}, this, [sandbox.id]);
					sandbox.subscribe("GetCurrentConsultationInfo", this.getCurrentConsultationInfo, this, [sandbox.id]);
					sandbox.subscribe("ClearConsultationPanelData", this.clearPanelData, this, [sandbox.id]);
				},

				/**
				 * System settings initialization.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				initSysSettings: function(callback, scope) {
					this.Terrasoft.SysSettings.querySysSettings(this.getSysSettingsArray(), function(values) {
						for (var key in values) {
							if (values.hasOwnProperty(key)) {
								var value = values[key];
								if (this.Ext.isDefined(value)) {
									this.set(key, value);
								}
							}
						}
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}, this);
				},

				/**
				 * Returns system setings codes array.
				 * @protected
				 * @return {Array} SysSetings codes array.
				 */
				getSysSettingsArray: function() {
					return ["OBSWAnniversaryDaysUntil", "OBSWAnniversaryDaysAfter"];
				},

				/**
				 * Returns OBSW module identifier.
				 * @protected
				 * @return {String} OBSW module identifier.
				 */
				getOBSWModuleId: function() {
					return this.sandbox.id.replace("_OBSWConsultationPanelSchemaModule", "");
				},

				/**
				 * Postpone consultation button click handler.
				 * @protected
				 */
				onPostponeConsultationButtonClick: function() {
					var config = {
						caseId: this.get("CaseId")
					};
					this.sandbox.publish("PostponeConsultation", config, [this.getOBSWModuleId()]);
					this.clearPanelData();
				},

				/**
				 * Returns the information of the current consultation.
				 * @protected
				 * @return {Object} Object with information.
				 */
				getCurrentConsultationInfo: function() {
					return {
						caseId: this.get("CaseId"),
						contact: this.get("Contact"),
						account: this.get("Account"),
						symptoms: this.get("Symptoms"),
						number: this.get("Number"),
						status: this.get("Status")
					};
				},

				/**
				 * Completed consultation button click handler.
				 * @protected
				 */
				onCompleteConsultationButtonClick: function() {
					this.showConsultationPostprocessingWindow();
				},

				/**
				 * Opens a modal postprocessing window.
				 * @protected
				 */
				showConsultationPostprocessingWindow: function() {
					var config = {
						heightPixels: 638,
						widthPixels: 1200,
						boxClasses: ["consultation-postprocessing-page-modal-box"]
					};
					var moduleId = this.getConsultationPostprocessingWindowId();
					var renderTo = ModalBox.show(config, function() {
						this.sandbox.unloadModule(moduleId, renderTo);
					}.bind(this));
					this.sandbox.loadModule("BaseSchemaModuleV2", {
						id: moduleId,
						renderTo: renderTo,
						instanceConfig: {
							"isSchemaConfigInitialized": true,
							"schemaName": "ConsultationPostprocessingWindow",
							"useHistoryState": false
						}
					});
				},

				/**
				 * Returns consultation postprocessing window identifier.
				 * @protected
				 * @return {String} Consultation postprocessing window identifier.
				 */
				getConsultationPostprocessingWindowId: function() {
					return (this.sandbox.id + "_ConsultationPostprocessingWindow");
				},

				/**
				 * Gets current consultation config and open it.
				 * @protected
				 */
				getCurrentConsultation: function() {
					var config = this.sandbox.publish("GetCurrentConsultation", null, [this.getOBSWModuleId()]);
					if (config && config.caseId) {
						this.openConsultation(config.caseId);
					}
				},

				/**
				 * Clears panel data.
				 * @protected
				 */
				clearPanelData: function() {
					this.set("ConsultationContainerVisible", false);
					this.set("CaseId", null);
					this.set("ConsultationStartedOn", null);
					this.set("TotalSeconds", 0);
					this.set("LastActiveDate", null);
					this.set("Account", null);
					this.set("Contact", null);
					this.set("Symptoms", null);
					this.set("Number", null);
					this.set("Status", null);
					this.stopConsultationDuration();
					this.set("ConsultationDuration", "00:00");
					this.clearImportantInformation();
					this.clearConsultationThemes();
				},

				/**
				 * Opens consultation.
				 * @protected
				 * @param {Guid} caseId Case identifier.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				openConsultation: function(caseId, callback, scope) {
					this.clearPanelData();
					this.set("CaseId", caseId);
					var maskId = this.Terrasoft.Mask.show({
						selector: ".right-panel-modules-container",
						timeout: 0
					});
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName
					});
					this.addCaseDataColumns(esq);
					this.addContactDataColumns(esq);
					esq.getEntity(caseId, function(result) {
						this.Terrasoft.chain(
							function(next) {
								if (result.success) {
									this.setPanelData(result.entity, next, this);
								} else {
									next();
								}
							},
							function() {
								this.Terrasoft.Mask.hide(maskId);
								if (this.Ext.isFunction(callback)) {
									callback.call(scope || this);
								}
							},
							this
						);
					}, this);
				},

				/**
				 * Adds case column in query instance.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq Query which will be added to the case column.
				 */
				addCaseDataColumns: function(esq) {
					esq.addColumn("[VwCaseDuration:Id].TotalSeconds", "TotalSeconds");
					esq.addColumn("[VwCaseDuration:Id].LastActiveDate", "LastActiveDate");
					esq.addColumn("Account");
					esq.addColumn("Contact");
					esq.addColumn("Symptoms");
					esq.addColumn("Number");
					esq.addColumn("Status");
				},

				/**
				 * Adds contact column in query instance.
				 * @protected
				 * @param {Terrasoft.EntitySchemaQuery} esq Query which will be added to the contact column.
				 */
				addContactDataColumns: function(esq) {
					esq.addColumn("Contact.Id", "ContactId");
					esq.addColumn("Contact.Name", "ContactName");
					esq.addColumn("Contact.Branch.Name", "BranchName");
					esq.addColumn("Contact.Photo", "ContactPhoto");
					esq.addColumn("Contact.ServiceLevel.Image", "ServiceLevelImage");
					esq.addColumn("Contact.SocialStatus.Name", "SocialStatusName");
				},

				/**
				 * Returns a query to significant events contact.
				 * @param {Guid} contactId Contact identifier.
				 * @return {Terrasoft.EntitySchemaQuery} Query.
				 */
				getContactAnniversaryQuery: function(contactId) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "ContactAnniversary"
					});
					esq.addColumn("Date");
					esq.addColumn("AnniversaryType.Id", "AnniversaryTypeId");
					esq.addColumn("AnniversaryType.Name", "AnniversaryTypeName");
					esq.filters.add("ContactFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"Contact",
						contactId));
					return esq;
				},

				/**
				 * Initializes significant events contact.
				 * @param {Guid} contactId Contact identifier.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				initContactAnniversary: function(contactId, callback, scope) {
					var esq = this.getContactAnniversaryQuery(contactId);
					esq.getEntityCollection(function(result) {
						if (result.success) {
							this.addContactAnniversaries(result.collection);
						}
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}, this);
				},

				/**
				 * Check whether months are from the same year.
				 * @param {Date} startDateMonth Date.
				 * @param {Date} endDateMonth Date.
				 * @return {Boolean}
				 */
				areMonthsFromOneYear: function(startDateMonth, endDateMonth) {
					var monthsDifference = endDateMonth - startDateMonth;
					return monthsDifference >= 0;
				},

				/**
				 * Check whether dates are equal.
				 * @protected
				 * @param {Date} date Date which month will be compared.
				 * @param {Number} monthNumber Number month that will be compared with date month.
				 * @return {Boolean}
				 */
				areMonthsEqual: function(inputDate, monthNumber) {
					var inputMonth = inputDate.getMonth();
					return inputMonth === monthNumber;
				},

				/**
				 * Check whether input anniversary day greater than start period day.
				 * @protected
				 * @param {Date} startPeriodDate Date which day will be compared to start period day.
				 * @param {Number} inputDateDay Number of input anniversary day.
				 * @return {Boolean}
				 */
				isInputDayGreaterThanStart: function(startPeriodDate, inputDateDay) {
					var startDateDay = startPeriodDate.getDate();
					return inputDateDay >= startDateDay;
				},

				/**
				 * Check whether input anniversary day less than end period day.
				 * @protected
				 * @param {Date} startPeriodDate Date which day will be compared to end period day.
				 * @param {Number} inputDateDay Number of input anniversary day.
				 * @return {Boolean}
				 */
				isInputDayLessThanEnd: function(inputDateDay, endPeriodDate) {
					var endPeriodDay = endPeriodDate.getDate();
					return inputDateDay <= endPeriodDay;
				},

				/**
				 * Check whether input anniversary month is in allowed period determined by user restrictions.
				 * @protected
				 * @param {Object} periodConfig Object.
				 * @param {Object} inputAnniversaryConfig Object.
				 * @return {Boolean}
				 */
				isInputDateBetweenAllowedPeriod: function(periodConfig, inputAnniversaryConfig) {
					var startPeriodDate = periodConfig.startPeriodDate;
					var startDateMonth = startPeriodDate.getMonth();

					var endPeriodDate = periodConfig.endPeriodDate;
					var endDateMonth = endPeriodDate.getMonth();
					var inputDateMonth = inputAnniversaryConfig.inputDateMonth;

					if (!this.areMonthsFromOneYear(startDateMonth, endDateMonth)) {
						if (startDateMonth > inputDateMonth) {
							return inputDateMonth < endDateMonth;
						}
						if (startDateMonth < inputDateMonth) {
							return inputDateMonth > endDateMonth;
						}
						return false;
					}

					return (startDateMonth < inputDateMonth) && (inputDateMonth < endDateMonth);
				},

				/**
				 * Check whether input anniversary month/day is in start period.
				 * @protected
				 * @param {Object} periodConfig Object.
				 * @param {Object} inputAnniversaryConfig Object.
				 * @return {Boolean}
				 */
				isInputMonthEqualsToStartPeriodDate: function(periodConfig, inputAnniversaryConfig) {
					var startPeriodDate = periodConfig.startPeriodDate;
					var inputDateMonth = inputAnniversaryConfig.inputDateMonth;
					var inputDateDay = inputAnniversaryConfig.inputDateDay;

					return (this.areMonthsEqual(startPeriodDate, inputDateMonth)) &&
						this.isInputDayGreaterThanStart(startPeriodDate, inputDateDay);
				},

				/**
				 * Check whether input anniversary month/day is in end period.
				 * @protected
				 * @param {Object} periodConfig Object.
				 * @param {Object} inputAnniversaryConfig Object.
				 * @return {Boolean}
				 */
				isInputMonthEqualsToEndPeriodDate: function(periodConfig, inputAnniversaryConfig) {
					var endPeriodDate = periodConfig.endPeriodDate;
					var inputDateMonth = inputAnniversaryConfig.inputDateMonth;
					var inputDateDay = inputAnniversaryConfig.inputDateDay;
					
					return this.areMonthsEqual(endPeriodDate, inputDateMonth) &&
						this.isInputDayLessThanEnd(inputDateDay, endPeriodDate);
				},

				/**
				 * Create config with calculated period parameters
				 * @protected
				 * @return {Object} Config.
				 */
				createPeriodConfig: function() {
					var currentDate = new Date();

					var daysAmountBeforeAnniversaryDay = this.get("OBSWAnniversaryDaysUntil");
					var daysAmountAfterAnniversaryDay = this.get("OBSWAnniversaryDaysAfter");

					var startPeriodDate = Ext.Date.add(currentDate, this.Ext.Date.DAY, -daysAmountBeforeAnniversaryDay);
					var endPeriodDate = Ext.Date.add(currentDate, this.Ext.Date.DAY, daysAmountAfterAnniversaryDay);

					var periodConfig = {
						"startPeriodDate": startPeriodDate,
						"endPeriodDate": endPeriodDate
					};

					return periodConfig;
				},

				/**
				 * Check wheather input anniversary month is in allowed period.
				 * @protected
				 * @param {Object} periodConfig Object contains information about period limits.
				 * @param {Object} inputAnniversaryConfig Object contains anniversary date, month, day.
				 * @return {Boolean}
				 */
				isDayBetweenAllowedDayPeriod: function(periodConfig, inputAnniversaryConfig) {
					var startPeriodDay = periodConfig.startPeriodDate.getDate();
					var endPeriodDay = periodConfig.endPeriodDate.getDate();
					var inputDateDay = inputAnniversaryConfig.inputDateDay;
					
					var inputMonthEqualOrGreaterThenStart = startPeriodDay <= inputDateDay;
					var inputMonthEqualOrLessThenEnd = inputDateDay <= endPeriodDay;

					return inputMonthEqualOrGreaterThenStart && inputMonthEqualOrLessThenEnd;
				},

				/**
				 * Check wheather input anniversary date is equal to start or end limits of the period.
				 * @protected
				 * @param {Object} periodConfig Object contains information about period limits.
				 * @param {Object} inputAnniversaryConfig Object contains anniversary date, month, day.
				 * @return {Boolean}
				 */
				isInputMonthEqualsToOneOfPeriodLimit: function(periodConfig, inputAnniversaryConfig) {
					return this.isInputMonthEqualsToStartPeriodDate(periodConfig, inputAnniversaryConfig) ?
						true : this.isInputMonthEqualsToEndPeriodDate(periodConfig, inputAnniversaryConfig);
				},

				/**
				 * Check whether start/end period months are equal.
				 * @protected
				 * @param {Object} periodConfig Object contains information about period limits.
				 * @param {Object} inputAnniversaryConfig Object contains anniversary date, month, day.
				 * @return {Boolean}
				 */
				isInputMonthEqualsToBothPeriodLimits: function(periodConfig, inputDateConfig) {
					var endDateMonth = periodConfig.endPeriodDate.getMonth();
					var startDateMonth = periodConfig.startPeriodDate.getMonth();
					var inputDateMonth = inputDateConfig.inputDateMonth;

					return (startDateMonth === endDateMonth) && (startDateMonth === inputDateMonth);
				},

				/**
				 * Create config with input anniversary information.
				 * @protected
				 * @return {Object} Config.
				 */
				createInputAnniversaryConfig: function(anniversary) {
					var inputDate = anniversary.get("Date");
					var inputDateMonth = inputDate.getMonth();
					var inputDateDay = inputDate.getDate();

					return {
						"inputDate": inputDate,
						"inputDateMonth": inputDateMonth,
						"inputDateDay": inputDateDay
					};
				},

				/**
				 * Check whether input anniversary date is in allowed period determined by user restrictions.
				 * @protected
				 * @param {Date} anniversary Date.
				 * @return {Boolean}
				 */
				isAnniversaryDateInAvailablePeriod: function(anniversary) {
					var periodConfig = this.createPeriodConfig();
					var inputAnniversaryConfig = this.createInputAnniversaryConfig(anniversary);

					if (this.isInputMonthEqualsToBothPeriodLimits(periodConfig, inputAnniversaryConfig)) {
						return this.isDayBetweenAllowedDayPeriod(periodConfig, inputAnniversaryConfig);
					}

					return this.isInputDateBetweenAllowedPeriod(periodConfig, inputAnniversaryConfig) ||
						this.isInputMonthEqualsToOneOfPeriodLimit(periodConfig, inputAnniversaryConfig);
				},

				/**
				 * Get filled anniversary collection item.
				 * @protected
				 * @param {Object} labelConfig Object.
				 * @param {Object} inputAnniversary Object.
				 * @return {Boolean}
				 */
				getAnniversaryCollectionItem: function(labelConfig, inputAnniversary) {
					var schemaName = "ContactAnniversary";
					var anniversaryTypeName = inputAnniversary.get("AnniversaryTypeName");

					var anniversaryItem = this.getImportantInformationItem({
						schemaName: schemaName,
						tag: schemaName + "-" + anniversaryTypeName
					});

					anniversaryItem.set("LabelCaption", labelConfig.labelCaption);
					anniversaryItem.set("LabelHint", labelConfig.hintCaption);
					var icon = this.getImportantInformationItemIcon(schemaName,
						inputAnniversary.get("AnniversaryTypeId"));
					anniversaryItem.set("Icon", icon);
					
					return anniversaryItem;
				},

				/**
				 * Add filtered contact anniversaries to communication panel.
				 * @protected
				 * @param {Object} labelConfig Object contains label caption, hint.
				 * @param {Object} inputAnniversary Object.
				 */
				addAnniversaryToPanelCollection: function(labelConfig, inputAnniversary) {
					var anniversaryCollection = this.get("ImportantInformationCollection");
					var anniversaryItem = this.getAnniversaryCollectionItem(labelConfig, inputAnniversary);

					anniversaryCollection.addItem(anniversaryItem);
				},

				/**
				 * Create label with contact anniversary information.
				 * @protected
				 * @param {Object} labelConfig Object contains label caption, hint.
				 * @param {Object} inputAnniversary Object.
				 * @return {Object} labelConfig Object.
				 */
				createAnniversaryLabel: function(inputAnniversary) {
					var inputDate = inputAnniversary.get("Date");
					var inputDateWithClearedTime = this.Ext.Date.clearTime(inputDate);
					var currentDate = this.Ext.Date.clearTime(new Date(this.Ext.Date.now()));
					var anniversaryTypeName = inputAnniversary.get("AnniversaryTypeName");

					var dateString = this.Ext.Date.format(inputDateWithClearedTime, "d.m");
					var anniversaryCountString = this.getAnniversaryAgeString(this.getDateDiffInDays(
						currentDate, inputDateWithClearedTime));

					var labelConfig = this.getContactAnniversaryLabelCaptionConfig(anniversaryTypeName,
						dateString, anniversaryCountString);

					return labelConfig;
				},

				/**
				 * Create label with contact anniversary information.
				 * @protected
				 * @param {Object} contactAnniversaryCollection.
				 * @param {Object} inputAnniversary Object.
				 * @return {Object} labelConfig Object.
				 */
				addContactAnniversaries: function(contactAnniversaryCollection) {
					contactAnniversaryCollection.each(function(inputAnniversaryItem) {
						if (this.isAnniversaryDateInAvailablePeriod(inputAnniversaryItem)) {
							var anniversaryLabel = this.createAnniversaryLabel(inputAnniversaryItem);
							this.addAnniversaryToPanelCollection(anniversaryLabel, inputAnniversaryItem);
						}
					}, this);
				},

				/**
				 * Gets important information item's icon.
				 * @protected
				 * @param {String} imageName Image name.
				 * @param {String} anniversaryType Type of anniversary (optional).
				 * @return {Object} Item's icon.
				 */
				getImportantInformationItemIcon: function(imageName, anniversaryType) {
					if (anniversaryType === OBSWConstants.AnniversaryType.CompanyFoundationDay) {
						imageName = "CompanyFoundationDay";
					}
					return this.get("Resources.Images." + imageName + "Image");
				},

				/**
				 * Returns the configuration settings of the label significant events contact.
				 * @protected
				 * @param {String} anniversaryTypeName Significant event name.
				 * @param {String} dateString Significant event date.
				 * @param {String} anniversaryCountString Significant event age.
				 * @return {Object} Configuration settings of the label significant events contact.
				 */
				getContactAnniversaryLabelCaptionConfig: function(anniversaryTypeName, dateString, anniversaryCountString) {
					var maxCaptionLength = 16;
					var anniversaryLabelCaption = anniversaryTypeName;
					var anniversaryHintCaption = "";
					if (anniversaryLabelCaption.length > maxCaptionLength) {
						var dots = "...";
						anniversaryLabelCaption = anniversaryLabelCaption.substring(0, maxCaptionLength - dots.length) + dots;
						anniversaryHintCaption = this.Ext.String.format("{0} {1}", anniversaryTypeName, dateString);
					}
					anniversaryLabelCaption = this.Ext.String.format("{0} {1}", anniversaryLabelCaption, dateString);
					if (anniversaryCountString) {
						if (anniversaryHintCaption) {
							anniversaryHintCaption = this.Ext.String.format("{0} ({1})", anniversaryHintCaption, anniversaryCountString);
						}
						anniversaryLabelCaption = this.Ext.String.format("{0} ({1})", anniversaryLabelCaption, anniversaryCountString);
					}
					return {
						labelCaption: anniversaryLabelCaption,
						hintCaption: anniversaryHintCaption
					};
				},

				/**
				 * Returns date difference in days.
				 * @protected
				 * @param {Date} date1 Date 1.
				 * @param {Date} date2 Date 2.
				 * @return {Number} Difference of dates in days.
				 */
				getDateDiffInDays: function(date1, date2) {
					var oneDay = 1000 * 60 * 60 * 24;
					var date1InMs = date1.getTime();
					var date2InMs = date2.getTime();
					var differenceInMs = date1InMs - date2InMs;
					return Math.round(differenceInMs / oneDay);
				},

				/**
				 * Returns age string.
				 * @protected
				 * @param {Number} days Days count.
				 * @return {String} Age string.
				 */
				getAnniversaryAgeString: function(days) {
					var result;
					var count;
					var prefix;
					if (!days) {
						return result;
					}
					var years = Math.round(days / 365);
					var month = Math.round(days / 30);
					if (years >= 1) {
						count = years;
						prefix = "Year";
					} else if (month >= 1) {
						count = month;
						prefix = "Month";
					} else if (days >= 1) {
						count = days;
						prefix = "Day";
					}
					if (!count || !prefix) {
						return result;
					}
					var lastNumber = (count % 10);
					var isGenitive = [2, 3, 4].indexOf(lastNumber) > -1;
					var isPlural = [5, 6, 7, 8, 9, 0].indexOf(lastNumber) > -1;
					if (count === 1) {
						result = this.get("Resources.Strings." + prefix);
					} else if (isGenitive) {
						result = this.get("Resources.Strings." + prefix + "s");
					} else if (count === 0 || isPlural) {
						result = this.get("Resources.Strings." + prefix + "s2");
					}
					if (result && count) {
						result = this.Ext.String.format("{0} {1}", count, result);
					}
					return result;
				},

				/**
				 * Initializes contact leads count.
				 * @param {Guid} contactId Contact identifier.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				initLeadCount: function(contactId, callback, scope) {
					var qualifyStatus = OBSWConstants.QualifyStatus;
					var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
					var qualifyStatusFilter = this.Terrasoft.createColumnInFilterWithParameters(
						"QualifyStatus", [qualifyStatus.Disqualified, qualifyStatus.Satisfied, qualifyStatus.Absent],
						this.Terrasoft.DataValueType.GUID);
					qualifyStatusFilter.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
					filterGroup.add("qualifyStatusFilter", qualifyStatusFilter);
					var config = {
						schemaName: "Lead",
						contactId: contactId,
						columnPath: "QualifiedContact",
						filterGroup: filterGroup
					};
					this.initEntityCount(config, callback, scope);
				},

				/**
				 * Initializes contact applications count.
				 * @param {Guid} contactId Contact identifier.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				initFinApplicationCount: function(contactId, callback, scope) {
					var status = OBSWConstants.FinApplication.Status;
					var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
					var statusFilter = this.Terrasoft.createColumnInFilterWithParameters(
						"Status", [status.Closed, status.Canceled],
						this.Terrasoft.DataValueType.GUID);
					statusFilter.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
					filterGroup.add("statusFilter", statusFilter);
					var config = {
						schemaName: "FinApplication",
						contactId: contactId,
						columnPath: "Contact",
						filterGroup: filterGroup
					};
					this.initEntityCount(config, callback, scope);
				},

				/**
				 * Initializes contact cases count.
				 * @param {Guid} contactId Contact identifier.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				initCaseCount: function(contactId, callback, scope) {
					var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
					filterGroup.add("activeFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.NOT_EQUAL,
						"IsActive",
						true,
						this.Terrasoft.DataValueType.BOOLEAN));
					filterGroup.add("statusFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.NOT_EQUAL,
						"Status.IsFinal",
						true,
						this.Terrasoft.DataValueType.BOOLEAN));
					var config = {
						schemaName: "Case",
						contactId: contactId,
						columnPath: "Contact",
						filterGroup: filterGroup
					};
					this.initEntityCount(config, callback, scope);
				},

				/**
				 * Sets panel data.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} entity Item ViewModel.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				setPanelData: function(entity, callback, scope) {
					var contactId = entity.get("ContactId");
					this.Terrasoft.chain(
						function(next) {
							this.setCaseData(entity);
							this.setContactData(entity);
							next();
						},
						function(next) {
							this.initCaseCount(contactId, next, this);
						},
						function(next) {
							this.initLeadCount(contactId, next, this);
						},
						function(next) {
							this.initFinApplicationCount(contactId, next, this);
						},
						function(next) {
							this.initContactAnniversary(contactId, next, this);
						},
						this.loadConsultationThemes,
						function() {
							this.startConsultationDuration();
							this.set("ConsultationContainerVisible", true);
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this);
							}
						},
						this
					);
				},

				/**
				 * Sets the case data.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} entity Copy of the essence.
				 */
				setCaseData: function(entity) {
					this.set("TotalSeconds", entity.get("TotalSeconds"));
					this.set("LastActiveDate", entity.get("LastActiveDate"));
					this.set("Account", entity.get("Account"));
					this.set("Contact", entity.get("Contact"));
					this.set("Symptoms", entity.get("Symptoms"));
					this.set("Number", entity.get("Number"));
					this.set("Status", entity.get("Status"));
				},

				/**
				 * Sets contact data.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} entity Item ViewModel.
				 */
				setContactData: function(entity) {
					var branchName = entity.get("BranchName") || "";
					var socialStatusName = entity.get("SocialStatusName") || "";
					var serviceLevelImage = entity.get("ServiceLevelImage") || null;
					this.set("BranchName", branchName);
					this.set("SocialStatusName", socialStatusName);
					this.set("BranchNameVisible", !this.Ext.isEmpty(branchName));
					this.set("SocialStatusNameVisible", !this.Ext.isEmpty(socialStatusName));
					this.set("ContactPhoto", entity.get("ContactPhoto"));
					this.set("ServiceLevelImage", serviceLevelImage);
					this.set("ContactServiceLevelImageContainerVisible", !this.Ext.isEmpty(serviceLevelImage));
					this.set("ContactName", entity.get("ContactName"));
					this.set("ContactId", entity.get("ContactId"));
				},

				/**
				 * Starts counter counting the duration of consultation.
				 * @protected
				 */
				startConsultationDuration: function() {
					var scope = this;
					var durationTimerIntervalId = setInterval(function() {
						scope.updateConsultationDuration.call(scope);
					}, CtiConstants.TalkDuration.RefreshRate);
					var consultationStartedOn = this.get("LastActiveDate") ||
						this.getCurrentDateWithProfileTimeZone();
					var totalSeconds = this.get("TotalSeconds");
					if (totalSeconds > 0) {
						consultationStartedOn.setSeconds(consultationStartedOn.getSeconds() - totalSeconds);
					}
					this.set({
						DurationTimerIntervalId: durationTimerIntervalId,
						ConsultationStartedOn: consultationStartedOn
					});
					this._sendCurrentConsultationStartDate( {
						contactName: this.get("ContactName"),
						communicationStartedOn: consultationStartedOn
					});
				},

				/**
				 * Stops counter counting the duration of consultation.
				 * @protected
				 */
				stopConsultationDuration: function() {
					var durationTimerIntervalId = this.get("DurationTimerIntervalId");
					clearInterval(durationTimerIntervalId);
					this._sendCurrentConsultationStartDate( {
						contactName: null
					});
					this.publishConsultationDurationChanged();
				},

				/**
				 * Returns current user time with profile time zone.
				 * @protected
				 * @return {Date} Current user time.
				 */
				getCurrentDateWithProfileTimeZone: function() {
					var currentDate = new Date();
					var currentUserTimeOffset = this.Terrasoft.SysValue.CURRENT_USER_TIMEZONE_OFFSET;
					if (typeof currentUserTimeOffset !== "number") {
						return currentDate;
					}
					var currentLocalTimeOffset = currentDate.getTimezoneOffset();
					var timeDifference = currentUserTimeOffset + currentLocalTimeOffset;
					return this.Terrasoft.addMinutes(currentDate, timeDifference);
				},

				/**
				 * Update consultation duration string.
				 * @protected
				 */
				updateConsultationDuration: function() {
					var currentDate = this.getCurrentDateWithProfileTimeZone();
					var commutationStartedOn = this.get("ConsultationStartedOn");
					var timeDifference = this.Ext.Date.getElapsed(currentDate, commutationStartedOn);
					var secondDifference = Math.floor(timeDifference / CtiConstants.TimeScale.MillisecondsInSecond);
					var minutes = Math.floor(secondDifference / CtiConstants.TimeScale.SecondsInMinute);
					if (minutes < CtiConstants.TimeScale.MinTwoDigitNumber) {
						minutes = "0" + minutes;
					}
					var seconds = secondDifference - (minutes * CtiConstants.TimeScale.SecondsInMinute);
					if (seconds < CtiConstants.TimeScale.MinTwoDigitNumber) {
						seconds = "0" + seconds;
					}
					var msg = this.Ext.String.format("{0}:{1}", minutes, seconds);
					this.set("ConsultationDuration", msg);
					this.publishConsultationDurationChanged(msg);
				},

				/**
				 * Returns contact photo url.
				 * @protected
				 * @return {String} Contact photo url.
				 */
				getContactImage: function() {
					var primaryImageColumnValue = this.get("ContactPhoto");
					if (primaryImageColumnValue) {
						return this.getSchemaImageUrl(primaryImageColumnValue);
					}
					return this.getContactDefaultImage();
				},

				/**
				 * Returns contact service level image url.
				 * @protected
				 * @return {String} Contact service level image url.
				 */
				getServiceLevelImage: function() {
					var primaryImageColumnValue = this.get("ServiceLevelImage");
					if (primaryImageColumnValue) {
						return this.getSchemaImageUrl(primaryImageColumnValue);
					}
				},

				/**
				 * Returns contact default photo url.
				 * @protected
				 * @return {String} Contact default photo url.
				 */
				getContactDefaultImage: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.DefaultContactPhoto"));
				},

				/**
				 * Gets image url.
				 * @protected
				 * @return {String} Requested image url.
				 */
				getSchemaImageUrl: function(primaryImageColumnValue) {
					if (!primaryImageColumnValue) {
						return null;
					}
					var imageConfig = {
						source: this.Terrasoft.ImageSources.SYS_IMAGE,
						params: {
							primaryColumnValue: primaryImageColumnValue.value
						}
					};
					return this.Terrasoft.ImageUrlBuilder.getUrl(imageConfig);
				},

				/**
				 * Send consultation duration string.
				 * @protected
				 * @param {String} consultationDuration Consultation duration string.
				 */
				publishConsultationDurationChanged: function(consultationDuration) {
					this.sandbox.publish("ConsultationDurationChanged", consultationDuration);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSchemaModuleV2#destroy
				 * @override
				 */
				destroy: function() {
					this.stopConsultationDuration();
					this.callParent(arguments);
				}

				//endregion

			},
			diff: [{
				"operation": "insert",
				"name": "ConsultationContainer",
				"values": {
					"id": "ConsultationContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"visible": {
						"bindTo": "ConsultationContainerVisible"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "ConsultationClientInfoContainer",
				"parentName": "ConsultationContainer",
				"propertyName": "items",
				"values": {
					"id": "ConsultationClientInfoContainer",
					"wrapClass": ["consultation-client-info-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "ConsultationLeftContainer",
				"parentName": "ConsultationClientInfoContainer",
				"propertyName": "items",
				"values": {
					"id": "ConsultationLeftContainer",
					"wrapClass": ["consultation-left-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ConsultationLeftContainer",
				"propertyName": "items",
				"name": "ContactPhotoContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["contact-photo-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ContactPhotoContainer",
				"propertyName": "items",
				"name": "ContactPhoto",
				"values": {
					"getSrcMethod": "getContactImage",
					"onPhotoChange": Terrasoft.emptyFn,
					"readonly": true,
					"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
					"imageStyle": Terrasoft.ImageStyle.CIRCLE
				}
			}, {
				"operation": "insert",
				"parentName": "ConsultationLeftContainer",
				"propertyName": "items",
				"name": "ContactServiceLevelImageContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["contact-service-level-image-container"],
					"visible": {
						"bindTo": "ContactServiceLevelImageContainerVisible"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ContactServiceLevelImageContainer",
				"propertyName": "items",
				"name": "ServiceLevelImage",
				"values": {
					"getSrcMethod": "getServiceLevelImage",
					"onPhotoChange": Terrasoft.emptyFn,
					"readonly": true,
					"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage"
				}
			}, {
				"operation": "insert",
				"name": "ConsultationRightContainer",
				"parentName": "ConsultationClientInfoContainer",
				"propertyName": "items",
				"values": {
					"id": "ConsultationRightContainer",
					"wrapClass": ["consultation-right-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "IdentificationDataPanel",
				"parentName": "ConsultationRightContainer",
				"propertyName": "items",
				"values": {
					"id": "IdentificationDataPanel",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["identification-data-panel"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "IdentificationDataPanel",
				"propertyName": "items",
				"name": "ContactNameLabel",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "ContactName"
					},
					"classes": {
						"labelClass": ["contact-name-label"]
					}
				}
			}, {
				"operation": "insert",
				"name": "SocialStatusName",
				"parentName": "IdentificationDataPanel",
				"propertyName": "items",
				"values": {
					"visible": {
						"bindTo": "SocialStatusNameVisible"
					},
					"value": {
						"bindTo": "SocialStatusName"
					},
					"generator": "CtiBaseHelper.getIdentificationDataLabel"
				}
			}, {
				"operation": "insert",
				"name": "BranchName",
				"parentName": "IdentificationDataPanel",
				"propertyName": "items",
				"values": {
					"visible": {
						"bindTo": "BranchNameVisible"
					},
					"value": {
						"bindTo": "BranchName"
					},
					"generator": "CtiBaseHelper.getIdentificationDataLabel"
				}
			}, {
				"operation": "insert",
				"name": "ConsultationDurationInfo",
				"parentName": "ConsultationRightContainer",
				"propertyName": "items",
				"values": {
					"id": "ConsultationDurationInfo",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"visible": true,
					"classes": {
						"wrapClassName": ["consultation-duration-container"]
					},
					"items": [{
						"id": "ConsultationDurationLabel",
						"itemType": Terrasoft.ViewItemType.LABEL,
						"classes": {
							"labelClass": ["label-caption"]
						},
						"markerValue": "ConsultationDurationLabel",
						"caption": {
							"bindTo": "Resources.Strings.ConsultationDurationLabelCaption"
						}
					}, {
						"id": "ConsultationDuration",
						"itemType": Terrasoft.ViewItemType.LABEL,
						"classes": {
							"labelClass": ["consultation-duration"]
						},
						"markerValue": "ConsultationDuration",
						"caption": {
							"bindTo": "ConsultationDuration"
						}
					}]
				}
			}, {
				"operation": "insert",
				"name": "ConsultationButtonContainer",
				"parentName": "ConsultationContainer",
				"propertyName": "items",
				"values": {
					"wrapClass": ["consultation-button-container"],
					"markerValue": "ConsultationButtonContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ConsultationButtonContainer",
				"propertyName": "items",
				"name": "PostponeConsultationButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.PostponeConsultationButtonCaption"
					},
					"classes": {
						"textClass": "consultation-actions-button"
					},
					"click": {
						"bindTo": "onPostponeConsultationButtonClick"
					},
					"style": Terrasoft.controls.ButtonEnums.style.DEFAULT,
					"tag": "postponeConsultationButton",
					"markerValue": "PostponeConsultationButton"
				}
			}, {
				"operation": "insert",
				"parentName": "ConsultationButtonContainer",
				"propertyName": "items",
				"name": "CompleteConsultationButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.CompleteConsultationButtonCaption"
					},
					"classes": {
						"textClass": "consultation-actions-button"
					},
					"click": {
						"bindTo": "onCompleteConsultationButtonClick"
					},
					"style": Terrasoft.controls.ButtonEnums.style.RED,
					"tag": "completeConsultationButton",
					"markerValue": "CompleteConsultationButton"
				}
			}, {
				"operation": "insert",
				"name": "ImportantInformationContainer",
				"parentName": "ConsultationContainer",
				"propertyName": "items",
				"values": {
					"id": "ImportantInformationContainer",
					"markerValue": "ImportantInformationContainer",
					"wrapClass": ["important-information-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ImportantInformationContainer",
				"name": "ImportantInformation",
				"propertyName": "items",
				"values": {
					"classes": {
						"wrapClassName": ["important-information-container-list"]
					},
					"markerValue": "ImportantInformationContainerList",
					"generator": "ConfigurationItemGenerator.generateContainerList",
					"idProperty": "Tag",
					"itemPrefix": "Tag",
					"collection": "ImportantInformationCollection",
					"dataItemIdPrefix": "important-information-item",
					"selectableRowCss": "",
					"onGetItemConfig": "getImportantInformationItemViewConfig"
				}
			}, {
				"operation": "insert",
				"name": "ConsultationThemesContainer",
				"parentName": "ConsultationContainer",
				"propertyName": "items",
				"values": {
					"id": "ConsultationThemesContainer",
					"markerValue": "ConsultationThemesContainer",
					"wrapClass": ["consultation-themes-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ConsultationThemesContainer",
				"name": "ConsultationThemes",
				"propertyName": "items",
				"values": {
					"generator": "ConfigurationOBSWConsultationBlockListGenerator.generateOBSWConsultationBlockList",
					"markerValue": "ConsultationThemesContainerList",
					"idProperty": "Id",
					"collection": {
						"bindTo": "ConsultationThemesCollection"
					},
					"classes": {
						"wrapClassName": "consultation-block-list"
					},
					"itemPrefix": "consultation-block",
					"dataItemIdPrefix": "consultation-block"
				}

			}]
		};
	});
