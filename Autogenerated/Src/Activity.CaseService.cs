namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.Packages.Case;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_CaseServiceEventsProcess

	[EntityEventListenerRegistrationCancellation(EntityEventListenerName = "CaseServiceActivityEntityEventListener")]
	public partial class Activity_CaseServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		public override bool OnActivitySaving(ProcessExecutingContext context) {
			var isBaseSavingSuccess = base.OnActivitySaving(context);
			if (isBaseSavingSuccess && Entity.GetTypedColumnValue<Guid>("TypeId") == ActivityConsts.EmailTypeUId && UserConnection.GetIsFeatureEnabled("DisableEmbeddedCaseMessageHistoryListener")) {
				Guid caseValue = Entity.GetTypedColumnValue<Guid>("CaseId");
				Guid caseOldValue = Entity.GetTypedOldColumnValue<Guid>("CaseId");
				if (caseValue != Guid.Empty && caseValue != caseOldValue) {
					var notifier = new EmailMessageNotifier(this.Entity, UserConnection);
					var listener = new CaseMessageListener(UserConnection);
					listener.Update(notifier);
				}
			}
			return isBaseSavingSuccess;
		}

		public virtual bool UseCategoryFilter() {
			return CaseServiceActivityEventHandlingUtilities.UseCategoryFilter(UserConnection);
		}

		public virtual bool IsRequiredFieldsValid(Guid caseId) {
			return CaseServiceActivityEventHandlingUtilities.IsRequiredFieldsValid(UserConnection, caseId);
		}

		public virtual string JoinRecipients(string recipients, string recipient) {
			return CaseServiceActivityEventHandlingUtilities.JoinRecipients(recipients, recipient);
		}

		public virtual string GetRecipients(Guid activityId) {
			return CaseServiceActivityEventHandlingUtilities.GetRecipients(UserConnection, activityId, JoinRecipients);
		}

		public virtual void SetCaseCategory(Guid caseId, Guid activityId) {
			CaseServiceActivityEventHandlingUtilities.SetCaseCategory(UserConnection, caseId, activityId,
				JoinRecipients, GetRecipients);
		}

		#endregion

	}

	#endregion

}

