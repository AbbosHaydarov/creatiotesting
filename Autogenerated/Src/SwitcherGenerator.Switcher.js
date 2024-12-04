define("SwitcherGenerator", ["ext-base", "terrasoft", "SwitcherGeneratorResources", "DesignViewGeneratorV2",
		"Switcher", "css!Switcher"],
	function(Ext) {
		var viewGenerator = Ext.define("Terrasoft.configuration.SwitcherGenerator", {
			extend: "Terrasoft.ViewGenerator",
			alternateClassName: "Terrasoft.SwitcherGenerator",

			/**
			 * ########## ############ ############# ### {Terrasoft.Switcher}.
			 * @protected
			 * @virtual
			 * @param {Object} config ######## ######## #############.
			 * @return {Object} ########## ############### ############# Switcher.
			 */
			generateSwitcher: function(config) {
				var switcher = {
					className: "Terrasoft.Switcher",
					id: config.name + "SwitcherEdit"
				};
				delete config.generator;
				switcher = Ext.apply(switcher, config);
				switcher = this.getConfigWithoutServiceProperties(switcher,
					["labelConfig", "labelWrapConfig", "caption", "textSize"]);
				return switcher;
			}
		});
		return Ext.create(viewGenerator);
	});
