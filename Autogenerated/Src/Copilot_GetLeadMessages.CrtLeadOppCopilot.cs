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

	#region Class: Copilot_GetLeadMessagesMethodsWrapper

	/// <exclude/>
	public class Copilot_GetLeadMessagesMethodsWrapper : ProcessModel
	{

		public Copilot_GetLeadMessagesMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("RemoveEmailsHtmlScriptTaskExecute", RemoveEmailsHtmlScriptTaskExecute);
			AddScriptTaskMethod("RemoveChatHtmlScriptTaskExecute", RemoveChatHtmlScriptTaskExecute);
		}

		#region Methods: Private

		private bool RemoveEmailsHtmlScriptTaskExecute(ProcessExecutingContext context) {
			var readActivities = Get<CompositeObjectList<CompositeObject>>("ReadActivities.ResultCompositeObjectList");
			foreach (CompositeObject readActivityObject in readActivities) {
				var body = readActivityObject["Body"].ToString();
				readActivityObject.Remove("Body");
				readActivityObject["Body"] = StringUtilities.ConvertHtmlToPlainText(body);
			}
			Set("EmailMessages", readActivities);
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

		#endregion

	}

	#endregion

}

