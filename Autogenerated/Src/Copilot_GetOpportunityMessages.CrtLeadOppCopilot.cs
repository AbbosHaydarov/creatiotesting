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

	#region Class: Copilot_GetOpportunityMessagesMethodsWrapper

	/// <exclude/>
	public class Copilot_GetOpportunityMessagesMethodsWrapper : ProcessModel
	{

		public Copilot_GetOpportunityMessagesMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("RemoveEmailsHtmlScriptTaskExecute", RemoveEmailsHtmlScriptTaskExecute);
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

		#endregion

	}

	#endregion

}

