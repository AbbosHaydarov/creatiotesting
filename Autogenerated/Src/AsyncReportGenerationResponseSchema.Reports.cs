namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncReportGenerationResponseSchema

	/// <exclude/>
	public class AsyncReportGenerationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncReportGenerationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncReportGenerationResponseSchema(AsyncReportGenerationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("59415005-e6b4-4fec-b04e-4cda4c279496");
			Name = "AsyncReportGenerationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,65,107,195,48,12,133,207,45,244,63,8,118,79,238,77,41,140,30,74,97,135,210,246,15,120,142,146,137,37,118,144,148,65,40,253,239,83,156,46,91,123,216,197,198,207,159,158,222,11,174,69,233,156,71,184,32,179,147,88,105,182,139,161,162,186,103,167,20,195,106,121,93,45,23,189,80,168,225,60,136,98,91,60,189,141,111,26,244,35,44,217,30,3,50,121,99,140,122,97,172,77,133,93,227,68,214,240,42,67,240,39,236,34,107,194,146,255,201,214,219,32,166,129,174,127,111,200,131,31,249,255,113,88,195,67,204,51,242,23,121,252,117,91,88,108,59,231,12,71,142,29,178,18,90,144,99,90,51,253,231,121,14,27,233,219,214,241,176,253,17,246,168,2,145,65,198,91,63,16,252,92,17,98,5,84,98,80,170,8,217,168,10,56,101,132,122,14,9,234,228,83,178,217,62,255,235,127,239,120,120,35,209,205,190,167,114,11,207,37,47,54,126,40,5,174,230,169,197,152,162,128,219,189,14,134,114,106,148,222,147,250,40,222,190,1,122,178,151,186,212,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59415005-e6b4-4fec-b04e-4cda4c279496"));
		}

		#endregion

	}

	#endregion

}

