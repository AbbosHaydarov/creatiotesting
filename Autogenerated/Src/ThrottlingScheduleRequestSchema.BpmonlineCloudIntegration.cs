namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ThrottlingScheduleRequestSchema

	/// <exclude/>
	public class ThrottlingScheduleRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ThrottlingScheduleRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ThrottlingScheduleRequestSchema(ThrottlingScheduleRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9582f96f-5bbb-484d-b61c-0857214e30ce");
			Name = "ThrottlingScheduleRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,83,77,111,219,48,12,61,39,64,254,3,145,94,182,139,125,239,215,97,109,81,236,208,33,168,123,43,138,64,181,104,87,128,109,101,34,53,192,43,250,223,71,41,214,234,37,113,215,14,51,12,91,162,200,199,71,62,10,160,83,45,210,70,149,8,119,232,156,34,91,113,118,97,187,202,212,222,41,54,182,91,204,159,23,115,144,199,147,233,106,40,122,98,108,79,22,243,217,120,159,221,250,142,77,139,89,129,206,168,198,252,140,161,175,94,19,216,217,197,85,113,99,53,54,36,174,226,156,231,57,156,146,111,91,229,250,243,97,127,247,228,44,115,19,80,168,124,66,237,27,4,173,88,65,27,2,179,20,149,143,194,238,47,229,92,18,177,83,37,63,136,97,227,31,27,83,66,217,40,162,17,96,49,224,137,135,212,40,223,217,145,195,90,120,193,202,217,13,58,54,72,199,176,138,193,219,243,136,124,131,237,35,186,79,223,164,115,112,6,75,173,250,229,231,144,37,165,49,29,195,165,234,225,25,106,228,19,160,240,121,121,35,30,27,213,175,37,221,26,91,101,154,3,88,193,97,133,238,42,28,191,23,53,98,81,132,61,72,48,130,145,160,78,48,61,194,78,111,155,17,247,98,149,17,8,203,48,10,59,58,37,83,160,1,229,208,119,96,11,126,35,74,33,240,190,132,217,8,104,36,93,176,237,170,23,108,127,17,240,22,191,123,36,62,134,47,138,80,70,240,135,41,147,109,27,31,229,13,139,9,246,201,124,141,76,96,93,232,4,65,108,33,248,206,8,16,24,141,50,225,149,65,55,80,159,162,255,187,132,67,130,172,141,142,82,36,199,161,174,107,111,244,86,145,175,122,95,140,143,242,30,183,91,154,200,88,247,66,255,31,105,39,132,9,230,70,70,169,24,92,254,7,247,198,16,131,173,94,175,250,41,33,66,233,176,58,91,238,235,190,204,207,223,40,235,240,197,72,200,127,94,137,125,236,251,7,72,203,221,178,66,50,249,205,226,251,242,11,228,115,30,185,68,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9582f96f-5bbb-484d-b61c-0857214e30ce"));
		}

		#endregion

	}

	#endregion

}

