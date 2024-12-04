define("RegDocumentPageV2", [], function() {
	return {
		entitySchemaName: "RegDocument",
		details: /**SCHEMA_DETAILS*/ {
			Files: {
				schemaName: "FileDetailV2",
				entitySchemaName: "RegDocumentFile",
				filter: {
					masterColumn: "Id",
					detailColumn: "RegDocument"
				}
			}
		} /**SCHEMA_DETAILS*/ ,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Citizenship",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Citizenship",
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "Series",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "Number",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "RegDocumentType",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "IssueDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "ValidUntil",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "IsPrimary",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "CodeDivision",
				"values": {
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "IssuedBy",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "NotesTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.NotesTabCaption"
					},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "NotesTab",
				"propertyName": "items",
				"name": "Files",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {
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
			 * @inheritdoc Terrasoft.BasePageV2#asyncValidate
			 * @overridden
			 */
			asyncValidate: function(callback, scope) {
				this.callParent([function(response) {
					if (!this.validateResponse(response)) {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this, response);
						}
						return;
					}
					Terrasoft.chain(
						function(next) {
							this.checkIsValidUntilGreaterIssueDate(function(response) {
								if (this.validateResponse(response)) {
									next();
								}
							}, this);
						},
						function(next) {
							if (this.get("IsPrimary")) {
								this.checkIsNotExistsPrimaryDocument(function(response) {
									if (this.validateResponse(response)) {
										next();
									}
								}, this);
							} else {
								next();
							}
						},
						function() {
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this, response);
							}
						}, this);
				}, this]);
			},

			/**
			 * Check is ValidUntil greater IssueDate.
			 * @private
			 * @param {Function} callback - callback function.
			 * @param {Object} scope - execution context callback.
			 */
			checkIsValidUntilGreaterIssueDate: function(callback, scope) {
				var result = {
					success: true
				};
				var startDate = this.get("IssueDate");
				var endDate = this.get("ValidUntil");
				var ext = this.Ext;
				if (ext.isDate(startDate) && ext.isDate(endDate)) {
					if (ext.Date.clearTime(startDate) > ext.Date.clearTime(endDate)) {
						Terrasoft.showInformation(this.get("Resources.Strings.IssueDateGreaterValidUntil"));
						result.success = false;
					}
				}
				if (ext.isFunction(callback)) {
					callback.call(scope || this, result);
				}
			},

			/**
			 * Check is not exist other primary document for current contact.
			 * @private
			 * @param {Function} callback - callback function.
			 * @param {Object} scope - execution context callback.
			 */
			checkIsNotExistsPrimaryDocument: function(callback, scope) {
				var esq = this.getPrimaryRegDocumentByContactQuery();
				esq.getEntityCollection(function(response) {
					this.processingResponse(response, callback, scope);
				}, scope);
			},

			/**
			 * Get other primary registration document by contact.
			 * @private
			 * @returns {Terrasoft.EntitySchemaQuery}
			 */
			getPrimaryRegDocumentByContactQuery: function() {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName
					});
				esq.addColumn("Id");
				esq.filters.addItem(Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "Contact", this.get("Contact").value));
				esq.filters.addItem(Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.NOT_EQUAL, "Id", this.get("Id")));
				esq.filters.addItem(Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "IsPrimary", true));
				return esq;
			},

			/**
			 * Processing of the query response primary registration document by contact.
			 * @private
			 * @param {Object} response - result qeury.
			 * @param {Function} callback - callback function.
			 * @param {Object} scope - execution context callback.
			 */
			processingResponse: function(response, callback, scope) {
				var result = {
						success: true
					};
				if (response.success && response.collection.getCount() > 0) {
					var contactName = this.get("Contact").displayValue;
					var messageText = scope.get("Resources.Strings.IsExistsOtherPrimaryDocument");
					var message = this.Ext.String.format(messageText, contactName);
					scope.showConfirmationDialog(message,
						function(returnCode) {
							if (returnCode === Terrasoft.MessageBoxButtons.NO.returnCode) {
								this.set("IsPrimary", false);
							}
							if (scope.Ext.isFunction(callback)) {
								callback.call(scope || this, result);
							}
						}, ["yes", "no"]);
				} else {
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this, result);
					}
				}
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#onSaved
			 * @overridden
			 */
			onSaved: function() {
				this.callParent(arguments);
				var updateConfig = this.getUpdateDetailOnSavedConfig();
				this.sandbox.publish("UpdateDetail", updateConfig, [this.sandbox.id]);
			}
		}
	};
});
