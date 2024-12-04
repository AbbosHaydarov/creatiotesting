namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportParamsGeneratorSchema

	/// <exclude/>
	public class IImportParamsGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportParamsGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportParamsGeneratorSchema(IImportParamsGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36bfcac9-e88e-4dbb-b7ce-a67ca5579bb2");
			Name = "IImportParamsGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,82,177,110,194,48,16,157,131,196,63,156,96,105,37,148,236,45,101,161,20,49,84,66,2,117,119,195,17,44,197,118,116,118,144,80,213,127,175,125,78,2,45,37,91,165,78,201,157,223,189,123,239,217,90,40,180,149,200,17,182,72,36,172,217,187,116,110,244,94,22,53,9,39,141,30,14,62,134,131,164,182,82,23,176,57,89,135,202,159,151,37,230,225,208,166,75,212,72,50,127,236,48,55,104,210,23,89,226,74,85,134,220,239,88,194,116,161,157,116,18,173,7,120,200,152,176,240,131,176,210,14,105,239,21,62,192,42,18,172,5,9,101,121,179,112,134,24,157,101,25,76,109,173,148,160,211,172,169,215,100,142,114,135,22,20,186,131,217,89,216,27,2,201,20,80,49,7,20,145,36,8,108,73,178,11,150,170,126,47,101,14,178,149,112,83,65,18,66,234,36,251,197,21,82,176,194,218,174,196,113,99,137,206,130,59,32,228,166,172,149,134,163,40,107,180,65,198,181,142,216,97,68,87,110,123,70,207,200,103,201,23,229,121,166,214,145,15,125,2,241,59,131,57,15,191,241,44,176,254,164,64,190,157,228,51,234,30,163,222,69,75,77,221,248,123,141,121,134,86,143,61,14,7,163,71,142,27,125,138,189,6,25,5,218,35,159,70,209,211,104,22,108,54,254,166,25,3,126,199,99,120,60,167,77,126,64,37,226,84,236,128,229,214,245,48,161,171,73,219,217,52,107,255,194,209,197,253,178,220,206,199,185,117,183,184,88,213,108,137,197,4,122,226,142,38,238,227,227,254,155,204,240,31,100,208,26,252,241,118,226,139,250,222,244,189,47,56,73,34,114,127,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36bfcac9-e88e-4dbb-b7ce-a67ca5579bb2"));
		}

		#endregion

	}

	#endregion

}

