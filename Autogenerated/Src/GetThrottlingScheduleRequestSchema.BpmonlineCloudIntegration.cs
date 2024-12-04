namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetThrottlingScheduleRequestSchema

	/// <exclude/>
	public class GetThrottlingScheduleRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetThrottlingScheduleRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetThrottlingScheduleRequestSchema(GetThrottlingScheduleRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("164861d9-449c-4213-a157-80657f43f33a");
			Name = "GetThrottlingScheduleRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,65,79,2,49,16,133,207,144,240,31,38,120,209,203,238,29,212,131,139,49,28,48,132,229,102,140,41,221,217,165,201,110,139,157,169,9,18,255,187,211,221,5,69,19,46,109,250,250,230,117,190,169,85,13,210,78,105,132,53,122,175,200,149,156,100,206,150,166,10,94,177,113,54,201,30,243,149,88,156,37,164,209,240,48,26,14,2,25,91,65,190,39,198,38,89,5,203,166,193,36,71,111,84,109,62,219,162,233,201,117,33,117,225,10,172,73,172,98,190,242,88,137,12,89,173,136,38,240,132,188,222,122,199,92,75,70,174,183,88,132,26,87,248,30,144,184,245,167,105,10,183,20,154,70,249,253,125,127,158,41,86,160,157,101,175,52,3,59,168,80,182,83,12,80,159,67,201,49,32,253,149,240,18,203,179,190,250,85,132,93,216,212,70,131,142,29,93,108,8,38,240,160,8,101,0,31,70,255,116,57,144,81,201,122,66,91,122,183,67,207,6,133,111,217,102,119,247,127,81,90,65,222,35,112,30,40,238,243,25,184,242,140,68,154,100,172,246,17,228,63,73,135,178,192,102,131,254,250,89,254,23,238,96,124,44,121,51,197,248,38,226,29,249,140,101,200,251,203,121,1,135,56,181,105,124,119,10,95,61,0,218,162,99,104,207,157,122,46,138,246,13,192,112,205,147,73,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("164861d9-449c-4213-a157-80657f43f33a"));
		}

		#endregion

	}

	#endregion

}

