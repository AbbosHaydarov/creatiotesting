namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskMessageProviderFactorySchema

	/// <exclude/>
	public class EmailUserTaskMessageProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskMessageProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskMessageProviderFactorySchema(EmailUserTaskMessageProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("31e7a4a6-b0cf-4c1c-8657-06e2b3d26b6a");
			Name = "EmailUserTaskMessageProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,75,110,131,64,12,134,215,68,202,29,44,117,67,54,28,32,221,53,77,171,44,168,34,149,30,96,58,56,100,84,152,65,182,105,138,170,222,189,195,0,81,66,31,201,198,194,143,239,255,173,49,86,85,200,181,210,8,25,18,41,118,59,73,86,142,48,217,146,211,200,236,19,187,51,69,67,74,140,179,243,217,231,124,22,53,108,108,1,207,45,11,86,183,199,252,148,63,65,70,161,123,100,83,88,36,15,120,228,134,176,240,77,88,149,138,121,9,235,74,153,242,133,145,50,197,111,169,159,86,5,122,238,221,228,72,15,74,139,163,54,96,117,243,90,26,13,44,94,90,131,238,224,235,216,200,239,237,227,209,55,69,217,187,220,59,111,131,98,223,60,87,223,252,39,12,143,40,161,63,169,199,161,152,97,85,151,74,112,132,161,25,62,22,208,189,95,20,241,193,136,222,67,28,223,185,188,29,167,179,182,198,197,56,153,252,232,12,104,164,21,35,76,187,201,153,239,178,159,140,8,165,33,11,22,15,240,235,94,233,100,249,227,154,221,85,255,180,26,14,122,201,108,50,118,173,103,142,59,213,148,50,170,202,158,220,33,136,62,57,217,120,41,172,208,10,230,235,15,141,117,247,127,197,3,248,213,69,31,194,149,209,230,253,161,67,222,87,207,139,190,246,13,110,43,168,227,251,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("31e7a4a6-b0cf-4c1c-8657-06e2b3d26b6a"));
		}

		#endregion

	}

	#endregion

}

