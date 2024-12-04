namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntExcelCellWriterSchema

	/// <exclude/>
	public class IntExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntExcelCellWriterSchema(IntExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61d5eba2-33cc-431f-aed3-08714edf99a5");
			Name = "IntExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,144,65,79,195,48,12,133,207,173,180,255,96,137,203,118,105,239,99,219,129,50,36,14,72,147,152,224,156,165,94,23,148,198,149,147,150,33,180,255,142,155,110,131,13,196,33,82,108,191,231,247,37,78,213,232,27,165,17,214,200,172,60,109,67,86,144,219,154,170,101,21,12,185,108,185,111,136,195,154,150,123,141,118,148,126,142,210,81,154,220,48,86,50,132,194,42,239,167,112,143,218,212,202,70,73,129,214,62,16,215,42,4,228,40,206,243,28,102,190,173,107,197,31,139,99,253,232,2,86,200,128,189,5,228,88,120,103,35,142,236,100,200,127,56,154,118,99,141,6,221,167,245,214,115,208,107,244,192,20,238,148,199,171,174,248,6,216,51,237,138,169,65,14,6,5,121,21,87,14,115,201,155,25,183,67,177,149,164,33,239,35,79,153,212,201,191,152,18,225,234,113,191,234,249,226,186,149,9,233,237,145,0,93,57,64,92,18,61,97,216,81,217,227,48,5,212,1,203,255,136,78,154,111,40,31,216,184,10,134,188,23,101,91,28,211,230,77,68,208,245,197,4,228,7,146,36,233,20,131,113,131,0,230,48,150,251,36,10,4,79,198,140,161,101,119,86,100,107,122,142,123,199,147,56,63,252,249,134,161,123,217,60,124,1,132,121,189,255,79,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61d5eba2-33cc-431f-aed3-08714edf99a5"));
		}

		#endregion

	}

	#endregion

}

