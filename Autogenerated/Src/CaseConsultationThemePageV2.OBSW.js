define("CaseConsultationThemePageV2", [], function() {
	return {
		entitySchemaName: "CaseConsultationTheme",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Theme",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "LeadMedium",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "DateTimeStart",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "Duration",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "Result",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "Product",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "DateTimeEnd",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Comment",
				"values": {
					"enabled": false,
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 3
					},
					"contentType": Terrasoft.ContentType.LONG_TEXT,
					"labelWrapConfig": {
						"classes": {
							"wrapClassName": "justify-top"
						}
					}
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {
			"Theme": {
				"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
				"lookupListConfig": {
					"filters": [
						{
							method: function() {
								return this.getThemeFilter();
							}
						}
					]
				}
			},
			"ConsultationStartOrEndChange": {
				name: "DateTimeStartOrEnd",
				dependencies: [
					{
						columns: ["DateTimeStart"],
						methodName: "onConsultationStartOrEndChange"
					},
					{
						columns: ["DateTimeEnd"],
						methodName: "onConsultationStartOrEndChange"
					}
				]
			}
		},
		methods: {
			/**
			 * @inheritdoc Terrasoft.BasePageV2#getActions
			 * @overridden
			 */
			getActions: function() {
				var actionMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
				return actionMenuItems;
			},

			/**
			 * Create a group filter to select the consultation theme.
			 * @protected
			 * @return {Terrasoft.FilterGroup}
			 */
			getThemeFilter: function() {
				var filters = this.Terrasoft.createFilterGroup();
				filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"IsFolder", false));
				filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"Block.UseInOBSW", true));
				return filters;
			},

			/**
			 * Set duration of consultation by theme.
			 * @protected
			 */
			onConsultationStartOrEndChange: function() {
				var dateTimeStart = this.get("DateTimeStart");
				var dateTimeEnd = this.get("DateTimeEnd");
				var millisecondsInMinute = Terrasoft.DateRate.MILLISECONDS_IN_MINUTE;
				var millisecondsInSecond = Terrasoft.DateRate.MILLISECONDS_IN_SECOND;
				var differenceTime = "";
				if (this.Ext.isDate(dateTimeStart) && this.Ext.isDate(dateTimeEnd)) {
					var timeDifference = Ext.Date.getElapsed(dateTimeStart, dateTimeEnd);
					var secondDifference = Math.floor(timeDifference / millisecondsInSecond);
					var minutes = Math.floor(timeDifference / millisecondsInMinute);
					var seconds = secondDifference - (minutes * 60);
					minutes = this.getZeroPad(minutes.toString(), 2);
					seconds = this.getZeroPad(seconds.toString(), 2);
					differenceTime = this.getDurationString(minutes, seconds);
				}
				this.set("Duration", differenceTime);
			},

			/**
			 * Pad a number with a zero, to make it max digits.
			 * @private
			 * @param {String} numberAsString - predetermined number as string.
			 * @param {Number} charactersCount - the required number of characters of predetermined number.
			 * @return {String}
			 */
			getZeroPad: function(numberAsString, charactersCount) {
				return numberAsString.length < charactersCount
					? this.getZeroPad("0" + numberAsString, charactersCount)
					: numberAsString;
			},

			/**
			 * Create duration as string in format(mm:ss).
			 * @protected
			 * @param {String} minutes - minutes.
			 * @param {String} seconds - seconds.
			 * @return {String}
			 */
			getDurationString: function(minutes, seconds) {
				return Ext.String.format("{0}:{1}", minutes, seconds);
			}
		}
	};
});
