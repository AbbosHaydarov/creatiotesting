namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysCultureServiceSchema

	/// <exclude/>
	public class SysCultureServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysCultureServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysCultureServiceSchema(SysCultureServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a4865d94-8357-4f78-a417-9cd6dcdf4fff");
			Name = "SysCultureService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,77,79,227,48,16,61,7,137,255,48,42,151,34,149,228,206,2,18,20,129,118,165,46,21,109,197,161,218,131,155,76,138,69,98,7,143,221,42,90,241,223,119,108,167,31,80,22,142,243,252,230,205,204,155,177,18,53,82,35,114,132,41,26,35,72,151,54,29,106,85,202,165,51,194,74,173,142,143,254,30,31,37,142,164,90,194,164,37,139,245,143,15,113,58,65,179,146,57,142,116,129,213,151,143,233,117,110,229,42,200,126,205,123,194,197,142,176,107,140,97,110,174,174,67,58,191,159,24,92,178,22,12,43,65,116,238,149,134,174,178,206,96,39,22,72,89,150,193,5,185,186,22,166,189,234,226,177,209,43,89,32,193,26,23,103,20,201,80,106,3,107,109,94,96,45,237,51,148,40,188,18,165,27,137,108,79,99,222,21,96,167,172,17,185,253,227,177,107,106,126,163,229,254,26,158,112,33,43,105,219,71,124,117,210,96,141,202,82,127,63,240,99,194,37,124,147,226,89,105,7,20,167,190,72,227,22,149,204,33,247,3,31,206,11,231,112,35,104,55,125,226,87,183,117,105,132,246,89,23,236,211,56,136,4,115,14,220,9,192,35,178,168,34,40,176,20,92,0,242,88,5,156,146,175,14,217,56,101,101,41,209,120,111,14,205,137,136,137,26,87,183,223,105,92,100,27,170,207,157,63,52,24,15,111,223,219,100,206,171,255,169,86,250,5,251,113,12,54,175,55,126,152,76,123,3,152,25,57,197,186,169,132,245,150,246,238,209,118,53,59,115,152,114,163,139,118,98,219,202,19,88,105,132,68,98,137,91,52,125,50,162,105,176,24,248,82,137,55,28,201,222,105,83,11,251,46,225,46,64,233,47,210,106,192,38,81,163,21,117,224,255,120,97,107,155,181,221,59,89,192,65,127,253,83,8,123,74,86,194,0,109,119,58,179,254,30,36,31,233,37,40,92,239,109,123,251,210,159,241,237,178,79,10,249,95,113,45,255,103,146,36,218,249,153,82,250,73,237,144,243,22,143,225,4,85,17,143,37,196,17,125,15,190,253,3,132,100,143,63,49,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4865d94-8357-4f78-a417-9cd6dcdf4fff"));
		}

		#endregion

	}

	#endregion

}

