namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignInfoSchema

	/// <exclude/>
	public class CampaignInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignInfoSchema(CampaignInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42");
			Name = "CampaignInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,146,219,106,2,49,16,134,175,21,124,135,1,239,221,123,45,189,145,182,120,39,88,31,32,110,102,179,67,55,135,102,18,138,72,223,189,179,89,173,246,64,169,45,132,129,57,253,243,49,19,167,44,114,80,53,194,35,198,168,216,55,105,182,244,174,33,147,163,74,228,221,100,124,152,140,71,153,201,25,216,236,57,161,93,136,47,111,26,209,72,30,150,157,98,158,195,82,217,160,200,184,149,107,252,100,44,249,170,170,224,134,179,181,42,238,111,143,126,169,133,212,170,4,17,67,68,70,151,24,58,50,109,122,193,222,66,125,148,1,78,42,33,144,168,129,245,26,187,217,73,178,186,208,12,121,215,81,13,117,145,253,72,48,18,108,177,239,152,235,232,3,198,68,40,172,235,210,54,228,63,99,150,192,214,209,115,150,233,90,248,168,33,140,224,155,51,90,31,76,251,30,232,43,209,9,233,33,147,62,19,105,56,128,193,180,0,238,205,235,159,39,247,75,201,124,197,228,77,105,184,98,254,125,167,204,112,32,114,154,106,185,1,159,199,135,232,141,28,141,135,227,252,140,177,243,190,131,149,147,181,15,45,255,90,64,106,17,130,138,84,83,80,46,201,135,113,79,168,143,119,0,174,91,180,234,23,75,185,43,245,155,82,190,253,126,39,83,116,122,248,48,197,31,162,151,65,249,249,18,124,3,103,151,225,59,54,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42"));
		}

		#endregion

	}

	#endregion

}

