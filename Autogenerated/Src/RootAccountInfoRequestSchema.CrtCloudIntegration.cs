namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RootAccountInfoRequestSchema

	/// <exclude/>
	public class RootAccountInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RootAccountInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RootAccountInfoRequestSchema(RootAccountInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab1e6279-d876-431e-a833-76ede3fe1e04");
			Name = "RootAccountInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e340cd47-dd91-41d9-9076-90ff98ffd14e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,148,77,107,194,64,16,134,207,6,252,15,3,94,139,185,87,17,36,133,18,40,173,248,113,42,61,172,155,73,92,136,187,233,236,68,17,241,191,119,179,137,86,219,90,180,31,151,36,51,153,247,157,103,39,67,180,88,162,45,132,68,152,34,145,176,38,229,110,100,116,170,178,146,4,43,163,219,193,182,29,180,131,86,135,48,115,33,68,185,176,246,22,198,198,240,80,74,83,106,142,117,106,198,248,90,162,101,95,25,134,33,244,109,185,92,10,218,12,154,248,110,250,4,84,215,64,106,8,68,45,237,238,203,195,163,250,162,156,231,74,130,172,26,157,237,211,170,169,14,88,35,50,5,18,43,116,108,35,111,80,191,255,8,227,19,247,200,22,28,133,173,238,188,64,144,132,213,97,97,54,126,168,144,62,51,237,161,44,147,210,25,68,117,253,140,114,216,66,134,220,171,172,122,176,187,180,167,128,149,200,75,4,165,19,37,157,147,179,92,47,208,145,16,60,23,85,180,7,82,218,178,208,18,95,190,199,154,27,147,195,200,9,27,176,184,145,253,140,238,120,34,50,87,168,25,84,226,174,42,85,72,215,204,39,242,226,56,249,51,12,139,46,193,215,35,76,188,238,247,24,245,24,120,227,222,208,202,125,172,43,247,37,110,228,19,175,254,143,237,225,133,178,135,165,1,247,44,36,171,21,94,176,61,177,29,250,210,255,71,210,200,32,13,157,131,242,25,239,118,8,1,250,114,192,84,98,63,148,3,80,233,121,207,30,152,170,233,90,89,188,169,68,169,200,173,87,29,53,123,247,62,61,255,35,114,228,44,190,26,64,7,117,82,255,104,124,92,103,79,147,187,118,240,6,171,131,208,24,76,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab1e6279-d876-431e-a833-76ede3fe1e04"));
		}

		#endregion

	}

	#endregion

}

