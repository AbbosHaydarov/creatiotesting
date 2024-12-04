namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCloudResponseSchema

	/// <exclude/>
	public class BaseCloudResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCloudResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCloudResponseSchema(BaseCloudResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d2a5529-1027-4e39-b5d9-500029d6ce6b");
			Name = "BaseCloudResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,77,111,194,48,12,134,207,69,226,63,88,112,157,232,157,175,195,170,105,218,1,9,13,254,64,72,221,54,90,155,176,56,1,77,136,255,62,55,45,31,27,176,177,157,218,56,175,95,63,118,18,45,42,164,181,144,8,75,180,86,144,201,220,32,49,58,83,185,183,194,41,163,7,201,211,98,102,82,44,169,219,217,117,59,221,78,212,183,152,243,6,36,165,32,26,194,163,32,76,74,227,211,87,54,50,154,48,136,226,56,134,49,249,170,18,246,99,218,174,67,2,100,198,194,138,115,192,182,122,200,172,169,128,203,192,86,185,2,164,169,42,118,95,91,179,70,235,20,210,224,96,23,159,249,173,253,170,84,18,100,176,188,130,16,53,172,71,216,249,209,110,8,243,144,219,236,127,231,12,129,103,116,4,2,54,162,244,8,74,167,74,242,40,116,14,219,2,93,129,22,92,161,232,132,207,255,228,165,68,10,164,151,168,77,36,152,29,151,0,99,57,117,214,227,56,150,83,80,25,44,156,112,158,0,223,189,40,9,122,230,173,55,2,83,23,219,42,194,135,90,157,241,70,144,159,85,57,153,182,243,88,25,83,194,11,45,26,30,224,33,68,81,148,163,131,29,243,58,111,245,161,208,100,210,22,217,215,146,253,111,195,224,51,163,250,203,68,64,193,225,254,94,235,58,117,139,150,155,67,114,205,176,48,61,235,15,122,124,247,140,237,253,208,24,57,91,159,64,75,191,3,238,105,84,35,133,6,238,103,231,203,78,34,199,251,225,151,87,147,54,55,240,102,141,242,255,124,199,75,37,249,201,253,141,242,86,234,5,171,210,14,18,214,92,163,236,163,78,155,23,19,214,77,244,107,144,99,159,225,50,86,111,53,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d2a5529-1027-4e39-b5d9-500029d6ce6b"));
		}

		#endregion

	}

	#endregion

}

