namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Common;
	using Terrasoft.Core.Entities;

    #region Class: RecipientStatistics

    public class RecipientStatistics : BaseWebHook
	{

		#region Fields: Private

		private int _responseCode;

		#endregion

		#region Properties: Private

		private UserConnection UserConnection { get; set; }

		#endregion

		#region Properties: Public

		public Guid RecipientUId { get; set; }

		public Guid EmailId { get; set; }

		public string ResponseCode {
			get => _responseCode.ToString();
			set => _responseCode = Convert.ToInt32(value);
		}

		public string ResponseReason { get; set; }

		public string ResponseDetails { get; set; }

		public int Opens { get; set; }

		public int Clicks { get; set; }

		public string ProviderName { get; set; }

		#endregion

		#region Methods: Private

		private Update GetBETUpdateQuery(int opensCount) {
			Guid responseId = BulkEmailResponseMapping.GetResponseIdByCode(UserConnection, _responseCode);
			return new Update(UserConnection, "BulkEmailTarget").Set("ProviderName", Column.Parameter(ProviderName))
				.Set("Opens", Column.Parameter(opensCount)).Set("Clicks", Column.Parameter(Clicks))
				.Set("ModifiedOn", Column.Parameter(EventDate)).Set("BulkEmailResponseId", Column.Parameter(responseId))
				.Where("MandrillId").IsEqual(Column.Parameter(RecipientUId)).And("ModifiedOn")
				.IsLess(Column.Parameter(EventDate)) as Update;
		}

		private Select GetContactsWithActualCommunicationExistsSelect(string recipientEmail) {
			string upperEmail = recipientEmail.ToUpper();
			var communicationExistsSelect = new Select(UserConnection).Column(Column.Parameter(1))
				.From("ContactCommunication").As("cmn").Where(Func.Upper("cmn", "Number"))
				.IsNotEqual(Column.Parameter(upperEmail)).And("cmn", "CommunicationTypeId")
				.IsEqual(Column.Parameter(Guid.Parse(CommunicationTypeConsts.EmailId))).And("cmn", "NonActual")
				.IsEqual(Column.Parameter(false)).And("cmn", "ContactId").IsEqual("c", "Id").And("c", "Email")
				.IsEqual(Column.Parameter(recipientEmail)) as Select;
			communicationExistsSelect.SpecifyNoLockHints();
			var hardBouncedContacts = new Select(UserConnection).Column("Id").As("HardBouncedContactId").From("Contact")
				.As("c").Where().Exists(communicationExistsSelect) as Select;
			hardBouncedContacts.SpecifyNoLockHints();
			return hardBouncedContacts;
		}

		private BulkEmailResponseDetails GetCurrentResponseDetailsFromDB() {
			var bet = new BulkEmailTarget(UserConnection);
			var responseDetails = new BulkEmailResponseDetails(UserConnection);
			bool responseExists = bet.FetchFromDB("MandrillId", RecipientUId);
			if (responseExists) {
				var detailsId = bet.GetTypedColumnValue<Guid>("ResponseDetailsId");
				responseDetails.FetchFromDB(detailsId);
			}
			return responseDetails;
		}

		private bool GetIsLeaveOldDetails(BulkEmailResponseDetails responseDetails) {
			if (responseDetails.LoadState != EntityLoadState.NotLoaded) {
				var reasonId = responseDetails.GetTypedColumnValue<Guid>("ReasonId");
				var reason = new BulkEmailResponseReason(UserConnection);
				reason.FetchFromDB(reasonId);
				var reasonName = reason.GetTypedColumnValue<string>("Name");
				return string.Equals(reasonName, ResponseReason, StringComparison.InvariantCultureIgnoreCase) &&
					string.IsNullOrEmpty(ResponseDetails);
			}
			return false;
		}

		private IEnumerable<Guid> GetLastReasons(int reasonsCount) {
			string emailAddress = GetRecipientEmailAddress().ToUpper();
			var select = new Select(UserConnection).Top(reasonsCount).Column("details", "ReasonId").As("ReasonId")
				.From("BulkEmailTarget", "bet").LeftOuterJoin("BulkEmailResponseDetails").As("details")
				.On("details", "Id").IsEqual("bet", "ResponseDetailsId").LeftOuterJoin("BulkEmailResponseReason")
				.As("reason").On("details", "ReasonId").IsEqual("reason", "Id").Where(Func.Upper("bet", "EmailAddress"))
				.IsEqual(Column.Parameter(emailAddress)).OrderByDesc("bet", "ModifiedOn") as Select;
			select.SpecifyNoLockHints();
			return select.ExecuteEnumerable(r => r.GetColumnValue<Guid>("ReasonId"));
		}

		private int GetOpensCount() {
			return Opens == 0 && Clicks > 0 ? 1 : Opens;
		}

		private string GetRecipientEmailAddress() {
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "BulkEmailTarget");
			string emailColumnName = entitySchemaQuery.AddColumn("EmailAddress").Name;
			entitySchemaQuery.Filters.Add(
				entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "MandrillId", RecipientUId));
			Entity entity = entitySchemaQuery.GetEntityCollection(UserConnection).FirstOrDefault();
			return entity != null ? entity.GetTypedColumnValue<string>(emailColumnName) : string.Empty;
		}

		private BulkEmailResponseReason GetResponseReasonByName(string reasonName) {
			reasonName = reasonName ?? ResponseReason;
			string upperReasonName = reasonName.ToUpper();
			var query = new Select(UserConnection).Column("Id").From("BulkEmailResponseReason")
				.Where(Func.Upper("Name")).IsEqual(Column.Parameter(upperReasonName)) as Select;
			var responseReasonId = query.ExecuteScalar<Guid>();
			if (responseReasonId == default) {
				ResponseDetails = string.IsNullOrEmpty(ResponseDetails) ? "Non known reason provided: " + reasonName
					: $"Reason: {reasonName}. Details: {ResponseDetails}";
				responseReasonId = MailingConsts.OtherResponseReason;
			}
			var reason = new BulkEmailResponseReason(UserConnection);
			reason.FetchFromDB(responseReasonId);
			return reason;
		}

		private void HandleHardBounceResponse() {
			if (string.IsNullOrEmpty(ResponseReason)) {
				return;
			}
			BulkEmailResponseReason reason = GetResponseReasonByName(ResponseReason);
			if (reason.CountToSetIsNonActualEmail == -1) {
				return;
			}
			int reasonThreshold = reason.CountToSetIsNonActualEmail;
			IEnumerable<Guid> lastResponses = GetLastReasons(reasonThreshold);
			if (lastResponses.IsNotEmpty() && lastResponses.Count() == reasonThreshold &&
				lastResponses.All(x => x == reason.Id)) {
				HandleNonActualEmailState(MailingConsts.HardBounceNonActualReasonId);
			}
		}

		private void HandleInvalidEmailResponse() {
			HandleNonActualEmailState(MailingConsts.InvalidEmailNonActualReasonId);
		}

		private void HandleNonActualEmailState(Guid nonActualReasonId) {
			string recipientEmail = GetRecipientEmailAddress();
			UpdateNonActualContactCommunication(nonActualReasonId, recipientEmail);
			SetActualEmailToContact(recipientEmail);
			UpdateNonActualContactEmail(recipientEmail);
		}

		private void HandlePersonalResponse() {
			int opensCount = GetOpensCount();
			Update update = GetBETUpdateQuery(opensCount);
			HandleResponseReason(update);
			update.WithHints(new RowLockHint());
			update.Execute();
		}

		private void HandleResponseReason(Update update) {
			Guid? responseDetailsIdToSave = null;
			if (!string.IsNullOrEmpty(ResponseReason)) {
				BulkEmailResponseDetails currentResponseDetails = GetCurrentResponseDetailsFromDB();
				if (GetIsLeaveOldDetails(currentResponseDetails)) {
					return;
				}
				responseDetailsIdToSave = SaveOrUpdateResponseDetails(currentResponseDetails);
			}
			if (responseDetailsIdToSave.HasValue) {
				update.Set("ResponseDetailsId", Column.Parameter(responseDetailsIdToSave));
			} else {
				QueryColumnExpression nullParameter = Column.Parameter(DBNull.Value,
					new GuidDataValueType(UserConnection.DataValueTypeManager));
				update.Set("ResponseDetailsId", nullParameter);
			}
		}

		private void HandleSpamResponse() {
			string recipientEmail = GetRecipientEmailAddress();
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddAllSchemaColumns();
			IEntitySchemaQueryFilterItem communicationTypeFilter =
				esq.CreateFilterWithParameters(FilterComparisonType.Equal,
					"[ContactCommunication:Contact:Id].CommunicationType", Guid.Parse(CommunicationTypeConsts.EmailId));
			EntitySchemaQueryFilter numberFilter =
				WebHookUtilities.CreateUpperFunctionFilter(esq, "[ContactCommunication:Contact:Id].Number",
					recipientEmail);
			esq.Filters.Add(communicationTypeFilter);
			esq.Filters.Add(numberFilter);
			EntityCollection contactEntities = esq.GetEntityCollection(UserConnection);
			foreach (Entity contactEntity in contactEntities) {
				contactEntity.SetColumnValue("DoNotUseEmail", true);
				contactEntity.Save();
			}
		}

		private Guid SaveOrUpdateResponseDetails(BulkEmailResponseDetails currentDetails) {
			Guid detailsId;
			BulkEmailResponseReason reason = GetResponseReasonByName(ResponseReason);
			string responseDetails =
				ResponseDetails?.Substring(0, Math.Min(ResponseDetails.Length, 500)) ?? string.Empty;
			if (currentDetails.LoadState == EntityLoadState.NotLoaded) {
				detailsId = Guid.NewGuid();
				new Insert(UserConnection).Into("BulkEmailResponseDetails").Set("Id", Column.Parameter(detailsId))
					.Set("Details", Column.Parameter(responseDetails)).Set("ReasonId", Column.Parameter(reason.Id))
					.Set("ModifiedOn", Column.Parameter(EventDate)).Execute();
			} else {
				detailsId = currentDetails.Id;
				new Update(UserConnection, "BulkEmailResponseDetails").Set("Details", Column.Parameter(responseDetails))
					.Set("ReasonId", Column.Parameter(reason.Id)).Set("ModifiedOn", Column.Parameter(EventDate))
					.Where("Id").IsEqual(Column.Parameter(detailsId)).Execute();
			}
			return detailsId;
		}

		private void SetActualEmailToContact(string recipientEmail) {
			Select possibleActualContactsSelect = GetContactsWithActualCommunicationExistsSelect(recipientEmail);
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = possibleActualContactsSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						var contactId = reader.GetColumnValue<Guid>("HardBouncedContactId");
						SetActualEmailToContactById(contactId, recipientEmail);
					}
				}
			}
		}

		private void SetActualEmailToContactById(Guid contactId, string recipientEmail) {
			var contactCommunicationEsq =
				new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ContactCommunication");
			EntitySchemaQueryColumn modifiedOnColumn = contactCommunicationEsq.AddColumn("ModifiedOn").OrderByDesc();
			string numberColumnName = contactCommunicationEsq.AddColumn("Number").Name;
			contactCommunicationEsq.Filters.Add(contactCommunicationEsq.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Contact", contactId));
			contactCommunicationEsq.Filters.Add(WebHookUtilities.CreateUpperFunctionFilter(contactCommunicationEsq,
				"Number", recipientEmail, FilterComparisonType.NotEqual));
			contactCommunicationEsq.Filters.Add(
				contactCommunicationEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "NonActual", false));
			contactCommunicationEsq.Filters.Add(contactCommunicationEsq.CreateFilterWithParameters(
				FilterComparisonType.Equal, "CommunicationType", Guid.Parse(CommunicationTypeConsts.EmailId)));
			Entity contactCommunicationEntity =
				contactCommunicationEsq.GetEntityCollection(UserConnection).FirstOrDefault();
			if (contactCommunicationEntity is null) {
				return;
			}
			var firstActualEmail = contactCommunicationEntity.GetColumnValue(numberColumnName).ToString();
			EntitySchema contactSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");
			Entity contactEntity = contactSchema.CreateEntity(UserConnection);
			if (contactEntity.FetchFromDB(contactId)) {
				var currentContactEmail = contactEntity.GetColumnValue("Email").ToString();
				if (string.Equals(currentContactEmail, firstActualEmail, StringComparison.InvariantCultureIgnoreCase)) {
					return;
				}
				contactEntity.SetColumnValue("Email", firstActualEmail);
				contactEntity.Save();
			}
		}

		private void UpdateNonActualContactCommunication(Guid nonActualReasonId, string recipientEmail) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ContactCommunication");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddAllSchemaColumns();
			esq.Filters.Add(WebHookUtilities.CreateUpperFunctionFilter(esq, "Number", recipientEmail));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "CommunicationType",
				Guid.Parse(CommunicationTypeConsts.EmailId)));
			EntityCollection entities = esq.GetEntityCollection(UserConnection);
			foreach (Entity entity in entities) {
				entity.SetColumnValue("NonActual", true);
				entity.SetColumnValue("NonActualReasonId", nonActualReasonId);
				entity.SetColumnValue("DateSetNonActual", DateTime.UtcNow);
				entity.Save();
			}
		}

		private void UpdateNonActualContactEmail(string recipientEmail) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddAllSchemaColumns();
			esq.Filters.Add(WebHookUtilities.CreateUpperFunctionFilter(esq, "Email", recipientEmail));
			EntityCollection entities = esq.GetEntityCollection(UserConnection);
			foreach (Entity entity in entities) {
				entity.SetColumnValue("IsNonActualEmail", true);
				entity.Save();
			}
		}

		#endregion

		#region Methods: Public

		public override string GetGroupKey() {
			return base.GetGroupKey() + RecipientUId;
		}

		public override void HandleWebHook(UserConnection userConnection) {
			UserConnection = userConnection;
			HandlePersonalResponse();
			var handlersByResponseCode = new Dictionary<int, Action> {
				{ (int)MailingResponseCode.Spam, HandleSpamResponse },
				{ (int)MailingResponseCode.HardBounce, HandleHardBounceResponse },
				{ (int)MailingResponseCode.Invalid, HandleInvalidEmailResponse }
			};
			if (handlersByResponseCode.TryGetValue(_responseCode, out Action handler)) {
				handler();
			}
		}

		#endregion

	}

	#endregion

	//using static Terrasoft.Configuration.SocialLeadGen.GetEntitiesListResponse;
}

