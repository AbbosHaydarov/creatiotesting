namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccessControlWhitelistEventListenerSchema

	/// <exclude/>
	public class AccessControlWhitelistEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccessControlWhitelistEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccessControlWhitelistEventListenerSchema(AccessControlWhitelistEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("828843c3-614a-4128-91eb-0082720e27a5");
			Name = "AccessControlWhitelistEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("95a133a1-cd5f-4df8-af8f-ad440775d7d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,77,139,219,48,16,61,59,176,255,97,112,15,235,64,145,239,105,18,112,211,133,150,110,63,216,108,233,161,236,65,145,199,137,138,45,25,73,49,132,178,255,189,99,201,134,120,107,239,110,247,188,151,128,71,51,111,158,222,123,10,40,94,161,173,185,64,184,69,99,184,213,133,99,27,173,10,185,63,26,238,164,86,23,179,63,23,179,232,104,165,218,15,90,12,178,43,229,164,147,104,223,61,213,192,174,26,84,174,237,163,206,52,77,97,105,143,85,197,205,105,221,125,95,75,235,80,161,129,66,27,184,204,132,64,107,137,133,51,186,252,121,144,14,75,58,191,4,194,144,238,4,232,193,88,15,149,62,192,90,90,68,94,90,13,194,96,177,138,31,167,196,222,115,139,190,118,242,133,158,72,12,41,225,17,226,175,145,195,100,43,14,88,241,175,36,29,172,32,30,167,27,207,239,104,188,62,238,74,41,64,148,220,90,24,111,28,64,195,2,38,24,17,24,25,65,191,209,27,131,123,50,6,190,160,59,232,220,46,224,187,145,13,119,24,78,235,240,1,141,150,57,220,160,69,183,225,68,55,209,187,223,40,28,88,84,57,154,57,180,166,70,81,146,132,77,243,174,204,126,88,52,68,80,81,43,173,96,89,93,19,125,159,3,143,194,110,176,210,13,38,217,230,122,139,166,145,2,153,175,127,198,211,188,77,65,116,223,81,36,184,192,114,138,178,215,37,28,14,2,241,145,171,188,68,219,123,253,73,17,33,135,121,48,157,193,166,68,110,64,180,59,65,23,19,138,182,209,248,55,27,161,82,115,195,43,104,83,191,138,195,165,227,181,215,185,83,134,45,83,223,50,62,129,241,250,150,54,183,17,235,227,181,152,12,152,191,65,86,56,52,126,65,102,246,182,141,21,72,101,29,87,244,226,4,241,230,82,181,15,199,29,176,95,232,111,10,57,119,124,192,165,75,18,169,111,140,204,59,127,191,169,94,160,161,191,111,97,108,59,96,239,251,142,50,198,206,134,251,41,12,46,70,103,185,233,146,113,238,238,99,134,109,121,243,234,214,164,91,94,157,23,89,21,38,159,239,83,4,240,148,85,31,176,196,215,167,53,155,52,171,211,231,69,118,245,179,255,247,176,30,252,109,250,234,61,249,248,23,199,227,70,164,166,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("828843c3-614a-4128-91eb-0082720e27a5"));
		}

		#endregion

	}

	#endregion

}

