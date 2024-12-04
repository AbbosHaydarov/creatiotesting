namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: Copilot_GetCaseFeedMessagesMethodsWrapper

	/// <exclude/>
	public class Copilot_GetCaseFeedMessagesMethodsWrapper : ProcessModel
	{

		public Copilot_GetCaseFeedMessagesMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("RemoveHtmlScriptTaskExecute", RemoveHtmlScriptTaskExecute);
		}

		#region Methods: Private

		private bool RemoveHtmlScriptTaskExecute(ProcessExecutingContext context) {
			var readFeeds = Get<CompositeObjectList<CompositeObject>>("ReadFeeds.ResultCompositeObjectList");
			foreach (CompositeObject readFeedObject in readFeeds) {
				var message = readFeedObject["Message"].ToString();
				readFeedObject.Remove("Message");
				readFeedObject["Message"] = StringUtilities.ConvertHtmlToPlainText(message);
			}
			Set("FeedMessages", readFeeds);
			return true;
		}

		#endregion

	}

	#endregion

}

