namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportEntitiesChunkProcessorSchema

	/// <exclude/>
	public class IFileImportEntitiesChunkProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportEntitiesChunkProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportEntitiesChunkProcessorSchema(IFileImportEntitiesChunkProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cea1c9a4-d455-4ca6-92a0-f145d998b68e");
			Name = "IFileImportEntitiesChunkProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,203,106,195,48,16,60,39,144,127,88,146,75,123,177,239,169,27,40,193,165,62,20,12,233,15,40,246,198,17,181,37,179,43,153,154,210,127,175,44,57,118,95,148,156,132,102,102,103,119,86,82,162,65,110,69,129,240,130,68,130,245,201,68,123,173,78,178,178,36,140,212,42,122,148,53,102,77,171,201,172,150,239,171,229,194,178,84,21,28,122,54,216,220,173,150,14,217,16,86,78,9,144,41,131,116,114,102,91,200,230,178,84,25,105,36,242,254,108,213,107,78,186,64,102,77,190,178,181,199,90,22,32,47,117,215,148,45,134,33,166,158,105,135,202,48,108,33,247,86,3,133,3,20,136,39,161,202,26,41,249,226,216,31,68,135,165,103,31,168,226,29,252,226,66,168,107,108,82,34,77,255,88,121,126,180,219,160,42,195,204,227,157,66,128,103,52,103,93,242,28,96,32,227,56,134,132,109,211,8,234,119,23,32,125,195,194,26,4,233,187,128,235,234,247,3,199,30,90,193,140,165,59,200,61,167,219,37,71,147,75,252,211,38,241,42,80,78,121,191,14,94,249,84,183,222,37,177,231,189,188,211,178,132,113,245,254,25,110,66,194,89,63,14,51,3,183,127,199,253,8,31,229,27,232,176,79,241,138,182,140,126,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cea1c9a4-d455-4ca6-92a0-f145d998b68e"));
		}

		#endregion

	}

	#endregion

}

