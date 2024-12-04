namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookLogWriterSchema

	/// <exclude/>
	public class WebhookLogWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookLogWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookLogWriterSchema(WebhookLogWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1f5aa0c-1e22-41e9-b051-ad2f74579970");
			Name = "WebhookLogWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,201,106,195,64,12,61,187,208,127,16,238,37,129,98,223,187,228,208,116,161,208,148,66,186,156,85,91,113,134,218,51,97,150,20,83,250,239,213,120,236,212,118,74,201,101,96,164,247,164,167,39,73,172,200,108,48,35,120,38,173,209,168,149,77,230,74,174,68,225,52,90,161,228,241,209,215,241,81,228,140,144,5,44,107,99,169,58,223,253,251,20,77,28,231,76,154,166,112,97,92,85,161,174,103,237,255,141,222,215,74,125,64,169,10,248,212,194,146,78,58,100,218,131,110,220,123,41,50,200,74,52,166,227,60,168,226,173,97,112,158,133,240,27,157,104,42,88,24,220,10,42,115,115,6,79,90,108,209,82,72,110,194,7,52,97,174,100,89,195,139,33,205,3,73,202,252,52,163,111,144,28,157,144,204,67,209,97,7,6,26,171,93,102,149,246,125,26,121,1,49,158,178,9,244,224,126,190,253,1,67,100,131,26,43,144,108,252,101,236,6,114,226,153,151,7,217,46,144,92,164,13,186,33,183,246,140,141,153,140,38,28,150,156,130,95,95,20,141,64,151,35,152,223,105,244,253,191,27,11,178,107,149,31,98,4,107,131,207,118,231,124,34,135,219,209,146,238,243,120,214,241,69,62,48,97,143,82,241,177,96,65,241,236,198,55,2,190,102,255,253,203,184,173,18,185,151,214,26,216,224,39,119,142,131,187,182,167,192,11,244,151,221,86,237,220,219,162,6,146,86,216,122,153,173,169,66,246,111,104,104,114,211,203,46,80,50,87,39,119,100,239,249,34,80,102,116,85,63,178,218,73,252,187,188,120,218,120,222,43,205,69,251,61,146,57,223,176,165,80,120,180,228,150,27,224,201,146,236,53,173,230,170,116,149,124,197,210,145,153,236,1,122,217,157,10,182,249,244,119,246,255,41,139,224,43,19,58,107,134,112,220,82,219,244,239,43,226,232,247,15,163,139,186,210,108,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1f5aa0c-1e22-41e9-b051-ad2f74579970"));
		}

		#endregion

	}

	#endregion

}

