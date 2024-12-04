 /**
 * Parent: ProcessElementParametersMappingPage
 */
define("CompositeObjectConfigurationPage", [
	"CompositeObjectConfigurationPageResources",
	"css!CompositeObjectConfigurationPage"
], function() {
	return {
		attributes: {

			/**
			 * Flow element name.
			 * @type {Terrasoft.dataValueType.TEXT}
			 */
			"FlowElementName": {
				dataValueType: this.Terrasoft.DataValueType.TEXT,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Flow element parameters data.
			 */
			"FlowElementParametersData": {
				dataValueType: this.Terrasoft.DataValueType.COLLECTION,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Array of selected element parameters.
			 */
			"SelectedElementParameters": {
				dataValueType: this.Terrasoft.DataValueType.COLLECTION,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Name of the already mapped element.
			 */
			"MappedElementName": {
				dataValueType: this.Terrasoft.DataValueType.TEXT,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Collection of the already mapped element parameters.
			 */
			"MappedElementParameters": {
				dataValueType: this.Terrasoft.DataValueType.COLLECTION,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * The unique identifier of the composite object parameter the element parameters are mapped to. 
			 */
			"MappedToParameterUId": {
				dataValueType: this.Terrasoft.DataValueType.TEXT,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Determines whether the select all checkbox is checked or not.
			 */
			"SelectAllChecked": {
				dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: false
			}
		},
		messages: {},
		properties: {},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BaseParametersMappingPage#init
			 * @overridden
			 */
			init: function(callback) {
				this.callParent([function() {
					this.$FlowElementParametersData = Ext.create("Terrasoft.Collection");
					this.$SelectedElementParameters = [];
					this.on("change:SelectedElementParameters", this._onSelectedElementParametersChange, this);
					this.on("change:SelectAllChecked", this._onSelectDeselectChecked, this);
					callback.call(this);
				}, this]);
			},

			/**
			 * @inheritdoc Terrasoft.ProcessElementParametersMappingPage#onSelectFlowElement
			 * @overridden
			 */
			onSelectFlowElement: function(flowElementPrimaryColumn) {
				this.set("FlowElementName", flowElementPrimaryColumn);
				this.$SelectedElementParameters = [];
				this.callParent(arguments);
			},

			/**
			 * @private
			 */
			_publishResultActiveRowMessage: function(elementName, parameters) {
				const parametersValue = parameters ?? [];
				this.sandbox.publish("ResultActiveRow", {
					elementName: elementName,
					parameters: parametersValue,
					mappedToParameterUId: this.$MappedToParameterUId,
					isSaveAllowed: Terrasoft.isNotEmpty(parametersValue)
				}, [this.sandbox.id]);
			},

			/**
			 * @private
			 */
			_initSelectedParameters: function() {
				const mappedParameterNames = this.$MappedParameterNames;
				if (Terrasoft.isEmpty(mappedParameterNames)) {
					return;
				}
				this.$SelectedElementParameters = Terrasoft.map(mappedParameterNames, function(parameterName) {
					const parameterData = this.$FlowElementParametersData
						.findByFn(f => f.parameter.name === parameterName, this);
					return parameterData?.parameter.uId;
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.ProcessElementParametersMappingPage#getMainRowCollection
			 * @overridden
			 */
			getMainRowCollection: function() {
				const collection = this.callParent(arguments);
				const mappedElementName = this.$MappedElementName;
				if (Terrasoft.isEmpty(mappedElementName)) {
					return collection;
				}
				const mappedElement = collection[mappedElementName];
				if (Terrasoft.isEmpty(mappedElement)) {
					return collection;
				}
				return {
					[mappedElementName]: mappedElement
				};
			},

			/**
			 * @inheritdoc Terrasoft.ProcessElementParametersMappingPage#loadParametersGrid
			 * @overridden
			 */
			loadParametersGrid: function(gridRowCollection) {
				this.callParent(arguments);
				const gridItems = this.getParametersGridData();
				const flowElementName = this.get("FlowElementName");
				let parameters = [];
				const flowElement = this.getGridData("ElementsGrid").find(flowElementName);
				this.$FlowElementParametersData.clear();
				Terrasoft.each(gridItems, function(gridItem) {
					const parameter = gridItem.get("Parameter");
					const parameterValue = this.getParameterSelectedValue(flowElement, gridItem);
					if (parameterValue && parameterValue.value) {
						parameterValue.value =
							Terrasoft.ProcessSchemaDesignerUtilities.addParameterMask(parameterValue.value);
						parameterValue.displayValue =
							Terrasoft.ProcessSchemaDesignerUtilities.addParameterMask(parameterValue.displayValue);
						parameterValue.referenceSchemaUId = parameter.referenceSchemaUId;
					}
					const parameterData = {
						parameter,
						parameterValue
					};
					parameters.push(parameterData);
					this.$FlowElementParametersData.add(parameter.uId, parameterData);
				}, this);
				this._publishResultActiveRowMessage(flowElementName);
				this._initSelectedParameters();
			},

			/**
			 * @inheritdoc BaseParametersMappingPage#onChangeActiveRow
			 * @overridden
			 */
			onChangeActiveRow: Terrasoft.emptyFn,

			/**
			 * @inheritdoc BaseParametersMappingPage#onGridDoubleClick
			 * @overridden
			 */
			onGridDoubleClick: Terrasoft.emptyFn,

			/**
			 * @private
			 */
			_onSelectDeselectAllLabelClick: function() {
				this.$SelectAllChecked = !this.$SelectAllChecked;
			},

			/**
			 * @private
			 */
			_onSelectDeselectChecked: function(sender, checked) {
				if (Terrasoft.isEmpty(checked)) {
					return;
				}
				this.$SelectedElementParameters = [];
				if (checked) {
					this.$SelectedElementParameters = [...this.$ParametersGridData.getKeys()];
				}
			},

			/**
			 * @private
			 */
			_onSelectedElementParametersChange: function() {
				const parameters = this.$FlowElementParametersData;
				const selectedParameters = Terrasoft.map(this.$SelectedElementParameters, function (parameterUId) {
					return parameters.find(parameterUId);
				}, this);
				this._publishResultActiveRowMessage(this.$FlowElementName, selectedParameters);
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "SelectDeselectContainer",
				"parentName": "right-grid-container",
				"propertyName": "items",
				"index": 1,
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"classes": {
						"wrapClassName": "select-deselect-container"
					}
				}
			},
			{
				"operation": "insert",
				"name": "SelectDeselectAllCheckbox",
				"parentName": "SelectDeselectContainer",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"controlConfig": {
						"className": "Terrasoft.CheckBoxEdit",
						"checked": { "bindTo": "SelectAllChecked" },
					},
					"labelConfig": {
						"visible": false
					},
					"caption": {
						"bindTo": "Resources.Strings.SelectDeselectAllCheckboxCaption"
					},
					"markerValue": "SelectDeselectAllCb",
					"wrapClass": ["t-checkbox-control"]
				}
			},
			{
				"operation": "insert",
				"name": "SelectDeselectAllLabel",
				"parentName": "SelectDeselectContainer",
				"propertyName": "items",
				"values": {
					"classes": {
						"labelClass": ["t-title-label-proc"]
					},
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.SelectDeselectAllCheckboxCaption"
					},
					"click": { "bindTo": "_onSelectDeselectAllLabelClick" },
					"markerValue": "SelectDeselectAllLbl"
				}
			},
			{
				"operation": "merge",
				"name": "ParametersGrid",
				"values": {
					"multiSelect": true,
					"selectedRows": "$SelectedElementParameters"
				}
			}
		]
	};
});
