namespace Terrasoft.Configuration
{
	using System;
	using Newtonsoft.Json;

	#region Class: TrackingImportByWebhookMessage

	/// <summary>
	/// Class to represent data import by form submit action message.
	/// </summary>
	public class TrackingImportByWebhookMessage : TouchQueueMessage
	{

		#region Constructors: Public

		/// <summary>
		/// Constructor for <see cref="TrackingImportByWebhookMessage"/>.
		/// </summary>
		/// <param name="contactId">Contact unique identifier from Creatio.</param>
		/// <param name="trackingUserId">Tracking system user id.</param>
		/// <param name="pageUrl">Webhook landing page url.</param>
		public TrackingImportByWebhookMessage(Guid contactId, string trackingUserId, string pageUrl) {
			Type = TouchQueueMessageType.Import;
			ContactId = contactId;
			TrackingUserId = trackingUserId;
			PageUrl = pageUrl;
			RequiresDeduplication = true;
		}

		/// <summary>
		/// Constructor for <see cref="TrackingImportByWebhookMessage"/>.
		/// </summary>
		public TrackingImportByWebhookMessage() {
			Type = TouchQueueMessageType.Import;
			RequiresDeduplication = true;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Contains contact id or <see cref="Guid.Empty"/>.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Guid ContactId { get; set; }

		// <summary>
		/// Contains tracking system id or <see cref="Guid.Empty"/>.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Guid TrackingId { get; set; }

		/// <summary>
		/// Contains tracking user id.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string TrackingUserId { get; set; }

		/// <summary>
		/// Contains landing page Url.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string PageUrl { get; set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Defines priority of current message. Messages with highest priority will be processed first.
		/// </summary>
		public override int GetPriority() => 12;

		/// <summary>
		/// Defines number of retries in case of crash or error.
		/// </summary>
		/// <returns>Number of retries.</returns>
		public override int GetMaxRetryCount() => 2;

		/// <inheritdoc />
		public override Guid GetTracking() => TrackingId;

		#endregion

	}
	#endregion

}

