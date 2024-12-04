namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PdfAsyncReportGeneratorSchema

	/// <exclude/>
	public class PdfAsyncReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PdfAsyncReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PdfAsyncReportGeneratorSchema(PdfAsyncReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e562fee6-cd50-43d6-8ac4-36911be07fee");
			Name = "PdfAsyncReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,107,219,64,16,61,43,144,255,48,40,23,9,130,124,79,98,67,99,215,33,135,22,211,164,244,80,74,217,74,35,121,65,222,21,179,35,55,166,244,191,119,86,235,4,203,72,110,211,246,34,180,179,51,239,205,155,143,53,106,131,174,81,57,194,35,18,41,103,75,206,230,214,148,186,106,73,177,182,230,252,236,199,249,89,212,58,109,42,88,234,26,229,114,139,196,72,254,240,246,137,209,56,241,130,105,255,50,155,215,26,13,103,222,120,253,18,127,72,65,163,246,108,169,114,182,164,209,13,123,28,36,151,125,192,198,18,63,32,109,117,238,1,37,224,130,176,242,25,205,107,229,220,21,172,138,242,141,219,153,60,120,222,161,65,9,181,212,185,78,38,19,184,113,237,102,163,104,55,219,159,197,143,208,73,238,14,20,80,23,4,213,115,20,104,3,188,70,88,45,150,80,90,218,40,206,158,97,38,7,56,159,23,88,170,182,230,91,109,10,201,62,225,93,131,182,76,238,135,18,73,47,225,189,244,64,10,24,11,106,156,126,145,248,166,253,86,235,28,114,175,96,76,0,92,193,173,114,56,172,45,146,158,201,247,165,22,75,141,117,225,139,65,122,171,24,195,101,19,14,34,82,21,214,212,59,184,63,166,248,250,221,82,113,100,12,69,142,46,208,20,1,188,207,36,237,113,76,173,111,160,231,235,132,236,233,130,168,17,57,73,10,126,206,162,104,136,83,138,211,117,51,12,198,46,187,67,190,57,78,118,150,196,159,36,50,78,253,208,68,63,79,103,185,34,219,200,156,202,136,249,154,88,198,156,177,8,46,93,51,181,89,35,105,46,172,52,129,176,156,198,99,165,206,30,108,75,57,246,118,33,158,204,66,121,247,184,96,101,39,72,23,120,98,127,178,254,54,13,160,194,116,246,199,241,217,194,230,79,215,127,165,231,81,81,133,252,191,245,12,160,190,74,143,12,205,111,230,238,29,242,218,22,255,220,206,149,108,188,34,12,230,228,163,67,146,252,140,224,9,199,37,28,121,247,158,162,116,188,76,33,108,161,88,73,118,227,248,208,190,130,14,242,30,249,126,121,8,185,37,51,184,183,178,52,221,31,38,199,52,125,164,19,235,19,172,125,163,216,126,1,18,51,229,153,67,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e562fee6-cd50-43d6-8ac4-36911be07fee"));
		}

		#endregion

	}

	#endregion

}

