namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DecimalExcelCellWriterSchema

	/// <exclude/>
	public class DecimalExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DecimalExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DecimalExcelCellWriterSchema(DecimalExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("11e09c36-5811-41ad-acea-44711f05f95b");
			Name = "DecimalExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,77,111,219,48,12,61,187,64,255,3,145,92,178,139,125,111,154,30,150,166,197,14,251,0,18,108,187,42,54,157,170,208,135,65,201,73,186,32,255,125,148,228,4,153,157,118,7,3,34,197,71,190,247,68,27,161,209,53,162,68,88,33,145,112,182,246,249,220,154,90,110,90,18,94,90,147,47,246,141,37,191,178,139,125,137,234,246,230,112,123,147,181,78,154,13,44,223,156,71,61,237,197,249,179,178,107,161,228,159,136,230,91,190,31,19,110,56,128,185,18,206,221,193,35,150,82,11,21,27,206,81,169,39,75,90,120,143,20,139,139,162,128,123,215,106,45,232,237,161,139,59,4,96,128,0,127,10,118,36,25,145,159,0,197,5,162,105,215,74,150,80,134,105,131,97,191,34,14,238,224,179,112,216,203,50,54,200,59,243,253,65,182,65,242,18,153,52,159,61,150,30,171,72,114,192,50,36,178,239,13,26,216,107,5,174,225,169,53,115,48,173,94,243,180,58,42,4,105,106,27,24,15,41,103,205,169,61,124,139,144,228,201,23,6,64,232,250,91,171,65,254,0,27,244,83,56,38,66,99,52,85,162,221,197,215,52,68,99,206,2,238,165,121,65,22,94,217,18,138,196,34,57,103,183,188,11,178,66,232,61,209,32,158,61,244,83,121,231,247,244,99,86,188,98,206,83,91,122,75,61,94,29,133,235,207,54,249,4,241,129,178,247,60,153,129,193,221,208,194,4,202,82,190,107,189,196,70,240,138,91,98,208,40,31,197,138,99,216,230,236,63,142,126,69,255,98,171,203,149,128,143,44,61,23,157,93,101,229,225,127,73,252,126,10,213,226,196,174,95,185,8,182,33,56,105,220,10,130,42,113,141,69,204,147,109,227,38,62,95,217,78,196,36,33,34,237,140,208,183,100,254,193,112,229,50,78,155,188,227,88,130,94,81,220,229,46,83,199,191,110,83,53,82,45,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11e09c36-5811-41ad-acea-44711f05f95b"));
		}

		#endregion

	}

	#endregion

}

