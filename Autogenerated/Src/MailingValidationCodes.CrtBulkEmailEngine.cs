namespace Terrasoft.Configuration
{

	#region Class: MailingValidationCodes

	/// <summary>
	/// Mailing validation codes
	/// </summary>
	public static class MailingValidationCodes
	{
		/// <summary>
		/// Represents a validation code used to ensure the audience size.
		/// </summary>
		public const string AudienceSize = "AudienceSize";

		/// <summary>
		/// Represents a validation code used to ensure if the email sending limit has been reached.
		/// </summary>
		public const string EmailSendingLimit = "EmailSendingLimit";

		/// <summary>
		/// Represents a validation code used to validate the presence and correctness of email headers.
		/// </summary>
		public const string Headers = "Headers";

		/// <summary>
		/// A validation code for verifying the email provider's.
		/// </summary>
		public const string Provider = "Provider";

		/// <summary>
		/// A validation code for sender's email.
		/// </summary>
		public const string Sender = "Sender";

		/// <summary>
		/// A validation code for default esp email.
		/// </summary>
		public const string DefaultESPEmail = "DefaultESPEmail";

		/// <summary>
		/// A validation code for confirming the existence of an email template.
		/// </summary>
		public const string TemplateExistence = "TemplateExistence";

		/// <summary>
		/// Represents a validation code used to ensure the email template size adheres to specified limits.
		/// </summary>
		public const string TemplateSize = "TemplateSize";
	}

	#endregion

}

