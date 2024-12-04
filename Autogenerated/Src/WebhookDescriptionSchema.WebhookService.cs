namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookDescriptionSchema

	/// <exclude/>
	public class WebhookDescriptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookDescriptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookDescriptionSchema(WebhookDescriptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("020f1299-16ac-4e29-87a6-9d2c2c565cca");
			Name = "WebhookDescription";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,147,75,75,3,49,16,128,207,43,248,31,134,122,81,144,221,187,173,21,180,82,17,209,170,69,207,233,118,218,70,183,201,58,147,40,139,248,223,157,36,91,41,62,81,47,121,204,243,155,201,196,168,37,114,173,74,132,49,18,41,182,51,151,31,89,51,211,115,79,202,105,107,54,55,158,55,55,50,207,218,204,225,186,97,135,75,209,87,21,150,65,201,249,16,13,146,46,187,111,54,231,248,228,68,17,226,156,178,53,249,153,54,15,162,21,125,81,20,208,99,191,92,42,106,250,237,125,164,136,113,10,79,56,89,88,123,159,175,172,138,53,179,218,79,42,93,66,89,41,102,184,77,134,3,228,146,116,157,248,50,1,148,53,219,34,156,139,0,70,100,107,36,167,145,247,96,20,157,147,254,125,254,40,24,162,99,176,4,28,118,183,64,88,160,154,34,113,64,249,200,178,130,25,232,88,190,72,123,236,72,202,222,133,180,247,225,36,249,195,51,204,209,117,67,220,46,188,252,6,224,193,35,53,80,43,146,151,113,255,33,185,12,129,70,111,113,254,78,68,40,76,236,96,98,167,205,247,52,167,23,147,59,153,12,184,74,30,135,226,240,247,180,108,61,201,92,174,205,198,215,137,219,185,144,244,112,29,221,90,193,103,217,183,208,76,211,168,252,68,19,40,92,83,35,216,89,60,163,113,218,125,213,130,40,137,207,6,70,90,190,223,105,193,133,169,211,31,139,119,123,7,27,123,148,247,138,104,188,94,197,163,38,231,85,213,190,96,96,56,142,25,199,194,176,189,3,225,35,102,25,161,243,100,214,91,124,144,223,168,202,99,59,0,253,237,78,242,58,23,138,206,78,248,153,89,170,60,174,47,175,243,137,0,157,242,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("020f1299-16ac-4e29-87a6-9d2c2c565cca"));
		}

		#endregion

	}

	#endregion

}

