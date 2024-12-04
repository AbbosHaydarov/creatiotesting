namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingLeadDefaultsEntityEventListenerSchema

	/// <exclude/>
	public class LandingLeadDefaultsEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingLeadDefaultsEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingLeadDefaultsEntityEventListenerSchema(LandingLeadDefaultsEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c533f17-6aa2-4943-af7f-3dea2285b86f");
			Name = "LandingLeadDefaultsEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("06216ff1-b4ca-40e0-be99-b3b390fd90e0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,145,49,79,195,48,16,133,231,248,87,156,194,80,88,226,189,180,12,180,221,162,50,192,134,24,174,206,75,48,74,236,202,103,35,85,85,255,59,73,10,67,165,168,116,180,222,189,207,239,222,145,227,14,178,103,3,122,67,8,44,190,142,197,202,187,218,54,41,112,180,222,209,145,148,202,146,88,215,92,140,4,20,27,23,109,180,144,199,127,244,98,243,13,23,251,49,149,221,5,52,3,116,213,178,200,156,74,118,85,111,44,193,213,26,53,167,54,202,104,58,140,142,210,74,132,67,232,125,90,107,90,72,234,58,14,135,167,243,243,79,165,218,7,154,77,144,102,132,145,69,24,191,47,126,41,250,18,179,16,128,91,241,100,2,234,101,126,125,133,226,153,5,47,187,47,152,120,37,111,78,186,135,191,79,40,247,175,230,19,29,111,251,210,105,73,249,68,232,252,225,67,101,251,180,107,173,33,51,148,116,99,71,115,186,41,26,29,79,195,21,224,170,243,33,148,58,169,31,98,42,116,223,4,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c533f17-6aa2-4943-af7f-3dea2285b86f"));
		}

		#endregion

	}

	#endregion

}

