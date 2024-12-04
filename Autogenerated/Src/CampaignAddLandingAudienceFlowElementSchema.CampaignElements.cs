namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAddLandingAudienceFlowElementSchema

	/// <exclude/>
	public class CampaignAddLandingAudienceFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAddLandingAudienceFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAddLandingAudienceFlowElementSchema(CampaignAddLandingAudienceFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96686031-a67a-4d43-b6a1-db7f65c9f6a9");
			Name = "CampaignAddLandingAudienceFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,77,111,219,48,12,61,167,64,255,3,209,93,146,75,124,111,226,20,109,218,21,3,214,97,67,151,243,160,74,180,35,192,150,92,125,36,11,138,253,247,209,146,109,56,169,235,230,98,88,148,248,248,30,31,169,88,137,182,98,28,225,55,26,195,172,206,220,124,173,85,38,115,111,152,147,90,93,94,188,93,94,76,188,149,42,135,231,131,117,88,46,186,115,63,197,224,252,254,142,174,232,242,139,193,156,50,97,93,48,107,175,97,205,202,138,201,92,221,10,241,157,41,65,137,183,94,72,84,28,191,22,122,255,80,96,137,202,133,196,36,73,96,105,125,89,50,115,88,53,231,135,191,200,189,99,47,5,2,19,2,26,4,96,13,4,96,204,159,183,233,73,47,191,242,47,133,228,192,107,30,231,209,128,107,184,99,22,187,183,67,68,39,212,16,250,118,50,127,26,93,161,113,18,73,43,253,59,228,14,69,124,114,42,40,4,168,189,142,113,247,77,0,215,133,47,21,40,242,0,88,33,153,5,230,64,27,153,75,197,10,176,36,141,59,112,58,8,239,4,75,5,188,161,87,139,126,175,122,82,181,36,64,239,200,33,41,16,172,51,193,64,237,13,199,231,0,220,209,88,7,22,63,106,18,111,144,163,91,80,101,250,252,107,84,162,18,81,232,136,234,208,231,17,201,27,37,95,61,81,23,212,64,153,73,52,160,179,214,202,143,68,68,239,30,189,236,76,167,142,13,16,28,44,72,236,118,84,205,2,149,53,7,40,181,192,2,50,109,192,109,169,25,21,242,154,133,128,98,156,130,145,59,230,176,45,223,52,236,87,141,216,224,27,248,243,218,63,46,122,204,199,178,142,79,245,130,77,38,36,12,210,213,9,32,220,220,192,244,36,148,130,194,253,24,252,116,99,209,208,133,34,151,201,170,217,44,208,154,216,193,2,41,236,88,225,49,60,249,196,242,39,116,91,45,206,156,242,123,204,164,34,3,150,22,17,184,193,44,189,106,183,41,144,189,74,86,193,144,122,182,107,61,21,163,97,226,178,98,202,217,51,102,60,68,12,58,111,148,93,245,106,196,217,174,193,163,243,251,173,228,91,104,30,210,194,133,110,217,174,114,191,208,50,105,241,62,88,162,136,13,143,216,238,142,141,145,233,172,177,112,199,76,179,181,79,97,224,210,99,163,231,148,25,51,194,245,180,27,235,198,160,182,63,207,124,139,37,219,208,184,167,125,184,249,187,251,152,246,217,82,31,131,12,188,136,48,81,252,208,219,8,61,50,33,49,122,28,164,216,127,148,55,84,49,92,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96686031-a67a-4d43-b6a1-db7f65c9f6a9"));
		}

		#endregion

	}

	#endregion

}

