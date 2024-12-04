using System.Runtime.Serialization;

namespace Terrasoft.Configuration
{
	/// <summary>
	/// Response for getting email designer URL.
	/// </summary>
	[DataContract]
	public class GetEmailPageUrlResponse: ConfigurationServiceResponse
	{
		/// <summary>
		/// Email designer URL.
		/// </summary>
		[DataMember(Name = "emailPageUrl")]
		public string EmailPageUrl { get; set; }
	}
}

