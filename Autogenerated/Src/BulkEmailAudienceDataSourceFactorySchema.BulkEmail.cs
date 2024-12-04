namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailAudienceDataSourceFactorySchema

	/// <exclude/>
	public class BulkEmailAudienceDataSourceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailAudienceDataSourceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailAudienceDataSourceFactorySchema(BulkEmailAudienceDataSourceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c1f0d41-7ba2-4160-96b6-1a7c839825bf");
			Name = "BulkEmailAudienceDataSourceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93656b7c-51ad-4950-bd26-b581bae6f796");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,77,111,211,64,16,61,167,82,255,195,200,61,144,74,145,45,196,161,82,155,70,130,20,144,15,5,36,183,226,80,113,216,216,227,100,133,189,107,118,118,169,2,234,127,239,172,63,82,167,73,218,32,65,79,220,60,187,51,111,230,189,121,94,37,74,164,74,164,8,87,104,140,32,157,219,112,170,85,46,231,206,8,43,181,58,60,248,125,120,48,112,36,213,28,146,37,89,44,207,86,241,84,27,228,136,227,35,131,115,78,134,88,89,52,57,195,157,66,124,41,100,193,89,111,93,38,81,165,120,33,172,72,180,51,41,126,16,169,213,102,89,23,70,81,4,99,114,101,41,204,114,210,198,113,89,21,88,162,178,4,121,147,10,86,67,106,80,88,4,169,200,10,134,35,208,57,87,34,250,139,252,60,216,221,46,136,38,97,215,41,234,181,186,249,60,35,93,160,197,97,240,85,22,5,204,16,12,150,250,39,102,32,114,166,1,39,225,235,147,240,77,112,252,141,147,43,55,43,100,10,105,33,136,224,157,43,190,191,47,185,223,78,110,123,208,31,109,164,36,72,196,34,98,182,69,170,129,223,194,74,102,222,16,89,227,252,29,157,194,151,122,182,90,206,13,61,235,131,11,204,133,43,44,164,15,101,33,76,107,61,9,132,90,105,234,37,181,11,220,131,159,23,116,83,209,78,165,231,235,135,199,80,19,186,107,166,62,66,149,53,212,124,212,103,122,137,118,161,179,125,72,246,92,83,214,69,61,211,40,188,93,35,249,39,190,217,66,179,62,169,132,17,37,40,254,127,206,3,71,104,120,39,10,83,255,203,4,147,107,142,95,145,215,187,61,10,199,81,157,191,189,124,214,233,21,103,193,228,138,23,224,148,252,225,216,235,25,211,145,185,100,47,182,155,241,153,128,62,245,25,68,97,211,69,34,127,97,131,71,252,229,33,42,49,71,47,11,171,146,109,2,24,180,206,40,154,124,218,173,214,19,155,101,185,198,81,7,209,97,246,76,177,91,232,214,138,113,219,114,120,189,166,38,172,139,59,130,143,78,102,208,147,108,196,195,90,88,49,110,157,53,104,70,169,87,255,196,212,195,199,232,107,192,15,160,103,61,183,190,152,253,224,86,218,5,80,243,44,196,25,144,171,42,109,236,127,87,190,160,43,147,238,81,254,75,246,108,19,86,75,253,39,118,29,245,240,251,206,237,191,179,28,55,167,235,135,119,247,92,196,100,171,18,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c1f0d41-7ba2-4160-96b6-1a7c839825bf"));
		}

		#endregion

	}

	#endregion

}

