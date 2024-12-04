namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using global::Common.Logging;

	#region Class: WebAnalyticsStreamModel

	/// <summary>
	/// Defines implementation of web analytics stream (site).
	/// </summary>
	public class WebAnalyticsStreamModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string DefaultUri { get; set; }
		public string StreamId { get; set; }
	}

	#endregion

	#region Class: BaseWebAnalyticsAccountRepositoty

	/// <summary>
	/// Base class to work with web analytics accounts and streams.
	/// </summary>
	public abstract class BaseWebAnalyticsAccountRepositoty
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;
		private readonly ILog _logger;
		private readonly Guid _analitycsPlatformId;

		#endregion

		#region Fields: Protected

		protected readonly Guid ConnectedStatusId = new Guid("51B41366-E59D-4891-AF51-35E1D762B382");
		protected readonly Guid DisconnectedStatusId = new Guid("8B07BD13-6A0F-40C9-AD67-F965FBB63BBA");

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseWebAnalyticsAccountRepositoty"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="logger">The logger.</param>
		/// <param name="analitycsPlatformId">The analytics platform identifier.</param>
		public BaseWebAnalyticsAccountRepositoty(UserConnection userConnection, ILog logger, Guid analitycsPlatformId) {
			_userConnection = userConnection;
			_logger = logger;
			_analitycsPlatformId = analitycsPlatformId;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Instance of the <see cref="UserConnection"/>.
		/// </summary>
		protected UserConnection UserConnection {
			get => _userConnection; 
		}

		/// <summary>
		/// Instance of the <see cref="ILog"/> logger.
		/// </summary>
		protected ILog Logger {
			get => _logger; 
		}

		#endregion

		#region Methods: Private

		protected EntitySchemaQuery GetAccountsQuery() {
			var esqResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "WebAnalyticsAccount") {
				PrimaryQueryColumn = { IsVisible = true }
			};
			esqResult.AddColumn("Id");
			esqResult.AddColumn("AccountId");
			esqResult.AddColumn("Name");
			esqResult.AddColumn("ConnectionStatus");
			var filterByPlatformId =
				esqResult.CreateFilterWithParameters(FilterComparisonType.Equal, "WebAnalyticsPlatform", _analitycsPlatformId);
			esqResult.Filters.Add(filterByPlatformId);
			return esqResult;
		}

		protected bool IsExistingAccount(string accountId, EntityCollection accountsCollection) =>
			accountsCollection != null && accountsCollection.Any(x => x.GetTypedColumnValue<string>("AccountId") == accountId);

		protected Entity GetExistingAccount(string accountId, EntityCollection accountsCollection) =>
			accountsCollection.Where(x => x.GetTypedColumnValue<string>("AccountId") == accountId)
				.FirstOrDefault();

		protected virtual Guid SaveNewAccount(IWebAnalyticsAccount account) {
			var entity = UserConnection.EntitySchemaManager.GetInstanceByName("WebAnalyticsAccount")
				.CreateEntity(UserConnection);
			entity.SetDefColumnValues();
			entity.SetColumnValue("AccountId", account.Id);
			entity.SetColumnValue("Name", account.Name);
			entity.SetColumnValue("ConnectionStatusId", ConnectedStatusId);
			entity.SetColumnValue("WebAnalyticsPlatformId", _analitycsPlatformId);
			entity.Save();
			return entity.PrimaryColumnValue;
		}

		protected EntitySchemaQuery GetStreamsQuery(Guid accountId) {
			var esqResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "WebAnalyticsStream") {
				PrimaryQueryColumn = { IsVisible = true }
			};
			esqResult.AddColumn("Id");
			esqResult.AddColumn("StreamId");
			esqResult.AddColumn("Name");
			esqResult.AddColumn("SiteUrl");
			var filterByAccount =
				esqResult.CreateFilterWithParameters(FilterComparisonType.Equal, "WebAnalyticsAccount", accountId);
			esqResult.Filters.Add(filterByAccount);
			return esqResult;
		}

		protected EntityCollection GetExistingStreams(Guid accountId) {
			var esqResult = GetStreamsQuery(accountId);
			return esqResult.GetEntityCollection(UserConnection);
		}

		protected void UpdateStreams(IEnumerable<WebAnalyticsStreamModel> streamList, EntityCollection streams) {
			streams.ForEach(entity => {
				var stream = streamList
					.Where(s => entity.GetTypedColumnValue<string>("StreamId").Equals(s.StreamId))
					.FirstOrDefault();
				if (!string.IsNullOrEmpty(stream?.Name)) {
					entity.SetColumnValue("Name", stream.Name);
				}
				if (!string.IsNullOrEmpty(stream?.DefaultUri)) {
					entity.SetColumnValue("SiteUrl", stream.DefaultUri);
				}
				entity.Save();
			});
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns collection of the connected accounts for current web analytics platform.
		/// </summary>
		/// <returns>Collection of the connected accounts.</returns>
		public virtual EntityCollection GetConnectedAccounts() {
			var esqResult = GetAccountsQuery();
			var filterByStatus = esqResult.CreateFilterWithParameters(FilterComparisonType.Equal,
				"ConnectionStatus", ConnectedStatusId);
			esqResult.Filters.Add(filterByStatus);
			return esqResult.GetEntityCollection(UserConnection);
		}

		#endregion

	}

	#endregion

}
