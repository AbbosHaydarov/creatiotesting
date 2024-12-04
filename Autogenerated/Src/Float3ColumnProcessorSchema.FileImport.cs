namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float3ColumnProcessorSchema

	/// <exclude/>
	public class Float3ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float3ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float3ColumnProcessorSchema(Float3ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ac9f761-d47f-4b4c-a8e7-4a1491cda0d9");
			Name = "Float3ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aaf0cd3b-b0e9-4378-a805-7163759e3c5e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,193,106,227,48,16,134,207,41,244,29,134,244,146,64,177,15,189,237,54,129,38,37,37,151,165,176,205,94,202,30,20,121,156,8,108,201,157,145,10,97,233,187,119,44,37,109,236,164,11,189,216,210,240,207,63,154,79,35,171,106,228,70,105,132,39,36,82,236,74,159,205,157,45,205,38,144,242,198,217,108,97,42,92,214,141,35,127,121,241,239,242,98,16,216,216,13,252,222,177,199,250,231,199,254,56,155,240,171,120,182,80,218,59,50,200,162,16,205,21,225,70,106,192,188,82,204,63,96,81,57,229,111,230,174,10,181,125,36,167,145,217,81,20,230,121,14,183,198,110,145,140,47,156,6,77,88,78,134,81,223,147,15,243,233,65,207,161,174,21,237,14,251,59,11,198,178,87,86,154,117,37,248,173,97,208,109,97,144,5,9,5,103,217,172,43,132,210,17,52,201,175,109,33,157,10,116,172,3,175,170,10,200,217,161,70,126,84,228,249,30,75,21,42,63,51,182,144,196,145,223,53,232,202,209,178,119,194,241,53,252,18,234,48,1,43,63,17,156,109,123,60,254,43,150,77,88,87,70,239,143,121,86,7,123,108,39,212,6,114,89,242,253,100,44,237,121,10,45,127,65,253,24,141,147,226,187,112,79,232,198,192,156,80,121,228,46,99,33,32,74,196,99,207,155,83,211,22,231,41,207,20,105,20,169,58,162,154,12,3,35,73,31,22,117,59,154,195,233,74,246,114,49,135,64,118,155,71,117,76,222,163,59,91,114,180,234,24,65,215,119,44,76,215,138,113,212,15,183,227,63,120,219,99,69,91,36,178,93,204,82,163,65,242,50,226,2,153,156,151,92,44,254,199,121,38,149,190,129,249,94,121,149,134,48,209,13,214,188,200,218,20,104,189,41,13,210,23,44,101,160,211,89,192,189,202,155,20,61,60,4,83,68,191,63,173,221,147,184,173,150,5,76,166,221,88,150,8,246,117,233,1,247,49,36,56,221,224,219,59,68,53,113,75,100,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ac9f761-d47f-4b4c-a8e7-4a1491cda0d9"));
		}

		#endregion

	}

	#endregion

}

