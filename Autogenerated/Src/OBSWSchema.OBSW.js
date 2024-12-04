define("OBSWSchema", ["OBSWConstants", "NetworkUtilities", "ConfigurationConstants", "Case",
		"OBSWSearchPanelSchema", "OBSWConsultationPanelSchema", "OBSWPendingConsultationPanelSchema", "BaseSchemaModuleV2",
		"OBSWMixin", "OBSWConsultationPanelMixin"
	],
	function(OBSWConstants, NetworkUtilities, ConfigurationConstants) {
		return {
			entitySchemaName: "Case",
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
				 * @message GetCurrentConsultation
				 * @return {Object} config ###### # ##########.
				 */
				"GetCurrentConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message StartNewConsultation
				 * ######### #### ####### ###### ##### ############ ## ########## ########.
				 * @param {Object} config ###### # ##########.
				 * @param {Object} config.contact ######### #######.
				 */
				"StartNewConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message ContinueConsultation
				 * ######### #### ####### ########## ############.
				 * @param {Object} config ###### # ##########.
				 * @param {Guid} caseId ############# #########.
				 * @param {Object} contact ####### #########.
				 */
				"ContinueConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message PostponeConsultation
				 * ######### ###########, ### ############ ########.
				 * @param {Guid} ############# ############.
				 */
				"PostponeConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message CompleteConsultation
				 * ######### ###########, ### ############ #########.
				 * @param {Guid} ############# ############.
				 */
				"CompleteConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message LoadPendingConsultations
				 * ######### ######### ###### ############ ## #########.
				 * @param {Object} config ################ ######.
				 */
				"LoadPendingConsultations": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message OpenConsultation
				 * ######### #### ####### ## ######## ############.
				 * @param {Object} config ################ ######.
				 */
				"OpenConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message SelectedSideBarItemChanged
				 * ######## ######### ######## ####### # #### ####### ##### ######.
				 * @param {String} ######### #######.
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
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				OBSWMixin: "Terrasoft.OBSWMixin",
				OBSWConsultationPanelMixin: "Terrasoft.OBSWConsultationPanelMixin",
				CustomEvent: "Terrasoft.mixins.CustomEventDomMixin",
			},
			attributes: {

				/**
				 * ##### ########### ####### ####.
				 * @protected
				 * @type {String}
				 */
				"Mode": {
					dataValueType: this.Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ############# #########.
				 * @protected
				 * @type {Guid}
				 */
				"CaseId": {
					"dataValueType": Terrasoft.DataValueType.GUID
				},

				/**
				 * ####### #######, ## ######## ########### ############.
				 * @protected
				 * @type {Object}
				 */
				"Contact": {
					"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT
				},

				/**
				 * Case locker.
				 * @protected
				 * @type {Boolean}
				 */
				"CaseLock": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				}
			},
			methods: {

				/**
				 * Initialize custom event object.
				 * @private
				 */
				_initCustomEvent: function() {
					this.mixins.CustomEvent.destroy.call(this);
					this.mixins.CustomEvent.init.call(this);
				},

				/**
				 * @param eventData
				 * @private
				 */
				_sendCurrentConsultationChangedEvent: function(eventData) {
					this.mixins.CustomEvent.publish.call(this, 'CurrentConsultationChanged', eventData);
				},

				/**
				 * @private
				 * @return {Array} Consultation panel module tags.
				 */
				_getConsultationPanelModuleTags: function() {
					const consultationPanelModuleTags = [this.getConsultationPanelModuleId()];
					const tags = this.getSandboxTags(this.sandbox.id);
					Terrasoft.each(tags, function(tag) {
						const consultationPanelModuleId = tag + "_OBSWConsultationPanelSchemaModule";
						if(!consultationPanelModuleTags.includes(consultationPanelModuleId)) {
							consultationPanelModuleTags.push(consultationPanelModuleId);
						}
					}, this);
					return consultationPanelModuleTags;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.setDefaultMode();
					this._initCustomEvent();
					this.callParent([function() {
						this.subscribeSandboxEvents();
						this.initActiveConsultationData(function() {
							callback.call(scope || this);
						}, this);
					}, this]);
				},

				/**
				* @inheritdoc Terrasoft.BaseSchemaModule#destroy
				* @overridden
				*/
				destroy: function() {
					this.mixins.CustomEvent.destroy.call(this);
				},

				/**
				 * ############## ###### ######## ############.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				initActiveConsultationData: function(callback, scope) {
					this.getActiveConsultationData(function(result) {
						if (result && result.success) {
							var activeConsultationId = result.activeConsultationId;
							if (activeConsultationId && !this.Ext.isEmpty(activeConsultationId) &&
								activeConsultationId !== this.Terrasoft.GUID_EMPTY) {
								this.set("CaseId", activeConsultationId);
								var activeContact = result.activeContact;
								if (activeContact && this.Ext.isObject(activeContact) &&
									!this.Ext.isEmpty(activeContact.value) &&
									activeContact.value !== this.Terrasoft.GUID_EMPTY) {
									this.set("Contact", activeContact);
								}
								this.setConsultationdMode();
							}
						}
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}, this);
				},

				/**
				 * ############# ## #########, ########### ### ######.
				 * @protected
				 */
				subscribeSandboxEvents: function() {
					var sandbox = this.sandbox;
					sandbox.subscribe("GetCurrentConsultation", this.getCurrentConsultation, 
						this, this.getSandboxTags(sandbox.id));
					sandbox.subscribe("ContinueConsultation", function(config) {
						this.continueConsultation(config);
					}, this, this.getSandboxTags(sandbox.id));
					sandbox.subscribe("StartNewConsultation", function(config) {
						this.startNewConsultation(config);
					}, this, this.getSandboxTags(sandbox.id));
					sandbox.subscribe("PostponeConsultation", function(config) {
						this.postponeConsultation(config);
					}, this, this.getSandboxTags(sandbox.id));
					sandbox.subscribe("CompleteConsultation", function(config) {
						this.completeConsultation(config);
					}, this, this.getSandboxTags(sandbox.id));
					sandbox.subscribe("GetConsultaionStartedOn", function(config) {
						this._sendCurrentConsultationChangedEvent(config);
					}, this, this.getSandboxTags(sandbox.id));
				},

				/**
				 * ########## ############# ###### ########## ############.
				 * @protected
				 * @return {String} ############# ###### ########## ############.
				 */
				getPendingConsultationPanelModuleId: function() {
					return (this.sandbox.id + "_OBSWPendingConsultationPanelSchemaModule");
				},

				/**
				 * ########## ############# ###### ############.
				 * @protected
				 * @return {String} ############# ###### ############.
				 */
				getConsultationPanelModuleId: function() {
					return (this.sandbox.id + "_OBSWConsultationPanelSchemaModule");
				},

				/**
				 * ######## ##### ###########.
				 * @protected
				 * @param {String} mode ##### #####.
				 */
				changeMode: function(mode) {
					if (mode === this.get("Mode")) {
						return;
					}
					this.set("Mode", mode);
				},

				/**
				 * ############# ##### ###### ########.
				 * @protected
				 */
				setSearchMode: function() {
					this.changeMode(OBSWConstants.OBSWViewMode.Search);
				},

				/**
				 * ############# ##### ############.
				 * @protected
				 */
				setConsultationdMode: function() {
					this.changeMode(OBSWConstants.OBSWViewMode.Consultation);
				},

				/**
				 * ############# ##### ## #########.
				 * @protected
				 */
				setDefaultMode: function() {
					this.setSearchMode();
				},

				/**
				 * ########## ###### ###### ########.
				 * @protected
				 * @return {Boolean} ######## ######### ###### ###### ########.
				 */
				isSearchPanelVisible: function() {
					return (this.get("Mode") === OBSWConstants.OBSWViewMode.Search);
				},

				/**
				 * ########## ######## ######### ###### ############.
				 * @protected
				 * @return {Boolean} ######## ######### ###### ############.
				 */
				isConsultationPanelVisible: function() {
					return (this.get("Mode") === OBSWConstants.OBSWViewMode.Consultation);
				},

				/**
				 * Opens consultation on previously established case.
				 * @protected
				 * @param {Object} config Case configuration.
				 * @param {Object} config.contact Case contact.
				 * @param {Guid} config.caseId Case identifier.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback context.
				 */
				continueConsultation: function(config, callback, scope) {
					if (this.get("CaseLock")) {
						return;
					}
					this.set("CaseLock", true);
					this.showBodyMask();
					this.postponeConsultation({
						caseId: this.get("CaseId"),
						isSilent: true
					}, function() {
						this.set("Contact", config.contact);
						this.openConsultation(config.caseId, function() {
							this.loadPendingConsultations();
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this);
							}
							this.set("CaseLock", false);
						}, this);
					}, this);
				},

				/**
				 * Creates new case, and opens it for consultation.
				 * @protected
				 * @param {Object} config New case configuration.
				 * @param {Object} config.contact Case contact.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback context.
				 */
				startNewConsultation: function(config, callback, scope) {
					if (this.get("CaseLock")) {
						return;
					}
					this.set("CaseLock", true);
					this.showBodyMask();
					var newCaseConfig = this.getInsertQueryConfig(config);
					this.createNewCase(newCaseConfig, function(result) {
						this.hideBodyMask();
						if (result && result.success) {
							this.set("Contact", config.contact);
							this.openConsultation(result.id, callback, scope);
						} else {
							if (result && result.errorInfo) {
								this.showInformationDialog(result.errorInfo.message);
							}
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this);
							}
						}
						this.set("CaseLock", false);
					});
				},

				/**
				 * ########## ############ ### ######## #########.
				 * @protected
				 * @param {Object} config ############ ######## ###### #########.
				 * @param {Object} config.contact ####### #########.
				 * @return {Object} ############ ### ######## #########.
				 */
				getInsertQueryConfig: function(config) {
					return {
						parameterValues: [{
							columnPath: "Contact",
							value: config.contact.value,
							type: Terrasoft.DataValueType.GUID
						}, {
							columnPath: "Owner",
							value: this.Terrasoft.SysValue.CURRENT_USER_CONTACT.value,
							type: Terrasoft.DataValueType.GUID
						}, {
							columnPath: "Status",
							value: OBSWConstants.Case.Status.InWork,
							type: Terrasoft.DataValueType.GUID
						}, {
							columnPath: "Subject",
							value: this.getConsultationSubject(config.contact.displayValue),
							type: Terrasoft.DataValueType.TEXT
						}, {
							columnPath: "PostponedOn",
							value: new Date(this.Ext.Date.now()),
							type: Terrasoft.DataValueType.DATE_TIME
						}]
					};
				},

				/**
				 * ########## ############.
				 * @protected
				 * @param {Object} config ############ #########.
				 * @param {Guid} config.caseId ############# #########.
				 * @param {Boolean} config.isSilent ####### ########## ### #########.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				postponeConsultation: function(config, callback, scope) {
					if (!config || !config.caseId) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
						return;
					}
					this.showBodyMask();
					var updateConfig = this.getUpdateQueryPostponedConfig(config);
					this.updateCase(updateConfig, function(result) {
						this.updateCaseCallback(result, config, callback, scope);
					}, this);
				},

				/**
				 * ########## ############ ### ########## ######### # ######### "#######".
				 * @protected
				 * @param {Object} config ############ #########.
				 * @param {Guid} config.caseId ############# #########.
				 * @return {Object} ############ ### ########## #########.
				 */
				getUpdateQueryPostponedConfig: function(config) {
					var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
					filterGroup.add("activeFilter", this.createActiveFilter());
					return {
						caseId: config.caseId,
						filterGroup: filterGroup,
						parameterValues: [{
							columnPath: "IsActive",
							value: false,
							type: Terrasoft.DataValueType.BOOLEAN
						}, {
							columnPath: "Status",
							value: OBSWConstants.Case.Status.InWork,
							type: Terrasoft.DataValueType.GUID
						}, {
							columnPath: "PostponedOn",
							value: new Date(this.Ext.Date.now()),
							type: Terrasoft.DataValueType.DATE_TIME
						}]
					};
				},

				/**
				 * ######### ############.
				 * @protected
				 * @param {Object} config ############ ##########.
				 * @param {Guid} config.caseId ############# #########.
				 * @param {Boolean} config.isSilent ####### ########## ### #########.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				completeConsultation: function(config, callback, scope) {
					if (!config || !config.caseId) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
						return;
					}
					this.showBodyMask();
					var updateConfig = this.getUpdateQueryCompletedConfig(config);
					this.updateCase(updateConfig, function(result) {
						this.updateCaseCallback(result, config, callback, scope);
					}, this);
				},

				/**
				 * ############ ######### ########## ########## #########.
				 * @protected
				 * @param {Object} result ######### ########## #######.
				 * @param {Object} config ############ ##########.
				 * @param {Guid} config.caseId ############# #########.
				 * @param {Boolean} config.isSilent ####### ########## ### #########.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				updateCaseCallback: function(result, config, callback, scope) {
					this.set("CaseId", null);
					this.set("Contact", null);
					this.removeActiveConsultationData(config.caseId, function() {
						this.removeActiveConsultationDataCallback(result, config, callback, scope);
					}, this);
				},

				/**
				 * ############ ######### ########## ######## ######## ######## ############.
				 * @protected
				 * @param {Object} updateCaseResult ######### ########## ####### ########## #########.
				 * @param {Object} config ############ ##########.
				 * @param {Guid} config.caseId ############# #########.
				 * @param {Boolean} config.isSilent ####### ########## ### #########.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				removeActiveConsultationDataCallback: function(updateCaseResult, config, callback, scope) {
					this.hideBodyMask();
					if (updateCaseResult && updateCaseResult.success && !config.isSilent) {
						this.setSearchMode();
						this.loadPendingConsultations();
						this.openHomePage(callback, scope);
					} else {
						if (updateCaseResult && updateCaseResult.errorInfo) {
							this.showInformationDialog(updateCaseResult.errorInfo.message);
						}
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}
				},

				/**
				 * ########## ############ ### ########## ######### # ######### "########".
				 * @protected
				 * @param {Object} config ############ #########.
				 * @param {Guid} config.caseId ############# #########.
				 * @return {Object} ############ ### ########## #########.
				 */
				getUpdateQueryCompletedConfig: function(config) {
					var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
					filterGroup.add("activeFilter", this.createActiveFilter());
					return {
						caseId: config.caseId,
						filterGroup: filterGroup,
						parameterValues: [{
							columnPath: "IsActive",
							value: false,
							type: Terrasoft.DataValueType.BOOLEAN
						}, {
							columnPath: "Status",
							value: OBSWConstants.Case.Status.Closed,
							type: Terrasoft.DataValueType.GUID
						}, {
							columnPath: "PostponedOn",
							value: new Date(this.Ext.Date.now()),
							type: Terrasoft.DataValueType.DATE_TIME
						}]
					};
				},

				/**
				 * ####### ###### ######## ############.
				 * @protected
				 * @return {Terrasoft.CompareFilter} ###### ######## ############.
				 */
				createActiveFilter: function() {
					return this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"IsActive",
						true,
						this.Terrasoft.DataValueType.BOOLEAN);
				},

				/**
				 * ########## ############ ####### ############.
				 * @protected
				 * @return {config} ############ ####### ############.
				 */
				getCurrentConsultation: function() {
					return {
						caseId: this.get("CaseId"),
						contact: this.get("Contact")
					};
				},

				/**
				 * ####### ##### #########.
				 * @protected
				 * @param {Object} config ############ ###### #########.
				 * @param {Guid} config.contactId ############# ######## #########.
				 * @param {Guid} config.statusId ############# ####### #########.
				 * @param {Guid} config.ownerId ############# ############# #########.
				 * @param {String} config.subject #### #########.
				 * @param {Function} callback ####### ######### ######.
				 */
				createNewCase: function(config, callback, scope) {
					this.showBodyMask();
					this.insertQuery = null;
					var insertQuery = this.getInsertQuery();
					this.setQueryParameterValues(insertQuery, config.parameterValues);
					insertQuery.execute(function(result) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this, result);
						}
					}, this);
				},

				/**
				 * ######### #########.
				 * @protected
				 * @param {Object} config ############ ##########.
				 * @param {Guid} config.caseId (optional) ############# #########.
				 * @param {Array} config.parameterValues ###### ######## #######.
				 * @param {Terrasoft.FilterGroup} config.filterGroup (optional) ###### ############## ########.
				 * @param {Function} callback ####### ######### ######.
				 */
				updateCase: function(config, callback, scope) {
					this.showBodyMask();
					var filterGroup = config.filterGroup;
					var caseId = config.caseId;
					this.updateQuery = null;
					var updateQuery = this.getUpdateQuery();
					if (caseId) {
						updateQuery.enablePrimaryColumnFilter(caseId);
					}
					this.setQueryParameterValues(updateQuery, config.parameterValues);
					if (filterGroup) {
						updateQuery.filters.add("customFilter", filterGroup);
					}
					updateQuery.execute(function(result) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this, result);
						}
					}, this);
				},

				/**
				 * ############# ######## ####### ### #######.
				 * @protected
				 * @param {Terrasoft.BaseObject} query ######.
				 * @param {Object} parameterValues ######## #######.
				 */
				setQueryParameterValues: function(query, parameterValues) {
					this.Terrasoft.each(parameterValues, function(parameterValue) {
						query.setParameterValue(parameterValue.columnPath, parameterValue.value, parameterValue.type);
					}, this);
				},

				/**
				 * ########## ######## #### ############.
				 * @protected
				 * @param  {String} contactName ### ########.
				 * @return {String} ######## #### ############.
				 */
				getConsultationSubject: function(contactName) {
					var subject = this.get("Resources.Strings.ConsultationSubjectCaption");
					subject = this.Ext.String.format(subject, contactName);
					return subject;
				},

				/**
				 * ######### ######### # ############# ##### ############.
				 * @protected
				 * @param {Guid} caseId ############# #########.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				openConsultation: function(caseId, callback, scope) {
					this.showBodyMask();
					var contact = this.get("Contact");
					this.saveActiveConsultationData(caseId, contact, function() {
						this.set("CaseId", caseId);
						this.setConsultationdMode();
						var config = {
							caseId: caseId
						};
						this.sandbox.publish("OpenConsultation",
							config, this._getConsultationPanelModuleTags());
						if (this.Ext.isObject(contact)) {
							this.openContactPageInChain(contact.value);
						}
						this.hideBodyMask();
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}, this);
				},

				/**
				 * ######## ######### ### ######## ########## ############.
				 * @protected
				 */
				loadPendingConsultations: function() {
					var config = {
						owner: this.Terrasoft.SysValue.CURRENT_USER_CONTACT,
						excludeCaseId: this.get("CaseId")
					};
					this.sandbox.publish("LoadPendingConsultations",
						config, this.getSandboxTags(this.getPendingConsultationPanelModuleId()));
				},

				/**
				 * ######### ######## ############## ######## ### ####### ## ###### # #######.
				 * @protected
				 * @param {Guid} contactId ############# ########.
				 */
				openContactPageInChain: function(contactId) {
					var historyState = this.sandbox.publish("GetHistoryState") || {};
					var config = {
						sandbox: this.sandbox,
						entityId: contactId,
						entitySchemaName: "Contact"
					};
					var hash = historyState.hash || {};
					var hashHistoryState = hash.historyState || "";
					if (contactId === hash.recordId || hashHistoryState.indexOf(contactId) > -1) {
						return;
					}
					NetworkUtilities.openEntityPage(config);
				},

				/**
				 * ######### ######## ########, #### ####### ###, ## ####### ####.
				 * @protected
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				openHomePage: function(callback, scope) {
					var historyState = this.sandbox.publish("GetHistoryState") || {};
					var processModuleName = "ProcessCardModuleV2";
					if (historyState.hash && historyState.hash.moduleName === processModuleName) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
						return;
					}
					var moduleStructure = this.getModuleStructure("OperatorSingleWindow");
					if (moduleStructure && moduleStructure.hide === "false") {
						this.openSectionPage(moduleStructure.sectionModule, callback, scope);
					} else {
						this.openIntroPage(callback, scope);
					}
				},

				/**
				 * ######### ######## #######.
				 * @protected
				 * @param {String} sectionModule ### ###### ######## #######.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				openSectionPage: function(sectionModule, callback, scope) {
					this.sandbox.publish("SelectedSideBarItemChanged", sectionModule + "/", ["sectionMenuModule"]);
					this.sandbox.publish("PushHistoryState", {
						hash: sectionModule
					});
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this);
					}
				},

				/**
				 * ######### ####### ####.
				 * @protected
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
				 */
				openIntroPage: function(callback, scope) {
					if (Terrasoft.isAngularHost) {
						this.Ext.callback(callback, scope);
						return;
					}
					var defaultIntroPageName = Terrasoft.configuration.defaultIntroPageName;
					var defaultHomeModule = ConfigurationConstants.DefaultHomeModule;
					var hash = this.Terrasoft.combinePath(defaultHomeModule, defaultIntroPageName);
					this.sandbox.publish("PushHistoryState", {
						hash: hash
					});
					this.Ext.callback(callback, scope);
				}
			},
			diff: [{
					"operation": "insert",
					"name": "OBSWContentPanel",
					"values": {
						"id": "OBSWContentPanel",
						"wrapClass": ["OBSW-content-panel"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},

				//region search panel

				{
					"operation": "insert",
					"name": "SearchPanel",
					"parentName": "OBSWContentPanel",
					"propertyName": "items",
					"values": {
						"id": "SearchPanel",
						"markerValue": "SearchPanel",
						"wrapClass": ["search-panel"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"visible": {
							"bindTo": "isSearchPanelVisible"
						},
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "HeaderContainer",
					"parentName": "SearchPanel",
					"propertyName": "items",
					"values": {
						"wrapClass": ["base-container"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "HeaderLabel",
					"parentName": "HeaderContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"classes": {
							"labelClass": ["header-label"]
						},
						"caption": {
							"bindTo": "Resources.Strings.HeaderLabel"
						}
					}
				}, {
					"operation": "insert",
					"name": "OBSWSearchPanelSchemaModuleContainer",
					"parentName": "SearchPanel",
					"propertyName": "items",
					"values": {
						"moduleId": "ViewModule_RightSideBarModule_OBSWModule_OBSWSearchPanelSchemaModule",
						"itemType": Terrasoft.ViewItemType.MODULE,
						"moduleName": "BaseSchemaModuleV2",
						"generateId": true,
						"makeUniqueId": true,
						"instanceConfig": {
							"isSchemaConfigInitialized": true,
							"schemaName": "OBSWSearchPanelSchema",
							"useHistoryState": false
						}
					}
				},

				//endregion

				//region consultation panel

				{
					"operation": "insert",
					"name": "ConsultationPanel",
					"parentName": "OBSWContentPanel",
					"propertyName": "items",
					"values": {
						"id": "ConsultationPanel",
						"markerValue": "ConsultationPanel",
						"wrapClass": ["consultation-panel"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"visible": {
							"bindTo": "isConsultationPanelVisible"
						},
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "OBSWConsultationPanelSchemaModuleContainer",
					"parentName": "ConsultationPanel",
					"propertyName": "items",
					"values": {
						"moduleId": "ViewModule_RightSideBarModule_OBSWModule_OBSWConsultationPanelSchemaModule",
						"itemType": Terrasoft.ViewItemType.MODULE,
						"moduleName": "BaseSchemaModuleV2",
						"generateId": true,
						"makeUniqueId": true,
						"instanceConfig": {
							"isSchemaConfigInitialized": true,
							"schemaName": "OBSWConsultationPanelSchema",
							"useHistoryState": false
						}
					}
				},

				//endregion

				//region pending consultation panel

				{
					"operation": "insert",
					"name": "PendingConsultationPanel",
					"parentName": "OBSWContentPanel",
					"propertyName": "items",
					"values": {
						"id": "PendingConsultationPanel",
						"markerValue": "PendingConsultationPanel",
						"wrapClass": ["pending-consultation-panel"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"visible": true
					}
				}, {
					"operation": "insert",
					"name": "PendingConsultationHeaderContainer",
					"parentName": "PendingConsultationPanel",
					"propertyName": "items",
					"values": {
						"wrapClass": ["base-container"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "PendingConsultationHeaderLabel",
					"parentName": "PendingConsultationHeaderContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"classes": {
							"labelClass": ["header-label"]
						},
						"caption": {
							"bindTo": "Resources.Strings.PendingConsultationGroupCaption"
						}
					}
				}, {
					"operation": "insert",
					"name": "PendingConsultationHeaderColorContainer",
					"parentName": "PendingConsultationHeaderContainer",
					"propertyName": "items",
					"values": {
						"wrapClass": ["header-color-container"],
						"markerValue": "PendingConsultationHeaderColorContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "OBSWPendingConsultationPanelModuleContainer",
					"parentName": "PendingConsultationPanel",
					"propertyName": "items",
					"values": {
						"moduleId": "ViewModule_RightSideBarModule_OBSWModule_OBSWPendingConsultationPanelSchemaModule",
						"itemType": Terrasoft.ViewItemType.MODULE,
						"moduleName": "BaseSchemaModuleV2",
						"generateId": true,
						"makeUniqueId": true,
						"instanceConfig": {
							"isSchemaConfigInitialized": true,
							"schemaName": "OBSWPendingConsultationPanelSchema",
							"useHistoryState": false
						}
					}
				}
				//endregion

			]
		};
	});
