define("OBSWConsultationThemeList", ["terrasoft", "ext-base", "ContainerList", "css!OBSWConsultationThemeList"],
	function(Terrasoft, Ext) {

		/**
		 * ##### ######### ########### ######### ############.
		 */
		Ext.define("Terrasoft.controls.OBSWConsultationThemeList", {
			extend: "Terrasoft.ContainerList",
			alternateClassName: "Terrasoft.OBSWConsultationThemeList",

			//region Fields: Protected

			/**
			 * ############# ####### ######.
			 * @type {Guid}
			 */
			currentFolder: "",

			/**
			 * #### ####.
			 * @type {String}
			 */
			backgroundColor: "",

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.ContainerList#getCustomItemConfig
			 * @overriden
			 */
			getCustomItemConfig: function(item) {
				var colorStyle = {
					wrapStyles: {
						"background-color": this.backgroundColor
					}
				};
				var backgroundImageStyle = {};
				if (!item.get("IsFolder")) {
					backgroundImageStyle = {
						wrapStyles: {
							"background-image": "none"
						}
					};
				}
				var config = {
					className: "Terrasoft.Container",
					id: "consultation-theme",
					classes: {
						wrapClassName: ["consultation-theme"]
					},
					visible: {
						bindTo: "Visible"
					},
					styles: colorStyle,
					items: [{
							className: "Terrasoft.Container",
							id: "consultation-theme-label-container",
							classes: {
								wrapClassName: ["consultation-theme-label-container"]
							},
							styles: backgroundImageStyle,
							items: [{
								className: "Terrasoft.Label",
								id: "consultation-theme-label",
								caption: {
									bindTo: "Name"
								},
								classes: {
									labelClass: ["consultation-theme-label"]
								}
							}]
						}]
				};
				return config;
			},

			/**
			 * @inheritdoc Terrasoft.Bindable#getBindConfig
			 * @overridden
			 */
			getBindConfig: function() {
				var bindConfig = this.callParent(arguments);
				var gridBindConfig = {
					currentFolder: {
						changeMethod: "setCurrentFolder",
						changeEvent: "changeCurrentFolder"
					}
				};
				return Ext.apply(gridBindConfig, bindConfig);
			},

			/**
			 * ##### ########## ####### ######.
			 * @protected
			 * @param {Guid} currentFolder ############### ########.
			 */
			setCurrentFolder: function(currentFolder) {
				this.currentFolder = currentFolder;
			},

			/**
			 * ############ click ## ###### ######## ##########.
			 * @protected
			 * @param {String} itemId ############# ###### # #########.
			 */
			onItemClick: function(itemId) {
				var item = this.collection.get(itemId);
				if (item) {
					if (item.get("IsFolder") === true) {
						this.setCurrentFolder(item.get("Id"));
						this.fireEvent("changeCurrentFolder", this.currentFolder, this);
					} else {
						item.onItemClick();
					}
				}
			}

			//endregion

		});

	});
