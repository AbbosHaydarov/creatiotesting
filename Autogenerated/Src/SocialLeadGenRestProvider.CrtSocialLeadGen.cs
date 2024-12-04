namespace Terrasoft.Configuration.SocialLeadGen
{
	using System;
	using System.Net;
    using Newtonsoft.Json;
	using Terrasoft.Configuration.BpmonlineCloudIntegration;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Requests;
	using IHttpResponse = Terrasoft.Core.Requests.IHttpResponse;

    #region Class: SocialLeadGenRestProvider

    /// <summary>
    /// Provide information from tracking service.
    /// </summary>
    public class SocialLeadGenRestProvider
	{

		#region Constants: Private

		private const string _socialLeadgenApiScope = "social_leadgen_api";

		#endregion

		#region Fields: Private

		private IHttpRequestClient _httpRequestClient;

		private IdentityServerProvider _identityServerProvider;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor of a class.
		/// </summary>
		/// <param name="userConnection">Instance of UserConnection.</param>
		public SocialLeadGenRestProvider(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		/// <summary>
		/// Identity server provider instance. Returns established provider.
		/// If established is null then create instance of <see cref="IdentityServerProvider"/> 
		/// from <see cref="ClassFactory"/>.
		/// </summary>
		private IdentityServerProvider IdentityServerProvider {
			get {
				if (_identityServerProvider == null) {
					_identityServerProvider = CreateIdentityServerProvider();
				}
				return _identityServerProvider;
			}
			set { _identityServerProvider = value; }
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Gets or sets the rest client for Api calls.
		/// </summary>
		/// <value>
		/// The rest client.
		/// </value>
		protected IHttpRequestClient HttpRequestClient {
			get {
				if (_httpRequestClient == null) {
					_httpRequestClient = ClassFactory.Get<IHttpRequestClient>();
				}
				return _httpRequestClient;
			}
			set { _httpRequestClient = value; }
		}

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		private HttpRequestConfig CreateHttpRequestConfigWithToken(string url) {
			string token = IdentityServerProvider.GetAccessTokenWithExceptionHandle(_socialLeadgenApiScope);
			var request = new HttpRequestConfig {
				Url = new Uri(url)
			};
			request.Headers.Add("Authorization", $"Bearer {token}");
			return request;
		}

		private IdentityServerProvider CreateIdentityServerProvider() {
			var userConnectionArg = new ConstructorArgument("userConnection", UserConnection);
			return ClassFactory.Get<IdentityServerProvider>(userConnectionArg);
		}

		private T GetResponseData<T>(IHttpResponse response)
			where T : SocialLeadGenRestProviderResponse, new() {
			return response.GetResult<T>() ?? new T();
		}

		private T SendTokenizedRequest<T>(HttpRequestMethod method, string url, object bodyObject = default)
			where T : SocialLeadGenRestProviderResponse, new() {
			HttpRequestConfig httpRequestConfig = CreateHttpRequestConfigWithToken(url);
			httpRequestConfig.Method = method;
            string jsonContent = string.Empty;
            if (bodyObject != default) {
                jsonContent = JsonConvert.SerializeObject(bodyObject);
            }
            IHttpResponse response = bodyObject != default ? HttpRequestClient.SendWithJsonBody(httpRequestConfig, jsonContent)
				: HttpRequestClient.Send(httpRequestConfig);
			CheckResponseForError<T>(response);
			return GetResponseData<T>(response);
		}

		private IHttpResponse SendTokenizedRequest(HttpRequestMethod method, string url, string jsonBody) {
			HttpRequestConfig request = CreateHttpRequestConfigWithToken(url);
			request.Method = method;
			IHttpResponse response;
            if (jsonBody != default) {
				response = HttpRequestClient.SendWithJsonBody(request, jsonBody);
				CheckResponseForError(response);
				return response;
			}
			response = HttpRequestClient.Send(request);
			CheckResponseForError(response);
			return response;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Checks response for exceptions occured.
		/// </summary>
		/// <typeparam name="T">Data provider response type.</typeparam>
		/// <param name="response">Instance of the response.</param>
		/// <exception cref="DataProviderException">Throws when <paramref name="response"/> 
		/// status code is not <see cref="HttpStatusCode.OK"/></exception>
		protected void CheckResponseForError<T>(IHttpResponse response)
			where T : SocialLeadGenRestProviderResponse, new() {
			if (response.StatusCode != HttpStatusCode.OK) {
				string errorMessage = response.GetResult<SocialLeadGenRestProviderResponse>().ErrorMessage ??
					response.Exception.Message ?? response.ReasonPhrase;
				throw new SocialLeadGenRestProviderException(response?.Exception?.Message, errorMessage,
					response.Exception, response.StatusCode, response.RequestConfig.Url.ToString());
			}
		}

		/// <summary>
		/// Checks response for exceptions occured.
		/// </summary>
		/// <param name="response">Instance of the response.</param>
		/// <exception cref="DataProviderException">Throws when <paramref name="response"/> 
		/// status code is not <see cref="HttpStatusCode.OK"/></exception>
		protected void CheckResponseForError(IHttpResponse response) {
			if (response.StatusCode != HttpStatusCode.OK) {
				SocialLeadGenRestProviderResponse remoteErrorResponse = null;
				try {
					remoteErrorResponse = response.GetResult<SocialLeadGenRestProviderResponse>();
				} catch { }
				string errorMessage = remoteErrorResponse?.ErrorMessage ??
					response?.Exception?.Message ?? response.ReasonPhrase;
				throw new SocialLeadGenRestProviderException(remoteErrorResponse?.ErrorMessage, errorMessage,
					response.Exception, response.StatusCode, response.RequestConfig.Url.ToString());
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Sends <see cref="RestRequest"/> to <paramref name="url"/> with <paramref name="bodyObject"/>.
		/// Sets token to request and request body format <see cref="Method.POST"/>.
		/// </summary>
		/// <typeparam name="T"><see cref="DataProviderResponse"/> object or inherited classes 
		/// with default constructor.</typeparam>
		/// <param name="url">Url addres for request.</param>
		/// <param name="bodyObject">Body object for request.</param>
		/// <returns>Response data.</returns>
		/// <exception cref="DataProviderException">Exception thrown when request has network problems 
		/// or cloud endpoint returns response with error message.</exception>
		public T SendTokenizedPostRequest<T>(string url, object bodyObject)
			where T : SocialLeadGenRestProviderResponse, new() {
			return SendTokenizedRequest<T>(HttpRequestMethod.POST, url, bodyObject);
		}

		/// <summary>
		/// Sends <see cref="RestRequest"/> to <paramref name="url"/> with <paramref name="bodyObject"/>.
		/// Sets token to request and request body format <see cref="Method.POST"/>.
		/// </summary>
		/// <param name="url">Url addres for request.</param>
		/// <param name="bodyObject">Body object for request as string</param>
		/// <returns>Raw response from API.</returns>
		/// <exception cref="DataProviderException">Exception thrown when request has network problems 
		/// or cloud endpoint returns response with error message.</exception>
		public string SendTokenizedPostRequest(string url, string bodyObject) {
			IHttpResponse response = SendTokenizedRequest(HttpRequestMethod.POST, url, bodyObject);
			return response.Content;
		}

		#endregion

	}

	#endregion

}

