define("BankCardPageV2", ["BankCardPageV2Resources", "BankCustomerJourneyConstants"],
	function(resources, BankCustomerJourneyConstants) {
		return {
			entitySchemaName: "BankCard",
			details: /**SCHEMA_DETAILS*/{
				RelatedBankCardDetailV2: {
					schemaName: "RelatedBankCardDetailV2",
					entitySchemaName: "BankCardRelated",
					filter: {
						masterColumn: "Id",
						detailColumn: "BankCard"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "insert",
					"name": "GeneralInfoGroup",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
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
					"operation": "move",
					"name": "BankCardPageGeneralBlock",
					"parentName": "GeneralInfoGroup",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Client",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": {
							"bindTo": "Contract",
							"bindConfig": {
								"converter": "isContractEmpty"
							}
						},
						"controlConfig": {
							"enableLeftIcon": true,
							"leftIconConfig": {
								"bindTo": "getMultiLookupIconConfig"
							}
						},
						"tabIndex": 5
					}
				},
				{
					"operation": "insert",
					"name": "Package",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"visible": {
							"bindTo": "IsPackageVisible"
						},
						"enabled": {
							"bindTo": "Contract",
							"bindConfig": {
								"converter": "isContractEmpty"
							}
						},
						"tabIndex": 7
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"parentName": "BankCardPageGeneralBlock",
					"propertyName": "items",
					"name": "ContactNameEng",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12
						},
						"tabIndex": 13
					}
				},
				{
					"operation": "insert",
					"parentName": "BankCardPageGeneralBlock",
					"propertyName": "items",
					"name": "IsPayPassPayWave",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 11,
							"rowSpan": 1
						},
						"tabIndex": 11
					}
				},
				{
					"operation": "insert",
					"name": "AdditionalInfoGroup",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"caption": {
							"bindTo": "Resources.Strings.AdditionalInfoGroupCaption"
						},
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "AdditionalInfoGroupGridLayout",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "AdditionalInfoGroup",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"parentName": "AdditionalInfoGroupGridLayout",
					"propertyName": "items",
					"name": "BankCardStatus",
					"values": {
						"contentType": Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"tabIndex": 14
					}
				},
				{
					"operation": "insert",
					"parentName": "AdditionalInfoGroupGridLayout",
					"propertyName": "items",
					"name": "StartDate",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12
						},
						"tabIndex": 15
					}
				},
				{
					"operation": "insert",
					"parentName": "AdditionalInfoGroupGridLayout",
					"propertyName": "items",
					"name": "ValidDate",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12
						},
						"tabIndex": 16
					}
				},
				{
					"operation": "insert",
					"parentName": "AdditionalInfoGroupGridLayout",
					"propertyName": "items",
					"name": "Balance",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12
						},
						"tabIndex": 17
					}
				},
				{
					"operation": "insert",
					"parentName": "AdditionalInfoGroupGridLayout",
					"propertyName": "items",
					"name": "CashLimit",
					"values": {
						"caption": {
							"bindTo": "CashLimitCaption"
						},
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12
						},
						"tabIndex": 18
					}
				},
				{
					"operation": "insert",
					"parentName": "AdditionalInfoGroupGridLayout",
					"propertyName": "items",
					"name": "Debt",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12
						},
						"tabIndex": 19
					}
				},
				{
					"operation": "insert",
					"parentName": "AdditionalInfoGroupGridLayout",
					"propertyName": "items",
					"name": "RepayDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12
						},
						"visible": {
							"bindTo": "IsRepayDateVisible"
						},
						"tabIndex": 20
					}
				},
				{
					"operation": "merge",
					"name": "Number",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.NumberCaption"
						}
					}
				},
				{
					"operation": "merge",
					"name": "BankCardOwner",
					"values": {
						"enabled": true
					}
				},
				{
					"operation": "merge",
					"name": "Product",
					"values": {
						"isRequired": true,
						"enabled": {
							"bindTo": "Contract",
							"bindConfig": {
								"converter": "isContractEmpty"
							}
						},
						"tabIndex": 6
					}
				},
				{
					"operation": "merge",
					"name": "Holder",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12
						},
						"tabIndex": 12
					}
				},
				{
					"operation": "merge",
					"name": "Contract",
					"values": {
						"tabIndex": 3
					}
				},
				{
					"operation": "merge",
					"name": "BankCardType",
					"values": {
						"tabIndex": 8
					}
				},
				{
					"operation": "merge",
					"name": "BankCardPaymentSystem",
					"values": {
						"tabIndex": 9
					}
				},
				{
					"operation": "merge",
					"name": "BankCardCategory",
					"values": {
						"tabIndex": 10
					}
				},
				{
					"operation": "merge",
					"name": "Branch",
					"values": {
						"tabIndex": 13
					}
				},
				{
					"operation": "merge",
					"name": "Division",
					"values": {
						"tabIndex": 14
					}
				},
				{
					"operation": "move",
					"name": "IsPrimary",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12
						},
						"tabIndex": 4
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "remove",
					"name": "BankAccountInBankCardDetailV2"
				},
				{
					"operation": "remove",
					"name": "BankCardOwner"
				},
				{
					"operation": "remove",
					"name": "IsMulticurrency"
				},
				{
					"operation": "remove",
					"name": "StatusGroup"
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"name": "BankAccountInBankCardDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"name": "RelatedBankCardDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			] /**SCHEMA_DIFF*/,
			attributes: {
				/**
				 * Client.
				 * @type {Object}
				 */
				"Client": {
					"caption": {
						"bindTo": "Resources.Strings.Client"
					},
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"multiLookupColumns": ["Contact", "BankCardOwner"],
					"isRequired": true
				},

				/**
				 * Service Package.
				 * @type {Object}
				 */
				"Package": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						"filters": [
							{
								method: function() {
									return this.getPackageFilter();
								}
							}
						]
					}
				},

				/**
				 * Product.
				 * @type {Object}
				 */
				"ProductChange": {
					"name": "Product",
					"dependencies": [{
						"columns": ["Product"],
						"methodName": "onProductChanged"
					}]
				},

				/**
				 * Type.
				 * @type {Object}
				 */
				"BankCardTypeChange": {
					"name": "BankCardType",
					"dependencies": [{
						"columns": ["BankCardType"],
						"methodName": "onBankCardTypeChange"
					}]
				},

				/**
				 * Contract.
				 * @type {Object}
				 */
				"Contract": {
					"lookupListConfig": {
						"columns": ["Account", "Product", "ContactContract", "Package"],
						"filters": [
							{
								method: function() {
									return this.getContractFilter();
								}
							}
						]
					}
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.MultiLookupUtilitiesMixin#getLookupImageId
				 * @overridden
				 */
				getLookupImageId: function(columnName) {
					var lookupImageId = "";
					var columnsInfo = this.Terrasoft.configuration.ColumnsInfo;
					this.Terrasoft.each(columnsInfo, function(column, name) {
						if (name === columnName || (name === "Account" && columnName === "BankCardOwner")) {
							lookupImageId = column.ImageId;
							return false;
						}
					}, this);
					return lookupImageId;
				},

				/**
				 * Set Package visibility.
				 * @protected
				 * @param {function} callback - callback function.
				 * @param {Object} scope - execution context callback.
				 */
				onProductChanged: function(callback, scope) {
					var product = this.get("Product");
					if (this.Ext.isObject(product)) {
						this.getProductPackages(product.value, function(productPackages) {
							this.set("IsPackageVisible", productPackages && !productPackages.isEmpty());
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this);
							}
						}, this);
					} else {
						this.set("IsPackageVisible", false);
						this.set("Package", null);
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}
				},

				/**
				 * @inheritdoc Terrasoft.BankCardPageV2#onContractChange
				 * @overridden
				 */
				onContractChange: function() {
					this.callParent(arguments);
					var contract = this.get("Contract");
					if (this.Ext.isEmpty(contract)) {
						this.set("Client", null);
					} else {
						if (contract && contract.ContactContract) {
							this.setClient("Contact", contract.ContactContract);
						}
						if (contract && contract.Account) {
							this.setClient("BankCardOwner", contract.Account);
						}
					}
					this.set("Package", contract && contract.Package);
				},

				/**
				 * Sets "Client" field.
				 * @protected
				 * @param {function} column - name multilookup column.
				 * @param {Object} value - value multilookup column.
				 */
				setClient: function(column, value) {
					this.set("Client", {
						column: column,
						value: value.value,
						displayValue: value.displayValue
					});
				},

				/**
				 * Get packages by product.
				 * @protected
				 * @param {GUID} productId - Id of banking product.
				 * @param {function} callback - callback function.
				 * @param {Object} scope - execution context callback.
				 */
				getProductPackages: function(productId, callback, scope) {
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "ProductInPackage"
					});
					select.addColumn("Package");
					select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Product", productId));
					select.getEntityCollection(function(response) {
						var result;
						if (response.success) {
							result = response.collection;
						}
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this, result);
						}
					}, this);
				},

				/**
				 * Do actions, related with changes of card type.
				 * @protected
				 */
				onBankCardTypeChange: function() {
					var bankCardType = this.get("BankCardType");
					var isCreditCardType = false;
					if (!Ext.isEmpty(bankCardType)) {
						isCreditCardType = bankCardType.value === BankCustomerJourneyConstants.BankCardType.CREDIT;
						this.setCashLimitCaption(isCreditCardType);
					} else {
						this.set("RepayDate", null);
						this.set("CashLimitCaption", this.get("Resources.Strings.CreditCashLimitCaption"));
					}
					this.setRepayDateVisible(isCreditCardType);
				},

				/**
				 * Set RepayDate visibility.
				 * @protected
				 * @param {Bool} isCreditCardType - is selected Credit of card type.
				 */
				setRepayDateVisible: function(isCreditCardType) {
					this.set("IsRepayDateVisible", isCreditCardType);
				},

				/**
				 * Set CashLimit caption.
				 * @protected
				 * @param {Bool} isCreditCardType - is selected Credit of card type.
				 */
				setCashLimitCaption: function(isCreditCardType) {
					var cashLimitCaption = isCreditCardType
						? this.get("Resources.Strings.CreditCashLimitCaption")
						: this.get("Resources.Strings.DebitCashLimitCaption");
					this.set("CashLimitCaption", cashLimitCaption);
				},

				/**
				 * Returns a filter group to select the package of the selected product.
				 * @protected
				 * @return {Terrasoft.FilterGroup} Filter group.
				 */
				getPackageFilter: function() {
					var product = this.get("Product");
					var filters = this.Terrasoft.createFilterGroup();
					if (!this.Ext.isEmpty(product)) {
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"[ProductInPackage:Package:Id].Product", product.value));
					}
					return filters;
				},

				/**
				 * Returns a filter group to filter contracts by contact and product.
				 * @protected
				 * @return {Terrasoft.FilterGroup} Filter group.
				 */
				getContractFilter: function() {
					var contact = this.get("Contact");
					var product = this.get("Product");
					var filters = this.Terrasoft.createFilterGroup();
					if (!this.Ext.isEmpty(contact)) {
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "ContactContract", contact.value));
					}
					if (!this.Ext.isEmpty(product)) {
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Product", product.value));
					}
					return filters;
				},

				/**
				 * Gets is contract empty.
				 * @protected
				 * @return {Boolean} True, if contract is empty, otherwise false.
				 */
				isContractEmpty: function() {
					var contract = this.get("Contract");
					return this.Ext.isEmpty(contract);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.onProductChanged();
					this.onBankCardTypeChange();
					this.callParent(arguments);
				}
			}
		};
	}
);
