namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BooleanLandingiTypeWebhookHandlerSchema

	/// <exclude/>
	public class BooleanLandingiTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BooleanLandingiTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BooleanLandingiTypeWebhookHandlerSchema(BooleanLandingiTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a8724b0-e76c-4658-bbf3-973f18c33949");
			Name = "BooleanLandingiTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b9eb76ce-f311-4383-b358-4cd35dcab7fa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,77,143,218,48,16,61,131,196,127,24,101,247,16,164,85,114,103,129,195,210,86,173,180,173,144,64,234,161,234,193,36,99,72,155,216,209,216,89,138,16,255,189,99,59,166,187,116,217,246,226,200,243,241,222,204,27,79,148,104,208,180,162,64,88,35,145,48,90,218,108,161,149,172,182,29,9,91,105,53,26,30,71,195,65,103,42,181,133,213,193,88,108,238,207,247,231,41,132,217,7,81,88,77,21,26,142,224,152,27,194,45,3,192,162,22,198,76,224,246,248,133,185,78,222,149,231,57,76,77,215,52,130,14,243,254,254,21,55,59,173,127,194,78,168,178,70,2,169,9,30,180,174,81,40,176,135,22,65,146,110,224,145,189,76,93,101,17,37,191,128,153,26,68,81,27,13,5,161,156,37,87,186,202,62,45,58,99,117,179,102,224,158,248,99,224,77,32,119,80,223,222,161,20,93,109,31,42,207,151,186,10,180,76,175,166,141,239,192,181,7,51,72,250,162,99,165,175,80,140,191,51,67,219,109,234,170,128,194,169,3,255,204,129,9,92,229,102,48,158,17,159,103,201,151,164,91,36,203,163,152,192,210,243,4,255,165,238,222,192,193,79,85,201,20,138,27,112,186,254,45,108,44,214,88,114,115,143,25,161,227,121,28,221,74,119,84,32,235,108,172,80,214,100,177,155,251,55,200,125,11,14,211,9,252,54,185,107,60,28,76,217,207,99,195,186,141,123,252,27,84,101,232,255,165,24,159,209,238,116,249,63,74,156,139,217,247,111,177,21,196,45,90,214,230,73,212,221,181,250,188,197,135,122,9,103,73,165,218,206,38,243,85,80,203,167,130,150,175,160,186,55,30,73,179,105,238,29,127,32,9,109,71,202,204,151,130,12,150,1,103,154,71,235,51,101,244,230,7,22,54,32,97,218,15,201,23,49,6,183,189,131,129,191,240,227,244,223,108,173,31,245,30,41,117,202,57,167,4,47,100,182,166,131,231,74,125,216,29,104,206,113,14,32,52,188,11,227,136,54,8,53,244,230,0,194,139,205,167,217,87,182,216,65,0,56,135,23,194,32,36,90,37,147,112,143,249,150,58,12,217,49,68,202,203,24,201,203,28,131,202,176,147,49,194,238,72,239,65,225,30,222,255,42,176,117,123,157,222,38,71,207,125,226,86,89,176,170,151,45,75,250,94,125,153,225,39,116,249,96,130,245,165,241,52,26,254,6,19,54,164,119,34,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a8724b0-e76c-4658-bbf3-973f18c33949"));
		}

		#endregion

	}

	#endregion

}

