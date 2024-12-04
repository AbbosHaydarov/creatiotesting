define("ProcessSchedulerConstants", ["ProcessSchedulerConstantsResources"],
	function(resources) {

		/** @enum
		 *  #### ######### ############. */
		var expressionType = {
			/** @type {Number} #########. */
			MINUTE_PERIOD: 0,
			/** @type {Number} ########. */
			HOUR_PERIOD: 1,
			/** @type {Number} #########. */
			DAY_PERIOD: 2,
			/** @type {Number} ## #### ######. */
			WEEK_PERIOD: 3,
			/** @type {Number} ##########. */
			MONTH_PERIOD: 4,
			/** @type {Number} ######. */
			OTHER_PERIOD: 5
		};

		/** @enum
		 *  ####### ######### ############. */
		var expressionTemplate = {
			/** @type {String} ###### ### ########### #### #########. */
			MINUTE_PERIOD: "0 0/{0} * 1/1 * ? *",
			/** @type {String} ###### ### ########## #### #########. ###### ##### ###### n #####.*/
			HOUR_PERIOD: "0 0 0/{0} 1/1 * ? *",
			/** @type {String} ###### ### ########### #### #########. */
			DAY_PERIOD: "0 {2} {1} 1/{0} * ? *",
			/** @type {String} ###### ######### ## #### ######. */
			WEEK_PERIOD: "0 {2} {1} ? * {0} *",
			/** @type {String} ###### ######### ### ############ ####### ############ # ######### #### ######. */
			MONTH_DAILY_PERIOD: "0 {3} {2} {1} 1/{0} ? *",
			/** @type {String} ###### ######### ### ############ ####### ############ # ######### #### ######. */
			MONTH_WEEKLY_PERIOD: "0 {4} {3} ? 1/{2} {0}#{1} *"
		};

		/** @enum
		 *  ########## ######### ### ######## cron #########. */
		var expressionRegexTemplates = {
			/** @type {RegExp} ########## ######### ### ########### ##########. #### ########### ######### ##########
			#####. */
			MINUTE_PERIOD: /(0 0\/(\d+) \* 1\/1 \* \? \*)/,
			/** @type {RegExp} ########## ######### ########## ## #####. #### ########### ######### ##########
			#####. */
			HOUR_PERIOD: /(0 0 0\/(\d+) 1\/1 \* \? \*)/,
			/** @type {RegExp} ########## ######### ########## ## ####. #### ########### ######### ##########
			#####, ##### # ####. */
			DAY_PERIOD: /(0 (\d+) (\d+) 1\/(\d+) \* \? \*)/,
			/** @type {RegExp} ########## ######### ########## ## #######. #### ########### ######### ##########
			#####, ##### # #### ######. */
			WEEK_PERIOD: /(0 (\d+) (\d+) \? \* ([\w+,]+) \*)/,
			/** @type {RegExp} ########## ######### ########## ## #######. #### ########### ######### ##########
			#####, #####, #### # #######. */
			MONTH_DAILY_PERIOD: /(0 (\d+) (\d+) (\d+) 1\/(\d+) \? \*)/,
			/** @type {RegExp} ########## ######### ########## ## #######. #### ########### ######### ##########
			#####, #####, #### ###### # ## #######, # ### ## #######. */
			MONTH_WEEKLY_PERIOD: /(0 (\d+) (\d+) \? 1\/(\d+) (\d+)#(\w+) \*)/
		};

		/** @enum
		 *  ####### ######### ######### ############. */
		var hourPeriod = {
			/** @type {Number} ######### ######### ############ # ######### ####### #######. */
			HOURLY_HOURS: 0,
			/** @type {Number} ######### ######### ############ # ######### ####### #######. */
			HOURLY_TIME: 1
		};

		/** @enum
		 *  ####### ########### ######### ############. */
		var monthPeriod = {
			/** @type {Number} ########### ######### ############ # ######### #### ######. */
			MONTHLY_WEEKLY: 0,
			/** @type {Number} ########### ######### ############ # ######### #### ######. */
			MONTHLY_DAILY: 1
		};

		/** @enum
		 *  ### ######. */
		var dayOfWeek = {
			/** @type {Object} ###########. */
			MONDAY: {
				"displayValue": resources.localizableStrings.MondayCaption,
				"property": "Monday",
				"value": "MON"
			},
			/** @type {Object} #######. */
			TUESDAY: {
				"displayValue": resources.localizableStrings.TuesdayCaption,
				"property": "Tuesday",
				"value": "TUE"
			},
			/** @type {Object} #####. */
			WEDNESDAY: {
				"displayValue": resources.localizableStrings.WednesdayCaption,
				"property": "Wednesday",
				"value": "WED"
			},
			/** @type {Object} #######. */
			THURSDAY: {
				"displayValue": resources.localizableStrings.ThursdayCaption,
				"property": "Thursday",
				"value": "THU"
			},
			/** @type {Object} #######. */
			FRIDAY: {
				"displayValue": resources.localizableStrings.FridayCaption,
				"property": "Friday",
				"value": "FRI"
			},
			/** @type {Object} #######. */
			SATURDAY: {
				"displayValue": resources.localizableStrings.SaturdayCaption,
				"property": "Saturday",
				"value": "SAT"
			},
			/** @type {Object} ###########. */
			SUNDAY: {
				"displayValue": resources.localizableStrings.SundayCaption,
				"property": "Sunday",
				"value": "SUN"
			}
		};

		/** @enum
		 *  ####### ### ######. */
		var numberDayOfWeek = {
			/** @type {Object} ######. */
			FIRST: {
				displayValue: resources.localizableStrings.FirstCaption,
				value: 1
			},
			/** @type {Object} ######. */
			SECOND: {
				displayValue: resources.localizableStrings.SecondCaption,
				value: 2
			},
			/** @type {Object} ######. */
			THIRD: {
				displayValue: resources.localizableStrings.ThirdCaption,
				value: 3
			},
			/** @type {Object} #########. */
			FOURTH: {
				displayValue: resources.localizableStrings.FourthCaption,
				value: 4
			}
		};

		return {
			ExpressionType: expressionType,
			ExpressionTemplate: expressionTemplate,
			ExpressionRegexTemplates: expressionRegexTemplates,
			HourPeriod: hourPeriod,
			MonthPeriod: monthPeriod,
			DayOfWeek: dayOfWeek,
			NumberDayOfWeek: numberDayOfWeek
		};
	});
