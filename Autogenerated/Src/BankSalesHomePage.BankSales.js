define("BankSalesHomePage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		"viewConfigDiff": /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "crt.IndicatorWidgete6177f88-79f2-229d-ed4d-6a7430787f90",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 3,
						"rowSpan": 2
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidgete6177f8879f2229ded4d6a7430787f90_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Revenue"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"368843a3-d6a4-4b0b-9a6e-a73edddd2145": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "DueDate"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 13
												}
											},
											"b960b17d-22dc-41f6-84be-42da454d171b": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Owner"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "Contact",
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 2
												}
											},
											"8e4a5169-ee71-4d44-9850-f4f8bb40be1a": {
												"filterType": 4,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Stage"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "OpportunityStage",
												"rightExpressions": [
													{
														"expressionType": 2,
														"parameter": {
															"dataValueType": 10,
															"value": {
																"Name": "Closed won",
																"Id": "60d5310c-5be6-df11-971b-001d60e938c6",
																"value": "60d5310c-5be6-df11-971b-001d60e938c6",
																"displayValue": "Closed won"
															}
														}
													}
												]
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 2,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidgete6177f8879f2229ded4d6a7430787f90_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "crt.IndicatorWidget876a3bbc-2e45-e97d-29ad-265ed519be22",
				"values": {
					"layoutConfig": {
						"row": 3,
						"rowSpan": 2,
						"column": 1,
						"colSpan": 3
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidget876a3bbc2e45e97d29ad265ed519be22_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Revenue"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"ff1f89f8-9ecd-40b3-860e-9be098d4d4ab": {
												"filterType": 4,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Stage"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "OpportunityStage",
												"rightExpressions": [
													{
														"expressionType": 2,
														"parameter": {
															"dataValueType": 10,
															"value": {
																"Name": "Closed won",
																"Id": "60d5310c-5be6-df11-971b-001d60e938c6",
																"value": "60d5310c-5be6-df11-971b-001d60e938c6",
																"displayValue": "Closed won"
															}
														}
													}
												]
											},
											"1071ad3f-3e16-4d01-b244-70bdff6ddd3a": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "DueDate"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 19
												}
											},
											"53a9d69b-2a3f-4451-bacd-e8b8f6d65a97": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Owner"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "Contact",
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 2
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 2,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidget876a3bbc2e45e97d29ad265ed519be22_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "crt.FunnelWidget52ecd7b8-dfa2-1823-37d9-043ae5bf440a",
				"values": {
					"layoutConfig": {
						"row": 1,
						"rowSpan": 8,
						"column": 7,
						"colSpan": 6
					},
					"type": "crt.FunnelWidget",
					"config": {
						"title": "#ResourceString(crtFunnelWidget52ecd7b8dfa2182337d9043ae5bf440a_title)#",
						"color": "blue",
						"entities": [
							{
								"schemaName": "Opportunity",
								"calculatedOperations": [
									{
										"operation": "Amount",
										"targetColumnName": "Budget"
									}
								],
								"connectedWith": null,
								"filters": {
									"items": {
										"5e8cff9b-fcee-46e1-a116-42fbd1913a5b": {
											"filterType": 1,
											"comparisonType": 3,
											"isEnabled": true,
											"trimDateTimeParameterToDate": true,
											"leftExpression": {
												"expressionType": 0,
												"columnPath": "CreatedOn"
											},
											"isAggregative": false,
											"dataValueType": 7,
											"rightExpression": {
												"expressionType": 1,
												"functionType": 1,
												"macrosType": 19
											}
										}
									},
									"logicalOperation": 0,
									"isEnabled": true,
									"filterType": 6,
									"rootSchemaName": "Opportunity"
								}
							}
						]
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "crt.IndicatorWidget7ecf25f6-c73c-9840-14b2-f7711a862669",
				"values": {
					"layoutConfig": {
						"row": 1,
						"rowSpan": 2,
						"column": 4,
						"colSpan": 3
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidget7ecf25f6c73c984014b2f7711a862669_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 1,
											"aggregationEvalType": 2,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Id"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"a73a0054-58c6-427c-86b7-b06e3d3ea795": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 19
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidget7ecf25f6c73c984014b2f7711a862669_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "crt.IndicatorWidget3db7d0ae-1c59-6148-8916-37fdd341a181",
				"values": {
					"layoutConfig": {
						"row": 3,
						"rowSpan": 2,
						"column": 4,
						"colSpan": 3
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidget3db7d0ae1c596148891637fdd341a181_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Revenue"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"c152af6c-b787-4a4f-ac9b-5dce2ac702f1": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 19
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 2,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidget3db7d0ae1c596148891637fdd341a181_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidget0979f91a-123f-7412-8f28-47c0dce2b542",
				"values": {
					"layoutConfig": {
						"row": 5,
						"rowSpan": 4,
						"column": 1,
						"colSpan": 3
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidget0979f91a123f74128f2847c0dce2b542_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "#ResourceString(crtChartWidget0979f91a123f74128f2847c0dce2b542_yAxis)#",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "green",
								"type": "bar",
								"label": "#ResourceString(crtChartWidget0979f91a123f74128f2847c0dce2b542_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Revenue"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"10edf7ed-342d-419b-bdb5-60c386819987": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "celestial-blue",
								"type": "bar",
								"label": "#ResourceString(crtChartWidget0979f91a123f74128f2847c0dce2b542_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Revenue"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"10edf7ed-342d-419b-bdb5-60c386819987": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"d85e5677-4dae-42a7-92df-86ec6559436b": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Stage"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "OpportunityStage",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Closed won",
																		"Id": "60d5310c-5be6-df11-971b-001d60e938c6",
																		"value": "60d5310c-5be6-df11-971b-001d60e938c6",
																		"displayValue": "Closed won"
																	}
																}
															}
														]
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "red",
								"type": "bar",
								"label": "#ResourceString(crtChartWidget0979f91a123f74128f2847c0dce2b542_series_2)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Revenue"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"10edf7ed-342d-419b-bdb5-60c386819987": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"d85e5677-4dae-42a7-92df-86ec6559436b": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Stage"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "OpportunityStage",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Closed lost",
																		"Id": "a9aafdfe-2242-4f42-8cd5-2ae3b9556d79",
																		"value": "a9aafdfe-2242-4f42-8cd5-2ae3b9556d79",
																		"displayValue": "Closed lost"
																	}
																}
															}
														]
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidgetc75c6457-3593-8d12-2cb6-c240540ec9d4",
				"values": {
					"layoutConfig": {
						"row": 5,
						"rowSpan": 4,
						"column": 4,
						"colSpan": 3
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidgetc75c645735938d122cb6c240540ec9d4_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "blue",
								"type": "area",
								"label": "#ResourceString(crtChartWidgetc75c645735938d122cb6c240540ec9d4_series_0)#",
								"legend": {
									"enabled": false
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": {
												"expression": {
													"expressionType": 0,
													"columnPath": "LeadType"
												}
											},
											"type": "by-value"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Revenue"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"5d46ddb0-a5a1-4604-a738-3555b056d237": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "LeadType"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "crt.IndicatorWidgetd573f525-361b-a940-f818-d2642a788773",
				"values": {
					"layoutConfig": {
						"row": 9,
						"rowSpan": 2,
						"column": 1,
						"colSpan": 3
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidgetd573f525361ba940f818d2642a788773_title)#",
						"data": {
							"providing": {
								"schemaName": "Lead",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 1,
											"aggregationEvalType": 2,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Id"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"cdf37c7b-b22d-4b34-879c-874233c107b9": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "QualifyStatus.IsFinal"
												},
												"isAggregative": false,
												"dataValueType": 12,
												"rightExpression": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 12,
														"value": false
													}
												}
											},
											"69d133c8-6926-4071-98f2-5ed3d30d5ef5": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Owner"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "Contact",
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 2
												}
											},
											"ae79c16a-1ee3-420a-9f13-91e88a940ac4": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 19
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Lead"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidgetd573f525361ba940f818d2642a788773_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "insert",
				"name": "crt.IndicatorWidget00e4e076-004b-08a4-167f-fc36ee033955",
				"values": {
					"layoutConfig": {
						"row": 9,
						"rowSpan": 2,
						"column": 4,
						"colSpan": 3
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidget00e4e076004b08a4167ffc36ee033955_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 1,
											"aggregationEvalType": 2,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Id"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"01234677-67cb-4afe-96f2-f183cb392847": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Stage.End"
												},
												"isAggregative": false,
												"dataValueType": 12,
												"rightExpression": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 12,
														"value": false
													}
												}
											},
											"4d0ad465-8d71-45f3-a0a7-9eb9e179c01e": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Owner"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "Contact",
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 2
												}
											},
											"581f5b80-5d41-4465-b1ae-137d8b62b9b4": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 13
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidget00e4e076004b08a4167ffc36ee033955_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 8
			},
			{
				"operation": "insert",
				"name": "crt.IndicatorWidget85635ed8-6f14-6ce6-c51f-430f2629cb1c",
				"values": {
					"layoutConfig": {
						"row": 9,
						"rowSpan": 2,
						"column": 7,
						"colSpan": 3
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidget85635ed86f146ce6c51f430f2629cb1c_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Revenue"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"d3340a68-4382-4fda-a88c-39eddec3423e": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Stage.End"
												},
												"isAggregative": false,
												"dataValueType": 12,
												"rightExpression": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 12,
														"value": false
													}
												}
											},
											"6e617f48-478d-4a43-b621-a6c16c982ac5": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Owner"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "Contact",
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 2
												}
											},
											"9aca95f4-51f5-4418-be3d-770f17dc4e66": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 13
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 2,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidget85635ed86f146ce6c51f430f2629cb1c_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 9
			},
			{
				"operation": "insert",
				"name": "crt.IndicatorWidgetca72b22c-c19c-2dbe-5416-95cb9f6eb779",
				"values": {
					"layoutConfig": {
						"row": 9,
						"rowSpan": 2,
						"column": 10,
						"colSpan": 3
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(crtIndicatorWidgetca72b22cc19c2dbe541695cb9f6eb779_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Revenue"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"8bf2c5e2-faf7-416c-9eba-26b85c098ac9": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 13
												}
											},
											"99e10fe8-298f-42b5-9d46-cf82a25d2165": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Owner"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "Contact",
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 2
												}
											},
											"d32eebe9-4f86-4c01-b9b7-23b3046735ee": {
												"filterType": 4,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Type"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "OpportunityType",
												"rightExpressions": [
													{
														"expressionType": 2,
														"parameter": {
															"dataValueType": 10,
															"value": {
																"Name": "Partner sale",
																"Id": "c4505efc-6cf5-4b0c-b984-55076bc235f0",
																"value": "c4505efc-6cf5-4b0c-b984-55076bc235f0",
																"displayValue": "Partner sale"
															}
														}
													}
												]
											},
											"2e478bda-8735-4cd3-9ebe-4fb48cd65a72": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "Stage.End"
												},
												"isAggregative": false,
												"dataValueType": 12,
												"rightExpression": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 12,
														"value": false
													}
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 2,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(crtIndicatorWidgetca72b22cc19c2dbe541695cb9f6eb779_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "blue"
						},
						"theme": "without-fill"
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 10
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidget737c0309-325d-0372-014e-51af9716e7c0",
				"values": {
					"layoutConfig": {
						"row": 11,
						"rowSpan": 4,
						"column": 1,
						"colSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidget737c0309325d0372014e51af9716e7c0_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "#ResourceString(crtChartWidget737c0309325d0372014e51af9716e7c0_yAxis)#",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "green",
								"type": "bar",
								"label": "#ResourceString(crtChartWidget737c0309325d0372014e51af9716e7c0_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"463591ce-6bd6-4af4-aaa8-59f0f8e91926": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"5b25c096-a3c8-49ec-b28e-87049708df92": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "IsPrimary"
														},
														"isAggregative": false,
														"dataValueType": 12,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 12,
																"value": true
															}
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "celestial-blue",
								"type": "bar",
								"label": "#ResourceString(crtChartWidget737c0309325d0372014e51af9716e7c0_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"463591ce-6bd6-4af4-aaa8-59f0f8e91926": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"5b25c096-a3c8-49ec-b28e-87049708df92": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "IsPrimary"
														},
														"isAggregative": false,
														"dataValueType": 12,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 12,
																"value": false
															}
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 11
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidgetddb58e77-7d95-c888-8f94-9e1c4c82dc5f",
				"values": {
					"layoutConfig": {
						"row": 11,
						"rowSpan": 4,
						"column": 5,
						"colSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidgetddb58e777d95c8888f949e1c4c82dc5f_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "green",
								"type": "bar",
								"label": "#ResourceString(crtChartWidgetddb58e777d95c8888f949e1c4c82dc5f_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"19848b8b-448b-45a0-aa1c-1d31c174630e": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"08ee913a-6373-401d-b255-933f06d2b276": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "IsPrimary"
														},
														"isAggregative": false,
														"dataValueType": 12,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 12,
																"value": true
															}
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "celestial-blue",
								"type": "bar",
								"label": "#ResourceString(crtChartWidgetddb58e777d95c8888f949e1c4c82dc5f_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"19848b8b-448b-45a0-aa1c-1d31c174630e": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"08ee913a-6373-401d-b255-933f06d2b276": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "IsPrimary"
														},
														"isAggregative": false,
														"dataValueType": 12,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 12,
																"value": false
															}
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 12
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidgete341104d-4ef4-e897-cb92-5d2864b238f1",
				"values": {
					"layoutConfig": {
						"row": 11,
						"rowSpan": 4,
						"column": 9,
						"colSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidgete341104d4ef4e897cb925d2864b238f1_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "celestial-blue",
								"type": "bar",
								"label": "#ResourceString(crtChartWidgete341104d4ef4e897cb925d2864b238f1_series_0)#",
								"legend": {
									"enabled": false
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": {
												"expression": {
													"expressionType": 0,
													"columnPath": "Stage"
												}
											},
											"type": "by-value"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Revenue"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"2b3fa844-c6d6-4782-afb1-e47ced1f2a18": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 13
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Stage"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 13
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidget9c23d3c4-58c8-7b33-320b-5233d357fc04",
				"values": {
					"layoutConfig": {
						"row": 15,
						"rowSpan": 5,
						"column": 1,
						"colSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidget9c23d3c458c87b33320b5233d357fc04_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "green",
								"type": "horizontal-bar",
								"label": "#ResourceString(crtChartWidget9c23d3c458c87b33320b5233d357fc04_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"82392e61-7197-4561-bd25-6dbadf2cf755": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "celestial-blue",
								"type": "horizontal-bar",
								"label": "#ResourceString(crtChartWidget9c23d3c458c87b33320b5233d357fc04_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"82392e61-7197-4561-bd25-6dbadf2cf755": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"c77dfe8c-8651-4d06-823f-9fff1efbb95a": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "QualifyStatus.IsFinal"
														},
														"isAggregative": false,
														"dataValueType": 12,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 12,
																"value": false
															}
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "red",
								"type": "horizontal-bar",
								"label": "#ResourceString(crtChartWidget9c23d3c458c87b33320b5233d357fc04_series_2)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ecbe0307-dfa2-44ae-9a6c-b598da861fb6": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "violet",
								"type": "horizontal-bar",
								"label": "#ResourceString(crtChartWidget9c23d3c458c87b33320b5233d357fc04_series_3)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ecbe0307-dfa2-44ae-9a6c-b598da861fb6": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"b37ed242-9284-4986-b2e9-0b7999154cb7": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Stage"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "OpportunityStage",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Closed won",
																		"Id": "60d5310c-5be6-df11-971b-001d60e938c6",
																		"value": "60d5310c-5be6-df11-971b-001d60e938c6",
																		"displayValue": "Closed won"
																	}
																}
															}
														]
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 14
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidget01685e8c-49b6-4ac2-56ee-8421059b0a03",
				"values": {
					"layoutConfig": {
						"row": 15,
						"rowSpan": 5,
						"column": 9,
						"colSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidget01685e8c49b64ac256ee8421059b0a03_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "celestial-blue",
								"type": "horizontal-bar",
								"label": "#ResourceString(crtChartWidget01685e8c49b64ac256ee8421059b0a03_series_0)#",
								"legend": {
									"enabled": false
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"2597214c-ab67-4b38-b354-a80d2bd35f05": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 15
			},
			{
				"operation": "insert",
				"name": "crt.ChartWidgetde335e37-b065-ed6e-4b3c-9ca30415677c",
				"values": {
					"layoutConfig": {
						"row": 15,
						"rowSpan": 5,
						"column": 5,
						"colSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(crtChartWidgetde335e37b065ed6e4b3c9ca30415677c_title)#",
						"color": "blue",
						"theme": "full-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "celestial-blue",
								"type": "horizontal-bar",
								"label": "#ResourceString(crtChartWidgetde335e37b065ed6e4b3c9ca30415677c_series_0)#",
								"legend": {
									"enabled": false
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"cdb45828-cf6b-4e19-92e8-7178a8effaa0": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 19
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 16
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		"modelConfig": /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/
	};
});
