define("BaseFinApplicationPage", ["BusinessRuleModule", "Product", "VwFinActiveProduct", "BaseFinanceConstants",
		"css!FinApplicationCSS", "FinAppSpecificationFieldsDetail", "DocListInFinAppDetail", "FinApplicationProfileUtils"
	],
	function(BusinessRuleModule, Product, VwFinActiveProduct, BaseFinanceConstants) {
		return {
			entitySchemaName: "FinApplication",
			details: /**SCHEMA_DETAILS*/ {
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "FinApplicationFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "FinApplication"
					}
				},
				"Activities": {
					"schemaName": "ActivityDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "FinApplication"
					}
				},
				"Emails": {
					"schemaName": "EmailDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "FinApplication"
					}
				},
				"DocListInFinAppDetail": {
					"schemaName": "DocListInFinAppDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "FinApplication"
					}
				},
				"FinAppSpecificationFieldsDetail": {
					"schemaName": "FinAppSpecificationFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "FinApplication"
					},
					"defaultValues": {
						"FinApplication": {
							"masterColumn": "FinApplication"
						}
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			messages: {
				/**
				 * @message SetDetailCollapsed
				 */
				"SetDetailCollapsed": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message GenerateProductSpecification
				 */
				"GenerateProductSpecification": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message ConfirmRegenerateProductSpecification
				 */
				"ConfirmRegenerateProductSpecification": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			mixins: {
				FinApplicationProfileUtils: "Terrasoft.FinApplicationProfileUtils"
			},
			rules: {
				"Package": {
					"VisiblePackageInProduct": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "IsPackageInProductExists"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						}]
					}
				},
				"ActiveProduct": {
					"BindParameterEnabledProductToContract": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "Contract"
							},
							"comparisonType": this.Terrasoft.ComparisonType.IS_NULL
						}]
					}
				},
				"ProductType": {
					"ProductTypeByProductCategory": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"autoClean": true,
						"baseAttributePatch": "Category",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "ProductCategory"
					}
				},
				"Contract": {
					"ContractByProduct": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "Product",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Product"
					},
					"ContractByContact": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "ContactContract",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Contact"
					},
					"ContractByAccount": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "Account",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Account"
					},
					"BindParameterEnabledContractToProductAndClient": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"logical": this.Terrasoft.LogicalOperatorType.AND,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "Product"
							},
							"comparisonType": this.Terrasoft.ComparisonType.IS_NOT_NULL
						}, {
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "Client"
							},
							"comparisonType": this.Terrasoft.ComparisonType.IS_NOT_NULL
						}]
					}
				},
				"Client": {
					"BindParameterEnabledClientToContract": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "Contract"
							},
							"comparisonType": this.Terrasoft.ComparisonType.IS_NULL
						}]
					}
				}
			},
			attributes: {
				/**
				 * Information message with type and category of the current product.
				 * @type {String}
				 */
				"InfoMessage": {
					dataValueType: Terrasoft.DataValueType.TEXT
				},

				/**
				 * Product in application.
				 * @type {Object}
				 */
				"Product": {
					lookupListConfig: {
						columns: ["Category", "Type", "[ProductInPackage:Product:Id].Id"]
					}
				},

				/**
				 * The sign that the product have records on package products detail.
				 * @type {Boolean}
				 */
				"IsPackageInProductExists": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},

				/**
				 * Product package.
				 * @type {Object}
				 */
				"Package": {
					lookupListConfig: {
						filter: function() {
							var product = this.get("Product");
							return this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "[ProductInPackage:Package:Id].Product",
								product && product.value);
						}
					}
				},

				/**
				 * FinApplication product in profile.
				 */
				"FinAppProduct": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isLookup": true,
					"referenceSchema": Product,
					"referenceSchemaName": "Product"
				},
				/**
				 * Active product.
				 */
				"ActiveProduct": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isLookup": true,
					"referenceSchema": VwFinActiveProduct,
					"referenceSchemaName": "VwFinActiveProduct",
					"lookupListConfig": {
						"columns": ["Product", "Product.Category", "Product.Type", "OpportunityCondition",
							"Product.ProductStatus", "Product.Name"
						],
						"filter": function() {
							return this.getActiveProductLookupFilter();
						}
					},
					"dependencies": [{
						"columns": ["ActiveProduct"],
						"methodName": "onActiveProductChange"
					}]
				},
				/**
				 * Profile Info product.
				 */
				"ProfileInfoCollection": {
					"dataValueType": Terrasoft.DataValueType.COLLECTION
				},
				/**
				 * Generates update amount with actual currency info.
				 */
				"FinAppAmountGenerator": {
					"dependencies": [{
						"columns": ["FinAppAmount", "FinAppCurrency"],
						"methodName": "updateAmount"
					}]
				},
				/**
				 * Profile Info product. Amount with currency.
				 */
				"FinAppAmountWithCurrency": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN

				},
				/**
				 * Profile Info product. Amount value.
				 */
				"FinAppAmount": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Profile Info product. Currency value.
				 */
				"FinAppCurrency": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Profile Info product. Term value.
				 */
				"FinAppTerm": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Borrower photo.
				 */
				"Photo": {
					"dataValueType": this.Terrasoft.DataValueType.IMAGE,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Caption of "Borrower" column.
				 */
				"BorrowerCaption": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Borrower lookup column.
				 */
				"Borrower": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"referenceSchemaName": "AppForm"
				},
				/**
				 * Column with "Branch" and "Division" column values.
				 */
				"BranchDivision": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				/**
				 * Handing of "Branch" column changing.
				 */
				"BranchChange": {
					"name": "Branch",
					"dependencies": [{
						"columns": ["Branch"],
						"methodName": "initBranchDivision"
					}]
				},
				/**
				 * Handing of "Division" column changing.
				 */
				"DivisionChange": {
					"name": "Division",
					"dependencies": [{
						"columns": ["Division"],
						"methodName": "initBranchDivision"
					}]
				},
				/**
				 * Handing of "ProductCategory" column changing.
				 */
				"ProductCategory": {
					"name": "ProductCategory",
					"dependencies": [{
						"columns": ["ProductCategory"],
						"methodName": "updateProductInfoMessage"
					}]
				},
				/**
				 * Handing of "ProductType" column changing.
				 */
				"ProductType": {
					"name": "ProductType",
					"dependencies": [{
						"columns": ["ProductType"],
						"methodName": "updateProductInfoMessage"
					}]
				},
				/**
				 * Owner column in profile.
				 */
				"OwnerInProfile": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isLookup": true,
					"referenceSchemaName": "Contact"
				},
				/**
				 * Filling date column in profile.
				 */
				"FillingDateInProfile": {
					"dataValueType": this.Terrasoft.DataValueType.DATE,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Client attribute ("Contact" or "Account" field).
				 */
				"Client": {
					"caption": {
						"bindTo": "Resources.Strings.ClientCaption"
					},
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"multiLookupColumns": ["Contact", "Account"]
				}
			},
			methods: {
				//region Methods: Private

				/**
				 * Returns filter group for Actual product.
				 * @private
				 * @return {Terrasoft.FilterGroup} Group of filters for Actual product lookup list.
				 */
				getActiveProductLookupFilter: function() {
					var filters = this.Terrasoft.createFilterGroup();
					var productType = this.get("ProductType");
					var productCategory = this.get("ProductCategory");
					if (this.Ext.isObject(productType)) {
						var productTypeFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
							"Product.Type", productType.value);
						filters.add("TypeFilter", productTypeFilter);
					}
					if (this.Ext.isObject(productCategory)) {
						var productCategoryFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
							"Product.Category", productCategory.value);
						filters.add("CategoryFilter", productCategoryFilter);
					}
					var productStatusFilter = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"Product.ProductStatus", BaseFinanceConstants.ProductStatus.IsActual);
					filters.add("StatusFilter", productStatusFilter);
					return filters;
				},

				/**
				 * Sets Number value.
				 * @private
				 */
				initNumber: function() {
					if (this.isAddMode() || this.isCopyMode()) {
						this.getIncrementCode(function(response) {
							this.set("Number", response);
						});
					}
				},

				/**
				 * Checks if any amount value exist to show.
				 * @private
				 * @return {Boolean} true is FinAppAmountWithCurrency set.
				 */
				getAmountVisible: function() {
					return !this.Ext.isEmpty(this.get("FinAppAmountWithCurrency"));
				},

				/**
				 * Returns product icon link.
				 * @private
				 * @return {String} Product lunk url.
				 */
				getProductIcon: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.FinAppProductIcon"));
				},

				/**
				 * Checks if any term value exist to show.
				 * @private
				 * @return {Boolean} true is FinAppTerm set.
				 */
				getTermVisible: function() {
					return !this.Ext.isEmpty(this.get("FinAppTerm"));
				},

				/**
				 * Sets BranchDivision value.
				 * @private
				 */
				initBranchDivision: function() {
					var branch = this.get("Branch");
					var division = this.get("Division");
					var branchDivision = branch ? branch.displayValue : "";
					division = division ? division.displayValue : "";
					if (!this.Ext.isEmpty(division)) {
						branchDivision += !this.Ext.isEmpty(branchDivision) ? "/" + division : division;
					}
					this.set("BranchDivision", branchDivision);
				},

				/**
				 * Updates product category value and product type value by product.
				 * @private
				 * @param {Object} product Selected product.
				 */
				updateProductParameters: function(product) {
					if (this.get("IsEntityInitialized")) {
						var productCategory = product ? product.Category : null;
						var productType = product ? product.Type : null;
						var fiAppProductCategory = this.get("ProductCategory");
						var fiAppProductType = this.get("ProductType");
						if (this.Ext.isEmpty(product) && (fiAppProductCategory || fiAppProductType)) {
							this.showConfirmationDialog(this.get("Resources.Strings.ClearProductParametersDialog"),
								function(returnCode) {
									if (returnCode === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
										this.clearProductParameters();
										this.setIsCategoryTypeVisible();
									}
								}, [this.Terrasoft.MessageBoxButtons.NO.returnCode,
									this.Terrasoft.MessageBoxButtons.YES.returnCode
								], null
							);
						} else {
							this.set("ProductCategory", productCategory);
							this.set("ProductType", productType);
							this.changedValues["ProductCategory"] = productCategory;
							this.changedValues["ProductType"] = productType;
						}
					}
				},

				/**
				 * Clears product category value and product type value.
				 * @private
				 */
				clearProductParameters: function() {
					this.set("ProductType", null);
					this.set("ProductCategory", null);
				},

				/**
				 * Sets collapsed detail.
				 * @private
				 * @param {String} detailName Detail name.
				 * @param {Boolean} isCollapsed Flag is detail collapsed.
				 */
				setDetailCollapsed: function(detailName, isCollapsed) {
					this.sandbox.publish("SetDetailCollapsed", isCollapsed, [this.getDetailId(detailName)]);
				},

				/**
				 * Sets ProductCategory and ProductType fields visibility.
				 * @private
				 */
				setIsCategoryTypeVisible: function() {
					var productCategory = this.get("ProductCategory");
					var productType = this.get("ProductType");
					var isCategoryTypeVisible = this.Ext.isEmpty(productCategory) || this.Ext.isEmpty(productType);
					this.set("IsCategoryTypeVisible", isCategoryTypeVisible);
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1616);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.initBranchDivision();
					this.initActiveProduct();
					this.setIsCategoryTypeVisible();
					this.initNumber();
					this.onProductChanged();
					this.callParent(arguments);
					this.subscribeOnColumnChange("Product", this.onProductChanged);
				},

				/**
				 * Sets the information message and sign that the product have records on package products detail.
				 * @protected
				 */
				onProductChanged: function() {
					var product = this.get("Product");
					this.updateProductParameters(product);
					this.updateProductInfoMessage();
					if (product) {
						if (this.get("IsEntityInitialized")) {
							this.changedValues["Product"] = product;
						}
						if (!product.Type) {
							return;
						}
					} else {
						if (this.get("IsEntityInitialized")) {
							this.set("OpportunityCondition", null);
						}
						if (product === "") {
							this.set("Product", null, {
								silent: true
							});
						}
					}
					this.setDetailCollapsed("FinAppSpecificationFieldsDetail", this.Ext.isEmpty(product));
					this.updatePageHeaderCaption();
					this.initFinAppValues();
				},

				/**
				 * Sets product tip.
				 * @protected
				 */
				updateProductInfoMessage: function() {
					var productType = this.get("ProductType") || {};
					var productTypeCaption = productType.displayValue || "";
					var productCategory = this.get("ProductCategory") || {};
					var productCategoryCaption = productCategory.displayValue || "";
					if (productCategoryCaption && productTypeCaption) {
						var message = this.Ext.String.format(this.get("Resources.Strings.InformationMessage"),
							productCategoryCaption, productTypeCaption);
						this.set("InfoMessage", message);
					} else {
						this.set("InfoMessage", "");
					}
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BaseSchemaModuleV2#destroy
				 * @overridden
				 */
				destroy: function() {
					this.unsubscribeOnColumnChange("Product", this.onProductChanged);
					this.callParent(arguments);
				},

				/**
				 * Active product value change event handler.
				 * @protected
				 */
				onActiveProductChange: function() {
					var activeProduct = this.get("ActiveProduct");
					if (!this.Ext.isEmpty(activeProduct)) {
						var product = activeProduct.Product;
						if (this.Ext.isEmpty(product)) {
							return;
						}
						var productCategory = activeProduct["Product.Category"];
						var productType = activeProduct["Product.Type"];
						var opportunityCondition = activeProduct.OpportunityCondition;
						product.displayValue = activeProduct["Product.Name"];
						product.Category = productCategory;
						product.Type = productType;
						this.set("Product", product);
						this.set("OpportunityCondition", opportunityCondition);
						this.sandbox.publish("GenerateProductSpecification", null, [this.getDetailId("FinAppSpecificationFieldsDetail")]);
					} else {
						this.set("Product", null);
					}
				},

				/**
				 * Checks whether the contract specified.
				 * @protected
				 * @return {Boolean} True, if the contract field is not filled.
				 */
				isContractEmpty: function() {
					var contract = this.get("Contract");
					return this.Ext.isEmpty(contract);
				},

				/**
				 * Gets the object with the desired properties for product obtained from the object of the contract.
				 * @protected
				 * @param {Object} contract Object of contract.
				 * @return {Object} Object of product.
				 */
				getProductFromContract: function(contract) {
					var productCategory = contract["[Product:Id:Product].Category"];
					var productType = contract["[Product:Id:Product].Type"];
					var packageInProduct = contract["[ProductInPackage:Product:Product].Id"];
					var product = contract.Product;
					product.Category = productCategory;
					product.Type = productType;
					product["[ProductInPackage:Product:Id].Id"] = packageInProduct;
					return product;
				},

				/**
				 * Inits Active product value.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				initActiveProduct: function(callback, scope) {
					var product = this.get("Product");
					var opportunityCondition = this.get("OpportunityCondition");
					if (!this.Ext.isEmpty(product)) {
						var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "VwFinActiveProduct"
						});
						esq.rowCount = 1;
						esq.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
						esq.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
						esq.filters.add("ProductId", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Product", product.value));
						if (!this.Ext.isEmpty(opportunityCondition)) {
							esq.filters.add("OpportunityCondition", this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "OpportunityCondition", opportunityCondition.value));
						} else {
							esq.filters.add("OpportunityConditionNull",
								esq.createColumnIsNullFilter("OpportunityCondition"));
						}
						esq.getEntityCollection(function(response) {
							this.initActiveProductCallback(callback, scope, response);
						}, this);
					} else {
						this.Ext.callback(callback, scope);
					}
				},

				/**
				 * Sets Active product value.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 * @param {Object} response Response object.
				 */
				initActiveProductCallback: function(callback, scope, response) {
					var product = this.get("Product");
					if (response.success) {
						var responseCollection = response.collection;
						var activeProduct = {
							value: "",
							displayValue: ""
						};
						if (!responseCollection.isEmpty()) {
							var item = responseCollection.first();
							activeProduct.value = item.get("Id");
							activeProduct.displayValue = item.get("Name");
						} else {
							activeProduct.value = product.value;
							activeProduct.displayValue = product.displayValue;
						}
						this.set("ActiveProduct", activeProduct);
						this.Ext.callback(callback, scope);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overridden
				 */
				onSaved: function() {
					this.callParent(arguments);
					this.initFinAppValues();
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#getPageHeaderCaption
				 * @overridden
				 */
				getPageHeaderCaption: function() {
					var caption = this.get("Resources.Strings.ApplicationCaptionTemplate");
					var number = this.get("Number");
					caption += !this.Ext.isEmpty(number) ? number : "";
					var pageCaptionTemplateEnding = this.get("Resources.Strings.ApplicationCaptionTemplateEnding");
					var product = this.get("Product");
					var productType = product && product.Type;
					var productTypeCaption = productType && productType.displayValue;
					if (!this.Ext.isEmpty(productTypeCaption) && !this.Ext.isEmpty(number)) {
						caption += this.Ext.String.format(pageCaptionTemplateEnding, productTypeCaption);
					}
					return caption;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onLookupResult
				 * @overridden
				 */
				onLookupResult: function(args) {
					var columnName = args.columnName;
					var selectedRows = args.selectedRows;
					if (columnName !== "ActiveProduct" || selectedRows.isEmpty()) {
						this.callParent(arguments);
					} else {
						this.sandbox.publish("ConfirmRegenerateProductSpecification", {
							callback: this.onLookupResultCallback,
							columnName: columnName,
							columnValue: selectedRows.first(),
							scope: this
						}, [this.getDetailId("FinAppSpecificationFieldsDetail")]);
					}
				},

				/**
				 * Sets Active product value from lookup.
				 * @protected
				 * @param {Object} selectResult The result of the selection of the lookup window.
				 * @param {Object} selectResult.scope Execution context.
				 * @param {String} selectResult.columnName Name of changed column.
				 * @param {Object} selectResult.columnValue Value for change column.
				 */
				onLookupResultCallback: function(selectResult) {
					var columnName = selectResult.columnName;
					var columnValue = selectResult.columnValue;
					this.set(columnName, columnValue);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#getDetailInfo
				 * @overridden
				 */
				getDetailInfo: function() {
					var result = this.callParent(arguments);
					return Ext.apply({}, {
						"product": this.get("Product"),
						"opportunityCondition": this.get("OpportunityCondition")
					}, result);
				},

				/**
				 * @inheritdoc Terrasoft.configuration.mixins.FinApplicationProfileUtils#getFinApplicationConfig
				 * @overridden
				 */
				getFinApplicationConfig: function() {
					var finApplicationId = this.get(this.primaryColumnName);
					if (this.Ext.isEmpty(finApplicationId)) {
						return;
					}
					return {
						"finApplication": {
							value: finApplicationId
						},
						"product": this.get("Product")
					};
				}

				//endregion
			},
			diff: /**SCHEMA_DIFF*/ [{
					"operation": "insert",
					"name": "SelectedProductTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.SelectedProductTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "ParticipantsAndDocumentsTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.ParticipantsAndDocumentsTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "HistoryTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.HistoryTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "HistoryTabFirstControlGroup",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": []
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "HistoryTabFirstGridLayout",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "HistoryTabFirstControlGroup",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "GeneralInfoTabFakeContainer",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 2,
					"alias": {
						"name": "GeneralInfoTab"
					}
				},
				{
					"operation": "insert",
					"name": "Client",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"controlConfig": {
							"enableLeftIcon": true,
							"leftIconConfig": {
								"bindTo": "getMultiLookupIconConfig"
							}
						}
					},
					"parentName": "HistoryTabFirstGridLayout",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Contract",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Contract"
					},
					"parentName": "HistoryTabFirstGridLayout",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "FillingDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "HistoryTabFirstGridLayout",
					"propertyName": "items"
				}, {
					"operation": "insert",
					"name": "EndDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "HistoryTabFirstGridLayout",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "HistoryTabControlGroup",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 1,
					"alias": {
						"name": "GeneralInfoControlGroup"
					}
				},
				{
					"operation": "insert",
					"name": "HistoryTabGridLayout",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "HistoryTabControlGroup",
					"propertyName": "items",
					"alias": {
						"name": "GeneralInfoGridLayout"
					}
				},
				{
					"operation": "insert",
					"name": "Status",
					"values": {
						"contentType": Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "HistoryTabGridLayout",
					"propertyName": "items"
				}, {
					"operation": "insert",
					"name": "Owner",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "HistoryTabGridLayout",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Division",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "HistoryTabGridLayout",
					"propertyName": "items"
				}, {
					"operation": "insert",
					"name": "Branch",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "HistoryTabGridLayout",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "NotesAndFilesTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.FinApplicationFilesTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 3
				},
				{
					"operation": "move",
					"name": "ESNTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 10
				},
				{
					"operation": "insert",
					"name": "SelectedProductTabControlGroup",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					},
					"parentName": "SelectedProductTab",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"parentName": "SelectedProductTab",
					"propertyName": "items",
					"name": "FinAppSpecificationFieldsDetail",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "ParticipantsAndDocumentsTab",
					"propertyName": "items",
					"name": "DocListInFinAppDetail",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"index": 1
				},
				{
					"operation": "insert",
					"name": "SelectedProductTabGridLayout",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "SelectedProductTabControlGroup",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Product",
					"values": {
						"markerValue": "ActiveProduct",
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "ActiveProduct",
						"caption": {
							"bindTo": "Resources.Strings.FinAppProductCaption"
						},
						"tip": {
							"content": {
								"bindTo": "InfoMessage"
							}
						}
					},
					"parentName": "SelectedProductTabGridLayout",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "ProductCategory",
					"parentName": "SelectedProductTabGridLayout",
					"propertyName": "items",
					"values": {
						"contentType": Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"visible": {
							"bindTo": "IsCategoryTypeVisible"
						}
					}
				},
				{
					"operation": "insert",
					"name": "ProductType",
					"parentName": "SelectedProductTabGridLayout",
					"propertyName": "items",
					"values": {
						"contentType": Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"visible": {
							"bindTo": "IsCategoryTypeVisible"
						}
					}
				},
				{
					"operation": "insert",
					"name": "Activities",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"name": "Emails",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "Files",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "NotesAndFilesTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "NotesControlGroup",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"caption": {
							"bindTo": "Resources.Strings.NotesGroupCaption"
						},
						"items": []
					},
					"parentName": "NotesAndFilesTab",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"parentName": "NotesControlGroup",
					"propertyName": "items",
					"name": "Notes",
					"values": {
						"contentType": Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"controlConfig": {
							"imageLoaded": {
								"bindTo": "insertImagesToNotes"
							},
							"images": {
								"bindTo": "NotesImagesCollection"
							}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"name": "AdditionalProfileInfoContainer",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"classes": {
							"wrapClassName": ["profile-container"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "FinAppProductContainer",
					"parentName": "FinAppAmountAndTermContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["product-container"],
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "ProductIcon",
					"parentName": "FinAppProductContainer",
					"propertyName": "items",
					"values": {
						"getSrcMethod": "getProductIcon",
						"readonly": true,
						"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
						"classes": {
							"wrapClass": ["product-icon"]
						}
					}
				}, {
					"operation": "insert",
					"name": "FinAppAmountAndTermContainer",
					"parentName": "AdditionalProfileInfoContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "FinAppProduct",
					"values": {
						"bindTo": "FinAppProduct",
						"wrapClass": ["product-lookup"],
						"caption": {
							"bindTo": "Resources.Strings.FinAppProductCaption"
						},
						"enabled": false
					},
					"parentName": "FinAppProductContainer",
					"propertyName": "items"
				}, {
					"operation": "insert",
					"name": "FinAppAmountContainer",
					"parentName": "FinAppAmountAndTermContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["profile-term-and-amount"],
						"visible": {
							"bindTo": "getAmountVisible"
						},
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "FinAppAmountCaptionContainer",
					"parentName": "FinAppAmountContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["profile-caption"],
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "FinAppAmountValueContainer",
					"parentName": "FinAppAmountContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "FinAppAmountCaptionLabel",
					"parentName": "FinAppAmountCaptionContainer",
					"propertyName": "items",
					"values": {
						"id": "FinAppAmountCaptionLabel",
						"labelClass": ["estimate-caption-label"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.FinAppAmountCaption"
						}
					},
					"index": 0
				}, {
					"operation": "insert",
					"name": "FinAppAmountValueLabel",
					"parentName": "FinAppAmountValueContainer",
					"propertyName": "items",
					"values": {
						"id": "FinAppAmountValueLabel",
						"labelClass": ["estimate-caption-label"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "FinAppAmountWithCurrency"
						}
					},
					"index": 1
				}, {
					"operation": "insert",
					"name": "FinAppTermContainer",
					"parentName": "FinAppAmountAndTermContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["profile-term-and-amount"],
						"items": [],
						"visible": {
							"bindTo": "getTermVisible"
						}
					}
				}, {
					"operation": "insert",
					"name": "FinAppTermCaptionContainer",
					"parentName": "FinAppTermContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["profile-caption"],
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "FinAppTermValueContainer",
					"parentName": "FinAppTermContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				}, {
					"operation": "insert",
					"name": "FinAppTermCaptionLabel",
					"parentName": "FinAppTermCaptionContainer",
					"propertyName": "items",
					"values": {
						"id": "FinAppTermCaptionLabel",
						"labelClass": ["estimate-caption-label"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.FinAppTermCaption"
						}
					},
					"index": 0
				}, {
					"operation": "insert",
					"name": "FinAppTermValueLabel",
					"parentName": "FinAppTermValueContainer",
					"propertyName": "items",
					"values": {
						"id": "FinAppTermValueLabel",
						"labelClass": ["estimate-caption-label"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "FinAppTerm"
						}
					},
					"index": 1
				},
				{
					"operation": "insert",
					"name": "BranchDivision",
					"parentName": "AdditionalProfileInfoContainer",
					"propertyName": "items",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.BranchDivisionCaption"
						},
						"layout": {
							"colSpan": 24,
							"rowSpan": 1,
							"column": 0,
							"row": 1
						},
						"enabled": false,
						"value": {
							"bindTo": "BranchDivision"
						}
					}
				}, {
					"operation": "insert",
					"name": "FillingDateInProfile",
					"parentName": "AdditionalProfileInfoContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "FillingDate",
						"layout": {
							"colSpan": 24,
							"rowSpan": 1,
							"column": 0,
							"row": 2
						},
						"enabled": false
					}
				}, {
					"operation": "insert",
					"name": "OwnerInProfile",
					"parentName": "AdditionalProfileInfoContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "Owner",
						"layout": {
							"colSpan": 24,
							"rowSpan": 1,
							"column": 0,
							"row": 3
						}
					}
				}, {
					"operation": "insert",
					"name": "Source",
					"parentName": "AdditionalProfileInfoContainer",
					"propertyName": "items",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"colSpan": 24,
							"rowSpan": 1,
							"column": 0,
							"row": 4
						}
					}
				}
			] /**SCHEMA_DIFF*/
		};
	});
