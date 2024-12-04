namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportParametersRepositorySchema

	/// <exclude/>
	public class IImportParametersRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportParametersRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportParametersRepositorySchema(IImportParametersRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0944487b-5887-4694-84cc-de8e541b2ac6");
			Name = "IImportParametersRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a83ae89b-1206-453d-b626-f37ab41fffbf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,84,77,79,227,48,16,61,183,82,255,195,136,19,43,85,201,125,201,246,2,108,229,211,34,186,31,103,55,158,20,107,29,59,178,29,80,132,248,239,107,199,73,155,47,160,237,34,78,145,199,51,239,189,121,25,143,164,57,154,130,166,8,63,81,107,106,84,102,163,107,37,51,190,43,53,181,92,201,232,59,23,72,242,66,105,187,152,63,47,230,179,210,112,185,131,77,101,44,230,87,131,179,43,21,2,83,95,103,162,53,74,212,60,29,229,144,31,46,228,130,69,185,21,60,5,46,45,234,204,43,32,129,230,142,106,39,202,5,205,61,22,202,112,171,116,5,95,129,220,74,203,109,117,136,37,195,244,149,3,245,10,103,113,28,67,98,202,60,167,186,90,181,129,95,5,163,22,193,88,186,67,80,25,240,186,26,12,26,227,228,238,203,226,97,93,82,120,2,144,142,228,219,5,103,23,171,36,174,35,211,9,18,159,130,172,141,231,233,39,63,42,206,26,25,157,156,203,117,233,194,156,45,225,224,116,125,97,110,101,233,96,123,128,95,130,117,211,29,222,160,112,62,64,177,55,4,50,165,207,236,51,80,134,26,194,38,250,8,100,141,248,126,246,155,34,215,104,77,171,41,165,50,69,1,153,160,187,232,35,132,213,217,26,109,169,165,89,145,49,71,18,183,151,62,123,171,148,240,114,136,33,93,208,235,186,0,217,233,173,53,19,230,169,26,90,100,231,79,218,176,81,210,67,1,194,162,147,6,241,55,21,37,78,25,63,250,179,193,128,158,39,103,123,81,104,149,186,124,167,118,108,68,244,73,78,52,26,58,149,173,42,46,221,54,112,205,14,33,70,15,245,174,133,152,52,98,9,117,116,207,115,244,252,119,94,234,19,183,15,29,93,169,202,11,255,190,222,242,168,157,229,27,94,47,92,119,23,80,254,98,5,220,76,53,9,84,50,120,12,131,48,33,98,240,62,14,184,137,239,111,9,163,125,235,155,249,227,40,91,123,246,178,47,223,179,0,50,183,235,32,211,42,7,182,61,166,201,251,250,27,202,140,213,72,243,129,218,77,29,244,216,126,141,134,211,233,99,219,172,208,99,213,253,199,152,118,150,168,23,252,170,212,217,203,98,254,242,15,136,115,246,238,166,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0944487b-5887-4694-84cc-de8e541b2ac6"));
		}

		#endregion

	}

	#endregion

}

