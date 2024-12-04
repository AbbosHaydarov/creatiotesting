namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichTextDataResponseSchema

	/// <exclude/>
	public class EnrichTextDataResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichTextDataResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichTextDataResponseSchema(EnrichTextDataResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("292254cb-473a-40ba-91c0-ffcaaa382dcd");
			Name = "EnrichTextDataResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,77,79,235,48,16,60,7,137,255,176,10,151,246,146,220,121,109,37,196,151,144,0,33,224,246,244,14,198,217,180,22,142,29,217,155,62,62,196,127,103,237,24,148,182,180,192,37,178,55,179,227,217,217,49,162,65,223,10,137,112,143,206,9,111,107,42,142,173,169,213,188,115,130,148,53,251,123,175,251,123,89,231,149,153,195,221,179,39,108,254,172,221,25,175,53,202,0,246,197,57,26,116,74,110,96,110,59,67,170,193,226,142,255,10,173,94,34,55,163,24,119,224,112,206,23,56,214,194,251,67,56,53,220,191,184,199,39,58,17,36,110,89,29,243,98,68,150,101,9,19,223,53,141,112,207,179,116,239,225,64,140,135,138,27,0,53,54,104,200,131,252,148,85,124,244,150,131,230,191,129,158,71,37,39,36,253,227,66,219,61,104,37,65,6,25,91,85,100,236,6,127,63,69,223,56,219,162,35,133,172,252,38,18,244,255,215,165,166,2,34,72,135,245,52,239,249,195,243,252,250,5,59,148,67,57,3,197,7,15,90,121,10,146,55,53,247,162,175,176,121,64,55,186,230,213,193,20,242,48,117,62,14,19,124,140,112,201,4,147,213,9,194,19,51,8,39,8,251,204,178,57,82,88,82,150,249,116,120,219,33,252,210,218,199,174,133,165,208,29,122,176,53,8,41,45,111,212,3,45,4,129,67,205,251,92,34,144,101,215,227,72,191,208,95,51,83,117,148,8,183,14,146,0,253,28,103,195,150,111,6,58,64,83,245,203,90,221,28,123,239,201,117,146,172,91,219,93,122,252,235,8,140,198,233,189,232,229,20,12,254,223,234,247,104,252,19,33,87,72,11,91,253,36,63,71,85,229,97,210,10,39,26,14,17,24,54,112,154,135,204,228,156,29,246,126,144,175,160,33,84,119,100,41,86,34,217,144,105,182,51,164,33,163,108,155,48,18,139,73,25,155,35,87,178,108,105,85,21,84,142,54,205,136,217,30,122,87,4,92,44,110,51,41,213,86,125,123,123,7,175,45,156,55,178,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("292254cb-473a-40ba-91c0-ffcaaa382dcd"));
		}

		#endregion

	}

	#endregion

}

