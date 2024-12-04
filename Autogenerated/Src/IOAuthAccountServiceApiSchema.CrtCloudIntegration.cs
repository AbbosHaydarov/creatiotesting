namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOAuthAccountServiceApiSchema

	/// <exclude/>
	public class IOAuthAccountServiceApiSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOAuthAccountServiceApiSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOAuthAccountServiceApiSchema(IOAuthAccountServiceApiSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6411d790-fc03-4c7d-b30a-460690fd5e23");
			Name = "IOAuthAccountServiceApi";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,148,193,142,211,48,16,134,207,172,180,239,48,234,94,150,75,114,103,187,145,170,10,86,57,172,88,81,94,96,154,76,186,22,206,56,120,236,46,5,237,187,51,118,210,210,82,64,192,1,46,145,61,227,252,254,255,207,78,24,123,146,1,27,130,165,15,75,235,98,91,115,160,141,199,96,28,23,105,236,59,237,202,229,197,151,203,139,23,81,12,111,224,222,181,100,165,120,71,31,35,73,144,155,243,134,12,142,133,142,58,171,157,4,234,139,165,179,150,154,36,45,197,29,49,121,211,232,26,93,117,229,105,163,85,168,223,46,98,120,92,52,141,139,28,86,228,183,166,161,197,96,116,69,89,150,48,151,216,247,232,119,213,52,127,240,110,107,90,2,195,157,243,125,182,12,157,119,61,224,40,0,168,98,196,193,52,99,79,70,193,98,47,87,30,233,13,113,109,77,163,82,83,226,95,88,81,18,250,60,120,190,167,240,232,90,121,5,15,89,98,108,126,111,55,23,22,57,58,4,7,18,208,7,80,115,217,162,243,230,243,228,222,186,167,100,239,220,223,88,25,208,99,15,172,135,118,59,243,35,255,89,53,29,132,202,97,128,198,113,64,195,39,76,112,237,226,180,219,48,192,206,69,120,66,165,163,62,142,0,145,206,139,121,153,119,248,182,161,167,16,61,75,85,179,90,102,197,226,58,205,69,4,141,167,238,118,182,74,57,50,168,55,234,124,127,240,179,178,170,230,229,254,213,164,245,227,117,144,203,169,114,125,24,237,195,76,233,94,222,252,22,207,13,5,112,156,34,124,160,92,208,27,64,34,128,12,244,73,79,148,209,194,96,49,36,38,255,146,111,242,149,61,157,144,149,224,211,71,113,71,225,125,234,93,239,7,127,159,29,173,5,220,162,53,184,182,19,5,249,47,57,165,248,211,43,148,147,215,186,139,156,95,155,250,53,199,158,124,10,53,31,161,85,7,106,114,192,38,63,225,118,69,220,142,223,104,158,63,143,127,154,147,226,243,87,183,242,132,195,0,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6411d790-fc03-4c7d-b30a-460690fd5e23"));
		}

		#endregion

	}

	#endregion

}

