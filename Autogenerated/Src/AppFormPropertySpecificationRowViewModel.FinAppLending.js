define("AppFormPropertySpecificationRowViewModel", ["SpecificationBankConstants", "BaseFieldRowViewModel"],
	function(SpecificationBankConstants) {
		Ext.define("Terrasoft.configuration.AppFormPropertySpecificationRowViewModel", {
			extend: "Terrasoft.BaseFieldRowViewModel",
			alternateClassName: "Terrasoft.AppFormPropertySpecificationRowViewModel",

			//region Methods: Protected

			/**
			 * Returns control visibility by parameter type.
			 * @param {String} tag Parameter type.
			 * @return {Boolean} Control visibility.
			 */
			getControlVisible: function(tag) {
				var dataType = this.get("SpecificationType");
				var type = SpecificationBankConstants.DataTypes[dataType.value].type;
				return tag === type;
			},

			/**
			 * Sets entity schema query filters for specification field.
			 * @protected
			 * @param {Terrasoft.FilterGroup} filters Collection of ESQ filters.
			 */
			setSpecificationESQFilters: function(filters) {
				var specification = this.get("Specification");
				specification = specification && specification.value;
				if (!this.Ext.isEmpty(specification)) {
					var specificationFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Specification", specification);
					filters.add("SpecificationFilter", specificationFilter);
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseViewModel#getLookupQuery
			 * @overridden
			 */
			getLookupQuery: function(filterValue, columnName) {
				var esq = this.callParent(arguments);
				if (columnName === "SpecificationListItem") {
					this.setSpecificationESQFilters(esq.filters);
				}
				return esq;
			},

			/**
			 * @inheritdoc Terrasoft.LookupQuickAddMixin#getLookupQueryFilters
			 * @overridden
			 */
			getLookupQueryFilters: function(columnName) {
				var filters = this.callParent(arguments);
				if (columnName === "SpecificationListItem") {
					this.setSpecificationESQFilters(filters);
				}
				return filters;
			},

			/**
			 * Returns marker value.
			 * @protected
			 * @param {String} tag Parameter type.
			 * @return {String} Marker value.
			 */
			getMarkerValue: function(tag) {
				var caption = this.get("Caption");
				return this.Ext.String.format("{0} {1}", caption, tag);
			}

			//endregion

		});

		return Terrasoft.AppFormPropertySpecificationRowViewModel;
	});
