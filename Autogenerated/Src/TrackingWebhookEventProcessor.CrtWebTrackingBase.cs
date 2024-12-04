namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using global::Common.Logging;

	#region Class: TrackingWebhookEventProcessor

	public class TrackingWebhookEventProcessor
	{

		#region Properties: Private

		private IEnumerable<BaseTrackingWebhookEventHandler> _handlersChain;

		private IEnumerable<BaseTrackingWebhookEventHandler> HandlersChain =>
			_handlersChain ?? (_handlersChain = Loader.GetHandlers());

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Instance of <see cref="TrackingWebhookEventHandlerLoader"/> to get all available tracking event handlers.
		/// </summary>
		private TrackingWebhookEventHandlerLoader _loader;
		protected virtual TrackingWebhookEventHandlerLoader Loader {
			get => _loader ?? (_loader = new TrackingWebhookEventHandlerLoader());
			set => _loader = value;
		}

		/// <summary>
		/// Logger.
		/// </summary>
		private ILog _logger;
		public ILog Logger {
			get => _logger ?? (_logger = LogManager.GetLogger("TouchPoints"));
			set => _logger = value;
		}

		#endregion


		#region Methods: Public

		/// <summary>
		/// Processes dispatched tracking webhook event by all available handlers.
		/// </summary>
		/// <param name="userConnection">Instance of the <see cref="UserConnection"/>.</param>
		/// <param name="message">Instance of the <see cref="TrackingImportByWebhookMessage"/></param>
		/// <returns></returns>
		public virtual bool Process(UserConnection userConnection, TrackingImportByWebhookMessage message) {
			var result = true;
			HandlersChain.ForEach(handler => {
				try {
					handler.Handle(userConnection, message);
				}
				catch (Exception ex) {
					Logger.Error(ex);
					result = false;
				}
			});
			return result;
		}

		#endregion

	}

	#endregion

}

