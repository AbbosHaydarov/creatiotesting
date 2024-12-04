namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGenerationResultSchema

	/// <exclude/>
	public class ReportGenerationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGenerationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGenerationResultSchema(ReportGenerationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ee0c217-8753-49b8-84d4-5d609fc7ae8a");
			Name = "ReportGenerationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,49,107,195,48,16,133,103,5,242,31,14,178,56,80,242,3,18,58,101,40,29,218,132,184,91,200,32,187,23,87,96,75,230,116,38,184,33,255,189,146,165,80,203,164,75,23,131,223,189,247,221,243,89,203,6,109,43,75,132,15,36,146,214,156,121,181,53,250,172,170,142,36,43,163,231,179,235,124,38,58,171,116,5,121,111,25,155,205,228,125,245,186,115,146,19,23,132,149,75,192,182,150,214,174,225,128,173,33,126,65,141,129,116,64,219,213,60,56,143,57,146,146,181,250,150,69,141,39,39,180,93,81,171,18,74,159,252,51,40,92,19,247,252,221,99,180,101,234,74,54,228,214,237,7,68,112,68,220,99,80,230,66,190,61,13,211,119,119,128,39,40,122,198,227,41,74,142,203,168,121,233,73,98,13,252,165,108,54,54,107,188,192,27,54,134,250,156,9,101,147,165,177,37,248,139,137,219,63,171,228,3,115,82,37,32,69,160,120,31,60,143,66,254,143,220,135,49,126,31,71,192,224,136,141,22,168,63,195,5,211,115,238,201,180,72,172,240,241,49,99,213,81,133,43,84,200,27,72,63,52,238,79,202,164,198,201,254,160,166,226,237,7,252,52,166,218,151,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ee0c217-8753-49b8-84d4-5d609fc7ae8a"));
		}

		#endregion

	}

	#endregion

}

