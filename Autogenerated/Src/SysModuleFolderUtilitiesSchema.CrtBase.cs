namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleFolderUtilitiesSchema

	/// <exclude/>
	public class SysModuleFolderUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleFolderUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleFolderUtilitiesSchema(SysModuleFolderUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da6824aa-e582-4158-850d-dede529eb3c0");
			Name = "SysModuleFolderUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,82,81,107,194,48,16,126,86,240,63,4,159,20,36,236,93,246,32,130,226,195,198,80,199,30,71,76,79,23,214,38,229,114,21,68,252,239,75,147,90,173,182,163,15,115,165,77,218,187,75,191,239,187,239,180,72,192,166,66,2,91,3,162,176,102,75,124,106,244,86,237,50,20,164,140,238,117,143,189,110,39,179,74,239,216,234,96,9,146,113,249,125,125,36,73,140,174,207,32,52,197,249,138,66,214,229,211,108,19,43,201,44,57,84,201,100,44,172,205,241,94,76,148,197,48,51,113,4,248,78,42,86,164,192,186,242,156,84,237,153,169,144,95,176,112,52,95,115,101,121,149,47,189,169,181,132,133,160,0,96,223,4,17,160,102,161,184,179,3,58,191,118,16,40,115,153,254,20,65,16,92,19,90,139,205,231,241,233,212,207,245,185,235,228,183,176,182,192,156,200,188,191,109,144,111,143,52,128,186,229,190,43,123,163,34,182,4,11,244,97,240,219,91,109,125,143,6,11,191,121,11,152,44,95,135,5,250,37,194,151,144,152,61,12,26,6,132,251,223,148,222,240,18,198,199,231,104,178,116,56,110,65,175,48,34,112,155,103,46,108,171,246,47,162,17,251,157,243,94,96,136,158,253,103,207,69,215,249,204,96,34,104,80,157,14,126,231,255,232,30,52,144,175,233,71,5,169,148,24,172,111,18,121,227,100,157,216,71,202,172,142,220,149,216,63,150,57,209,34,62,184,144,93,66,106,144,30,58,111,147,26,172,150,52,131,246,127,224,24,32,194,108,95,184,185,199,221,63,65,60,44,47,130,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da6824aa-e582-4158-850d-dede529eb3c0"));
		}

		#endregion

	}

	#endregion

}

