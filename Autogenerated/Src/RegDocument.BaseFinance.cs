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
	using Terrasoft.Configuration;
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

	#region Class: RegDocument_BaseFinanceEventsProcess

	public partial class RegDocument_BaseFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateContactPassport() {
			if (Entity.IsPrimary) {
				string series = Entity.GetTypedColumnValue<string>("Series");
				string number = Entity.GetTypedColumnValue<string>("Number");
				Guid contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
				string separator = (series != string.Empty && number != string.Empty) ? " " : "";
				string passport = series + separator + number;
				EntitySchema contactSchema = UserConnection.EntitySchemaManager.FindInstanceByName("Contact");
				Entity contact = contactSchema.CreateEntity(UserConnection);
				if (contact.FetchFromDB(contactId)) {
					contact.SetColumnValue("Passport", passport);
					contact.Save();
				}
			}
		}

		public virtual void ClearContactPassport() {
			Guid contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			EntitySchema contactSchema = UserConnection.EntitySchemaManager.FindInstanceByName("Contact");
			Entity contact = contactSchema.CreateEntity(UserConnection);
			if (contact.FetchFromDB(contactId)) {
				contact.SetColumnValue("Passport", string.Empty);
				contact.Save();
			}
		}

		public virtual void OnSaved() {
			UpdateIsPrimaryRegDocument();
			UpdateContactPassport();
		}

		public virtual void OnDeleted() {
			if (Entity.IsPrimary) {
				ClearContactPassport();
			}
		}

		public virtual void UpdateIsPrimaryRegDocument() {
			if (Entity.IsPrimary) {
				Guid contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
				var update = new Update(UserConnection, "RegDocument")
					.Set("IsPrimary", Column.Parameter(false))
					.Where("ContactId").IsEqual(Column.Parameter(contactId))
					.And("IsPrimary").IsEqual(Column.Parameter(true))
					.And("Id").IsNotEqual(Column.Parameter(Entity.Id)) as Update;
				update.Execute();
			}
		}

		public virtual void OnSaving() {
			var primaryRegDoc = false;
			var primaryRegDocSelect = new Select(UserConnection).
				Column(("IsPrimary")).
				From("RegDocument").
				Where("Id").IsEqual(Column.Parameter(Entity.Id)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = primaryRegDocSelect.ExecuteReader(dbExecutor)) {
					if (dr.Read()) {
						primaryRegDoc = UserConnection.DBTypeConverter.DBValueToBool(dr["IsPrimary"]);
					}
				}
			}
			if (primaryRegDoc) {
				foreach(var column in Entity.GetChangedColumnValues()) { 
					if (column.Name == "IsPrimary" && !Convert.ToBoolean(column.Value)) {
						ClearContactPassport();
					}
				}
			}
		}

		#endregion

	}

	#endregion
}
