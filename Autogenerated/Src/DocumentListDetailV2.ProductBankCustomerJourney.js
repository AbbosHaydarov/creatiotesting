define("DocumentListDetailV2", ["ConfigurationEnums", "ConfigurationGrid", "ConfigurationGridGenerator",
    "ConfigurationGridUtilities"],
        function() {
	return {
		entitySchemaName: "DocumentList",
		attributes: {

			/**
			 * ######### ## ############### #######.
			 */
			IsEditable: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: true
			}
		},
		/**
		 * ######-####### (#######), ########### ################ ####### #####
		 */
		mixins: {
			ConfigurationGridUtilities: "Terrasoft.ConfigurationGridUtilities"
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"className": "Terrasoft.ConfigurationGrid",
					"generator": "ConfigurationGridGenerator.generatePartial",
					"generateControlsConfig": {"bindTo": "generateActiveRowControlsConfig"},
					"changeRow": {"bindTo": "changeRow"},
					"unSelectRow": {"bindTo": "unSelectRow"},
					"onGridClick": {"bindTo": "onGridClick"},
					"activeRowActions": [
						{
							"className": "Terrasoft.Button",
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"tag": "save",
							"markerValue": "save",
							"imageConfig": {"bindTo": "Resources.Images.SaveIcon"}
						},
						{
							"className": "Terrasoft.Button",
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"tag": "cancel",
							"markerValue": "cancel",
							"imageConfig": {"bindTo": "Resources.Images.CancelIcon"}
						},
						{
							"className": "Terrasoft.Button",
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"tag": "remove",
							"markerValue": "remove",
							"imageConfig": {"bindTo": "Resources.Images.RemoveIcon"}
						}
					],
					"listedZebra": true,
					"initActiveRowKeyMap": {"bindTo": "initActiveRowKeyMap"},
					"activeRowAction": {"bindTo": "onActiveRowAction"},
					"multiSelect": false,
					"type": "listed",
					"listedConfig": {
						"name": "DataGridListedConfig",
						"items": [
							{
								"name": "NameListedGridColumn",
								"caption": {"bindTo": "Resources.Strings.NameCaption"},
								"bindTo": "Name",
								"type": "text",
								"position": {
									"column": 0,
									"colSpan": 9
								}
							},
							{
								"name": "ParticipantRoleListedGridColumn",
								"caption": {"bindTo": "Resources.Strings.ParticipantRoleCaption"},
								"bindTo": "ParticipantRole",
								"type": "text",
								"position": {
									"column": 9,
									"colSpan": 6
								}
							},
							{
								"name": "DocumentListStageListedGridColumn",
								"caption": {"bindTo": "Resources.Strings.DocumentListStageCaption"},
								"bindTo": "DocumentListStage",
								"type": "text",
								"position": {
									"column": 15,
									"colSpan": 6
								}
							}
						]
					}
				}
			}
		]/**SCHEMA_DIFF*/,
		methods: {

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
			 * @overridden
			 */
			getDeleteRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @overridden
			 */
			getCopyRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @overridden
			 */
			getEditRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
			 * @overridden
			 */
			getSwitchGridModeMenuItem: this.Terrasoft.emptyFn
		}
	};
});
