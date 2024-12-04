namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateUserSettingsRequestSchema

	/// <exclude/>
	public class UpdateUserSettingsRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateUserSettingsRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateUserSettingsRequestSchema(UpdateUserSettingsRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83429a60-95f6-4bbb-baae-d29f929fc531");
			Name = "UpdateUserSettingsRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,77,79,194,64,16,134,207,146,240,31,38,112,80,47,237,157,15,19,4,163,137,193,16,62,226,193,120,24,202,0,27,218,110,221,153,197,32,241,191,187,221,2,70,64,148,75,147,153,157,247,217,121,223,110,138,9,113,134,17,193,144,140,65,214,83,9,218,58,157,170,153,53,40,74,167,65,251,110,208,213,19,138,185,92,90,151,75,229,210,133,101,149,206,96,176,98,161,36,232,219,84,84,66,193,128,140,194,88,125,120,77,221,207,85,13,205,92,1,237,24,153,107,48,202,38,40,52,98,50,3,18,113,8,238,211,155,37,22,63,28,134,33,52,216,38,9,154,213,205,166,246,66,152,106,3,166,152,4,209,96,61,6,48,138,180,187,250,146,193,58,34,240,6,25,108,81,225,30,171,193,68,24,179,134,200,208,180,89,249,211,108,112,139,76,206,212,82,69,180,217,179,2,97,78,123,233,160,160,83,137,193,72,94,93,35,179,227,88,69,16,249,109,127,117,9,53,56,68,58,117,145,233,46,172,158,209,25,25,81,228,18,235,121,112,113,190,159,143,111,220,147,48,104,239,158,65,230,4,239,52,134,185,214,11,192,44,115,82,239,9,38,58,65,149,230,201,28,70,83,116,150,24,91,218,149,195,127,131,190,117,62,148,46,37,99,50,87,79,238,73,65,19,42,142,241,224,16,173,44,235,120,97,229,58,79,107,27,23,139,201,159,209,243,222,16,172,97,70,82,207,45,213,225,243,28,239,104,221,215,61,198,205,178,11,90,157,103,249,164,254,180,211,92,250,72,171,163,6,91,197,217,49,95,85,74,39,197,111,247,117,209,253,217,116,189,47,87,167,15,228,162,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83429a60-95f6-4bbb-baae-d29f929fc531"));
		}

		#endregion

	}

	#endregion

}

