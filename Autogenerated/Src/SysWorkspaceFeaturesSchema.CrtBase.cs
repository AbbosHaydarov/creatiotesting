namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysWorkspaceFeaturesSchema

	/// <exclude/>
	public class SysWorkspaceFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysWorkspaceFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysWorkspaceFeaturesSchema(SysWorkspaceFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f433f309-ae33-4c7e-b563-db6b55384ed9");
			Name = "SysWorkspaceFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,145,79,75,3,49,16,197,207,91,232,119,24,122,82,176,237,221,127,160,11,150,130,212,67,69,143,146,102,103,107,48,59,89,102,102,149,69,246,187,155,93,27,181,182,151,64,242,155,247,30,111,66,166,66,169,141,69,120,68,102,35,161,212,89,30,168,116,219,134,141,186,64,227,209,231,120,148,53,226,104,11,235,86,20,171,200,189,71,219,67,153,45,144,144,157,189,248,153,249,107,195,24,223,35,169,155,141,119,22,172,55,34,240,28,248,109,72,188,67,163,13,163,192,57,44,243,80,213,49,110,227,188,211,54,129,168,236,179,179,154,221,187,81,4,209,56,98,129,209,20,129,124,11,203,123,39,122,41,202,49,247,26,94,202,228,119,5,132,31,176,7,7,159,108,62,159,60,16,230,33,248,93,196,228,44,189,175,209,6,42,96,21,133,7,236,134,130,190,34,31,213,173,130,78,159,144,219,233,81,218,215,242,168,232,219,91,83,28,106,255,135,117,223,235,74,251,218,239,183,64,77,139,57,57,221,21,98,140,119,250,173,222,127,67,214,13,38,241,236,190,0,69,103,252,210,221,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f433f309-ae33-4c7e-b563-db6b55384ed9"));
		}

		#endregion

	}

	#endregion

}

