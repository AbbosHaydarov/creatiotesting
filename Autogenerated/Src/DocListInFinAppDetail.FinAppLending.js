define("DocListInFinAppDetail", [],
	function() {
		return {
			entitySchemaName: "DocListInFinApp",
			attributes: {},
			mixins: {},
			diff: /**SCHEMA_DIFF*/ [],
			/**SCHEMA_DIFF*/
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc DocListInFinAppDetail#getFillDetailServiceConfig
				 * @overridden
				 */
				getFillDetailServiceConfig: function() {
					var config = {};
					var data = null;
					var serviceName = null;
					var methodName = null;
					var masterRecordId = this.get("MasterRecordId");
					var detailColumnName = this.get("DetailColumnName");
					switch (detailColumnName) {
						case "FinApplication":
							return this.callParent(arguments);
						case "AppForm":
							serviceName = "DocListLendingHelperService";
							methodName = "FillDocListInFinApplicationForm";
							data = {
								appFormId: masterRecordId
							};
							break;
						default:
							break;
					}
					if (!this.Ext.isEmpty(serviceName) && !this.Ext.isEmpty(methodName)) {
						config = {
							serviceName: serviceName,
							methodName: methodName,
							data: data
						};
					}
					return config;
				}

				//endregion

			}
		};
	});
