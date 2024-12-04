namespace Terrasoft.Configuration
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

	/// <summary>
	/// Response, which contains information about validation
	/// </summary>
	[DataContract]
	public class MailingValidationResponse: ConfigurationServiceResponse {
		
		/// <summary>
		/// Validation results
		/// </summary>
		public IEnumerable<MailingValidationResult> MailingValidationResults { get; set; }
	}
}
