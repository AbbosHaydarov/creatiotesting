define("PreconfiguredAppValidationPage", ["FinAppLendingConstants", "ImageCustomGeneratorV2",
		"css!FinAppLendingCSS", "AppValidationUtilities", "AppValidationChecklistDetail", "HtmlEditModule",
		"AppValFileDetail"
	],
	function(FinAppLendingConstants) {
		var AppValidationResultsEnum = FinAppLendingConstants.AppValidationResult;
		return {
			entitySchemaName: "AppValidation",
			details: /**SCHEMA_DETAILS*/ {
				"AppValidationChecklistDetail": {
					"schemaName": "AppValidationChecklistDetail",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "AppValidation"
					}
				},
				"AppValFileDetail": {
					"schemaName": "AppValFileDetail",
					"entitySchemaName": "AppValidationItemFile",
					"filter": {
						"masterColumn": "ValidationItem",
						"detailColumn": "AppValidationItem"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			messages: {
				/**
				 * @message Reload dashboard items.
				 */
				"ReloadDashboardItems": {
					mode: this.Terrasoft.MessageMode.BROADCAST,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			mixins: {
				"AppValidationUtilities": "Terrasoft.AppValidationUtilities"
			},
			attributes: {
				"ValidationItem": {
					"lookupListConfig": {
						"columns": ["Scenery"]
					}
				},
				"AppValidationItemScenery": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"ValidationResult": {
					"onChange": "updateHeaderStyle"
				},
				"IsFilesDetailVisible": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"value": false
				},
				"IsChecklistDetailVisible": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"value": false
				},
				"MiniPageModes": {
					dataValueType: this.Terrasoft.DataValueType.COLLECTION,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: [this.Terrasoft.ConfigurationEnums.CardOperation.EDIT]
				},
				"MainContainerHeightOffset": {
					dataValueType: this.Terrasoft.DataValueType.INTEGER,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: 60
				},
				"MinContainerWidth": {
					dataValueType: this.Terrasoft.DataValueType.INTEGER,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: 660
				}
			},
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseMiniPage#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([
						function() {
							this.getEntityInitializedSubscribers();
							this.subscribeDetailsEvents();
							this.Ext.callback(callback, scope);
						},
						this
					]);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overridden
				 */
				onSaved: function(callback, scope) {
					const parentMethod = this.getParentMethod();
					this.Terrasoft.chain(
						this.saveDetailsInChain,
						function() {
							parentMethod.call(this, callback, scope);
						},
						this
					);
				},

				/**
				 * Returns header icon link.
				 * @protected
				 * @return {String} Product lunk url.
				 */
				getHeaderIcon: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.VerificationHeaderIcon"));
				},

				/**
				 * Handles GetDetailFileItemsCount response.
				 * @param {Object} response Response object.
				 */
				onGetDetailFileCount: function(response) {
					var count = response && response.collection.getCount();
					this.set("IsFilesDetailVisible", count > 0);
				},

				/**
				 * Handles GetDetailFileItemsCount response.
				 * @param {Object} response Response object.
				 */
				onGetChecklistDetailItemsCount: function(response) {
					var count = response && response.collection.getCount();
					this.set("IsChecklistDetailVisible", count > 0);
				},

				/**
				 * Requests app validation files detail items count.
				 * @protected
				 */
				getFileDetailItemsCount: function() {
					var validationItem = this.get("ValidationItem");
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "AppValidationItemFile"
					});
					esq.filters.add("AppValidationItem", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "AppValidationItem", validationItem.value));
					esq.getEntityCollection(this.onGetDetailFileCount, this);
				},

				/**
				 * Requests app validation checklist detail items count.
				 * @protected
				 */
				getChecklistDetailtemsCount: function() {
					var validationId = this.get("Id");
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "AppValQuestionResult"
					});
					esq.filters.add("AppValidation", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "AppValidation", validationId));
					esq.getEntityCollection(this.onGetChecklistDetailItemsCount, this);
				},

				/**
				 * Handles verification result change.
				 * @param {Object} tag Button tag object.
				 * @protected
				 */
				setResult: function(arg0, arg1, arg2, tag) {
					this.set("ValidationResult", tag);
				},

				/**
				 * Handles Proceed button click.
				 * @protected
				 */
				onProceed: function() {
					if (this.Ext.isEmpty(this.get("ValidationResult"))) {
						this.showInformationDialog(this.get("Resources.Strings.ResultNotSetMessage"));
					} else {
						this.isSilentSave = true;
						this.save({
							isSilent: true,
							callback: this.Terrasoft.emptyFn,
							scope: this
						});
					}
				},

				/**
				 * Sets Scenery text box value from AppValidationItem.
				 * @protected
				 */
				updateSceneryText: function() {
					var validationItem = this.get("ValidationItem") || {};
					this.set("AppValidationItemScenery", validationItem.Scenery);
				},

				/**
				 * Check if button result is in allowed list.
				 * @protected
				 * @param {Object} tag Button tag object.
				 * @return {Boolean} true if button result allowed to set.
				 */
				isResultButtonVisible: function(tag) {
					var resultsAllowed = this.get("AllowedResult") || [];
					if (resultsAllowed.length === 0) {
						return true;
					} else if (resultsAllowed.length > 3) {
						return false;
					}
					return this.Ext.Array.contains(resultsAllowed, tag.value);
				},

				/**
				 * Check if button result is in allowed list.
				 * @protected
				 * @return {Boolean} true if custom results added.
				 */
				isResultEnumVisible: function() {
					var resultsAllowed = this.get("AllowedResult") || [];
					return resultsAllowed.length > 3;
				},

				/**
				 * Check if scenery text empty.
				 * @protected
				 * @return {Boolean} true if there anything to show in Scenery text box.
				 */
				isSceneryVisible: function() {
					return !this.Ext.isEmpty(this.get("AppValidationItemScenery"));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.getFileDetailItemsCount();
					this.getChecklistDetailtemsCount();
					this.updateSceneryText();
					this.updateHeaderStyle();
				},

				/**
				 * @inheritdoc Terrasoft.BaseMiniPageV2#loadMiniPageEntity
				 * @overridden
				 */
				loadMiniPageEntity: function(callback, scope) {
					this.callParent([function() {
						this.initAllowedResult(callback, scope);
					}, this]);
				},

				/**
				 * Generates button image based on current validation result state.
				 * @protected
				 * @param {Object} tag Button tag object.
				 * @return {Object} Button icon.
				 */
				getButtonIcon: function(tag) {
					var activeResult = this.get("ValidationResult") || {};
					var buttonState = activeResult.value === tag.value ? "Selected" : "";
					var image = this.Ext.String.format("Resources.Images.{0}Button{1}Image", tag.code, buttonState);
					return this.get(image);
				},

				/**
				 * Generates header corner background image based on current validation result state.
				 * @protected
				 * @return {Object} Background icon.
				 */
				getHeaderBackgroundImg: function() {
					var result = this.get("ValidationResult");
					result = this.updateTagCodeByValue(result);
					var backgroundImg = this.Ext.String.format("Resources.Images.HeaderBG{0}", result.code);
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get(backgroundImg));
				},

				/**
				 * Updates background style by setting result tag code for container marker.
				 * @protected
				 */
				updateHeaderStyle: function() {
					var result = this.get("ValidationResult");
					result = this.updateTagCodeByValue(result);
					if (result && result.code) {
						this.set("GeneralHeaderContainerMarker", result.code);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#onLookupDataLoaded
				 * @overridden
				 */
				onLookupDataLoaded: function(config) {
					this.callParent(arguments);
					if (config && config.columnName === "ValidationResult" && config.objects) {
						var objects = config.objects;
						for (var property in objects) {
							objects[property] = this.updateTagCodeByValue(objects[property]);
						}
					}
				},

				/**
				 * Finds tag in AppValidationResult emun matched by result id value.
				 * @protected
				 * @param {Object} result Validation result lookup object.
				 * @return {Object} Validation result lookup object merged with tag.
				 */
				updateTagCodeByValue: function(result) {
					var tag = {
						code: ""
					};
					if (result) {
						var results = Object.getOwnPropertyNames(AppValidationResultsEnum);
						this.Terrasoft.each(results, function(item) {
							if (AppValidationResultsEnum[item].value === result.value) {
								tag = AppValidationResultsEnum[item];
								return false;
							}
						}, this);
					}
					return this.Ext.merge(tag, result);
				},

				/**
				 * Sets AlignableMiniPage container width.
				 * @protected
				 * @param {Object} container Mini page content container.
				 */
				updateMiniPageContentContainerWidth: function(container) {
					var miniPageContentContainer = this.Ext.get("MiniPageContentContainer");
					var minContainerWidth = this.get("MinContainerWidth");
					if (container && miniPageContentContainer) {
						var alignToEl = container.alignToEl;
						var alignToElWidth = alignToEl.getWidth();
						var width = minContainerWidth > alignToElWidth ? minContainerWidth : alignToElWidth;
						miniPageContentContainer.applyStyles({
							"width": width + "px"
						});
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseMiniPageV2#updateMaxHeight
				 * @overridden
				 */
				updateMaxHeight: function(container) {
					var miniPageContainer = this.Ext.get("MiniPageContentContainer");
					if (miniPageContainer) {
						var maxHeight;
						var offset = this.get("MainContainerHeightOffset");
						var documentHeight = document.body.clientHeight;
						var alignToEl = container.alignToEl;
						maxHeight = documentHeight - (alignToEl.getY() + offset);
						miniPageContainer.applyStyles({
							"max-height": maxHeight + "px"
						});
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseMiniPageV2#adjustMiniPagePosition
				 * @overridden
				 */
				adjustMiniPagePosition: function(callback, scope) {
					var container = this.Ext.getCmp("AlignableMiniPageContainer");
					if (this.entitySchemaName) {
						this.updateMiniPageContentContainerWidth(container);
						this.updateMaxHeight(container);
					}
					this.Ext.callback(callback, scope || this);
				}

				//endregion
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "remove",
				"name": "AlignableMiniPageContainer"
			}, {
				"operation": "insert",
				"name": "AppValidationPageContainer",
				"values": {
					"id": "AppValidationPageContainer",
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["appvalidation-minipage-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "AlignableMiniPageContainer",
				"parentName": "AppValidationPageContainer",
				"propertyName": "items",
				"values": {
					"id": "AlignableMiniPageContainer",
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"className": "Terrasoft.AlignableContainer",
					"wrapClass": ["minipage-alignable-container"],
					"alignToEl": {
						"bindTo": "AlignToEl"
					},
					"showOverlay": {
						"bindTo": "isNotViewMode"
					},
					"alignOrder": [
						this.Terrasoft.AlignType.TOP_LEFT
					],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "MiniPageContentContainer",
				"parentName": "AlignableMiniPageContainer",
				"propertyName": "items",
				"values": {
					"id": "MiniPageContentContainer",
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["minipage-content-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "MiniPageContentContainer",
				"propertyName": "items",
				"name": "AppValidationCardContentWrapper",
				"values": {
					"id": "AppValidationCardContentWrapper",
					"selectors": {
						"wrapEl": "#AppValidationCardContentWrapper"
					},
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["card-content-container", "appvalidation-page-modal-box"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "AppValidationCardContentWrapper",
				"propertyName": "items",
				"name": "ModalCardContentContainer",
				"values": {
					"visible": {
						"bindTo": "IsEntityInitialized"
					},
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["modal-box-card-content-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ModalCardContentContainer",
				"propertyName": "items",
				"name": "GeneralHeaderContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"markerValue": {
						"bindTo": "GeneralHeaderContainerMarker"
					},
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "GeneralHeaderContainer",
				"propertyName": "items",
				"name": "HeaderContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["header", "header-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "HeaderContainer",
				"propertyName": "items",
				"name": "HeaderIconContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["header-icon-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "HeaderIcon",
				"parentName": "HeaderIconContainer",
				"propertyName": "items",
				"values": {
					"getSrcMethod": "getHeaderIcon",
					"readonly": true,
					"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
					"classes": {
						"wrapClass": ["header-icon"]
					}
				}
			}, {
				"operation": "insert",
				"parentName": "HeaderContainer",
				"propertyName": "items",
				"name": "HeaderCaptionContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["header-caption-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "HeaderCaptionContainer",
				"propertyName": "items",
				"name": "Name",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"markerValue": {
						"bindTo": "Name"
					},
					"caption": {
						"bindTo": "Name"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "HeaderContainer",
				"propertyName": "items",
				"name": "CloseButtonContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["close-btn-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "HeaderBackground",
				"parentName": "CloseButtonContainer",
				"propertyName": "items",
				"values": {
					"getSrcMethod": "getHeaderBackgroundImg",
					"readonly": true,
					"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
					"classes": {
						"wrapClass": ["background-img"]
					}
				}
			}, {
				"operation": "insert",
				"name": "CloseButton",
				"parentName": "CloseButtonContainer",
				"propertyName": "items",
				"values": {
					"click": {
						"bindTo": "close"
					},
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"hint": {
						"bindTo": "Resources.Strings.CloseButtonHint"
					},
					"imageConfig": {
						"bindTo": "Resources.Images.CloseButtonImage"
					},
					"markerValue": "CloseIconButton",
					"classes": {
						"wrapperClass": ["close-btn"]
					}
				}
			}, {
				"operation": "insert",
				"parentName": "GeneralHeaderContainer",
				"propertyName": "items",
				"name": "HeaderActionsContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["header-actions-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "ToWorkButton",
				"parentName": "HeaderActionsContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"visible": {
						"bindTo": "isResultButtonVisible"
					},
					"caption": {
						"bindTo": "Resources.Strings.ToWorkButtonCaption"
					},
					"tag": AppValidationResultsEnum.ToWork,
					"click": {
						"bindTo": "setResult"
					},
					"imageConfig": {
						"bindTo": "getButtonIcon"
					},
					"markerValue": "ToWorkIconButton",
					"classes": {
						"wrapperClass": ["action-btn"]
					}
				}
			}, {
				"operation": "insert",
				"name": "ApprovedButton",
				"parentName": "HeaderActionsContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"visible": {
						"bindTo": "isResultButtonVisible"
					},
					"caption": {
						"bindTo": "Resources.Strings.ApprovedButtonCaption"
					},
					"tag": AppValidationResultsEnum.Approved,
					"click": {
						"bindTo": "setResult"
					},
					"imageConfig": {
						"bindTo": "getButtonIcon"
					},
					"markerValue": "ApprovedIconButton",
					"classes": {
						"wrapperClass": ["action-btn"]
					}
				}
			}, {
				"operation": "insert",
				"name": "NotApprovedButton",
				"parentName": "HeaderActionsContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"visible": {
						"bindTo": "isResultButtonVisible"
					},
					"caption": {
						"bindTo": "Resources.Strings.NotApprovedButtonCaption"
					},
					"tag": AppValidationResultsEnum.NotApproved,
					"click": {
						"bindTo": "setResult"
					},
					"imageConfig": {
						"bindTo": "getButtonIcon"
					},
					"markerValue": "NotApprovedIconButton",
					"classes": {
						"wrapperClass": ["action-btn"]
					}
				}
			}, {
				"operation": "insert",
				"name": "ValidationResult",
				"parentName": "HeaderActionsContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.ENUM,
					"bindTo": "ValidationResult",
					"wrapClass": ["custom-result-enum"],
					"visible": {
						"bindTo": "isResultEnumVisible"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "HeaderActionsContainer",
				"propertyName": "items",
				"name": "ProceedButtonContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["proceed-btn-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"name": "ProceedButton",
				"parentName": "ProceedButtonContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"style": this.Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": {
						"bindTo": "Resources.Strings.ProceedButtonCaption"
					},
					"tag": "proceed",
					"click": {
						"bindTo": "onProceed"
					},
					"markerValue": "ProceedButton"
				}
			}, {
				"operation": "insert",
				"parentName": "ModalCardContentContainer",
				"name": "BodyContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["body-container"],
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "BodyContainer",
				"name": "ContentLayout",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "ContentLayout",
				"name": "CommentContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["comment-container"],
					"items": [],
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24,
						"rowSpan": 2
					}
				}
			}, {
				"operation": "insert",
				"name": "Comment",
				"parentName": "CommentContainer",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.LONG_TEXT,
					"bindTo": "Comment",
					"labelConfig": {
						"visible": false
					},
					"placeholder": {
						"bindTo": "Resources.Strings.CommentPlaceholder"
					},
					"wrapClass": ["square-border"]
				},
				"index": 0
			}, {
				"operation": "insert",
				"name": "SceneryControlGroup",
				"parentName": "ContentLayout",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
					"caption": {
						"bindTo": "Resources.Strings.SceneryCaption"
					},
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					},
					"visible": {
						"bindTo": "isSceneryVisible"
					},
					"collapsed": false,
					"items": []
				},
				"index": 1
			}, {
				"operation": "insert",
				"name": "AppValidationItemScenery",
				"parentName": "SceneryControlGroup",
				"propertyName": "items",
				"values": {
					"contentType": this.Terrasoft.ContentType.RICH_TEXT,
					"labelConfig": {
						"visible": false
					},
					"enabled": false,
					"wrapClass": ["margin-as-detail"]
				}
			}, {
				"operation": "insert",
				"parentName": "BodyContainer",
				"name": "DetailContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			}, {
				"operation": "insert",
				"parentName": "DetailContainer",
				"propertyName": "items",
				"name": "AppValFileDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "IsFilesDetailVisible"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "DetailContainer",
				"propertyName": "items",
				"name": "AppValidationChecklistDetail",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "IsChecklistDetailVisible"
					}
				}
			}] /**SCHEMA_DIFF*/
		};
	});
