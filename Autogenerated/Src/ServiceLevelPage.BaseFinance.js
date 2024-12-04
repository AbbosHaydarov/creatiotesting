define("ServiceLevelPage", ["ServiceLevelPageResources", "css!ServiceLevelCSS", "ContentImageUtilitiesV2"],
	function(resources) {
		return {
			entitySchemaName: "ServiceLevel",
			mixins: {
				ContentImageUtilities: "Terrasoft.ContentImageUtilities"
			},
			diff: /**SCHEMA_DIFF*/ [{
				"operation": "insert",
				"name": "Name",
				"values": {
					"layout": {
						"column": 4,
						"row": 0,
						"colSpan": 20,
						"rowSpan": 1
					}
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			}, {
				"operation": "insert",
				"name": "Description",
				"values": {
					"layout": {
						"column": 4,
						"row": 1,
						"colSpan": 20,
						"rowSpan": 1
					},
					"contentType": this.Terrasoft.ContentType.LONG_TEXT
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "ImageContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["image-edit-container"],
					"layout": {
						"column": 0,
						"row": 0,
						"rowSpan": 5,
						"colSpan": 4
					},
					"items": []
				},
				"index": 2
			}, {
				"operation": "insert",
				"parentName": "ImageContainer",
				"propertyName": "items",
				"name": "Image",
				"values": {
					"getSrcMethod": "getImageUrl",
					"onPhotoChange": "onImageChange",
					"beforeFileSelected": "beforeFileSelected",
					"readonly": false,
					"defaultImage": this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.DefaultImage),
					"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
				}
			}, {
				"operation": "remove",
				"name": "ESNTab"
			}, {
				"operation": "remove",
				"name": "ESNFeedContainer"
			}, {
				"operation": "remove",
				"name": "ESNFeed"
			}] /**SCHEMA_DIFF*/ ,
			methods: {
				/**
				 * @inheritdoc Terrasoft.BasePageV2#onCloseClick
				 * @overridden
				 */
				onCloseClick: function() {
					this.sandbox.publish("BackHistoryState");
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initHeaderCaption
				 * @overridden
				 */
				initHeaderCaption: function() {
					this.sandbox.publish("InitDataViews", {
						caption: this.entitySchema.caption
					});
				}
			}
		};
	});
