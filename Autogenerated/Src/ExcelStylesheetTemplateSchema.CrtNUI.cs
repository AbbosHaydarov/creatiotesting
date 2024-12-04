namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelStylesheetTemplateSchema

	/// <exclude/>
	public class ExcelStylesheetTemplateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelStylesheetTemplateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelStylesheetTemplateSchema(ExcelStylesheetTemplateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("962cb08b-b35b-4310-92bb-ae488ec1da3f");
			Name = "ExcelStylesheetTemplate";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,63,107,195,48,16,197,103,27,252,29,14,186,203,123,91,186,184,41,217,58,196,148,172,87,229,226,8,244,15,221,9,18,66,190,123,101,37,105,189,180,116,144,208,19,239,253,142,123,30,29,113,68,77,48,82,74,200,97,47,106,8,126,111,166,156,80,76,240,106,117,140,33,201,24,86,71,77,182,107,207,93,219,181,77,102,227,39,120,13,58,59,242,242,22,146,67,81,239,145,252,214,89,181,137,137,112,199,7,34,121,170,238,135,68,83,65,193,96,145,249,17,42,105,35,39,75,213,51,146,139,22,133,170,181,239,123,120,230,236,28,166,211,203,77,215,24,200,1,5,116,240,130,198,51,208,204,0,254,134,128,220,40,234,14,233,23,148,152,63,173,209,160,43,232,215,241,77,217,173,185,123,127,12,203,231,25,166,178,20,240,124,93,22,238,129,172,189,182,0,31,104,51,45,244,63,34,235,82,23,165,63,50,229,204,53,146,223,93,155,156,101,253,251,2,178,57,73,209,191,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("962cb08b-b35b-4310-92bb-ae488ec1da3f"));
		}

		#endregion

	}

	#endregion

}

