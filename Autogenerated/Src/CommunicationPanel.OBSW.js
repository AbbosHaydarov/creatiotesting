define("CommunicationPanel", ["CommunicationPanelHelper", "OBSWModule", "OBSWSchema", "OBSWMixin", "css!OBSWMixin"],
	function() {
		return {
			attributes: {

				/**
				 * @type {String}
				 */
				"OBSWCounter": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": ""
				}
			},
			messages: {

				/**
				 * @message ConsultationDurationChanged
				 * Changes the line with consultation duration.
				 * @param {String} Consultation duration.
				 */
				"ConsultationDurationChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				OBSWMixin: "Terrasoft.OBSWMixin"
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.CommunicationPanel#initSelectedMenuItem
				 * @overridden
				 */
				initSelectedMenuItem: function(callback, scope) {
					this.sandbox.subscribe("ConsultationDurationChanged", this.onConsultationDurationChanged, this);
					this.callParent([function(selectedMenuItemTag) {
						this.getActiveConsultationData(function(result) {
							if (result && result.success) {
								var activeConsultationId = result.activeConsultationId;
								if (activeConsultationId && !this.Ext.isEmpty(activeConsultationId) &&
									activeConsultationId !== this.Terrasoft.GUID_EMPTY) {
									if (selectedMenuItemTag !== "OBSW") {
										selectedMenuItemTag = "OBSW";
										var itemConfig = this.getPanelItemConfig("OBSWModule");
										itemConfig.loadHidden = true;
										this.sandbox.publish("CommunicationPanelItemSelected", itemConfig);
									}
								}
							}
							if (this.Ext.isFunction(callback)) {
								callback.call(scope || this, selectedMenuItemTag);
							}
						}, this);
					}.bind(this)]);
				},

				/**
				 * Handles consultation duration change.
				 * @protected
				 * @param {String} consultationDuration Consultation duration in format mm:ss.
				 */
				onConsultationDurationChanged: function(consultationDuration) {
					this.set("ConsultationDuration", consultationDuration);
				},

				/**
				 * @inheritDoc Terrasoft.CommunicationPanel#getPanelItemConfig
				 * @overridden
				 */
				getPanelItemConfig: function(moduleName) {
					var config = this.callParent(arguments);
					if (moduleName !== "OBSWModule") {
						return config;
					}
					return Ext.apply(config, {
						keepAlive: true
					});
				},

				/**
				 * Returns OBSWPanel menu item style.
				 * @protected
				 * @param {String} itemTag Menu item identifier.
				 * @return {String} Menu item style.
				 */
				getOBSWPanelStyle: function(itemTag) {
					var isItemPressed = this.get("SelectedMenuItem") === itemTag;
					var consultationDuration = this.get("ConsultationDuration");
					var itemWithCallDuration = (!isItemPressed && !this.Ext.isEmpty(consultationDuration));
					return (itemWithCallDuration ? "with-call-duration" : "without-call-duration");
				},

				/**
				 * Returns the image configuration for OBSWPanel menu item.
				 * @protected
				 * @param {String} itemTag Menu item identifier.
				 * @return {Object} Menu item image configuration.
				 */
				getOBSWPanelImageConfig: function(itemTag) {
					var ext = this.Ext;
					var resourceName = "";
					if (!this.getIsFeatureEnabled("OldUI")) {
						resourceName = ext.String.format(this.get("MenuItemIconNameTemplate"), itemTag, "", "");
						return this.get("Resources.Images." + resourceName + "SVG");
					}
					var isItemPressed = this.get("SelectedMenuItem") === itemTag;
					var obswPanelCounter = this.get(itemTag + "Counter");
					var pressedSuffix = isItemPressed ? "Pressed" : ext.emptyString;
					var counterSuffix = !ext.isEmpty(obswPanelCounter) ? "Counter" : ext.emptyString;
					var consultationDuration = this.get("ConsultationDuration");
					if (!isItemPressed) {
						counterSuffix = !ext.isEmpty(consultationDuration) ? "ConsultationDuration" : counterSuffix;
					}
					resourceName = ext.String.format(this.get("MenuItemIconNameTemplate"),
						itemTag, pressedSuffix, counterSuffix);
					return this.get("Resources.Images." + resourceName);
				},

				/**
				 * Returns caption for OBSWPanel menu item.
				 * @protected
				 * @param {String} itemTag Menu item identifier.
				 * @return {String} Menu item caption.
				 */
				getOBSWPanelCaption: function(itemTag) {
					var isItemPressed = this.get("SelectedMenuItem") === itemTag;
					var obswPanelCounter = this.get(itemTag + "Counter");
					var consultationDuration = this.get("ConsultationDuration");
					if (!isItemPressed) {
						return (!this.Ext.isEmpty(consultationDuration) ? consultationDuration : obswPanelCounter);
					}
					return obswPanelCounter;
				}
			},
			diff: [{
				"operation": "insert",
				"parentName": "communicationPanelContent",
				"propertyName": "items",
				"name": "OBSW",
				"values": {
					"tag": "OBSW",
					"imageConfig": {
						"bindTo": "getOBSWPanelImageConfig"
					},
					"caption": {
						"bindTo": "getOBSWPanelCaption"
					},
					"style": {
						"bindTo": "getOBSWPanelStyle"
					},
					"generator": "CommunicationPanelHelper.generateMenuItem"
				},
				"index": 0
			}]
		};
	});
