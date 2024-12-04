namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignFragmentSyncManagerSchema

	/// <exclude/>
	public class ICampaignFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignFragmentSyncManagerSchema(ICampaignFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f487be7-70f8-43c3-96b8-4b744c2ea4c4");
			Name = "ICampaignFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,148,193,78,227,48,16,134,207,84,234,59,140,202,133,149,80,115,135,210,75,17,82,15,72,43,177,60,192,212,153,36,150,226,113,118,198,94,182,139,120,119,28,183,208,26,16,92,56,238,37,145,199,246,231,255,255,199,9,163,35,29,208,16,252,34,17,84,223,132,249,202,115,99,219,40,24,172,231,233,228,113,58,57,137,106,185,45,150,8,93,78,39,105,230,84,168,77,203,96,205,129,164,73,160,11,88,175,208,13,104,91,190,17,108,29,113,184,219,178,185,69,198,150,36,239,169,170,10,22,26,157,67,217,46,247,227,107,82,35,118,67,10,77,100,51,158,140,189,13,91,104,188,128,217,243,96,64,9,214,216,1,57,40,104,162,118,226,217,254,203,66,97,15,10,29,6,176,10,198,59,151,170,227,254,86,124,28,192,55,7,144,154,142,28,2,245,52,234,83,120,176,161,3,250,29,177,127,135,237,125,107,205,252,69,117,117,36,123,136,155,222,26,176,47,206,191,48,126,146,130,76,207,215,196,110,41,116,190,214,11,248,153,57,187,201,183,209,228,194,221,171,164,20,207,199,97,140,54,31,58,107,186,195,124,179,23,161,208,97,13,27,34,6,250,75,38,6,170,71,59,239,253,236,42,9,139,14,56,221,139,171,89,84,146,116,27,152,114,67,102,203,53,107,64,78,78,83,150,11,37,2,35,212,92,205,238,203,101,213,18,76,143,170,243,69,149,97,31,179,15,57,83,189,242,145,195,108,153,95,35,251,120,174,240,89,32,255,120,91,31,103,115,86,234,128,82,253,57,36,173,99,179,10,122,62,242,199,229,39,225,223,120,73,134,143,246,252,111,193,80,182,32,39,244,157,125,56,37,174,119,31,73,30,63,237,126,52,69,49,213,158,1,232,172,123,97,187,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f487be7-70f8-43c3-96b8-4b744c2ea4c4"));
		}

		#endregion

	}

	#endregion

}

