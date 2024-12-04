define("OpportunityConditionParameterItemViewModel", ["OpportunityConditionParameterItemViewModelResources",
	"SpecificationBuilderConstants", "ProductConditionParameterItemViewModel"],
	function(resources, SpecificationBuilderConstants) {
		/**
		 * @class Terrasoft.OpportunityConditionParameterItemViewModel
		 */
		Ext.define("Terrasoft.configuration.OpportunityConditionParameterItemViewModel", {
			alternateClassName: "Terrasoft.OpportunityConditionParameterItemViewModel",
			extend: "Terrasoft.ProductConditionParameterItemViewModel",

			/**
			 * @inheritdoc Terrasoft.ProductConditionParameterItemViewModel#constructor
			 * @overridden
			*/
			constructor: function() {
				this.callParent(arguments);
				this.initResourcesValues(resources);
			},

			/**
			 * @inheritDoc Terrasoft.ProductConditionParameterItemViewModel#onValueChanged
			 * @overridden
			 */
			onValueChanged: function() {
				this.set("CurrentType", SpecificationBuilderConstants.ViewType.SingleValue);
				this.callParent(arguments);
			},

			/**
			 * @inheritDoc Terrasoft.ProductConditionParameterItemViewModel#prepareChangeTypeMenu
			 * @overridden
			 */
			prepareChangeTypeMenu: function() {
				this.callParent(arguments);
				var changeTypeMenuItems = this.get("ChangeTypeMenuItems");
				changeTypeMenuItems.add("tableValue", this.Ext.create("Terrasoft.BaseViewModel", {
					values: {
						"Caption": resources.localizableStrings.TableValueButtonCaption,
						"Click": {"bindTo": "onChangeTypeClick"},
						"MarkerValue": resources.localizableStrings.TableValueButtonCaption,
						"Tag": SpecificationBuilderConstants.ViewType.TableValue
					}
				}));
			},

			/**
			 * @inheritDoc Terrasoft.ProductConditionParameterItemViewModel#onChangeTypeClick
			 * @overridden
			 */
			onChangeTypeClick: function(tag) {
				if (this.get("CurrentType") === tag) {
					return;
				}
				if (tag === SpecificationBuilderConstants.ViewType.TableValue) {
					var parent = this.get("ParentItem");
					parent.setToolsVisible(false);
				}
				this.callParent(arguments);
			}

		});

		return Terrasoft.OpportunityConditionParameterItemViewModel;
	});
