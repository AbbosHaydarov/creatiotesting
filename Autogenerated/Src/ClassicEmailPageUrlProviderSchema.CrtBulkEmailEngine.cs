namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClassicEmailPageUrlProviderSchema

	/// <exclude/>
	public class ClassicEmailPageUrlProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClassicEmailPageUrlProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClassicEmailPageUrlProviderSchema(ClassicEmailPageUrlProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40199bb4-2b00-400c-807c-449a17321216");
			Name = "ClassicEmailPageUrlProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,147,77,107,219,64,16,134,207,49,248,63,12,202,197,134,218,138,85,59,24,39,246,193,78,10,129,182,152,98,231,82,122,88,75,179,98,137,180,43,246,35,16,132,254,123,71,31,73,44,39,17,13,189,72,104,118,222,217,119,159,125,37,89,138,38,99,33,194,14,181,102,70,113,59,222,40,201,69,236,52,179,66,201,126,47,239,247,206,156,17,50,110,181,104,188,250,160,62,254,198,66,171,180,64,67,29,212,115,174,49,166,65,176,73,152,49,139,250,37,194,219,148,137,100,203,98,220,235,100,171,213,163,136,80,87,237,190,239,195,181,113,105,202,244,211,170,249,110,52,128,165,8,50,82,193,254,215,119,200,26,221,248,89,230,31,233,126,223,32,103,46,177,107,33,35,50,57,176,79,25,42,62,184,123,111,227,225,23,248,73,32,96,9,94,135,61,111,248,135,230,102,238,144,144,149,176,236,235,58,12,44,224,189,242,154,25,164,41,4,149,158,175,108,148,52,86,187,146,27,33,218,86,91,212,29,167,56,106,30,26,153,69,3,130,84,76,210,229,41,78,77,136,16,106,228,203,206,51,248,171,146,214,91,92,117,37,99,154,165,32,137,197,210,115,6,53,249,146,24,150,57,240,86,123,250,134,240,165,112,237,87,205,149,182,97,210,177,239,96,223,154,6,237,225,195,114,200,217,2,14,4,103,112,178,4,57,20,13,44,148,81,205,171,13,143,246,200,80,91,10,220,63,160,187,65,35,98,73,39,41,243,240,1,138,230,56,234,145,114,77,230,129,174,166,140,249,179,116,71,202,187,8,150,43,240,112,206,57,159,206,194,209,36,8,46,71,211,240,235,116,116,8,46,249,104,130,51,22,205,231,243,201,236,112,225,93,117,216,185,109,39,218,98,154,37,116,181,159,51,118,12,124,215,76,168,236,229,23,197,249,134,233,232,135,138,92,130,247,129,159,79,10,31,35,97,253,60,40,58,125,173,93,242,112,252,187,149,145,248,156,169,181,75,30,94,140,213,127,23,57,106,85,239,131,78,15,59,45,226,152,110,234,191,108,52,67,222,58,57,93,120,53,115,146,179,58,125,237,98,209,239,253,5,248,113,43,50,58,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40199bb4-2b00-400c-807c-449a17321216"));
		}

		#endregion

	}

	#endregion

}

