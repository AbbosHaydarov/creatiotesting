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

	#region Class: Copilot_GetCaseExternalMessagesMethodsWrapper

	/// <exclude/>
	public class Copilot_GetCaseExternalMessagesMethodsWrapper : ProcessModel
	{

		public Copilot_GetCaseExternalMessagesMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("RemoveEmailHtmlScriptTaskExecute", RemoveEmailHtmlScriptTaskExecute);
			AddScriptTaskMethod("RemovePortalHtmlScriptTaskExecute", RemovePortalHtmlScriptTaskExecute);
			AddScriptTaskMethod("RemoveChatHtmlScriptTaskExecute", RemoveChatHtmlScriptTaskExecute);
			AddScriptTaskMethod("RemoveFeedHtmlScriptTaskExecute", RemoveFeedHtmlScriptTaskExecute);
			AddScriptTaskMethod("CheckObjectExistenceExecute", CheckObjectExistenceExecute);
		}

		#region Methods: Private

		private bool RemoveEmailHtmlScriptTaskExecute(ProcessExecutingContext context) {
			var readActivities = Get<CompositeObjectList<CompositeObject>>("ReadActivities.ResultCompositeObjectList");
			foreach (CompositeObject readActivityObject in readActivities) {
				var body = readActivityObject["Body"].ToString();
				readActivityObject.Remove("Body");
				readActivityObject["Body"] = StringUtilities.ConvertHtmlToPlainText(body);
			}
			Set("EmailMessages", readActivities);
			return true;
		}

		private bool RemovePortalHtmlScriptTaskExecute(ProcessExecutingContext context) {
			var readPortalMessages = Get<CompositeObjectList<CompositeObject>>("ReadPortalMessages.ResultCompositeObjectList");
			foreach (CompositeObject readMessageObject in readPortalMessages) {
				var body = readMessageObject["Message"].ToString();
				readMessageObject.Remove("Message");
				readMessageObject["Message"] = StringUtilities.ConvertHtmlToPlainText(body);
			}
			Set("ExternalFeedMessages", readPortalMessages);
			return true;
		}

		private bool RemoveChatHtmlScriptTaskExecute(ProcessExecutingContext context) {
			var readChatMessages = Get<CompositeObjectList<CompositeObject>>("ReadChatlMessages.ResultCompositeObjectList");
			foreach (CompositeObject readMessageObject in readChatMessages) {
				var body = readMessageObject["Message"].ToString();
				readMessageObject.Remove("Message");
				readMessageObject["Message"] = StringUtilities.ConvertHtmlToPlainText(body);
			}
			Set("ChatMessages", readChatMessages);
			return true;
		}

		private bool RemoveFeedHtmlScriptTaskExecute(ProcessExecutingContext context) {
			var readFeedMessages = Get<CompositeObjectList<CompositeObject>>("ReadExternalFeedMessages.ResultCompositeObjectList");
			foreach (CompositeObject readMessageObject in readFeedMessages) {
				var body = readMessageObject["Message"].ToString();
				readMessageObject.Remove("Message");
				readMessageObject["Message"] = StringUtilities.ConvertHtmlToPlainText(body);
			}
			Set("ExternalFeedMessages", readFeedMessages);
			return true;
		}

		private bool CheckObjectExistenceExecute(ProcessExecutingContext context) {
			if (UserConnection.EntitySchemaManager.FindItemByName("PortalMessage") != null) Set<bool>("PortalMessageTableExists", true);
			return true;
		}

		#endregion

	}

	#endregion

}

