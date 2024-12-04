define("OpportunityConditionSpecificationRowViewModel", ["OpportunityConditionSpecificationRowViewModelResources",
	"SpecificationBuilderConstants", "ProductConditionSpecificationRowViewModel",
	"OpportunityConditionParameterItemViewModel", "OpportunityConditionSpecificationMatrixBuilderViewModel"],
	function(resources, SpecificationBuilderConstants) {
	/**
	 * @class Terrasoft.OpportunityConditionSpecificationRowViewModel
	 */
	Ext.define("Terrasoft.configuration.OpportunityConditionSpecificationRowViewModel", {
		alternateClassName: "Terrasoft.OpportunityConditionSpecificationRowViewModel",
		extend: "Terrasoft.ProductConditionSpecificationRowViewModel",

		/**
		 * HTML ######## ### ######## ########## ######.
		 * @type {String}
		 */
		topContainerHTMLContent: "<div class='specification-row-top-container'><div class='specification-row-top-" +
			"hr'></div>{0}<div class='specification-row-top-hr'></div></div>",

		/**
		 * HTML ######## ### ####### ########## ######.
		 * @type {String}
		 */
		bottomContainerHTMLContent: "<div class='specification-row-bottom-container'><div class='specification-row-" +
			"top-hr'></div></div>",

		/**
		 * ### ###### ### ############ ######### ########.
		 * @type {String}
		 */
		matrixItemViewModelName: "Terrasoft.OpportunityConditionSpecificationMatrixBuilderViewModel",

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#parameterViewModelClassName
		 * @type {String}
		 */
		parameterViewModelClassName: "Terrasoft.OpportunityConditionParameterItemViewModel",

		/**
		 * ### #######, ############ ### ##### #### ########### ######## ######.
		 * @type {String}
		 */
		viewTypeChangedEventName: "onChangeViewType",

		/**
		 * @inheritdoc Terrasoft.ProductConditionSpecificationRowViewModel#constructor
		 * @overridden
		*/
		constructor: function() {
			this.callParent(arguments);
			this.initResourcesValues(resources);
		},

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#getRowItemViewModelNameByType
		 * @overridden
		 */
		getRowItemViewModelNameByType: function() {
			var itemViewModelName = this.callParent(arguments);
			var parameterViewModel = this.get("ParameterViewModel");
			if (parameterViewModel.get("CurrentType") === SpecificationBuilderConstants.ViewType.TableValue) {
				itemViewModelName = this.matrixItemViewModelName;
			}
			return itemViewModelName;
		},

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#onParameterChanged
		 * @overridden
		 */
		onParameterChanged: function() {
			this.setAdditionalMatrixStyles();
			this.callParent(arguments);
		},

		/**
		 * ############# ############## ##### ### ########## ########.
		 * @protected
		 */
		setAdditionalMatrixStyles: function() {
			var parameter = this.get("ParameterViewModel");
			var currentType = parameter.get("CurrentType");
			var isTableValue = currentType === SpecificationBuilderConstants.ViewType.TableValue;
			this.set("IsTableValue", isTableValue);
			parameter.set("IsTableValue", isTableValue);
			if (isTableValue) {
				var caption = this.get("Resources.Strings.TopCaption");
				var topHtmlContent = this.Ext.String.format(this.topContainerHTMLContent, caption);
				this.set("TopRowHtmlContent", topHtmlContent);
				this.set("BottomRowHtmlContent", this.bottomContainerHTMLContent);
			} else {
				this.set("TopRowHtmlContent", "");
				this.set("BottomRowHtmlContent", "");
			}
		},

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#getRowViewConfig
		 * @overridden
		 */
		getRowViewConfig: function() {
			var config = this.callParent(arguments);
			config.useAdditionalSpecificationClass = {bindTo: "IsTableValue"};
			config.topContainerConfig = {
				className: "Terrasoft.HtmlControl",
				htmlContent: {
					bindTo: "TopRowHtmlContent"
				}
			};
			config.bottomContainerConfig = {
				className: "Terrasoft.HtmlControl",
				htmlContent: {
					bindTo: "BottomRowHtmlContent"
				}
			};
			return config;
		},

		/**
		 * @inheritDoc Terrasoft.ProductConditionSpecificationRowViewModel#getSpecificationViewConfig
		 * @overridden
		 */
		getSpecificationViewConfig: function() {
			var config = this.callParent(arguments);
			config.useAdditionalWrapClass = {bindTo: "IsTableValue"};
			return config;
		},

		/**
		 * @inheritdoc Terrasoft.BaseSpecificationRowViewModel#loadEntity
		 * @overridden
		 */
		loadEntity: function(entity) {
			if (entity.get("XAxisEntity") && entity.get("YAxisEntity")) {
				this.set("RowItemViewModelName", this.matrixItemViewModelName);
				var parameterViewModel = this.get("ParameterViewModel");
				parameterViewModel.isNew = false;
				var propertyValueConfig = {
					silent: true,
					preventValidation: true
				};
				var value = entity.get("Value");
				parameterViewModel.set("Value", value, propertyValueConfig);
				parameterViewModel.set("IsReadMode", true, propertyValueConfig);
				parameterViewModel.set("CurrentType", SpecificationBuilderConstants.ViewType.TableValue,
					propertyValueConfig);
				var collection = this.getRowValuesCollection();
				var id = entity.get("Id");
				var matrixViewModel = this.getItemViewModel(id);
				matrixViewModel.loadEntity(entity);
				collection.add(id, matrixViewModel);
				this.setAdditionalMatrixStyles();
			} else {
				this.callParent(arguments);
			}
		}
	});
	return Terrasoft.OpportunityConditionSpecificationRowViewModel;
});
