namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdminUtilitiesSchema

	/// <exclude/>
	public class AdminUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdminUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdminUtilitiesSchema(AdminUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("170e19f8-c937-4f98-aec0-9d08e2acf0d5");
			Name = "AdminUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,201,110,219,48,16,61,211,128,255,129,208,137,58,152,144,208,34,105,16,244,16,91,114,32,160,40,10,199,105,15,69,14,140,52,118,8,80,164,202,197,173,81,228,223,203,197,173,34,55,57,72,67,190,153,121,111,22,58,195,229,30,223,29,141,133,254,122,62,115,241,186,5,173,153,81,59,75,87,170,239,149,124,213,161,225,13,152,86,75,239,153,207,36,235,193,12,172,133,137,95,238,248,222,105,102,185,146,243,217,239,249,12,13,238,81,240,22,27,235,177,22,183,130,25,131,111,186,158,203,123,203,5,183,28,140,15,10,129,103,145,26,88,167,164,56,226,91,199,59,92,193,110,165,132,235,229,134,239,159,236,39,56,128,104,58,252,17,75,248,25,3,72,86,20,151,235,226,125,93,47,202,117,93,46,170,117,89,46,174,46,203,229,162,40,202,234,162,168,175,222,125,88,93,100,249,53,66,40,104,253,175,23,101,110,193,110,148,178,169,62,201,109,211,145,123,3,218,183,37,161,13,61,97,55,185,230,56,86,142,238,64,120,0,155,100,82,89,9,35,103,9,116,171,6,82,230,52,117,67,178,166,203,114,186,214,170,39,153,223,210,63,97,15,70,98,244,237,9,52,76,125,219,227,0,95,153,112,224,131,26,83,255,112,76,144,68,23,230,111,44,41,242,156,222,72,63,147,47,76,131,244,29,9,136,50,141,249,236,132,32,57,102,230,84,157,95,164,215,72,91,38,7,166,113,247,88,255,130,214,89,165,125,23,211,210,105,45,141,211,80,45,71,136,228,127,7,48,225,96,150,109,252,246,32,112,164,145,208,196,10,9,38,163,202,72,128,248,14,147,49,149,6,243,130,31,33,13,214,233,243,5,248,199,24,198,225,129,3,104,235,211,170,101,28,205,86,197,87,49,242,125,15,147,126,200,83,195,8,61,39,123,50,241,159,206,39,149,144,77,235,126,176,199,152,17,124,254,123,254,3,45,84,32,219,79,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("170e19f8-c937-4f98-aec0-9d08e2acf0d5"));
		}

		#endregion

	}

	#endregion

}

