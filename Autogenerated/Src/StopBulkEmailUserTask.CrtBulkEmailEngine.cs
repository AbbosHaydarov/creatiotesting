namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Net.Http;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: StopBulkEmailUserTask

	/// <exclude/>
	public partial class StopBulkEmailUserTask
	{

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			IsSuccess = false;
			ValidationCodes = string.Empty;
			var mailingProviderBuilder = ClassFactory.Get<IMailingProviderBuilder>();
			IMailingProvider mailingProvider = mailingProviderBuilder.Build();
			if (mailingProvider.PingProvider()) {
				var response = mailingProvider.BreakMailing(CrtBulkEmailIdentifier);
				IsSuccess = response.Success;
				return true;
			}
			ValidationCodes = "Ping";
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

