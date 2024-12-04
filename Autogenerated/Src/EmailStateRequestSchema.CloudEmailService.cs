namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStateRequestSchema

	/// <exclude/>
	public class EmailStateRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStateRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStateRequestSchema(EmailStateRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa");
			Name = "EmailStateRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,146,77,79,195,48,12,134,207,157,180,255,96,141,11,92,218,59,95,59,140,105,218,1,52,173,187,33,14,89,234,118,17,109,82,18,23,105,32,254,59,78,210,33,54,62,132,64,92,154,218,177,95,61,111,108,45,26,116,173,144,8,43,180,86,56,83,82,58,49,186,84,85,103,5,41,163,135,131,231,225,32,233,156,210,21,228,91,71,216,156,29,196,233,178,211,164,26,76,115,180,74,212,234,41,244,113,21,215,29,89,172,56,128,73,45,156,59,133,105,35,84,157,147,32,92,226,67,135,142,66,81,150,101,112,238,186,166,17,118,123,217,199,75,108,45,58,212,228,192,198,82,48,37,208,6,1,189,6,56,47,2,14,237,163,146,152,238,68,178,119,42,183,87,130,4,91,33,43,36,221,113,162,237,214,181,146,32,61,202,103,36,9,27,229,239,27,243,194,154,22,45,41,100,240,69,232,141,247,135,184,33,49,67,38,53,150,137,248,140,136,243,2,200,128,220,160,188,247,128,31,9,35,226,53,54,107,180,199,55,60,8,184,128,81,232,157,23,163,19,143,188,99,158,117,170,24,71,102,86,245,3,73,146,10,201,79,34,73,92,255,243,242,83,60,126,59,75,80,248,7,236,223,148,125,42,83,64,25,42,52,69,3,238,55,248,65,155,243,184,111,192,103,86,188,35,99,200,119,5,127,182,129,186,248,39,19,172,252,157,133,105,188,254,210,0,244,123,196,50,113,149,66,28,125,237,39,57,247,10,198,57,178,115,129,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa"));
		}

		#endregion

	}

	#endregion

}

