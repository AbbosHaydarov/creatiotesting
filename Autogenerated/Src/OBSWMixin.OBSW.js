define("OBSWMixin", [],
	function() {
		/**
		 * @class Terrasoft.configuration.mixins.OBSWMixin
		 * Mixin, implements to work with a single window banking operator.
		 */
		Ext.define("Terrasoft.configuration.mixins.OBSWMixin", {
			alternateClassName: "Terrasoft.OBSWMixin",

			//region Methods: Protected

			/**
			 * Requests data of the active case.
			 * @param {Function} callback Callback-function.
			 * @param {Object} scope Callback-function scope.
			 */
			getActiveCaseData: function(callback, scope) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "Case"
				});
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
				esq.addColumn("Contact");
				var filterGroup = this.Ext.create("Terrasoft.FilterGroup");
				filterGroup.add("activeFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"IsActive",
					true,
					this.Terrasoft.DataValueType.GUID));
				filterGroup.add("ownerFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"Owner",
					this.Terrasoft.SysValue.CURRENT_USER_CONTACT.value,
					this.Terrasoft.DataValueType.GUID));
				esq.filters.addItem(filterGroup);
				esq.getEntityCollection(function(response) {
					var result = {
						success: false
					};
					if (response && response.success) {
						var dataCollection = response.collection;
						if (dataCollection.getCount() === 1) {
							var entity = dataCollection.getByIndex(0);
							result.success = true;
							result.activeConsultationId = entity.get("Id");
							result.activeContact = entity.get("Contact");
						}
					}
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this, result);
					}
				}, this);
			},

			/**
			 * Saves the data of the active case.
			 * @param {Guid} caseId Case identifier.
			 * @param {Boolean} isActive Active state.
			 * @param {Function} callback Callback-function.
			 * @param {Object} scope Callback-function scope.
			 */
			updateActiveCaseData: function(caseId, isActive, callback, scope) {
				var updateQuery = Ext.create("Terrasoft.UpdateQuery", {
					rootSchemaName: "Case"
				});
				updateQuery.enablePrimaryColumnFilter(caseId);
				updateQuery.setParameterValue("IsActive", isActive, Terrasoft.DataValueType.BOOLEAN);
				updateQuery.execute(function() {
					if (this.Ext.isFunction(callback)) {
						callback.call(scope || this);
					}
				}, this);
			},

			/**
			 * Requests active consultation data.
			 * @param {Function} callback Callback-function.
			 * @param {Object} scope Callback-function scope.
			 */
			getActiveConsultationData: function(callback, scope) {
				this.getActiveCaseData(callback, scope);
			},

			/**
			 * Saves the consultation active data.
			 * @param {Guid} consultationId Consultation identifier.
			 * @param {Object} contact Consultation contact.
			 * @param {Function} callback Callback-function.
			 * @param {Object} scope Callback-function scope.
			 */
			saveActiveConsultationData: function(consultationId, contact, callback, scope) {
				this.updateActiveCaseData(consultationId, true, callback, scope);
			},

			/**
			 * Removes active consultation data.
			 * @param {Guid} consultationId Consultation identifier.
			 * @param {Function} callback Callback-function.
			 * @param {Object} scope Callback-function scope.
			 */
			removeActiveConsultationData: function(consultationId, callback, scope) {
				this.updateActiveCaseData(consultationId, false, callback, scope);
			}

			//endregion
		});
		return Terrasoft.OBSWMixin;
	});
