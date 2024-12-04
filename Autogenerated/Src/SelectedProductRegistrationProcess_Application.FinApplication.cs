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

	#region Class: SelectedProductRegistrationProcess_ApplicationMethodsWrapper

	/// <exclude/>
	public class SelectedProductRegistrationProcess_ApplicationMethodsWrapper : ProcessModel
	{

		public SelectedProductRegistrationProcess_ApplicationMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
			AddScriptTaskMethod("ScriptTask2Execute", ScriptTask2Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			var opportunities = Get<ICompositeObjectList<ICompositeObject>>("OpportunityConditions");
			foreach (var opportunity in opportunities) {
				if (opportunity.TryGetValue<Guid>("opportunityConditionId", out var opportunityId) && opportunityId.IsNotEmpty()) {
					Set<Guid>("OpportunityConditionId2", opportunityId);
					break;
				}
			}
			return true;
		}

		private bool ScriptTask2Execute(ProcessExecutingContext context) {
			var selectedSpecifications = Get<ICompositeObjectList<ICompositeObject>>("SelectedSpecifications");
			Set<bool>("DoesSelectedParametersExist", selectedSpecifications.IsNotEmpty());
			return true;
		}

		#endregion

	}

	#endregion

}

