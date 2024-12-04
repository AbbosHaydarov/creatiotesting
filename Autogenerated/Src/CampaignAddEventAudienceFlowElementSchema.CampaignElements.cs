﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAddEventAudienceFlowElementSchema

	/// <exclude/>
	public class CampaignAddEventAudienceFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAddEventAudienceFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAddEventAudienceFlowElementSchema(CampaignAddEventAudienceFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("945115d3-d0ef-4241-8e98-d8197d804ff3");
			Name = "CampaignAddEventAudienceFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,77,79,227,48,16,61,7,137,255,48,42,151,86,90,165,119,160,149,160,20,22,137,69,172,10,218,179,177,39,173,69,98,135,177,83,182,66,251,223,119,28,39,105,203,182,208,189,164,245,120,62,222,188,121,99,35,10,116,165,144,8,143,72,36,156,205,124,58,177,38,211,243,138,132,215,214,28,31,189,31,31,37,149,211,102,14,179,149,243,88,156,117,231,205,16,194,244,234,146,175,248,242,132,112,206,145,48,201,133,115,167,48,17,69,41,244,220,92,40,53,93,162,241,23,149,210,104,36,94,231,246,109,154,99,193,166,58,108,56,28,194,185,171,138,66,208,106,220,156,167,191,81,86,94,60,231,8,66,41,192,16,15,162,73,0,24,163,65,27,144,77,145,180,77,52,220,200,84,86,207,185,150,32,3,158,67,224,192,41,92,10,135,157,231,46,192,9,211,194,223,117,179,214,56,47,140,231,134,31,72,47,133,199,120,95,198,3,200,112,15,206,83,32,174,46,252,40,104,142,252,229,230,238,121,10,48,130,222,134,189,23,185,76,78,208,168,88,98,187,222,3,217,18,201,107,172,11,90,143,210,163,138,46,31,137,172,13,140,207,11,233,111,21,35,201,171,194,128,9,53,69,174,133,11,252,89,210,115,254,113,76,169,244,144,89,170,249,238,152,254,192,240,191,20,115,159,13,6,176,75,150,133,86,216,54,59,179,21,73,156,213,153,59,20,147,26,68,221,247,59,112,187,103,92,154,63,127,2,11,157,211,127,113,80,207,248,19,2,158,140,126,173,184,19,197,20,235,76,35,129,205,162,160,246,117,20,85,115,83,105,21,7,198,220,109,97,253,28,220,15,244,11,171,246,201,33,210,1,55,232,183,68,24,205,253,1,132,165,75,146,165,160,118,36,35,48,248,214,132,245,159,28,18,179,100,248,63,151,26,212,190,73,26,57,237,239,18,215,55,232,49,157,131,244,194,245,123,119,218,188,160,154,50,11,126,21,140,135,68,127,49,195,152,120,61,183,54,231,53,217,98,103,198,214,225,215,2,9,247,33,110,72,103,216,183,110,250,90,137,188,31,43,166,15,130,216,195,35,197,200,91,53,24,0,203,56,194,11,207,83,146,68,214,210,89,137,82,103,171,123,123,103,229,203,119,205,235,217,31,68,7,66,95,81,43,248,218,116,248,60,191,222,182,43,204,180,65,199,23,200,171,79,152,141,122,237,136,127,86,72,171,222,112,220,45,89,152,107,41,88,198,82,151,225,1,57,96,217,106,75,236,192,141,55,106,68,6,66,114,150,58,173,224,109,161,229,2,26,199,240,4,133,249,184,174,242,102,161,243,97,155,111,207,54,175,21,219,204,217,117,98,29,141,247,10,121,247,6,71,170,183,141,108,251,11,109,106,253,64,141,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("945115d3-d0ef-4241-8e98-d8197d804ff3"));
		}

		#endregion

	}

	#endregion

}

