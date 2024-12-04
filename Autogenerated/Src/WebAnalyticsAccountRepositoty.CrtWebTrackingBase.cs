namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using global::Common.Logging;

	#region Interface: IWebAnalyticsAccount

	/// <summary>
	/// Defines implementation of web analytics account.
	/// </summary>
	public interface IWebAnalyticsAccount
	{
		string Id { get; set; }
		string Name { get; set; }
	}

	#endregion

	#region Class: WebAnalyticsAccountRepositoty

	/// <summary>
	/// Implements the interface for the saving web analytics accounts.
	/// </summary>
	/// <seealso cref="IWebAnalyticsAccountRepositoty" />
	[Obsolete("8.1.5 | Will be removed in the upcoming releases")]
	[DefaultBinding(typeof(IWebAnalyticsAccountRepositoty))]
	public class WebAnalyticsAccountRepositoty: IWebAnalyticsAccountRepositoty
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;
		private readonly ILog _logger;
		private readonly Guid _analitycsPlatformId;
		private readonly Guid ConnectedStatusId = new Guid("51B41366-E59D-4891-AF51-35E1D762B382");
		private readonly Guid DisconnectedStatusId = new Guid("8B07BD13-6A0F-40C9-AD67-F965FBB63BBA");

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="WebAnalyticsAccountRepositoty"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="logger">The logger.</param>
		public WebAnalyticsAccountRepositoty(UserConnection userConnection, ILog logger, Guid analitycsPlatformId) {
			_userConnection = userConnection;
			_logger = logger;
			_analitycsPlatformId = analitycsPlatformId;
		}

		#endregion

		#region Methods: Private

		private EntitySchemaQuery GetAccountsQuery() {
			var esqResult = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "WebAnalyticsAccount") {
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

		private EntityCollection GetExistingAccounts(string platformUserId) {
			var esqResult = GetAccountsQuery();
			var filterByPlatformUserId =
				esqResult.CreateFilterWithParameters(FilterComparisonType.Equal, "PlatformUserId", platformUserId);
			esqResult.Filters.Add(filterByPlatformUserId);
			return esqResult.GetEntityCollection(_userConnection);
		}

		private bool IsExistingAccount(string accountId, EntityCollection accountsCollection) {
			var accountEntity = accountsCollection.Where(x => x.GetTypedColumnValue<string>("AccountId") == accountId)
				.FirstOrDefault();
			return accountEntity != null;
		}

		private void SaveNewAccount(IWebAnalyticsAccount account, string platformUserId) {
			var entity = _userConnection.EntitySchemaManager.GetInstanceByName("WebAnalyticsAccount")
				.CreateEntity(_userConnection);
			entity.SetDefColumnValues();
			entity.SetColumnValue("AccountId", account.Id);
			entity.SetColumnValue("Name", account.Name);
			entity.SetColumnValue("PlatformUserId", platformUserId);
			entity.SetColumnValue("ConnectionStatusId", ConnectedStatusId);
			entity.SetColumnValue("WebAnalyticsPlatformId", _analitycsPlatformId);
			entity.Save();
		}

		private void UpdateAccounts(IEnumerable<IWebAnalyticsAccount> accountsList, EntityCollection accounts) {
			accounts.ForEach(entity => {
				var accountName = accountsList
					.Where(a => entity.GetTypedColumnValue<string>("AccountId").Equals(a.Id))
					.Select(a => a.Name).FirstOrDefault();
				var connectionStatusId = string.IsNullOrEmpty(accountName) ? DisconnectedStatusId : ConnectedStatusId;
				if (!string.IsNullOrEmpty(accountName)) {
					entity.SetColumnValue("Name", accountName);
				}
				entity.SetColumnValue("ConnectionStatusId", connectionStatusId);
				entity.Save();
			});
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IWebAnalyticsAccountRepositoty.GetConnectedAccounts()"/>
		public EntityCollection GetConnectedAccounts() {
			var esqResult = GetAccountsQuery();
			var filterByStatus = esqResult.CreateFilterWithParameters(FilterComparisonType.Equal,
				"ConnectionStatus", ConnectedStatusId);
			esqResult.Filters.Add(filterByStatus);
			var accounts = esqResult.GetEntityCollection(_userConnection);
			var result = new EntityCollection(_userConnection, "WebAnalyticsAccount");
			var ids = new List<string>();
			foreach (var entity in accounts) {
				var accountId = entity.GetTypedColumnValue<string>("AccountId");
				if (ids.Contains(accountId)) {
					continue;
				}
				ids.Add(accountId);
				result.Add(entity);
			};
			return result;
		}

		/// <inheritdoc cref="IWebAnalyticsAccountRepositoty.SaveAccounts(IEnumerable{AnalyticsAccount}, string)"/>
		public void SaveAccounts(IEnumerable<IWebAnalyticsAccount> accountsList, string platformUserId) {
			try {
				if (platformUserId == null) {
					throw new ArgumentNullException("PlatformUserId is null");
				}
				var connectedAccountsIdentifiers = accountsList.Select(x => x.Id.ToString()).ToArray();
				var accountCollection = GetExistingAccounts(platformUserId);
				UpdateAccounts(accountsList, accountCollection);
				foreach (var account in accountsList) {
					if (accountCollection.Any() && IsExistingAccount(account.Id, accountCollection)) {
						continue;
					}
					SaveNewAccount(account, platformUserId);
				}
			} catch (Exception e) {
				_logger.Error(e.Message);
				throw;
			}
		}

		#endregion

	}

	#endregion

}
