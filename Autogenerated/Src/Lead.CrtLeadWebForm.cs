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
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Lead_CrtLeadWebFormEventsProcess

	public partial class Lead_CrtLeadWebFormEventsProcess<TEntity>
	{

		#region Methods: Private
		
		private void SetColumnValue(string columnName, string value) {
			if (string.IsNullOrWhiteSpace(value)) {
				return;
			}
			Entity.SetColumnValue(columnName, value);
		}

		private void SetComputedColumnValue(string columnName, Guid computedValue, bool useDefaultLeadSourceValue) {
			if (computedValue == Guid.Empty) {
				return;
			}
			var value = Entity.IsColumnValueLoaded(columnName)
				? Entity.GetTypedColumnValue<Guid>(columnName) : Guid.Empty;
			if (useDefaultLeadSourceValue && value != Guid.Empty) {
				return;
			}
			Entity.SetColumnValue(columnName, computedValue);
		}

		private (ITouchSource, ITouchSourceProps) GetLeadSourceHelper(UserConnection userConnection) {
			var touchSource = ClassFactory.Get<ITouchSource>(
				new ConstructorArgument("userConnection", userConnection)
			);
			var touchSourceProps = touchSource is ITouchSourceProps ? (ITouchSourceProps)touchSource : default;
			return (touchSource, touchSourceProps);
		}

		#endregion

		#region Methods: Public

		public override void LeadInserting() {
			base.LeadInserting();
			string bpmHrefColumnName = "BpmHref";
			string bpmRefColumnName = "BpmRef";
			string bpmHref = Entity.IsColumnValueLoaded(bpmHrefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmHrefColumnName) : string.Empty;
			string bpmRef = Entity.IsColumnValueLoaded(bpmRefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmRefColumnName) : string.Empty;
			(ITouchSource touchSource, ITouchSourceProps touchSourceProps) lsh = GetLeadSourceHelper(UserConnection);
			lsh.touchSource.ComputeMediumAndSource(new Dictionary<string, string> {
				["bpmRef"] = bpmRef,
				["bpmHref"] = bpmHref,
			});
			SetColumnValue("UtmMediumStr", lsh.touchSource.BpmHrefParameters["utm_medium"]);
			SetColumnValue("UtmSourceStr", lsh.touchSource.BpmHrefParameters["utm_source"]);
			SetColumnValue("UtmCampaignStr", lsh.touchSource.BpmHrefParameters["utm_campaign"]);
			SetColumnValue("UtmTermStr", lsh.touchSource.BpmHrefParameters["utm_term"]);
			SetColumnValue("UtmContentStr", lsh.touchSource.BpmHrefParameters["utm_content"]);
			if (lsh.touchSourceProps == null) {
				return;
			}
			var useDefaultLeadSourceValue = UserConnection.GetIsFeatureEnabled("UseDefaultLeadSourceValue");
			SetComputedColumnValue("LeadMediumId", lsh.touchSourceProps.ResultLeadMediumId, useDefaultLeadSourceValue);
			SetComputedColumnValue("LeadSourceId", lsh.touchSourceProps.ResultLeadSourceId, useDefaultLeadSourceValue);
		}

		#endregion

	}

	#endregion

}

