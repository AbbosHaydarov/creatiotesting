namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiOperationProviderSchema

	/// <exclude/>
	public class MultiOperationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiOperationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiOperationProviderSchema(MultiOperationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("13cc5a20-1dd4-486f-abc0-6d6d0a98a042");
			Name = "MultiOperationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,83,201,110,219,48,16,61,43,64,254,97,144,92,100,192,144,239,77,28,32,72,221,192,64,54,52,189,27,138,52,86,8,112,81,185,56,21,130,252,123,134,162,41,209,75,138,246,34,137,124,179,188,121,122,35,75,129,166,45,43,132,95,168,117,105,212,218,22,55,74,174,89,227,116,105,153,146,167,39,239,167,39,153,51,76,54,240,220,25,139,226,98,239,76,241,156,99,229,131,77,113,139,18,53,171,14,98,238,152,252,61,94,166,189,132,80,146,16,194,206,53,54,84,4,110,120,105,204,55,184,119,220,178,199,22,3,143,39,173,54,172,70,221,71,206,102,51,184,52,78,136,82,119,87,219,115,12,128,181,210,32,124,110,203,17,84,204,55,69,204,155,37,137,173,123,225,172,130,202,119,252,178,97,70,10,208,115,224,247,131,33,175,137,224,147,102,155,210,98,0,219,112,0,141,101,173,36,239,96,185,91,238,217,210,27,155,14,86,102,251,117,113,52,141,80,175,208,10,165,101,182,123,160,223,115,60,238,142,25,123,121,235,88,125,5,43,141,149,210,181,89,214,65,199,236,28,101,29,184,238,18,167,31,75,229,93,101,149,246,244,251,217,183,236,131,14,199,21,200,191,26,37,78,50,141,172,71,210,211,148,224,192,111,2,222,76,89,198,214,144,199,100,152,207,65,58,206,35,150,217,87,173,222,64,226,27,92,235,198,9,170,249,64,240,226,79,133,173,239,158,159,197,254,103,147,94,154,236,35,173,73,52,138,165,241,25,143,122,33,90,219,229,35,169,201,191,247,88,12,73,135,93,134,113,246,26,253,71,249,159,177,196,110,245,193,27,48,31,196,13,120,226,7,194,246,204,145,141,14,128,249,168,118,143,81,225,191,89,226,30,237,171,234,205,156,184,97,127,189,250,139,239,106,92,38,191,75,135,203,20,93,180,97,218,186,146,195,70,177,154,210,6,223,228,81,159,97,204,34,69,147,17,167,137,167,131,64,199,199,8,183,187,151,31,159,164,122,197,3,211,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13cc5a20-1dd4-486f-abc0-6d6d0a98a042"));
		}

		#endregion

	}

	#endregion

}

