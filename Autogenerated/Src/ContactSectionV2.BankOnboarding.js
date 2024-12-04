﻿define("ContactSectionV2", [],
	function() {
		return {
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			methods: {
				/**
				 * @inheritdoc Terrasoft.ContactSectionV2#checkCanSearchDuplicates
				 * @overridden
				 */
				checkCanSearchDuplicates: function() {
					if (this.getIsFeatureEnabled("Deduplication")) {
						this.callParent(arguments);
					} else {
						this.set("canSearchDuplicates", false);
					}
				}
			}
		};
	}
);
