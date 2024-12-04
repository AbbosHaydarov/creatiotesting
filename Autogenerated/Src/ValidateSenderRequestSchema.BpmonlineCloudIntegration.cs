namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderRequestSchema

	/// <exclude/>
	public class ValidateSenderRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderRequestSchema(ValidateSenderRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efc01930-33c9-4ec2-8ddf-662cdd8b0a08");
			Name = "ValidateSenderRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,77,79,2,49,16,61,75,194,127,152,224,65,189,236,222,249,58,136,132,152,136,33,44,241,98,60,148,101,192,38,221,22,103,186,36,72,252,239,78,187,128,225,195,175,203,110,102,250,222,235,188,55,181,170,64,94,170,28,97,130,68,138,221,220,39,61,103,231,122,81,146,242,218,217,164,215,207,134,110,134,134,235,181,77,189,118,81,178,182,11,200,214,236,177,16,164,49,152,7,24,39,3,180,72,58,111,29,99,198,165,245,186,192,36,147,83,101,244,123,84,21,148,224,46,9,23,82,64,207,40,230,38,60,201,241,76,121,204,208,206,144,198,248,86,34,251,8,76,211,20,218,92,22,133,162,117,119,91,71,18,204,29,1,85,72,240,14,86,91,9,224,168,113,197,128,133,210,134,147,157,72,122,164,210,102,68,101,216,65,78,56,239,52,126,13,33,185,85,44,3,210,74,231,184,157,176,1,105,80,123,190,83,94,9,203,147,202,253,139,52,150,229,212,232,28,242,56,231,89,111,208,132,83,57,97,74,206,242,221,199,51,34,183,68,242,26,37,163,81,20,173,206,143,83,137,141,1,122,6,9,133,195,223,191,98,21,0,24,205,62,132,112,154,66,213,145,224,74,220,151,147,239,120,95,176,104,119,136,197,20,233,250,81,30,17,116,160,17,41,15,194,104,220,132,0,118,9,220,247,109,89,32,169,169,193,54,123,146,183,209,133,254,14,10,27,88,160,111,133,121,91,240,17,88,127,183,214,207,70,96,229,238,255,25,59,195,250,217,214,146,220,74,203,214,66,125,232,172,114,19,22,180,7,28,251,137,139,148,165,87,187,140,117,213,61,108,74,239,19,69,13,36,111,139,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efc01930-33c9-4ec2-8ddf-662cdd8b0a08"));
		}

		#endregion

	}

	#endregion

}

