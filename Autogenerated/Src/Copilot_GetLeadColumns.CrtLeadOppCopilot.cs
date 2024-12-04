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
	using Terrasoft.Configuration.ML;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: Copilot_GetLeadColumnsMethodsWrapper

	/// <exclude/>
	public class Copilot_GetLeadColumnsMethodsWrapper : ProcessModel
	{

		public Copilot_GetLeadColumnsMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScoreAndExplainScriptTaskExecute", ScoreAndExplainScriptTaskExecute);
		}

		#region Methods: Private

		private bool ScoreAndExplainScriptTaskExecute(ProcessExecutingContext context) {
			var predictorService = new MLPredictorService();
			var result = predictorService.ScoreAndExplain(
				Get<Guid>("LeadSchemaUId"), 
				Get<Guid>("PredictiveScoreColumnUId"), 
				Get<Guid>("LeadIdForAnalysis")
			);
			var resultStr = Terrasoft.Common.Json.Json.Serialize(result);
			Set("ColumnsAffectingLeadScore", resultStr);
			return true;
		}

		#endregion

	}

	#endregion

}

