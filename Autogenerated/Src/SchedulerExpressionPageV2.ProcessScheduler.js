define("SchedulerExpressionPageV2", ["ProcessSchedulerConstants"],
	function(ProcessSchedulerConstants) {
		return {
			entitySchemaName: "SchedulerExpression",
			details: /**SCHEMA_DETAILS*/{
			}/**SCHEMA_DETAILS*/,
			attributes: {
				/**
				 * ####### ########### ##### ### ############ ######### ## #### ######.
				 */
				MonthWeeklyPeriod: {
					"dependencies": [{
						"columns": ["ExpressionType", "MonthPeriodTypeValue"],
						"methodName": "setMonthWeeklyPeriod"
					}],
					"dataValueType": Terrasoft.DataValueType.BOOLEAN
				},
				/**
				 * ####### ########### ##### ### ############ ######### ## #### ######.
				 */
				MonthDailyPeriod: {
					"dependencies": [{
						"columns": ["ExpressionType", "MonthPeriodTypeValue"],
						"methodName": "setMonthDailyPeriod"
					}],
					"dataValueType": Terrasoft.DataValueType.BOOLEAN
				},
				/**
				 * ### ######### ############.
				 */
				ExpressionType: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": ProcessSchedulerConstants.ExpressionType.MINUTE_PERIOD
				},
				/**
				 * ### ############ #########.
				 */
				MonthPeriodTypeValue: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": ProcessSchedulerConstants.MonthPeriod.MONTHLY_DAILY
				},
				/**
				 * ######### #### ######.
				 */
				MonthlyWeeklyMonthList: {
					"dataValueType": Terrasoft.DataValueType.COLLECTION
				},
				/**
				 * ######### ####### #### ######.
				 */
				MonthlyDayOfWeekList: {
					"dataValueType": Terrasoft.DataValueType.COLLECTION
				},
				/**
				 * #### ######.
				 */
				MonthlyWeeklyMonth: {
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * ####### ### ######.
				 */
				MonthlyDayOfWeek: {
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * #### "##### ######, #####".
				 */
				MinutelyMinutes: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"caption": {"bindTo": "Resources.Strings.MinutelyMinutesCaption"}
				},
				/**
				 * #### "##### ######, #####".
				 */
				HourlyHours: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * #### "######, ####".
				 */
				DailyHours: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * #### "########## #".
				 */
				DailyTime: {
					"dataValueType": Terrasoft.DataValueType.TIME,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * #### "########## #" ## ####### ## #### ######.
				 */
				WeeklyTime: {
					"dataValueType": Terrasoft.DataValueType.TIME,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * #### "####" ## ####### ## #### ######.
				 */
				MonthlyDay: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * #### "#####".
				 */
				MonthlyMonth: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * #### "########## #" ## ####### ## #### ######.
				 */
				MonthlyTime: {
					"dataValueType": Terrasoft.DataValueType.TIME,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * ############ ######## # ######## ####.
				 */
				MaxNumberControlValue: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": 9999
				},
				/**
				 * ########### ######## # ######## ####.
				 */
				MinNumberControlValue: {
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"value": 1
				}
			},
			methods: {

				/**
				 * ############# ####### ########### ##### ### ############ ######### ## #### ######.
				 * @private
				 */
				setMonthWeeklyPeriod: function() {
					var isRequired = this.get("MonthPeriodTypeValue") ===
						ProcessSchedulerConstants.MonthPeriod.MONTHLY_WEEKLY &&
						this.get("ExpressionType") ===
						ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD;
					this.set("MonthWeeklyPeriod", isRequired);
				},

				/**
				 * ############# ####### ########### ##### ### ############ ######### ## #### ######.
				 * @private
				 */
				setMonthDailyPeriod: function() {
					var isRequired = this.get("MonthPeriodTypeValue") ===
						ProcessSchedulerConstants.MonthPeriod.MONTHLY_DAILY &&
						this.get("ExpressionType") ===
						ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD;
					this.set("MonthDailyPeriod", isRequired);
				},

				/**
				 * #########, ###### ## #### ## #### ## ####### #### ######.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Object} scope ######## ##########.
				 */
				validateDaysOfWeekFilling: function(callback, scope) {
					var result = {
						success: true
					};
					if (this.get("ExpressionType") !== ProcessSchedulerConstants.ExpressionType.WEEK_PERIOD) {
						callback.call(scope || this, result);
						return;
					}
					var checkedDays = [];
					this.Terrasoft.each(ProcessSchedulerConstants.DayOfWeek, function(item) {
						if (item.property && this.get(item.property)) {
							checkedDays.push(item.value);
						}
					}, this);
					if (checkedDays.length === 0) {
						result.message = this.get("Resources.Strings.DaysOfWeekFillingWarning");
						result.success = false;
					}
					callback.call(scope || this, result);
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.BasePageV2#asyncValidate
				 * @overridden
				 */
				asyncValidate: function(callback, scope) {
					this.callParent([function(response) {
						if (!this.validateResponse(response)) {
							return;
						}
						this.Terrasoft.chain(
							function(next) {
								this.validateDaysOfWeekFilling(function(response) {
									if (this.validateResponse(response)) {
										next();
									}
								}, this);
							},
							function(next) {
								callback.call(scope, response);
								next();
							}, this);
					}, this]);
				},

				/**
				 * ############## ######### #########.
				 * @private
				 */
				initDataCollections: function() {
					this.set("MonthlyWeeklyMonthList", this.Ext.create("Terrasoft.Collection"));
					this.set("MonthlyDayOfWeekList", this.Ext.create("Terrasoft.Collection"));
				},


				/**
				 * @inheritDoc BasePageV2#setValidationConfig
				 * @overridden
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("MinutelyMinutes", this.numberRangeValidator);
					this.addColumnValidator("HourlyHours", this.numberRangeValidator);
					this.addColumnValidator("DailyHours", this.numberRangeValidator);
					this.addColumnValidator("MonthlyDay", this.numberRangeValidator);
					this.addColumnValidator("MonthlyMonth", this.numberRangeValidator);
				},

				/**
				 * ############# ######## ############## ########## ### ####.
				 * @param {Object} columnName ####### ######### ######.
				 * @param {Object} isRequired ######## ##########.
				 */
				setColumnIsRequired: function(columnName, isRequired) {
					var column = this.columns[columnName];
					if (column) {
						column.isRequired = isRequired;
					}
				},

				/**
				 * ######### ## ######### ######## ######### ######.
				 * @protected
				 * @param {Mixed} value ######## #######.
				 * @param {Object} column ####### ######.
				 * @return {Object} ######, ########## ##### ###### ### #########.
				 */
				numberRangeValidator: function(value, column) {
					var result = {
						invalidMessage: ""
					};
					if (this.Ext.isEmpty(value) || !column.isRequired) {
						return result;
					}
					var minValue = this.get("MinNumberControlValue");
					var maxValue = this.get("MaxNumberControlValue");
					var validationMessage = this.get("Resources.Strings.RangeNumberValidationMessage");
					validationMessage = this.Ext.String.format(validationMessage, minValue, maxValue);
					if (value > maxValue || value < minValue) {
						result.invalidMessage = validationMessage;
					}
					return result;
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.BasePageV2#init
				 * @overridden
				 */
				init: function() {
					this.initDataCollections();
					this.callParent(arguments);
				},

				/**
				 * ############## ######### #### ######.
				 * @param {Object} filter ####### ######### ######.
				 * @param {Object} list ######## ##########.
				 */
				prepareWeekDaysList: function(filter, list) {
					if (this.Ext.isEmpty(list)) {
						return;
					}
					var collection = this.Ext.create("Terrasoft.Collection");
					this.Terrasoft.each(ProcessSchedulerConstants.DayOfWeek, function(item) {
						collection.add(item.value, item);
					}, this);
					list.clear();
					list.loadAll(collection);
				},

				/**
				 * ############## ######### ####### #### ######.
				 * @param {Object} filter ####### ######### ######.
				 * @param {Object} list ######## ##########.
				 */
				prepareWeekDaysOrderList: function(filter, list) {
					if (this.Ext.isEmpty(list)) {
						return;
					}
					var collection = this.Ext.create("Terrasoft.Collection");
					this.Terrasoft.each(ProcessSchedulerConstants.NumberDayOfWeek, function(item) {
						collection.add(item.value, item);
					}, this);
					list.clear();
					list.loadAll(collection);
				},

				/**
				 * ############# ######## ####### Expression ### ########### ####.
				 * @protected
				 */
				setMinutePeriodExpression: function() {
					var template = ProcessSchedulerConstants.ExpressionTemplate.MINUTE_PERIOD;
					var minutes = this.get("MinutelyMinutes");
					this.set("Expression", this.Ext.String.format(template, minutes));
				},

				/**
				 * ############# ######## ####### Expression ### ########## ####.
				 * @protected
				 */
				setHourPeriodExpression: function() {
					var template = ProcessSchedulerConstants.ExpressionTemplate.HOUR_PERIOD;
					var hours = this.get("HourlyHours");
					this.set("Expression", this.Ext.String.format(template, hours));
				},

				/**
				 * ############# ######## ####### Expression ### ########### ####.
				 * @protected
				 */
				setDayPeriodExpression: function() {
					var template = ProcessSchedulerConstants.ExpressionTemplate.DAY_PERIOD;
					var time = this.get("DailyTime");
					var hours = this.get("DailyHours");
					this.set("Expression", this.Ext.String.format(template, hours, time.getHours(),
						time.getMinutes()));
				},

				/**
				 * ############# ######## ####### Expression ## #### ######.
				 * @protected
				 */
				setWeekPeriodExpression: function() {
					var template = ProcessSchedulerConstants.ExpressionTemplate.WEEK_PERIOD;
					var checkedDays = [];
					this.Terrasoft.each(ProcessSchedulerConstants.DayOfWeek, function(item) {
						if (item.property && this.get(item.property)) {
							checkedDays.push(item.value);
						}
					}, this);
					var time = this.get("WeeklyTime");
					this.set("Expression", this.Ext.String.format(template, checkedDays.join(","),
						time.getHours(), time.getMinutes()));
				},

				/**
				 * ############# ######## ####### Expression ### ############ ####.
				 * @protected
				 */
				setMonthPeriodExpression: function() {
					var template;
					var time = this.get("MonthlyTime");
					var month = this.get("MonthlyMonth");
					if (this.get("MonthPeriodTypeValue") ===
						ProcessSchedulerConstants.MonthPeriod.MONTHLY_DAILY) {
						template = ProcessSchedulerConstants.ExpressionTemplate.MONTH_DAILY_PERIOD;
						var day = this.get("MonthlyDay");
						this.set("Expression", this.Ext.String.format(template, day, month, time.getHours(),
							time.getMinutes()));
					}
					if (this.get("MonthPeriodTypeValue") ===
						ProcessSchedulerConstants.MonthPeriod.MONTHLY_WEEKLY) {
						template = ProcessSchedulerConstants.ExpressionTemplate.MONTH_WEEKLY_PERIOD;
						var weekNumber = this.get("MonthlyDayOfWeek");
						var weekDay = this.get("MonthlyWeeklyMonth");
						this.set("Expression", this.Ext.String.format(template, weekNumber.value,
							weekDay.value, month, time.getHours(), time.getMinutes()));
					}
				},


				/**
				 * ############# ######## ####### Expression.
				 * @protected
				 */
				setSchedulerExpression: function() {
					switch (this.get("ExpressionType")) {
						case ProcessSchedulerConstants.ExpressionType.MINUTE_PERIOD:
							this.setMinutePeriodExpression();
							break;
						case ProcessSchedulerConstants.ExpressionType.HOUR_PERIOD:
							this.setHourPeriodExpression();
							break;
						case ProcessSchedulerConstants.ExpressionType.DAY_PERIOD:
							this.setDayPeriodExpression();
							break;
						case ProcessSchedulerConstants.ExpressionType.WEEK_PERIOD:
							this.setWeekPeriodExpression();
							break;
						case ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD:
							this.setMonthPeriodExpression();
							break;
					}
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#onEntityInitialized
				 * @overriden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					if (!this.isNewMode()) {
						this.parseSchedulerExpression();
					}
				},

				/**
				 * Fills page fields based on cron expression.
				 * @protected
				 */
				parseSchedulerExpression: function() {
					var regexTemplates = ProcessSchedulerConstants.ExpressionRegexTemplates;
					var expression = this.get("Expression");
					if (regexTemplates.MINUTE_PERIOD.test(expression)) {
						this.parseMinutePeriod(regexTemplates.MINUTE_PERIOD, expression);
					} else if (regexTemplates.HOUR_PERIOD.test(expression)) {
						this.parseHourHoursPeriod(regexTemplates.HOUR_PERIOD, expression);
					} else if (regexTemplates.DAY_PERIOD.test(expression)) {
						this.parseDayPeriod(regexTemplates.DAY_PERIOD, expression);
					} else if (regexTemplates.WEEK_PERIOD.test(expression)) {
						this.parseWeekPeriod(regexTemplates.WEEK_PERIOD, expression);
					} else if (regexTemplates.MONTH_DAILY_PERIOD.test(expression)) {
						this.parseMonthDailyPeriod(regexTemplates.MONTH_DAILY_PERIOD, expression);
					} else if (regexTemplates.MONTH_WEEKLY_PERIOD.test(expression)) {
						this.parseMonthWeeklyPeriod(regexTemplates.MONTH_WEEKLY_PERIOD, expression);
					} else {
						this.set("ExpressionType", ProcessSchedulerConstants.ExpressionType.OTHER_PERIOD);
					}
				},

				/**
				 * Parse scheduler expression and fills page fields for "Every minute" expression type.
				 * @param {RegExp} regexTemplate RegExp expression.
				 * @param {String} expression Current cron expression.
				 * @protected
				 */
				parseMinutePeriod: function(regexTemplate, expression) {
					this.set("ExpressionType", ProcessSchedulerConstants.ExpressionType.MINUTE_PERIOD);
					var result = regexTemplate.exec(expression);
					var minutes = result[2];
					this.set("MinutelyMinutes", minutes);
				},

				/**
				 * Parse scheduler expression and fills page fields for "Hourly" expression type.
				 * @param {RegExp} regexTemplate RegExp expression.
				 * @param {String} expression Current cron expression.
				 * @protected
				 */
				parseHourHoursPeriod: function(regexTemplate, expression) {
					this.set("ExpressionType", ProcessSchedulerConstants.ExpressionType.HOUR_PERIOD);
					var result = regexTemplate.exec(expression);
					var hours = result[2];
					this.set("HourlyHours", hours);
				},

				/**
				 * Parse scheduler expression and fills page fields for "Once a Day" expression type.
				 * @param {RegExp} regexTemplate RegExp expression.
				 * @param {String} expression Current cron expression.
				 * @protected
				 */
				parseDayPeriod: function(regexTemplate, expression) {
					this.set("ExpressionType", ProcessSchedulerConstants.ExpressionType.DAY_PERIOD);
					var result = regexTemplate.exec(expression);
					var minutes = result[2];
					var hours = result[3];
					var day = result[4];
					var date = this.getDate(minutes, hours);
					this.set("DailyTime", date);
					this.set("DailyHours", day);
				},

				/**
				 * Parse scheduler expression and fills page fields for "By days of the week" expression type.
				 * @param {RegExp} regexTemplate RegExp expression.
				 * @param {String} expression Current cron expression.
				 * @protected
				 */
				parseWeekPeriod: function(regexTemplate, expression) {
					this.set("ExpressionType", ProcessSchedulerConstants.ExpressionType.WEEK_PERIOD);
					var result = regexTemplate.exec(expression);
					var minutes = result[2];
					var hours = result[3];
					var days = result[4];
					var date = this.getDate(minutes, hours);
					this.set("WeeklyTime", date);
					var checkedDays = days.split(",");
					this.Terrasoft.each(ProcessSchedulerConstants.DayOfWeek, function(item) {
						if (checkedDays.indexOf(item.value) >= 0) {
							this.set(item.property, true);
						}
					}, this);
				},

				/**
				 * Parse scheduler expression and fills page fields for "Every month/Days of month" expression type.
				 * @param {RegExp} regexTemplate RegExp expression.
				 * @param {String} expression Current cron expression.
				 * @protected
				 */
				parseMonthDailyPeriod: function(regexTemplate, expression) {
					this.set("ExpressionType", ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD);
					this.set("MonthPeriodTypeValue", ProcessSchedulerConstants.MonthPeriod.MONTHLY_DAILY);
					var result = regexTemplate.exec(expression);
					var minutes = result[2];
					var hours = result[3];
					var month = result[4];
					var day = result[5];
					var date = this.getDate(minutes, hours);
					this.set("MonthlyTime", date);
					this.set("MonthlyMonth", month);
					this.set("MonthlyDay", day);
				},

				/**
				 * Parse scheduler expression and fills page fields for "Every month/Days of the week" expression type.
				 * @param {RegExp} regexTemplate RegExp expression.
				 * @param {String} expression Current cron expression.
				 * @protected
				 */
				parseMonthWeeklyPeriod: function(regexTemplate, expression) {
					this.set("ExpressionType", ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD);
					this.set("MonthPeriodTypeValue", ProcessSchedulerConstants.MonthPeriod.MONTHLY_WEEKLY);
					var result = regexTemplate.exec(expression);
					var minutes = result[2];
					var hours = result[3];
					var month = result[4];
					var weekDay = Number(result[5]);
					var order = result[6];
					var date = this.getDate(minutes, hours);
					this.set("MonthlyTime", date);
					this.set("MonthlyMonth", month);
					this.Terrasoft.each(ProcessSchedulerConstants.NumberDayOfWeek, function(item) {
						if (item.value === weekDay) {
							this.set("MonthlyDayOfWeek", item);
						}
					}, this);
					this.Terrasoft.each(ProcessSchedulerConstants.DayOfWeek, function(item) {
						if (item.value === order) {
							this.set("MonthlyWeeklyMonth", item);
						}
					}, this);
				},

				/**
				 * Returns the date with the specified value of minutes and hours.
				 * @param {String} minutes Number of minutes.
				 * @param {String} hours Number of hours.
				 * @return {Date} Result date.
				 * @protected
				 */
				getDate: function(minutes, hours) {
					var date = new Date();
					date.setMinutes(minutes);
					date.setHours(hours);
					return date;
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#save
				 * @overriden
				 */
				save: function() {
					if (!this.validate()) {
						return;
					}
					this.setSchedulerExpression();
					this.callParent(arguments);
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"bindTo": "Name",
						"textSize": 0,
						"contentType": Terrasoft.ContentType.TEXT,
						"labelConfig": {
							"visible": true
						},
						"enabled": true
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"name": "ExpressionTypeControlGroup",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"caption": {"bindTo": "Resources.Strings.ExpressionTypeGroupCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ExpressionTypeControlGroup",
					"name": "ExpressionContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ExpressionContainer",
					"name": "RadioGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.RADIO_GROUP,
						"value": {
							"bindTo": "ExpressionType"
						},
						"items": [],
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 5
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "RadioGroup",
					"propertyName": "items",
					"name": "MinutePeriod",
					"values": {
						"caption": {"bindTo": "Resources.Strings.MinutePeriodCaption"},
						"markerValue": {"bindTo": "Resources.Strings.MinutePeriodCaption"},
						"value": ProcessSchedulerConstants.ExpressionType.MINUTE_PERIOD
					}
				},
				{
					"operation": "insert",
					"parentName": "RadioGroup",
					"propertyName": "items",
					"name": "HourPeriod",
					"values": {
						"caption": {"bindTo": "Resources.Strings.HourPeriodCaption"},
						"markerValue": {"bindTo": "Resources.Strings.HourPeriodCaption"},
						"value": ProcessSchedulerConstants.ExpressionType.HOUR_PERIOD
					}
				},
				{
					"operation": "insert",
					"parentName": "RadioGroup",
					"propertyName": "items",
					"name": "DayPeriod",
					"values": {
						"caption": {"bindTo": "Resources.Strings.DayPeriodCaption"},
						"markerValue": {"bindTo": "Resources.Strings.DayPeriodCaption"},
						"value": ProcessSchedulerConstants.ExpressionType.DAY_PERIOD
					}
				},
				{
					"operation": "insert",
					"parentName": "RadioGroup",
					"propertyName": "items",
					"name": "WeekPeriod",
					"values": {
						"caption": {"bindTo": "Resources.Strings.WeekPeriodCaption"},
						"markerValue": {"bindTo": "Resources.Strings.WeekPeriodCaption"},
						"value": ProcessSchedulerConstants.ExpressionType.WEEK_PERIOD
					}
				},
				{
					"operation": "insert",
					"parentName": "RadioGroup",
					"propertyName": "items",
					"name": "MonthPeriod",
					"values": {
						"caption": {"bindTo": "Resources.Strings.MonthPeriodCaption"},
						"markerValue": {"bindTo": "Resources.Strings.MonthPeriodCaption"},
						"value": ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD
					}
				},
				{
					"operation": "insert",
					"parentName": "RadioGroup",
					"propertyName": "items",
					"name": "OtherPeriod",
					"values": {
						"caption": {"bindTo": "Resources.Strings.OtherPeriodCaption"},
						"markerValue": {"bindTo": "Resources.Strings.OtherPeriodCaption"},
						"value": ProcessSchedulerConstants.ExpressionType.OTHER_PERIOD
					}
				},
				{
					"operation": "insert",
					"parentName": "ExpressionContainer",
					"name": "RightInnerExpressionContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 6,
							"row": 0,
							"colSpan": 18
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				// Every minute tab
				{
					"operation": "insert",
					"parentName": "RightInnerExpressionContainer",
					"name": "MinutePeriodContainer",
					"propertyName": "items",
					"values": {
						"visible": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.ExpressionType.MINUTE_PERIOD;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "MinutelyMinutes",
					"parentName": "MinutePeriodContainer",
					"propertyName": "items",
					"values": {
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.MINUTE_PERIOD;
									this.setColumnIsRequired("MinutelyMinutes", isRequired);
									return isRequired;
								}
							}
						},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 8
						}
					}
				},
				// Hourly tab
				{
					"operation": "insert",
					"parentName": "RightInnerExpressionContainer",
					"name": "HourPeriodContainer",
					"propertyName": "items",
					"values": {
						"visible": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.ExpressionType.HOUR_PERIOD;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "HourPeriodContainer",
					"name": "HourPeriodGridLayout",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "HourlyHours",
					"parentName": "HourPeriodGridLayout",
					"propertyName": "items",
					"values": {
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.HOUR_PERIOD;
									this.setColumnIsRequired("HourlyHours", isRequired);
									return isRequired;
								}
							}
						},
						"dataValueType": Terrasoft.DataValueType.INTEGER,
						"caption": {"bindTo": "Resources.Strings.HourlyHoursCaption"},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 8
						}
					}
				},
				// Daily tab
				{
					"operation": "insert",
					"parentName": "RightInnerExpressionContainer",
					"name": "DailyPeriodContainer",
					"propertyName": "items",
					"values": {
						"visible": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.ExpressionType.DAY_PERIOD;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "DailyPeriodContainer",
					"name": "DailyPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 8
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "DailyHours",
					"parentName": "DailyPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.DAY_PERIOD;
									this.setColumnIsRequired("DailyHours", isRequired);
									return isRequired;
								}
							}
						},
						"dataValueType": Terrasoft.DataValueType.INTEGER,
						"caption": {"bindTo": "Resources.Strings.DailyHoursCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "DailyTime",
					"parentName": "DailyPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.DAY_PERIOD;
									this.setColumnIsRequired("DailyTime", isRequired);
									return isRequired;
								}
							}
						},
						"dataValueType": Terrasoft.DataValueType.TIME,
						"caption": {"bindTo": "Resources.Strings.DailyTimeCaption"}
					}
				},
				// Day of the week tab
				{
					"operation": "insert",
					"parentName": "RightInnerExpressionContainer",
					"name": "WeekPeriodContainer",
					"propertyName": "items",
					"values": {
						"visible": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.ExpressionType.WEEK_PERIOD;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "WeekPeriodContainer",
					"name": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 10
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "Monday",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"caption": {"bindTo": "Resources.Strings.MondayCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "Tuesday",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"caption": {"bindTo": "Resources.Strings.TuesdayCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "Wednesday",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"caption": {"bindTo": "Resources.Strings.WednesdayCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "Thursday",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"caption": {"bindTo": "Resources.Strings.ThursdayCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "Friday",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"caption": {"bindTo": "Resources.Strings.FridayCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "Saturday",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"caption": {"bindTo": "Resources.Strings.SaturdayCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "Sunday",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.BOOLEAN,
						"caption": {"bindTo": "Resources.Strings.SundayCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "WeeklyTime",
					"parentName": "WeekPeriodInnerContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.TIME,
						"caption": {"bindTo": "Resources.Strings.WeeklyTimeCaption"},
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.WEEK_PERIOD;
									this.setColumnIsRequired("WeeklyTime", isRequired);
									return isRequired;
								}
							}
						}
					}
				},
				// Monthly tab
				{
					"operation": "insert",
					"parentName": "RightInnerExpressionContainer",
					"name": "MonthPeriodContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"visible": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "MonthPeriodContainer",
					"name": "MonthPeriodGridLayout",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "MonthPeriodGridLayout",
					"name": "MonthPeriodRadioGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.RADIO_GROUP,
						"value": {
							"bindTo": "MonthPeriodTypeValue"
						},
						"items": [],
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 7
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "MonthPeriodRadioGroup",
					"propertyName": "items",
					"name": "MonthlyDailyRadio",
					"values": {
						"caption": {"bindTo": "Resources.Strings.MonthlyDailyRadioCaption"},
						"markerValue": {"bindTo": "Resources.Strings.MonthlyDailyRadioCaption"},
						"value": ProcessSchedulerConstants.MonthPeriod.MONTHLY_DAILY
					}
				},
				{
					"operation": "insert",
					"parentName": "MonthPeriodRadioGroup",
					"propertyName": "items",
					"name": "MonthlyWeeklyRadio",
					"values": {
						"caption": {"bindTo": "Resources.Strings.MonthlyWeeklyRadioCaption"},
						"markerValue": {"bindTo": "Resources.Strings.MonthlyWeeklyRadioCaption"},
						"value": ProcessSchedulerConstants.MonthPeriod.MONTHLY_WEEKLY
					}
				},
				{
					"operation": "insert",
					"parentName": "MonthPeriodGridLayout",
					"name": "RightMonthPeriodContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 8,
							"row": 0,
							"colSpan": 10
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "RightMonthPeriodContainer",
					"name": "RightInnerMonthPeriodContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "RightMonthPeriodContainer",
					"name": "RightGeneralInnerMonthPeriodContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "RightInnerMonthPeriodContainer",
					"name": "MonthlyDailyContainer",
					"propertyName": "items",
					"values": {
						"visible": {
							"bindTo": "MonthPeriodTypeValue",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.MonthPeriod.MONTHLY_DAILY;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "MonthlyDay",
					"parentName": "MonthlyDailyContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.INTEGER,
						"caption": {
							"bindTo": "Resources.Strings.MonthlyDayCaption"
						},
						"isRequired": {
							"bindTo": "MonthDailyPeriod",
							"bindConfig": {
								"converter": function(value) {
									this.setColumnIsRequired("MonthlyDay", value);
									return value;
								}
							}
						},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "RightInnerMonthPeriodContainer",
					"name": "MonthlyWeeklyContainer",
					"propertyName": "items",
					"values": {
						"visible": {
							"bindTo": "MonthPeriodTypeValue",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.MonthPeriod.MONTHLY_WEEKLY;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "MonthlyDayOfWeek",
					"parentName": "MonthlyWeeklyContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"caption": {
							"bindTo": "Resources.Strings.MonthlyDayOfWeekCaption"
						},
						"controlConfig": {
							"prepareList": {"bindTo": "prepareWeekDaysOrderList"},
							"list": {"bindTo": "MonthlyDayOfWeekList"}
						},
						"isRequired": {
							"bindTo": "MonthWeeklyPeriod",
							"bindConfig": {
								"converter": function(value) {
									this.setColumnIsRequired("MonthlyDayOfWeek", value);
									return value;
								}
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "MonthlyWeeklyMonth",
					"parentName": "MonthlyWeeklyContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"caption": {
							"bindTo": "Resources.Strings.MonthlyWeeklyMonthCaption"
						},
						"controlConfig": {
							"prepareList": {"bindTo": "prepareWeekDaysList"},
							"list": {"bindTo": "MonthlyWeeklyMonthList"}
						},
						"isRequired": {
							"bindTo": "MonthWeeklyPeriod",
							"bindConfig": {
								"converter": function(value) {
									this.setColumnIsRequired("MonthlyWeeklyMonth", value);
									return value;
								}
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "MonthlyMonth",
					"parentName": "RightMonthPeriodContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.INTEGER,
						"caption": {
							"bindTo": "Resources.Strings.MonthlyMonthCaption"
						},
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD &&
										this.get("ExpressionType") ===
										ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD;
									this.setColumnIsRequired("MonthlyMonth", isRequired);
									return isRequired;
								}
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "MonthlyTime",
					"parentName": "RightMonthPeriodContainer",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.TIME,
						"caption": {
							"bindTo": "Resources.Strings.MonthlyTimeCaption"
						},
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.MONTH_PERIOD;
									this.setColumnIsRequired("MonthlyTime", isRequired);
									return isRequired;
								}
							}
						}
					}
				},
				// Other tab
				{
					"operation": "insert",
					"parentName": "RightInnerExpressionContainer",
					"name": "OtherPeriodContainer",
					"propertyName": "items",
					"values": {
						"visible": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									return value === ProcessSchedulerConstants.ExpressionType.OTHER_PERIOD;
								}
							}
						},
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "Expression",
					"parentName": "OtherPeriodContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"dataValueType": Terrasoft.DataValueType.TEXT,
						"isRequired": {
							"bindTo": "ExpressionType",
							"bindConfig": {
								"converter": function(value) {
									var isRequired = value === ProcessSchedulerConstants.ExpressionType.OTHER_PERIOD;
									this.setColumnIsRequired("Expression", isRequired);
									return isRequired;
								}
							}
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
