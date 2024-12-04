namespace Terrasoft.Configuration.CampaignService
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.WebService;
	using Terrasoft.Web.Http.Abstractions;
	using ErrorInfo = Terrasoft.Core.ServiceModelContract.ErrorInfo;

	#region Class: CampaignService
	/// <summary>
	/// Service class for managing of campaigns.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class CampaignService
	{

		#region Constants: Private
		
		private const string CampaignHasAlreadyStoppedException = "CampaignHasAlreadyStopped";

		#endregion

		#region Properties: Public

		private UserConnection _userConnection;

		/// <summary>
		/// Gets or sets user connection.
		/// </summary>
		public UserConnection UserConnection {
			get {
				return _userConnection ??
					(_userConnection = HttpContext.Current.Session["UserConnection"] as UserConnection);
			}
			set {
				_userConnection = value;
			}
		}

		/// <summary>
		/// An instance of the <see cref="FolderHelper"/> class.
		/// </summary>
		private FolderHelper _folderHelper;
		public FolderHelper FolderHelper {
			get {
				return _folderHelper ?? (_folderHelper = new FolderHelper());
			}
			set {
				_folderHelper = value;
			}
		}

		/// <summary>
		/// Gets or sets the campaign helper. Instance of <see cref="CampaignHelper"/>.
		/// </summary>
		private CampaignHelper _campaignHelper;
		public CampaignHelper CampaignHelper {
			get {
				return _campaignHelper ?? (_campaignHelper = new CampaignHelper(UserConnection));
			}
			set {
				_campaignHelper = value;
			}
		}

		/// <summary>
		/// Gets or sets the campaign analytics provider. Instance of <see cref="CampaignAnalyticsProvider"/>.
		/// </summary>
		private CampaignAnalyticsProvider _campaignAnalyticsProvider;
		public CampaignAnalyticsProvider CampaignAnalyticsProvider {
			get {
				return _campaignAnalyticsProvider ??
					(_campaignAnalyticsProvider = new CampaignAnalyticsProvider(UserConnection));
			}
			set {
				_campaignAnalyticsProvider = value;
			}
		}

		#endregion

		#region Methods: Private

		private CampaignConfigurationServiceResponse GetResponse(CampaignSchema schema, bool isWarningsIgnore) {
			return new CampaignConfigurationServiceResponse {
				Success = schema.IsSchemaValid(isWarningsIgnore),
				ErrorInfo = new ErrorInfo {
					Message = schema.ErrorValidationMessage
				},
				WarningInfo = new WarningInfo {
					Message = schema.WarningValidationMessage
				}
			};
		}

		private IEnumerable<Guid> GetCampaignIds(string filtersConfig) {
			var campaignIds = new List<Guid>();
			var utilities = ClassFactory.Get<GridUtilitiesServiceHandler>();
			var campaignIdsText = utilities.GetPrimaryColumnValuesFromFilters("Campaign", filtersConfig);
			campaignIdsText.ForEach(x => {
				var result = Guid.TryParse(x, out var campaignId);
				if (result) {
					campaignIds.Add(campaignId);
				}
			});
			return campaignIds;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Launches given campaign with new engine.
		/// </summary>
		/// <param name="campaignId">Unique identifier of campaign created in new designer.</param>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "v2/LaunchCampaign", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public CampaignConfigurationServiceResponse LaunchCampaignV2(Guid campaignId, bool ignoreWarnings = false) {
			try {
				CampaignSchema schema = CampaignHelper.GetCampaignSchema(campaignId);
				if (ignoreWarnings) {
					CampaignEventFacade.StartWithWarnings(UserConnection, schema);
				} else {
					CampaignEventFacade.Start(UserConnection, schema);
				}
				return GetResponse(schema, ignoreWarnings);
			} catch (Exception e) {
				return new CampaignConfigurationServiceResponse(e);
			}
		}

		/// <summary>
		/// Completes given campaign with new engine.
		/// </summary>
		/// <param name="campaignId">Unique identifier of campaign created in new designer.</param>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "v2/CompleteCampaign", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public CampaignConfigurationServiceResponse CompleteCampaignV2(Guid campaignId) {
			try {
				var campaignInfo = CampaignHelper.GetCampaignInfo(campaignId);
				if (campaignInfo.CampaignStatusId == CampaignConsts.StoppingCampaignStatusId
						|| campaignInfo.CampaignStatusId == CampaignConsts.CompletedCampaignStatusId) {
					string errorText = CampaignHelper
						.GetLczStringValue(nameof(CampaignService), CampaignHasAlreadyStoppedException);
					string message = string.Format(errorText, campaignId);
					throw new InvalidOperationException(message);
				}
				var schema = CampaignHelper.GetCampaignSchema(campaignId);
				CampaignEventFacade.Finalize(UserConnection, schema);
				if (!campaignInfo.InProgress) {
					CampaignEventFacade.Stop(UserConnection, schema);
				}
			} catch (Exception e) {
				return new CampaignConfigurationServiceResponse(e);
			}
			return new CampaignConfigurationServiceResponse();
		}

		/// <summary>
		/// Returns entities folder info model of type <see cref="FolderInfoModel"/>.
		/// </summary>
		/// <param name="folderId">The folder identifier.</param>
		/// <returns>Folder data info.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetContactFolderInfo", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public FolderInfoModel GetContactFolderInfo(Guid folderId, string folderSchemaName = null) {
			return FolderHelper.GetFolderInfo(folderSchemaName ?? "ContactFolder", folderId, UserConnection);
		}

		/// <summary>
		/// Service method which returns next fire time for campaign with id <paramref name="campaignId"/>
		/// starting from now.
		/// </summary>
		/// <param name="campaignId">Campaign identifier.</param>
		/// <param name="includeTimezoneOffset">A flag that indicates if necessary to add current user
		/// time zone offset in minutes.</param>
		/// <returns>Instance of <see cref="CampaignNextFireTimeResponse"/> which includes information 
		/// about campaign next fire time.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetCampaignNextFireTime", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public CampaignNextFireTimeResponse GetCampaignNextFireTime(Guid campaignId, bool includeTimezoneOffset) {
			var campaignScheduler = new CampaignTimeScheduler(UserConnection);
			var nextFireTime = campaignScheduler.GetCampaignNextFireTime(campaignId, includeTimezoneOffset);
			var response = new CampaignNextFireTimeResponse {
				NextFireTime = DateTimeDataValueType.Serialize(nextFireTime, TimeZoneInfo.Utc)
			};
			return response;
		}

		/// <summary>
		/// Service method which calculates campaign participant analytics.
		/// </summary>
		/// <param name="request">Instance of <see cref="ParticipantsAnalyticsRequest"/> which contains 
		/// parameters for calculation.</param>
		/// <returns>Instance of <see cref="ParticipantsAnalyticsResponse"/> which contains analytics 
		/// for each campaign item which contains participants.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetParticipantsAnalytics", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ParticipantsAnalyticsResponse GetParticipantsAnalytics(ParticipantsAnalyticsRequest request) {
			var analyticsProvider = new CampaignAnalyticsProvider(UserConnection);
			return analyticsProvider.GetParticipantsAnalytics(request);
		}

		/// <summary>
		/// Returns True if there is one or more participants for the specified campaign.
		/// </summary>
		/// <param name="campaignId">Id of current campaign.</param>
		/// <returns>False for the campaign with empty audience.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "HasParticipants", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool HasParticipants(Guid campaignId) {
			return CampaignAnalyticsProvider.HasParticipants(new Guid[] { campaignId });
		}

		/// <summary>
		/// Returns True if there is one or more participants for the specified campaigns.
		/// </summary>
		/// <param name="filtersConfig">Serialized filter.</param>
		/// <returns>False if all the campaigns are with empty audience.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "HasParticipantsByFilter", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool HasParticipantsByFilter(string filtersConfig) {
			var campaignIds = GetCampaignIds(filtersConfig);
			return CampaignAnalyticsProvider.HasParticipants(campaignIds);
		}

		/// <summary>
		/// Returns current status for the campaign specified.
		/// </summary>
		/// <param name="campaignId">Id of current campaign.</param>
		/// <returns>Campaign status id.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetCampaignStatus", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public Guid GetCampaignStatus(Guid campaignId) {
			var info = CampaignHelper.GetCampaignInfo(campaignId);
			return info.CampaignStatusId;
		}

		/// <summary>
		/// Returns current statuses for the campaigns that are specified.
		/// </summary>
		/// <param name="campaignId">Serialized filter.</param>
		/// <returns>Campaign status ids.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetCampaignStatusByFilter", BodyStyle = WebMessageBodyStyle.Wrapped,
				RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public IEnumerable<Guid> GetCampaignStatusByFilter(string filtersConfig) {
			var campaignIds = GetCampaignIds(filtersConfig);
			return campaignIds.Select(campaignId => CampaignHelper.GetCampaignInfo(campaignId).CampaignStatusId);
		}

		#endregion

	}

	#endregion

}

