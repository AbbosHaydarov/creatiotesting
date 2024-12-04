namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Quartz;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Scheduler;

	/// <summary>
	/// Helper class to work with scheduled mailings.
	/// </summary>
	public class BulkEmailScheduleHelper
	{

		#region Consts: Private

		private const string JobGroupName = "Mailing";

		private const string SendProcessName = "SendBulkEmailProcess";

		private const int TriggerEmailStartDateShift = 1;

		#endregion

		#region Fields: Private

		private readonly string _applicationUrl;
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="userConnection">Instance of user connection.</param>
		/// <param name="applicationUrl">External address of the BPMonline application.</param>
		public BulkEmailScheduleHelper(UserConnection userConnection, string applicationUrl) {
			_userConnection = userConnection;
			_applicationUrl = applicationUrl;
		}

		#endregion

		#region Methods: Private

		private string GetJobName(Guid entityId) {
			return "SendBulkEmail_" + entityId.ToString().Replace("-", "_");
		}

		private string GetJobExecutorName() {
			string jobExecutorName = _userConnection.CurrentUser.Name;
			Guid systemUserId = _userConnection.AppConnection.SystemUserConnection.CurrentUser.Id;
			if (_userConnection.CurrentUser.Id == systemUserId) {
				return jobExecutorName;
			}
			var selectQuery = new Select(_userConnection).Column("Name").From("SysAdminUnit").Where("Id")
				.IsEqual(Column.Parameter(systemUserId)) as Select;
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader reader = selectQuery.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						jobExecutorName = reader.GetColumnValue<string>("Name");
					}
				}
			}
			return jobExecutorName;
		}

		private void ScheduleImmediateJob(string jobName, Guid entityId) {
			string jobExecutorName = GetJobExecutorName();
			Dictionary<string, object> parameters = new Dictionary<string, object>();
			parameters.Add("ApplicationUrl", _applicationUrl);
			parameters.Add("BulkEmailId", entityId.ToString());
			AppScheduler.ScheduleImmediateProcessJob(jobName, JobGroupName, SendProcessName,
				_userConnection.Workspace.Name, jobExecutorName, parameters);
		}

		private void ShiftTriggerEmailStartDate(Guid bulkEmailId, int daysCount) {
			var parameters = new KeyValuePair<string, object>[] {
				new KeyValuePair<string, object>("RecordId", bulkEmailId),
				new KeyValuePair<string, object>("DaysCount", daysCount)
			};
			MailingDbUtilities.ExecuteStoredProcedure(_userConnection, "tsp_ShiftTriggerEmailStartDate", parameters);
		}

		private IEnumerable<Guid> GetBulkEmailsFromSendQueue() {
			var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "VwBulkEmailSendWaiting");
			esq.JoinRightState = Terrasoft.Core.DB.QueryJoinRightLevel.Disabled;
			string primaryColumnName = esq.AddColumn("Id").Name;
			EntityCollection entities = esq.GetEntityCollection(_userConnection);
			List<Guid> resultCollection = new List<Guid>();
			foreach (Entity entity in entities) {
				Guid entityId = entity.GetTypedColumnValue<Guid>(primaryColumnName);
				resultCollection.Add(entityId);
			}
			return resultCollection;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Schedules bulk email from send queue to sent.
		/// </summary>
		public void ScheduleBulkEmailsFromSendQueue() {
			IEnumerable<Guid> bulkEmailIds = GetBulkEmailsFromSendQueue();
			foreach (Guid entityId in bulkEmailIds) {
				string jobName = GetJobName(entityId);
				IJobDetail jobDetail = MailingSchedulerUtilities.FindJob(jobName, JobGroupName);
				if (jobDetail != null) {
					continue;
				}
				ShiftTriggerEmailStartDate(entityId, TriggerEmailStartDateShift);
				ScheduleImmediateJob(jobName, entityId);
			}
		}

		#endregion

	}
}

