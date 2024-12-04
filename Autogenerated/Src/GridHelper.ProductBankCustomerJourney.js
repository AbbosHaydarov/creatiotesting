define("GridHelper", [], function() {
	Ext.define("Terrasoft.configuration.mixins.GridHelper", {

		alternateClassName: "Terrasoft.GridHelper",

		/**
		 * ####### config ###### ####### ### ########## ###########.
		 * @param {Terrasoft.BaseViewModel} item ####### #######.
		 * @return {Object} config ###### #######.
		 * @protected
		 */
		createPrimaryDisplayColumnLink: function(item) {
			var editPages = this.get("EditPages");
			var typeColumnValue = this.getTypeColumnValue(item);
			var editPage = editPages.get(typeColumnValue);
			var recordId = item.get(item.primaryColumnName);
			var schemaName = editPage.get("SchemaName");
			var displayValue = item.get(item.primaryDisplayColumnName);
			var url = ["CardModuleV2", schemaName, "edit", recordId];
			var link = this.Terrasoft.workspaceBaseUrl + "/NUI/ViewModule.aspx#" + url.join("/");
			return {
				caption: displayValue,
				target: "_self",
				title: displayValue,
				url: link
			};
		},

		/**
		 * ######### #####, ############ ############ ###### # ###### #######.
		 * @protected
		 * @param {Terrasoft.BaseViewModel} item ####### #######.
		 * @param {Object} column ####### ######## #######.
		 */
		addOpenCardColumnLink: function(item, column) {
			var columnPath = column.columnPath;
			var linkConfig = this.createPrimaryDisplayColumnLink(item);
			item["on" + columnPath + "LinkClick"] = function() {
				return {
					caption: linkConfig.caption,
					target: linkConfig.target,
					title: linkConfig.title,
					url: linkConfig.url
				};
			};
		}
	});

	return Ext.create("Terrasoft.GridHelper");
});
