namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UIRedirectBlacklistEventListenerSchema

	/// <exclude/>
	public class UIRedirectBlacklistEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UIRedirectBlacklistEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UIRedirectBlacklistEventListenerSchema(UIRedirectBlacklistEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dc5f9c57-1778-4929-bd4f-7a9a65741f1a");
			Name = "UIRedirectBlacklistEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cb307258-3a76-44c9-ba03-f25bdd404252");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,193,106,219,64,16,61,59,144,127,24,148,67,108,40,210,221,137,13,177,99,104,160,105,74,29,159,74,15,99,105,44,111,35,175,196,238,74,212,148,254,123,103,119,181,38,114,236,186,13,4,218,139,177,70,51,239,205,204,123,35,144,184,33,93,97,74,240,72,74,161,46,87,38,158,150,114,37,242,90,161,17,165,140,23,119,159,41,19,138,82,51,41,48,125,42,132,54,179,134,164,249,192,127,72,146,58,63,251,113,126,214,171,181,144,121,7,67,81,60,147,70,24,65,250,234,84,66,236,16,109,30,103,94,40,202,153,24,166,5,106,61,132,211,252,92,147,36,9,92,235,122,179,65,181,29,183,207,33,1,86,165,130,203,3,48,151,192,48,194,108,129,28,123,28,112,146,61,160,107,77,132,133,46,33,85,180,26,69,191,159,33,158,160,38,23,219,118,218,140,32,177,120,95,14,188,234,207,211,53,109,240,35,75,1,35,136,14,116,26,13,190,114,109,85,47,11,145,66,106,247,114,114,45,48,132,35,157,48,18,43,198,191,189,74,137,6,13,65,83,138,12,166,107,74,159,166,40,239,81,98,78,243,178,168,173,252,253,114,249,141,57,64,147,204,72,13,192,106,221,235,53,168,194,238,70,208,247,28,3,159,114,181,75,168,53,41,182,146,228,114,43,231,168,173,136,23,157,184,207,239,230,198,183,147,57,165,181,178,157,203,92,72,138,67,115,179,239,28,55,244,80,145,119,103,63,122,209,113,52,112,144,63,253,136,193,76,247,100,214,101,198,118,250,228,150,232,95,238,187,198,5,222,163,204,10,210,97,190,57,54,148,121,135,88,131,188,116,136,143,84,168,112,3,246,154,70,145,95,68,52,118,91,111,55,23,95,39,46,229,112,5,69,227,199,53,57,163,5,147,13,143,218,204,245,117,179,50,164,28,193,141,202,181,53,23,8,169,13,74,190,228,180,148,6,133,180,247,102,214,20,8,221,8,144,161,193,78,47,173,169,202,134,233,68,214,122,225,65,222,73,86,196,48,68,215,0,239,192,211,79,136,143,138,118,252,64,193,25,71,92,212,218,199,139,189,100,95,198,207,41,2,54,117,164,251,19,117,22,21,15,100,7,253,231,4,218,219,208,49,133,2,27,11,245,151,10,133,209,223,78,160,29,195,235,245,185,165,130,254,107,125,224,213,23,20,70,127,59,125,118,12,135,245,185,224,168,255,250,185,103,31,237,6,57,246,11,208,166,33,16,2,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc5f9c57-1778-4929-bd4f-7a9a65741f1a"));
		}

		#endregion

	}

	#endregion

}

