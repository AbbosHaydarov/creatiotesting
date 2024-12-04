namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignTimerFlowElementSchema

	/// <exclude/>
	public class CampaignTimerFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignTimerFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignTimerFlowElementSchema(CampaignTimerFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2be9fb0-f9e2-400e-a7f9-206a3251c665");
			Name = "CampaignTimerFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,143,203,10,194,48,16,69,215,13,228,31,6,220,55,123,17,55,161,126,65,127,96,26,167,37,144,23,121,160,34,253,119,141,169,168,11,151,7,230,204,189,215,161,165,20,80,17,140,20,35,38,63,231,94,122,55,235,165,68,204,218,59,206,238,156,113,214,237,34,45,79,4,105,48,165,61,72,180,1,245,226,70,109,41,158,140,191,12,134,44,185,252,186,21,66,192,33,21,107,49,222,142,27,15,87,82,37,227,100,8,114,117,128,154,0,152,65,109,207,250,183,43,190,228,80,38,163,21,168,154,251,55,22,62,141,126,202,116,173,252,218,38,144,59,183,21,21,215,7,209,194,228,161,251,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2be9fb0-f9e2-400e-a7f9-206a3251c665"));
		}

		#endregion

	}

	#endregion

}

