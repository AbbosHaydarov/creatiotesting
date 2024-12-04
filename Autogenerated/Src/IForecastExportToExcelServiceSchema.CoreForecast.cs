namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastExportToExcelServiceSchema

	/// <exclude/>
	public class IForecastExportToExcelServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastExportToExcelServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastExportToExcelServiceSchema(IForecastExportToExcelServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c9ba928-203d-4631-aa4f-bccc69f69d0a");
			Name = "IForecastExportToExcelService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,193,110,194,48,12,61,15,137,127,176,122,218,36,68,165,93,7,189,32,64,104,135,73,128,184,135,212,133,108,105,130,156,148,82,77,252,251,156,6,16,21,236,82,53,47,207,47,239,217,54,162,68,119,16,18,97,141,68,194,217,194,15,39,214,20,106,87,145,240,202,154,225,204,18,74,225,252,230,189,223,251,237,247,94,42,167,204,14,86,141,243,88,50,85,107,148,129,231,134,115,52,72,74,126,220,56,255,41,78,79,7,75,126,109,167,39,137,154,233,92,144,166,41,140,92,85,150,130,154,236,114,94,24,143,84,4,107,133,37,192,182,40,200,22,23,67,176,87,206,91,106,32,39,165,117,110,107,3,185,240,2,188,101,50,43,15,175,186,233,157,240,161,218,106,37,65,221,180,23,215,124,29,87,43,164,163,146,200,5,28,153,191,15,6,91,96,66,40,60,58,16,38,135,154,84,248,109,95,6,231,249,166,12,78,180,149,34,156,45,137,29,182,68,66,95,145,185,228,129,31,108,130,207,71,163,17,57,8,98,29,195,67,26,39,133,210,108,58,182,50,201,102,237,41,38,150,157,246,142,210,182,234,185,136,221,126,243,188,54,66,87,184,68,105,41,119,73,246,213,98,112,12,32,219,107,209,1,212,123,37,247,80,115,107,97,139,23,187,152,63,170,199,60,46,27,57,68,144,132,197,56,233,180,114,201,251,197,235,129,73,154,69,156,159,136,8,107,93,139,131,218,211,42,152,99,119,50,159,216,188,198,236,177,19,112,223,150,1,44,166,166,42,145,196,86,227,40,230,186,203,154,193,99,252,183,176,175,231,126,239,12,127,236,253,180,58,11,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c9ba928-203d-4631-aa4f-bccc69f69d0a"));
		}

		#endregion

	}

	#endregion

}

