define("AccountRelationshipDetailV2", [], function() {

	return {
		entitySchemaName: "VwAccountRelationship",
		methods: {
			/**
			 * @inheritdoc Terrasoft.RelationshipDiagramViewModel#getRemoveRelationshipMessage
			 * @overridden
			 */
			getRemoveRelationshipMessage: function() {
				return this.get("Resources.Strings.RemoveRelationshipDialogMessage");
			},

			/**
			 * @inheritdoc Terrasoft.RelationshipDiagramViewModel#getGotoAccountMessage
			 * @overridden
			 */
			getGotoAccountMessage: function() {
				return this.get("Resources.Strings.GotoAccountDialogMessage");
			}
		},
		diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
	};
});
