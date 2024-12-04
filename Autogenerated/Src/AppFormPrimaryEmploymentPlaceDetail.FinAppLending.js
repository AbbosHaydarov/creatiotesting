define("AppFormPrimaryEmploymentPlaceDetail", ["AppFormPrimaryEmploymentPlaceRowViewModel", "DetailEntityMappingMixin",
	"css!FinAppLendingCSS"],
	function() {
		return {
			entitySchemaName: "AppFormCareer",
			mixins: {
				DetailEntityMappingMixin: "Terrasoft.DetailEntityMappingMixin"
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "remove",
				"name": "AddRecordButton"
			}, {
				"operation": "merge",
				"name": "Detail",
				"values": {
					"classes": {
						"wrapClass": ["detail primary-employment-place-detail"]
					}
				}
			}],
			/**SCHEMA_DIFF*/
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
				 * @overridden
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.AppFormPrimaryEmploymentPlaceRowViewModel";
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#initDetailOptions
				 * @overridden
				 */
				getDisplayColumns: function() {
					return ["Employer", "LegalForm", "Industry", "BusinessPhone",
						"Role", "JobTitle", "YearsOfEmployment", "MonthOfEmployment"
					];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowContainerWrapClass
				 * @overridden
				 */
				getRowContainerWrapClass: function() {
					return ["primary-employment-place-field-detail-row"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getLeftRowContainerWrapClass
				 * @overridden
				 */
				getLeftRowContainerWrapClass: function() {
					return ["primary-employment-place-field-detail-row-left"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#useVirtualRecord
				 * @overridden
				 */
				useVirtualRecord: function() {
					return true;
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDeleteButtonConfig
				 * @overridden
				 */
				getDeleteButtonConfig: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getTypeColumnConfig
				 * @overridden
				 */
				getTypeColumnConfig: function() {
					return {
						name: "Primary",
						value: true
					};
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDetailRowItemsViewConfig
				 * @overridden
				 */
				getDetailRowItemsViewConfig: function() {
					var controlsGrid = {
						"name": "LeftFieldDetailRowContainer",
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [{
							"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
							"name": "Employer",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 0,
								"row": 0
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
							"name": "LegalForm",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 6,
								"row": 0
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
							"name": "Industry",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 12,
								"row": 0
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.TEXT,
							"name": "BusinessPhone",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 18,
								"row": 0
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
							"name": "Role",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 0,
								"row": 1
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
							"name": "JobTitle",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 6,
								"row": 1
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.INTEGER,
							"name": "YearsOfEmployment",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 12,
								"row": 1
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.INTEGER,
							"name": "MonthOfEmployment",
							"layout": {
								"colSpan": 6,
								"rowSpan": 1,
								"column": 18,
								"row": 1
							}
						}]
					};
					return [controlsGrid];
				},

				/**
				 * @inheritdoc Terrasoft.DetailEntityMappingMixin#onSetDetailMappingDataComplete
				 * @overridden
				 */
				onSetDetailMappingDataComplete: function() {
					var collection = this.getCollection();
					var newItemsCollection = collection.filter(function(item) {
						return !item.isDeleted;
					});
					if (newItemsCollection && newItemsCollection.isEmpty() && this.useVirtualRecord()) {
						this.addVirtualRecord();
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.initStateMixinMessages();
				}

				//endregion

			}
		};
	});
