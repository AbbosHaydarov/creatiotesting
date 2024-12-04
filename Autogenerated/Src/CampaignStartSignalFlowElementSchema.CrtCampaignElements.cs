namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartSignalFlowElementSchema

	/// <exclude/>
	public class CampaignStartSignalFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartSignalFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartSignalFlowElementSchema(CampaignStartSignalFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("823b00f3-7d8f-4414-a5d0-9dfbf7ad3656");
			Name = "CampaignStartSignalFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,143,77,10,131,64,12,133,215,10,222,33,208,189,238,75,233,70,236,5,236,5,226,24,117,96,126,100,38,131,149,210,187,119,252,41,182,171,238,242,66,94,222,247,12,106,242,35,10,130,59,57,135,222,118,156,151,214,116,178,15,14,89,90,147,165,207,44,205,210,228,228,168,143,18,74,133,222,159,161,68,61,162,236,77,205,232,184,142,3,170,155,178,83,165,72,147,225,213,81,20,5,92,124,208,26,221,124,221,117,245,32,17,24,27,69,32,246,15,64,155,7,166,65,138,1,176,109,65,88,195,40,216,3,219,227,12,67,43,201,68,208,102,6,191,6,230,159,144,226,43,101,12,141,146,2,196,130,249,135,18,142,26,63,236,201,214,248,181,245,38,211,110,213,23,25,119,111,200,71,61,62,50,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("823b00f3-7d8f-4414-a5d0-9dfbf7ad3656"));
		}

		#endregion

	}

	#endregion

}

