define("AppValidationChecklistDetail", ["css!FinAppLendingCSS", "AppValidationChecklistRowViewModel"],
	function() {
		return {
			entitySchemaName: "AppValQuestionResult",
			attributes: {},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"name": "Detail",
				"values": {
					"classes": {
						"wrapClass": ["detail appvalidation-checklist-fields-detail"]
					}
				}
			}],
			/**SCHEMA_DIFF*/
			messages: {},
			methods: {

				//region Properties: Protected

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDeleteButtonConfig
				 * @overridden
				 */
				getDeleteButtonConfig: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseDetail#getToolsVisible
				 * @overridden
				 */
				getToolsVisible: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getRowViewModelClassName
				 * @overridden
				 */
				getRowViewModelClassName: function() {
					return "Terrasoft.AppValidationChecklistRowViewModel";
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDisplayColumns
				 * @overridden
				 */
				getDisplayColumns: function() {
					return ["Question", "AppValidationAnswer", "Description", "IsRequired"];
				},

				/**
				 * @inheritdoc Terrasoft.BaseFieldsDetail#getDetailRowItemsViewConfig
				 * @overridden
				 */
				getDetailRowItemsViewConfig: function() {
					var controlsGrid = [{
							"dataValueType": this.Terrasoft.DataValueType.ENUM,
							"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
							"name": "AppValidationAnswer",
							"isRequired": {
								"bindTo": "IsRequired"
							},
							"caption": {
								"bindTo": "Question"
							}
						}, {
							"dataValueType": this.Terrasoft.DataValueType.TEXT,
							"itemType": this.Terrasoft.ViewItemType.MODEL_ITEM,
							"contentType": this.Terrasoft.ContentType.LONG_TEXT,
							"name": "Description",
							"wrapClass": ["memo-edit-input"],
							"visible": {
								"bindTo": "DescriptionVisible"
							},
							labelConfig: {
								visible: false
							}
						}];
					return controlsGrid;
				}

				//endregion
			}
		};
	});
