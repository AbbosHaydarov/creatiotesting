namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookAccountResponseSchema

	/// <exclude/>
	public class WebhookAccountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookAccountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookAccountResponseSchema(WebhookAccountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cbf385ce-188b-4c9c-b713-0b0178ffc565");
			Name = "WebhookAccountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,82,219,106,194,64,16,125,54,144,127,152,47,48,239,181,20,212,66,17,132,130,10,125,158,172,99,92,154,236,134,157,89,37,136,255,222,201,13,74,45,150,250,16,216,156,61,103,207,153,11,0,56,172,136,107,52,4,59,10,1,217,31,100,186,244,238,96,139,24,80,172,119,211,53,186,189,117,133,93,57,161,162,199,210,228,146,38,147,200,10,195,182,97,161,106,150,38,138,100,89,6,207,28,171,10,67,243,50,252,111,168,14,196,228,132,65,142,4,103,202,143,222,127,2,26,227,163,19,208,187,218,59,166,233,40,207,190,233,235,152,151,214,128,41,145,25,62,122,229,188,23,110,6,29,60,193,2,153,126,191,212,39,218,160,55,185,58,224,141,52,146,15,192,52,68,51,129,80,104,15,121,211,134,185,77,51,198,97,9,109,225,203,158,190,104,224,2,5,201,172,125,104,6,215,174,17,255,116,212,46,223,117,124,85,214,206,86,52,122,190,187,199,60,17,78,88,70,2,171,19,53,58,73,173,226,124,36,77,18,52,142,101,197,89,208,233,46,232,25,141,216,19,221,207,149,123,95,194,138,231,29,245,241,54,232,82,17,148,182,178,114,223,206,234,190,108,148,187,110,169,143,219,141,43,200,62,6,243,71,133,195,172,135,245,218,118,138,159,206,19,253,174,105,242,5,161,155,157,44,77,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cbf385ce-188b-4c9c-b713-0b0178ffc565"));
		}

		#endregion

	}

	#endregion

}

