namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignEnumsSchema

	/// <exclude/>
	public class CampaignEnumsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignEnumsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignEnumsSchema(CampaignEnumsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c552018-5652-4db5-88b4-c7082c75a44f");
			Name = "CampaignEnums";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,146,207,78,2,65,12,198,207,144,240,14,13,30,188,24,86,61,26,32,49,252,81,79,30,132,7,168,67,23,38,153,157,25,103,58,146,141,241,221,45,187,130,34,44,92,188,181,219,111,219,223,180,159,197,130,162,71,69,48,163,16,48,186,156,123,35,103,115,189,76,1,89,59,219,105,127,116,218,157,118,235,34,208,82,82,152,216,84,220,193,11,147,31,185,194,27,98,90,136,126,161,107,173,8,179,44,131,126,76,69,129,161,28,126,231,59,5,240,10,25,180,100,10,153,162,164,4,145,37,4,151,131,199,192,90,105,143,150,227,37,160,98,253,190,169,146,7,229,234,73,224,131,243,20,184,132,220,5,80,41,4,178,12,28,208,198,170,125,111,59,63,251,5,224,211,171,209,10,72,192,27,185,91,242,200,214,1,122,245,225,129,56,238,161,85,179,215,43,173,86,251,237,126,224,116,132,89,72,180,161,57,196,105,205,35,237,254,121,182,166,132,1,92,95,85,171,251,79,128,41,154,120,130,224,201,170,63,12,55,103,25,208,152,125,142,181,230,149,75,12,104,75,57,209,246,196,175,24,133,69,130,227,112,13,76,247,210,99,0,183,18,126,214,126,35,187,168,45,119,196,126,187,203,161,121,161,183,68,86,209,212,184,245,152,12,150,115,171,185,209,136,149,2,146,72,234,45,246,35,17,168,64,249,160,219,208,115,98,168,16,147,117,179,225,89,115,157,167,58,97,179,154,76,91,88,96,25,27,118,52,150,210,57,183,236,250,200,101,66,83,163,199,77,109,115,243,134,117,127,126,1,61,145,59,198,23,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c552018-5652-4db5-88b4-c7082c75a44f"));
		}

		#endregion

	}

	#endregion

}

