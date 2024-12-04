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
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_AddressFinanceEventsProcess

	public partial class Contact_AddressFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool SynchronizeContactAddressOld() {
			var addressTypeId = Entity.GetTypedColumnValue<Guid>("AddressTypeId");
			var address = Entity.GetTypedColumnValue<string>("Address");
			if (addressTypeId.Equals(Guid.Empty)) {
				return true;
			}
			var contactId = Entity.PrimaryColumnValue;
			var cityId = Entity.GetTypedColumnValue<Guid>("CityId");
			var regionId = Entity.GetTypedColumnValue<Guid>("RegionId");
			var countryId = Entity.GetTypedColumnValue<Guid>("CountryId");
			var zip = Entity.GetTypedColumnValue<string>("Zip");
			var districtId = Entity.GetTypedColumnValue<Guid>("DistrictId");
			var street = Entity.GetTypedColumnValue<string>("Street");
			var building1 = Entity.GetTypedColumnValue<string>("Building1");
			var building2 = Entity.GetTypedColumnValue<string>("Building2");
			var aptOffice = Entity.GetTypedColumnValue<string>("AptOffice");
			
			var addressESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ContactAddress");
			var createdOnColumn = addressESQ.AddColumn("CreatedOn");
			addressESQ.AddAllSchemaColumns();
			createdOnColumn.OrderByAsc();
			var contactFilter = addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Contact", contactId);
			var addressTypeFilter = addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "AddressType", addressTypeId);
			addressESQ.Filters.Add(contactFilter);
			addressESQ.Filters.Add(addressTypeFilter);
			var options = new EntitySchemaQueryOptions {
				PageableDirection = PageableSelectDirection.First,
				PageableRowCount = 1,
				PageableConditionValues = new Dictionary<string, object>()
			};
			var addresses = addressESQ.GetEntityCollection(UserConnection, options);
			if (addresses.Count > 0) {
				var contactAddress = addresses[0];
				if (!contactAddress.GetTypedColumnValue<string>("Address").Equals(address)) {
					contactAddress.SetColumnValue("Address", address);
				}
				if (!contactAddress.GetTypedColumnValue<Guid>("CityId").Equals(cityId)) {
					contactAddress.SetColumnValue("CityId", cityId);
				}
				if (!contactAddress.GetTypedColumnValue<Guid>("RegionId").Equals(regionId)) {
					contactAddress.SetColumnValue("RegionId", regionId);
				}
				if (!contactAddress.GetTypedColumnValue<Guid>("CountryId").Equals(countryId)) {
					contactAddress.SetColumnValue("CountryId", countryId);
				}
				if (!contactAddress.GetTypedColumnValue<string>("Zip").Equals(zip)) {
					contactAddress.SetColumnValue("Zip", zip);
				}
				if (!contactAddress.GetTypedColumnValue<Guid>("DistrictId").Equals(districtId)) {
					contactAddress.SetColumnValue("DistrictId", districtId);
				}
				if (!contactAddress.GetTypedColumnValue<string>("Street").Equals(street)) {
					contactAddress.SetColumnValue("Street", street);
				}
				if (!contactAddress.GetTypedColumnValue<string>("Building1").Equals(building1)) {
					contactAddress.SetColumnValue("Building1", building1);
				}
				if (!contactAddress.GetTypedColumnValue<string>("Building2").Equals(building2)) {
					contactAddress.SetColumnValue("Building2", building2);
				}
				if (!contactAddress.GetTypedColumnValue<string>("AptOffice").Equals(aptOffice)) {
					contactAddress.SetColumnValue("AptOffice", aptOffice);
				}
				contactAddress.Save();
			} else {
				var schema = UserConnection.EntitySchemaManager.GetInstanceByName("ContactAddress");
				var contactEntity = schema.CreateEntity(UserConnection);
				contactEntity.SetDefColumnValues();
				contactEntity.SetColumnValue("ContactId", contactId);
				contactEntity.SetColumnValue("Primary", true);
				contactEntity.SetColumnValue("AddressTypeId", addressTypeId);
				contactEntity.SetColumnValue("Address", address);
				if (!cityId.Equals(Guid.Empty)) {
					contactEntity.SetColumnValue("CityId", cityId);
				}
				if (!regionId.Equals(Guid.Empty)) {
					contactEntity.SetColumnValue("RegionId", regionId);
				}
				if (!countryId.Equals(Guid.Empty)) {
					contactEntity.SetColumnValue("CountryId", countryId);
				}
				if (!districtId.Equals(Guid.Empty)) {
					contactEntity.SetColumnValue("DistrictId", districtId);
				}
				contactEntity.SetColumnValue("Zip", zip);
				contactEntity.SetColumnValue("Street", street);
				contactEntity.SetColumnValue("Building1", building1);
				contactEntity.SetColumnValue("Building2", building2);
				contactEntity.SetColumnValue("AptOffice", aptOffice);
				contactEntity.Save();
			}
			return true;
		}

		#endregion

	}

	#endregion

}

