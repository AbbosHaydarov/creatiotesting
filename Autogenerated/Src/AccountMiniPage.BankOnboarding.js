define("AccountMiniPage", ["css!AccountMiniPageCSS"],
	function() {
		return {
			entitySchemaName: "Account",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			methods: {
				/**
				 * Sets FullAddress.
				 * @protected
				 * @overridden
				 */
				initFullAddress: function() {
					this.set("FullAddress", this.get("Address"));
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});
