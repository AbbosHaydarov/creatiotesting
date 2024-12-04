namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAppEventListenerSchema

	/// <exclude/>
	public class CampaignAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAppEventListenerSchema(CampaignAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e");
			Name = "CampaignAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1f302b36-4763-41e5-806c-b1f1f1b6d901");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,77,107,219,64,16,61,219,224,255,48,40,23,7,138,116,119,28,65,226,56,224,146,210,82,135,244,188,150,70,210,82,237,172,216,93,133,168,37,255,189,163,175,68,142,227,10,66,104,115,17,210,204,219,55,111,102,158,150,132,66,91,136,8,225,22,141,17,86,39,206,95,105,74,100,90,26,225,164,166,217,244,247,108,58,41,173,164,116,15,98,208,95,9,85,8,153,210,217,24,192,223,144,67,147,112,21,59,142,221,58,97,220,150,223,68,126,20,124,45,34,167,141,124,157,238,7,238,24,165,148,174,133,113,254,196,96,202,141,192,42,23,214,46,160,47,116,81,20,235,123,36,119,35,173,67,66,211,96,131,32,128,165,45,149,18,166,10,187,239,239,88,24,180,140,180,160,208,101,58,182,224,52,72,146,78,138,92,254,66,224,241,253,20,41,250,253,249,96,64,80,148,187,92,70,16,213,181,143,150,134,5,108,14,229,76,120,240,252,124,210,255,165,45,190,128,111,13,103,155,124,41,184,9,92,74,98,145,157,44,203,121,68,136,12,38,231,94,51,131,118,122,149,23,132,32,29,42,91,11,63,84,222,70,10,97,132,2,98,151,156,123,145,230,53,62,56,47,220,144,117,130,216,51,58,25,146,247,45,172,58,92,16,250,203,160,33,104,248,186,81,220,107,25,195,215,122,6,205,166,231,47,78,65,87,229,20,106,223,77,38,67,197,126,221,216,114,211,143,113,253,128,81,89,123,244,70,167,41,154,79,112,36,17,206,189,210,162,225,2,132,81,29,246,78,207,198,184,63,235,221,149,228,31,195,69,217,144,121,47,252,22,222,91,169,112,203,135,227,50,31,242,238,133,223,194,123,109,68,170,120,138,219,138,162,204,104,98,95,14,232,95,203,134,243,113,214,139,50,150,200,139,190,99,163,199,130,1,207,148,7,169,158,239,241,47,198,108,214,190,166,24,80,21,174,130,76,80,204,253,254,47,255,177,144,49,247,5,193,149,6,210,46,171,175,152,68,27,224,183,167,63,11,42,116,254,120,203,91,180,150,151,216,184,253,3,52,62,148,243,15,219,95,211,71,216,250,179,152,119,109,253,4,41,110,111,233,230,187,141,238,7,31,103,211,63,35,90,166,196,108,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e"));
		}

		#endregion

	}

	#endregion

}

