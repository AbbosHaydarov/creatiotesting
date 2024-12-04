namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendMessageRequestSchema

	/// <exclude/>
	public class SendMessageRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendMessageRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendMessageRequestSchema(SendMessageRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("394b7098-d52a-4248-b5d6-5a4098ccf4ac");
			Name = "SendMessageRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,193,78,227,64,12,134,207,32,241,14,86,185,176,151,228,78,97,37,40,8,113,40,32,218,27,90,33,147,56,89,75,153,76,25,59,72,44,218,119,199,51,73,129,182,168,171,238,37,137,29,255,206,124,191,157,22,29,201,2,11,130,57,133,128,226,43,205,38,190,173,184,238,2,42,251,54,155,92,206,166,190,164,70,14,246,223,14,246,247,58,225,182,134,217,171,40,185,241,90,156,221,119,173,178,163,108,70,129,177,225,63,169,131,85,89,221,97,160,218,2,152,52,40,114,12,51,106,203,41,137,96,77,247,244,220,145,104,170,202,243,28,78,164,115,14,195,235,207,33,78,10,168,124,128,208,87,130,122,16,211,3,59,71,37,163,18,184,190,85,182,108,145,175,245,56,17,34,108,196,67,17,168,58,29,253,147,53,59,71,33,163,120,225,98,121,190,17,228,177,219,195,5,42,154,74,3,22,250,203,18,139,238,169,225,2,138,116,202,77,44,56,134,205,94,38,51,47,237,250,97,203,93,240,11,10,202,100,222,220,165,142,253,251,117,67,82,226,138,84,192,252,144,120,215,223,4,228,144,27,249,234,194,166,13,125,230,5,155,142,62,194,185,105,7,17,92,204,111,191,8,63,235,18,240,148,220,19,133,163,27,219,22,56,133,209,160,25,253,136,6,44,29,184,140,135,24,224,97,121,127,131,154,116,28,79,58,134,191,187,32,149,113,172,104,67,142,11,5,190,74,19,143,171,198,45,136,134,248,100,43,225,80,119,163,77,123,179,34,218,78,26,235,31,81,87,73,135,239,199,97,159,233,255,35,82,52,12,184,36,251,105,42,166,176,27,201,22,245,118,164,36,124,228,114,149,233,170,227,178,31,225,117,249,29,210,161,193,246,187,154,226,62,187,154,180,220,59,153,117,57,156,79,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("394b7098-d52a-4248-b5d6-5a4098ccf4ac"));
		}

		#endregion

	}

	#endregion

}

