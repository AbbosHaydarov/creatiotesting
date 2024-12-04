namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddCampaignAudienceElementHandlerSchema

	/// <exclude/>
	public class AddCampaignAudienceElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddCampaignAudienceElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddCampaignAudienceElementHandlerSchema(AddCampaignAudienceElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4");
			Name = "AddCampaignAudienceElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,86,91,111,19,57,20,126,14,18,255,225,144,125,153,72,209,68,251,182,162,109,164,194,38,180,82,160,104,91,182,15,136,7,119,230,76,98,237,140,157,181,61,161,1,241,223,57,190,205,37,183,2,66,170,42,197,62,151,207,223,119,46,35,88,133,122,205,50,132,59,84,138,105,89,152,244,181,20,5,95,214,138,25,46,197,243,103,95,159,63,27,212,154,139,37,220,110,181,193,138,238,203,18,51,123,169,211,55,40,80,241,236,108,215,102,193,197,255,123,135,119,248,104,218,195,110,66,133,233,165,49,138,63,212,6,245,81,147,215,172,90,51,190,20,79,26,164,179,13,10,115,197,68,94,162,106,173,173,77,52,185,205,86,88,49,184,128,190,99,255,154,92,201,121,50,153,192,185,174,171,138,169,237,52,252,38,142,12,227,66,67,133,102,37,115,13,133,84,80,209,137,61,181,185,46,243,28,46,235,156,163,32,110,177,196,138,0,105,224,2,178,152,42,70,158,116,66,175,235,135,146,103,160,145,149,152,67,86,50,173,109,164,136,42,6,156,249,120,225,129,240,18,94,49,141,167,141,198,112,125,35,162,201,191,172,228,57,51,72,25,73,93,250,63,248,67,225,146,4,181,239,210,70,213,153,145,74,191,132,247,14,142,183,8,208,158,68,147,140,192,86,204,96,128,189,227,119,84,104,196,246,27,52,119,219,53,38,163,212,30,88,105,6,223,2,2,20,185,7,209,71,244,214,19,76,96,20,223,56,204,14,141,255,1,27,201,115,184,87,220,224,156,151,6,85,120,25,57,94,139,66,38,39,120,137,162,68,184,27,70,2,162,214,108,25,112,46,178,47,183,84,146,98,73,49,107,76,246,159,51,134,161,79,122,207,205,234,157,36,234,114,110,51,223,51,101,75,96,56,58,107,2,111,122,176,222,54,105,136,107,178,76,231,82,85,204,36,33,253,56,66,163,106,92,91,159,16,168,95,155,41,41,177,243,218,131,89,198,176,163,122,184,94,224,6,203,52,96,29,117,149,232,113,27,75,101,46,203,28,149,78,174,103,162,174,80,177,135,18,207,79,176,59,109,106,62,242,203,11,72,94,196,195,244,82,108,147,81,188,26,40,52,181,114,109,237,64,4,210,10,159,146,104,90,72,150,7,0,238,161,77,236,64,204,10,179,255,194,253,236,145,211,172,17,186,17,76,143,99,160,142,30,225,196,11,231,69,164,52,115,46,98,154,238,77,210,247,247,154,253,66,173,184,40,167,107,197,85,242,142,170,123,239,232,98,27,71,28,191,75,102,23,181,47,115,167,229,223,51,101,120,198,215,76,152,163,66,211,36,68,150,173,128,202,81,197,75,59,248,118,237,156,16,52,233,84,182,250,155,25,59,138,103,34,147,185,237,135,15,119,243,191,104,181,152,87,91,90,7,145,128,212,99,11,76,121,111,215,9,97,180,68,51,242,107,138,81,24,110,182,190,95,28,151,31,52,42,226,94,248,245,53,74,219,0,103,135,48,93,49,221,22,135,35,255,10,203,53,170,212,85,220,237,190,93,210,6,28,119,226,140,97,39,113,200,230,122,226,64,186,134,162,193,241,209,22,199,87,8,229,219,230,219,207,13,84,105,8,15,230,254,126,119,205,185,131,127,92,103,106,48,43,132,146,58,11,100,65,70,136,144,41,44,46,134,39,75,99,56,153,54,219,14,216,238,46,180,251,111,127,1,250,147,53,83,172,2,65,44,94,12,61,163,195,105,204,19,68,167,138,210,134,81,192,244,124,226,204,91,111,63,77,244,116,17,240,102,82,16,90,170,244,19,96,206,39,209,203,183,70,96,6,228,134,190,48,120,142,240,195,115,175,91,126,33,122,114,224,195,195,191,34,10,237,147,135,195,116,94,202,207,209,55,189,41,236,194,124,162,9,147,94,103,63,173,124,103,175,31,148,61,142,3,125,228,59,134,130,53,100,182,91,39,5,223,18,228,22,103,247,103,154,85,32,164,213,192,15,188,99,186,127,188,81,228,144,252,57,250,212,249,216,112,163,233,166,249,92,105,62,45,58,147,197,174,135,131,148,247,232,30,253,20,141,191,176,171,48,24,219,217,28,86,72,59,146,116,122,191,66,133,201,35,92,76,225,197,99,218,246,185,15,179,187,99,15,4,235,236,174,222,173,31,215,71,82,157,200,20,198,252,129,88,167,42,137,78,233,239,59,63,25,233,251,52,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFolderWithNoConditionWarningLocalizableString());
			LocalizableStrings.Add(CreateFolderNotFoundErrorLocalizableString());
			LocalizableStrings.Add(CreateFilterWithNoConditionWarningLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFolderWithNoConditionWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7244310a-84bf-404b-baa6-2bae953fbbc1"),
				Name = "FolderWithNoConditionWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFolderNotFoundErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f6c3f61f-5296-4d52-bc90-ce76168b921f"),
				Name = "FolderNotFoundError",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFilterWithNoConditionWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b77bcf38-2f18-445a-8f83-e2935ae6e184"),
				Name = "FilterWithNoConditionWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"));
		}

		#endregion

	}

	#endregion

}

