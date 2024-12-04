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
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: FormSubmit_CrtTouchPointEventsProcess

	[EntityEventListenerRegistrationCancellation(EntityEventListenerName = "TouchPointFormSubmitEventListener")]
	public partial class FormSubmit_CrtTouchPointEventsProcess<TEntity>
	{

		#region Methods: Private

		private string GetReferrer(Entity entity) {
			const string referrerColumnName = "Referrer";
			string referrer = entity.IsColumnValueLoaded(referrerColumnName)
				? entity.GetTypedColumnValue<string>(referrerColumnName)
				: string.Empty;
			return referrer;
		}

		private string GetLandingPageUrl(Entity entity) {
			const string landingPageUrlColumnName = "LandingPageURL";
			string landingPageUrl = entity.IsColumnValueLoaded(landingPageUrlColumnName)
				? entity.GetTypedColumnValue<string>(landingPageUrlColumnName)
				: string.Empty;
			return landingPageUrl;
		}

		private (ITouchSource, ITouchSourceProps) GetLeadSourceHelper(UserConnection userConnection) {
			var touchSource = ClassFactory.Get<ITouchSource>(
				new ConstructorArgument("userConnection", userConnection)
			);
			var touchSourceProps = touchSource is ITouchSourceProps ? (ITouchSourceProps)touchSource : default;
			return (touchSource, touchSourceProps);
		}

		private void SetColumnValue(Entity entity, string columnName, string value) {
			if (string.IsNullOrWhiteSpace(value)
				|| !string.IsNullOrEmpty(entity.GetColumnValue(columnName).ToString())) {
				return;
			}
			entity.SetColumnValue(columnName, value);
		}

		private void SetComputedColumnValue(Entity entity, string columnName, Guid computedValue,
				bool useDefaultLeadSourceValue) {
			if (computedValue == Guid.Empty) {
				return;
			}
			var value = entity.IsColumnValueLoaded(columnName)
				? entity.GetTypedColumnValue<Guid>(columnName)
				: Guid.Empty;
			if (useDefaultLeadSourceValue && value != Guid.Empty) {
				return;
			}
			entity.SetColumnValue(columnName, computedValue);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles the before inserting action.
		/// </summary>
		public virtual void FormSubmitInserting() {
			var entity = Entity;
			var userConnection = entity.UserConnection;
			(ITouchSource touchSource, ITouchSourceProps touchSourceProps) lsh = GetLeadSourceHelper(userConnection);
			lsh.touchSource.ComputeMediumAndSource(new Dictionary<string, string> {
				["bpmRef"] = GetReferrer(entity),
				["bpmHref"] = GetLandingPageUrl(entity),
			});
			bool useDefaultLeadSourceValue = userConnection.GetIsFeatureEnabled("UseDefaultLeadSourceValue");
			SetComputedColumnValue(entity, "ChannelId", lsh.touchSourceProps.ResultLeadMediumId, useDefaultLeadSourceValue);
			SetComputedColumnValue(entity, "SourceId", lsh.touchSourceProps.ResultLeadSourceId, useDefaultLeadSourceValue);
			SetColumnValue(entity, "UtmMediumStr", lsh.touchSource.BpmHrefParameters["utm_medium"]);
			SetColumnValue(entity, "UtmSourceStr", lsh.touchSource.BpmHrefParameters["utm_source"]);
			SetColumnValue(entity, "UtmCampaignStr", lsh.touchSource.BpmHrefParameters["utm_campaign"]);
			SetColumnValue(entity, "UtmTermStr", lsh.touchSource.BpmHrefParameters["utm_term"]);
			SetColumnValue(entity, "UtmContentStr", lsh.touchSource.BpmHrefParameters["utm_content"]);
		}

		#endregion

	}

	#endregion

}

