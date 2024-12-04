namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialLeadGenRestProviderResponseSchema

	/// <exclude/>
	public class SocialLeadGenRestProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialLeadGenRestProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialLeadGenRestProviderResponseSchema(SocialLeadGenRestProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb4700f9-fd00-5da9-06bb-a7b825d87bb3");
			Name = "SocialLeadGenRestProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,80,203,78,195,64,12,60,55,82,255,193,42,247,228,206,163,151,10,245,2,82,5,252,128,217,56,169,165,196,27,217,27,16,170,250,239,56,47,84,224,0,151,149,31,179,227,153,17,108,201,58,12,4,47,164,138,22,171,148,239,162,84,92,247,138,137,163,228,207,49,48,54,15,132,229,158,100,157,157,214,217,58,91,93,41,213,190,132,93,131,102,215,240,13,243,68,150,14,26,223,184,36,245,186,139,98,52,126,42,138,2,110,173,111,91,212,143,237,220,47,0,8,3,19,84,81,29,66,222,42,85,119,155,63,121,55,197,22,80,74,96,57,146,114,162,114,226,33,203,151,123,197,197,193,174,127,109,56,204,167,254,161,121,53,153,253,114,235,136,142,52,49,185,229,195,200,53,237,127,26,27,7,158,98,66,22,3,207,213,93,121,204,134,53,193,251,145,4,6,154,49,93,96,131,94,172,15,193,215,131,230,223,162,23,213,150,148,165,134,251,129,237,113,38,59,65,77,233,6,108,120,206,179,86,146,114,146,59,246,211,244,114,120,254,4,107,57,158,17,243,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb4700f9-fd00-5da9-06bb-a7b825d87bb3"));
		}

		#endregion

	}

	#endregion

}

