namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityUserTaskHelperSchema

	/// <exclude/>
	public class ActivityUserTaskHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityUserTaskHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityUserTaskHelperSchema(ActivityUserTaskHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64a98983-9363-4df0-9a04-3cf2dd6cddc8");
			Name = "ActivityUserTaskHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,93,75,235,64,16,125,142,224,127,152,219,251,210,66,73,222,213,22,180,232,189,23,84,132,170,239,107,50,105,23,247,35,236,71,49,136,255,253,206,238,38,177,177,85,40,75,231,227,156,57,115,50,138,73,180,13,43,17,30,209,24,102,117,237,242,149,86,53,223,120,195,28,215,234,244,228,253,244,36,243,150,171,13,172,91,235,80,158,15,241,62,68,74,173,142,87,12,230,215,202,113,199,209,82,3,181,252,54,184,33,102,88,9,102,237,25,92,150,142,239,184,107,159,44,154,71,102,95,255,162,104,208,80,31,253,138,162,128,11,235,165,100,166,93,118,241,131,209,59,94,161,5,230,223,184,224,84,1,137,110,171,43,11,181,54,224,182,8,172,163,4,79,156,224,136,52,239,201,138,61,182,198,191,8,94,130,117,180,105,9,101,144,243,189,26,178,129,222,65,252,93,26,121,6,15,145,36,21,191,202,141,137,27,46,132,133,82,11,47,21,236,152,240,8,186,142,50,49,216,210,6,105,135,218,82,166,97,134,73,80,244,145,22,147,212,61,89,70,51,219,252,162,136,197,227,189,105,218,61,253,159,44,87,105,114,40,252,12,138,218,134,254,24,141,0,99,187,118,154,87,176,110,176,228,117,219,155,118,171,245,171,111,18,193,115,192,79,147,216,110,211,57,97,77,56,143,79,121,115,248,227,137,39,14,155,65,56,181,44,227,53,76,211,244,127,246,90,54,174,157,206,250,82,102,208,121,19,15,45,203,62,226,155,38,172,203,45,74,54,124,248,46,92,244,22,167,248,252,0,144,164,210,43,144,144,90,117,202,44,33,199,84,116,199,177,240,29,69,55,104,148,90,244,108,249,13,87,213,85,27,246,157,126,174,62,75,92,97,219,35,224,95,11,80,94,136,97,241,126,17,116,251,246,30,2,231,157,151,123,22,209,19,47,23,85,149,142,55,198,41,59,78,82,238,63,114,228,240,119,17,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64a98983-9363-4df0-9a04-3cf2dd6cddc8"));
		}

		#endregion

	}

	#endregion

}

