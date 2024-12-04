namespace CrtCloudIntegration
{
	using CrtCloudIntegration.Models.Responses;
	using CrtCloudIntegration.Models.Requests;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using CrtCloudIntegration.Interfaces;
	using Terrasoft.Core.Factories;
	using System.Collections.Generic;

	#region Class: OAuthAccountServiceApi

	/// <inheritdoc cref="IOAuthAccountServiceApi"/>
	[DefaultBinding(typeof(IOAuthAccountServiceApi))]
	public class OAuthAccountServiceApi : AccountServiceApi, IOAuthAccountServiceApi
	{

		#region Constructors: Public

		/// <summary>
		/// Constructor of the class.
		/// </summary>
		/// <param name="userConnection">Instance of UserConnection.</param>
		/// <param name="scope">Identity scope.</param>
		public OAuthAccountServiceApi(UserConnection userConnection, string scope)
			: base(userConnection, scope) {
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IOAuthAccountServiceApi.GetToken"/>
		public string GetToken(GetTokenRequest request) {
			string url = $"{AccountServiceUrl}/api/OAuth/getToken";
			var response = SendPostRequest<TokenInfo>(url, request);
			return response.Token;
		}

		/// <inheritdoc cref="IOAuthAccountServiceApi.GetTokens"/>
		public IEnumerable<string> GetTokens(GetTokensRequest request) {
			string url = $"{AccountServiceUrl}/api/OAuth/getTokens";
			var response = SendPostRequest<TokenInfos>(url, request);
			return response.Tokens;
		}

		/// <inheritdoc cref="IOAuthAccountServiceApi.StartFlow"/>
		public StartOAuthFlowResponse StartFlow(StartFlowRequest request) {
			string url = $"{AccountServiceUrl}/api/OAuth/startFlow";
			StartOAuthFlowResponse response = SendPostRequest<StartOAuthFlowResponse>(url, request);
			return response;
		}

		#endregion

	}

	#endregion
}
