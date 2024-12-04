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

	#region Class: BaseAddress_AddressFinanceEventsProcess

	public partial class BaseAddress_AddressFinanceEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual void UpdateAddress() {
			var addressEntity = new Entity(Entity);
			
			if (addressEntity.FetchFromDB(Entity.PrimaryColumnValue)) {
				var addressString = new List<string>();
				var fullAddress = string.Empty;
				
				var zipName = addressEntity.Schema.Columns.GetByName("Zip").DisplayColumnValueName;
				var building1Name = addressEntity.Schema.Columns.GetByName("Building1").DisplayColumnValueName;
				var building2Name = addressEntity.Schema.Columns.GetByName("Building2").DisplayColumnValueName;
				var aptOfficeName = addressEntity.Schema.Columns.GetByName("AptOffice").DisplayColumnValueName;
				var countryName = addressEntity.Schema.Columns.GetByName("Country").DisplayColumnValueName;
				var streetName = addressEntity.Schema.Columns.GetByName("Street").DisplayColumnValueName;
				var cityName = addressEntity.Schema.Columns.GetByName("City").DisplayColumnValueName;
				var districtName = addressEntity.Schema.Columns.GetByName("District").DisplayColumnValueName;
				var regionName = addressEntity.Schema.Columns.GetByName("Region").DisplayColumnValueName;
				
				var streetValue = (string)addressEntity.ForceGetEntityColumnValue(streetName).Value;
				var building1Value = (string)addressEntity.ForceGetEntityColumnValue(building1Name).Value;
				if(!string.IsNullOrEmpty(building1Value)){
					building1Value = BuildingType + " " + building1Value;
				}
				var building2Value = (string)addressEntity.ForceGetEntityColumnValue(building2Name).Value;
				if(!string.IsNullOrEmpty(building2Value)){
						building2Value = StructType + " " + building2Value;
				}
				var aptOfficeValue = (string)addressEntity.ForceGetEntityColumnValue(aptOfficeName).Value;
				if(!string.IsNullOrEmpty(aptOfficeValue)){
						aptOfficeValue = AptType + " " + aptOfficeValue;
				}
				var cityValue = (string)addressEntity.ForceGetEntityColumnValue(cityName).Value;
				var districtValue = (string)addressEntity.ForceGetEntityColumnValue(districtName).Value;
				var regionValue = (string)addressEntity.ForceGetEntityColumnValue(regionName).Value;
				var zipValue = (string)addressEntity.ForceGetEntityColumnValue(zipName).Value;
				var countryValue = (string)addressEntity.ForceGetEntityColumnValue(countryName).Value;
				
				addressString.Add(streetValue);
				addressString.Add(building1Value);
				addressString.Add(building2Value);
				addressString.Add(aptOfficeValue);
				addressString.Add(cityValue);
				addressString.Add(districtValue);
				addressString.Add(regionValue);
				addressString.Add(zipValue);
				addressString.Add(countryValue);
				
				fullAddress = StringUtilities.ConcatIfNotEmpty(addressString, ", ");
				
				Update updateAddressQuery = new Update(UserConnection, Entity.Schema.Name);
				updateAddressQuery.Set("Address", Column.Parameter(fullAddress));
				updateAddressQuery.Where("Id").IsEqual(Column.Parameter(Entity.PrimaryColumnValue));
				updateAddressQuery.Execute();
				
				if(Entity.Schema.Name == "AccountAddress")
				{
					Update updateAccountQuery = new Update(UserConnection, "Account");
					updateAccountQuery.Set("Address", Column.Parameter(fullAddress));
					updateAccountQuery.Where("Id").IsEqual(Column.Parameter(Entity.GetTypedColumnValue<Guid>("AccountId")));
					updateAccountQuery.Execute();
				}
				if(Entity.Schema.Name == "ContactAddress")
				{
					Update updateContactQuery = new Update(UserConnection, "Contact");
					updateContactQuery.Set("Address", Column.Parameter(fullAddress));
					updateContactQuery.Where("Id").IsEqual(Column.Parameter(Entity.GetTypedColumnValue<Guid>("ContactId")));
					updateContactQuery.Execute();
				}
			}
		}

		#endregion

	}

	#endregion

}