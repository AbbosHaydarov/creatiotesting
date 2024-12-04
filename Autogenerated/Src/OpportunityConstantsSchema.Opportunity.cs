namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityConstantsSchema

	/// <exclude/>
	public class OpportunityConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityConstantsSchema(OpportunityConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff91c21e-dcda-4052-875f-3134d07a6a12");
			Name = "OpportunityConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,146,221,106,220,48,16,133,175,109,240,59,136,92,181,23,147,149,45,89,182,104,19,8,78,92,2,41,133,180,208,107,89,63,139,131,45,45,150,76,88,66,222,61,218,117,8,217,133,208,80,22,196,32,70,103,206,249,16,51,251,222,174,209,239,173,15,122,252,150,165,89,106,197,168,253,70,72,141,254,232,105,18,222,153,112,222,56,107,250,245,60,137,208,59,155,165,79,89,154,108,230,110,232,37,242,33,246,36,146,131,240,30,253,218,108,220,20,102,219,135,109,156,136,79,54,248,40,221,201,147,213,106,133,190,251,121,28,197,180,189,92,26,168,25,156,215,10,77,250,65,203,16,47,113,98,173,207,223,212,171,247,242,195,188,73,11,229,236,176,69,63,230,94,29,228,238,45,239,95,29,111,21,186,64,86,63,238,101,95,206,42,194,218,146,182,215,112,83,80,12,148,181,53,212,77,213,0,199,140,53,4,95,181,109,201,207,190,238,127,225,31,192,147,155,79,12,188,56,30,1,115,209,153,130,18,9,70,226,8,92,74,3,181,46,106,144,170,99,76,242,2,215,29,254,12,240,163,179,167,99,253,235,236,17,38,195,170,36,57,150,80,118,154,129,50,121,14,188,202,59,192,56,87,12,107,78,106,201,62,131,25,107,56,29,231,93,116,59,2,21,92,8,163,140,134,162,160,5,80,19,75,45,85,9,133,208,164,227,101,201,84,181,44,64,146,124,132,122,173,141,152,135,240,62,238,167,115,10,245,227,255,97,47,126,59,139,219,157,195,17,48,38,149,33,130,115,144,21,169,129,230,204,128,160,172,3,149,27,204,53,161,28,203,101,1,146,231,44,141,231,5,135,72,54,218,206,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff91c21e-dcda-4052-875f-3134d07a6a12"));
		}

		#endregion

	}

	#endregion

}

