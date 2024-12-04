namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportDataChunkSchema

	/// <exclude/>
	public class ImportDataChunkSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportDataChunkSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportDataChunkSchema(ImportDataChunkSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd201402-92ae-464e-8ec8-0ef3cbe29b35");
			Name = "ImportDataChunk";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,187,110,194,48,20,134,103,144,120,135,35,186,86,68,109,183,18,88,40,173,144,58,32,37,91,213,193,36,135,212,34,182,35,95,134,20,241,238,245,37,129,42,80,72,23,75,57,254,143,255,239,92,194,9,67,85,145,12,33,69,41,137,18,91,61,89,8,190,165,133,145,68,83,193,39,175,180,196,21,171,132,212,163,225,126,52,28,24,69,121,1,73,173,52,178,233,104,104,35,119,18,11,171,132,37,55,236,25,130,118,241,101,248,46,209,68,163,151,84,102,83,210,12,208,42,46,8,6,238,221,65,42,214,82,100,168,20,204,224,225,222,69,86,252,20,121,244,145,230,27,115,27,121,178,129,67,0,64,158,7,134,235,60,105,93,93,197,9,247,129,230,93,136,157,169,142,40,75,174,169,174,29,199,45,215,69,73,148,106,109,95,136,38,254,105,47,137,162,8,98,101,24,35,178,158,55,223,254,22,196,22,114,43,5,234,179,38,173,54,234,136,99,109,9,43,34,9,3,110,7,55,27,167,227,121,28,29,131,78,246,145,160,164,164,164,223,100,83,226,231,169,214,204,97,117,169,226,116,222,214,219,226,219,14,87,40,53,69,91,195,218,167,122,244,51,118,31,72,236,44,92,210,42,119,21,156,224,207,233,91,140,55,67,243,134,162,73,182,185,123,40,80,79,65,185,227,240,167,89,232,84,176,234,52,235,134,159,207,236,237,227,151,18,178,118,46,193,5,174,219,116,119,26,194,217,207,208,141,3,220,16,251,54,177,179,178,224,143,127,120,245,180,73,131,186,243,176,95,150,95,171,127,241,111,56,252,0,171,74,227,87,88,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd201402-92ae-464e-8ec8-0ef3cbe29b35"));
		}

		#endregion

	}

	#endregion

}

