namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailAttachmentUploaderSchema

	/// <exclude/>
	public class EmailAttachmentUploaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailAttachmentUploaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailAttachmentUploaderSchema(EmailAttachmentUploaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7453c0f-fd21-4f21-8c73-c15c9fdbf8ae");
			Name = "EmailAttachmentUploader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,77,107,220,48,16,61,59,208,255,32,156,139,13,139,125,207,199,194,54,205,6,67,210,150,38,57,133,80,20,121,236,21,216,146,145,70,91,76,201,127,239,200,218,47,109,178,189,24,107,244,230,205,123,79,163,120,15,118,224,2,216,19,24,195,173,110,176,184,209,170,145,173,51,28,165,86,236,239,151,179,196,89,169,90,246,56,90,132,254,242,232,92,84,63,246,165,74,33,180,161,113,49,200,194,31,77,67,236,118,15,57,49,167,88,202,14,158,135,78,243,250,115,172,129,83,245,98,201,5,106,35,167,41,132,57,55,208,122,229,55,29,183,246,130,221,246,92,118,11,68,46,86,61,40,12,51,192,76,208,151,111,208,112,215,225,87,169,106,34,206,112,28,64,55,89,181,23,3,38,159,177,239,148,18,187,102,233,9,170,52,127,37,174,193,189,117,82,48,225,167,158,26,202,46,88,196,77,109,148,47,125,119,162,151,18,186,154,84,255,52,114,205,17,194,101,89,150,236,202,186,190,231,102,156,239,11,0,76,24,104,174,211,103,11,134,210,84,32,124,148,105,57,103,82,89,228,74,64,177,67,151,135,253,67,96,103,113,35,251,237,162,115,136,51,57,7,85,7,117,177,84,2,90,52,206,103,239,5,79,246,3,98,19,197,137,16,178,163,169,78,228,211,150,37,201,209,124,138,220,9,255,234,201,251,255,149,60,0,174,116,125,36,98,114,45,213,10,140,196,90,139,77,84,81,252,69,248,9,18,179,59,39,235,25,35,75,180,9,51,246,54,34,188,188,230,20,230,129,163,181,150,53,251,208,196,26,226,172,118,189,76,209,186,108,9,88,205,145,111,253,173,185,153,176,191,96,208,86,82,110,35,89,156,214,52,172,240,88,220,1,94,45,35,196,60,83,240,231,48,235,133,105,157,143,51,75,227,180,210,217,241,251,229,249,101,52,246,86,161,196,177,82,141,166,177,158,213,79,10,197,224,201,95,101,233,130,154,215,84,243,183,68,186,53,231,93,109,141,36,52,4,73,195,134,231,1,122,82,250,136,6,120,159,77,134,103,1,246,164,145,119,158,231,30,84,139,43,130,251,219,34,156,38,200,123,144,24,167,178,121,23,223,152,197,194,73,14,239,44,4,99,159,111,69,168,198,69,170,253,3,246,38,199,254,234,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7453c0f-fd21-4f21-8c73-c15c9fdbf8ae"));
		}

		#endregion

	}

	#endregion

}

