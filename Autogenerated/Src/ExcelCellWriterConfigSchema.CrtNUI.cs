namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelCellWriterConfigSchema

	/// <exclude/>
	public class ExcelCellWriterConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelCellWriterConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelCellWriterConfigSchema(ExcelCellWriterConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("346c17cb-c7b3-4b13-89c8-26d13a32c8da");
			Name = "ExcelCellWriterConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,61,107,3,49,12,134,231,4,242,31,4,221,239,150,210,161,41,93,174,9,100,73,161,77,63,86,159,171,28,46,182,116,216,50,73,8,249,239,181,125,151,18,40,37,131,108,94,244,72,175,36,82,14,67,175,52,194,6,189,87,129,183,82,53,76,91,211,69,175,196,48,85,139,125,207,94,54,188,216,107,180,179,233,113,54,157,196,96,168,131,215,67,16,116,243,95,253,196,58,58,36,89,178,119,74,170,231,30,233,211,217,148,79,196,141,199,46,53,131,198,170,16,238,161,244,106,208,218,15,111,4,253,96,88,192,186,174,225,33,68,231,148,63,60,142,186,208,144,194,194,174,240,160,75,65,117,230,235,139,130,62,182,214,104,208,217,232,63,159,73,94,226,76,142,115,14,4,140,223,17,58,148,57,132,252,156,46,224,183,21,201,221,45,188,240,110,29,93,123,29,108,216,70,71,87,88,110,191,81,11,188,43,27,241,15,148,34,223,15,233,107,56,97,150,167,31,55,38,128,177,182,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("346c17cb-c7b3-4b13-89c8-26d13a32c8da"));
		}

		#endregion

	}

	#endregion

}

