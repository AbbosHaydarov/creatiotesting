define("PeriodPageV2", ["terrasoft", "BaseFinanceUtilities"], function(Terrasoft, BaseFinanceUtilities) {
	return {
		entitySchemaName: "Period",
		attributes: {
			"TypeGenerator": {
				dependencies: [{
					columns: ["StartDate", "DueDate"],
					methodName: "autoFillType"
				}]
			},
			"NameGenerator": {
				dependencies: [{
					columns: ["StartDate", "DueDate", "PeriodType"],
					methodName: "generateName"
				}]
			},
			"PeriodType": {
				lookupListConfig: {
					orders: [{
						columnPath: "Position",
						direction: Terrasoft.OrderDirection.ASC
					}]
				}
			}
		},
		details: /**SCHEMA_DETAILS*/ {},
		/**SCHEMA_DETAILS*/
		methods: {
			/**
			 * ############## ########### #### ####### ## #### #####
			 * @protected
			 */
			autoFillType: function() {
				if (this.get("StartDate") && this.get("DueDate")) {
					var startDate = this.get("StartDate");
					var dueDate = this.get("DueDate");
					this.loadLookupDisplayValue("PeriodType", BaseFinanceUtilities.getPeriodType(startDate, dueDate));
				}
			},
			/**
			 * ############## ########## #### ########
			 * @protected
			 */
			generateName: function() {
				if (this.get("StartDate") && this.get("DueDate") && this.get("PeriodType")) {
					this.set("Name", BaseFinanceUtilities.getPeriodName(this.get("StartDate"), this.get("DueDate"),
						this.get("PeriodType").value));
				}
			},
			/**
			 * ######## ### #### ########## ###### #### ######
			 * @protected
			 * @overridden
			 * @returns {boolean}
			 */
			validate: function() {
				var isValid = this.callParent(arguments);
				if (!isValid) {
					return false;
				}
				var ext = this.Ext;
				var startDate = this.get("StartDate");
				var dueDate = this.get("DueDate");
				if (ext.isDate(startDate) && ext.isDate(dueDate)) {
					if (ext.Date.clearTime(startDate) > ext.Date.clearTime(dueDate)) {
						this.showInformationDialog(this.get("Resources.Strings.NotValidEndDateMessage"));
						return false;
					}
				}
				return true;
			},
			/**
			 * ######### ####### ####### # #### ######
			 * @protected
			 * @overridden
			 * @param {Function} callback callback-#######
			 * @param {Terrasoft.BaseSchemaViewModel} scope ######## ########## callback-#######
			 */
			asyncValidate: function(callback, scope) {
				this.callParent([function(result) {
					if (result.success) {
						BaseFinanceUtilities.checkPeriodExist(this.get("StartDate"),
							this.get("DueDate"), true, callback, scope);
					} else {
						callback.call(scope, result);
					}
				}, this]);
			}
		},
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "merge",
			"name": "Description",
			"values": {
				"layout": {
					"column": 0,
					"row": 4,
					"colSpan": 24,
					"rowSpan": 1
				}
			}
		}, {
			"operation": "merge",
			"name": "Name",
			"values": {
				"enabled": false
			}
		}, {
			"operation": "insert",
			"name": "StartDate",
			"values": {
				"layout": {
					"column": 0,
					"row": 1,
					"colSpan": 12,
					"rowSpan": 1
				},
				"bindTo": "StartDate",
				"enabled": true
			},
			"parentName": "GeneralInfoBlock",
			"propertyName": "items"
		}, {
			"operation": "insert",
			"name": "DueDate",
			"values": {
				"layout": {
					"column": 0,
					"row": 2,
					"colSpan": 12,
					"rowSpan": 1
				},
				"bindTo": "DueDate",
				"enabled": true
			},
			"parentName": "GeneralInfoBlock",
			"propertyName": "items"
		}, {
			"operation": "insert",
			"name": "PeriodType",
			"values": {
				"contentType": Terrasoft.ContentType.ENUM,
				"layout": {
					"column": 0,
					"row": 3,
					"colSpan": 12,
					"rowSpan": 1
				},
				"bindTo": "PeriodType",
				"enabled": true
			},
			"parentName": "GeneralInfoBlock",
			"propertyName": "items"
		}] /**SCHEMA_DIFF*/
	};
});
