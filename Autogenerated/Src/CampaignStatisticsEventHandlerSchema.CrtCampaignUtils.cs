namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStatisticsEventHandlerSchema

	/// <exclude/>
	public class CampaignStatisticsEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStatisticsEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStatisticsEventHandlerSchema(CampaignStatisticsEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b");
			Name = "CampaignStatisticsEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,86,75,111,219,56,16,62,171,64,255,3,225,189,72,64,160,116,175,237,110,1,199,117,218,0,105,18,212,78,123,40,122,96,168,177,76,172,68,106,249,72,226,46,242,223,119,248,144,228,135,236,36,40,16,244,146,88,212,204,55,51,223,55,195,145,160,53,232,134,50,32,115,80,138,106,185,48,249,68,138,5,47,173,162,134,75,241,250,213,127,175,95,37,86,115,81,146,217,74,27,168,223,117,207,235,46,10,242,177,49,138,223,88,3,122,175,201,132,214,13,229,165,200,167,183,32,204,39,42,138,10,212,94,235,15,39,143,2,161,1,154,252,161,160,196,92,201,164,162,90,191,37,237,203,245,32,222,238,248,248,152,252,165,109,93,83,181,122,31,159,177,90,67,185,208,164,6,179,148,133,38,70,18,202,140,165,21,255,9,132,69,40,162,13,210,161,13,103,154,20,86,185,140,186,87,224,194,232,188,197,63,94,11,208,216,155,138,51,162,129,86,80,16,230,210,235,178,155,117,136,235,121,146,225,244,79,168,134,35,114,118,41,122,111,217,108,28,76,239,129,89,167,24,50,85,115,65,13,96,124,212,14,255,246,252,72,129,117,96,178,111,201,149,226,183,222,198,189,111,194,3,97,238,61,150,234,235,155,86,80,247,9,92,96,163,144,191,137,192,127,114,145,30,174,33,123,183,23,180,117,156,211,155,10,134,49,159,224,125,69,21,198,228,13,150,114,0,104,205,202,97,122,34,64,20,129,139,77,98,174,148,108,0,173,193,49,227,53,59,108,255,57,244,202,30,26,103,80,1,51,228,35,152,185,52,180,26,200,71,79,164,21,38,216,165,25,113,35,150,36,183,84,97,167,120,87,172,5,238,34,78,122,173,65,161,114,2,127,99,236,204,219,38,9,206,65,101,107,145,158,90,193,114,15,151,142,206,138,81,22,223,231,167,74,214,233,33,194,90,195,111,75,80,144,142,90,83,135,145,159,233,233,191,56,1,105,136,145,163,59,58,24,80,189,240,108,9,53,205,167,194,112,179,58,43,178,140,80,29,243,245,242,37,161,144,124,214,0,227,139,213,133,60,151,236,159,79,28,43,79,131,190,137,2,99,21,206,85,239,243,176,143,197,47,64,49,92,49,95,194,71,73,171,103,209,248,100,13,6,146,202,199,162,72,71,174,197,173,118,172,68,190,30,229,166,155,178,124,32,106,172,197,21,210,34,239,144,183,69,196,173,228,5,185,110,10,252,221,2,142,109,193,65,48,240,37,128,210,27,197,27,95,112,95,220,243,105,112,40,170,79,116,7,235,137,130,244,96,214,103,31,219,58,148,178,213,214,71,187,87,67,215,233,51,192,222,158,83,85,198,42,70,104,28,200,159,217,155,24,108,187,232,108,200,123,204,150,28,111,235,33,255,225,114,183,80,62,203,130,47,56,20,151,162,135,232,245,255,128,85,205,121,13,249,181,97,23,242,110,143,239,9,142,203,144,247,38,29,249,196,42,133,55,170,59,117,11,217,224,74,114,157,178,57,179,191,48,171,65,132,160,80,80,39,255,198,205,50,140,168,83,233,139,188,107,103,54,205,178,13,195,176,106,32,10,252,240,212,171,114,237,94,221,94,196,254,96,220,52,21,222,192,221,34,94,72,53,184,127,17,84,227,246,203,59,191,118,91,235,222,156,198,1,193,253,17,38,164,179,222,216,207,201,247,75,85,32,85,127,190,121,147,253,240,51,23,22,182,31,185,75,191,100,187,209,50,106,21,127,37,143,13,99,96,235,1,211,49,108,73,210,233,61,131,198,169,74,224,190,69,75,226,74,195,207,47,77,75,8,115,117,206,126,206,252,241,87,90,89,72,119,55,240,17,25,133,172,58,200,81,12,150,180,217,156,203,178,196,158,153,42,37,213,169,84,53,53,105,140,113,132,225,251,49,219,238,138,8,99,150,74,222,197,252,215,212,29,20,172,251,116,170,100,137,164,29,208,11,218,143,19,98,218,175,147,23,144,111,247,147,232,247,19,115,186,147,227,75,75,187,53,184,225,116,243,16,207,254,7,103,215,72,151,41,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOnExecutionTerminateExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnStopExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOnExecutionTerminateExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0197d642-0e99-4a65-b19d-c37839084917"),
				Name = "OnExecutionTerminateException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"),
				ModifiedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnStopExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("240946f2-b208-45ac-909a-43c9b9be0ccb"),
				Name = "OnStopException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"),
				ModifiedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"));
		}

		#endregion

	}

	#endregion

}

