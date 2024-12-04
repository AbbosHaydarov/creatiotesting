namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookApiKeyResponseSchema

	/// <exclude/>
	public class WebhookApiKeyResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookApiKeyResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookApiKeyResponseSchema(WebhookApiKeyResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8fce16ad-5709-43b9-bd14-2a8342248eb7");
			Name = "WebhookApiKeyResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,146,65,111,130,64,16,133,207,144,240,31,38,120,105,47,112,215,106,98,109,210,152,86,99,180,73,15,141,135,21,6,220,8,187,100,119,105,66,141,255,189,179,44,8,7,231,2,251,242,102,222,124,11,130,149,168,43,150,32,124,161,82,76,203,204,68,43,41,50,158,215,138,25,46,69,244,201,68,202,69,206,215,194,96,238,180,192,191,6,190,87,107,146,225,208,104,131,101,180,175,133,225,37,70,7,84,156,21,252,175,245,205,238,174,97,248,182,230,214,244,203,19,220,200,20,139,232,141,25,70,137,70,177,196,80,67,224,3,213,68,97,78,3,96,85,48,173,167,240,141,167,179,148,151,101,197,63,176,217,211,194,82,104,236,189,113,28,195,139,174,203,146,169,102,49,72,189,13,18,59,3,50,169,200,133,116,84,152,205,195,135,19,195,120,1,68,11,92,156,9,195,96,234,122,81,71,163,164,120,136,242,126,198,203,31,157,169,170,79,5,79,186,212,135,49,48,133,87,166,113,224,0,42,186,81,247,98,171,199,223,41,89,161,50,28,233,14,118,237,220,177,235,1,120,47,191,163,209,64,196,218,62,205,25,97,185,91,195,5,155,14,228,222,61,130,233,245,150,105,131,229,9,213,211,150,254,14,152,67,200,218,253,195,231,14,209,86,135,169,141,178,223,215,1,194,21,114,52,51,155,58,131,155,93,213,243,38,40,82,71,211,158,157,58,22,111,129,255,15,117,213,209,45,133,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8fce16ad-5709-43b9-bd14-2a8342248eb7"));
		}

		#endregion

	}

	#endregion

}

