namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Collections.Specialized;
	using System.Linq;
	using Terrasoft.Common;
	using HttpUtility = System.Web.HttpUtility;

	#region Class: BulkEmailUriHelper

	/// <summary>
	/// Helper class for work with Uri.
	/// </summary>
	public static class BulkEmailUriHelper
	{

		#region Methods: Private

		private static NameValueCollection ParseQueryParameters(Uri uri) {
			return HttpUtility.ParseQueryString(uri.Query);
		}

		private static string QueryParametersToQueryString(Uri uri, NameValueCollection queryParameters) {
			var uriBuilder = new UriBuilder(uri) {
				Query = queryParameters.ToString()
			};
			return uriBuilder.Query + uriBuilder.Fragment;
		}

		private static string BuildUriString(Uri uri, NameValueCollection queryParameters) {
			string processedQuery = QueryParametersToQueryString(uri, queryParameters);
			var absolutePath = uri.Segments.Length > 1 ? uri.AbsolutePath : string.Empty;
			return uri.Scheme + Uri.SchemeDelimiter + uri.Host + absolutePath + Uri.UnescapeDataString(processedQuery);
		}

		private static string AppendQueryParametersToQueryString(Uri uri, NameValueCollection queryParameters) {
			var uriBuilder = new UriBuilder(uri);
			var parameters = queryParameters.ToString();
			var queryDelimiter = uri.Query.Length > 0 ? "&" : "?";
			return queryDelimiter + parameters + uriBuilder.Fragment;
		}

		private static string BuildUriWithAdditionalParameters(Uri uri, NameValueCollection queryParameters) {
			if (!queryParameters.HasKeys()) {
				return uri.OriginalString;
			}
			string processedQuery = AppendQueryParametersToQueryString(uri, queryParameters);
			string finalUri = uri.Fragment.IsNotEmpty() ? uri.OriginalString.Replace(uri.Fragment, string.Empty)
				: uri.OriginalString;
			return finalUri + Uri.UnescapeDataString(processedQuery);
		}

		private static void RemoveParameterIgnoreCase(NameValueCollection collection, string paramName) {
			foreach (string key in collection.AllKeys) {
				if (string.Equals(key, paramName, StringComparison.InvariantCultureIgnoreCase)) {
					collection.Remove(key);
				}
			}
		}

		private static NameValueCollection ToNameValueCollection(IEnumerable<KeyValuePair<string, string>> parameters) {
			var queryString = HttpUtility.ParseQueryString(string.Empty);
			foreach (var parameter in parameters) {
				queryString.Add(parameter.Key, parameter.Value);
			}
			return queryString;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Removes parameters from the uri.
		/// </summary>
		/// <param name="sourceUri">Uri.</param>
		/// <param name="parameters">Parameters to remove.</param>
		/// <returns>Uri.</returns>
		public static string RemoveParametersFromUri(string sourceUri, params string[] parameters) {
			Uri uri;
			if (!Uri.TryCreate(sourceUri, UriKind.Absolute, out uri)) {
				return sourceUri;
			}
			NameValueCollection queryParameters = ParseQueryParameters(uri);
			if (!queryParameters.HasKeys()) {
				return sourceUri;
			}
			foreach (string parameter in parameters) {
				RemoveParameterIgnoreCase(queryParameters, parameter);
			}
			return BuildUriString(uri, queryParameters);
		}

		/// <summary>
		/// Get parameters from uri.
		/// </summary>
		/// <param name="sourceUri">Uri.</param>
		/// <param name="keys">Parameters to remove.</param>
		/// <returns>Returns Uri parameters by keys. If keys array is empty - returns empty collection.</returns>
		public static Dictionary<string, string> GetParametersFromUri(string sourceUri, params string[] keys) {
			Uri uri;
			var resultCollection = new Dictionary<string, string>();
			if (!Uri.TryCreate(sourceUri.ToLower(), UriKind.Absolute, out uri)) {
				return resultCollection;
			}
			NameValueCollection queryParameters = ParseQueryParameters(uri);
			if (queryParameters.HasKeys()) {
				foreach (var key in keys) {
					var values = queryParameters.GetValues(key.ToLower());
					if (values?.Length > 0) {
						resultCollection.Add(key, values[0]);
					}
				}
			}
			return resultCollection;
		}

		/// <summary>
		/// Adds parameters to the uri.
		/// </summary>
		/// <param name="sourceUri">Uri.</param>
		/// <param name="parameters">Parameters to add.</param>
		/// <returns>Uri.</returns>
		public static string AddParametersToUri(string sourceUri, Dictionary<string, string> parameters) {
			if (parameters == null) {
				return sourceUri;
			}
			if (!Uri.TryCreate(sourceUri, UriKind.Absolute, out Uri uri)) {
				return sourceUri;
			}
			NameValueCollection queryParameters = ParseQueryParameters(uri);
			IEnumerable<KeyValuePair<string, string>> uniqueParameters = parameters.Where(p =>
				!queryParameters.AllKeys.Any(key => key != null && key.Equals(p.Key, StringComparison.OrdinalIgnoreCase)));
			NameValueCollection parametersToAdd = ToNameValueCollection(uniqueParameters);
			return BuildUriWithAdditionalParameters(uri, parametersToAdd);
		}

		#endregion

	}

	#endregion

}

