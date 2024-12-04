using System.Runtime.Serialization;

namespace Terrasoft.Configuration
{
	/// <summary>
	/// Request for getting email designer URL.
	/// </summary>
	[DataContract]
	public class GetEmailPageUrlRequest
	{
		/// <summary>
		/// Email designer type.
		/// </summary>
		[DataMember(Name = "designerTypeId")]
		public string DesignerTypeId { get; set; }

		/// <summary>
		/// Bulk email identifier.
		/// </summary>
		[DataMember(Name = "bulkEmailId")]
		public string BulkEmailId { get; set; }

		/// <summary>
		/// Flag that indicates whether email is bulk.
		/// </summary>
		[DataMember(Name = "isBulkEmail")]
		public bool IsBulkEmail { get; set; }
	}
}
