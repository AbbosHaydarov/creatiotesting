namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SentSinceAndDraftsSyncStrategySchema

	/// <exclude/>
	public class SentSinceAndDraftsSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SentSinceAndDraftsSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SentSinceAndDraftsSyncStrategySchema(SentSinceAndDraftsSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6a52f3c-de2d-4d94-bc45-c093e0898f55");
			Name = "SentSinceAndDraftsSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,84,93,107,219,48,20,125,118,161,255,225,226,189,36,144,197,123,206,154,192,154,120,80,88,67,135,147,167,178,7,197,190,246,196,108,201,92,201,163,166,228,191,239,202,118,82,53,75,210,23,99,73,247,227,220,115,142,164,68,133,166,22,41,194,6,137,132,209,185,157,62,10,89,222,222,188,222,222,4,141,145,170,240,78,150,90,229,178,104,72,88,169,213,215,179,1,132,151,246,167,177,178,210,74,52,23,3,190,139,212,106,234,35,56,230,19,97,193,125,96,89,10,99,102,144,160,178,137,84,41,126,83,217,138,68,110,77,210,170,52,177,140,6,139,182,203,136,162,8,238,76,83,85,130,218,197,113,141,8,41,97,62,15,31,252,132,48,90,128,172,234,18,43,174,43,164,213,106,2,25,150,242,47,18,102,144,147,174,252,212,21,231,220,11,131,217,17,197,73,173,233,161,93,116,218,159,144,151,127,204,97,125,125,12,104,184,7,88,13,6,75,76,45,136,178,4,165,237,103,70,134,150,79,88,45,35,10,52,147,161,26,211,200,218,25,174,9,25,23,120,67,225,117,125,94,97,46,154,210,222,75,149,49,235,35,219,214,168,243,209,59,54,198,19,88,179,21,96,14,225,117,128,225,248,23,151,172,155,93,41,83,72,157,50,31,77,52,131,235,228,113,57,246,26,127,143,130,63,145,174,145,108,59,115,127,150,105,192,172,15,56,213,119,32,84,80,250,27,240,165,38,38,199,229,91,100,93,7,54,254,23,37,168,15,69,65,179,216,36,51,38,208,146,243,227,86,25,6,246,104,138,190,230,207,6,169,5,119,17,130,160,64,59,252,5,132,182,33,5,225,118,189,138,127,196,155,120,5,73,188,222,36,15,235,101,12,175,95,246,161,243,119,16,236,221,119,63,12,134,42,235,103,123,63,40,223,39,238,220,56,215,179,193,159,58,82,175,76,186,36,228,169,140,239,203,15,196,114,30,231,22,130,3,46,144,209,237,212,130,68,5,138,13,48,15,217,128,196,184,20,51,196,16,195,197,150,215,144,30,55,166,119,81,23,125,62,217,184,230,104,45,147,105,194,133,135,211,189,41,59,253,210,129,59,156,251,224,252,170,131,185,174,143,54,114,184,222,112,186,123,227,45,39,208,61,54,45,248,128,198,157,46,51,216,177,21,71,167,241,239,2,123,165,207,139,215,239,250,155,251,127,38,12,143,54,69,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6a52f3c-de2d-4d94-bc45-c093e0898f55"));
		}

		#endregion

	}

	#endregion

}

