namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysEntityRightByAdminOperationEventListenerSchema

	/// <exclude/>
	public class SysEntityRightByAdminOperationEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysEntityRightByAdminOperationEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysEntityRightByAdminOperationEventListenerSchema(SysEntityRightByAdminOperationEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("043420fb-2a3b-4a10-bbe5-469835248027");
			Name = "SysEntityRightByAdminOperationEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,207,106,131,64,16,198,207,10,190,195,144,94,34,20,31,32,37,133,252,187,181,77,168,237,169,244,176,209,137,217,98,102,101,103,21,66,201,187,119,116,19,136,77,155,67,60,232,238,206,124,223,254,230,179,102,77,5,188,161,181,138,205,198,37,51,99,49,89,144,211,78,35,63,68,97,125,173,158,44,26,36,215,182,69,33,169,29,114,165,50,236,53,211,70,23,181,85,78,27,138,194,239,40,4,136,194,224,163,211,239,59,241,147,102,135,132,118,152,102,91,220,169,23,113,129,49,12,210,61,251,166,87,93,108,221,116,63,201,119,154,150,21,122,171,65,252,41,54,154,28,90,82,37,100,165,98,134,235,146,222,101,48,130,169,98,252,3,67,108,133,82,222,193,157,197,66,116,240,140,110,107,114,30,193,202,234,70,57,108,171,112,124,42,127,4,141,209,57,204,74,84,118,166,100,140,161,55,6,236,62,49,140,31,143,203,228,157,209,74,40,132,89,203,148,204,167,41,102,181,109,33,168,208,132,73,231,113,54,5,175,172,105,116,142,249,239,113,216,95,20,75,244,30,165,67,70,202,61,117,239,244,98,144,122,93,234,204,79,89,117,107,48,141,252,51,185,199,79,178,164,84,53,152,15,205,250,75,64,129,197,22,237,61,120,174,201,70,82,239,50,155,216,130,1,99,144,192,130,32,88,75,160,201,73,121,146,96,11,40,197,179,108,142,225,196,190,197,215,15,103,161,254,67,52,199,18,221,141,76,39,237,45,84,253,84,101,47,167,109,174,135,31,231,190,136,30,57,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("043420fb-2a3b-4a10-bbe5-469835248027"));
		}

		#endregion

	}

	#endregion

}

