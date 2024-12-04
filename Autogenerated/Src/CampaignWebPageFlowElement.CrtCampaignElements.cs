namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.DB;

	#region Class: CampaignWebPageFlowElement

	/// <summary>
	/// Executable web page element that filters audience due to the source web page conditions.
	/// </summary>
	public class CampaignWebPageFlowElement : CampaignFlowElement
	{

		#region Properties: Public

		/// <summary>
		/// The unique identifier of a current target entity for web page.
		/// </summary>
		public Guid WebPageTargetEntityId { get; set; }

		/// <summary>
		/// Column name of target entity for current web page URL.
		/// </summary>
		public string WebPageUrlColumn { get; set; }

		/// <summary>
		/// URL of the current web page.
		/// </summary>
		public string WebPageUrl { get; set; }

		/// <summary>
		/// Provides query model for the specified web page URL.
		/// </summary>
		private WebPageContactQueryProvider _queryProvider;
		public WebPageContactQueryProvider QueryProvider {
			get => _queryProvider ?? (_queryProvider = new WebPageContactQueryProvider(UserConnection) {
				PageUrlColumnName = WebPageUrlColumn,
				PageUrlColumnValue = WebPageUrl
			});
			set => _queryProvider = value;
		}

		#endregion

		#region Methods: Protecteds

		/// <summary>
		/// Contains custom logic for <see cref="AudieceQuery"/> initialization.
		/// </summary>
		/// <returns>Initialized <see cref="Query"/> to use as campaign audience.</returns>
		protected override Query GetAudienceQuery() {
			var selectModel = QueryProvider.GetSelectModel(WebPageTargetEntityId);
			var contactSelect = selectModel.ContactSelect;
			var contactIdColumn = contactSelect.Columns.FindByAlias(selectModel.ContactIdColumnName);
			if (contactSelect.HasCondition) {
				contactSelect.And(contactIdColumn).IsEqual(CampaignParticipantTable, "ContactId");
			} else {
				contactSelect.Where(contactIdColumn).IsEqual(CampaignParticipantTable, "ContactId");
			}
			var participantsSelect = base.GetAudienceQuery();
			participantsSelect.And().Exists(contactSelect);
			return participantsSelect;
		}

		#endregion

	}

	#endregion

}

