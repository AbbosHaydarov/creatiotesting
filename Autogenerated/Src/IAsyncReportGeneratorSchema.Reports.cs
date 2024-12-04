namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IAsyncReportGeneratorSchema

	/// <exclude/>
	public class IAsyncReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IAsyncReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IAsyncReportGeneratorSchema(IAsyncReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe187b0f-b6a6-426e-8401-a8fc548ff6d0");
			Name = "IAsyncReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,77,75,195,64,16,61,43,248,31,134,122,81,144,230,94,181,32,30,164,7,65,108,253,1,219,100,210,46,54,187,97,118,86,9,226,127,119,118,183,105,147,54,150,94,66,118,62,222,188,55,111,19,163,42,116,181,202,17,22,72,164,156,45,121,252,108,77,169,87,158,20,107,107,174,46,127,174,46,47,188,211,102,5,243,198,49,86,247,187,115,183,133,80,226,146,185,38,92,73,27,204,12,35,149,2,60,129,217,59,214,150,248,5,13,10,166,165,39,215,152,60,22,103,89,6,15,206,87,149,162,102,186,61,191,145,253,210,5,58,80,161,108,77,214,88,239,54,13,80,4,129,85,66,9,227,75,111,242,64,81,109,52,55,227,22,46,235,224,213,126,185,209,57,232,150,11,204,226,236,3,62,82,40,26,229,185,35,255,138,188,182,133,155,192,91,4,72,201,67,178,49,48,103,69,44,92,15,233,9,8,43,247,25,88,29,211,74,145,90,145,170,192,136,1,143,35,239,144,100,237,6,163,160,209,116,177,70,8,49,200,119,65,96,219,162,227,118,218,248,33,139,32,195,152,121,215,198,4,217,11,157,5,72,200,158,140,75,221,132,82,90,68,97,96,203,99,201,210,222,214,7,128,222,154,37,189,8,125,113,97,67,153,155,143,222,14,162,252,253,241,14,134,156,235,221,212,190,186,219,251,19,174,189,224,214,51,231,55,60,40,37,137,92,54,82,229,106,204,117,169,69,184,92,75,195,225,149,206,245,53,160,164,213,255,51,129,131,7,188,101,114,122,253,123,182,234,8,230,91,243,26,88,138,210,116,194,178,67,96,86,140,178,105,151,252,105,155,222,211,28,217,209,112,230,102,208,215,52,168,221,250,53,154,34,125,75,241,252,155,126,13,189,160,196,254,0,139,130,138,81,125,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe187b0f-b6a6-426e-8401-a8fc548ff6d0"));
		}

		#endregion

	}

	#endregion

}

