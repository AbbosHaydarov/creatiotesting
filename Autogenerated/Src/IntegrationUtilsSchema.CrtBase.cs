namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationUtilsSchema

	/// <exclude/>
	public class IntegrationUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationUtilsSchema(IntegrationUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4eda3c2-a9cc-455c-a6b6-3d2187c88a64");
			Name = "IntegrationUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,81,107,131,48,16,199,159,43,248,29,66,159,44,148,124,129,178,151,214,110,20,182,14,106,187,61,103,241,116,1,77,228,146,116,200,232,119,95,76,108,87,199,4,95,140,151,187,223,221,63,249,199,106,33,75,146,181,218,64,189,138,35,235,195,35,32,50,173,10,67,55,10,97,100,155,166,235,91,38,240,52,101,134,185,189,56,146,172,6,221,48,14,3,70,22,162,180,200,140,80,50,142,190,227,104,214,216,143,74,112,194,43,166,53,217,73,3,101,200,158,140,168,180,203,119,53,215,34,109,92,138,147,179,18,57,121,71,97,32,107,37,63,128,182,149,73,78,26,208,181,151,192,59,154,216,65,184,36,79,214,49,218,75,236,131,92,224,32,137,190,79,31,168,6,130,140,165,27,138,221,241,114,208,28,69,211,237,45,58,73,94,215,236,204,240,94,244,179,42,51,254,9,53,35,15,127,20,208,173,52,194,180,33,251,194,36,43,1,233,163,144,249,78,186,83,73,14,235,118,239,46,44,153,15,187,205,23,171,145,57,110,194,127,131,233,6,129,25,8,211,146,161,134,190,215,16,163,25,152,20,138,141,170,108,45,223,88,101,65,39,163,133,119,85,3,165,193,251,93,62,119,215,229,127,167,117,72,175,22,120,242,102,200,52,248,224,253,242,100,176,110,26,246,122,117,214,147,55,159,167,193,91,68,133,233,239,75,232,84,223,189,139,105,135,118,246,56,174,91,142,162,6,122,50,124,175,190,70,88,118,134,222,141,139,251,92,102,113,116,249,1,34,254,199,86,174,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4eda3c2-a9cc-455c-a6b6-3d2187c88a64"));
		}

		#endregion

	}

	#endregion

}

