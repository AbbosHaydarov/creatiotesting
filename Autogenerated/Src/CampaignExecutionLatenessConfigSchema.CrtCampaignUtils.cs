namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignExecutionLatenessConfigSchema

	/// <exclude/>
	public class CampaignExecutionLatenessConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignExecutionLatenessConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignExecutionLatenessConfigSchema(CampaignExecutionLatenessConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("363990ca-c5bf-49b2-9d2c-6f6312c3cdc6");
			Name = "CampaignExecutionLatenessConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,207,106,195,48,12,198,207,41,244,29,68,123,79,238,91,215,75,40,163,176,65,161,125,1,213,85,18,131,237,4,75,217,86,198,222,125,118,254,180,93,199,90,216,33,38,150,63,253,252,73,178,67,75,220,160,34,216,145,247,200,117,33,105,94,187,66,151,173,71,209,181,155,78,62,167,147,164,101,237,74,216,30,89,200,62,94,237,131,222,24,82,81,204,233,51,57,242,90,157,53,151,88,79,105,142,182,65,93,186,32,8,146,185,167,50,164,65,110,144,249,1,198,195,213,7,169,54,242,94,80,2,143,185,119,212,165,100,89,6,11,110,173,69,127,92,14,251,46,29,164,66,1,85,59,65,237,24,212,192,2,51,48,160,65,31,138,21,242,156,142,156,236,2,212,180,123,163,21,168,142,117,215,73,18,186,18,214,83,5,27,95,55,228,69,83,40,99,211,145,226,105,252,174,13,119,129,17,7,111,104,90,74,97,237,88,208,133,41,212,69,16,19,129,242,84,60,205,118,218,210,182,65,55,203,150,209,243,111,211,163,235,81,120,2,199,0,196,201,37,73,73,18,199,145,36,60,252,124,245,214,111,27,147,99,67,183,239,252,179,71,103,200,63,12,228,167,199,20,123,97,53,23,218,211,1,200,144,37,39,12,239,90,42,144,88,93,24,245,65,71,225,109,155,235,149,107,45,121,220,27,90,140,150,183,170,34,139,171,158,185,132,215,225,150,216,180,48,224,158,58,156,222,43,98,78,238,208,191,129,110,223,71,127,6,67,236,27,93,150,119,99,103,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("363990ca-c5bf-49b2-9d2c-6f6312c3cdc6"));
		}

		#endregion

	}

	#endregion

}

