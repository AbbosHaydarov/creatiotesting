define("CurrencyViewGenerator", ["ext-base", "terrasoft", "ViewGeneratorV2Resources", "CurrencyButton"],
	function() {
		function generateCurrencyMenuControl(controlConfig) {
			return {
				id: controlConfig.name + "CurrencyControl",
				className: "Terrasoft.CurrencyButton",
				markerValue: controlConfig.markerValue,
				classes: {
					wrapperClass: ["custom-currency-btn"],
					textClass: ["currency-btn-inner-user-class"]
				},
				style: controlConfig.style,
				click: controlConfig.click,
				menu: {
					items: []
				},
				caption: controlConfig.caption
			};
		}

		return {
			generateCurrencyMenuControl: generateCurrencyMenuControl
		};
	});
