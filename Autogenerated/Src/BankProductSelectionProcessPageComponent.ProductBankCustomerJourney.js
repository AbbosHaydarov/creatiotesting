define("BankProductSelectionProcessPageComponent", [
	"BankProductSelectionProcessPageComponentResources",
	...(Terrasoft.UseMfForAngularElements ? ["mf!NGBankProductSelection", "css-ltr!NGBankProductSelectionStyles"] : ["NGBankProductSelectionOld"])
], function(resources) {
	Ext.define("Terrasoft.BankProductSelectionProcessPageComponent", {
		extend: "Terrasoft.Component",

		/**
		 * @inheritdoc Terrasoft.controls.Container#tpl
		 */
		tpl: [
			"<div id=\"ts-bank-product-selection-process-page-{id}-wrap\" class=\"{wrapClassName}\">" +
			"<ts-bank-product-selection-process-page id=\"ts-bank-product-selection-process-page-{id}\" class=\"ts-bank-product-selection-process-page\"></ts-bank-product-selection-process-page>" + "</div>"
		],

		// region Methods: Protected

		getSelectors: function() {
			return {
				wrapEl: "#ts-bank-product-selection-process-page-" + this.id + "-wrap",
				designerEl: "#ts-bank-product-selection-process-page-" + this.id
			};
		},

		/**
		 * @inheritdoc Terrasoft.Component#getTplData
		 * @override
		 */
		getTplData: function() {
			const tplData = this.callParent(arguments);
			this.selectors = this.getSelectors();
			return tplData;
		},

		// endregion

	});
});
