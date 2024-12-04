namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationRequestSchema

	/// <exclude/>
	public class IntegrationRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationRequestSchema(IntegrationRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0");
			Name = "IntegrationRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,65,107,195,48,12,133,207,11,228,63,8,118,79,238,237,216,37,133,50,40,172,116,253,3,90,162,100,6,199,202,36,123,99,148,253,247,57,118,91,210,109,39,91,79,143,167,239,57,28,73,39,108,9,142,36,130,202,189,175,26,118,189,25,130,160,55,236,170,23,110,13,218,29,97,183,37,87,22,167,178,40,139,187,123,161,33,46,161,177,168,186,130,39,231,105,200,254,3,189,7,82,159,92,117,93,195,131,134,113,68,249,122,60,207,141,229,208,129,100,23,108,142,207,240,105,252,27,24,215,179,140,41,1,184,143,227,53,176,186,4,213,139,164,41,188,90,211,66,59,159,255,231,58,172,224,6,251,16,181,189,240,135,233,72,226,127,98,167,20,83,114,151,107,153,232,152,72,188,161,216,104,159,14,228,253,239,26,73,216,146,87,96,1,157,223,5,46,88,163,126,102,254,11,125,161,94,240,46,255,27,244,8,39,24,200,175,231,212,53,124,159,241,200,117,153,48,205,89,189,21,163,246,3,114,222,225,54,201,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0"));
		}

		#endregion

	}

	#endregion

}

