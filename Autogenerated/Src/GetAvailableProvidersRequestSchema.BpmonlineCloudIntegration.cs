namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetAvailableProvidersRequestSchema

	/// <exclude/>
	public class GetAvailableProvidersRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetAvailableProvidersRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetAvailableProvidersRequestSchema(GetAvailableProvidersRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d23b130-a0c9-4a16-9005-a52b09ec2d91");
			Name = "GetAvailableProvidersRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,49,79,195,48,16,133,231,70,234,127,56,149,5,150,100,39,128,84,21,132,16,42,170,90,54,196,112,77,175,193,34,182,195,221,165,82,168,250,223,177,147,6,81,24,88,108,223,243,249,249,123,182,67,75,82,99,65,240,76,204,40,126,171,233,204,187,173,41,27,70,53,222,165,179,187,213,220,111,168,146,113,178,31,39,163,70,140,43,97,213,138,146,77,151,141,83,99,41,93,17,27,172,204,103,119,34,31,39,161,239,140,169,12,5,204,42,20,185,132,123,210,233,14,77,133,235,138,22,236,119,102,67,44,75,250,104,72,180,235,207,178,12,174,164,177,22,185,189,57,214,75,170,153,132,156,10,112,223,10,234,161,36,5,28,188,192,134,69,36,170,7,211,116,48,203,126,184,189,220,162,98,200,165,140,133,190,6,161,110,214,149,41,160,136,116,255,192,141,66,236,48,126,39,10,29,53,177,26,10,177,22,157,77,191,255,59,65,39,4,107,1,207,32,113,214,55,130,233,226,1,222,169,141,148,127,49,123,206,57,217,53,241,249,83,248,26,184,134,9,214,230,145,218,201,69,196,30,184,69,57,134,158,118,91,176,143,111,146,199,59,114,56,28,97,201,109,122,222,174,238,213,83,241,240,5,194,72,236,27,252,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d23b130-a0c9-4a16-9005-a52b09ec2d91"));
		}

		#endregion

	}

	#endregion

}

