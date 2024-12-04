namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BoolExcelCellWriterSchema

	/// <exclude/>
	public class BoolExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BoolExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BoolExcelCellWriterSchema(BoolExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb306662-1573-42f1-9db8-66a8d68b57c0");
			Name = "BoolExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,77,79,195,48,12,134,207,157,180,255,96,193,101,147,80,123,7,54,36,38,56,1,66,98,192,57,107,205,8,74,227,202,73,199,151,248,239,56,201,202,216,24,131,67,171,58,126,109,191,125,28,171,106,116,141,42,17,166,200,172,28,61,248,124,66,246,65,207,91,86,94,147,205,207,94,26,98,63,165,179,151,18,77,191,247,222,239,101,173,211,118,190,86,80,215,100,143,250,61,201,237,51,206,165,12,38,70,57,119,8,55,158,69,27,107,39,104,204,61,107,143,28,133,69,81,192,177,107,235,90,241,235,120,25,39,53,96,144,131,60,6,158,99,65,222,233,139,111,5,77,59,51,186,132,50,12,130,83,34,179,49,5,126,157,158,201,79,200,123,229,149,172,243,202,122,241,123,205,122,161,60,166,124,147,2,40,67,30,92,50,119,213,234,75,101,213,28,249,74,216,193,8,246,86,32,36,183,119,180,163,118,202,45,38,79,119,202,180,216,53,72,252,110,189,54,46,223,144,236,108,119,174,140,251,171,223,166,166,107,184,143,182,74,191,191,206,226,154,169,65,246,26,3,140,72,56,229,5,255,177,182,143,40,8,43,42,161,8,27,232,86,64,11,33,160,43,132,47,210,231,196,181,242,63,226,209,120,243,40,15,139,251,195,210,37,250,71,170,226,114,200,99,233,177,218,101,169,211,172,92,117,180,226,192,8,97,64,179,39,17,193,34,4,67,8,119,58,203,22,138,97,38,110,162,66,48,14,66,48,76,26,113,40,10,70,223,178,253,46,26,129,151,125,197,100,118,2,22,159,225,130,74,101,244,155,154,153,37,245,193,250,133,57,216,118,9,134,121,252,76,125,14,255,217,103,219,246,151,141,162,221,143,173,84,211,233,250,225,199,39,113,182,204,32,6,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb306662-1573-42f1-9db8-66a8d68b57c0"));
		}

		#endregion

	}

	#endregion

}

