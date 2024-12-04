namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

    #region Class: Unsubscribe

    public class Unsubscribe : BaseWebHook
	{

		#region Properties: Public

		public string EmailAddress { get; set; }

		/// <summary>
		/// Represents the identifier of the recipient in a concrete email.
		/// </summary>
		public Guid RecipientUid { get; set; }

		#endregion

		#region Methods: Private

		private void UpdateEmailAddress(UserConnection userConnection) {
			if (!string.IsNullOrEmpty(EmailAddress) || RecipientUid == Guid.Empty) {
				return;
			}
			var bet = new BulkEmailTarget(userConnection);
			bool isFetchSuccess = bet.FetchFromDB("MandrillId", RecipientUid, new[] { "EmailAddress" });
			if (isFetchSuccess) {
				EmailAddress = bet.EmailAddress;
			}
		}

		#endregion

		#region Methods: Public

		public override string GetGroupKey() {
			return base.GetGroupKey() + EmailAddress + RecipientUid;
		}

		public override void HandleWebHook(UserConnection userConnection) {
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "Contact");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddAllSchemaColumns();
			IEntitySchemaQueryFilterItem communicationTypeFilter =
				esq.CreateFilterWithParameters(FilterComparisonType.Equal,
					"[ContactCommunication:Contact:Id].CommunicationType", Guid.Parse(CommunicationTypeConsts.EmailId));
			EntitySchemaQueryFilter numberFilter =
				WebHookUtilities.CreateUpperFunctionFilter(esq, "[ContactCommunication:Contact:Id].Number",
					EmailAddress);
			var subFilterGroupAnd = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.And);
			subFilterGroupAnd.Add(communicationTypeFilter);
			subFilterGroupAnd.Add(numberFilter);
			EntitySchemaQueryFilter emailContactFilter =
				WebHookUtilities.CreateUpperFunctionFilter(esq, "Email", EmailAddress);
			var filterGroupOr = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			filterGroupOr.Add(subFilterGroupAnd);
			filterGroupOr.Add(emailContactFilter);
			esq.Filters.Add(filterGroupOr);
			EntityCollection contactEntities = esq.GetEntityCollection(userConnection);
			foreach (Entity contactEntity in contactEntities) {
				contactEntity.SetColumnValue("DoNotUseEmail", true);
				contactEntity.Save();
			}
		}

		#endregion

	}

	#endregion

}

