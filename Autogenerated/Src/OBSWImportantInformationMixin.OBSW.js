define("OBSWImportantInformationMixin", ["ModuleUtils", "ImportantInformationItemViewModel", 
		"css!OBSWImportantInformationMixin"],
	function(ModuleUtils) {
		/**
		 * @class Terrasoft.configuration.mixins.OBSWImportantInformationMixin
		 * ######, ########### ###### # ###### ###########.
		 */
		Ext.define("Terrasoft.configuration.mixins.OBSWImportantInformationMixin", {
			alternateClassName: "Terrasoft.OBSWImportantInformationMixin",

			//region Methods: Protected

			/**
			 * ############## #########.
			 * @protected
			 */
			initImportantInformation: function() {
				this.set("ImportantInformationCollection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
			},

			/**
			 * ####### #########.
			 * @protected
			 */
			clearImportantInformation: function() {
				var importantInformationCollection = this.get("ImportantInformationCollection");
				importantInformationCollection.clear();
			},

			/**
			 * ############## ########## ######### # ########.
			 * @protected
			 * @param {Object} config ###### #######.
			 * @param {String} config.schemaName ### ##### ########.
			 * @param {Guid} config.contactId ############# ########.
			 * @param {String} config.columnPath #### # ########### ####### ############ ######## ##### rootSchema.
			 * @param {Terrasoft.FilterGroup} config.filterGroup (optional) ###### ############## ########.
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ###### ####### ######### ######.
			 */
			initEntityCount: function(config, callback, scope) {
				if (!config) {
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this);
					}
				}
				var schemaName = config.schemaName;
				var contactId = config.contactId;
				var columnPath = config.columnPath;
				var filterGroup = config.filterGroup;
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: schemaName
				});
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
				esq.filters.add("ContactFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					columnPath,
					contactId));
				if (filterGroup) {
					esq.filters.add("OtherFilter", filterGroup);
				}
				esq.getEntityCollection(function(result) {
					this.initEntityCountCallback(result, config, callback, scope);
				}, this);
			},

			/**
			 * Callback ####### ## ######### ########## #########.
			 * @protected
			 * @param {Object} result ######### ########## #######.
			 * @param {Object} config ###### #######.
			 * @param {String} config.schemaName ### ##### ########.
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ###### ####### ######### ######.
			 */
			initEntityCountCallback: function(result, config, callback, scope) {
				var schemaName = config.schemaName;
				if (result.success) {
					var entityCollection = result.collection;
					var count = !this.Ext.isEmpty(entityCollection) ? entityCollection.getCount() : 0;
					if (count > 0) {
						var importantInformationItem = this.getImportantInformationItem({
							className: "Terrasoft.Hyperlink",
							schemaName: schemaName
						});
						importantInformationItem.set("EntityCount", count);
						var labelCaption = this.get("Resources.Strings." + schemaName + "CountLabelCaption");
						var formatString = this.Ext.String.format(labelCaption, count);
						importantInformationItem.set("LabelCaption", formatString);
						var icon = this.get("Resources.Images." + schemaName + "Image");
						importantInformationItem.set("Icon", icon);
						if (count === 1) {
							var entity = entityCollection.getByIndex(0);
							importantInformationItem.set("EntityId", entity.get("Id"));
						}
						var importantInformationCollection = this.get("ImportantInformationCollection");
						importantInformationCollection.addItem(importantInformationItem);
						if (Terrasoft.isAngularHost) {
							this.showModuleInWorkplace(schemaName);
						}
					}
				}
				if (this.Ext.isFunction(callback)) {
					callback.call(scope || this);
				}
			},

			/**
			 * Sets module structure hide parameter to false.
			 * @protected
			 * @param {String} schemaName Entity schema name.
			 */
			showModuleInWorkplace: function(schemaName) {
				var moduleStructure = ModuleUtils.getModuleStructureByName(schemaName);
				if (moduleStructure) {
					moduleStructure.hide = "false";
				}
			},

			/**
			 * ######### view ###### ########.
			 * @protected
			 * @param  {Object} itemConfig View ###### ########.
			 * @param  {Terrasoft.BaseViewModel} item ViewModel ########.
			 */
			getImportantInformationItemViewConfig: function(itemConfig, item) {
				var className = item.get("ClassName");
				var click = item.get("Click");
				var tag = item.get("Tag") || "";
				var mainItemContainer = {
					className: "Terrasoft.Container",
					classes: {
						wrapClassName: ["important-information-item-container"]
					},
					markerValue: "",
					items: []
				};
				var itemLabelContainer = {
					className: "Terrasoft.Container",
					classes: {
						wrapClassName: ["important-information-item-label-container"]
					},
					items: []
				};
				var itemLabel = {
					className: className || "Terrasoft.Label",
					caption: {
						bindTo: "LabelCaption"
					},
					hint: {
						bindTo: "LabelHint"
					},
					classes: {
						labelClass: ["important-information-item-label"]
					},
					markerValue: tag
				};
				if (click) {
					itemLabel.click = click;
				}
				itemLabelContainer.items.push(itemLabel);
				var icon = item.get("Icon");
				if (icon) {
					var iconUrl = this.Terrasoft.ImageUrlBuilder.getUrl(icon);
					var iconContainer = {
						className: "Terrasoft.Container",
						classes: {
							wrapClassName: ["important-information-item-icon-container"]
						},
						styles: {
							wrapStyles: {
								"background-image": "url(" + iconUrl + ")"
							}
						},
						markerValue: ""
					};
					mainItemContainer.items.push(iconContainer);
				}
				mainItemContainer.items.push(itemLabelContainer);
				itemConfig.config = mainItemContainer;
			},

			/**
			 * ########## ####### ###### ##########.
			 * @protected
			 * @param {Object} config ###### #######.
			 * @param {String} config.schemaName ### ##### ########.
			 * @param {String} config.tag (optional) ### ########.
			 * @param {String} config.className (optional) ### ###### ########## ########.
			 * @param  {[type]} config [description]
			 * @return Terrasoft.ImportantInformationItemViewModel ####### ###### ##########.
			 */
			getImportantInformationItem: function(config) {
				var schemaName = config.schemaName;
				var tag = config.tag || schemaName;
				return this.Ext.create("Terrasoft.ImportantInformationItemViewModel", {
					Ext: this.Ext,
					Terrasoft: this.Terrasoft,
					sandbox: this.sandbox,
					values: {
						Id: this.Terrasoft.generateGUID(),
						ClassName: config.className || "Terrasoft.Label",
						SchemaName: schemaName,
						Tag: tag,
						Click: {
							bindTo: "onNavigateTo"
						}
					}
				});
			}

			//endregion
		});
		return Terrasoft.OBSWImportantInformationMixin;
	});
