namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAudienceConfigSchema

	/// <exclude/>
	public class CampaignAudienceConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAudienceConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAudienceConfigSchema(CampaignAudienceConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("639d6364-2acb-4af6-9f5a-465dfd23757f");
			Name = "CampaignAudienceConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,148,207,110,219,48,12,198,207,46,208,119,32,186,75,11,12,241,125,109,58,12,30,176,245,50,20,72,247,0,154,68,219,194,108,201,211,159,101,69,145,119,31,37,75,177,227,166,105,46,69,69,138,63,126,31,69,71,177,30,237,192,56,194,19,26,195,172,174,221,170,210,170,150,141,55,204,73,173,46,47,94,46,47,10,111,165,106,96,243,108,29,246,183,251,243,188,196,32,197,41,243,193,96,67,101,80,117,204,218,79,80,177,126,96,178,81,95,188,144,168,56,142,236,120,179,44,75,184,179,190,239,153,121,190,79,231,88,5,219,86,242,22,184,86,142,73,101,97,96,134,84,58,52,22,106,109,128,27,100,14,129,39,50,176,132,6,235,72,197,42,147,203,25,122,240,191,58,201,129,71,250,91,146,10,50,74,127,39,7,90,89,103,60,39,42,25,121,140,136,241,198,82,121,12,140,23,130,234,92,21,164,188,214,50,70,162,39,80,228,107,125,229,45,26,106,166,144,135,129,95,221,63,16,129,5,67,186,6,215,34,132,124,224,166,11,171,187,50,86,31,135,229,177,60,8,2,9,84,78,214,146,202,19,42,123,63,205,176,104,45,53,10,136,205,248,47,200,61,106,5,223,153,5,129,53,243,157,131,191,172,243,8,179,192,55,47,197,24,61,232,145,94,224,248,236,175,127,30,76,32,26,158,142,31,71,230,100,44,5,246,42,97,157,187,95,135,196,205,13,132,149,45,138,5,117,189,224,134,61,46,138,205,140,178,39,142,169,44,54,230,166,246,49,185,75,187,130,74,140,235,114,184,59,143,70,15,104,156,196,115,54,167,202,139,190,16,28,150,253,143,71,67,148,55,86,41,77,117,81,183,56,190,64,131,238,22,118,39,20,28,123,229,31,136,226,156,15,46,94,217,106,243,27,50,109,43,93,155,103,137,34,124,190,78,114,57,48,229,136,103,116,15,150,40,172,123,199,84,124,227,233,117,206,112,81,101,129,51,27,239,183,200,85,231,245,120,146,125,114,28,126,162,182,180,248,67,199,104,212,211,126,2,254,67,238,227,135,122,178,249,87,154,105,160,125,222,43,216,240,22,133,239,80,132,84,22,99,103,138,22,219,54,70,15,131,187,255,26,47,87,51,209,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("639d6364-2acb-4af6-9f5a-465dfd23757f"));
		}

		#endregion

	}

	#endregion

}

