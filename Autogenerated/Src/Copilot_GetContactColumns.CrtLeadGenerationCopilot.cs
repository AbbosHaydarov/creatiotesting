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

	#region Class: Copilot_GetContactColumnsMethodsWrapper

	/// <exclude/>
	public class Copilot_GetContactColumnsMethodsWrapper : ProcessModel
	{

		public Copilot_GetContactColumnsMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			var predictorService = new MLPredictorService();
			var result = predictorService.ScoreAndExplain(
				Get<Guid>("ContactSchemaUId"), 
				Get<Guid>("PredictiveScoreColumnUId"), 
				Get<Guid>("ContactIdForAnalysis")
			);
			var resultStr = Terrasoft.Common.Json.Json.Serialize(result);
			Set("ColumnsAffectingContactScore", resultStr);
			return true;
		}

		#endregion

	}

	#endregion

}

