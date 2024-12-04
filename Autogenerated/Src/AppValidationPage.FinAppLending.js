define("AppValidationPage", ["BusinessRuleModule", "ConfigurationConstants",
		"BaseFiltersGenerateModule", "HtmlEditModule", "ConfigurationFileApi", "AppValidationUtilities", "AppValFileDetail"
	],
	function(BusinessRuleModule, ConfigurationConstants, BaseFiltersGenerateModule) {
		return {
			entitySchemaName: "AppValidation",
			details: /**SCHEMA_DETAILS*/ {
				"Files": {
					"schemaName": "AppValFileDetail",
					"entitySchemaName": "AppValidationItemFile",
					"filter": {
						"masterColumn": "ValidationItem",
						"detailColumn": "AppValidationItem"
					}
				},
				"CheckListResult": {
					"schemaName": "AppValQuestionResultDetail",
					"entitySchemaName": "AppValQuestionResult",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppValidation"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			mixins: {
				AppValidationUtilities: "Terrasoft.AppValidationUtilities"
			},
			attributes: {
				"Role": {
					"lookupListConfig": {
						filter: function() {
							return this.getRoleLookupFilter();
						}
					}
				},
				"Owner": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						filter: BaseFiltersGenerateModule.OwnerFilter
					},
					"dependencies": [{
						"columns": ["Owner"],
						"methodName": "onOwnerChange"
					}]
				},
				"AppValidationItemScenery": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"ValidationItem": {
					"lookupListConfig": {
						"columns": ["Scenery"]
					},
					"dependencies": [{
						"columns": ["ValidationItem"],
						"methodName": "onValidationItemChange"
					}]
				},
				"ValidationResult": {
					"dependencies": [{
						"columns": ["ValidationResult"],
						"methodName": "onValidationResultChange"
					}]
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * Returns filter group to get only "Owner" contact roles, or all roles, if no "Owner" is set.
				 * @private
				 * @return {Terrasoft.FilterGroup} Group of filters for Role lookup list.
				 */
				getRoleLookupFilter: function() {
					var sysAdminUnitTypes = [
						ConfigurationConstants.SysAdminUnit.Type.Organisation,
						ConfigurationConstants.SysAdminUnit.Type.Department,
						ConfigurationConstants.SysAdminUnit.Type.Team,
						ConfigurationConstants.SysAdminUnit.Type.FuncRole
					];
					var filters = this.Terrasoft.createFilterGroup();
					var columnInFilter = this.Terrasoft.createColumnInFilterWithParameters("SysAdminUnitTypeValue", sysAdminUnitTypes);
					filters.add("TypeFilter", columnInFilter);
					var selectedUser = this.get("Owner");
					if (this.Ext.isObject(selectedUser)) {
						var roleFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"[SysUserInRole:SysRole:Id].SysUser.Contact",
							selectedUser.value
						);
						filters.add("CurrentOwnerRoleFilter", roleFilter);
					}
					return filters;
				},

				/**
				 * Sets Entity schema query filters.
				 * @private
				 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
				 * @param {String} columnName The name of column.
				 */
				setAppValidationResultESQFilters: function(filters, columnName) {
					var allowedResult = this.get("AllowedResult");
					if (columnName === "ValidationResult" && this.Ext.isArray(allowedResult)) {
						var idFilter = this.Terrasoft.createColumnInFilterWithParameters("Id", allowedResult);
						filters.add("IdFilter", idFilter);
					}
				},

				/**
				 * Handles "ValidationItem" property change.
				 * @private
				 */
				onValidationItemChange: function() {
					var validationItem = this.get("ValidationItem") || {};
					this.set("AppValidationItemScenery", validationItem.Scenery);
					this.updateDetails();
				},

				/**
				 * Handles "Owner" property change.
				 * @private
				 */
				onOwnerChange: function() {
					var selectedUser = this.get("Owner");
					if (this.Ext.isEmpty(selectedUser)) {
						this.set("Role", null);
						this.set("ValidationDate", null);
						return;
					}
					var query = this.getContactRoleESQ(selectedUser.value);
					query.getEntityCollection(this.parseRoleCallback, this);
				},

				/**
				 * Generates ESQ to get given contact roles.
				 * @protected
				 * @param {String} contactUId of the user contact.
				 * @return {Terrasoft.EntitySchemaQuery} generated query to get contact roles.
				 */
				getContactRoleESQ: function(contactUId) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SysUserInRole"
					});
					esq.addColumn("[SysAdminUnit:Id:SysRole].Id", "RoleId");
					esq.addColumn("[SysAdminUnit:Id:SysRole].Name", "RoleName");
					esq.filters.add("CurrentOwnerRoleFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"[SysAdminUnit:Id:SysUser].Contact",
						contactUId
					));
					return esq;
				},

				/**
				 * Callback to ESQ to check if role single, and if it is, sets it to the "Role" field.
				 * @protected
				 * @param {Object} response ESQ result response.
				 */
				parseRoleCallback: function(response) {
					response = response || {};
					var collection = response.collection;
					var role;
					if (response.success && collection.getCount() === 1) {
						var entity = collection.first();
						role = {
							"value": entity.get("RoleId"),
							"displayValue": entity.get("RoleName")
						};
					}
					this.set("Role", role);
				},

				/**
				 * Handles "ValidationResult" property change.
				 * @private
				 */
				onValidationResultChange: function() {
					var validationResult = this.get("ValidationResult");
					if (this.Ext.isEmpty(validationResult)) {
						this.set("ValidationDate", null);
						this.set("Owner", null);
						return;
					}
					this.set("ValidationDate", this.Ext.Date.clearTime(new Date()));
					var currentContact = this.Terrasoft.SysValue.CURRENT_USER_CONTACT;
					this.set("Owner", currentContact);
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.onValidationItemChange();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initEntity
				 * @overridden
				 */
				initEntity: function(callback, scope) {
					this.callParent([function() {
						this.initAllowedResult(callback, scope);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
				 * @overridden
				 */
				getLookupQuery: function(filterValue, columnName) {
					var esq = this.callParent(arguments);
					this.setAppValidationResultESQFilters(esq.filters, columnName);
					return esq;
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "ValidationItem",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "ValidationItem"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "ValidationResult",
				"values": {
					"dataValueType": this.Terrasoft.DataValueType.ENUM,
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "Header"
					},
					"bindTo": "ValidationResult"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"name": "Role",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1,
						"layoutName": "Header"
					},
					"bindTo": "Role"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "ValidationDate",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "Header"
					},
					"bindTo": "ValidationDate"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Owner",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 2,
						"layoutName": "Header"
					},
					"bindTo": "Owner"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "ParticipantRole",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 3,
						"layoutName": "Header"
					},
					"bindTo": "ParticipantRole"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Participant",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 4,
						"layoutName": "Header"
					},
					"bindTo": "Participant"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Comment",
				"values": {
					"contentType": this.Terrasoft.ContentType.LONG_TEXT,
					"layout": {
						"colSpan": 12,
						"rowSpan": 2,
						"column": 0,
						"row": 3,
						"layoutName": "Header"
					},
					"bindTo": "Comment"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "CheckListTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.CheckListTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "SceneryTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.SceneryTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "SceneryTab",
				"propertyName": "items",
				"name": "AppValidationItemScenery",
				"values": {
					"contentType": this.Terrasoft.ContentType.RICH_TEXT,
					"enabled": false,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					}
				}
			}, {
				"operation": "insert",
				"name": "FilesTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.FilesTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "Files",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "FilesTab",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "CheckListResult",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "CheckListTab",
				"propertyName": "items"
			}] /**SCHEMA_DIFF*/ ,
			rules: {
				"Participant": {
					"ParticipantByFinApplication": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "FinApplication",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "FinApplication"
					},
					"ParticipantByParticipantRole": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "ParticipantRole",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "ParticipantRole"
					}
				}
			}
		};
	});
