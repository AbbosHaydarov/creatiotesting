namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateEmailScheduleCloudRequestSchema

	/// <exclude/>
	public class UpdateEmailScheduleCloudRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateEmailScheduleCloudRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateEmailScheduleCloudRequestSchema(UpdateEmailScheduleCloudRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("deb86ebb-b3f3-4b2f-84b4-86a9af7d4a21");
			Name = "UpdateEmailScheduleCloudRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,149,77,111,26,49,16,134,207,137,148,255,48,74,14,77,47,112,47,109,165,4,80,20,85,169,16,208,75,170,10,153,245,0,163,238,218,91,127,164,221,68,249,239,29,123,119,41,16,90,216,77,47,32,155,119,94,230,177,103,198,160,68,134,54,23,9,194,20,141,17,86,47,92,167,175,213,130,150,222,8,71,90,117,250,195,201,157,150,152,218,179,211,167,179,211,19,111,73,45,97,82,88,135,89,111,103,221,25,123,229,40,195,206,4,13,137,148,30,163,3,171,88,215,237,118,225,189,245,89,38,76,241,177,90,143,49,55,104,81,57,11,82,56,1,137,86,206,136,196,193,66,27,240,57,239,5,111,204,4,165,111,44,216,100,133,210,167,216,169,221,186,27,118,95,7,108,208,175,226,191,241,70,238,231,41,37,144,164,194,90,248,18,188,112,24,140,38,149,75,63,213,94,142,241,135,71,235,88,206,104,252,121,114,97,112,201,41,195,200,232,28,141,35,180,239,96,20,157,202,223,119,41,226,198,13,50,0,103,108,195,183,91,33,92,141,110,225,59,22,33,209,151,153,150,169,222,97,54,71,115,249,153,143,31,62,192,57,171,207,223,134,180,235,188,173,51,129,253,42,167,79,88,192,19,44,209,245,194,31,244,224,185,73,38,243,112,61,200,39,16,174,5,80,201,191,228,20,119,30,68,234,113,189,156,30,8,255,163,222,7,84,71,206,66,228,140,35,183,241,82,205,112,215,149,102,202,146,161,146,255,139,210,58,97,220,107,56,119,13,154,144,198,216,3,172,147,160,105,79,203,189,72,15,104,138,117,67,112,243,20,182,25,240,65,143,127,51,215,225,179,58,124,22,194,247,86,240,160,146,214,125,55,96,97,59,118,175,136,187,21,72,242,192,160,5,161,1,189,136,7,18,7,68,51,254,24,178,97,117,52,121,12,156,209,78,57,223,120,146,16,199,203,237,43,202,88,50,93,152,83,240,115,133,170,74,49,243,214,193,28,33,17,42,193,20,27,246,111,237,120,60,222,175,156,202,185,207,55,234,112,155,146,245,24,234,23,134,107,85,216,106,15,156,27,210,134,92,17,46,50,158,94,51,186,58,252,104,186,58,96,27,139,148,227,121,95,101,210,154,133,100,44,199,112,60,143,90,97,124,194,248,105,147,220,3,205,168,120,56,112,10,27,78,45,170,180,244,40,39,82,240,120,81,176,85,115,78,163,46,220,233,61,171,246,215,238,5,67,148,175,98,92,243,238,243,111,161,174,216,52,54,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("deb86ebb-b3f3-4b2f-84b4-86a9af7d4a21"));
		}

		#endregion

	}

	#endregion

}

