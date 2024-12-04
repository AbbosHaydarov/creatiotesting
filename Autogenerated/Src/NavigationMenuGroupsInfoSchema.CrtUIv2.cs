namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NavigationMenuGroupsInfoSchema

	/// <exclude/>
	public class NavigationMenuGroupsInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NavigationMenuGroupsInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NavigationMenuGroupsInfoSchema(NavigationMenuGroupsInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a55f40b7-13c7-4e83-afa2-c626b579e2d1");
			Name = "NavigationMenuGroupsInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,193,106,195,48,12,61,183,208,127,16,237,61,185,175,93,96,180,163,20,182,81,182,193,206,142,171,4,51,199,14,146,189,81,74,255,125,142,147,101,205,8,185,24,235,233,189,167,103,203,136,10,185,22,18,225,29,137,4,219,194,37,91,107,10,85,122,18,78,89,147,188,136,47,85,198,235,51,26,191,152,95,22,243,153,103,101,74,120,59,179,195,42,208,181,70,217,16,56,217,163,65,82,114,221,115,62,44,125,214,58,248,63,212,42,160,1,95,17,150,129,11,91,45,152,239,0,134,254,123,178,190,230,131,41,108,36,167,105,10,27,246,85,37,232,156,117,245,14,89,146,202,145,193,244,82,168,130,22,202,40,6,21,213,173,54,189,17,215,62,215,74,130,108,6,79,140,157,133,23,134,179,15,122,36,91,35,57,133,33,237,49,90,180,253,255,217,34,240,247,25,96,139,208,70,4,73,88,220,47,71,230,45,211,44,233,141,82,190,113,234,146,30,30,141,175,144,68,174,113,51,162,207,160,141,13,23,40,209,173,129,155,227,58,17,238,21,217,107,215,4,211,86,156,154,245,124,255,174,7,216,145,151,206,19,78,71,234,247,249,212,58,116,150,195,106,36,207,10,205,169,253,207,88,183,232,16,188,254,0,250,206,228,95,140,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a55f40b7-13c7-4e83-afa2-c626b579e2d1"));
		}

		#endregion

	}

	#endregion

}

