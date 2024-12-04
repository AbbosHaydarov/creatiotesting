namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailLicenseInformationResponseSchema

	/// <exclude/>
	public class EmailLicenseInformationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailLicenseInformationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailLicenseInformationResponseSchema(EmailLicenseInformationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3bb4a3c-028b-42dd-b032-27136305e1d1");
			Name = "EmailLicenseInformationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,75,75,3,49,20,133,247,133,254,135,75,55,234,162,51,184,181,42,232,180,139,66,235,162,173,43,113,113,59,185,51,6,242,24,114,19,100,44,253,239,102,30,173,173,80,16,103,145,132,195,201,185,231,203,128,65,77,92,97,78,176,33,231,144,109,225,147,204,154,66,150,193,161,151,214,36,217,108,189,180,130,20,15,7,187,225,0,226,23,88,154,18,214,53,123,210,201,42,24,47,53,37,107,114,18,149,252,106,47,77,134,131,206,154,166,41,220,115,208,26,93,253,248,35,173,168,114,196,100,60,67,220,43,107,152,224,83,250,15,192,60,183,49,240,138,65,201,156,26,89,154,194,58,221,85,57,201,76,207,67,223,166,232,49,246,246,14,115,255,222,105,85,216,198,16,200,21,50,195,76,163,84,139,46,115,254,19,185,234,167,223,193,51,50,101,202,6,113,144,186,144,136,220,29,46,208,28,228,167,147,226,90,122,176,5,80,51,146,193,91,136,164,2,42,114,32,176,78,96,94,192,248,22,198,16,76,107,37,209,115,93,98,59,242,45,73,111,201,93,191,196,95,6,15,48,18,49,190,94,52,17,89,51,122,116,211,115,159,176,75,227,97,122,110,131,29,148,228,39,177,83,92,246,127,165,83,142,80,212,29,72,207,213,242,66,124,201,72,216,112,253,15,162,189,251,202,88,210,165,254,155,163,227,119,245,198,24,183,253,55,153,127,255,121,197,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3bb4a3c-028b-42dd-b032-27136305e1d1"));
		}

		#endregion

	}

	#endregion

}

