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

	#region Class: Account_AddressFinanceEventsProcess

	public partial class Account_AddressFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool SynchronizeAddressOld() {
			var addressTypeId = Entity.GetTypedColumnValue<Guid>("AddressTypeId");
			if (addressTypeId.Equals(Guid.Empty)) {
				return true;
			}
			var accountId = Entity.PrimaryColumnValue;
			var address = Entity.GetTypedColumnValue<string>("Address");
			var cityId = Entity.GetTypedColumnValue<Guid>("CityId");
			var regionId = Entity.GetTypedColumnValue<Guid>("RegionId");
			var countryId = Entity.GetTypedColumnValue<Guid>("CountryId");
			var zip = Entity.GetTypedColumnValue<string>("Zip");
			var districtId = Entity.GetTypedColumnValue<Guid>("DistrictId");
			var street = Entity.GetTypedColumnValue<string>("Street");
			var building1 = Entity.GetTypedColumnValue<string>("Building1");
			var building2 = Entity.GetTypedColumnValue<string>("Building2");
			var aptOffice = Entity.GetTypedColumnValue<string>("AptOffice");
			
			var addressESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "AccountAddress");
			var createdOnColumn = addressESQ.AddColumn("CreatedOn");
			addressESQ.AddAllSchemaColumns();
			createdOnColumn.OrderByAsc();
			var accountFilter = addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Account", accountId);
			var addressTypeFilter = addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "AddressType", addressTypeId);
			addressESQ.Filters.Add(accountFilter);
			addressESQ.Filters.Add(addressTypeFilter);
			var options = new EntitySchemaQueryOptions {
				PageableDirection = PageableSelectDirection.First,
				PageableRowCount = 1,
				PageableConditionValues = new Dictionary<string, object>()
			};
			var addresses = addressESQ.GetEntityCollection(UserConnection, options);
			if (addresses.Count > 0) {
				var accountAddress = addresses[0];
				if (!accountAddress.GetTypedColumnValue<string>("Address").Equals(address)) {
					accountAddress.SetColumnValue("Address", address);
				}
				if (!accountAddress.GetTypedColumnValue<Guid>("CityId").Equals(cityId)) {
					if (cityId.Equals(Guid.Empty)) {
						accountAddress.SetColumnValue("CityId", null);
					} else {
						accountAddress.SetColumnValue("CityId", cityId);
					}
				}
				if (!accountAddress.GetTypedColumnValue<Guid>("RegionId").Equals(regionId)) {
					accountAddress.SetColumnValue("RegionId", regionId);
				}
				if (!accountAddress.GetTypedColumnValue<Guid>("CountryId").Equals(countryId)) {
					accountAddress.SetColumnValue("CountryId", countryId);
				}
				if (!accountAddress.GetTypedColumnValue<string>("Zip").Equals(zip)) {
					accountAddress.SetColumnValue("Zip", zip);
				}
				if (!accountAddress.GetTypedColumnValue<Guid>("DistrictId").Equals(districtId)) {
					if (districtId.Equals(Guid.Empty)) {
						accountAddress.SetColumnValue("DistrictId", null);
					} else {
						accountAddress.SetColumnValue("DistrictId", districtId);
					}
				}
				if (!accountAddress.GetTypedColumnValue<string>("Street").Equals(street)) {
					accountAddress.SetColumnValue("Street", street);
				}
				if (!accountAddress.GetTypedColumnValue<string>("Building1").Equals(building1)) {
					accountAddress.SetColumnValue("Building1", building1);
				}
				if (!accountAddress.GetTypedColumnValue<string>("Building2").Equals(building2)) {
					accountAddress.SetColumnValue("Building2", building2);
				}
				if (!accountAddress.GetTypedColumnValue<string>("AptOffice").Equals(aptOffice)) {
					accountAddress.SetColumnValue("AptOffice", aptOffice);
				}
				accountAddress.Save();
			} else {
				var schema = UserConnection.EntitySchemaManager.GetInstanceByName("AccountAddress");
				var accountEntity = schema.CreateEntity(UserConnection);
				accountEntity.SetDefColumnValues();
				accountEntity.SetColumnValue("AccountId", accountId);
				accountEntity.SetColumnValue("Primary", true);
				accountEntity.SetColumnValue("AddressTypeId", addressTypeId);
				accountEntity.SetColumnValue("Address", address);
				if (!cityId.Equals(Guid.Empty)) {
					accountEntity.SetColumnValue("CityId", cityId);
				}
				if (!regionId.Equals(Guid.Empty)) {
					accountEntity.SetColumnValue("RegionId", regionId);
				}
				if (!countryId.Equals(Guid.Empty)) {
					accountEntity.SetColumnValue("CountryId", countryId);
				}
				if (!districtId.Equals(Guid.Empty)) {
					accountEntity.SetColumnValue("DistrictId", districtId);
				}
				accountEntity.SetColumnValue("Zip", zip);
				accountEntity.SetColumnValue("Street", street);
				accountEntity.SetColumnValue("Building1", building1);
				accountEntity.SetColumnValue("Building2", building2);
				accountEntity.SetColumnValue("AptOffice", aptOffice);
				accountEntity.Save();
			}
			return true;
		}

		#endregion

	}

	#endregion

}

