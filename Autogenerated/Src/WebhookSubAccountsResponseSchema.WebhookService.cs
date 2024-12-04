namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookSubAccountsResponseSchema

	/// <exclude/>
	public class WebhookSubAccountsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookSubAccountsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookSubAccountsResponseSchema(WebhookSubAccountsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95258480-3f8d-4085-a822-2deac2e3e86d");
			Name = "WebhookSubAccountsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,207,193,110,131,48,12,6,224,243,144,120,7,63,1,220,71,85,105,219,161,154,212,83,59,169,231,16,12,141,6,54,138,157,85,85,181,119,159,25,176,77,235,129,136,252,193,127,62,200,13,40,163,243,8,111,24,163,19,110,181,120,97,106,67,151,162,211,192,84,236,29,53,129,186,240,74,138,221,156,229,217,45,207,30,146,88,12,199,171,40,14,54,211,247,232,167,67,41,118,72,24,131,175,242,204,190,42,203,18,54,146,134,193,197,235,118,217,31,112,140,40,72,42,160,103,4,123,31,109,14,161,141,60,192,5,235,51,243,59,56,239,57,145,130,96,252,8,230,67,106,70,14,164,197,90,90,202,111,235,152,234,62,120,240,189,19,129,211,220,112,76,245,211,220,33,135,245,134,71,120,118,130,75,188,166,54,63,253,207,29,245,59,216,161,41,57,26,99,209,246,65,20,184,253,113,174,62,187,153,125,112,138,13,72,170,23,189,76,218,123,238,234,221,91,215,102,225,254,67,109,225,143,31,110,208,161,86,19,162,130,79,43,176,39,207,108,249,2,81,131,66,193,191,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95258480-3f8d-4085-a822-2deac2e3e86d"));
		}

		#endregion

	}

	#endregion

}

