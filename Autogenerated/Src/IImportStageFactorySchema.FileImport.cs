namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportStageFactorySchema

	/// <exclude/>
	public class IImportStageFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportStageFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportStageFactorySchema(IImportStageFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("65f0da7e-4515-4c52-863a-8b3f9080781c");
			Name = "IImportStageFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,203,106,195,48,16,60,199,224,127,16,185,180,133,16,127,64,19,67,106,26,240,173,244,241,1,27,101,109,4,150,100,118,165,131,41,249,247,74,86,210,56,169,161,55,105,53,59,51,59,43,3,26,185,7,137,226,19,137,128,109,227,214,149,53,141,106,61,129,83,214,172,247,170,195,90,247,150,92,158,125,231,217,194,179,50,237,13,154,240,57,207,194,75,81,20,98,195,94,107,160,161,60,223,223,177,39,100,52,142,133,50,14,169,137,82,141,37,33,9,193,133,99,96,23,106,164,127,96,193,14,90,228,11,85,49,225,234,253,161,83,114,194,81,39,79,31,177,99,15,210,89,26,2,44,26,252,227,99,44,84,73,47,73,37,33,113,24,132,58,254,118,76,229,82,165,7,2,45,76,136,104,187,84,87,185,101,185,41,198,167,121,164,103,164,16,161,65,25,243,251,7,44,109,231,181,225,55,178,18,153,45,205,192,9,157,39,195,229,134,17,99,108,205,118,249,2,140,215,189,36,83,69,232,188,64,99,111,61,3,58,167,48,169,60,222,33,248,213,120,125,78,105,44,172,196,215,205,60,226,118,188,85,148,10,98,85,154,99,215,182,132,45,132,109,236,142,208,135,93,137,251,1,159,194,95,89,156,242,236,244,3,223,50,183,7,122,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65f0da7e-4515-4c52-863a-8b3f9080781c"));
		}

		#endregion

	}

	#endregion

}

