namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	#region Class: MailingResponse

	/// <summary> 
	/// Provides properties of the bulk email sending response.
	/// </summary>
	[DataContract]
	public class MailingResponse
	{

		#region Properties: Public

		/// <summary>
		/// Result of sending.
		/// </summary>
		[DataMember]
		public bool Success { get; set; }

		/// <summary>
		/// Bulk email status.
		/// </summary>
		[DataMember]
		public Guid StatusId { get; set; }

		/// <summary>
		/// Gets or sets exception.
		/// </summary>
		public Exception Exception { get; set; }

		public string RemindingLczStringCode { get; set; }

		[Obsolete]
		public IEnumerable<string> NotificationLcsStringCodes { get; set; }

		public IEnumerable<ValidationResultWrapper> ValidationResults { get; set; }

		#endregion

	}

	/// <summary>
	/// Contains information about validation
	/// </summary>
	public class ValidationResultWrapper {

		/// <summary>
		/// Validation message
		/// </summary>
		public string ValidationMessage { get; set; }

		/// <summary>
		/// Validation message
		/// </summary>
		public string ValidationCode {get;set;}
	}

	#endregion

}

