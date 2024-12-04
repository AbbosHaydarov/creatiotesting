namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartEventFlowElementSchema

	/// <exclude/>
	public class CampaignStartEventFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartEventFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartEventFlowElementSchema(CampaignStartEventFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2c0d06b-bc9a-4a03-b964-92f201a1b9c3");
			Name = "CampaignStartEventFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,75,14,194,48,12,68,215,173,212,59,88,98,79,246,8,177,169,202,5,224,2,110,226,150,72,249,84,137,3,84,136,187,147,210,162,194,134,157,103,228,177,223,56,180,20,7,148,4,103,10,1,163,239,120,91,123,215,233,62,5,100,237,93,85,62,170,178,42,139,77,160,62,75,168,13,198,184,131,26,237,128,186,119,39,198,192,205,149,28,31,141,191,53,134,108,30,223,1,33,4,236,99,178,22,195,120,88,116,115,39,153,24,91,67,32,151,3,64,115,6,248,130,12,168,84,4,233,29,163,228,8,236,215,53,76,74,147,203,156,237,8,49,27,104,182,159,39,226,235,203,144,90,163,37,200,137,242,63,36,172,37,126,208,139,220,183,120,206,157,201,169,185,246,36,179,247,2,230,7,72,81,46,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2c0d06b-bc9a-4a03-b964-92f201a1b9c3"));
		}

		#endregion

	}

	#endregion

}

