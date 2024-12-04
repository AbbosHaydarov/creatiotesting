define("FinApplicationProfileUtils", ["ProductBankConstants", "FinApplicationProfileUtilsResources"],
	function(ProductBankConstants, resources) {
		/**
		 * @class Terrasoft.configuration.mixins.FinApplicationProfileUtils
		 */
		Ext.define("Terrasoft.configuration.mixins.FinApplicationProfileUtils", {
			alternateClassName: "Terrasoft.FinApplicationProfileUtils",

			//region Methods: Private

			/**
			 * Updates currency virtual field with fetched short name value.
			 * @private
			 * @param {Object} response Result query collection.
			 * @param {Function} callback Callback function if response successful.
			 * @param {Object} scope Callback context.
			 */
			parseCurrencyShortNameResponse: function(response, callback, scope) {
				var currencyShortName;
				if (response.success) {
					var currencyItem = response.collection.first();
					if (currencyItem) {
						currencyShortName = currencyItem.get("ShortName");
					}
				}
				this.Ext.callback(callback, scope, [currencyShortName]);
			},

			/**
			 * Generate query to fetch currency short name.
			 * @private
			 * @param {String} currencyId Currency identifier.
			 * @return {Terrasoft.EntitySchemaQuery} Query.
			 */
			getCurrencyShortNameQuery: function(currencyId) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "Currency"
				});
				esq.addColumn("Id");
				esq.addColumn("Name");
				esq.addColumn("ShortName");
				esq.filters.add("idFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "Id", currencyId));
				return esq;
			},

			/**
			 * Add filters to query to get only nessesary specification items.
			 * @private
			 * @param {Terrasoft.EntitySchemaQuery} esq Query to add filters.
			 */
			addSpecificationTypesFilter: function(esq) {
				if (esq && esq.filters) {
					esq.filters.add("specificatoinsFilter", this.Terrasoft.createColumnInFilterWithParameters(
						"Specification", [
							ProductBankConstants.Specification.AMOUNT,
							ProductBankConstants.Specification.CURRENCY,
							ProductBankConstants.Specification.TERM_YEARS,
							ProductBankConstants.Specification.TERM_MONTH
						]));
				}
			},

			/**
			 * Creates entitySchemaQuery that selects FinApplication Specifications.
			 * @private
			 * @param {String} finApplicationId Finance application record id.
			 * @return {Terrasoft.EntitySchemaQuery} Query to EntitySchema of actions.
			 */
			getFinApplicationSpecQuery: function(finApplicationId) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "FinApplicationSpec"
				});
				esq.addColumn("Id");
				esq.addColumn("Specification");
				esq.addColumn("FloatValue");
				esq.addColumn("IntegerValue");
				esq.addColumn("SpecificationListItem.LookupValueId", "LookupValueId");
				esq.filters.add("finApplicationFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "FinApplication", finApplicationId));
				this.addSpecificationTypesFilter(esq);
				return esq;
			},

			/**
			 * Updates visible credit amount field with actual currency info.
			 * @private
			 */
			updateAmount: function() {
				var finAppAmount = this.get("FinAppAmount");
				var finAppCurrency = this.get("FinAppCurrency");
				if (finAppAmount && finAppCurrency) {
					var formattedAmount = this.Terrasoft.getFormattedNumberValue(finAppAmount);
					this.set("FinAppAmountWithCurrency",
						this.Ext.String.format("{0} {1}", formattedAmount, finAppCurrency));
				} else {
					this.set("FinAppAmountWithCurrency", null);
				}
			},

			/**
			 * Validates that the number of dependants is greater than zero.
			 * @private
			 * @param {Number} columnValue Value of column.
			 * @return {Object} Validates object.
			 */
			validateNumberOfDependantsMoreThenZero: function(columnValue) {
				var invalidMessage;
				if (columnValue < 0) {
					invalidMessage = this.get("Resources.Strings.NumberMustBeGreaterThenZeroMessage");
				}
				return {
					fullInvalidMessage: invalidMessage,
					invalidMessage: invalidMessage
				};
			},

			/**
			 * Parses query response to fill fin application specification data fields.
			 * @private
			 * @param {Object} response Result query collection.
			 * @param {Function} callback Callback function if response successful.
			 * @param {Object} scope Callback context.
			 */
			parseFinAppResponse: function(response, callback, scope) {
				if (response.success) {
					this.Terrasoft.chain(
						function(next) {
							this.initAmount(response);
							this.initTerm(response);
							next();
						},
						function() {
							this.initCurrencyShortName(response, callback, scope);
						},
						this);
				} else {
					this.Ext.callback(callback, scope);
				}
			},

			/**
			 * Updates amount virtual field with fetched credit value.
			 * @private
			 * @param {Object} response Specification response collection.
			 * @param {Function} callback Callback function if response successful.
			 * @param {Object} scope Callback context.
			 */
			initAmount: function(response, callback, scope) {
				var amountValue;
				var amountItem = this.findItemBySpecification(response.collection,
					ProductBankConstants.Specification.AMOUNT);
				if (amountItem) {
					amountValue = amountItem.get("FloatValue");
				}
				this.set("FinAppAmount", amountValue);
				this.Ext.callback(callback, scope, [amountValue]);
			},

			/**
			 * Updates term virtual field with fetched credit term in years or months,
			 * depends on one of them defined in specifications. If both defined - prefer years.
			 * @private
			 * @param {Object} response Specification response collection.
			 * @param {Function} callback Callback function if response successful.
			 * @param {Object} scope Callback context.
			 */
			initTerm: function(response, callback, scope) {
				var termValue;
				var monthItem = this.findItemBySpecification(response.collection,
					ProductBankConstants.Specification.TERM_MONTH);
				if (monthItem) {
					termValue = this.getTermString(monthItem.get("IntegerValue"), "Month");
				}
				var yearsItem = this.findItemBySpecification(response.collection,
					ProductBankConstants.Specification.TERM_YEARS);
				if (yearsItem) {
					termValue = this.getTermString(yearsItem.get("IntegerValue"), "Year");
				}
				this.set("FinAppTerm", termValue);
				this.Ext.callback(callback, scope, [termValue]);
			},

			/**
			 * Returns formatted term string.
			 * @protected
			 * @param {Number} value Term count.
			 * @param {String} prefix Term name ('Month', 'Year' ets.).
			 * @return {String} Term string.
			 */
			getTermString: function(value, prefix) {
				value = Math.abs(value);
				var cases = [2, 0, 1, 1, 1, 2];
				var postfixes = ["", "s1", "s2"];
				var caseIndex = (value % 10 < 5) ? value % 10 : 5;
				var postfix = postfixes[(20 > value % 100 && value % 100 > 4)
					? 2
					: cases[caseIndex]];
				var term = resources.localizableStrings[prefix + postfix];
				return this.Ext.String.format("{0} {1}", value, term);
			},

			/**
			 * Updates currency virtual field with fetched currency short name value.
			 * @private
			 * @param {Object} response Specification response collection.
			 * @param {Function} callback Callback function if response successful.
			 * @param {Object} scope Callback context.
			 */
			initCurrencyShortName: function(response, callback, scope) {
				this.set("FinAppCurrency", null);
				var currencySpecItem = this.findItemBySpecification(response.collection,
					ProductBankConstants.Specification.CURRENCY);
				var currencyId = currencySpecItem && currencySpecItem.get("LookupValueId");
				if (currencyId) {
					var esq = this.getCurrencyShortNameQuery(currencyId);
					this.Terrasoft.chain(
						function(next) {
							esq.getEntityCollection(next, this);
						},
						function(next, currencyResponse) {
							this.parseCurrencyShortNameResponse(currencyResponse, next, this);
						},
						function(next, currencyShortName) {
							this.set("FinAppCurrency", currencyShortName);
							this.Ext.callback(callback, scope, [currencyShortName]);
						},
						this
					);
				} else {
					this.Ext.callback(callback, scope);
				}
			},

			/**
			 * Finds necessary parameter from esq result collection by specification id.
			 * @private
			 * @param {Object} collection Esq result collection.
			 * @param {Object} specificationId Specification identifier.
			 * @return {Object} Found parameter.
			 */
			findItemBySpecification: function(collection, specificationId) {
				return collection.filter(function(item) {
					var specification = item.get("Specification");
					if (specification && specification.value) {
						return specification.value === specificationId;
					} else {
						return false;
					}
				}).first();
			},

			//endregion

			//region Methods: Protected

			/**
			 * Initializes query to fetch all data for appForm profile data.
			 * @protected
			 * @param {Function} callback Callback-function.
			 * @param {Object} scope Callback-function scope.
			 */
			initFinAppValues: function(callback, scope) {
				var finApplicationConfig = this.getFinApplicationConfig() || {};
				var finApplication = finApplicationConfig.finApplication;
				if (this.Ext.isObject(finApplication)) {
					this.set("FinAppProduct", finApplicationConfig.product);
					var esq = this.getFinApplicationSpecQuery(finApplication.value);
					esq.getEntityCollection(function(response) {
						this.parseFinAppResponse(response, callback, scope);
					}, this);
				} else {
					this.set("FinAppProduct", null);
					this.set("FinAppAmount", null);
					this.set("FinAppTerm", null);
				}
			},

			/**
			 * Returns FinApplication and Product parameters.
			 * @protected
			 * @return {Object} Found parameter.
			 */
			getFinApplicationConfig: this.Ext.emptyFn

			//endregion
		});
	});
