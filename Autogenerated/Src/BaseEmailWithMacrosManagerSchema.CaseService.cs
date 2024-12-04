namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseEmailWithMacrosManagerSchema

	/// <exclude/>
	public class BaseEmailWithMacrosManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseEmailWithMacrosManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseEmailWithMacrosManagerSchema(BaseEmailWithMacrosManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c02f3b0c-eb83-4c52-8f82-1f769b555a1b");
			Name = "BaseEmailWithMacrosManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,83,193,106,219,64,16,61,59,144,127,24,210,139,4,69,135,30,221,82,72,69,218,94,76,2,113,218,67,201,97,180,26,219,75,215,187,98,102,100,87,148,252,123,71,81,156,68,50,49,244,56,79,111,246,205,155,55,138,184,37,105,208,17,44,137,25,37,173,180,40,83,92,249,117,203,168,62,197,243,179,191,231,103,179,86,124,92,195,109,39,74,219,143,147,218,248,33,144,235,201,82,124,163,72,236,221,11,167,76,76,227,170,184,138,234,213,147,76,224,175,232,52,241,8,95,160,15,197,45,197,154,248,72,117,73,127,212,64,131,223,49,173,77,28,202,128,34,115,248,130,66,87,91,235,252,233,117,179,64,199,73,22,24,113,77,252,200,254,117,93,73,10,164,148,93,148,45,51,69,5,237,26,2,47,208,10,213,144,98,232,96,149,24,116,67,80,161,251,189,71,174,193,165,109,99,251,168,124,240,218,21,112,39,4,37,235,219,82,224,163,77,137,245,69,126,111,154,77,91,5,239,0,43,81,54,151,224,250,73,79,12,250,105,57,148,55,156,28,137,36,254,60,63,45,119,220,96,170,179,253,134,216,130,157,124,130,57,220,169,15,82,12,248,119,10,13,241,143,15,239,33,210,62,203,173,207,2,239,187,159,215,106,185,42,183,125,56,182,93,123,70,45,108,170,7,82,115,40,79,184,201,114,232,111,104,246,240,31,45,182,96,54,225,56,220,85,159,204,171,50,159,91,48,66,217,4,125,82,129,167,241,237,108,6,7,99,59,11,210,77,170,79,57,73,59,251,21,124,77,32,132,193,234,199,123,237,44,0,66,165,75,211,218,89,57,128,7,107,51,38,109,217,118,53,226,100,121,127,181,199,190,119,158,181,197,0,7,222,81,219,248,209,222,107,241,134,58,202,243,43,175,181,38,230,7,116,12,62,252,3,168,205,116,211,251,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c02f3b0c-eb83-4c52-8f82-1f769b555a1b"));
		}

		#endregion

	}

	#endregion

}

