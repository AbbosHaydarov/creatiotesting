namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebAnalyticsTouchQueryExecutorSchema

	/// <exclude/>
	public class WebAnalyticsTouchQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebAnalyticsTouchQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebAnalyticsTouchQueryExecutorSchema(WebAnalyticsTouchQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("50ec6c2c-ce23-41df-8176-3b465f84fd4e");
			Name = "WebAnalyticsTouchQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,65,110,219,48,16,60,43,64,254,64,168,23,25,16,228,187,211,6,72,28,167,48,208,54,41,236,52,135,32,7,154,92,91,4,36,82,33,151,105,141,32,127,239,82,146,91,201,145,157,30,122,49,160,225,236,236,236,112,105,205,75,112,21,23,192,150,96,45,119,102,141,217,212,232,181,218,120,203,81,25,125,122,242,114,122,18,121,167,244,134,45,182,14,161,60,251,243,221,45,41,75,163,135,79,44,28,194,179,153,70,133,10,220,65,194,53,23,104,108,195,32,206,7,11,27,242,196,166,5,119,110,194,238,97,117,161,121,177,69,37,220,210,120,145,127,247,96,183,179,95,32,60,85,213,21,15,87,176,230,190,192,75,165,37,233,39,184,173,192,172,147,121,221,121,219,227,143,82,246,141,210,96,159,88,124,92,56,30,61,146,114,229,87,133,18,76,4,43,239,56,97,19,118,201,29,116,73,87,28,121,143,147,178,33,79,212,135,226,167,223,191,163,27,237,208,250,16,11,37,112,107,13,130,64,144,13,105,60,30,179,143,74,231,96,21,74,35,198,231,1,108,141,30,183,152,220,57,176,164,173,73,45,180,241,189,207,17,77,176,162,9,88,178,143,191,176,215,214,31,104,217,88,236,251,37,135,21,216,112,201,255,232,118,199,97,230,153,118,65,73,96,52,111,88,141,38,158,133,200,161,228,205,69,157,179,184,158,36,62,59,238,225,43,96,110,228,91,3,3,189,186,77,234,128,174,85,129,97,228,162,104,147,153,90,224,8,148,1,210,110,54,167,46,121,83,198,192,61,165,236,179,87,146,137,134,58,151,148,86,232,26,61,115,187,3,219,122,218,57,13,63,223,111,158,144,234,40,60,150,40,234,11,100,95,204,70,9,94,220,80,214,245,179,37,197,125,104,65,49,10,204,110,236,160,192,133,148,65,61,107,198,107,208,123,133,249,45,183,148,117,61,228,206,77,89,113,171,156,209,75,122,75,217,236,201,243,34,173,21,163,184,77,37,78,59,67,15,251,253,47,237,30,186,59,253,67,57,69,139,60,153,203,201,0,60,151,143,225,127,237,144,59,11,232,173,222,187,149,250,104,120,189,27,180,15,190,254,6,24,36,181,45,76,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50ec6c2c-ce23-41df-8176-3b465f84fd4e"));
		}

		#endregion

	}

	#endregion

}

