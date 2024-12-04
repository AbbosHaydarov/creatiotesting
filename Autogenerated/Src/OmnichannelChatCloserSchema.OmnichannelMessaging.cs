namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelChatCloserSchema

	/// <exclude/>
	public class OmnichannelChatCloserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelChatCloserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelChatCloserSchema(OmnichannelChatCloserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("495695b8-7d6f-4949-94fd-1777698ef8a2");
			Name = "OmnichannelChatCloser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,203,110,194,64,12,60,7,169,255,96,193,133,74,85,114,111,121,28,82,138,168,132,138,250,56,87,75,112,97,81,178,27,217,27,30,170,250,239,221,236,210,52,9,168,234,205,118,60,227,177,103,163,68,134,156,139,4,225,21,137,4,235,15,19,198,90,125,200,117,65,194,72,173,194,167,76,201,100,35,148,194,52,156,35,179,88,75,181,190,234,124,94,117,130,130,109,8,177,38,188,171,178,151,35,27,204,44,71,154,98,82,18,112,56,69,133,36,19,219,99,187,122,132,107,91,133,56,21,204,112,11,53,250,120,35,76,156,106,70,114,157,81,20,193,128,139,44,19,116,28,157,242,103,204,9,25,149,97,16,109,40,120,44,108,245,50,252,129,71,53,124,94,44,83,153,64,226,6,95,28,107,229,204,30,245,114,114,192,164,48,218,170,8,202,45,43,201,15,18,211,85,169,121,65,114,39,12,58,149,65,238,19,40,105,172,60,205,210,66,143,240,78,85,236,23,15,122,168,86,158,233,148,159,104,231,104,54,250,223,188,83,52,205,74,255,205,42,183,150,41,127,110,40,26,233,53,184,21,2,66,83,144,170,171,130,241,24,250,245,124,8,10,247,173,113,253,22,219,117,105,116,240,245,239,133,220,201,253,215,182,157,174,224,238,126,102,228,126,131,10,164,1,201,96,100,134,165,155,231,118,250,74,46,72,100,160,236,43,30,118,155,90,187,163,242,48,144,84,133,112,16,185,238,203,96,23,163,65,226,238,104,81,197,97,29,115,122,64,59,73,166,16,41,236,180,92,129,127,43,248,183,9,55,48,187,151,46,178,218,7,108,200,254,40,55,160,151,91,251,121,4,191,147,127,204,218,9,171,187,105,251,240,130,241,45,111,156,53,65,19,23,186,3,79,14,185,36,92,149,112,238,255,101,161,175,54,139,95,223,89,156,84,101,35,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("495695b8-7d6f-4949-94fd-1777698ef8a2"));
		}

		#endregion

	}

	#endregion

}

