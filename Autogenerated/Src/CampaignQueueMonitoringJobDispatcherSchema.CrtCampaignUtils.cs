namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignQueueMonitoringJobDispatcherSchema

	/// <exclude/>
	public class CampaignQueueMonitoringJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignQueueMonitoringJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignQueueMonitoringJobDispatcherSchema(CampaignQueueMonitoringJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858");
			Name = "CampaignQueueMonitoringJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,87,95,111,219,54,16,127,86,129,126,135,67,250,34,3,134,188,190,186,177,139,46,13,58,111,205,214,54,9,246,88,208,210,89,225,42,145,42,73,185,245,134,126,247,30,37,81,18,101,41,118,176,23,219,60,222,223,223,29,239,206,130,229,168,11,22,35,220,161,82,76,203,157,137,174,164,216,241,180,84,204,112,41,158,63,251,239,249,179,160,212,92,164,240,177,100,202,252,251,170,61,247,69,20,70,183,241,3,38,101,134,106,140,227,111,220,18,87,158,75,209,221,90,169,43,150,23,140,167,130,140,106,163,97,85,17,35,71,141,188,107,38,140,238,164,211,76,110,89,182,92,214,90,163,247,50,77,137,76,247,196,241,66,97,74,206,195,85,198,180,94,130,211,242,177,196,18,111,164,224,70,42,226,253,93,110,223,114,138,222,144,227,170,146,91,44,22,112,169,203,60,103,234,176,110,206,31,148,220,243,4,53,228,104,30,100,162,193,72,120,96,34,201,16,182,74,126,65,1,113,163,30,190,90,253,144,183,6,34,167,114,209,211,89,148,219,140,199,16,91,215,206,242,12,150,240,43,211,88,177,120,23,115,216,188,41,138,235,61,10,243,158,107,131,194,70,17,80,190,232,179,131,192,33,183,164,72,248,158,25,172,239,139,250,0,177,189,7,46,12,12,124,184,83,60,77,81,145,16,29,205,129,82,243,242,151,26,221,224,5,138,164,86,239,219,34,168,10,84,134,163,53,86,133,217,216,170,67,150,123,42,7,130,18,180,177,6,128,130,121,167,100,89,252,73,69,8,171,53,248,181,208,230,190,207,214,56,48,204,83,69,120,35,40,12,27,43,85,179,220,209,61,82,116,10,119,171,139,9,148,47,22,235,58,13,54,79,199,137,106,33,154,16,135,207,95,125,194,171,94,172,83,50,195,179,125,93,65,144,162,177,0,12,21,194,235,215,16,30,17,87,32,240,219,148,129,240,94,163,34,0,5,198,246,249,206,102,149,83,129,158,48,176,130,61,203,74,11,107,16,252,248,95,216,254,134,25,229,254,169,144,214,82,240,57,246,206,99,64,54,156,131,163,15,159,175,165,70,111,64,243,193,171,137,39,48,59,210,112,30,100,239,144,250,153,84,64,106,168,103,60,96,215,38,180,107,148,17,108,30,7,213,123,238,132,237,9,84,55,163,114,93,4,30,185,15,242,132,224,56,117,28,115,159,199,131,222,191,242,51,224,221,157,153,136,161,190,163,124,76,245,167,155,186,131,219,78,40,13,217,192,164,151,63,46,72,27,55,137,140,23,13,168,13,79,215,183,54,52,100,108,94,237,172,33,111,103,214,43,250,125,195,4,163,115,212,221,28,79,182,182,155,213,28,182,151,217,232,158,100,189,29,176,214,135,246,80,187,241,22,119,172,204,58,106,228,42,235,137,70,246,146,39,224,180,16,208,97,211,171,191,73,245,165,90,20,172,231,115,215,193,75,221,132,210,20,5,141,163,206,3,247,235,134,139,210,96,118,32,109,151,231,204,187,117,88,233,10,206,24,7,243,161,95,206,161,57,208,83,229,50,217,136,218,58,229,252,229,188,86,203,245,237,129,134,101,110,107,109,9,70,149,54,28,231,244,178,141,157,166,107,209,140,190,229,137,209,56,59,234,5,231,2,125,47,156,229,123,193,98,83,178,140,162,211,161,131,147,202,52,70,173,91,151,232,178,49,173,195,209,7,212,130,212,139,34,52,181,72,85,38,181,222,128,239,90,114,244,7,30,34,11,153,221,251,12,163,46,31,82,117,221,29,10,12,103,21,125,230,188,9,130,59,117,232,60,182,197,113,182,19,61,99,205,163,182,120,217,207,217,201,70,218,160,64,27,152,191,104,77,54,195,113,172,55,194,160,18,44,187,254,142,49,85,68,11,242,32,183,209,167,82,132,179,167,117,147,222,170,51,26,129,3,130,118,200,230,45,192,63,114,11,59,154,14,131,221,145,246,74,139,21,86,91,166,66,135,181,219,52,27,24,167,166,107,69,41,152,98,57,8,202,220,234,130,150,59,131,223,205,197,122,98,206,184,245,241,170,225,163,9,115,185,168,20,172,123,211,161,130,239,47,97,31,183,161,127,0,225,64,202,174,144,246,219,1,74,229,227,247,241,208,49,212,153,167,42,250,212,70,102,171,200,67,251,200,230,181,72,30,177,8,163,98,183,84,47,100,248,148,187,143,10,159,103,119,80,28,53,213,39,254,248,9,139,224,113,155,101,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExecutionExceptionLocalizableString());
			LocalizableStrings.Add(CreateCreateJobErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExecutionExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fe22e7df-a5c5-4b9d-824b-76db35cfd28d"),
				Name = "ExecutionException",
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"),
				ModifiedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateJobErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04db795e-fe79-4373-8e8e-a00606a0efa9"),
				Name = "CreateJobError",
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"),
				ModifiedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"));
		}

		#endregion

	}

	#endregion

}

