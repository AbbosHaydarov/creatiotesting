﻿define("EmailTemplatesLookupPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGridMain",
				"values": {
					"columns": [
						{
							"id": "5293e2ac-ae57-77c1-23b3-80058d7a3675",
							"code": "MainDS_Name",
							"caption": "#ResourceString(MainDS_Name)#",
							"dataValueType": 30
						}
					],
					"features": {
						"rows": {
							"toolbar": false
						},
						"columns": {
							"adding": false
						},
						"editable": {
							"enable": false,
							"itemsCreation": false
						}
					},
					"placeholder": false
				}
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"DataGridMain_PredefinedFilter": {
						"value": {
							"items": {
								"1982f0d1-cf43-487f-a81a-8741f6000b4d": {
									"filterType": 4,
									"comparisonType": 3,
									"isEnabled": true,
									"trimDateTimeParameterToDate": false,
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "TemplateType"
									},
									"isAggregative": false,
									"dataValueType": 10,
									"referenceSchemaName": "MessageTemplateType",
									"rightExpressions": [
										{
											"expressionType": 2,
											"parameter": {
												"dataValueType": 10,
												"value": {
													"Name": "Email template",
													"Id": "74ff0cee-6593-482f-a62f-6dde6e17ab5e",
													"value": "74ff0cee-6593-482f-a62f-6dde6e17ab5e",
													"displayValue": "Email template"
												}
											}
										}
									]
								}
							},
							"logicalOperation": 0,
							"isEnabled": true,
							"filterType": 6,
							"rootSchemaName": "EmailTemplate"
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"DataGridMain",
					"modelConfig"
				],
				"values": {
					"filterAttributes": [
						{
							"loadOnChange": true,
							"name": "DataGridMain_PredefinedFilter"
						}
					]
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"DataGridMain",
					"modelConfig",
					"sortingConfig"
				],
				"values": {
					"default": [
						{
							"direction": "desc",
							"columnName": "Name"
						}
					]
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"DataGridMain",
					"viewModelConfig",
					"attributes"
				],
				"values": {
					"MainDS_Name": {
						"modelConfig": {
							"path": "MainDS.Name"
						}
					},
					"MainDS_Id": {
						"modelConfig": {
							"path": "MainDS.Id"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"primaryDataSourceName": "EmailTemplateDS"
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"EmailTemplateDS": {
						"type": "crt.EntityDataSource",
						"scope": "page",
						"config": {
							"entitySchemaName": "EmailTemplate"
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"MainDS",
					"config"
				],
				"values": {
					"entitySchemaName": "EmailTemplate"
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"MainDS",
					"config",
					"attributes"
				],
				"values": {
					"Name": {
						"path": "Name"
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});