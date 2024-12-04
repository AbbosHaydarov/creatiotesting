namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PdfAsyncReportGenerationControllerSchema

	/// <exclude/>
	public class PdfAsyncReportGenerationControllerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PdfAsyncReportGenerationControllerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PdfAsyncReportGenerationControllerSchema(PdfAsyncReportGenerationControllerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71fc74a3-8eb1-455a-8bf5-06643861c00c");
			Name = "PdfAsyncReportGenerationController";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,82,193,74,35,65,16,61,71,240,31,138,241,98,14,206,92,69,77,32,70,34,123,112,9,26,79,178,135,182,167,38,105,152,233,234,173,174,9,12,139,255,110,245,76,12,9,174,184,176,151,134,106,94,189,122,245,234,121,211,96,12,198,34,172,144,217,68,170,36,159,147,175,220,186,101,35,142,252,233,201,159,211,147,81,27,157,95,195,83,23,5,155,252,9,121,235,44,62,80,137,117,62,179,226,182,61,242,122,143,59,164,98,204,23,198,10,177,195,168,8,197,156,49,174,21,14,243,218,196,120,5,203,178,154,197,206,219,71,12,196,114,143,30,135,193,170,66,152,234,26,57,117,105,223,203,44,134,159,40,115,106,130,2,94,93,237,164,123,196,223,173,99,108,208,75,60,63,44,146,56,152,192,55,45,9,149,239,62,202,241,47,29,82,20,5,220,196,182,105,12,119,211,93,173,202,24,99,194,131,1,187,151,5,84,129,73,202,55,76,158,218,8,203,187,197,5,247,91,192,122,191,6,196,193,173,252,131,188,56,96,15,237,107,237,44,216,228,196,63,24,1,87,112,107,34,126,107,215,72,79,166,239,222,233,37,83,64,22,189,128,218,205,36,104,5,203,1,210,75,114,126,131,236,164,36,149,194,88,77,178,47,167,236,78,159,34,34,106,200,170,11,152,21,105,147,81,248,224,5,218,234,249,157,218,31,133,83,26,14,176,48,153,66,102,66,208,165,77,162,43,66,89,93,131,221,24,142,40,147,231,213,226,226,50,235,67,242,31,210,142,254,137,191,150,247,227,51,13,113,58,246,81,173,138,251,160,14,33,238,242,123,148,155,191,118,78,207,51,13,64,54,30,66,62,58,67,95,14,246,247,245,219,16,253,163,207,183,119,99,50,166,10,125,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71fc74a3-8eb1-455a-8bf5-06643861c00c"));
		}

		#endregion

	}

	#endregion

}

