namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PeriodicityEnumsSchema

	/// <exclude/>
	public class PeriodicityEnumsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PeriodicityEnumsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PeriodicityEnumsSchema(PeriodicityEnumsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01");
			Name = "PeriodicityEnums";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,93,111,219,54,20,125,118,129,254,7,193,126,113,0,211,149,68,82,164,150,109,0,77,145,217,128,21,13,154,108,121,28,84,153,113,133,218,82,64,73,27,188,194,255,125,36,165,56,137,172,116,217,60,204,125,152,225,47,209,247,158,123,238,7,174,142,139,116,163,170,187,52,83,222,181,210,58,173,202,219,122,206,203,226,54,95,53,58,173,243,178,120,253,234,243,235,87,163,166,202,139,149,119,181,173,106,181,57,239,93,27,251,245,90,101,214,184,154,95,168,66,233,60,123,176,121,12,171,213,240,249,102,83,22,246,23,243,156,104,181,50,64,30,95,167,85,245,141,247,67,217,232,234,157,126,155,23,77,173,42,119,216,218,221,53,31,214,121,230,101,246,228,25,43,203,123,143,39,115,181,94,26,192,75,157,255,150,214,202,254,100,95,119,237,165,247,115,165,180,73,187,104,211,240,126,109,158,92,159,223,155,79,84,177,108,1,247,39,29,254,165,46,239,148,174,115,101,99,56,110,251,16,45,211,159,202,44,93,231,127,164,31,214,234,170,214,182,2,142,181,231,88,142,86,170,238,190,141,180,170,27,93,120,133,250,253,208,103,122,161,234,247,170,50,142,153,57,41,117,186,82,211,179,153,55,190,52,53,47,151,121,150,215,91,81,52,155,106,60,107,177,70,227,3,136,106,238,226,206,127,73,215,141,26,159,205,175,203,14,250,204,101,57,218,217,247,221,95,146,239,106,125,2,250,93,228,23,38,240,124,199,76,123,171,90,55,153,225,241,92,207,6,230,106,218,155,148,167,131,114,214,85,161,55,63,222,119,61,187,243,54,204,11,88,190,85,245,199,242,11,131,251,99,175,158,222,80,137,173,67,75,236,205,155,201,100,50,243,204,155,125,220,127,62,185,242,38,222,77,169,63,181,75,129,191,15,8,132,56,118,206,93,107,123,201,205,123,225,206,255,118,102,67,165,79,114,7,158,234,237,183,23,77,190,156,29,14,211,247,54,213,167,29,154,222,215,255,209,16,190,0,104,239,102,30,159,173,143,53,156,142,101,188,136,66,234,83,32,69,228,3,20,6,18,196,152,34,192,152,20,60,16,97,192,81,50,54,227,235,56,236,102,3,8,65,40,69,128,40,5,40,90,4,0,37,146,131,69,0,3,16,80,66,49,145,144,98,38,44,66,71,127,183,251,66,237,118,221,126,124,124,118,184,47,147,116,91,189,187,189,81,234,211,115,187,242,208,226,107,223,147,87,77,177,76,183,39,216,52,109,224,163,55,101,121,34,250,109,224,99,233,95,55,170,58,13,255,46,242,177,9,220,168,101,113,170,20,246,177,143,238,194,71,179,99,78,212,134,46,244,177,41,72,157,159,38,129,54,240,177,244,175,82,67,243,68,123,168,11,253,95,72,158,222,237,225,127,185,243,85,201,157,135,238,252,187,82,199,104,145,36,16,200,7,97,66,49,64,12,65,192,36,199,32,70,132,65,142,8,65,73,96,133,74,123,71,28,212,58,18,137,152,38,18,2,142,152,209,58,34,16,128,74,34,0,34,16,65,65,168,160,204,169,165,246,174,52,8,65,22,140,16,201,67,32,252,72,26,71,28,129,152,46,56,160,65,76,104,128,48,77,22,78,46,117,55,134,97,201,37,96,128,5,51,113,35,97,50,241,9,6,20,50,14,226,69,140,147,36,196,18,145,208,98,236,55,243,112,50,20,113,8,25,4,33,18,70,189,49,163,217,22,28,83,144,72,196,49,129,81,194,72,228,152,116,187,113,24,132,133,216,167,152,131,196,200,61,128,176,47,1,101,146,2,26,135,73,144,48,6,125,31,89,16,233,246,211,32,4,140,140,246,166,145,0,81,192,153,73,9,33,16,19,104,42,178,192,137,111,72,248,148,251,174,47,221,134,248,39,10,178,155,64,101,214,80,239,15,143,221,76,237,184,184,243,106,47,84,173,106,236,208,30,123,63,76,231,131,167,153,24,215,115,215,53,87,118,87,53,151,181,227,221,66,237,254,4,148,178,29,95,136,16,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHoursLocalizableString());
			LocalizableStrings.Add(CreateMinutesLocalizableString());
			LocalizableStrings.Add(CreateSundayLocalizableString());
			LocalizableStrings.Add(CreateSaturdayLocalizableString());
			LocalizableStrings.Add(CreateFridayLocalizableString());
			LocalizableStrings.Add(CreateThursdayLocalizableString());
			LocalizableStrings.Add(CreateWednesdayLocalizableString());
			LocalizableStrings.Add(CreateTuesdayLocalizableString());
			LocalizableStrings.Add(CreateMondayLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHoursLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("12f23832-fa87-4303-aacd-c714edf36063"),
				Name = "Hours",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMinutesLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("65f8dfe4-7ce0-435b-abc2-6bc7c5d56ace"),
				Name = "Minutes",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSundayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a8d5eda9-2165-4a96-9e78-d74c46256197"),
				Name = "Sunday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSaturdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1020d386-033c-46b6-a17f-8e39fb443bc2"),
				Name = "Saturday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFridayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bfeef8db-c2a7-438b-a423-cb94b9790dd6"),
				Name = "Friday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateThursdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0b2c9a60-8c38-49fa-a995-ace5363fa8d1"),
				Name = "Thursday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWednesdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fade33fe-e073-4386-af12-715568054744"),
				Name = "Wednesday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTuesdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("165ca4ef-8cfc-4d1c-874e-ed4de8b3461e"),
				Name = "Tuesday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMondayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5664557f-389b-421d-a281-b77b0f6df8fb"),
				Name = "Monday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"));
		}

		#endregion

	}

	#endregion

}

