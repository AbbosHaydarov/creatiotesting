namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookParserSchema

	/// <exclude/>
	public class WebhookParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookParserSchema(WebhookParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27f94e71-ff84-4026-a617-5aa9c6d13750");
			Name = "WebhookParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,83,177,110,194,48,16,157,131,196,63,156,96,161,75,178,183,52,75,144,42,85,64,145,90,169,179,227,28,137,219,196,70,182,83,68,43,254,189,103,39,148,2,1,164,14,205,96,201,231,247,222,61,191,115,36,171,208,172,24,71,120,65,173,153,81,75,27,38,74,46,69,94,107,102,133,146,225,179,226,130,149,83,100,217,3,202,126,239,171,223,11,106,35,100,14,115,92,91,37,61,227,209,40,121,215,239,209,209,80,99,78,44,72,74,102,204,45,188,98,90,40,245,190,96,218,160,246,128,40,138,96,108,234,170,98,122,19,183,251,22,5,43,15,11,119,168,232,23,108,85,167,165,224,96,44,153,226,192,157,250,177,120,64,214,104,253,177,48,67,91,168,140,76,44,60,183,57,60,110,239,11,94,1,74,186,34,72,101,197,114,3,235,214,81,198,44,115,126,78,13,53,21,114,204,42,144,20,226,253,192,97,7,241,132,86,88,23,130,23,32,12,72,196,12,172,130,20,129,43,249,129,218,54,123,91,116,247,83,233,27,114,27,142,35,47,188,239,163,209,214,90,154,120,122,137,179,3,57,214,97,94,142,54,247,172,93,212,254,202,251,242,200,88,237,102,234,238,112,3,110,198,65,208,200,129,155,109,210,120,15,39,72,73,211,107,16,159,248,228,187,142,79,148,227,145,215,160,215,16,4,219,171,153,211,227,51,44,199,255,140,253,76,203,107,201,207,174,208,206,135,223,50,59,242,63,56,249,243,8,186,244,59,166,48,68,153,53,127,134,223,251,42,208,119,88,223,126,3,202,159,170,45,17,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27f94e71-ff84-4026-a617-5aa9c6d13750"));
		}

		#endregion

	}

	#endregion

}

