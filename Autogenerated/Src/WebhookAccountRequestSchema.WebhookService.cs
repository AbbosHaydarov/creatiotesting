namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookAccountRequestSchema

	/// <exclude/>
	public class WebhookAccountRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookAccountRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookAccountRequestSchema(WebhookAccountRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3176958d-017e-4009-868d-c2180693d9ea");
			Name = "WebhookAccountRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,148,65,107,227,48,16,133,207,13,228,63,12,244,158,220,55,165,144,102,161,152,13,108,72,90,122,86,228,137,51,212,150,188,154,113,138,41,253,239,29,203,118,233,238,182,33,113,123,49,210,104,158,223,103,233,201,206,20,200,165,177,8,119,24,130,97,191,147,201,194,187,29,101,85,48,66,222,77,150,198,165,228,50,74,156,96,214,214,198,163,231,241,232,162,98,45,195,166,102,193,98,54,30,105,229,50,96,166,203,176,200,13,243,15,120,192,237,222,251,199,185,181,190,114,178,198,63,21,178,196,198,233,116,10,87,92,21,133,9,245,117,55,95,99,25,144,209,9,131,236,17,158,90,49,152,86,13,161,149,79,122,245,244,157,188,172,182,57,89,176,141,237,103,174,23,138,172,207,55,198,85,240,37,6,33,84,208,85,212,183,235,255,162,197,194,45,42,149,15,192,216,209,205,87,9,60,98,221,208,252,143,211,243,176,132,102,135,230,37,253,194,26,158,33,67,153,53,175,152,193,203,57,94,54,160,17,76,97,123,154,221,162,109,191,249,6,71,61,253,163,142,63,181,235,142,10,236,61,127,187,97,158,6,14,38,175,16,72,147,102,53,97,250,21,79,123,84,146,160,56,196,90,103,49,78,51,170,99,99,133,14,120,156,107,235,125,14,9,207,99,235,240,109,208,176,35,228,84,144,28,183,35,141,231,90,123,151,77,235,112,187,62,241,236,171,96,241,164,179,238,178,190,137,138,225,206,148,234,181,35,169,245,6,145,142,186,249,142,48,156,68,145,116,242,69,84,39,233,23,131,71,126,32,71,76,33,249,111,199,96,212,130,76,206,70,216,68,221,215,49,222,142,135,49,28,244,78,220,175,151,231,236,71,127,60,155,168,190,15,249,71,68,151,232,210,246,207,24,231,109,245,239,226,203,120,244,10,152,201,59,214,46,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3176958d-017e-4009-868d-c2180693d9ea"));
		}

		#endregion

	}

	#endregion

}

