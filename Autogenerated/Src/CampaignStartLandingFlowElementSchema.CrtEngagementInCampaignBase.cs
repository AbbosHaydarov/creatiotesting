namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartLandingFlowElementSchema

	/// <exclude/>
	public class CampaignStartLandingFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartLandingFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartLandingFlowElementSchema(CampaignStartLandingFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61400b6c-6c0b-7653-fe9c-14375ff174b0");
			Name = "CampaignStartLandingFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,143,177,14,194,48,12,68,231,86,234,63,88,98,167,59,66,44,85,153,216,224,7,220,196,148,72,137,83,37,142,160,66,252,59,41,5,21,38,198,59,249,124,239,24,29,197,1,21,193,137,66,192,232,207,178,110,60,159,77,159,2,138,241,92,149,247,170,172,202,98,21,168,207,18,26,139,49,110,160,65,55,160,233,249,40,24,228,128,172,13,247,123,235,175,173,37,71,44,175,72,93,215,176,141,201,57,12,227,238,173,219,27,169,36,216,89,2,245,126,1,52,103,64,46,40,128,90,71,80,158,5,149,68,16,191,156,97,210,134,56,147,118,35,196,108,160,93,127,74,234,175,150,33,117,214,40,80,19,231,63,76,88,134,252,192,23,121,115,241,152,119,19,235,121,250,36,179,247,4,52,138,121,144,50,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61400b6c-6c0b-7653-fe9c-14375ff174b0"));
		}

		#endregion

	}

	#endregion

}

