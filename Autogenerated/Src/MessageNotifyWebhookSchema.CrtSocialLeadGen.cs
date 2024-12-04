namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessageNotifyWebhookSchema

	/// <exclude/>
	public class MessageNotifyWebhookSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessageNotifyWebhookSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessageNotifyWebhookSchema(MessageNotifyWebhookSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b64b5e73-bc62-4ff2-a773-7df631ba5e5b");
			Name = "MessageNotifyWebhook";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,83,59,79,195,48,16,158,139,212,255,112,162,75,89,218,29,80,151,22,33,16,45,149,138,196,128,24,28,231,146,24,28,59,242,57,170,66,197,127,199,78,220,71,66,129,178,88,202,249,243,125,143,187,40,150,35,21,140,35,60,161,49,140,116,98,71,83,173,18,145,150,134,89,161,213,104,165,185,96,242,1,89,124,139,170,127,182,233,159,245,74,18,42,133,5,174,173,86,245,139,123,210,234,106,119,177,170,200,98,238,218,72,137,220,247,160,145,123,138,70,112,135,113,168,129,193,212,85,97,42,25,209,37,60,99,148,105,253,190,100,134,208,212,128,241,120,12,215,84,230,57,51,213,36,124,207,145,136,165,8,74,91,145,84,176,110,30,141,182,232,241,1,252,197,203,121,140,222,28,249,112,142,121,132,102,229,200,153,20,31,141,163,199,194,222,169,139,87,135,44,202,72,10,14,220,11,217,50,44,106,130,32,202,97,156,97,119,118,69,7,112,115,215,213,91,23,102,72,220,136,8,9,124,40,18,33,15,14,18,109,130,11,175,254,187,252,163,170,124,221,71,127,132,172,21,15,215,49,194,58,19,60,131,120,39,96,157,49,11,25,43,10,116,163,216,55,105,145,54,169,45,141,46,208,216,106,120,238,27,157,215,33,237,4,145,53,126,188,83,79,177,129,20,237,21,144,63,62,155,20,254,80,102,171,2,79,37,247,216,14,185,80,22,158,92,249,31,204,51,180,76,72,140,67,18,133,31,62,232,100,59,136,83,197,28,188,62,30,200,236,160,253,166,173,174,215,11,18,7,168,226,102,131,218,235,20,104,4,186,157,90,214,93,127,89,169,16,37,185,41,111,127,173,31,86,168,99,33,56,166,160,63,200,191,187,81,101,142,134,69,18,175,67,235,201,158,163,227,228,136,137,166,218,46,126,126,1,47,76,203,32,81,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b64b5e73-bc62-4ff2-a773-7df631ba5e5b"));
		}

		#endregion

	}

	#endregion

}

