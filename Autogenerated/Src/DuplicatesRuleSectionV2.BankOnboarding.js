define("DuplicatesRuleSectionV2", ["DuplicatesRuleSectionV2Resources"],
	function() {
		return {
			methods: {
				/**
				 * @inheritDoc Terrasoft.BaseSectionV2#getSectionActions
				 * @overriden
				 */
				getSectionActions: function() {
					var actionMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Caption": {"bindTo": "Resources.Strings.ContactsDuplicatesSearchCaption"},
						"Click": {"bindTo": "openContactDuplicatesModule"}
					}));
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Caption": {"bindTo": "Resources.Strings.AccountsDuplicatesSearchCaption"},
						"Click": {"bindTo": "openAccountDuplicatesModule"}
					}));
					actionMenuItems.addItem(this.getButtonMenuSeparator());
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Caption": {"bindTo": "Resources.Strings.ScheduleCaption"},
						"Click": {"bindTo": "openScheduleSettingPage"}
					}));
					return actionMenuItems;
				}
			}
		};
	}
);
