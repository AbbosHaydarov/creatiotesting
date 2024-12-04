define("SystemDesigner", function() {
	return {
		attributes: {
			/**
			 * Detemines if Link DuplicatesSettingsSection is visible.
			 * @type {Boolean}
			 */
			"DuplicatesSettingsSectionVisible": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},
		diff: [
			{
				"operation": "merge",
				"propertyName": "items",
				"parentName": "SystemSettingsTile",
				"name": "DuplicatesSettingsSection",
				"index": 2,
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.DuplicatesSettingsLinkCaption"},
					"tag": "navigateToDuplicatesSettings",
					"click": {"bindTo": "invokeOperation"},
					"visible": {"bindTo": "DuplicatesSettingsSectionVisible"}
				}
			}
		],
		methods: {
			/**
			 * @inheritdoc Terrasoft.SystemDesigner#init
			 * @overridden
			 */
			init: function() {
				this.callParent(arguments);
				this.setDuplicatesSettingsSectionLinkVisible();
			},

			/**
			 * Sets visibility for link 'Setup duplicates rules'.
			 * @protected
			 */
			setDuplicatesSettingsSectionLinkVisible: function() {
				this.set("DuplicatesSettingsSectionVisible", this.getIsFeatureEnabled("Deduplication"));
			}
		}
	};
});
