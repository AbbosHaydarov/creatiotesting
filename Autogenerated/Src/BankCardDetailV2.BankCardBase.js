define("BankCardDetailV2", ["BankCardDetailV2Resources"], function() {
	return {
		entitySchemaName: "BankCard",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "ActionsButton",
				"parentName": "Detail",
				"values": {
					"visible": {"bindTo": "getToolButtonsVisible"}
				}
			}
		]/**SCHEMA_DIFF*/,
		methods: {
			/**
			 * ######### ######## ####### ###### # ######### ########### ###### ############## ######.
			 * @overridden
			 */
			getAddRecordButtonVisible: function() {
				return !this.isNeedHideItem() && this.getToolsVisible();
			},
			/**
			 * ########## ####### ########### ###### ############## ######, ########## ## ############## ######.
			 * @protected
			 * @overridden
			 * @return {BaseViewModel} ####### ########### ###### ############## ######, ########## ##
			 * ############## ######.
			 */
			getCopyRecordMenuItem: function() {
				return this.isNeedHideItem() ? null : this.callParent();
			},
			/**
			 * ########## ####### ########### ###### ############## ######, ########## ## ########### ######.
			 * @protected
			 * @overridden
			 * @return {BaseViewModel} ####### ########### ###### ############## ######, ########## ## ###########
			 * ######.
			 */
			getEditRecordMenuItem: function() {
				return this.isNeedHideItem() ? null : this.callParent();
			},
			/**
			 * ########## ####### ########### ###### ############## ######, ########## ## ######## ######.
			 * @protected
			 * @overridden
			 * @return {BaseViewModel} ####### ########### ###### ############## ######, ########## ## ########
			 * ######.
			 */
			getDeleteRecordMenuItem: function() {
				return this.isNeedHideItem() ? null : this.callParent();
			},
			/**
			 * ########## ############# ####### ###### ####
			 * @returns {boolean}
			 */
			isNeedHideItem: function() {
				var cardPageName = this.get("CardPageName");
				return cardPageName === "ContactPageV2";
			}
		}
	};
});
