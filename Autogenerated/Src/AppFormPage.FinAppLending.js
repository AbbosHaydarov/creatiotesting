define("AppFormPage", ["ProductBankConstants", "Product", "TimezoneGenerator", "TimezoneMixin",
		"ImageCustomGeneratorV2", "ContactFieldConverterMixin", "FinApplicationProfileUtils", "DocListInFinAppDetail",
		"AppFormCommunicationDetail", "RegistrationAddressFieldsDetail", "PlaceOfResidenceAddressFieldsDetail",
		"AppFormPrimaryEmploymentPlaceDetail", "AppFormIncomeDetail", "AppFormExpensesDetail",
		"AppFormObligationFieldsDetail", "AppFormPropertyFieldsDetail", "AppFormMainContactFieldsDetail",
		"css!FinAppLendingCSS"
	],
	function(ProductBankConstants, Product) {
		return {
			entitySchemaName: "AppForm",
			details: /**SCHEMA_DETAILS*/ {
				"AppFormPropertyFieldsDetail": {
					"schemaName": "AppFormPropertyFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"DocListInFinAppDetail": {
					"schemaName": "DocListInFinAppDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					},
					"defaultValues": {
						"FinApplication": {
							"masterColumn": "FinApplication"
						}
					}
				},
				"AppFormCommunicationDetail": {
					"schemaName": "AppFormCommunicationDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"RegistrationAddressFieldsDetail": {
					"schemaName": "RegistrationAddressFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"PlaceOfResidenceAddressFieldsDetail": {
					"schemaName": "PlaceOfResidenceAddressFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"AppFormPrimaryEmploymentPlaceDetail": {
					"schemaName": "AppFormPrimaryEmploymentPlaceDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					},
					"defaultValues": {
						"Primary": {
							"value": true
						},
						"Current": {
							"value": true
						}
					}
				},
				"AppFormIncomeDetail": {
					"schemaName": "AppFormIncomeDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"AppFormExpensesDetail": {
					"schemaName": "AppFormExpensesDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"AppFormObligationFieldsDetail": {
					"schemaName": "AppFormObligationFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"AppFormMainContactFieldsDetail": {
					"schemaName": "AppFormMainContactFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				},
				"BusinessAddressFieldsDetail": {
					"schemaName": "BusinessAddressFieldsDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppForm"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			mixins: {
				TimezoneMixin: "Terrasoft.TimezoneMixin",
				ContactFieldConverterMixin: "Terrasoft.ContactFieldConverterMixin",
				FinApplicationProfileUtils: "Terrasoft.FinApplicationProfileUtils"
			},
			messages: {
				/**
				 * @message DetailLoaded
				 */
				"DetailLoaded": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message SetCollapseLock
				 */
				"SetCollapseLock": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message SetDetailCollapsed
				 */
				"SetDetailCollapsed": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message GetFieldsDetailItems
				 */
				"GetAddressRecordInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message UpdateFieldsDetailItems
				 */
				"SetAddressRecordInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message SetDetailMappingData
				 * Gets new detail fields data.
				 */
				"SetDetailMappingData": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"name": "CardContentWrapper",
				"values": {
					"wrapClass": ["AppFormPage", "card-content-container"]
				}
			}, {
				"operation": "insert",
				"name": "AddressInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.AddressInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "AddressInfoContainer",
				"parentName": "AddressInfoTab",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "IsSameAddress",
				"parentName": "AddressInfoContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 5
					}
				}
			}, {
				"operation": "insert",
				"name": "RegistrationAddressFieldsDetail",
				"parentName": "AddressInfoTab",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"name": "PlaceOfResidenceAddressFieldsDetail",
				"parentName": "AddressInfoTab",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"name": "FinanceInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 4,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.FinanceInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "FinanceInfoTab",
				"propertyName": "items",
				"name": "AppFormIncomeDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"parentName": "FinanceInfoTab",
				"propertyName": "items",
				"name": "AppFormExpensesDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"parentName": "FinanceInfoTab",
				"propertyName": "items",
				"name": "AppFormObligationFieldsDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"parentName": "FinanceInfoTab",
				"propertyName": "items",
				"name": "AppFormPropertyFieldsDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"name": "DocumentsInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 5,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.DocumentsInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "DocumentsInfoTab",
				"propertyName": "items",
				"name": "DocListInFinAppDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"name": "AdditionalProfileInfoContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": [],
					"classes": {
						"wrapClassName": ["profile-container"]
					}
				}
			}, {
				"operation": "insert",
				"name": "PhotoTimeZoneContainer",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["image-edit-container"],
					"items": [],
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			}, {
				"operation": "insert",
				"parentName": "PhotoTimeZoneContainer",
				"propertyName": "items",
				"name": "PhotoAppForm",
				"values": {
					"getSrcMethod": "getAppFormPhoto",
					"onPhotoChange": "onPhotoChange",
					"readonly": false,
					"defaultImage": {
						"bindTo": "getAppFormDefaultPhoto"
					},
					"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
				}
			}, {
				"operation": "insert",
				"parentName": "PhotoTimeZoneContainer",
				"propertyName": "items",
				"name": "Timezone",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"generator": "TimezoneGenerator.generateTimeZone",
					"wrapClass": ["timezone-container"],
					"visible": true,
					"timeZoneCaption": {
						"bindTo": "TimeZoneCaption"
					},
					"timeZoneCity": {
						"bindTo": "TimeZoneCity"
					},
					"tips": []
				}
			}, {
				"operation": "insert",
				"name": "Participant",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					},
					"bindTo": "Participant",
					"caption": {
						"bindTo": "getParticipantCaption"
					},
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "FinApplication",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					},
					"bindTo": "FinApplication"
				},
				"parentName": "AdditionalProfileInfoContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "ParticipantRole",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					},
					"bindTo": "ParticipantRole"
				},
				"parentName": "AdditionalProfileInfoContainer",
				"propertyName": "items",
				"index": 0
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
			}, {
				"operation": "insert",
				"name": "GeneralInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.GeneralInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "PersonalInformationContainer",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "PersonalInformationContainer",
				"name": "IsNewContact",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 6
					}
				}
			}, {
				"operation": "insert",
				"name": "Contact",
				"values": {
					"layout": {
						"column": 6,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "Contact",
					"visible": {
						"bindTo": "getContactVisible"
					}
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Surname",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "Surname"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "GivenName",
				"values": {
					"layout": {
						"column": 6,
						"row": 1,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "GivenName"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "MiddleName",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "MiddleName"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "PreviousSurname",
				"values": {
					"layout": {
						"column": 18,
						"row": 1,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "PreviousSurname"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "INN",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "INN"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "BirthDate",
				"values": {
					"layout": {
						"column": 6,
						"row": 2,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "BirthDate"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "PlaceOfBirth",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "PlaceOfBirth"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Gender",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "Gender"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Citizenship",
				"values": {
					"layout": {
						"column": 6,
						"row": 3,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "Citizenship"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "SocialStatus",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 12,
						"row": 3,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "SocialStatus"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Education",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 18,
						"row": 3,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "Education"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "IsAgreePrivateDataProcessing",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "IsAgreePrivateDataProcessing"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "IsAgreePrivateDataVerification",
				"values": {
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 12,
						"rowSpan": 1
					},
					"bindTo": "IsAgreePrivateDataVerification"
				},
				"parentName": "PersonalInformationContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"name": "PassportControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
					"caption": {
						"bindTo": "Resources.Strings.PassportControlGroupCaption"
					},
					"items": [],
					"collapsed": false
				}
			}, {
				"operation": "insert",
				"name": "PassportContainer",
				"parentName": "PassportControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "Series",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 3,
						"rowSpan": 1
					},
					"bindTo": "Series"
				},
				"parentName": "PassportContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "Number",
				"values": {
					"layout": {
						"column": 3,
						"row": 0,
						"colSpan": 3,
						"rowSpan": 1
					},
					"bindTo": "Number"
				},
				"parentName": "PassportContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "IssueDate",
				"values": {
					"layout": {
						"column": 6,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "IssueDate"
				},
				"parentName": "PassportContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "IssuedBy",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "IssuedBy"
				},
				"parentName": "PassportContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "CodeDivision",
				"values": {
					"layout": {
						"column": 18,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "CodeDivision"
				},
				"parentName": "PassportContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"name": "AppFormCommunicationDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL,
					"classes": {
						"wrapClassName": ["appFormCommunicationDetail"]
					}
				}
			}, {
				"operation": "insert",
				"name": "AdditionalInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.AdditionalInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "AdditionalInfoTabContainer",
				"parentName": "AdditionalInfoTab",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "MaritalStatus",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "MaritalStatus"
				},
				"parentName": "AdditionalInfoTabContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "NumberOfDependants",
				"values": {
					"layout": {
						"column": 6,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "NumberOfDependants"
				},
				"parentName": "AdditionalInfoTabContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "NumberOfChildren",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "NumberOfChildren"
				},
				"parentName": "AdditionalInfoTabContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "ChildrenUnder14",
				"values": {
					"layout": {
						"column": 18,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "ChildrenUnder14"
				},
				"parentName": "AdditionalInfoTabContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"parentName": "AdditionalInfoTab",
				"name": "SpouseInfoControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
					"caption": {
						"bindTo": "Resources.Strings.SpouseInfoControlGroupCaption"
					},
					"items": [],
					"collapsed": false
				}
			}, {
				"operation": "insert",
				"name": "SpouseInfoContainer",
				"parentName": "SpouseInfoControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "SpouseSurname",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "SpouseSurname",
					"caption": {
						"bindTo": "Resources.Strings.SpouseSurnameCaption"
					}
				},
				"parentName": "SpouseInfoContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "SpouseGivenName",
				"values": {
					"layout": {
						"column": 6,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "SpouseGivenName",
					"caption": {
						"bindTo": "Resources.Strings.SpouseGivenNameCaption"
					}
				},
				"parentName": "SpouseInfoContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "SpouseContactNumber",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "SpouseContactNumber",
					"caption": {
						"bindTo": "Resources.Strings.SpouseContactNumberCaption"
					}
				},
				"parentName": "SpouseInfoContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "SpouseMiddleName",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "SpouseMiddleName",
					"caption": {
						"bindTo": "Resources.Strings.SpouseMiddleNameCaption"
					}
				},
				"parentName": "SpouseInfoContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "SpouseBirthDate",
				"values": {
					"layout": {
						"column": 18,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "SpouseBirthDate",
					"caption": {
						"bindTo": "Resources.Strings.SpouseBirthDateCaption"
					}
				},
				"parentName": "SpouseInfoContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"parentName": "AdditionalInfoTab",
				"name": "AppFormMainContactFieldsDetail",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"name": "JobInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 3,
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.JobInfoTabCaption"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "JobInfoTabContainer",
				"parentName": "JobInfoTab",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "EmploymentType",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "EmploymentType"
				},
				"parentName": "JobInfoTabContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"parentName": "JobInfoTab",
				"propertyName": "items",
				"name": "AppFormPrimaryEmploymentPlaceDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"parentName": "JobInfoTab",
				"propertyName": "items",
				"name": "BusinessAddressFieldsDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}, {
				"operation": "insert",
				"name": "Qualification",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 6,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "Qualification"
				},
				"parentName": "JobInfoTabContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "TotalWorkExperienceYears",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "TotalWorkExperienceYears"
				},
				"parentName": "JobInfoTabContainer",
				"propertyName": "items"
			}, {
				"operation": "insert",
				"name": "TotalWorkExperienceMonths",
				"values": {
					"layout": {
						"column": 18,
						"row": 0,
						"colSpan": 6,
						"rowSpan": 1
					},
					"bindTo": "TotalWorkExperienceMonths"
				},
				"parentName": "JobInfoTabContainer",
				"propertyName": "items"
			}] /**SCHEMA_DIFF*/ ,
			attributes: /**ATTRIBUTES*/ {
				"FinApplication": {
					lookupListConfig: {
						columns: ["Number", "Product", "Product.Type"]
					}
				},
				"ContactFieldConverter": {
					name: "ContactFieldConverter",
					dataValueType: Terrasoft.DataValueType.LOOKUP
				},
				"FinAppProduct": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isLookup: true,
					referenceSchema: Product,
					referenceSchemaName: "Product",
					dependencies: [{
						columns: ["Surname", "GivenName", "MiddleName"],
						methodName: "generateFullName"
					}]
				},
				"ProductUpdater": {
					dependencies: [{
						columns: ["FinApplication"],
						methodName: "updateProduct"
					}]
				},
				"ProfileInfoCollection": {
					dataValueType: Terrasoft.DataValueType.COLLECTION
				},
				"FinAppAmountGenerator": {
					dependencies: [{
						columns: ["FinAppAmount", "FinAppCurrency"],
						methodName: "updateAmount"
					}]
				},
				"FinAppAmountWithCurrency": {
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"FinAppAmount": {
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"FinAppCurrency": {
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"FinAppTerm": {
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"IsSameAddress": {
					dependencies: [{
						columns: ["IsSameAddress"],
						methodName: "onIsSameAddressChange"
					}]
				},
				"IsNewContact": {
					dependencies: [{
						columns: ["IsNewContact"],
						methodName: "onIsNewContactChange"
					}]
				},
				"ExistingContact": {
					dependencies: [{
						columns: ["Contact"],
						methodName: "onContactChange"
					}]
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * Returns participant field caption based on ParticipantType field value.
				 * @private
				 * @return {String} Participant field caption.
				 */
				getParticipantCaption: function() {
					var participantType = this.get("ParticipantRole");
					if (participantType && participantType.displayValue) {
						return participantType.displayValue;
					}
					return "";
				},

				/**
				 * Returns application form photo url.
				 * @private
				 * @return {String} Application form photo url.
				 */
				getAppFormPhoto: function() {
					var primaryImageColumnValue = this.get(this.primaryImageColumnName);
					if (primaryImageColumnValue) {
						return this.getSchemaImageUrl(primaryImageColumnValue);
					}
					return this.getAppFormDefaultPhoto();
				},

				/**
				 * Returns default application form photo url.
				 * @private
				 * @return {String} Default application form photo url.
				 */
				getAppFormDefaultPhoto: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.DefaultPhoto"));
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
				 * Checking if any amount value exist to show.
				 * @private
				 * @return {Boolean} true is FinAppAmountWithCurrency set.
				 */
				getAmountVisible: function() {
					return !this.Ext.isEmpty(this.get("FinAppAmountWithCurrency"));
				},

				/**
				 * Checking if any term value exist to show.
				 * @private
				 * @return {Boolean} true is FinAppTerm set.
				 */
				getTermVisible: function() {
					return !this.Ext.isEmpty(this.get("FinAppTerm"));
				},

				/**
				 * Returns contact field visible.
				 * @private
				 * @return {Boolean}
				 */
				getContactVisible: function() {
					return !this.get("IsNewContact");
				},

				/**
				 * Uploads image.
				 * @private
				 * @param {File} photo File.
				 */
				onPhotoChange: function(photo) {
					if (!photo) {
						this.set(this.primaryImageColumnName, null);
						return;
					}
					this.Terrasoft.ImageApi.upload({
						file: photo,
						onComplete: this.onPhotoUploaded,
						onError: this.Terrasoft.emptyFn,
						scope: this
					});
				},

				/**
				 * Updates product and credit data on FinApplication setting.
				 * @private
				 */
				updateProduct: function() {
					this.initFinAppValues();
				},

				/**
				 * Returns configuration element by Id.
				 * @private
				 * @param {Array} elements Array of configuration elements.
				 * @param {String} containerId Container identifier.
				 * @return {Object} Configuration element.
				 */
				getConfigElementById: function(elements, containerId) {
					var result = null;
					if (this.Ext.isArray(elements)) {
						this.Terrasoft.each(elements, function(item) {
							if (item && item.id === containerId) {
								result = item;
								return false;
							} else {
								var innerresult = this.getConfigElementById(item.items, containerId);
								if (!this.Ext.isEmpty(innerresult)) {
									result = innerresult;
									return false;
								}
							}
						}, this);
					}
					return result;
				},

				/**
				 * Returns detail names from configuration element.
				 * @private
				 * @param {Object} element Configuration element.
				 * @return {Array} Detail names.
				 */
				getElementDetailNames: function(element) {
					var result = [];
					var innerElements = element && element.items;
					if (this.Ext.isArray(innerElements)) {
						this.Terrasoft.each(innerElements, function(item) {
							if (item && item.tag && item.tag.detailName) {
								result.push(item.tag.detailName);
							} else {
								var innerResult = this.getElementDetailNames(item);
								this.Terrasoft.append(result, innerResult);
							}
						}, this);
					}
					return result;
				},
				
				_initializeExcludeDetailNames: function(viewConfig) {
					const activeTabName = this.get("ActiveTabName");
					const container = this.getConfigElementById(viewConfig, activeTabName);
					this.$ExcludeDetailNames = this.getElementDetailNames(container);
				},

				//endregion

				//region Methods: Protected

				/**
				 * On property IsNewContact change handler.
				 * @protected
				 */
				onIsNewContactChange: function() {
					if (this.get("Contact")) {
						this.set("Contact", null);
					}
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#initPageHeaderColumnNames
				 * @overridden
				 */
				initPageHeaderColumnNames: function() {
					this.set("PageHeaderColumnNames", "FinApplication");
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#getPageHeaderCaption
				 * @overridden
				 */
				getPageHeaderCaption: function() {
					var caption = this.get("Resources.Strings.AppFormCaptionTemplate");
					var pageCaptionTemplateEnding = this.get("Resources.Strings.AppFormCaptionTemplateEnding");
					var finApplication = this.get("FinApplication");
					var finApplicationNumber = finApplication && finApplication.Number;
					var productType = finApplication && finApplication["Product.Type"];
					var productTypeCaption = productType && productType.displayValue;
					if (!this.Ext.isEmpty(productTypeCaption) && !this.Ext.isEmpty(finApplicationNumber)) {
						caption +=
							this.Ext.String.format(pageCaptionTemplateEnding, finApplicationNumber, productTypeCaption);
					}
					return caption;
				},

				/**
				 * On photo uploaded handler.
				 * @protected
				 * @param {String} imageId Photo image id.
				 */
				onPhotoUploaded: function(imageId) {
					var primaryImageColumnName = this.primaryImageColumnName;
					if (!primaryImageColumnName) {
						return;
					}
					this.set(this.primaryImageColumnName, {
						value: imageId,
						displayValue: "Photo"
					});
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.mixins.TimezoneMixin.init.call(this);
					this.initFinAppValues();
					this.preloadCardDetails();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this._initializeExcludeDetailNames(scope.viewConfig);
						this.mixins.ContactFieldConverterMixin.initContactFieldConverter.call(this, "Participant", callback, scope);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1681);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#setValidationConfig
				 * @overridden
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("NumberOfDependants", this.validateNumberOfDependantsMoreThenZero);
					this.addColumnValidator("NumberOfChildren", this.validateNumberOfDependantsMoreThenZero);
					this.addColumnValidator("ChildrenUnder14", this.validateNumberOfDependantsMoreThenZero);
					this.addColumnValidator("TotalWorkExperienceYears", this.validateNumberOfDependantsMoreThenZero);
					this.addColumnValidator("TotalWorkExperienceMonths", this.validateNumberOfDependantsMoreThenZero);
					this.addColumnValidator("ChildrenUnder14", this.validateNumberOfDependantsMoreThenZero);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#save
				 * @overridden
				 */
				save: function() {
					if (this.get("IsSameAddress")) {
						this.copyAddressDetails();
					}
					this.callParent(arguments);
				},

				/**
				 * Copy registration address to place of residence detail.
				 * @protected
				 */
				copyAddressDetails: function() {
					var registrationAddressDetailId = this.getDetailId("RegistrationAddressFieldsDetail");
					var placeOfResidenceAddressDetailId = this.getDetailId("PlaceOfResidenceAddressFieldsDetail");
					var item = this.sandbox.publish("GetAddressRecordInfo", null, [registrationAddressDetailId]);
					if (!this.Ext.isEmpty(item)) {
						this.sandbox.publish("SetAddressRecordInfo", item, [placeOfResidenceAddressDetailId]);
					}
				},

				/**
				 * Contact field onChange handler.
				 * @protected
				 */
				onContactChange: function() {
					var contact = this.get("Contact") || {};
					this.requestContactData(contact.value);
				},

				/**
				 * Publish SetDetailMappingData message to detail need to change.
				 * @protected
				 * @param {Object} detail Detail config.
				 */
				updateDetailData: function(detail) {
					if (detail && detail.Key) {
						var detailId = this.getDetailId(detail.Key);
						this.sandbox.publish("SetDetailMappingData", detail.Value, [detailId]);
					}
				},

				/**
				 * Preloads all details on page to be able to listn events before tabs opening.
				 * @protected
				 */
				preloadCardDetails: function() {
					const excludeDetailNames = this.$ExcludeDetailNames || [];
					this.Terrasoft.each(this.details, function(detail) {
						if (!this.Terrasoft.contains(excludeDetailNames, detail.schemaName)) {
							this.preloadDetail(detail.schemaName, null);
						}
					}, this);
				},

				/**
				 * Requests Contact Data from EntityMapping service call to get full Contact data by Id.
				 * @param {String} contactId Contact identificator.
				 * @protected
				 */
				requestContactData: function(contactId) {
					this.showBodyMask();
					var data = {
						id: contactId
					};
					var config = {
						serviceName: "EntityMappingService",
						methodName: "GetMappedEntity",
						data: data
					};
					this.callService(config, this.parseMappedEntityResponse, this);
				},

				/**
				 * Parsing service response.
				 * @param {Object} response EntityMappingService response.
				 * @protected
				 */
				parseMappedEntityResponse: function(response) {
					var result = response.result;
					var success = result && result.success;
					if (success) {
						this.parseContactData(result);
					} else {
						var errorInfo = result && result.errorInfo;
						var message = this.Ext.String.format(this.get("Resources.Strings.GetContactErrorMessage"),
							errorInfo.message);
						this.showInformationDialog(message);
					}
					this.hideBodyMask();
				},

				/**
				 * Handles field collection in service response to set new photo id if exist.
				 * @protected
				 * @param {Object} response EntityMappingService.
				 */
				setNewImageGuid: function(response) {
					if (response && this.Ext.isArray(response.columns)) {
						var photo = response.columns.filter(function(column) {
							return column.Key === "Photo";
						})[0];
						if (photo && photo.Value && photo.Value.value) {
							this.set("NewPhotoId", photo.Value.value);
						}
					}
				},

				/**
				 * Deletes image by id from SysImage.
				 * @protected
				 * @param {String} id SysImage id.
				 * @param {Function} callback callback-function.
				 * @param {Object} scope execution context of callback.
				 */
				deleteImageById: function(id, callback, scope) {
					var deleteQuery = Ext.create("Terrasoft.DeleteQuery", {
						rootSchemaName: "SysImage"
					});
					deleteQuery.filters.add("GuidKey", Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Id", id));
					deleteQuery.execute(callback, scope);
				},

				/**
				 * @inheritdoc BasePageV2.onDiscardChangesClick
				 * @overridden
				 */
				onDiscardChangesClick: function() {
					var newPhotoId = this.get("NewPhotoId");
					if (newPhotoId) {
						this.deleteImageById(newPhotoId);
						this.set("NewPhotoId", null);
					}
					this.callParent(arguments);
				},

				/**
				 * Handles field collection in service response to update page field.
				 * @protected
				 * @param {Object} response EntityMappingService response.
				 */
				updatePageData: function(response) {
					this.parsePassportData(response);
					this.parseAddressDetailsData(response);
					this.setNewImageGuid(response);
					this.Terrasoft.each(response.columns, function(column) {
						var columnConfig = this.columns[column.Key] || {};
						column.Value = column.Value || undefined;
						var isDateTime = columnConfig.dataValueType === this.Terrasoft.DataValueType.DATE ||
							columnConfig.dataValueType === this.Terrasoft.DataValueType.TIME ||
							columnConfig.dataValueType === this.Terrasoft.DataValueType.DATE_TIME;
						if (!this.Ext.isEmpty(column.Value) && isDateTime) {
							column.Value = this.Terrasoft.parseDate(column.Value);
						}
						this.set(column.Key, column.Value);
					}, this);
				},

				/**
				 * Handles field collection to update contact passport data.
				 * @protected
				 * @param {Object} response EntityMappingService response.
				 */
				parsePassportData: function(response) {
					var passportValues = [{
						Key: "Number",
						Value: undefined
					}, {
						Key: "IssuedBy",
						Value: undefined
					}, {
						Key: "IssueDate",
						Value: undefined
					}, {
						Key: "CodeDivision",
						Value: undefined
					}, {
						Key: "Series",
						Value: undefined
					}];
					var detailsToRenderOnPage = response.details.filter(function(detail) {
						return detail.Key === "DocumentContactDetail";
					});
					if (detailsToRenderOnPage[0] && detailsToRenderOnPage[0].Value && detailsToRenderOnPage[0].Value[0]) {
						passportValues = detailsToRenderOnPage[0].Value[0];
					}
					response.columns = response.columns.concat(passportValues);
				},

				/**
				 * Handles field collection to check addresses detail view state.
				 * @protected
				 * @param {Object} response EntityMappingService response.
				 */
				parseAddressDetailsData: function(response) {
					var isEqual = false;
					var registrationAddressFieldsDetail = response.details.filter(function(detail) {
						return detail.Key === "RegistrationAddressFieldsDetail";
					});
					var placeOfResidenceAddressFieldsDetail = response.details.filter(function(detail) {
						return detail.Key === "PlaceOfResidenceAddressFieldsDetail";
					});
					if (placeOfResidenceAddressFieldsDetail[0].Value && registrationAddressFieldsDetail[0].Value) {
						isEqual = this.checkIsAddressEquals(placeOfResidenceAddressFieldsDetail[0].Value[0],
							registrationAddressFieldsDetail[0].Value[0]);
					}
					this.set("IsSameAddress", isEqual);
				},

				/**
				 * Handles detail collection in service response to update page details.
				 * @protected
				 * @param {Object} response EntityMappingService response.
				 */
				updateDetailsData: function(response) {
					this.Terrasoft.each(response.details, function(item) {
						this.updateDetailData(item);
					}, this);
				},

				/**
				 * Handles EntityMappingService response to update page fields and details.
				 * @protected
				 * @param {Object} response EntityMappingService response.
				 */
				parseContactData: function(response) {
					this.updatePageData(response);
					this.updateDetailsData(response);
				},

				/**
				 * Preloads detail.
				 * @param {String} detailName Detail name.
				 * @param {String} containerId Container id.
				 * @protected
				 */
				preloadDetail: function(detailName, containerId) {
					var parameterDetailConfig = {
						detailName: detailName,
						containerId: containerId,
						forceLoad: true
					};
					this.loadDetail(parameterDetailConfig);
				},

				/**
				 * @inheritdoc Terrasoft.mixins.FinApplicationProfileUtils#getFinApplicationConfig
				 * @overridden
				 */
				getFinApplicationConfig: function() {
					var finApplication = this.get("FinApplication");
					if (this.Ext.isEmpty(finApplication)) {
						return;
					}
					return {
						"finApplication": finApplication,
						"product": finApplication.Product
					};
				},

				/**
				 * Handles "IsSameAddress" property change.
				 * @protected
				 */
				onIsSameAddressChange: function() {
					var placeOfResidenceAddressDetailId = this.getDetailId("PlaceOfResidenceAddressFieldsDetail");
					var isSameAddress = this.get("IsSameAddress");
					this.sandbox.publish("SetDetailCollapsed", isSameAddress, [placeOfResidenceAddressDetailId]);
					this.sandbox.publish("SetCollapseLock", isSameAddress, [placeOfResidenceAddressDetailId]);
				},

				/**
				 * Handles field collection to check addresses detail view state.
				 * @protected
				 * @param {Object} addressDetailValues1 Array first address detail columns.
				 * @param {Object} addressDetailValues2 Array second address detail columns.
				 * @return {Boolean} Is detail values equals.
				 */
				checkIsAddressEquals: function(addressDetailValues1, addressDetailValues2) {
					var isEqual = false;
					if (addressDetailValues1 && addressDetailValues2) {
						isEqual = true;
						this.Terrasoft.each(addressDetailValues1, function(column, index) {
							if (column.Key === "AddressType" || !isEqual) {
								return;
							}
							isEqual = this.Terrasoft.isEqual(column.Value, addressDetailValues2[index].Value);
						}, this);
					}
					return isEqual;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#subscribeDetailsEvents
				 * @overridden
				 */
				subscribeDetailsEvents: function() {
					this.callParent(arguments);
					var placeOfResidenceAddressDetailId = this.getDetailId("PlaceOfResidenceAddressFieldsDetail");
					this.sandbox.subscribe("DetailLoaded", this.onIsSameAddressChange,
						this, [placeOfResidenceAddressDetailId]);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#discardDetailChange
				 * @overridden
				 */
				discardDetailChange: function() {
					this.callParent(arguments);
					this.onIsSameAddressChange();
				}

				//endregion
			},
			rules: {}
		};
	});
