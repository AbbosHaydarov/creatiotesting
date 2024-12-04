namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportServiceDataProviderSchema

	/// <exclude/>
	public class ReportServiceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportServiceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportServiceDataProviderSchema(ReportServiceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4bdab04d-2ff8-4619-bc00-3e7bdcd86548");
			Name = "ReportServiceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,77,107,227,48,16,61,171,208,255,48,164,151,24,22,251,190,109,2,75,182,44,189,116,75,147,238,117,81,237,113,16,181,37,51,146,2,161,244,191,239,72,178,155,216,93,199,7,219,51,122,243,241,222,140,180,108,209,118,178,68,216,33,145,180,166,118,249,198,232,90,237,61,73,167,140,206,119,36,203,55,165,247,215,87,239,215,87,194,91,254,133,237,209,58,108,111,63,237,243,88,194,147,63,88,41,27,172,162,49,206,205,64,134,222,16,238,217,128,77,35,173,253,14,67,189,159,210,201,39,50,7,85,33,69,92,81,20,112,103,125,219,74,58,174,123,187,7,128,210,181,161,54,38,133,154,76,11,132,157,33,7,22,233,160,74,204,135,240,226,44,190,243,175,141,42,161,12,101,225,57,226,183,9,126,94,26,230,58,18,44,7,191,63,219,231,147,14,201,41,100,14,79,164,14,210,97,2,76,251,142,142,164,32,247,231,28,103,182,160,121,14,192,28,224,85,90,156,116,15,158,154,192,224,43,5,209,165,66,96,29,5,189,19,139,31,85,69,104,237,182,207,253,24,82,175,214,176,24,120,36,212,11,53,139,52,0,113,131,186,74,44,46,81,50,14,75,135,85,130,76,10,255,165,33,231,237,44,229,231,47,164,224,32,27,143,179,212,250,130,99,114,92,34,156,134,93,20,98,143,46,126,147,37,84,13,203,4,206,31,236,163,111,154,223,116,223,118,238,184,60,181,151,101,9,218,71,136,211,73,191,161,105,65,115,158,207,160,95,254,11,221,159,208,232,242,133,123,231,115,205,109,177,60,223,230,229,206,242,157,217,198,70,150,89,20,132,31,66,231,73,79,149,18,226,35,125,176,177,56,110,237,114,64,124,127,92,158,31,247,202,114,248,210,25,10,19,140,251,126,97,39,55,39,56,152,26,100,186,26,51,227,137,158,78,146,108,227,238,174,22,126,36,206,98,253,192,201,164,230,65,115,170,177,112,249,93,17,3,211,152,211,45,156,189,127,19,209,97,92,38,227,235,25,110,204,114,234,126,135,255,107,147,188,99,39,251,254,1,31,70,189,149,7,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4bdab04d-2ff8-4619-bc00-3e7bdcd86548"));
		}

		#endregion

	}

	#endregion

}

