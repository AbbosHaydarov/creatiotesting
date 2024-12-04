namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Configuration.CES;

	#region Interface: IMailingCesApiProvider

	/// <summary>
	/// Provides interface to operate with ICESApi instance.
	/// </summary>
	public interface IMailingCesApiProvider: IMailingProvider
	{

		#region Properties: Public
		
		/// <summary>
		/// Instance of <see cref="BulkEmailEventLogger"/>, provides logging to BulkEmailEventLog table in DB.
		/// </summary>
		BulkEmailEventLogger BulkEmailEventLogger { get; }

		/// <summary>
		/// Gets or sets instance of <see cref="ICESApi"/>
		/// </summary>
		ICESApi ServiceApi { get;}
		
		#endregion

	}

	public interface IExtendedMessageValidator: IMailingProvider {

		/// <summary>
		/// Validates message.
		/// </summary>
		/// <param name="validationRequest">Validation request</param>
		/// <returns>Validation result.</returns>
		MailingValidationResponse ValidateMessageExtended(ValidationRequest validationRequest);
	}

	/// <summary>
	/// Validation request
	/// </summary>
	public class ValidationRequest {

		/// <summary>
		/// Message identifier
		/// </summary>
		public Guid[] MessageIds { get; set; }

		/// <summary>
		/// Recipients count
		/// </summary>
		public int RecipientsCount { get; set;}

		/// <summary>
		/// Sending type
		/// </summary>
		public SendingType SendingType { get; set; }
	}

	#endregion
}
