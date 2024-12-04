namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskSenderFactorySchema

	/// <exclude/>
	public class EmailUserTaskSenderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskSenderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskSenderFactorySchema(EmailUserTaskSenderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("638e470d-51ca-4d2c-ac7f-a8a2d6682831");
			Name = "EmailUserTaskSenderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,81,193,106,195,48,12,61,187,208,127,16,244,146,94,242,1,29,59,140,174,29,61,116,20,154,125,128,231,168,169,89,98,7,75,166,11,163,255,62,59,110,74,3,97,183,93,100,235,73,239,233,33,25,217,32,181,82,33,20,232,156,36,123,226,124,109,29,230,7,103,21,18,133,196,156,116,229,157,100,109,205,124,246,51,159,9,79,218,84,112,236,136,177,121,186,231,143,252,7,202,32,244,138,164,43,131,46,16,2,101,225,176,10,69,88,215,146,104,5,155,70,234,250,131,208,21,146,190,142,104,74,116,91,169,216,186,174,239,110,253,103,173,21,16,7,69,5,42,114,254,164,136,224,50,196,251,148,61,242,217,150,97,206,161,23,74,197,177,232,110,66,15,222,144,123,56,165,89,255,47,176,105,107,201,56,180,130,191,125,150,16,119,35,4,93,52,171,51,100,89,100,37,74,215,226,114,104,203,199,240,141,36,148,36,132,81,41,127,241,108,87,169,42,28,178,119,6,12,94,32,194,83,102,111,66,66,68,60,156,192,160,138,251,135,231,187,195,124,92,153,167,254,107,60,225,180,131,189,52,94,214,19,30,82,225,63,92,148,120,146,190,230,97,38,159,157,189,244,35,223,45,239,194,230,177,65,195,88,110,190,21,182,145,158,45,19,241,26,99,8,241,89,4,43,233,242,125,158,208,49,24,176,95,174,208,12,66,250,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("638e470d-51ca-4d2c-ac7f-a8a2d6682831"));
		}

		#endregion

	}

	#endregion

}

