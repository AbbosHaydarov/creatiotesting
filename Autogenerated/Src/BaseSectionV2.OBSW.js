define("BaseSectionV2", ["OBSWMixin"],
	function() {
		return {
			mixins: {
				OBSWMixin: "Terrasoft.OBSWMixin"
			},
			attributes: {
				/**
				 * Sign of the filter on the consultation contact.
				 */
				"UseConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				},
				/**
				 * Contact filter.
				 */
				"ConsultationContactFilter": {
					"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT
				}
			},
			methods: {

				// region Methods: Private

				/**
				 * Returns consultation section filter key.
				 * @return {String}
				 */
				_getConsultationSectionFilterKey: function() {
					var filterColumnName = this.getConsultationContactFilterColumnName();
					return this.Ext.String.format("customFilter{0}_{1}", filterColumnName, this.entitySchemaName);
				},

				// endregion

				// region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#initData
				 * @overridden
				 */
				initData: function(callback, scope) {
					this.callParent([function() {
						this.initConsultationContactFilter(function() {
							callback.call(scope || this);
						}, this);
					}, this]);
				},

				/**
				 * Initializes the filter contact consultation.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Context of callback functions.
				 */
				initConsultationContactFilter: function(callback, scope) {
					if (this.get("UseConsultationContactFilter")) {
						this.getActiveConsultationData(function(result) {
							var contact;
							if (result && result.success) {
								var activeContact = result.activeContact;
								if (activeContact && this.Ext.isObject(activeContact) &&
									!this.Ext.isEmpty(activeContact.value) &&
									activeContact.value !== this.Terrasoft.GUID_EMPTY) {
									contact = activeContact;
								}
							}
							this.set("ConsultationContactFilter", contact);
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this);
							}
						}, this);
					} else {
						if (this.Ext.isFunction(callback)) {
							callback.call(scope || this);
						}
					}
				},

				/**
				 * Returns column name for filter.
				 * @protected
				 * @return {String} Column name for filter.
				 */
				getConsultationContactFilterColumnName: function() {
					return "Contact";
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#initFilterAttributes
				 * @overridden
				 */
				initFilterAttributes: function() {
					var filterKey = "CustomFilters";
					var sectionFilters = this.get("SectionFilters");
					var filterGroup;
					if (this.get("UseConsultationContactFilter")) {
						var consultationContactFilter = this.get("ConsultationContactFilter");
						var filterColumnName = this.getConsultationContactFilterColumnName();
						var sessionFilters = this.getSessionFilters();
						var storageCustomFilters = sessionFilters[filterKey] = sessionFilters[filterKey] || {};
						if (this.Ext.isObject(consultationContactFilter)) {
							storageCustomFilters[filterColumnName] = {
								displayValue: consultationContactFilter.displayValue,
								primaryDisplayColumnName: "Name",
								value: consultationContactFilter.displayValue
							};
							filterGroup = this.Ext.create("Terrasoft.FilterGroup");
							filterGroup.add(this._getConsultationSectionFilterKey(),
								this.createConsultationFilter(filterColumnName, consultationContactFilter.value));
						} else {
							delete storageCustomFilters[filterColumnName];
						}
					}
					this.callParent(arguments);
					if (filterGroup) {
						var customSectionFilters = sectionFilters.find(filterKey);
						if (customSectionFilters) {
							var valueKey = this._getConsultationSectionFilterKey();
							customSectionFilters.removeByKey(valueKey);
							customSectionFilters.add(valueKey, filterGroup);
						} else {
							sectionFilters.add(filterKey, filterGroup);
						}
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#saveFilter
				 * @overridden
				 */
				saveFilter: function(filterKey, filterValue) {
					var customFilterKey = "CustomFilters";
					if (this.get("UseConsultationContactFilter") && filterKey === customFilterKey && filterValue) {
						delete filterValue[this.getConsultationContactFilterColumnName()];
					}
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#setFilter
				 * @overridden
				 */
				setFilter: function(key, value) {
					var customFiltersKey = "CustomFilters";
					var filterColumnName = this.getConsultationContactFilterColumnName();
					var valueKey = this._getConsultationSectionFilterKey();
					if (value && value.find(valueKey) && key === customFiltersKey &&
						this.get("UseConsultationContactFilter")) {
						var consultationContactFilter = this.get("ConsultationContactFilter");
						if (this.Ext.isObject(consultationContactFilter)) {
							value.removeByKey(valueKey);
							value.add(valueKey,
								this.createConsultationFilter(filterColumnName, consultationContactFilter.value));
						}
					}
					this.callParent(arguments);
				},

				/**
				 * Create consultation filter.
				 * @protected
				 * @param {String} columnPath Column path.
				 * @param {Guid} value Value.
				 * @return {Terrasoft.CompareFilter} Filter.
				 */
				createConsultationFilter: function(columnPath, value) {
					return this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						columnPath,
						value);
				}

				// endregion

			},
			diff: []
		};
	});
