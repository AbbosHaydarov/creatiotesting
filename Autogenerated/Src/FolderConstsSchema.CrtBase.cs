namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FolderConstsSchema

	/// <exclude/>
	public class FolderConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FolderConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FolderConstsSchema(FolderConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76859cd8-136b-4004-a6d6-9dceeb8425ee");
			Name = "FolderConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,208,91,107,131,48,20,7,240,103,5,191,195,161,125,217,30,82,147,57,59,101,23,104,163,142,61,236,169,253,2,169,166,37,160,137,36,202,38,163,223,125,106,237,101,149,193,88,158,78,110,231,255,227,212,70,200,29,172,26,83,241,226,209,177,29,91,178,130,155,146,165,28,214,92,107,102,212,182,154,81,37,183,98,87,107,86,9,37,193,177,191,186,135,150,235,186,240,100,234,162,96,186,121,25,246,211,97,157,138,203,26,126,158,143,30,78,103,199,174,238,69,219,178,222,228,34,5,83,181,233,41,164,57,51,6,18,149,103,92,183,44,83,153,214,99,181,32,107,228,57,130,134,8,64,103,72,140,10,38,242,46,110,156,119,21,168,57,203,148,204,27,120,173,69,6,113,247,239,144,190,110,74,254,150,193,51,72,254,209,95,222,76,150,225,195,194,15,188,57,34,52,194,40,38,132,160,16,211,57,194,152,248,126,132,253,123,138,189,201,109,63,230,63,115,207,3,58,84,255,64,191,183,230,141,250,252,149,29,134,244,206,243,9,69,9,78,130,129,29,45,23,39,54,9,48,233,217,214,222,177,247,223,252,14,120,19,50,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76859cd8-136b-4004-a6d6-9dceeb8425ee"));
		}

		#endregion

	}

	#endregion

}

