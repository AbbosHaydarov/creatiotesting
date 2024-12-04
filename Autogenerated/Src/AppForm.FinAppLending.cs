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

	#region Class: AppForm_FinAppLendingEventsProcess

	public partial class AppForm_FinAppLendingEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual void FillSgmOrNameField() {
			IEnumerable<EntityColumnValue> changedColumns = Entity.GetChangedColumnValues();
			if (NamePartColumnChanged(changedColumns, "Participant")) {
				SetSgm(Entity as AppForm);
			} else if (
				NamePartColumnChanged(changedColumns, "Surname") ||
				NamePartColumnChanged(changedColumns, "GivenName") ||
				NamePartColumnChanged(changedColumns, "MiddleName")) {
					SetName(Entity as AppForm);
			}
		}

		public virtual bool NamePartColumnChanged(IEnumerable<EntityColumnValue> changedColumns, string namePart) {
			return changedColumns.Any(column => {
				return 
					column.Name == namePart && 
					column.Value != null &&
					!string.IsNullOrEmpty(column.Value.ToString()) &&
					!column.Value.Equals(column.OldValue);
			});
		}

		public virtual void SetSgm(AppForm appForm) {
			if (appForm == null) {
				return;
			}
			IContactFieldConverter converter = GetContactConverter();
			if (converter == null) {
				return;
			}
			ContactSgm contactSgm = converter.GetContactSgm(appForm.Participant);
			appForm.Surname = contactSgm.Surname;
			appForm.GivenName = contactSgm.GivenName;
			appForm.MiddleName = contactSgm.MiddleName;
		}

		public virtual void SetName(AppForm appForm) {
			if (appForm == null) {
				return;
			}
			IContactFieldConverter converter = GetContactConverter();
			if (converter == null) {
				return;
			}
			appForm.Participant = converter.GetContactName(new ContactSgm {
				Surname = appForm.Surname,
				GivenName = appForm.GivenName,
				MiddleName = appForm.MiddleName
			});
		}

		public virtual IContactFieldConverter GetContactConverter() {
			IContactFieldConverter converter = ContactUtilities.GetContactConverter(UserConnection);
			return converter;
		}

		public virtual void UpdateFinApplicationMainContact() {
			var participantRole = Entity.GetTypedColumnValue<Guid>("ParticipantRoleId");
			var mainParticipantRole = Terrasoft.Core.Configuration.SysSettings.GetValue<Guid>(UserConnection, "MainParticipantRole", Guid.Empty);
			if (participantRole.Equals(mainParticipantRole)) {
				var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
				var finApplicationId = Entity.GetTypedColumnValue<Guid>("FinApplicationId");
				var contactQueryParam = new QueryParameter("ContactId", contactId, "Guid");
				if (contactId.Equals(Guid.Empty)) {
					contactQueryParam = new QueryParameter("ContactId", null, "Guid");
				}
				var finApplicationUpdate = new Update(UserConnection, "FinApplication")
							.Set("ContactId", contactQueryParam)
							.Where("Id").IsEqual(Column.Parameter(finApplicationId)) as Update;
				finApplicationUpdate.Execute();
			}
		}

		public virtual void OnAppFormSaving() {
			FillSgmOrNameField();
			UpdateFinApplicationMainContact();
		}

		#endregion

	}

	#endregion

}

