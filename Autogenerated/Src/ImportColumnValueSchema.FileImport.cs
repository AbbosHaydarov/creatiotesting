namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportColumnValueSchema

	/// <exclude/>
	public class ImportColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportColumnValueSchema(ImportColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f8ae54ba-7ca1-412e-af1f-79f7b6e20f3d");
			Name = "ImportColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,77,79,227,48,16,61,7,137,255,48,10,151,86,139,146,59,37,145,80,43,36,14,172,16,32,46,171,61,184,233,36,107,201,177,163,177,189,108,183,234,127,199,31,73,73,105,169,224,18,201,51,158,55,239,189,153,88,178,22,117,199,42,132,103,36,98,90,213,38,155,43,89,243,198,18,51,92,201,236,150,11,188,107,59,69,230,252,108,115,126,150,88,205,101,3,79,107,109,176,157,125,56,103,11,206,26,169,180,225,149,62,200,61,90,105,120,139,217,19,18,103,130,255,15,240,238,150,187,119,65,216,184,3,204,5,211,250,10,98,187,185,18,182,149,47,76,88,12,151,242,60,135,107,109,219,150,209,186,236,207,55,18,184,212,134,73,39,64,213,96,254,112,13,149,7,1,194,142,80,163,52,26,120,128,131,42,224,193,95,15,152,13,120,249,8,240,215,2,151,182,105,144,22,92,119,130,173,39,105,104,94,108,82,248,1,210,25,165,234,73,136,76,221,57,221,166,211,223,190,104,39,103,41,208,7,58,187,20,188,234,89,28,81,146,56,19,221,119,167,249,150,163,88,57,209,15,161,46,230,62,74,13,129,136,226,244,174,240,159,231,127,40,192,41,96,134,221,99,187,68,154,252,116,132,161,128,52,202,190,243,85,145,241,192,80,27,242,211,153,191,231,103,39,186,63,170,215,111,183,38,245,250,121,95,7,56,110,122,129,114,21,29,217,183,231,129,84,135,100,56,126,197,162,96,241,55,8,134,93,56,202,46,32,193,6,26,52,51,208,254,179,61,205,211,253,52,174,212,86,70,209,151,134,73,200,12,234,253,237,93,119,232,110,34,66,69,88,23,233,193,242,164,121,249,137,184,16,233,24,177,54,44,106,209,43,43,163,33,215,121,72,29,191,57,222,143,114,111,199,78,150,209,48,219,242,125,51,198,5,189,157,7,26,38,189,193,129,224,229,96,247,136,196,46,54,116,240,131,74,167,224,223,158,36,25,109,171,139,143,202,252,115,147,36,113,108,69,68,143,161,97,207,92,116,64,12,137,35,243,236,99,251,35,222,190,1,47,130,101,47,35,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8ae54ba-7ca1-412e-af1f-79f7b6e20f3d"));
		}

		#endregion

	}

	#endregion

}

