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

	#region Class: Copilot_GetAccountColumnsMethodsWrapper

	/// <exclude/>
	public class Copilot_GetAccountColumnsMethodsWrapper : ProcessModel
	{

		public Copilot_GetAccountColumnsMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			var predictorService = new MLPredictorService();
			var result = predictorService.ScoreAndExplain(
				Get<Guid>("AccountSchemaUId"), 
				Get<Guid>("PredictiveScoreColumnUId"), 
				Get<Guid>("AccountIdForAnalysis")
			);
			var resultStr = Terrasoft.Common.Json.Json.Serialize(result);
			Set("ColumnsAffectingAccountScore", resultStr);
			return true;
		}

		#endregion

	}

	#endregion

}

