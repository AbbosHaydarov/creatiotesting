namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: SyncWithTrackingSystem

	/// <exclude/>
	public partial class SyncWithTrackingSystem
	{

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			foreach (var compObject in MatomoIdentifiers) {
				var userConnection = Get<UserConnection>("UserConnection");
				compObject.TryGetValue("ContactId", out Guid contactId);
				compObject.TryGetValue("TrackingId", out Guid trackingId);
				compObject.TryGetValue("TrackingUserId", out string visitorId);
				compObject.TryGetValue("LandingPageUrl", out string landingPageUrl);
				var message = new TrackingImportByWebhookMessage(contactId, visitorId, landingPageUrl) {
					TrackingId = trackingId
				};
				var eventProcessor = ClassFactory.Get<TrackingWebhookEventProcessor>();
				eventProcessor.Process(userConnection, message);
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		#endregion

	}

	#endregion

}

