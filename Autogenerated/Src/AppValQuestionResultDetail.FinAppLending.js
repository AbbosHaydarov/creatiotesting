define("AppValQuestionResultDetail", ["ConfigurationGrid", "ConfigurationGridGenerator",
	"ConfigurationGridUtilities"], function() {
	return {
		entitySchemaName: "AppValQuestionResult",
		attributes: {},
		mixins: {
			ConfigurationGridUtilites: "Terrasoft.ConfigurationGridUtilities"
		},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
			 * @overridden
			 */
			getDeleteRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @overridden
			 */
			getCopyRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @overridden
			 */
			getEditRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
			 * @overridden
			 */
			getSwitchGridModeMenuItem: this.Terrasoft.emptyFn
		},
		diff:/**SCHEMA_DIFF*/[] /**SCHEMA_DIFF*/
	};
});
