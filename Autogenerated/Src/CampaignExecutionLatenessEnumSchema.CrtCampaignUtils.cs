namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignExecutionLatenessEnumSchema

	/// <exclude/>
	public class CampaignExecutionLatenessEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignExecutionLatenessEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignExecutionLatenessEnumSchema(CampaignExecutionLatenessEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("790d2649-25eb-4742-88b0-ff7156873fad");
			Name = "CampaignExecutionLatenessEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,147,61,79,196,48,12,134,231,86,186,255,96,137,21,93,249,154,16,69,66,165,27,220,194,77,108,185,196,109,45,53,78,149,164,124,8,241,223,73,123,13,32,29,215,99,128,209,214,235,231,125,237,40,44,52,186,78,72,132,53,90,43,156,169,252,178,48,92,81,221,91,225,201,240,34,125,91,164,139,52,57,178,88,135,18,74,238,245,37,20,66,119,130,106,46,95,80,246,131,236,78,120,100,116,110,212,102,89,6,87,174,215,90,216,215,235,169,190,69,39,45,109,208,65,59,73,161,50,22,228,4,2,140,164,101,4,100,223,8,93,191,105,73,2,6,243,57,239,36,100,77,118,236,199,198,35,90,243,105,61,120,236,154,36,43,195,8,57,156,28,143,91,252,204,89,25,223,16,215,208,136,39,132,13,34,131,38,87,145,69,181,23,122,191,21,4,242,233,28,249,193,104,4,108,81,35,123,7,207,228,27,240,20,90,210,176,162,97,207,223,123,78,142,106,29,230,139,56,94,70,116,14,103,115,57,226,57,129,28,212,22,67,101,193,55,130,193,117,40,169,34,84,16,94,210,147,20,237,215,91,14,73,247,132,41,162,56,135,243,127,241,141,0,193,10,220,223,29,49,230,190,97,117,232,158,23,65,255,190,253,38,200,106,251,83,134,50,244,62,0,137,13,88,198,97,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("790d2649-25eb-4742-88b0-ff7156873fad"));
		}

		#endregion

	}

	#endregion

}

