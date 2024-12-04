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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: AppFormToContactSyncProcessMethodsWrapper

	/// <exclude/>
	public class AppFormToContactSyncProcessMethodsWrapper : ProcessModel
	{

		public AppFormToContactSyncProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("AppFormToContactSyncScriptTaskExecute", AppFormToContactSyncScriptTaskExecute);
		}

		#region Methods: Private

		private bool AppFormToContactSyncScriptTaskExecute(ProcessExecutingContext context) {
			var appFormESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "AppForm");
			var idColumn = appFormESQ.AddColumn(appFormESQ.RootSchema.GetPrimaryColumnName());
			appFormESQ.Filters.Add(appFormESQ.CreateFilterWithParameters(FilterComparisonType.Equal,
				"FinApplication", Get<Guid>("FinApplicationId")));
			EntityCollection appFormEntities = appFormESQ.GetEntityCollection(UserConnection);
			if (appFormEntities.Count > 0) {
				foreach (Entity appForm in appFormEntities) {
					var appFormId = appForm.GetTypedColumnValue<Guid>(idColumn.Name);
					var appFormToContactHelper = new AppFormToContactHelper(UserConnection);
					appFormToContactHelper.SynchronizeContactByAppForm(appFormId);
				}
			}
			
			return true;
		}

		#endregion

	}

	#endregion

}

