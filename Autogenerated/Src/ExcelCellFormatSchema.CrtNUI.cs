namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelCellFormatSchema

	/// <exclude/>
	public class ExcelCellFormatSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelCellFormatSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelCellFormatSchema(ExcelCellFormatSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea");
			Name = "ExcelCellFormat";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,93,75,195,48,20,134,175,59,216,127,56,224,205,6,165,221,151,95,211,9,186,77,38,136,138,155,34,136,23,89,119,218,5,243,81,211,4,167,178,255,110,154,86,16,101,171,94,52,52,57,239,251,230,225,228,8,194,49,75,73,132,48,67,165,72,38,99,29,12,165,136,105,98,20,209,84,138,96,188,74,165,210,51,57,94,69,200,234,181,143,122,173,94,243,76,70,69,2,35,25,25,142,66,159,75,197,137,14,174,83,20,15,156,5,211,84,33,89,100,75,68,125,228,212,59,10,19,27,5,99,97,120,31,92,208,16,25,43,108,78,17,134,33,28,103,134,115,162,222,78,202,189,211,129,253,24,196,78,9,104,253,193,151,58,252,38,79,205,156,209,200,213,127,199,123,22,217,243,30,221,249,149,225,115,84,69,165,17,19,150,97,243,41,175,158,73,201,96,0,109,127,131,84,43,131,62,116,90,237,59,187,118,11,207,136,104,180,158,78,133,39,119,180,124,104,80,161,155,19,169,232,187,20,154,176,83,70,19,145,247,238,158,48,131,89,112,75,147,165,46,115,49,162,156,228,56,93,127,27,185,15,47,70,106,188,81,24,211,85,31,242,235,138,128,137,237,62,42,235,239,109,71,107,255,27,237,66,104,27,187,91,129,245,74,23,122,217,135,158,141,222,64,56,213,42,159,159,1,236,85,53,188,245,163,225,51,202,243,166,239,255,13,161,211,221,136,112,41,229,179,73,109,212,65,21,130,123,193,18,161,188,254,208,254,175,139,209,70,177,40,166,59,223,174,63,1,48,240,16,123,79,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea"));
		}

		#endregion

	}

	#endregion

}

