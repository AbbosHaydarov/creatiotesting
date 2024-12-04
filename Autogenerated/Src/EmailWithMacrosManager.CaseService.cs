namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Creatio.FeatureToggling;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.DB;
	using global::Common.Logging;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;

	#region Class: EmailWithMacrosManager


	public partial class EmailWithMacrosManager : EmailWithMacrosManagerBase
	{

		#region Methods: Protected

		/// <summary>
		/// Creates an activity and fills it with default values.
		/// </summary>
		/// <returns>Activity entity.</returns>
		protected override sealed Entity CreateActivityEntity() {
			return CreateActivity();
		}

		protected virtual Activity CreateActivity() {
			return base.CreateActivityEntity() as Activity;
		}
        
		/// <summary>
		/// Fills an <paramref name="activity"/> with given <paramref name="data"/>.
		/// </summary>
		/// <param name="activity">Activity entity.</param>
		/// <param name="data">Case data.</param>
		protected virtual void FillActivityWithCaseData(Activity activity, CaseData data) {
			base.FillEntityWithCaseData(activity, data);
		}

		protected virtual void PreProcess(Activity activity, Guid caseId, Guid tplId) {
			base.PreProcess(activity, caseId, tplId);
		}

		#endregion

	}

	#endregion

}
