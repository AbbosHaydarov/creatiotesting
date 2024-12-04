define("AppValidationUtilities", ["ProcessModuleUtilities"],
	function(ProcessModuleUtilities) {
		Ext.define("Terrasoft.configuration.mixins.AppValidationUtilities", {

			alternateClassName: "Terrasoft.AppValidationUtilities",

			//region Properties: Protected

			/**
			 * Allowed result attribute name.
			 * @protected
			 * @type {String}
			 */
			allowedResultAttributeName: "AllowedResult",

			/**
			 * Entity process element idd attribute name.
			 * @protected
			 * @type {String}
			 */
			entityProcessElementIdAttributeName: "EntityProcessElementId",

			//endregion

			//region Methods: Private

			initEntityProcessElementId: function(callback, scope) {
				var primaryColumnValue = this.get(this.primaryColumnName);
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchema: this.entitySchema
				});
				esq.addColumn("[SysEntityCommonPrcEl:RecordId:Id].ProcessElement.Id", this.entityProcessElementIdAttributeName);
				esq.getEntity(primaryColumnValue, function(result) {
					var elementId;
					var entity = result.entity;
					if (entity) {
						elementId = entity.get(this.entityProcessElementIdAttributeName);
					}
					this.set(this.entityProcessElementIdAttributeName, elementId);
					this.Ext.callback(callback, scope, [elementId]);
				}, this);
			},

			/**
			 * Initialize "ExecutionData" of the process element.
			 * @private
			 * @param {Function} [callback] Callback function.
			 * @param {Object} [scope] Execution context.
			 */
			initExecutionData: function(callback, scope) {
				var elementId = this.get(this.entityProcessElementIdAttributeName);
				var recordId = this.get(this.primaryColumnName);
				if (this.Ext.isEmpty(elementId) || this.Ext.isEmpty(recordId)) {
					this.Ext.callback(callback, scope);
					return;
				}
				ProcessModuleUtilities.getExecutionData(elementId, recordId, function(request, success, response) {
					this.onGetExecutionData(request, success, response);
					this.Ext.callback(callback, scope);
				}, this);
			},

			/**
			 * Callback function of request to the method "GetExecutionData" of "ProcessEngineService".
			 * @private
			 * @param {Object} request Instance of the request.
			 * @param {Boolean} success Service call executed successfully.
			 * @param {Object} response Server response.
			 */
			onGetExecutionData: function(request, success, response) {
				if (!success) {
					return;
				}
				var executionData = this.Ext.decode(this.Ext.decode(response.responseText));
				var statusCode = executionData.status;
				executionData = statusCode ? null : executionData;
				this.initExecutionDataAllowedResult(executionData);
				this.set("ExecutionData", executionData);
			},

			initExecutionDataAllowedResult: function(executionData) {
				var allowedResult;
				executionData = executionData || {};
				var allowedValues = executionData.allowedValues || "[]";
				allowedResult = this.Ext.decode(allowedValues);
				this.set(this.allowedResultAttributeName, allowedResult);
			},

			//endregion

			//region Methods: Protected

			initAllowedResult: function(callback, scope) {
				this.Terrasoft.chain(
					this.initEntityProcessElementId,
					this.initExecutionData,
					function() {
						this.Ext.callback(callback, scope);
					},
					this
				);
			}

			//endregion

		});
	});
