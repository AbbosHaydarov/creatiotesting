namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapErrorMessagesSchema

	/// <exclude/>
	public class ImapErrorMessagesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapErrorMessagesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapErrorMessagesSchema(ImapErrorMessagesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a97a27d8-986d-4adc-b58a-66f3167f55a1");
			Name = "ImapErrorMessages";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,193,10,194,48,12,134,207,27,236,29,10,222,125,128,121,28,10,194,166,131,10,158,107,23,75,97,75,74,218,41,34,123,119,71,43,138,48,143,201,255,229,207,159,160,26,192,59,165,65,156,128,89,121,186,134,117,163,108,95,228,207,34,47,242,108,197,96,44,161,144,129,71,29,74,177,31,148,219,50,19,55,224,189,50,224,35,229,198,75,111,181,240,17,90,98,178,228,246,177,219,89,232,59,95,138,54,14,38,237,107,98,209,136,154,116,165,240,64,161,34,68,208,97,179,136,72,224,27,240,76,201,209,57,226,32,125,255,230,231,45,203,35,53,25,139,71,110,239,221,153,9,205,31,223,7,234,120,194,44,199,220,128,93,138,30,235,41,253,230,167,57,189,0,80,72,229,168,75,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a97a27d8-986d-4adc-b58a-66f3167f55a1"));
		}

		#endregion

	}

	#endregion

}

