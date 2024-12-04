define("OBSWConsultationThemeMixin", ["OBSWConsultationBlockList", "OBSWConsultationThemeList",
		"ConsultationThemeViewModel", "ConsultationBlockViewModel"
	],
	function() {
		/**
		 * @class Terrasoft.configuration.mixins.OBSWConsultationThemeMixin
		 * ######, ########### ###### # ###### ############.
		 */
		Ext.define("Terrasoft.configuration.mixins.OBSWConsultationThemeMixin", {
			alternateClassName: "Terrasoft.OBSWConsultationThemeMixin",

			//region Methods: Protected

			/**
			 * ############## #########.
			 * @protected
			 */
			initConsultationThemes: function() {
				this.set("ConsultationThemesCollection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
			},

			/**
			 * ####### #########.
			 * @protected
			 */
			clearConsultationThemes: function() {
				var consultationThemesCollection = this.get("ConsultationThemesCollection");
				consultationThemesCollection.clear();
			},

			/**
			 * ######### # ######### #### ############.
			 * @protected
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ###### ####### ######### ######.
			 */
			loadConsultationThemes: function(callback, scope) {
				var esq = this.getConsultationThemeSelect();
				esq.getEntityCollection(function(response) {
					if (response.success === true) {
						this.set("ConsultationThemeRawCollection", response.collection);
						this.initConsultationThemeBlocks();
					}
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this);
					}
				}, this);
			},

			/**
			 * ########## ###### ######### ### ############.
			 * @protected
			 * @return {Terrasoft.EntitySchemaQuery} ###### ######### ### ############.
			 */
			getConsultationThemeSelect: function() {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "ConsultationTheme",
					serverESQCacheParameters: {
						cacheLevel: this.Terrasoft.ESQServerCacheLevels.SESSION,
						cacheGroup: "ConsultationThemes",
						cacheItemName: ""
					}
				});
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
				esq.addColumn("Name");
				esq.addColumn("ProcessSchema.Id", "ProcessSchemaId");
				esq.addColumn("Position");
				esq.addColumn("Parent.Id", "ParentId");
				esq.addColumn("IsFolder");
				esq.addColumn("Block.Id", "BlockId");
				esq.addColumn("Block.Name", "BlockName");
				esq.addColumn("Block.Position", "BlockPosition");
				esq.addColumn("Block.CaptionColor", "CaptionColor");
				esq.addColumn("Block.ItemColor", "ItemColor");
				esq.filters.add(esq.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL,
					"Block.UseInOBSW",
					true));
				return esq;
			},

			/**
			 * ########## ######### ##### # ### ## ############## #####.
			 * @protected
			 * @param {Guid} blockId ############# #####.
			 * @return {Terrasoft.BaseViewModelCollection} ######### ##### # ###.
			 */
			getConsultationThemeCollection: function(blockId) {
				var collection = this.get("ConsultationThemeRawCollection");
				var items = this.Ext.create("Terrasoft.BaseViewModelCollection");
				Terrasoft.each(collection.getItems(), function(item) {
					var itemId = item.get("Id");
					if (item.get("BlockId") === blockId) {
						if (!items.contains(itemId)) {
							var newItem = this.createConsultationTheme(item);
							items.add(itemId, newItem);
						}
					}
				}, this);
				items.sort("Name", Terrasoft.OrderDirection.ASC, this.getSortFunction("Name"));
				return items;
			},

			/**
			 * ####### ###### ###### ### #### ############.
			 * @protected
			 * @param  {Object} item ####### #### ############.
			 * @return {Terrasoft.ConsultationThemeViewModel} ###### ###### ### #### ############.
			 */
			createConsultationTheme: function(item) {
				var caseId = this.get("CaseId");
				var contactId = this.get("ContactId");
				var newItem = this.Ext.create("Terrasoft.ConsultationThemeViewModel", {
					Ext: this.Ext,
					sandbox: this.sandbox,
					Terrasoft: this.Terrasoft,
					values: {
						Id: item.get("Id"),
						Name: item.get("Name"),
						CaseId: caseId,
						ContactId: contactId,
						ProcessSchemaId: item.get("ProcessSchemaId"),
						Position: item.get("Position"),
						ParentId: item.get("ParentId"),
						IsFolder: item.get("IsFolder"),
						ItemColor: item.get("ItemColor"),
						Visible: (item.get("ParentId") === "")
					}
				});
				return newItem;
			},

			/**
			 * ############## ##### ###.
			 * @protected
			 */
			initConsultationThemeBlocks: function() {
				var collection = this.get("ConsultationThemeRawCollection");
				var consultationThemesCollection = this.get("ConsultationThemesCollection");
				var blocks = this.Ext.create("Terrasoft.BaseViewModelCollection");
				Terrasoft.each(collection.getItems(), function(item) {
					var itemId = item.get("BlockId");
					if (!blocks.contains(itemId)) {
						var newItem = this.createConsultationBlock(item);
						blocks.add(itemId, newItem);
					}
				}, this);
				blocks.sort("Position", Terrasoft.OrderDirection.ASC, this.getSortFunction("Position"));
				consultationThemesCollection.clear();
				consultationThemesCollection.loadAll(blocks);
			},

			/**
			 * ####### ###### ##### ### ############.
			 * @protected
			 * @param  {Object} item ####### #####.
			 * @return {Terrasoft.ConsultationBlockViewModel} ###### #### ### ############.
			 */
			createConsultationBlock: function(item) {
				var itemId = item.get("BlockId");
				var newItem = this.Ext.create("Terrasoft.ConsultationBlockViewModel", {
					Ext: this.Ext,
					sandbox: this.sandbox,
					Terrasoft: this.Terrasoft,
					values: {
						Id: itemId,
						Name: item.get("BlockName"),
						BlockCaption: item.get("BlockName"),
						Position: item.get("BlockPosition"),
						Items: this.getConsultationThemeCollection(itemId),
						CaptionColor: item.get("CaptionColor"),
						ItemColor: item.get("ItemColor"),
						CurrentFolder: ""
					}
				});
				return newItem;
			},

			/**
			 * ########## ####### ##########.
			 * @protected
			 * @param {String} propertyName ### ######## ## ######## ############ ##########.
			 * @return {Function} ####### ##########.
			 */
			getSortFunction: function(propertyName) {
				var sortFn = function(object1, object2) {
					var property1 = object1.get(propertyName);
					var property2 = object2.get(propertyName);
					if (property1 === property2) {
						return 0;
					}
					return (property1 < property2) ? -1 : 1;
				};
				return sortFn;
			}

			//endregion

		});

		return Terrasoft.OBSWConsultationThemeMixin;
	});
