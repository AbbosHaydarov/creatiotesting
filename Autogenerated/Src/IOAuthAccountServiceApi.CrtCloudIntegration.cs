namespace CrtCloudIntegration.Interfaces
{
	using Models.Requests;
	using Models.Responses;
	using System.Collections.Generic;

	#region IOAuthAccountServiceApi
	/// <summary>
	/// Provide information from account authentication service.
	/// </summary>
	public interface IOAuthAccountServiceApi
	{

		#region Methods: Public

		/// <summary>
		/// Action to start the authorization flow.
		/// </summary>
		/// <param name="request">Request that contain information about the app you want to authenticate to.</param>
		/// <returns>Instance of <see cref="StartOAuthFlowResponse"/>></returns>
		StartOAuthFlowResponse StartFlow(StartFlowRequest request);

		/// <summary>
		/// Action to get one token to access an external platform.
		/// </summary>
		/// <param name="request">Request that contain information about the app you want to get token.</param>
		string GetToken(GetTokenRequest request);

		/// <summary>
		/// Action to get all avaliable tokens.
		/// </summary>
		/// <param name="request">Request that contain information about the app you want to get tokens.</param>
		/// <returns>Instance of <see cref="TokenInfos"/>></returns>
		IEnumerable<string> GetTokens(GetTokensRequest request);

		#endregion

	}

	#endregion

}
