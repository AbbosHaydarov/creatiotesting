namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDashboardItemSelectBuilderSchema

	/// <exclude/>
	public class IDashboardItemSelectBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDashboardItemSelectBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDashboardItemSelectBuilderSchema(IDashboardItemSelectBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e4bbf9b-4e63-40a8-8dcf-802e271ecd52");
			Name = "IDashboardItemSelectBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,144,77,78,195,64,12,133,215,173,212,59,120,9,18,74,14,208,170,139,54,8,117,193,170,92,192,73,156,116,208,252,4,219,35,20,85,189,59,78,34,10,27,216,204,226,217,239,189,207,19,49,144,12,216,16,188,17,51,74,234,180,56,166,216,185,62,51,170,75,113,179,190,110,214,171,44,46,246,112,30,69,41,216,220,123,106,166,161,20,47,20,137,93,179,189,239,28,19,83,81,29,76,48,105,200,181,119,13,184,168,196,221,84,114,170,80,46,117,66,110,79,150,116,166,41,231,144,157,111,137,109,221,154,236,93,149,101,9,59,201,33,32,143,251,111,161,114,115,163,73,240,233,244,2,77,242,57,68,129,1,217,78,176,124,41,238,222,242,183,249,199,184,19,101,67,124,130,84,191,91,239,30,158,163,58,29,237,156,41,233,21,7,184,66,79,186,133,219,63,28,51,173,128,204,232,240,145,201,128,186,196,208,162,34,248,132,237,31,24,203,173,139,253,225,113,249,158,185,231,246,5,21,17,11,113,131,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e4bbf9b-4e63-40a8-8dcf-802e271ecd52"));
		}

		#endregion

	}

	#endregion

}

