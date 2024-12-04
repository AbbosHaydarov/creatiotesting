namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignHelperSchema

	/// <exclude/>
	public class CampaignHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignHelperSchema(CampaignHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715");
			Name = "CampaignHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("162d1c91-6a07-417c-8455-dae56dc8642f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,88,75,111,219,56,16,62,187,64,255,3,225,94,100,192,144,247,220,198,62,196,137,83,3,105,16,36,233,230,176,88,44,104,105,100,11,149,72,47,73,229,209,34,255,125,135,47,73,148,101,199,205,110,247,146,88,195,225,60,190,153,111,52,54,163,37,200,45,77,128,220,129,16,84,242,76,197,115,206,178,124,93,9,170,114,206,222,191,251,241,254,221,160,146,57,91,147,219,103,169,160,252,212,121,70,253,162,128,68,43,203,248,2,24,136,60,105,116,230,188,44,57,107,63,11,8,159,226,57,45,183,52,95,119,148,226,179,211,70,208,14,14,143,206,153,202,85,14,50,188,225,237,220,38,27,40,41,153,134,214,227,240,24,175,226,229,15,2,214,24,55,153,23,84,202,143,196,171,124,134,98,11,194,104,108,171,85,145,39,36,209,10,59,231,3,196,6,255,54,102,16,2,245,145,92,139,252,129,42,176,103,91,251,64,18,125,70,164,18,38,220,192,144,241,126,133,149,192,152,25,254,227,89,20,42,140,62,29,97,203,230,117,197,213,130,87,44,61,127,74,96,171,107,130,54,135,175,168,12,143,49,127,208,240,94,147,31,128,165,22,156,30,164,68,149,40,46,16,247,107,3,178,11,194,2,30,2,16,125,149,8,19,103,204,246,25,169,130,199,17,209,61,58,24,252,21,138,49,192,80,160,219,101,240,114,56,176,69,14,69,42,247,212,176,19,69,199,223,43,41,127,1,181,225,105,39,219,201,100,66,78,100,85,150,84,60,207,188,224,2,148,36,106,131,133,112,32,144,199,92,109,136,220,66,146,103,57,164,36,51,65,226,63,36,94,74,114,70,50,193,75,114,118,26,215,38,39,93,155,39,91,42,104,105,218,107,58,12,227,30,206,238,208,151,150,233,202,59,97,124,50,49,55,250,13,248,192,150,169,189,92,7,154,167,128,220,196,248,196,43,6,120,81,149,76,222,241,5,168,100,227,140,88,153,209,192,252,57,201,244,217,174,29,1,170,18,76,206,78,38,254,83,171,111,164,194,177,213,180,143,198,210,127,62,220,68,99,114,81,229,105,157,201,50,29,155,158,26,24,231,210,177,225,143,63,73,24,185,111,61,51,145,158,221,228,145,126,0,133,30,226,182,210,23,202,232,26,81,194,248,150,72,5,202,18,56,125,214,51,32,170,73,53,212,180,175,109,55,24,79,157,131,120,46,0,187,210,30,71,29,74,216,171,203,115,86,149,32,232,170,128,147,182,247,185,73,98,86,67,222,152,180,2,29,150,13,71,70,157,132,173,225,60,35,145,15,40,54,7,11,108,193,179,211,200,217,65,250,232,246,179,230,198,109,84,189,207,145,135,110,96,171,216,228,71,155,65,107,157,33,101,27,53,86,21,69,155,200,255,49,131,136,174,6,211,47,196,210,240,245,88,74,253,82,70,188,206,5,223,67,132,103,136,6,224,85,1,217,180,105,165,201,44,238,165,203,67,46,84,69,139,126,190,252,27,66,184,106,181,205,117,198,101,111,87,4,93,118,168,194,55,54,23,82,228,235,141,122,4,253,183,193,188,228,41,20,174,228,56,15,42,73,40,75,201,86,240,181,0,124,141,107,25,252,210,194,30,89,150,37,203,248,209,165,209,202,109,60,245,115,183,68,30,253,224,78,125,172,31,166,13,129,6,15,84,16,9,122,119,211,98,120,36,183,230,161,91,168,145,173,187,155,13,209,112,201,174,29,146,195,238,81,189,104,24,212,17,50,175,160,167,67,123,178,57,241,253,6,4,78,60,173,24,47,229,249,223,152,111,100,109,197,215,26,81,80,248,238,111,165,55,210,195,193,70,105,83,176,225,199,183,134,216,207,87,252,146,39,223,62,231,76,201,104,20,40,156,63,65,82,41,184,1,154,162,197,84,144,233,204,143,159,46,60,136,67,0,159,83,27,116,115,67,221,212,204,111,27,240,239,180,168,224,68,215,99,214,135,131,35,207,160,1,175,247,254,138,243,98,22,66,236,111,214,65,105,207,13,38,246,244,197,77,202,158,241,108,243,178,117,175,103,174,91,238,112,173,230,226,14,158,116,3,96,36,151,201,247,91,115,96,130,137,246,108,169,227,253,59,161,115,63,80,27,193,31,13,148,245,81,100,93,198,11,46,74,170,162,218,115,123,12,140,70,61,3,191,157,199,27,6,191,123,33,253,223,108,239,139,33,164,185,185,10,245,54,109,39,67,179,64,207,238,241,221,68,86,64,12,150,24,128,70,66,26,219,29,187,132,174,36,160,91,180,95,155,235,29,36,187,223,145,90,227,196,74,246,13,148,55,142,138,208,248,215,159,26,8,78,242,166,177,96,194,181,62,49,29,220,110,130,41,112,155,208,130,10,199,213,22,99,234,27,218,105,185,197,165,106,212,37,12,46,68,18,247,182,183,209,101,207,215,175,67,164,113,254,2,94,52,201,185,37,146,76,173,129,58,130,96,197,28,117,106,164,71,78,160,208,45,147,19,251,245,211,209,48,240,24,47,114,150,54,123,43,22,182,1,239,39,222,221,28,11,145,127,199,5,204,161,187,122,246,159,52,27,99,114,44,105,61,212,195,153,65,221,136,73,198,133,247,160,247,95,103,249,224,14,86,248,130,90,99,246,179,57,219,203,249,203,30,15,189,95,75,140,169,221,166,113,7,117,10,99,175,26,196,226,219,208,159,53,78,27,29,221,230,193,136,29,94,118,213,100,252,227,183,151,216,56,30,142,59,30,26,226,236,88,119,148,223,49,23,217,182,235,246,215,61,23,223,204,111,74,241,13,72,94,137,4,213,185,192,182,25,183,211,44,250,114,240,47,109,235,246,65,7,138,206,119,84,109,10,13,113,157,98,231,29,183,255,186,30,123,85,129,69,2,91,4,243,171,21,45,58,225,198,103,144,57,181,49,201,104,33,67,26,58,94,24,47,7,126,89,176,210,80,248,242,15,67,89,156,89,119,19,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCampaignNotFoundExceptionLocalizableString());
			LocalizableStrings.Add(CreateScheduleNextCampaignJobExceptionLocalizableString());
			LocalizableStrings.Add(CreateRunCampaignExceptionLocalizableString());
			LocalizableStrings.Add(CreateCampaignSchemaNotFoundExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCampaignNotFoundExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eb9ddd1e-1015-403b-bb5f-a49b3fc21fce"),
				Name = "CampaignNotFoundException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateScheduleNextCampaignJobExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("83c1e6a4-4525-4ae3-8a5a-680a5e9bd043"),
				Name = "ScheduleNextCampaignJobException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRunCampaignExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aeb33530-d65e-440a-90e2-66dde8d996b2"),
				Name = "RunCampaignException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCampaignSchemaNotFoundExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2261ae3d-11a2-4503-ad1d-3cdfc5512c8f"),
				Name = "CampaignSchemaNotFoundException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"));
		}

		#endregion

	}

	#endregion

}

