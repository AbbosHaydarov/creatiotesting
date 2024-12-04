namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationListResponseSchema

	/// <exclude/>
	public class IntegrationListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationListResponseSchema(IntegrationListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56543138-4c89-c211-d5b8-8f2545d3e89d");
			Name = "IntegrationListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5eec482-a90e-42cc-86d3-ef2673139bae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,143,205,106,195,48,16,132,207,49,248,29,22,122,183,239,113,200,197,133,80,8,52,52,121,1,85,94,187,11,178,100,118,229,150,16,250,238,93,255,36,117,250,115,145,216,209,104,246,27,111,90,148,206,88,132,19,50,27,9,117,204,202,224,107,106,122,54,145,130,207,142,193,146,113,123,52,213,14,125,154,92,210,100,213,11,249,6,142,103,137,216,170,219,57,180,131,85,50,117,32,147,45,210,68,93,15,140,141,170,80,58,35,178,134,39,31,177,153,50,247,36,241,69,215,234,23,28,173,121,158,195,70,250,182,53,124,222,206,115,233,66,95,1,207,54,120,60,61,195,7,197,55,32,95,7,110,199,28,8,181,142,183,88,112,154,155,93,227,242,69,94,215,191,58,178,96,7,146,255,64,96,13,119,85,85,143,7,14,239,84,33,127,195,174,180,191,158,183,114,234,232,144,35,161,54,60,140,91,166,247,159,141,70,97,135,81,32,48,200,112,255,5,254,155,252,138,62,144,110,22,228,219,101,13,129,11,52,24,139,33,184,128,207,153,16,125,53,65,142,243,164,222,139,170,125,1,99,131,146,58,0,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56543138-4c89-c211-d5b8-8f2545d3e89d"));
		}

		#endregion

	}

	#endregion

}

