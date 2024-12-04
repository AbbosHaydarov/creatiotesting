define("OBSWSearchPanelSchema", ["OBSWSearchPanelSchemaResources", "Contact", "GridUtilitiesV2",
		"ContextCallUtilities", "ConfigurationVerticalGridGenerator"
	],
	function(resources) {
		return {
			entitySchemaName: "Contact",
			mixins: {
				GridUtilities: "Terrasoft.GridUtilities",
				ContextCallUtilities: "Terrasoft.ContextCallUtilities"
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
				 * @message StartNewConsultation
				 * ######### #### ####### ###### ##### ############ ## ########## ########.
				 * @param {Object} config ################ ######.
				 */
				"StartNewConsultation": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message CallCustomer
				 * ########## # ############# ###### #######.
				 * @param {Object} ########## # ########## ######.
				 */
				"CallCustomer": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {

				/**
				 * ######### #####.
				 * @type {Terrasoft.Collection}
				 */
				"TabsCollection": {
					dataValueType: Terrasoft.DataValueType.COLLECTION
				},

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
				 * ###### ### ######## #######.
				 * @type {String}
				 */
				"ActiveTabName": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ### ########## #####.
				 * @type {Boolean}
				 */
				"ItWasSearched": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				},

				/**
				 * ###### ### ########.
				 * @type {String}
				 */
				"FullName": {
					"name": "FullName",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ##### ########.
				 * @type {String}
				 */
				"Passport": {
					"name": "Passport",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ############# ###. ####.
				 * @type {String}
				 */
				"INN": {
					"name": "INN",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ##### ########.
				 * @type {String}
				 */
				"PhoneNumber": {
					"name": "PhoneNumber",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ##### ########.
				 * @type {String}
				 */
				"ContractNumber": {
					"name": "ContractNumber",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ##### ########## #####.
				 * @type {String}
				 */
				"BankCardNumber": {
					"name": "BankCardNumber",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ##### ########### #####.
				 * @type {String}
				 */
				"BankAccountNumber": {
					"name": "BankAccountNumber",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ########### ########## ######## ### #### ###.
				 * @type {Number}
				 */
				"OBSWFullNameMinValueLength": {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": 2
				},

				/**
				 * ########### ########## ######## ### #### ##### ########.
				 * @type {Number}
				 */
				"OBSWPhoneNumberMinValueLength": {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": 3
				},

				/**
				 * Contact locker.
				 * @protected
				 * @type {Boolean}
				 */
				"ContactLock": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.Terrasoft.chain(
							this.initData,
							function(next) {
								this.initTabs();
								this.mixins.GridUtilities.init.call(this);
								next();
							},
							this.initSysSettings,
							function() {
								callback.call(scope || this);
							},
							this
						);
					}, this]);
				},

				/**
				 * ############## ######## ######### ########.
				 * @protected
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ###### ####### ######### ######.
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
				 * ########## ###### ##### ######### ########.
				 * @protected
				 * @return {Array} ###### ##### ######### ########.
				 */
				getSysSettingsArray: function() {
					return ["OBSWFullNameMinValueLength", "OBSWPhoneNumberMinValueLength"];
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
				 * ############## ######### ######## ###### ### Tabs.
				 * @protected
				 */
				initTabs: function() {
					var tabsCollection = this.get("TabsCollection");
					if (!this.get("ActiveTabName") && !tabsCollection.getCount()) {
						return;
					}
					var firstTab = tabsCollection.getByIndex(0);
					var defaultTabName = firstTab.get("Name");
					this.set("ActiveTabName", defaultTabName);
					this.set(defaultTabName, true);
				},

				/**
				 * ############ ####### ######### ####### Tabs.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} activeTab ######### #######.
				 */
				activeTabChange: function(activeTab) {
					var activeTabName = activeTab.get("Name");
					var tabsCollection = this.get("TabsCollection");
					tabsCollection.eachKey(function(tabName, tab) {
						var tabContainerVisibleBinding = tab.get("Name");
						this.set(tabContainerVisibleBinding, false);
					}, this);
					this.set(activeTabName, true);
				},

				/**
				 * ########## ##### ###### ###### ########.
				 * @protected
				 */
				onSearchButtonClick: function() {
					var validateResult = this.validateColumns();
					if (validateResult && validateResult.success) {
						this.set("ItWasSearched", true);
						this.set("ActiveRow", null);
						this.reloadGridData();
					} else if (validateResult && validateResult.errorInfo) {
						this.showInformationDialog(validateResult.errorInfo);
					}
				},

				/**
				 * ########## ##### ###### ######## ###### ########.
				 * @protected
				 */
				onNewContactButtonClick: function() {
					if (this.get("FullName")) {
						this.createNewContact(this.startNewConsultation);
					}
				},

				/**
				 * Validates the fields, depending on the search category.
				 * @protected
				 * @return {Object} Validate object.
				 */
				validateColumns: function() {
					var result = true;
					var validationMessage;
					var columnNames = this.getTabColumns(this.get("ActiveTabName"));
					this.clearColumnsValidationInfo(columnNames);
					if (columnNames.indexOf("PhoneNumber") > -1) {
						result = this.validatePhoneNumber();
						validationMessage = result ? validationMessage : this.get("Resources.Strings.PhoneNumberErrorMessage");
					}
					if (result) {
						result = this.validateTabColumns(columnNames);
						validationMessage = result ? null : this.getValidationMessage(columnNames);
					}
					return {
						success: result,
						errorInfo: validationMessage
					};
				},

				/**
				 * Validates phone number field.
				 * @protected
				 * @return {Boolean} Validate value.
				 */
				validatePhoneNumber: function() {
					var columnValue = this.get("PhoneNumber");
					columnValue = this.formatPhoneNumber(columnValue);
					return !this.Ext.isEmpty(columnValue);
				},

				/**
				 * ############# ########## ######### # ########## ## ## ###### ######### ### ############.
				 * @protected
				 * @return {String} ######### ### ############.
				 */
				getValidationMessage: function(columnNames) {
					var mainMessageTemplate = this.get("Resources.Strings.RequiredFieldValidationErrorMessage");
					var requiredColumnsMessage = "";
					var optionalRequiredColumnsMessage = "";
					var requiredColumnNames = this.getRequiredColumnNames();
					this.Terrasoft.each(columnNames, function(columnName) {
						var isRequired = requiredColumnNames.indexOf(columnName) > -1;
						var columnMessage = this.getValidationMessageByColumnName(columnName);
						if (isRequired) {
							requiredColumnsMessage = this.addMessagePart(requiredColumnsMessage, columnMessage);
						} else {
							optionalRequiredColumnsMessage = this.addMessagePart(optionalRequiredColumnsMessage, columnMessage);
						}
					}, this);
					var invalidMessage = this.Ext.String.format(mainMessageTemplate, requiredColumnsMessage);
					if (optionalRequiredColumnsMessage) {
						var optionalInvalidMessageTemplate = this.get("Resources.Strings.OptionalFieldValidationErrorMessage");
						var optionalInvalidMessage = this.Ext.String.format(optionalInvalidMessageTemplate,
							optionalRequiredColumnsMessage);
						invalidMessage += optionalInvalidMessage;
					}
					return invalidMessage;
				},

				/**
				 * ########## ############# ######### ### #######.
				 * @param {String} columnName ### ####.
				 * @return {String} ############# #########.
				 */
				getValidationMessageByColumnName: function(columnName) {
					var result = "";
					var columnCaption = this.get("Resources.Strings." + columnName + "PlaceHolder");
					var minValueLength = this.get("OBSW" + columnName + "MinValueLength");
					if (minValueLength > 0) {
						var minValueLengthErrorMessage = this.get("Resources.Strings.MinValueLengthErrorMessage");
						minValueLengthErrorMessage = this.Ext.String.format(minValueLengthErrorMessage, minValueLength);
						result = this.Ext.String.format("{0} ({1})", columnCaption, minValueLengthErrorMessage);
					} else {
						result = columnCaption;
					}
					return result;
				},

				/**
				 * ######### # ######### ######### ##### #####.
				 * @param {String} message ######## #########.
				 * @param {String} part ##### #########.
				 * @return {String} ######### # ########### ######.
				 */
				addMessagePart: function(message, part) {
					if (this.Ext.isEmpty(message)) {
						message += part;
					} else {
						message += ", " + part;
					}
					return message;
				},

				/**
				 * ####### ######### #####.
				 * @protected
				 * @param {Array} columnNames ###### #### #####.
				 */
				clearColumnsValidationInfo: function(columnNames) {
					this.Terrasoft.each(columnNames, function(columnName) {
						this.setValidationInfo(columnName, true, "");
					}, this);
				},

				/**
				 * ########## ###### ######## ##### ############ ### ##########.
				 * @protected
				 * @return {Array} ###### ######## #####.
				 */
				getRequiredColumnNames: function() {
					return ["FullName", "PhoneNumber"];
				},

				/**
				 * ########## #### ######### ######.
				 * @protected
				 * @param {Array} columnNames ###### #### #####.
				 * @return {Boolean} ######## #########.
				 */
				validateTabColumns: function(columnNames) {
					var requiredColumnsAreEmpty = false;
					var optionalColumnsAreEmpty = true;
					var hasOptionalColumns = false;
					var requiredColumnNames = this.getRequiredColumnNames();
					this.Terrasoft.each(columnNames, function(columnName) {
						var isRequired = requiredColumnNames.indexOf(columnName) > -1;
						var isValid = this.validateTabColumn(columnName);
						if (!isRequired && !hasOptionalColumns) {
							hasOptionalColumns = true;
						}
						if ((!isValid && isRequired)) {
							requiredColumnsAreEmpty = true;
							return false;
						} else if (isValid && !isRequired && optionalColumnsAreEmpty) {
							optionalColumnsAreEmpty = false;
						}
					}, this);
					optionalColumnsAreEmpty = optionalColumnsAreEmpty && hasOptionalColumns;
					return (!requiredColumnsAreEmpty && !optionalColumnsAreEmpty);
				},

				/**
				 * ########## #### ######### ######.
				 * @protected
				 * @param {String} columnName ### ####.
				 * @return {Boolean} ######## #########.
				 */
				validateTabColumn: function(columnName) {
					var columnValue = this.get(columnName);
					var isEmpty = this.Ext.isEmpty(columnValue);
					var minValueLength = this.get("OBSW" + columnName + "MinValueLength") || -1;
					return (!isEmpty && minValueLength <= columnValue.length);
				},

				/**
				 * ########## ###### ######## ##### # ########### ## ######### ######.
				 * @protected
				 * @param {String} tabName ### ####.
				 * @return {Array} ###### ######## #####.
				 */
				getTabColumns: function(tabName) {
					var columnNames = [];
					switch (tabName) {
						case "IDTab":
							columnNames = ["FullName", "Passport", "INN"];
							break;
						case "PhoneTab":
							columnNames = ["FullName", "PhoneNumber"];
							break;
						case "BankCardTab":
							columnNames = ["FullName", "ContractNumber", "BankCardNumber", "BankAccountNumber"];
							break;
					}
					return columnNames;
				},

				/**
				 * ########## ##### ###### #######.
				 * @protected
				 */
				onClearButtonClick: function() {
					this.set("IsGridLoading", false);
					this.set("IsGridEmpty", true);
					this.set("ItWasSearched", false);
					var gridData = this.getGridData();
					gridData.clear();
					this.set("FullName", "");
					this.set("Passport", "");
					this.set("INN", "");
					this.set("PhoneNumber", "");
					this.set("ContractNumber", "");
					this.set("BankCardNumber", "");
					this.set("BankAccountNumber", "");
				},

				/**
				 * ########## ############# ###### ####### ####.
				 * @protected
				 * @return {String} ############# ###### ####### ####.
				 */
				getOBSWModuleId: function() {
					return this.sandbox.id.replace("_OBSWSearchPanelSchemaModule", "");
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
				 * ########## ########### ####### ### ###### ########## ######, # ########### ## #########.
				 * @protected
				 * @return {Terrasoft.FilterGroup} ########### ####### ### ###### ########## ######.
				 */
				getFilters: function() {
					var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
					var activeTabName = this.get("ActiveTabName");
					switch (activeTabName) {
						case "IDTab":
							this.getIDFilters(filterGroup);
							break;
						case "PhoneTab":
							this.getPhoneFilters(filterGroup);
							break;
						case "BankCardTab":
							this.getBankCardFilters(filterGroup);
							break;
					}
					return filterGroup;
				},

				/**
				 * ########## ########### ####### ### ###### ########## ######, ### ######### ID.
				 * @protected
				 * @param {Terrasoft.FilterGroup} filterGroup ###### ########.
				 * @return {Terrasoft.FilterGroup} ########### #######.
				 */
				getIDFilters: function(filterGroup) {
					this.addColumnFilter(filterGroup, "FullName", "Name", this.Terrasoft.ComparisonType.CONTAIN);
					this.addColumnFilter(filterGroup, "Passport");
					this.addColumnFilter(filterGroup, "INN");
				},

				/**
				 * ########## ########### ####### ### ###### ########## ######, ### ######### Phone.
				 * @protected
				 * @param {Terrasoft.FilterGroup} filterGroup ###### ########.
				 * @return {Terrasoft.FilterGroup} ########### #######.
				 */
				getPhoneFilters: function(filterGroup) {
					this.addColumnFilter(filterGroup, "FullName", "Name", this.Terrasoft.ComparisonType.CONTAIN);
					this.addColumnFilter(filterGroup, "PhoneNumber",
						"[ContactCommunication:Contact:Id].SearchNumber", this.Terrasoft.ComparisonType.START_WITH);
				},

				/**
				 * ########## ########### ####### ### ###### ########## ######, ### ######### BankCard.
				 * @protected
				 * @param {Terrasoft.FilterGroup} filterGroup ###### ########.
				 * @return {Terrasoft.FilterGroup} ########### #######.
				 */
				getBankCardFilters: function(filterGroup) {
					this.addColumnFilter(filterGroup, "FullName", "Name", this.Terrasoft.ComparisonType.CONTAIN);
					this.addColumnFilter(filterGroup, "ContractNumber", "[Contract:ContactContract:Id].Number");
					this.addColumnFilter(filterGroup, "BankCardNumber", "[BankCard:Holder:Id].Number");
					this.addColumnFilter(filterGroup, "BankAccountNumber", "[BankAccount:Contact:Id].BankAccountNumber");
				},

				/**
				 * ######### ###### ### #######.
				 * @protected
				 * @param {Terrasoft.FilterGroup} filterGroup ###### ########.
				 * @param {String} attributeName ### #########.
				 * @param {String} columnPath (optional) #### # ########### ####### ############ ######## ##### rootSchema.
				 * @param {Terrasoft.ComparisonType} comparisonType (optional) ### ######## #########.
				 */
				addColumnFilter: function(filterGroup, attributeName, columnPath, comparisonType) {
					var attributeValue = this.get(attributeName);
					if (!this.Ext.isEmpty(attributeValue)) {
						if (attributeName === "PhoneNumber") {
							attributeValue = this.formatPhoneNumber(attributeValue);
						}
						columnPath = columnPath || attributeName;
						comparisonType = comparisonType || this.Terrasoft.ComparisonType.EQUAL;
						filterGroup.add(filterGroup.getCount() + "Filter", this.Terrasoft.createColumnFilterWithParameter(
							comparisonType,
							columnPath,
							attributeValue));
					}
				},

				/**
				 * ######### Exists ###### ### #######.
				 * @protected
				 * @param {Terrasoft.FilterGroup} filterGroup ###### ########.
				 * @param {String} attributeName ### #########.
				 * @param {String} columnPath (optional) #### # ########### ####### ############ ######## ##### rootSchema.
				 * @param {Terrasoft.ComparisonType} comparisonType (optional) ### ######## #########.
				 */
				addColumnExistsFilter: function(filterGroup, attributeName, columnPath, comparisonType) {
					var attributeValue = this.get(attributeName);
					if (!this.Ext.isEmpty(attributeValue)) {
						if (attributeName === "PhoneNumber") {
							attributeValue = this.formatPhoneNumber(attributeValue);
						}
						columnPath = columnPath || attributeName;
						comparisonType = comparisonType || this.Terrasoft.ComparisonType.EQUAL;
						var subFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
						var filter = this.Terrasoft.createColumnFilterWithParameter(
							comparisonType,
							columnPath,
							attributeValue);
						subFilterGroup.addItem(filter);
						var existsFilter = this.Terrasoft.createExistsFilter("Id", subFilterGroup);
						filterGroup.add(filterGroup.getCount() + "Filter", existsFilter);
					}
				},

				/**
				 * ####### ## ######## ####### # ###### ####### ######## ## ########.
				 * @protected
				 * @param {String} value ###### ### ##############.
				 * @return {String} ################# ######.
				 */
				formatPhoneNumber: function(value) {
					value = value || "";
					var clearedNumber = value.replace(/\D/g, "");
					var arrayNumber = clearedNumber.split("");
					var reversedNumber = arrayNumber.reverse();
					return reversedNumber.join("");
				},

				/**
				 * ########## #######, ####### ###### ########## ########.
				 * @protected
				 * @return {Object} ########## ###### ########-############ #######.
				 */
				getGridDataColumns: function() {
					var defColumnsConfig = this.mixins.GridUtilities.getGridDataColumns.call(this);
					var columnsConfig = {
						Name: {
							path: "Name",
							orderDirection: this.Terrasoft.core.enums.OrderDirection.ASC,
							orderPosition: 0
						},
						BirthDate: {
							path: "BirthDate"
						},
						Passport: {
							path: "Passport"
						},
						INN: {
							path: "INN"
						},
						MobilePhone: {
							path: "MobilePhone"
						},
						Phone: {
							path: "Phone"
						},
						HomePhone: {
							path: "HomePhone"
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
						case "start":
							this.startNewConsultation(primaryColumnValue, activeRow.get("Name"));
							break;
					}
				},

				/**
				 * ######### ###### # ###### # ############ ######### ######.
				 * @protected
				 */
				onLoadMoreButtonClick: function() {
					this.loadGridData();
				},

				/**
				 * ######## ######### ### ######## ##### ############.
				 * @protected
				 * @param {Guid} contactId ############# ########.
				 * @param {String} contactName ###### ### ########.
				 * @param {Boolean} isNew ####### ###### ########.
				 */
				startNewConsultation: function(contactId, contactName, isNew) {
					var config = {
						contact: {
							displayValue: contactName,
							value: contactId,
							isNew: isNew
						}
					};
					this.sandbox.publish("StartNewConsultation",
						config, [this.getOBSWModuleId()]);
				},

				/**
				 * ########## ######## ######### ###### "##### #######".
				 * @protected
				 * @return {Boolean} ######## ######### ###### "##### #######".
				 */
				isNewContactButtonVisible: function() {
					return (this.get("IsGridEmpty") && this.get("ItWasSearched") && !this.Ext.isEmpty(this.get("FullName")));
				},

				/**
				 * ########## ######## ######### ########## ########### ######.
				 * @protected
				 * @return {Boolean} ######## ######### ########## ########### ######.
				 */
				isSearchResultContainerVisible: function() {
					return this.get("ItWasSearched");
				},

				/**
				 * Creates new contact.
				 * @protected
				 * @param {Function} callback Callback function.
				 */
				createNewContact: function(callback) {
					if (this.get("ContactLock")) {
						return;
					}
					this.set("ContactLock", true);
					this.showBodyMask();
					this.insertQuery = null;
					var insertQuery = this.getInsertQuery();
					var contactName = this.get("FullName");
					insertQuery.setParameterValue("Name", contactName, Terrasoft.DataValueType.TEXT);
					insertQuery.execute(function(result) {
						this.hideBodyMask();
						if (result.success && this.Ext.isFunction(callback)) {
							callback.call(this, result.id, contactName, true);
						}
						this.set("ContactLock", false);
					}, this);
				},

				/**
				 * ############ ####### ## ###### # ####### ########## ######.
				 * @protected
				 * @param {String} rowId ############# ######.
				 * @param {String} columnName ### #######.
				 * @return {Boolean} ########## ####### ######## ## ######.
				 */
				onLinkClicked: function(rowId, columnName) {
					var nameColumnName = "Name";
					if (columnName === nameColumnName) {
						var gridData = this.getGridData();
						var activeRow = gridData.get(rowId);
						this.startNewConsultation(rowId, activeRow.get(nameColumnName));
						return false;
					}
					return !this.phoneLinkClicked(rowId, columnName);
				},

				/**
				 * ########## #### #######.
				 * @protected
				 * @return {String} ####.
				 */
				getProfileKey: function() {
					return this.name + "GridSettings";
				},

				/**
				 * ####### ######## ######, ########### ##### ###### ########## ######.
				 * @protected
				 * @param {Object} response ##### ## #######.
				 */
				onGridDataLoaded: function(response) {
					this.mixins.GridUtilities.onGridDataLoaded.call(this, response);
					var gridData = this.getGridData();
					var oldActiveRow = this.get("ActiveRow");
					if (this.Ext.isEmpty(oldActiveRow) && gridData.getCount()) {
						var newActiveRow = gridData.getByIndex(0);
						this.set("ActiveRow", newActiveRow.get(newActiveRow.primaryColumnName));
					}
				}
			},
			diff: [{
				"operation": "insert",
				"name": "TabsContainer",
				"parentName": "SearchPanel",
				"propertyName": "items",
				"values": {
					"wrapClass": ["base-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "Tabs",
				"parentName": "TabsContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.TAB_PANEL,
					"collection": {
						"bindTo": "TabsCollection"
					},
					"activeTabName": {
						"bindTo": "ActiveTabName"
					},
					"activeTabChange": {
						"bindTo": "activeTabChange"
					},
					"isScrollVisible": false,
					"tabs": []
				}
			}, {
				"operation": "insert",
				"name": "IDTab",
				"values": {
					"wrapClass": ["base-tab"],
					"caption": {
						"bindTo": "Resources.Strings.IDTabCaption"
					},
					"items": []
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0
			}, {
				"operation": "insert",
				"name": "PhoneTab",
				"values": {
					"wrapClass": ["base-tab"],
					"caption": {
						"bindTo": "Resources.Strings.PhoneTabCaption"
					},
					"items": []
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1
			}, {
				"operation": "insert",
				"name": "BankCardTab",
				"values": {
					"wrapClass": ["base-tab"],
					"caption": {
						"bindTo": "Resources.Strings.BankCardTabCaption"
					},
					"items": []
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2
			}, {
				"operation": "insert",
				"name": "FullName_IDTab",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "FullName",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.FullNamePlaceHolder"
						}
					}
				},
				"parentName": "IDTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Passport",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "Passport",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.PassportPlaceHolder"
						}
					}
				},
				"parentName": "IDTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "INN",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "INN",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.INNPlaceHolder"
						}
					}
				},
				"parentName": "IDTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "FullName_PhoneTab",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "FullName",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.FullNamePlaceHolder"
						}
					}
				},
				"parentName": "PhoneTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "PhoneNumber",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "PhoneNumber",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.PhoneNumberPlaceHolder"
						}
					}
				},
				"parentName": "PhoneTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "FullName_BankCardTab",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "FullName",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.FullNamePlaceHolder"
						}
					}
				},
				"parentName": "BankCardTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "ContractNumber",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "ContractNumber",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.ContractNumberPlaceHolder"
						}
					}
				},
				"parentName": "BankCardTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "BankCardNumber",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "BankCardNumber",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.BankCardNumberPlaceHolder"
						}
					}
				},
				"parentName": "BankCardTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "BankAccountNumber",
				"values": {
					"contentType": Terrasoft.ContentType.SHORT_TEXT,
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"labelConfig": {
						"visible": false
					},
					"bindTo": "BankAccountNumber",
					"enterkeypressed": {
						"bindTo": "onSearchButtonClick"
					},
					"controlConfig": {
						"classes": ["placeholderOpacity"],
						"placeholder": {
							"bindTo": "Resources.Strings.BankAccountNumberPlaceHolder"
						}
					}
				},
				"parentName": "BankCardTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "SearchButtonContainer",
				"parentName": "SearchPanel",
				"propertyName": "items",
				"values": {
					"wrapClass": ["search-button-container"],
					"markerValue": "SearchButtonContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "SearchButtonContainer",
				"propertyName": "items",
				"name": "SearchButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.SearchButtonCaption"
					},
					"classes": {
						"textClass": "search-actions-button"
					},
					"click": {
						"bindTo": "onSearchButtonClick"
					},
					"style": Terrasoft.controls.ButtonEnums.style.GREEN,
					"tag": "search",
					"markerValue": "SearchButton"
				}
			}, {
				"operation": "insert",
				"parentName": "SearchButtonContainer",
				"propertyName": "items",
				"name": "NewContactButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.NewClientButtonCaption"
					},
					"classes": {
						"textClass": "search-actions-button"
					},
					"click": {
						"bindTo": "onNewContactButtonClick"
					},
					"visible": {
						"bindTo": "isNewContactButtonVisible"
					},
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"tag": "newContact",
					"markerValue": "NewContactButton"
				}
			}, {
				"operation": "insert",
				"parentName": "SearchButtonContainer",
				"propertyName": "items",
				"name": "ClearButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.ClearButtonCaption"
					},
					"classes": {
						"textClass": "search-actions-button"
					},
					"click": {
						"bindTo": "onClearButtonClick"
					},
					"style": Terrasoft.controls.ButtonEnums.style.DEFAULT,
					"tag": "clear",
					"markerValue": "ClearButton"
				}
			}, {
				"operation": "insert",
				"name": "SearchResultContainer",
				"parentName": "SearchPanel",
				"propertyName": "items",
				"values": {
					"wrapClass": ["search-result-container"],
					"markerValue": "SearchResultContainer",
					"visible": {
						"bindTo": "isSearchResultContainerVisible"
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "SearchResultHeaderContainer",
				"parentName": "SearchResultContainer",
				"propertyName": "items",
				"values": {
					"wrapClass": ["search-result-header-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "SearchResultHeaderLabel",
				"parentName": "SearchResultHeaderContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"classes": {
						"labelClass": ["search-result-header-label"]
					},
					"caption": {
						"bindTo": "Resources.Strings.SearchResultHeaderLabel"
					}
				}
			}, {
				"operation": "insert",
				"name": "DataGrid",
				"parentName": "SearchResultContainer",
				"propertyName": "items",
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
							"name": "NameListedGridColumn",
							"bindTo": "Name",
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
							"rows": 7
						},
						"items": [{
							"name": "NameTiledGridColumn",
							"bindTo": "Name",
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
							"name": "BirthDateTiledGridColumn",
							"bindTo": "BirthDate",
							"type": Terrasoft.GridCellType.TEXT,
							"position": {
								"row": 2,
								"column": 1,
								"colSpan": 24
							}
						}, {
							"name": "PassportTiledGridColumn",
							"bindTo": "Passport",
							"type": Terrasoft.GridCellType.TEXT,
							"position": {
								"row": 3,
								"column": 1,
								"colSpan": 24
							}
						}, {
							"name": "INNTiledGridColumn",
							"bindTo": "INN",
							"type": Terrasoft.GridCellType.TEXT,
							"position": {
								"row": 4,
								"column": 1,
								"colSpan": 24
							}
						}, {
							"name": "MobilePhoneTiledGridColumn",
							"bindTo": "MobilePhone",
							"type": Terrasoft.GridCellType.TEXT,
							"caption": resources.localizableStrings.MobileGridColumnCaption,
							"position": {
								"row": 5,
								"column": 1,
								"colSpan": 24
							}
						}, {
							"name": "PhoneTiledGridColumn",
							"bindTo": "Phone",
							"type": Terrasoft.GridCellType.TEXT,
							"caption": resources.localizableStrings.PhoneGridColumnCaption,
							"position": {
								"row": 6,
								"column": 1,
								"colSpan": 24
							}
						}, {
							"name": "HomePhoneTiledGridColumn",
							"bindTo": "HomePhone",
							"type": Terrasoft.GridCellType.TEXT,
							"caption": resources.localizableStrings.HomePhoneGridColumnCaption,
							"position": {
								"row": 7,
								"column": 1,
								"colSpan": 24
							}
						}]
					}
				}
			}, {
				"operation": "insert",
				"parentName": "SearchResultContainer",
				"propertyName": "items",
				"name": "LoadMoreButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.LoadMoreButtonCaption"
					},
					"click": {
						"bindTo": "onLoadMoreButtonClick"
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
				"name": "DataGridActiveRowStartConsultationAction",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": resources.localizableStrings.StartConsultationGridRowButtonCaption,
					"tag": "start"
				}
			}]
		};
	});
