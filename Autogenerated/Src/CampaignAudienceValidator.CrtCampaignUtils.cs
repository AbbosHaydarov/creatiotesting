namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Campaign.Interfaces;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;
	using CoreCampaignSchema = Core.Campaign.CampaignSchema;

	#region Class: CampaignAudienceValidator
	/// <summary>
	/// Represents class for campaign participants validation before campaign execution.
	/// Manages validation process for all elements in current campaign schema.
	/// </summary>
	public class CampaignAudienceValidator: ICampaignAudienceValidator
	{

		#region Constants: Private

		private const string ParticipantTableName = "CampaignParticipant";
		private const int ParticipantBatchSize = 460;

		#endregion

		#region Properties: Public

		/// <summary>
		/// User connection.
		/// </summary>
		public UserConnection UserConnection { get; set; }

		#endregion

		#region Methods: Private

		private int SetParticipantsStatus(IEnumerable<Guid> participantList, Guid statusId) {
			var update = new Update(UserConnection, ParticipantTableName)
				.Set("StatusId", Column.Parameter(statusId))
				.Set("StepModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Where("Id").In(Column.Parameters(participantList)) as Update;
			update.WithHints(new RowLockHint());
			return update.Execute();
		}

		private Select GetDuplicateParticipantsQuery(Guid campaignId) {
			var innerParticipantSelect = new Select(UserConnection)
				.Column("ContactId")
				.Column(Func.Max("CreatedOn")).As("max_date")
				.From(ParticipantTableName)
				.Where("CampaignId").IsEqual(Column.Parameter(campaignId))
				.And("StatusId").IsEqual(Column.Parameter(CampaignConstants.CampaignParticipantParticipatingStatusId))
				.GroupBy("ContactId") as Select;
			innerParticipantSelect.SpecifyNoLockHints();
			var campaignParticipantSelect = new Select(UserConnection)
				.Column(Func.Max("Id"))
				.From(ParticipantTableName).As("cp")
				.InnerJoin(innerParticipantSelect).As("icp")
					.On("cp", "ContactId").IsEqual("icp", "ContactId")
					.And("CreatedOn").IsEqual("icp", "max_date")
				.Where("CampaignId").IsEqual(Column.Parameter(campaignId))
				.And("StatusId").IsEqual(Column.Parameter(CampaignConstants.CampaignParticipantParticipatingStatusId))
				.GroupBy("cp", "ContactId") as Select;
			campaignParticipantSelect.SpecifyNoLockHints();
			var duplicateParticipantsSelect = new Select(UserConnection)
				.Column("Id")
				.From(ParticipantTableName)
				.Where("CampaignId").IsEqual(Column.Parameter(campaignId))
				.And("StatusId").IsEqual(Column.Parameter(CampaignConstants.CampaignParticipantParticipatingStatusId))
				.And("Id").Not().In(campaignParticipantSelect) as Select;
			duplicateParticipantsSelect.SpecifyNoLockHints();
			return duplicateParticipantsSelect;
		}

		private CampaignAudienceValidationInfo InternalValidate(Guid campaignId) {
			var validationInfo = new CampaignAudienceValidationInfo();
			var participantList = new List<Guid>();
			try {
				participantList = GetDuplicateParticipantsQuery(campaignId)
					.ExecuteEnumerable(r => r.GetColumnValue<Guid>("Id")).ToList();
			} catch (Exception ex) {
				validationInfo.Success = false;
				validationInfo.Errors.Add(ex);
			}
			var totalCount = participantList.Count();
			var count = 0;
			while (count < totalCount) {
				try {
					var batch = participantList.Skip(count).Take(ParticipantBatchSize);
					validationInfo.InvalidParticipantsCount += SetParticipantsStatus(batch,
						CampaignConstants.CampaignParticipantSuspendedStatusId);
				} catch (Exception ex) {
					validationInfo.Success = false;
					validationInfo.Errors.Add(ex);
				} finally {
					count += ParticipantBatchSize;
				}
			}
			return validationInfo;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validates campaign participants for campaign.
		/// </summary>
		/// <param name="userConnection">An instance of <see cref="UserConnection"/>.</param>
		/// <param name="campaignSchema">Current instance of <see cref="CoreCampaignSchema"/>.</param>
		/// <returns>Instance of <see cref="CampaignAudienceValidationInfo"/>.</returns>
		public CampaignAudienceValidationInfo Validate(UserConnection userConnection, CoreCampaignSchema campaignSchema) {
			userConnection.CheckArgumentNull("userConnection");
			campaignSchema.CheckArgumentNull("campaignSchema");
			UserConnection = userConnection;
			return InternalValidate(campaignSchema.EntityId);
		}

		#endregion

	}

	#endregion

}

