namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApplicationServiceQueryExecutorSchema

	/// <exclude/>
	public class ApplicationServiceQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApplicationServiceQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApplicationServiceQueryExecutorSchema(ApplicationServiceQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0ae10d6-8124-4581-913a-ac8fe338fb3a");
			Name = "ApplicationServiceQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,203,110,219,48,16,60,43,64,254,97,161,94,36,192,144,238,118,26,192,113,210,194,7,23,105,155,228,82,244,64,75,43,155,128,68,10,124,24,53,138,254,123,151,164,12,75,177,21,247,208,28,44,139,171,153,225,236,131,20,172,65,221,178,2,225,9,149,98,90,86,38,91,72,81,241,141,85,204,112,41,174,175,126,95,95,69,86,115,177,25,64,20,206,70,226,217,188,109,107,94,120,182,206,230,107,109,20,43,252,98,148,241,32,12,55,28,199,1,159,72,65,170,17,196,119,84,59,94,248,111,244,245,131,194,13,109,6,139,154,105,61,133,158,153,14,247,213,162,218,63,252,194,194,146,164,167,228,121,14,55,218,54,13,83,251,219,110,237,81,128,29,12,42,250,233,192,7,93,108,177,97,26,100,5,236,168,158,29,132,242,158,210,143,123,172,152,173,205,29,23,37,153,78,204,190,69,89,37,75,159,240,126,224,36,157,192,23,106,6,124,132,248,130,231,56,253,73,210,173,93,19,8,10,151,230,165,44,97,10,119,76,99,31,229,115,24,128,110,78,43,122,120,9,104,151,16,13,3,61,143,69,166,174,26,101,93,115,168,214,143,222,82,64,116,246,46,24,75,158,169,168,36,34,208,79,8,216,193,114,2,75,226,175,152,96,27,84,174,214,221,107,234,54,136,166,176,166,156,146,215,148,30,12,220,232,70,127,58,203,40,202,224,122,152,194,163,146,45,42,55,125,148,128,146,134,116,176,12,144,215,115,17,2,92,108,81,113,83,202,2,242,99,180,223,245,168,61,232,128,220,81,81,121,73,67,99,148,155,218,111,168,105,28,66,251,67,85,67,211,111,207,117,61,158,189,109,125,133,102,43,203,247,245,29,76,118,21,189,60,34,240,25,205,128,146,164,148,156,239,87,50,64,30,122,52,28,128,236,132,30,159,99,197,233,236,255,103,186,147,188,132,21,107,231,101,73,151,145,20,172,94,200,218,54,66,39,161,93,128,254,111,226,147,137,150,3,67,75,131,205,63,20,39,220,28,61,78,55,162,81,144,38,184,9,123,190,176,218,98,18,63,209,117,17,79,78,105,217,146,142,29,19,5,102,14,225,138,49,174,225,14,254,179,226,111,203,116,160,160,116,254,192,132,232,48,72,177,191,155,190,140,191,65,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0ae10d6-8124-4581-913a-ac8fe338fb3a"));
		}

		#endregion

	}

	#endregion

}

