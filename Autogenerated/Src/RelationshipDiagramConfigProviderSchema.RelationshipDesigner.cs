namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RelationshipDiagramConfigProviderSchema

	/// <exclude/>
	public class RelationshipDiagramConfigProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RelationshipDiagramConfigProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RelationshipDiagramConfigProviderSchema(RelationshipDiagramConfigProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd23d878-8d9c-8ece-5b7d-37cf027c27fd");
			Name = "RelationshipDiagramConfigProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("32e5a92e-2a79-472b-b08d-f730aa69067f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,77,111,155,64,16,61,59,82,254,195,138,147,45,5,7,176,113,220,90,62,216,94,28,33,69,149,21,183,189,84,61,108,97,192,43,193,46,218,143,84,86,229,255,222,229,163,9,196,180,78,115,1,118,121,239,205,188,157,153,101,36,7,89,144,8,208,103,16,130,72,158,168,241,134,179,132,166,90,16,69,57,27,63,66,86,125,200,3,45,48,72,154,50,16,215,87,191,174,175,6,90,82,150,162,253,81,42,200,23,207,235,182,142,128,241,150,68,138,11,10,210,32,12,166,208,63,50,26,161,40,35,82,34,76,73,42,72,222,137,103,48,165,246,31,96,192,20,85,199,14,2,109,169,144,234,1,158,32,171,247,81,69,24,164,160,22,72,154,71,185,58,93,208,216,67,196,89,252,6,145,211,121,218,61,122,175,178,190,215,52,70,251,232,0,57,249,18,198,151,242,147,74,148,7,135,169,44,50,114,252,74,50,13,27,158,233,156,253,133,120,78,13,115,146,254,155,211,245,65,153,2,145,148,85,15,59,229,109,215,99,39,248,19,141,203,90,215,214,250,138,133,238,65,117,54,134,163,197,115,172,111,24,18,162,51,181,166,44,54,73,14,213,177,0,158,12,47,71,28,141,190,191,62,242,139,28,244,241,63,172,52,210,111,116,212,156,168,0,165,5,67,12,126,246,19,107,212,224,172,57,151,21,165,175,7,27,198,224,165,81,150,85,231,140,119,68,72,24,90,158,143,239,54,238,106,109,187,56,112,236,169,239,184,246,122,234,120,182,227,5,78,224,175,238,60,60,11,172,209,13,186,189,37,81,196,53,83,141,94,79,35,45,145,245,201,76,186,117,211,64,194,86,195,152,127,171,154,255,192,83,30,198,86,141,57,53,216,243,73,121,191,35,119,182,14,38,51,223,181,231,219,192,179,167,174,255,193,158,99,236,216,171,185,51,193,211,217,124,130,241,164,118,100,98,42,115,115,188,219,209,238,192,85,203,75,245,58,181,135,193,108,253,6,75,121,192,91,252,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd23d878-8d9c-8ece-5b7d-37cf027c27fd"));
		}

		#endregion

	}

	#endregion

}

