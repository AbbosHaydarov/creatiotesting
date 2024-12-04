define("BaseProductCategoryAndTypeEditPage", ["ConfigurationEnums", "ModalBox"], function(Enums, ModalBox) {
	return {
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "BaseProductCategoryAndTypeEditPageContainer",
				"values": {
					"generateId": false,
					"wrapClass": ["category-page-container"],
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "Header",
				"parentName": "BaseProductCategoryAndTypeEditPageContainer",
				"propertyName": "items",
				"values": {
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["header-container"],
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "HeaderLabelContainer",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "HeaderLabel",
				"parentName": "HeaderLabelContainer",
				"propertyName": "items",
				"values": {
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.EditPageCaption"},
					"labelClass": ["modalbox-caption"]
				}
			},
			{
				"operation": "insert",
				"name": "ControlsContainer",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "ActionButtonsContainer",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"visible": true,
					"wrapClass": ["actions-container"],
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"name": "SelectButton",
				"values": {
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": {"bindTo": "Resources.Strings.SelectButtonCaption"},
					"click": {"bindTo": "onSaveButtonClick"}
				}
			},
			{
				"operation": "insert",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"name": "CancelButton",
				"values": {
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {"bindTo": "Resources.Strings.CancelButtonCaption"},
					"click": {"bindTo": "onCloseButtonClick"}
				}
			}
		]/**SCHEMA_DIFF*/,
		messages: {
			/**
			 * @message GetEntityInfo
			 */
			"GetEntityInfo": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message SaveEntity
			 */
			"SaveEntity": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		methods: {

			/**
			 * @inheritDoc Terrasoft.BaseSchemaViewModel#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.setEntityInfo();
					this.initEntity(callback, scope);
				}, this]);
			},

			/**
			 * ######### ########## # ###### ####### - ## ######### # ########## ############# #
			 * ######## ####### ##-#########.
			 * @protected
			 */
			setEntityInfo: function() {
				var entityInfo = this.sandbox.publish("GetEntityInfo", null, [this.sandbox.id]);
				this.set("Operation", entityInfo.Operation);
				this.set("PrimaryColumnValue", entityInfo.PrimaryColumnValue);
				this.set("DefaultValues", entityInfo.DefaultValues);
			},

			/**
			 * ############# ######## ########### ########.
			 * @private
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ####### ######### ######.
			 */
			initEntity: function(callback, scope) {
				var operation = this.get("Operation");
				var primaryColumnValue = this.get("PrimaryColumnValue");
				if (operation === Enums.CardStateV2.ADD) {
					this.setDefaultValues(function() {
						this.setEntityDefaultValues(callback, scope || this);
					}, this);
					return;
				}
				this.loadEntity(primaryColumnValue, function() {
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this);
					}
				}, this);
			},

			/**
			 * ############# ######## ## #########.
			 * @protected
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ####### ######### ######.
			 */
			setEntityDefaultValues: function(callback, scope) {
				var defaultValues = this.get("DefaultValues");
				this.Terrasoft.each(defaultValues, function(defaultValue) {
					var name = defaultValue.name;
					var value = defaultValue.value;
					this.set(name, value);
				}, this);
				if (this.Ext.isFunction(callback)) {
					callback.call(scope || this);
				}
			},

			/**
			 * ############ ####### ###### #######.
			 * @protected
			 */
			onCloseButtonClick: function() {
				ModalBox.close();
			},

			/**
			 * ############ ####### ###### #########.
			 * @protected
			 */
			onSaveButtonClick: function() {
				if (this.validate()) {
					this.saveEntity(this.onEntitySaved, this);
				}
			},

			/**
			 * ########## ######### # ############ ########## ######.
			 * @protected
			 * @param {Object} response ##### #######.
			 */
			onEntitySaved: function(response) {
				this.sandbox.publish("SaveEntity", response, [this.sandbox.id]);
				ModalBox.close();
			}
		}
	};
});
