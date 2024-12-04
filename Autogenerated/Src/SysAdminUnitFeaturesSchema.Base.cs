namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysAdminUnitFeaturesSchema

	/// <exclude/>
	public class SysAdminUnitFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysAdminUnitFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysAdminUnitFeaturesSchema(SysAdminUnitFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4b5d629-1e8b-41bd-915a-2e4ffb0cebcd");
			Name = "SysAdminUnitFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,193,74,3,49,16,134,207,187,176,239,48,212,139,94,250,0,21,15,82,21,122,16,10,214,7,152,102,103,211,64,154,132,153,132,82,164,239,238,100,179,122,16,33,33,240,231,251,255,249,39,224,153,36,161,33,56,16,51,74,156,242,122,27,195,228,108,97,204,46,134,161,255,26,250,174,136,11,22,182,76,85,91,191,233,83,152,14,209,90,175,250,227,208,43,146,202,209,59,3,198,163,8,124,92,229,121,60,187,240,25,92,94,104,81,166,70,253,1,79,241,162,243,50,154,188,11,191,22,216,192,226,122,167,140,35,102,172,70,117,215,167,187,99,178,218,12,212,39,153,139,201,145,101,3,251,57,118,65,150,25,255,167,223,63,192,92,164,235,118,242,26,240,232,105,132,39,208,36,210,77,170,252,66,98,216,165,186,190,126,172,26,35,48,58,73,30,175,16,39,48,45,20,132,60,153,153,211,147,79,4,69,136,33,161,165,85,203,186,253,116,166,48,182,218,77,80,189,222,27,12,253,55,160,178,171,191,131,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4b5d629-1e8b-41bd-915a-2e4ffb0cebcd"));
		}

		#endregion

	}

	#endregion

}

