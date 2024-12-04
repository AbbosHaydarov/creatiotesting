define("OBSWConsultationBlockList", ["terrasoft", "ext-base", "OBSWConsultationBlockListResources",
		"ContainerList", "css!OBSWConsultationBlockList"
	],
	function(Terrasoft, Ext, resources) {
		/**
		 * The class implements the display of the collection of consultations.
		 */
		Ext.define("Terrasoft.controls.OBSWConsultationBlockList", {
			extend: "Terrasoft.ContainerList",
			alternateClassName: "Terrasoft.OBSWConsultationBlockList",

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.ContainerList#getCustomItemConfig
			 * @override
			 */
			getCustomItemConfig: function(item) {
				var colorstyle = {
					wrapStyles: {
						"background-color": item.get("CaptionColor")
					}
				};
				var config = {
					className: "Terrasoft.Container",
					id: "item",
					classes: {
						wrapClassName: ["consultation-block"]
					},
					items: [{
						className: "Terrasoft.Container",
						id: "consultation-block-head-panel",
						classes: {
							wrapClassName: ["consultation-block-head-panel"]
						},
						items: [{
							className: "Terrasoft.Container",
							id: "consultation-block-head-panel-caption-container",
							classes: {
								wrapClassName: ["consultation-block-head-panel-caption-container"]
							},
							items: [{
								className: "Terrasoft.Label",
								id: "consultation-block-head-panel-caption",
								caption: {
									bindTo: "BlockCaption"
								},
								classes: {
									labelClass: ["consultation-block-head-panel-caption"]
								}
							}]
						}, {
							className: "Terrasoft.Button",
							classes: {
								wrapperClass: "consultation-block-head-panel-close-button"
							},
							markerValue: "consultation-block-head-panel-close-button",
							style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							imageConfig: resources.localizableImages.CloseButton,
							visible: {
								bindTo: "CloseButtonVisible"
							},
							click: {
								bindTo: "onCloseButtonClick"
							}
						}]
					}, {
						className: "Terrasoft.Container",
						classes: {
							wrapClassName: ["consultation-block-color-panel"]
						},
						styles: colorstyle
					}, {
						className: "Terrasoft.OBSWConsultationThemeList",
						id: "consultation-theme",
						dataItemIdPrefix: "consultation-theme",
						rowCssSelector: ".consultation-theme",
						backgroundColor: item.get("ItemColor"),
						classes: {
							wrapClassName: ["consultation-themes-container"]
						},
						idProperty: "Id",
						collection: {
							bindTo: "Items"
						},
						currentFolder: {
							bindTo: "CurrentFolder"
						},
						itemPrefix: "consultation-theme"
					}]
				};
				return config;
			}

			//endregion

		});
	});
