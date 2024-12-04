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

	#region Class: AccountAddress_AddressFinanceEventsProcess

	public partial class AccountAddress_AddressFinanceEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual bool SynchronizeAccountOld() {
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			var addressESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "AccountAddress");
			var idColumn = addressESQ.AddColumn(addressESQ.RootSchema.GetPrimaryColumnName()); 
			addressESQ.AddColumn("CreatedOn").OrderByAsc();
			addressESQ.Filters.Add(addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Account", accountId));
			var options = new EntitySchemaQueryOptions {
				PageableDirection = PageableSelectDirection.First,
				PageableRowCount = 1,
				PageableConditionValues = new Dictionary<string, object>()
			};
			var addresses = addressESQ.GetEntityCollection(UserConnection, options);
			if (addresses.Count > 0) {
				if (addresses[0].GetTypedColumnValue<Guid>(idColumn.Name).Equals(Entity.PrimaryColumnValue) &&
						!Entity.GetTypedColumnValue<bool>("Primary")) {
					Entity.SetColumnValue("Primary", true);
					Entity.Save();
				}
			}
			if (!Entity.GetTypedColumnValue<bool>("Primary")) {
				return true;
			}
			var accountESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Account");
			accountESQ.AddAllSchemaColumns();
			var account = accountESQ.GetEntity(UserConnection, accountId);
			if (account != null) {
				var entityChanged = false;
				var district = Entity.GetTypedColumnValue<Guid>("DistrictId");
				var street = Entity.GetTypedColumnValue<string>("Street");
				var building1 = Entity.GetTypedColumnValue<string>("Building1");
				var building2 = Entity.GetTypedColumnValue<string>("Building2");
				var aptOffice = Entity.GetTypedColumnValue<string>("AptOffice");
				
				if (!account.GetTypedColumnValue<Guid>("DistrictId").Equals(district)) {
					if (district.Equals(Guid.Empty)) {
						account.SetColumnValue("DistrictId", null);
					} else {
						account.SetColumnValue("DistrictId", district);
					}
					entityChanged = true;
				}
				
				if (!account.GetTypedColumnValue<string>("Street").Equals(street)) {
					account.SetColumnValue("Street", street);
					entityChanged = true;
				}
				
				if (!account.GetTypedColumnValue<string>("Building1").Equals(building1)) {
					account.SetColumnValue("Building1", building1);
					entityChanged = true;
				}
				
				if (!account.GetTypedColumnValue<string>("Building2").Equals(building2)) {
					account.SetColumnValue("Building2", building2);
					entityChanged = true;
				}
				
				if (!account.GetTypedColumnValue<string>("AptOffice").Equals(aptOffice)) {
					account.SetColumnValue("AptOffice", aptOffice);
					entityChanged = true;
				}
				
				if (entityChanged) {
					account.SetColumnValue("GPSN", string.Empty);
					account.SetColumnValue("GPSE", string.Empty);
					account.Save();
				}
			}
			return true;
		}

		#endregion

	}

	#endregion

}

