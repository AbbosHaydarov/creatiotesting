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

	#region Class: Copilot_GetLeadFeedMessagesMethodsWrapper

	/// <exclude/>
	public class Copilot_GetLeadFeedMessagesMethodsWrapper : ProcessModel
	{

		public Copilot_GetLeadFeedMessagesMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("RemoveHtmlTagsScriptTaskExecute", RemoveHtmlTagsScriptTaskExecute);
		}

		#region Methods: Private

		private bool RemoveHtmlTagsScriptTaskExecute(ProcessExecutingContext context) {
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

