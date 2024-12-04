namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendTemplateRequestSchema

	/// <exclude/>
	public class SendTemplateRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendTemplateRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendTemplateRequestSchema(SendTemplateRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b1f76d4-1295-4ca5-bbc0-4faf38c61644");
			Name = "SendTemplateRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,65,79,243,48,12,61,131,196,127,176,202,5,46,237,157,1,18,12,132,56,12,33,182,27,66,147,215,186,37,82,219,148,216,229,211,62,196,127,199,73,87,216,198,52,24,151,166,118,252,94,242,158,235,214,88,17,55,152,18,76,200,57,100,155,75,60,180,117,110,138,214,161,24,91,199,195,235,241,200,102,84,242,193,254,219,193,254,94,203,166,46,96,60,103,161,106,176,22,199,15,109,45,166,162,120,76,206,96,105,254,7,6,173,210,186,67,71,133,6,48,44,145,249,4,198,84,103,19,170,154,18,133,30,232,165,37,150,80,150,36,9,156,114,91,85,232,230,231,139,56,64,32,183,14,92,87,9,98,129,149,0,102,40,233,51,216,92,55,82,211,24,170,133,97,54,7,89,16,199,61,97,178,198,120,202,68,88,178,133,212,81,126,22,253,40,61,190,68,38,21,245,106,210,254,182,17,36,158,237,241,10,5,21,37,14,83,121,210,68,211,206,74,147,66,26,238,188,65,37,156,192,119,50,197,169,183,250,252,180,233,222,217,134,156,24,82,175,238,3,101,183,191,238,79,72,220,144,234,86,123,216,175,242,76,64,21,154,18,180,179,140,69,112,225,187,13,93,230,21,203,150,62,195,137,66,189,53,11,91,174,61,203,168,35,137,146,243,37,158,47,88,208,63,162,106,70,238,232,78,191,37,56,131,104,113,110,116,236,253,232,13,89,38,131,126,125,131,130,100,224,239,61,128,247,93,4,214,254,40,237,187,127,95,238,246,239,117,254,192,176,93,97,15,152,122,150,85,157,44,206,15,68,223,245,128,248,179,204,174,143,38,211,15,219,228,134,220,110,18,183,160,183,203,11,192,169,201,86,149,221,180,38,235,218,120,155,253,93,146,232,255,193,251,238,231,87,141,218,77,81,166,142,2,234,224,7,150,190,11,240,15,217,243,9,160,252,90,163,63,127,138,178,177,121,126,108,47,100,147,198,67,221,233,38,52,196,93,118,53,169,185,15,75,133,142,225,85,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b1f76d4-1295-4ca5-bbc0-4faf38c61644"));
		}

		#endregion

	}

	#endregion

}

