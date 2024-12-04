namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;

	#region Class: BaseTrackingWebhookEventHandler

	/// <summary>
	/// Handles tracking webhook event.
	/// </summary>
	public abstract class BaseTrackingWebhookEventHandler {

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseTrackingWebhookEventHandler"/> class.
		/// </summary>
		public BaseTrackingWebhookEventHandler() {}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Collection of the supported TouchEventTracking ids.
		/// If empty - handles all tracking webhooks.
		/// </summary>
		protected virtual IEnumerable<Guid> SupportedTrackings { get; set; } = new List<Guid>();

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Implement it with logic to handle tracking webhook event.
		/// </summary>
		/// <param name="userConnection">Instance of the <see cref="UserConnection"/>.</param>
		/// <param name="message">Instance of the <see cref="TrackingImportByWebhookMessage"/>.</param>
		protected abstract void InternalHandle(UserConnection userConnection, TrackingImportByWebhookMessage message);

		/// <summary>
		/// Returns True when current tracking system is active.
		/// </summary>
		/// <param name="userConnection">Instance of the <see cref="UserConnection"/>.</param>
		protected virtual bool IsConnected(UserConnection userConnection) => true;

		/// <summary>
		/// Returns True when current handler can handle webhook event for current tracking system.
		/// </summary>
		/// <param name="userConnection">Instance of the <see cref="UserConnection"/>.</param>
		/// <param name="trakingSystemId">Id of the triggered event tracking system.</param>
		/// <returns><see cref="Boolean"/> result.</returns>
		protected virtual bool CanProcess(UserConnection userConnection, Guid trakingSystemId) {
			return IsConnected(userConnection) && CanProcess(trakingSystemId);
		}

		/// <summary>
		/// Returns True when current handler can handle webhook event for current tracking system.
		/// </summary>
		/// <param name="trakingSystemId">Id of the triggered event tracking system.</param>
		/// <returns><see cref="Boolean"/> result.</returns>
		protected virtual bool CanProcess(Guid trakingSystemId) {
			if (SupportedTrackings.Any()) {
				return SupportedTrackings.Contains(trakingSystemId);
			}
			return true;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles tracking webhook event.
		/// </summary>
		/// <param name="userConnection">Instance of the <see cref="UserConnection"/>.</param>
		/// <param name="message">Instance of the <see cref="TrackingImportByWebhookMessage"/>.</param>
		public virtual void Handle(UserConnection userConnection, TrackingImportByWebhookMessage message) {
			if (CanProcess(userConnection, message.TrackingId)) {
				InternalHandle(userConnection, message);
			}
		}

		#endregion

	}

	#endregion

}

