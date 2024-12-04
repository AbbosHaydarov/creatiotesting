namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetAvailableProvidersResponseSchema

	/// <exclude/>
	public class GetAvailableProvidersResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetAvailableProvidersResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetAvailableProvidersResponseSchema(GetAvailableProvidersResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a32e2754-ebd1-43a6-8c8d-70af49bb850d");
			Name = "GetAvailableProvidersResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,84,77,111,219,48,12,61,59,64,254,3,209,93,54,160,176,239,75,22,96,72,139,34,135,22,69,178,219,176,131,34,211,137,0,89,50,68,41,69,87,244,191,143,82,172,124,182,24,86,4,216,197,54,41,242,241,61,146,178,17,45,82,39,36,194,15,116,78,144,109,124,57,181,166,81,171,224,132,87,214,148,211,219,197,189,173,81,211,112,240,50,28,20,129,148,89,193,226,153,60,182,28,169,53,202,24,70,229,29,26,116,74,142,78,99,230,193,120,213,98,185,224,83,161,213,239,132,202,81,28,247,201,225,138,13,152,106,65,244,21,238,208,127,223,8,165,197,82,227,163,179,27,85,163,163,57,211,99,120,76,9,85,85,193,152,66,219,10,247,60,233,237,57,118,14,9,141,39,240,107,4,254,14,218,131,109,146,229,215,206,122,175,35,29,146,107,172,131,198,50,227,84,7,64,63,111,132,23,172,219,59,33,253,47,118,116,97,169,149,4,25,153,253,141,88,193,125,225,231,78,14,135,116,232,188,66,214,244,152,112,182,231,167,236,147,131,177,9,172,3,138,239,72,89,238,122,26,69,136,92,23,90,254,136,58,186,76,32,10,57,87,178,149,114,143,237,18,221,231,7,158,46,124,131,43,113,198,254,234,75,84,153,101,206,110,77,104,209,197,136,113,14,153,153,198,78,224,92,55,188,192,10,253,40,18,30,193,107,175,28,77,189,21,159,236,173,247,208,89,156,79,251,176,206,255,28,238,49,143,203,205,82,192,70,232,128,160,76,173,36,47,61,179,124,90,35,243,118,137,124,30,35,40,226,145,27,195,35,199,250,157,145,38,79,66,219,155,114,226,93,192,113,37,39,160,154,247,17,71,96,99,201,39,69,120,29,147,26,161,41,101,29,148,218,35,191,181,59,138,166,25,236,120,105,150,214,106,152,237,79,79,23,163,40,46,222,168,26,27,17,23,160,225,220,157,68,16,82,90,254,201,92,172,121,125,149,75,180,238,102,11,245,102,227,250,179,143,182,45,178,54,177,80,127,27,178,130,127,248,45,228,148,104,31,83,36,239,226,28,242,221,72,9,31,185,247,195,193,235,31,47,203,158,37,98,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a32e2754-ebd1-43a6-8c8d-70af49bb850d"));
		}

		#endregion

	}

	#endregion

}

