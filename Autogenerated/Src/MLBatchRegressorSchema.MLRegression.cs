namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBatchRegressorSchema

	/// <exclude/>
	public class MLBatchRegressorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBatchRegressorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBatchRegressorSchema(MLBatchRegressorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b141c318-5fc2-4336-be2b-b9cb83f27062");
			Name = "MLBatchRegressor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("97d940bd-1454-46d7-84c7-92245c2594a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,146,65,107,194,64,16,133,207,10,254,135,33,189,40,148,228,222,170,7,45,5,65,69,138,61,149,30,54,235,36,46,36,187,97,118,151,98,75,255,123,103,55,169,98,196,75,96,95,102,222,188,249,118,181,168,209,54,66,34,236,145,72,88,83,184,116,105,116,161,74,79,194,41,163,211,205,122,52,252,25,13,7,222,42,93,94,85,17,62,223,209,211,87,33,157,33,133,150,43,184,230,129,176,100,47,88,86,194,218,39,216,172,23,194,201,227,27,150,132,214,26,138,53,89,150,193,212,250,186,22,116,154,119,231,174,34,180,170,186,169,176,70,237,208,197,92,80,24,98,35,200,131,19,52,132,7,37,99,222,127,171,172,231,53,181,136,162,178,6,36,97,49,75,238,175,155,118,241,182,190,70,82,114,215,90,27,74,32,11,94,31,47,88,8,95,185,133,210,7,222,124,236,78,13,154,98,188,234,186,206,229,147,71,216,50,92,152,113,74,30,97,157,77,47,235,236,200,228,188,206,158,123,39,159,108,218,248,188,82,18,100,224,115,131,7,206,196,250,145,184,147,175,134,191,23,194,97,18,249,240,147,65,239,162,109,91,209,231,27,133,149,86,78,137,74,125,163,5,1,26,191,64,113,191,208,252,30,76,1,238,136,17,91,135,172,159,43,201,230,109,226,192,252,22,122,171,52,130,68,13,154,73,204,18,111,145,56,160,198,120,83,201,124,207,254,65,3,121,22,211,105,22,59,162,65,71,165,63,119,252,126,229,19,45,46,199,9,227,202,133,197,113,95,14,143,120,240,219,225,66,125,104,137,197,115,171,94,139,172,253,1,205,242,222,10,29,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b141c318-5fc2-4336-be2b-b9cb83f27062"));
		}

		#endregion

	}

	#endregion

}

