namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncReportGeneratorConfigurationSchema

	/// <exclude/>
	public class AsyncReportGeneratorConfigurationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncReportGeneratorConfigurationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncReportGeneratorConfigurationSchema(AsyncReportGeneratorConfigurationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("320cda9d-04b0-419a-991e-dff36d9fb757");
			Name = "AsyncReportGeneratorConfiguration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,77,110,2,49,12,133,215,32,113,7,139,238,153,61,180,72,21,11,54,93,32,84,14,96,82,103,136,154,137,71,118,70,42,66,220,189,158,191,170,165,21,221,36,178,227,23,191,239,37,172,72,107,116,4,175,36,130,202,62,47,54,156,124,40,27,193,28,56,205,166,151,217,116,242,32,84,90,1,155,136,170,75,120,214,115,114,123,170,89,242,150,18,217,36,203,141,202,68,69,81,192,163,54,85,133,114,94,15,181,137,132,148,82,86,64,160,143,76,73,219,127,217,67,62,145,77,19,129,19,242,79,243,123,191,207,139,53,120,22,192,214,198,73,56,113,163,32,157,0,202,94,97,83,139,209,66,241,205,67,221,28,99,112,224,90,142,255,49,96,9,247,41,39,22,142,157,95,249,236,132,107,146,28,200,66,218,117,171,250,247,219,40,186,198,150,44,5,195,208,246,70,112,24,227,17,221,59,28,246,47,29,94,226,28,124,112,189,19,75,200,113,85,71,26,171,63,121,127,3,143,196,154,37,164,18,54,195,146,131,68,184,152,56,175,218,245,43,184,14,28,148,222,122,148,174,238,187,63,155,215,79,98,240,48,32,51,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("320cda9d-04b0-419a-991e-dff36d9fb757"));
		}

		#endregion

	}

	#endregion

}

