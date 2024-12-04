namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignCreateLeadProcessHelperSchema

	/// <exclude/>
	public class CampaignCreateLeadProcessHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignCreateLeadProcessHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignCreateLeadProcessHelperSchema(CampaignCreateLeadProcessHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c1f6025-2ed1-42c2-928b-a879e96e8221");
			Name = "CampaignCreateLeadProcessHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,84,223,107,219,64,12,126,206,96,255,131,112,94,18,48,206,222,235,26,74,182,117,217,74,41,164,219,30,199,197,86,178,219,124,119,70,119,110,9,33,255,251,100,159,127,166,110,103,48,62,203,159,62,73,159,36,107,161,208,22,34,69,120,68,34,97,205,222,69,107,163,247,242,80,146,112,210,104,56,189,127,55,43,173,212,7,216,30,173,67,117,117,241,206,240,60,199,180,194,218,232,22,53,146,76,123,204,144,149,240,53,123,180,77,127,99,86,230,72,140,96,76,81,238,114,153,130,117,156,66,10,105,46,172,133,181,80,133,144,7,189,38,20,14,239,80,100,15,100,82,180,246,11,230,5,82,157,231,172,186,11,146,79,140,128,148,19,114,204,65,85,188,214,187,242,171,25,12,125,53,187,123,174,254,65,56,135,164,225,26,130,9,208,175,211,135,115,112,213,82,175,86,43,136,109,169,148,160,99,210,26,230,237,213,158,58,139,63,64,103,25,63,230,243,168,227,92,93,146,198,133,32,161,64,115,130,215,65,105,145,184,41,218,171,28,36,47,34,246,215,208,18,197,171,154,101,154,52,231,34,183,14,139,77,22,36,155,172,246,131,96,192,18,188,237,238,4,29,208,109,244,222,244,253,31,100,214,144,64,195,92,189,245,231,97,154,189,24,195,112,227,1,120,50,50,3,223,247,97,139,22,223,71,186,192,88,166,16,110,75,118,235,203,12,97,243,73,151,10,73,236,114,140,191,225,241,135,200,75,110,191,164,184,66,122,124,146,192,84,101,75,63,94,179,102,154,236,81,167,205,248,240,220,120,99,244,217,144,18,110,241,223,73,243,129,162,123,124,174,158,139,229,178,30,175,217,71,89,71,226,33,136,61,97,8,102,247,135,195,39,80,235,130,236,107,57,154,198,103,120,29,187,104,51,157,157,32,184,235,91,28,14,132,128,115,216,65,30,167,218,24,78,106,0,231,218,235,236,211,189,41,138,110,105,187,245,221,40,133,153,228,54,53,171,201,133,47,6,90,133,253,138,113,140,238,252,98,163,249,163,79,112,220,209,232,167,161,191,245,207,42,242,108,23,159,215,37,17,106,87,77,69,3,232,133,243,34,87,21,240,125,254,7,124,86,32,192,246,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c1f6025-2ed1-42c2-928b-a879e96e8221"));
		}

		#endregion

	}

	#endregion

}

