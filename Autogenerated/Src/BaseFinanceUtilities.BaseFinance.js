define("BaseFinanceUtilities", ["ext-base", "terrasoft", "BaseFinanceConstants", "BaseFinanceUtilitiesResources"],
	function(Ext, Terrasoft, baseFinanceConstants, resources) {

		/**
		 * @class Terrasoft.configuration.BaseFinanceUtilities
		 * Class BaseFinanceUtilities provides utility methods for working with finance objects.
		 */
		Ext.define("Terrasoft.configuration.BaseFinanceUtilities", {
			alternateClassName: "Terrasoft.BaseFinanceUtilities",
			singleton: true,

			//region Methods: Private

			/**
			 * Get period type by two dates.
			 * @private
			 * @param {Ext.Date} startDate Start date.
			 * @param {Ext.Date} endDate End date.
			 * @returns {Guid} Period type.
			 */
			getPeriodType: function(startDate, endDate) {
				var sDay = startDate.getDate();
				var sMonth = startDate.getMonth();
				var sYear = startDate.getYear();
				var eDay = endDate.getDate();
				var eMonth = endDate.getMonth();
				var eYear = endDate.getYear();
				var periodType = baseFinanceConstants.PeriodType;

				if (sYear === eYear) {
					if (sMonth === eMonth) {
						if (sDay === eDay) {
							return periodType.Day;
						}
					}
					if (sDay === 1) {
						if (eDay === Ext.Date.getLastDateOfMonth(endDate).getDate()) {
							if (sMonth === eMonth) {
								return periodType.Month;
							}
							if ((sMonth === 0 && eMonth === 2) ||
								(sMonth === 3 && eMonth === 5) ||
								(sMonth === 6 && eMonth === 8) ||
								(sMonth === 9 && eMonth === 11)) {
								return periodType.Quarter;
							}

							if ((sMonth === 0 && eMonth === 5) ||
								(sMonth === 6 && eMonth === 11)) {
								return periodType.HalfYear;
							}

							if (sMonth === 0 && eMonth === 11) {
								return periodType.Year;
							}
						}
					}
				}
				return periodType.Custom;
			},

			//endregion

			//region Methods: Public

			/**
			 * Get name of period.
			 * @public
			 * @param {Ext.Date} startDate Start date.
			 * @param {Ext.Date} endDate End date.
			 * @param {Guid} type Period type.
			 * @returns {String} Name of period
			 */
			getPeriodName: function(startDate, endDate, type) {
				var periodType = baseFinanceConstants.PeriodType;
				if (type !== this.getPeriodType(startDate, endDate)) {
					return (Ext.Date.format(startDate, Terrasoft.Resources.CultureSettings.dateFormat) + " - " +
						Ext.Date.format(endDate, Terrasoft.Resources.CultureSettings.dateFormat));
				}
				switch (type) {
					case periodType.Day:
						return Ext.Date.format(startDate, Terrasoft.Resources.CultureSettings.dateFormat);
					case periodType.Month:
						return resources.localizableStrings["Month" + startDate.getMonth()] + " " +
							Ext.Date.format(startDate, "Y");
					case periodType.Quarter:
						return ((endDate.getMonth() + 1) / 3) + " " + resources.localizableStrings.Quarter + " " +
							Ext.Date.format(startDate, "Y");
					case periodType.HalfYear:
						return ((endDate.getMonth() + 1) / 6) + " " + resources.localizableStrings.HalfYear + " " +
							Ext.Date.format(startDate, "Y");
					case periodType.Year:
						return Ext.Date.format(startDate, "Y");
					default:
						return (Ext.Date.format(startDate, Terrasoft.Resources.CultureSettings.dateFormat) + " - " +
							Ext.Date.format(endDate, Terrasoft.Resources.CultureSettings.dateFormat));
				}
			},

			/**
			 * Check period exist in database.
			 * @public
			 * @param {Ext.Date} startDate Start date.
			 * @param {Ext.Date} endDate End date.
			 * @param {Boolean} showMessage Show message if record exist.
			 * @param {Function} callback Callback function.
			 * @param {Terrasoft.BaseSchemaViewModel} scope Execution context.
			 */
			checkPeriodExist: function(startDate, endDate, showMessage, callback, scope) {
				var selectPeriod = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "Period"
				});
				selectPeriod.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
				var startDateFilter = selectPeriod.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL,
					"StartDate",
					startDate);
				startDateFilter.trimDateTimeParameterToDate = true;
				var endDateFilter = selectPeriod.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL,
					"DueDate",
					endDate);
				endDateFilter.trimDateTimeParameterToDate = true;
				var filterGroup = Terrasoft.createFilterGroup();
				filterGroup.logicalOperation = Terrasoft.LogicalOperatorType.AND;
				filterGroup.addItem(startDateFilter);
				filterGroup.addItem(endDateFilter);
				selectPeriod.filters.add(filterGroup);
				selectPeriod.getEntityCollection(function(response) {
					if (response.success === true) {
						var collection = response.collection;
						var result = {
							success: true,
							id: null
						};
						if (collection.getCount() !== 0) {
							if (showMessage) {
								this.showInformationDialog(resources.localizableStrings.PeriodExist);
							}
							var period = collection.getByIndex(0);
							result.id = period.get("Id");
							result.success = false;
						}
						callback.call(scope, result);
					}
				}, scope);
			}

			//endregion

		});

		return Terrasoft.BaseFinanceUtilities;
	});
