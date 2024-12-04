define("AppFormDetail", [],
	function() {
		return {
			attributes: {
				/**
				 * Add button elements collection.
				 */
				"AddButtonMenuItems": {
					"dataValueType": this.Terrasoft.DataValueType.COLLECTION
				},
				/**
				 * AppForm roles collection.
				 */
				"ParticipantRoles": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": this.Terrasoft.DataValueType.COLLECTION
				}
			},
			entitySchemaName: "AppForm",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "AddRecordButton"
				}, {
					"operation": "merge",
					"name": "AddTypedRecordButton",
					"parentName": "Detail",
					"propertyName": "tools",
					"values": {
						"visible": true,
						"controlConfig": {
							"menu": {
								"items": {
									"bindTo": "AddButtonMenuItems"
								}
							}
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {

				//region Methods: Protected

				/**
				 * Returns add menu item based on participant role type.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} item ParticipantRoles collection item.
				 * @return {Terrasoft.BaseViewModel} ParticipantRole viewModel.
				 */
				getAddButtonMenuItem: function(item) {
					var name = item.get("Name");
					var value = item.get("Id");
					return this.Ext.create("Terrasoft.BaseModel", {
						values: {
							Id: value,
							Caption: name,
							MarkerValue: name,
							Tag: {
								name: "ParticipantRole",
								displayValue: name,
								value: value
							},
							Click: {
								bindTo: "addRecord"
							}
						}
					});
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addRecord
				 * @overridden
				 */
				addRecord: function(tag) {
					this.updateDefaultValues(tag);
					this.callParent(arguments);
				},

				/**
				 * Updates DefaultValues array with actual value.
				 * @protected
				 * @virtual
				 * */
				updateDefaultValues: function(tag) {
					var defValues = this.get("DefaultValues");
					if (!tag) {
						return;
					}
					var comparisonProperty = "name";
					var foundItem = this.Ext.Array.findBy(defValues, function(item) {
						return item[comparisonProperty] === tag[comparisonProperty];
					}, this);
					if (foundItem) {
						var foundIndex =  this.Ext.Array.indexOf(defValues, foundItem, this);
						defValues[foundIndex] = tag;
					} else {
						defValues.push(tag);
					}
				},

				/**
				 * Initialise add button menu items.
				 * @protected
				 */
				initAddButtonMenuItems: function() {
					var menuItems = this.Ext.create("Terrasoft.Collection");
					var participantRoles = this.get("ParticipantRoles");
					participantRoles.each(function(item) {
						var menuItem = this.getAddButtonMenuItem(item);
						menuItems.add(menuItem);
					}, this);
					this.set("AddButtonMenuItems", menuItems);
				},

				/**
				 * Initialise application form role items collection.
				 * @protected
				 * @param {Function} callback callback function.
				 * @param {Object} scope Execution context.
				 */
				initParticipantRoles: function(callback, scope) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "ParticipantRole"
					});
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					var nameColumn = esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
					nameColumn.orderDirection = this.Terrasoft.OrderDirection.ASC;
					esq.getEntityCollection(function(response) {
						if (response.success) {
							var entityCollection = response.collection;
							this.set("ParticipantRoles", entityCollection);
						}
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.initParticipantRoles(function() {
							this.initAddButtonMenuItems();
							this.Ext.callback(callback, scope);
						}, this);
					}, this]);
				}

				//endregion
			}
		};
	});
