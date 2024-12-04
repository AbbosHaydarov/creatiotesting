namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestRequestSchema

	/// <exclude/>
	public class LandingInfoRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestRequestSchema(LandingInfoRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8");
			Name = "LandingInfoRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,143,203,106,195,48,16,69,215,49,248,31,6,186,183,247,73,233,198,165,33,16,104,72,2,93,203,214,216,29,208,195,29,73,148,16,250,239,29,91,78,233,131,110,70,204,209,213,229,200,41,139,97,84,29,194,25,153,85,240,125,172,26,239,122,26,18,171,72,222,85,39,223,145,50,123,84,122,139,174,44,174,101,177,74,129,220,0,167,75,136,104,55,101,33,228,142,113,144,48,52,70,133,176,134,189,114,90,34,59,215,251,35,134,120,196,183,36,199,156,172,235,26,238,67,178,86,241,229,97,217,27,227,147,6,206,41,120,60,63,195,59,197,87,32,121,206,118,182,0,213,250,20,193,228,222,234,214,83,127,43,26,83,107,168,131,110,50,248,87,96,37,250,50,191,124,15,236,71,228,72,40,210,135,185,32,223,255,182,156,193,82,10,164,39,129,191,6,55,133,109,34,13,13,227,100,254,130,237,147,124,98,167,225,10,3,198,13,132,105,124,44,22,232,116,22,153,247,76,127,66,97,159,150,100,123,139,163,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8"));
		}

		#endregion

	}

	#endregion

}

