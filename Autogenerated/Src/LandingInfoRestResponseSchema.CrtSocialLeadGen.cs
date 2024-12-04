namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestResponseSchema

	/// <exclude/>
	public class LandingInfoRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestResponseSchema(LandingInfoRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2");
			Name = "LandingInfoRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,205,106,195,48,16,132,207,49,248,29,22,114,143,239,73,233,197,165,33,16,90,211,228,5,100,107,237,10,108,201,104,165,150,16,250,238,93,201,78,218,244,135,56,7,9,52,26,70,223,176,210,162,67,234,69,133,176,71,107,5,153,218,45,114,163,107,213,120,43,156,50,122,177,51,149,18,237,22,133,92,163,78,147,99,154,204,60,41,221,192,238,64,14,187,85,154,176,50,183,216,176,25,242,86,16,45,97,43,180,100,203,70,215,230,5,201,241,234,141,38,140,214,44,203,224,142,124,215,9,123,184,31,207,121,107,188,4,59,218,224,97,255,12,239,202,189,130,226,0,219,69,14,16,165,241,14,218,33,25,200,151,84,89,85,70,196,83,106,246,45,182,247,101,171,42,168,2,208,127,60,176,132,139,118,225,174,176,230,77,73,180,95,204,51,174,204,251,185,35,59,122,180,78,33,23,45,226,43,195,253,207,98,81,120,100,126,80,50,32,254,102,60,65,146,179,161,83,240,110,36,28,161,65,183,2,10,219,199,181,104,205,243,155,28,254,196,230,201,241,133,104,112,42,121,193,222,27,200,131,125,58,121,112,223,68,62,78,251,42,252,218,43,121,254,26,127,210,207,81,203,97,234,241,60,168,151,34,107,159,237,11,212,98,68,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2"));
		}

		#endregion

	}

	#endregion

}

