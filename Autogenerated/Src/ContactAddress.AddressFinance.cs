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

	#region Class: ContactAddress_AddressFinanceEventsProcess

	public partial class ContactAddress_AddressFinanceEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual void SynchronizeContactOld() {
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var addressESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ContactAddress");
			var idColumn = addressESQ.AddColumn(addressESQ.RootSchema.GetPrimaryColumnName()); 
			addressESQ.AddColumn("CreatedOn").OrderByAsc();
			addressESQ.Filters.Add(addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Contact", contactId));
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
			var contactESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			contactESQ.AddAllSchemaColumns();
			var contact = contactESQ.GetEntity(UserConnection, contactId);
			if (contact != null) {
				contact.SetColumnValue("ModifiedOn", DateTime.UtcNow);
				if (!Entity.GetTypedColumnValue<bool>("Primary")) {
					contact.Save();
					return;
				}
				var entityChanged = false;
				var district = Entity.GetTypedColumnValue<Guid>("DistrictId");
				var street = Entity.GetTypedColumnValue<string>("Street");
				var building1 = Entity.GetTypedColumnValue<string>("Building1");
				var building2 = Entity.GetTypedColumnValue<string>("Building2");
				var aptOffice = Entity.GetTypedColumnValue<string>("AptOffice");
				var addressType = Entity.GetTypedColumnValue<Guid>("AddressTypeId");
				var country = Entity.GetTypedColumnValue<Guid>("CountryId");
				var region = Entity.GetTypedColumnValue<Guid>("RegionId");
				var city = Entity.GetTypedColumnValue<Guid>("CityId");
				var address = Entity.GetTypedColumnValue<string>("Address");
				var zip = Entity.GetTypedColumnValue<string>("Zip");
				if (!contact.GetTypedColumnValue<Guid>("AddressTypeId").Equals(addressType)) {
					if (addressType.Equals(Guid.Empty)) {
						contact.SetColumnValue("AddressTypeId", null);
					} else {
						contact.SetColumnValue("AddressTypeId", addressType);
					}
					entityChanged = true;
				}
				if (!contact.GetTypedColumnValue<Guid>("CountryId").Equals(country)) {
					if (country.Equals(Guid.Empty)) {
						contact.SetColumnValue("CountryId", null);
					} else {
						contact.SetColumnValue("CountryId", country);
					}
					entityChanged = true;
				}
				if (!contact.GetTypedColumnValue<Guid>("RegionId").Equals(region)) {
					if (region.Equals(Guid.Empty)) {
						contact.SetColumnValue("RegionId", null);
					} else {
						contact.SetColumnValue("RegionId", region);
					}
					entityChanged = true;
				}
				if (!contact.GetTypedColumnValue<Guid>("CityId").Equals(city)) {
					if (city.Equals(Guid.Empty)) {
						contact.SetColumnValue("CityId", null);
					} else {
						contact.SetColumnValue("CityId", city);
					}
					entityChanged = true;
				}
				if (!contact.GetTypedColumnValue<string>("Address").Equals(address)) {
					contact.SetColumnValue("Address", address);
					entityChanged = true;
				}
				if (!contact.GetTypedColumnValue<string>("Zip").Equals(zip)) {
					contact.SetColumnValue("Zip", zip);
					entityChanged = true;
				}
				if (!contact.GetTypedColumnValue<Guid>("DistrictId").Equals(district)) {
					if (district.Equals(Guid.Empty)) {
						contact.SetColumnValue("DistrictId", null);
					} else {
						contact.SetColumnValue("DistrictId", district);
					}
					entityChanged = true;
				}
				
				if (!contact.GetTypedColumnValue<string>("Street").Equals(street)) {
					contact.SetColumnValue("Street", street);
					entityChanged = true;
				}
				
				if (!contact.GetTypedColumnValue<string>("Building1").Equals(building1)) {
					contact.SetColumnValue("Building1", building1);
					entityChanged = true;
				}
				
				if (!contact.GetTypedColumnValue<string>("Building2").Equals(building2)) {
					contact.SetColumnValue("Building2", building2);
					entityChanged = true;
				}
				
				if (!contact.GetTypedColumnValue<string>("AptOffice").Equals(aptOffice)) {
					contact.SetColumnValue("AptOffice", aptOffice);
					entityChanged = true;
				}
				if (entityChanged) {
					contact.SetColumnValue("GPSN", string.Empty);
					contact.SetColumnValue("GPSE", string.Empty);
					contact.Save();
				}
			}
		}

		#endregion

	}

	#endregion

}

