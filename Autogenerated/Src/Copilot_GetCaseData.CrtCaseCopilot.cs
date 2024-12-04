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

	#region Class: Copilot_GetCaseDataMethodsWrapper

	/// <exclude/>
	public class Copilot_GetCaseDataMethodsWrapper : ProcessModel
	{

		public Copilot_GetCaseDataMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("SetCaseScriptTaskExecute", SetCaseScriptTaskExecute);
		}

		#region Methods: Private

		private bool SetCaseScriptTaskExecute(ProcessExecutingContext context) {
			string caseNumber = Get<string>("CaseNumber");
			var caseEntity = UserConnection.EntitySchemaManager.GetEntityByName("Case", UserConnection);
			bool isFound = caseEntity.FetchFromDB(new Dictionary<string, object> {
				{ "Number", caseNumber }
			});
			Set("IsCaseFound", isFound);
			if (!isFound) {
				return true;
			}
			var compositeObject = new CompositeObject();
			IEnumerable<string> columnValueNames = caseEntity.GetColumnValueNames();
			foreach (string columnValueName in columnValueNames) {
				var columnValue = caseEntity.FindEntityColumnValue(columnValueName);
				if (columnValue.IsLoaded) {
					compositeObject[columnValueName] = columnValue.Value;
				}
			}
			Set("Case", compositeObject);
			return true;
		}

		#endregion

	}

	#endregion

}

