define("BankProductSelectionPageComponent", [
	"BankProductSelectionPageComponentResources",
	...(Terrasoft.UseMfForAngularElements ? ["mf!NGBankProductSelection", "css-ltr!NGBankProductSelectionStyles"] : ["NGBankProductSelectionOld"])
], function(resources) {
	Ext.define("Terrasoft.BankProductSelectionPageComponent", {
		extend: "Terrasoft.Component",

		/**
		 * @inheritdoc Terrasoft.controls.Container#tpl
		 */
		tpl: [
			"<div id=\"bank-product-selection-page-{id}-wrap\" class=\"{wrapClassName}\">" +
				"<ts-bank-product-selection-page id=\"bank-product-selection-page-{id}\" class=\"bank-product-selection-page\"></ts-bank-product-selection-page>" +
			"</div>"
		],

		// region Methods: Protected

		getSelectors: function() {
			return {
				wrapEl: "#bank-product-selection-page-" + this.id + "-wrap",
				pageEl: "#bank-product-selection-page-" + this.id
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
		}

		// endregion

	});
});
