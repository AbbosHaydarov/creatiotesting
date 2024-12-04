namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Core;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Core.Entities;

	#region Class: SenderDomainCacheService

	/// <inheritdoc cref="ISenderDomainCacheService"/>
	public class SenderDomainCacheService : ISenderDomainCacheService
	{

		#region Constants: Private

		private const string ActiveStatus = "active";
		private const string InactiveStatus = "inactive";
		private const string OkStatus = "ok";

		#endregion

		#region Fields: Private

		private readonly ICESApi _serviceApi;
		private ILog _logger;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="SenderDomainCacheService"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="serviceApi">The service API.</param>
		public SenderDomainCacheService(UserConnection userConnection, ICESApi serviceApi) {
			_serviceApi = serviceApi;
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private ILog Logger => _logger ?? (_logger = LogManager.GetLogger("SenderDomainCacheService"));

		private int SenderDomainCachePeriod =>
			(int)Core.Configuration.SysSettings.GetValue(UserConnection, "SenderDomainCachePeriod");

		private UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		private static string GetAuthKey(UserConnection userConnection) {
			return (string)Core.Configuration.SysSettings.GetValue(userConnection, "CloudServicesAuthKey");
		}

		private AccountInfo AccountInfo() {
			try {
				string authKey = GetAuthKey(UserConnection);
				return _serviceApi.AccountInfo(authKey);
			} catch (Exception e) {
				Logger.Error("Error while trying to get account info. " + $"ApiKey: {_serviceApi.ApiKey};", e);
				return null;
			}
		}

		private void AddNewDomainToCache(AddSenderDomainsInfoRequest request) {
			string cacheKey = GetCacheKey(request.ApiKey, request.ProviderName);
			CloudSenderDomainsInfo senderDomainsInfo = GetStoredDomainsInfo(cacheKey).FirstOrDefault();
			Guid senderDomainsInfoId = senderDomainsInfo?.Id ?? CreateEmptySenderDomainsInfo(cacheKey);
			var newSenderDomain = new CloudSenderDomain {
				Domain = request.Domain,
				Status = InactiveStatus
			};
			CreateOrUpdateEmptySenderDomainsInfo(newSenderDomain, senderDomainsInfoId);
		}

		private Guid CreateEmptySenderDomainsInfo(string cacheKey) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("SenderDomainsInfo");
			Entity senderDomainsInfoSchema = schema.CreateEntity(UserConnection);
			var senderDomainsInfoId = Guid.NewGuid();
			senderDomainsInfoSchema.SetColumnValue("Id", senderDomainsInfoId);
			senderDomainsInfoSchema.SetColumnValue("CacheKey", cacheKey);
			senderDomainsInfoSchema.Save();
			return senderDomainsInfoId;
		}

		private void CreateOrUpdateEmptySenderDomainsInfo(CloudSenderDomain newSenderDomain, Guid senderDomainsInfoId) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("SenderDomain");
			Entity senderDomainSchema = schema.CreateEntity(UserConnection);
			if (!senderDomainSchema.FetchFromDB(new Dictionary<string, object> {
					{ "Domain", newSenderDomain.Domain }
				})) {
				senderDomainSchema.SetColumnValue("Id", Guid.NewGuid());
			}
			senderDomainSchema.SetColumnValue("Domain", newSenderDomain.Domain);
			senderDomainSchema.SetColumnValue("Status", newSenderDomain.Status);
			senderDomainSchema.SetColumnValue("SenderDomainsInfoId", senderDomainsInfoId);
			senderDomainSchema.SetColumnValue("ModifiedOn", DateTime.UtcNow);
			senderDomainSchema.Save();
		}

		private void CreateOrUpdateSenderDomain(CloudSenderDomain storedSenderDomain, CloudSenderDomain newSenderDomain,
			Guid senderDomainsInfoId) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("SenderDomain");
			Entity senderDomainSchema = schema.CreateEntity(UserConnection);
			if (storedSenderDomain != null && storedSenderDomain.Id != default) {
				senderDomainSchema.FetchFromDB(new Dictionary<string, object> {
					{ "Id", storedSenderDomain.Id }
				});
			} else {
				senderDomainSchema.SetColumnValue("Id", Guid.NewGuid());
			}
			senderDomainSchema.SetColumnValue("Domain", newSenderDomain.Domain);
			senderDomainSchema.SetColumnValue("Error", newSenderDomain.Error);
			senderDomainSchema.SetColumnValue("Mx", newSenderDomain.Mx);
			senderDomainSchema.SetColumnValue("Key", newSenderDomain.Key);
			senderDomainSchema.SetColumnValue("SpfKey", newSenderDomain.SpfKey);
			senderDomainSchema.SetColumnValue("Status", newSenderDomain.Status);
			senderDomainSchema.SetColumnValue("SenderDomainsInfoId", senderDomainsInfoId);
			senderDomainSchema.SetColumnValue("ModifiedOn", DateTime.UtcNow);
			senderDomainSchema.Save();
		}

		private void CreateOrUpdateSenderDomainsData(CloudSenderDomainsInfo storedSenderDomains,
			CloudSenderDomainsInfo externalSenderDomains, string cacheKey) {
			Guid senderDomainsInfoId =
				CreateOrUpdateSenderDomainsInfo(storedSenderDomains, externalSenderDomains, cacheKey);
			if (externalSenderDomains.Domains != null) {
				foreach (CloudSenderDomain externalSenderDomain in externalSenderDomains.Domains) {
					CloudSenderDomain storedSenderDomain = storedSenderDomains?.Domains?.FirstOrDefault(domain =>
						domain.Domain.Equals(externalSenderDomain.Domain, StringComparison.CurrentCultureIgnoreCase));
					CreateOrUpdateSenderDomain(storedSenderDomain, externalSenderDomain, senderDomainsInfoId);
				}
			}
			RemoveIrrelevantDomains(storedSenderDomains, externalSenderDomains);
		}

		private Guid CreateOrUpdateSenderDomainsInfo(CloudSenderDomainsInfo storedSenderDomains,
			CloudSenderDomainsInfo externalSenderDomains, string cacheKey) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("SenderDomainsInfo");
			Entity senderDomainsInfoSchema = schema.CreateEntity(UserConnection);
			Guid senderDomainsInfoId;
			if (storedSenderDomains != null && storedSenderDomains.Id != default) {
				senderDomainsInfoSchema.FetchFromDB(new Dictionary<string, object> {
					{ "Id", storedSenderDomains.Id }
				});
				senderDomainsInfoId = storedSenderDomains.Id;
			} else {
				senderDomainsInfoId = Guid.NewGuid();
				senderDomainsInfoSchema.SetColumnValue("Id", senderDomainsInfoId);
			}
			senderDomainsInfoSchema.SetColumnValue("Code", externalSenderDomains?.Code);
			senderDomainsInfoSchema.SetColumnValue("DefaultDKIMKey", externalSenderDomains?.DefaultDKIMKey);
			senderDomainsInfoSchema.SetColumnValue("DKIMRecord", externalSenderDomains?.DKIMRecord);
			senderDomainsInfoSchema.SetColumnValue("DmarkValue", externalSenderDomains?.DmarkValue);
			senderDomainsInfoSchema.SetColumnValue("DomainValidationRecord",
				externalSenderDomains?.DomainValidationRecord);
			senderDomainsInfoSchema.SetColumnValue("Message", externalSenderDomains?.Message);
			senderDomainsInfoSchema.SetColumnValue("SpfValue", externalSenderDomains?.SpfValue);
			senderDomainsInfoSchema.SetColumnValue("Status", externalSenderDomains?.Status);
			senderDomainsInfoSchema.SetColumnValue("CacheKey", cacheKey);
			senderDomainsInfoSchema.Save();
			return senderDomainsInfoId;
		}

		private void DeleteDomainsByIds(string[] domainIdsToRemove) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("SenderDomain");
			var esq = new EntitySchemaQuery(schema) {
				PrimaryQueryColumn = {
					IsAlwaysSelect = true
				}
			};
			IEntitySchemaQueryFilterItem filter =
				esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", domainIdsToRemove);
			esq.Filters.Add(filter);
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			foreach (Entity entity in entityCollection.ToArray()) {
				entity.Delete();
			}
		}

		private DateTime? GetActualCheckDate(CloudSenderDomainsInfo storedSenderDomains) {
			DateTime? actualCheckDate = storedSenderDomains?.Domains?.Select(domain => domain.ModifiedOn).Min();
			return actualCheckDate;
		}

		private string GetCacheKey(string apiKey, string providerName) {
			return $"{providerName}_sender_domains_{apiKey}";
		}

		private CloudSenderDomainsInfo GetExternalSenderDomains(SenderDomainsInfoRequest senderDomainsInfoRequest) {
			try {
				return _serviceApi.SenderDomainsInfo(senderDomainsInfoRequest);
			} catch (Exception e) {
				Logger.Error(
					"Error while trying to get sender domains. " + $"ApiKey: {senderDomainsInfoRequest.ApiKey}; " +
					$"ProviderName: {senderDomainsInfoRequest.ProviderName}", e);
				return null;
			}
		}

		private CloudSenderDomainsInfo GetSenderDomainsInfoByRequest(
			SenderDomainsInfoRequest senderDomainsInfoRequest) {
			string cacheKey = GetCacheKey(senderDomainsInfoRequest.ApiKey, senderDomainsInfoRequest.ProviderName);
			CloudSenderDomainsInfo storedSenderDomainsInfo = GetStoredSenderDomainsData(cacheKey);
			if (IsCacheValid(storedSenderDomainsInfo)) {
				return storedSenderDomainsInfo;
			}
			CloudSenderDomainsInfo externalSenderDomains = GetExternalSenderDomains(senderDomainsInfoRequest);
			if (externalSenderDomains == null ||
				!externalSenderDomains.Status.Equals(OkStatus, StringComparison.InvariantCultureIgnoreCase)) {
				return storedSenderDomainsInfo;
			}
			CreateOrUpdateSenderDomainsData(storedSenderDomainsInfo, externalSenderDomains, cacheKey);
			return externalSenderDomains;
		}

		private IEnumerable<CloudSenderDomain> GetStoredDomains(CloudSenderDomainsInfo domainsInfo) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("SenderDomain");
			var esq = new EntitySchemaQuery(schema);
			string idColumn = esq.AddColumn("Id").Name;
			string domainColumn = esq.AddColumn("Domain").Name;
			string errorColumn = esq.AddColumn("Error").Name;
			string mxColumn = esq.AddColumn("Mx").Name;
			string keyColumn = esq.AddColumn("Key").Name;
			string spfKeyColumn = esq.AddColumn("SpfKey").Name;
			string statusColumn = esq.AddColumn("Status").Name;
			string senderDomainsInfoColumn = esq.AddColumn("SenderDomainsInfo.Id").Name;
			string modifiedOnColumn = esq.AddColumn("ModifiedOn").Name;
			IEntitySchemaQueryFilterItem filter =
				esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SenderDomainsInfo.Id", domainsInfo.Id);
			esq.Filters.Add(filter);
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			IEnumerable<CloudSenderDomain> domains = entityCollection.Select(domain => new CloudSenderDomain {
				Id = domain.GetTypedColumnValue<Guid>(idColumn),
				Domain = domain.GetTypedColumnValue<string>(domainColumn),
				Error = domain.GetTypedColumnValue<string>(errorColumn),
				Mx = domain.GetTypedColumnValue<string>(mxColumn),
				Key = domain.GetTypedColumnValue<string>(keyColumn),
				SpfKey = domain.GetTypedColumnValue<string>(spfKeyColumn),
				Status = domain.GetTypedColumnValue<string>(statusColumn),
				SenderDomainsInfoId = domain.GetTypedColumnValue<Guid>(senderDomainsInfoColumn),
				ModifiedOn = TimeZoneUtilities.ConvertToUtc(UserConnection,
					domain.GetTypedColumnValue<DateTime>(modifiedOnColumn))
			});
			return domains;
		}

		private IEnumerable<CloudSenderDomainsInfo> GetStoredDomainsInfo(string cacheKey) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("SenderDomainsInfo");
			var esq = new EntitySchemaQuery(schema);
			string idColumn = esq.AddColumn("Id").Name;
			string codeColumn = esq.AddColumn("Code").Name;
			string defaultDKIMKeyColumn = esq.AddColumn("DefaultDKIMKey").Name;
			string dKIMRecordColumn = esq.AddColumn("DKIMRecord").Name;
			string dmarkValueColumn = esq.AddColumn("DmarkValue").Name;
			string domainValidationRecordColumn = esq.AddColumn("DomainValidationRecord").Name;
			string messageColumn = esq.AddColumn("Message").Name;
			string spfValueColumn = esq.AddColumn("SpfValue").Name;
			string statusColumn = esq.AddColumn("Status").Name;
			string cacheKeyColumn = esq.AddColumn("CacheKey").Name;
			IEntitySchemaQueryFilterItem filter =
				esq.CreateFilterWithParameters(FilterComparisonType.Equal, cacheKeyColumn, cacheKey);
			esq.Filters.Add(filter);
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			return entityCollection.Select(domainsInfo => new CloudSenderDomainsInfo {
				Id = domainsInfo.GetTypedColumnValue<Guid>(idColumn),
				Code = domainsInfo.GetTypedColumnValue<int>(codeColumn),
				DefaultDKIMKey = domainsInfo.GetTypedColumnValue<string>(defaultDKIMKeyColumn),
				DKIMRecord = domainsInfo.GetTypedColumnValue<string>(dKIMRecordColumn),
				DmarkValue = domainsInfo.GetTypedColumnValue<string>(dmarkValueColumn),
				DomainValidationRecord = domainsInfo.GetTypedColumnValue<string>(domainValidationRecordColumn),
				Message = domainsInfo.GetTypedColumnValue<string>(messageColumn),
				SpfValue = domainsInfo.GetTypedColumnValue<string>(spfValueColumn),
				Status = domainsInfo.GetTypedColumnValue<string>(statusColumn),
				CacheKey = domainsInfo.GetTypedColumnValue<string>(cacheKeyColumn),
				Domains = new List<CloudSenderDomain>()
			});
		}

		private CloudSenderDomainsInfo GetStoredSenderDomainsData(string cacheKey) {
			CloudSenderDomainsInfo storedDomainsInfo = GetStoredDomainsInfo(cacheKey).FirstOrDefault();
			if (storedDomainsInfo == null) {
				return null;
			}
			IEnumerable<CloudSenderDomain> storedDomains = GetStoredDomains(storedDomainsInfo);
			if (!storedDomains.Any()) {
				return storedDomainsInfo;
			}
			storedDomainsInfo.Domains.AddRange(storedDomains);
			return storedDomainsInfo;
		}

		private bool IsCacheValid(CloudSenderDomainsInfo storedSenderDomains) {
			DateTime checkDateTime = DateTime.UtcNow.AddMinutes(-SenderDomainCachePeriod);
			return storedSenderDomains != null && storedSenderDomains.Domains.Any() &&
				storedSenderDomains.Domains.All(domain =>
					domain.Status.Equals(ActiveStatus, StringComparison.InvariantCultureIgnoreCase)) &&
				checkDateTime < GetActualCheckDate(storedSenderDomains);
		}

		private void RemoveIrrelevantDomains(CloudSenderDomainsInfo storedSenderDomains,
			CloudSenderDomainsInfo externalSenderDomains) {
			if (storedSenderDomains == null || storedSenderDomains.Domains.IsNullOrEmpty()) {
				return;
			}
			IEnumerable<CloudSenderDomain> domainsToRemove = externalSenderDomains.Domains.IsNullOrEmpty()
				? storedSenderDomains.Domains 
				: storedSenderDomains.Domains.Except(externalSenderDomains.Domains,
					(storedDomain, externalDomain) => storedDomain.Domain.Equals(externalDomain?.Domain,
						StringComparison.InvariantCultureIgnoreCase));
			if (!domainsToRemove.Any()) {
				return;
			}
			string[] domainIdsToRemove = domainsToRemove.Select(domain => domain.Id.ToString()).ToArray();
			DeleteDomainsByIds(domainIdsToRemove);
		}

		private void SetProviderNameIfNeeded(Action<string> setProviderName, string providerName) {
			if (providerName.IsNotNullOrEmpty()) {
				return;
			}
			AccountInfo accountInfo = AccountInfo();
			providerName = accountInfo?.Services?.FirstOrDefault()?.Settings?.Provider;
			if (!string.IsNullOrEmpty(providerName)) {
				setProviderName(providerName);
			}
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="ISenderDomainCacheService.AddDomainToCache"/>
		public void AddDomainToCache(AddSenderDomainsInfoRequest addSenderDomainsInfoRequest) {
			if (!UserConnection.GetIsFeatureEnabled("SenderDomainsCache")) {
				return;
			}
			SetProviderNameIfNeeded(providerName => addSenderDomainsInfoRequest.ProviderName = providerName,
				addSenderDomainsInfoRequest.ProviderName);
			AddNewDomainToCache(addSenderDomainsInfoRequest);
		}

		/// <inheritdoc cref="ISenderDomainCacheService.GetSenderDomainsInfo"/>
		public CloudSenderDomainsInfo GetSenderDomainsInfo(SenderDomainsInfoRequest senderDomainsInfoRequest) {
			if (!UserConnection.GetIsFeatureEnabled("SenderDomainsCache")) {
				return _serviceApi.SenderDomainsInfo(senderDomainsInfoRequest);
			}
			SetProviderNameIfNeeded(providerName => senderDomainsInfoRequest.ProviderName = providerName,
				senderDomainsInfoRequest.ProviderName);
			return GetSenderDomainsInfoByRequest(senderDomainsInfoRequest);
		}

		#endregion

	}

	#endregion

	/// <summary>
	/// Provides a data caching service for the sender's domain.
	/// </summary>
	public interface ISenderDomainCacheService
	{
		/// <summary>
		/// Adds the sender domain to the cache.
		/// </summary>
		/// <param name="addSenderDomainsInfoRequest">Add sender domains information request.</param>
		void AddDomainToCache(AddSenderDomainsInfoRequest addSenderDomainsInfoRequest);

		/// <summary>
		/// Returns sender domains info by the provider name.
		/// </summary>
		/// <param name="senderDomainsInfoRequest">The sender domains information request.</param>
		/// <returns>Sender domains info.</returns>
		CloudSenderDomainsInfo GetSenderDomainsInfo(SenderDomainsInfoRequest senderDomainsInfoRequest);

	}
}

