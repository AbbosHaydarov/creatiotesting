define("ServiceLevelSectionGridRowViewModel", ["ext-base", "BaseSectionGridRowViewModel"],
	function(Ext) {

	/**
	 * @class Terrasoft.configuration.ServiceLevelSectionGridRowViewModel
	 */
	Ext.define("Terrasoft.configuration.ServiceLevelSectionGridRowViewModel", {
		extend: "Terrasoft.BaseSectionGridRowViewModel",
		alternateClassName: "Terrasoft.ServiceLevelSectionGridRowViewModel",

		/**
		 * @inheritDoc Terrasoft.BaseViewModel#getLookupImageUrl
		 * @overridden
		 */
		getLookupImageUrl: function(lookupColumnName) {
			var lookupColumn = this.findEntityColumn(lookupColumnName) || this.getColumnByName(lookupColumnName);
			if (!lookupColumn || !lookupColumn.isLookup) {
				throw new Terrasoft.UnsupportedTypeException();
			}
			var lookupColumnValue = this.get(lookupColumnName);
			var value = lookupColumnValue.value;
			if (!value) {
				return null;
			}
			var imageConfig = {
				source: Terrasoft.ImageSources.SYS_IMAGE,
				params: {
					primaryColumnValue: value
				}
			};
			return Terrasoft.ImageUrlBuilder.getUrl(imageConfig);
		}
	});

	return Terrasoft.ServiceLevelSectionGridRowViewModel;
});
