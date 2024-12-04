namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignDeduplicatorRuleSchema

	/// <exclude/>
	public class CampaignDeduplicatorRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignDeduplicatorRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignDeduplicatorRuleSchema(CampaignDeduplicatorRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("078983fb-8c59-4207-a217-01b1057fd97c");
			Name = "CampaignDeduplicatorRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,203,106,195,48,16,60,39,144,127,24,200,61,190,55,165,23,183,148,94,74,104,154,15,216,88,107,91,96,73,174,180,58,152,208,127,175,164,36,37,125,16,114,17,171,217,213,204,236,174,44,25,14,35,53,140,119,246,158,130,107,101,85,59,219,234,46,122,18,237,236,98,126,88,204,103,49,104,219,97,59,5,97,179,94,204,19,178,244,220,165,52,234,129,66,184,67,77,102,36,221,217,71,86,113,28,116,67,226,252,91,28,184,212,86,85,133,251,16,141,33,63,61,156,238,57,9,69,66,48,78,241,0,233,73,160,3,98,96,133,253,132,230,68,8,117,193,8,30,216,176,149,176,58,179,86,23,180,99,220,167,58,52,217,209,21,67,179,212,80,58,191,59,216,120,55,178,23,205,169,141,77,161,56,230,127,187,46,192,206,234,143,200,208,42,185,208,173,102,15,215,34,199,50,33,52,61,27,202,214,254,122,59,155,123,142,90,225,169,212,111,75,249,238,69,225,128,142,101,141,144,143,207,43,226,27,146,30,226,208,184,33,26,155,163,86,91,133,115,131,28,210,224,174,203,7,241,121,145,117,33,40,116,183,106,191,166,143,130,54,173,64,122,134,79,131,188,73,168,188,250,71,98,201,86,29,199,95,238,71,244,39,152,176,47,171,37,218,42,157,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("078983fb-8c59-4207-a217-01b1057fd97c"));
		}

		#endregion

	}

	#endregion

}

