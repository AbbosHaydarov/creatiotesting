define("FinIndicatorPage", ["BaseFinanceUtilities", "BusinessRuleModule"],
	function(BaseFinanceUtilities, BusinessRuleModule) {
		return {
			entitySchemaName: "FinIndicator",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "GeneralInfoTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.GeneralInfoTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "GeneralInfoGroup",
					"values": {
						"itemType": 15,
						"caption": {
							"bindTo": "Resources.Strings.GeneralInfoGroupCaption"
						},
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "GeneralInfoGroup_gridLayout",
					"values": {
						"itemType": 0,
						"items": []
					},
					"parentName": "GeneralInfoGroup",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Type",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Type",
						"enabled": true,
						"tabIndex": 2
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Currency",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Currency",
						"textSize": "Default",
						"contentType": 3,
						"labelConfig": {
							"visible": true
						},
						"enabled": true,
						"tabIndex": 4
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Value",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Value",
						"enabled": true,
						"tabIndex": 3
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "ValueType",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ValueType",
						"textSize": 0,
						"contentType": 3,
						"labelConfig": {
							"visible": true
						},
						"enabled": true,
						"tabIndex": 5
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"name": "StartDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "StartDate",
						"enabled": true,
						"tabIndex": 7
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 7
				},
				{
					"operation": "insert",
					"name": "EndDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "EndDate",
						"enabled": true,
						"tabIndex": 8
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 8
				},
				{
					"operation": "insert",
					"name": "PeriodType",
					"values": {
						"contentType": Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "PeriodType",
						"enabled": true,
						"tabIndex": 9
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 6
				},
				{
					"operation": "insert",
					"name": "ConnectionsGroup",
					"values": {
						"itemType": 15,
						"caption": {
							"bindTo": "Resources.Strings.ConnectionsGroupCaption"
						},
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Period",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Period",
						"enabled": true,
						"tabIndex": 6
					},
					"parentName": "GeneralInfoGroup_gridLayout",
					"propertyName": "items",
					"index": 6
				},
				{
					"operation": "insert",
					"name": "ConnectionsGroup_gridLayout",
					"values": {
						"itemType": 0,
						"items": []
					},
					"parentName": "ConnectionsGroup",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Account",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Account",
						"textSize": 0,
						"contentType": 5,
						"labelConfig": {
							"visible": true
						},
						"enabled": true,
						"tabIndex": 10
					},
					"parentName": "ConnectionsGroup_gridLayout",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "AccountFolder",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "AccountFolder",
						"textSize": 0,
						"contentType": 5,
						"labelConfig": {
							"visible": true
						},
						"enabled": true,
						"tabIndex": 11
					},
					"parentName": "ConnectionsGroup_gridLayout",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "BankAccount",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "BankAccount",
						"textSize": 0,
						"contentType": 5,
						"labelConfig": {
							"visible": true
						},
						"enabled": true,
						"tabIndex": 12
					},
					"parentName": "ConnectionsGroup_gridLayout",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "remove",
					"name": "ESNTab"
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"AutofillPeriodAndType": {
					dependencies: [
						{
							columns: ["StartDate", "EndDate"],
							methodName: "autofillPeriodAndType"
						}
					]
				},
				"PeriodType": {
					lookupListConfig: {
						orders: [{
							columnPath: "Position",
							direction: Terrasoft.OrderDirection.ASC
						}]
					}
				},
				"Period": {
					lookupListConfig: {
						columns: ["Name", "StartDate", "DueDate", "PeriodType"],
						orders: [{
							columnPath: "StartDate",
							direction: Terrasoft.OrderDirection.ASC
						}]
					}
				},
				"PeriodChange": {
					dependencies: [
						{
							columns: ["Period"],
							methodName: "onPeriodChange"
						}
					]
				},
				"TypeChange": {
					dependencies: [
						{
							columns: ["Type"],
							methodName: "onTypeChange"
						}
					]
				}
			},
			methods: {

				/**
				 * ############# ######## ############## ########### ####### ### ######## "###. ##########"
				 * @override
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1080);
					this.callParent(arguments);
				},

				/**
				 * ##### ######### ####### ####### # ########### # ######### ####
				 * @protected
				 */
				autofillPeriodAndType: function() {
					if (this.get("IsPeriodChanged")) {
						return;
					}
					if (this.get("StartDate") && this.get("EndDate")) {
						BaseFinanceUtilities.checkPeriodExist(this.get("StartDate"),
							this.get("EndDate"), false, function(result) {
								if (result.id) {
									if (!(this.get("Period") && this.get("Period").value === result.id)) {
										this.loadLookupDisplayValue("Period", result.id);
									}
								} else {
									this.set("Period", null);
									this.loadLookupDisplayValue("PeriodType",
										BaseFinanceUtilities.getPeriodType(this.get("StartDate"), this.get("EndDate")));
								}
							}, this);
					}
				},

				/**
				 * ########## ######### #### ######
				 * @protected
				 */
				onPeriodChange: function() {
					var period = this.get("Period");
					if (!period) {
						return;
					}
					this.set("IsPeriodChanged", true);
					if (!this.get("EndDate") ||
						Ext.Date.clearTime(this.get("EndDate")) !== Ext.Date.clearTime(period.DueDate)) {
						this.set("EndDate", period.DueDate);
					}
					if (!this.get("StartDate") ||
						Ext.Date.clearTime(this.get("StartDate")) !== Ext.Date.clearTime(period.StartDate)) {
						this.set("StartDate", period.StartDate);
					}
					if (this.get("PeriodType") !== period.PeriodType) {
						this.loadLookupDisplayValue("PeriodType", period.PeriodType.value);
					}
					this.set("IsPeriodChanged", false);
					var endDateControl = this.Ext.get("FinIndicatorPageEndDateDateEdit-wrap");
					if (endDateControl) {
						endDateControl.removeCls("base-edit-focus");
					}
					var startDateControl = this.Ext.get("FinIndicatorPageStartDateDateEdit-wrap");
					if (startDateControl) {
						startDateControl.removeCls("base-edit-focus");
					}
				},

				/**
				 * ######## ### #### ########## ###### #### ######
				 * @protected
				 * @override
				 * @return {Boolean} #########
				 */
				validate: function() {
					var isValid = this.callParent(arguments);
					if (!isValid) {
						return false;
					}
					if (this.get("StartDate") && this.get("EndDate") &&
							Ext.Date.clearTime(this.get("StartDate")) > Ext.Date.clearTime(this.get("EndDate"))) {
						this.showInformationDialog(this.get("Resources.Strings.NotValidEndDateMessage"));
						return false;
					}
					return true;
				},

				/**
				 * Checks that the period is filled. If not, tries to fill period by selected start date and end date.
				 * If period with this bounds is not found, offers to create new period.
				 * @protected
				 * @param {Function} callback The callback function.
				 * @param {Object} scope Scope for the callback function.
				 */
				validatePeriod: function(callback, scope) {
					if (this.get("Period")) {
						callback.call(scope, {success: true});
						return;
					}
					BaseFinanceUtilities.checkPeriodExist(this.get("StartDate"),
						this.get("EndDate"), false, function(result) {
							if (result.id) {
								this.loadLookupDisplayValueAsync("Period", result.id, function() {
									callback.call(scope, {success: true});
								});
							} else {
								var periodType = this.get("PeriodType").value;
								var periodName = BaseFinanceUtilities.getPeriodName(this.get("StartDate"),
									this.get("EndDate"), periodType);
								var buttonsConfig = {
									buttons: [Terrasoft.MessageBoxButtons.YES.returnCode,
										Terrasoft.MessageBoxButtons.NO.returnCode],
									defaultButton: 0
								};
								var message = Ext.String.format(this.get("Resources.Strings.AddLookupQuestion"),
									periodName);
								this.showInformationDialog(message, function(dialogResult) {
									if (dialogResult === Terrasoft.MessageBoxButtons.YES.returnCode) {
										this.insertPeriod(periodType, periodName, callback, scope);
									} else {
										this.Ext.callback(callback, scope, [{success: false}]);
									}
								}, buttonsConfig, this);
							}
						}, this);
				},

				/**
				 * Creates Terrasoft.InsertQuery instance for inserting new period with passed period type and name and
				 * selected start date and end date.
				 * @protected
				 * @param {Guid} periodTypeId Id of period type.
				 * @param {String} periodName String with start date and end date of selected period.
				 * @return {Terrasoft.InsertQuery} Terrasoft.InsertQuery instance with filled parameters.
				 */
				getInsertPeriodQuery: function(periodTypeId, periodName) {
					var insertQuery = Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: "Period"
					});
					insertQuery.setParameterValue("Name", periodName,
						Terrasoft.DataValueType.TEXT);
					insertQuery.setParameterValue("StartDate", this.get("StartDate"),
						Terrasoft.DataValueType.DATE);
					insertQuery.setParameterValue("DueDate", this.get("EndDate"),
						Terrasoft.DataValueType.DATE);
					insertQuery.setParameterValue("PeriodType", periodTypeId,
						Terrasoft.DataValueType.GUID);
					return insertQuery;
				},

				/**
				 * Inserts period with selected start date and end date.
				 * @protected
				 * @param {Guid} periodTypeId Id of period type.
				 * @param {String} periodName String with start date and end date of selected period.
				 * @param {Function} callback The callback function.
				 * @param {Object} scope Scope for the callback function.
				 */
				insertPeriod: function(periodTypeId, periodName, callback, scope) {
					var insertPeriodQuery = this.getInsertPeriodQuery(periodTypeId, periodName);
					insertPeriodQuery.execute(function(response) {
						if (response.success === true) {
							this.loadLookupDisplayValueAsync("Period", response.id, function() {
								this.Ext.callback(callback, scope, [{success: true}]);
							});
						} else if (response.errorInfo) {
							this.showInformationDialog(response.errorInfo.message);
							this.Ext.callback(callback, scope, [{success: false}]);
						}
					}, this);
				},

				/**
				 * ######### ####### ####### # #### ######
				 * @protected
				 * @override
				 * @param {Function} callback callback-#######
				 * @param {Terrasoft.BaseSchemaViewModel} scope ######## ########## callback-#######
				 */
				asyncValidate: function(callback, scope) {
					this.callParent([function(result) {
						if (!result.success) {
							callback.call(scope, result);
						} else {
							this.validatePeriod(callback, scope);
						}
					}, this]);
				},
				/**
				 * Deletes collection element by Tag property
				 * @param {Terrasoft.BaseViewModelCollection} collection The collection with element
				 * @param {String} tag Tag to find element
				 */
				removeByTag: function(collection, tag) {
					for (var i = 0; i < collection.getCount(); i++) {
						if (collection.getByIndex(i).values.Tag && collection.getByIndex(i).values.Tag === tag) {
							collection.removeByIndex(i);
							break;
						}
					}
				},

				/**
				 * ########## ######### ######## ####### # ###### ########### ############# ####### # ########
				 * @protected
				 * @override
				 * @return {Terrasoft.BaseViewModelCollection} ########## ######### ######## ####### # ######
				 * ########### ############# ####### # ########
				 */
				getActions: function() {
					var actionMenuItems = this.callParent(arguments);
					this.removeByTag(actionMenuItems, "subscribeUser");
					this.removeByTag(actionMenuItems, "unsubscribeUser");
					return actionMenuItems;
				},

				/**
				 * Handles type value change. Set type display value to name attribute.
				 */
				onTypeChange: function() {
					var type = this.get("Type");
					if (!type) {
						return;
					}
					this.set("Name", type.displayValue);
				}
			},
			rules: {
				"StartDate": {
					"EnabledStartDate": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "Period"
							},
							"comparisonType": Terrasoft.ComparisonType.IS_NULL
						}]
					}
				},
				"EndDate": {
					"EnabledEndDate": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "Period"
							},
							"comparisonType": Terrasoft.ComparisonType.IS_NULL
						}]
					}
				},
				"PeriodType": {
					"EnabledPeriodType": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "Period"
							},
							"comparisonType": Terrasoft.ComparisonType.IS_NULL
						}]
					}
				}
			}
		};
	});
