namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysUserProfileRefreshServiceSchema

	/// <exclude/>
	public class SysUserProfileRefreshServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysUserProfileRefreshServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysUserProfileRefreshServiceSchema(SysUserProfileRefreshServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("803ab10e-c8ad-4b9b-b660-c988f5e60033");
			Name = "SysUserProfileRefreshService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5578e4f-2732-4fb5-8de7-483c06c796b9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,203,110,219,48,16,60,43,64,254,129,112,47,50,96,232,3,18,244,96,187,41,154,2,110,12,43,69,15,70,14,180,52,178,137,74,164,202,165,220,8,69,254,189,75,61,108,171,105,149,94,8,114,56,59,187,59,92,10,45,11,80,41,19,136,71,88,43,201,100,46,90,26,157,169,125,101,165,83,70,95,95,253,186,190,10,42,82,122,47,226,154,28,138,219,63,206,81,12,123,84,9,86,38,69,62,122,25,125,195,110,156,48,79,156,58,54,121,207,188,115,97,28,206,197,21,197,191,111,63,57,87,70,243,29,57,43,89,201,104,26,151,233,147,111,76,229,152,195,100,166,191,179,216,115,168,88,230,146,232,198,151,249,149,96,215,214,100,42,199,6,153,5,29,186,184,134,191,253,128,76,86,185,187,208,194,147,199,59,128,237,108,202,105,49,42,95,241,230,84,126,129,227,138,74,238,124,167,114,229,234,13,126,84,202,162,128,118,20,94,30,188,77,226,189,120,35,196,179,162,14,72,167,62,73,89,237,114,149,136,196,247,52,218,146,184,17,11,73,56,53,24,240,243,243,122,114,101,5,119,48,41,251,178,110,20,219,203,237,67,137,118,92,46,155,13,182,236,244,189,62,154,239,8,219,48,174,124,178,126,136,31,39,51,225,171,3,185,143,198,22,210,49,206,212,21,136,228,30,45,20,125,38,163,103,98,97,210,58,118,117,142,1,229,132,70,11,105,49,243,185,130,13,207,49,63,56,198,21,27,51,122,55,6,131,222,63,75,39,35,58,91,150,149,181,108,169,247,43,156,10,255,23,130,192,217,186,219,5,30,103,25,141,102,220,162,215,65,247,58,51,225,244,246,175,236,152,159,240,204,92,242,12,85,22,39,178,159,101,111,39,158,249,75,182,52,142,32,226,200,237,100,168,52,121,226,126,135,80,39,98,193,154,90,104,252,28,237,182,79,250,34,18,233,146,131,8,239,158,19,148,158,40,208,119,253,223,90,232,197,154,213,47,188,107,102,8,58,109,199,168,57,183,232,16,124,249,13,240,157,253,162,146,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("803ab10e-c8ad-4b9b-b660-c988f5e60033"));
		}

		#endregion

	}

	#endregion

}

