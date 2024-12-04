namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebhookDescriptionProviderSchema

	/// <exclude/>
	public class IWebhookDescriptionProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebhookDescriptionProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebhookDescriptionProviderSchema(IWebhookDescriptionProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96f3414e-d8a1-4585-8da8-b94ccc3c921b");
			Name = "IWebhookDescriptionProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,193,106,132,48,16,61,175,224,63,12,246,210,194,162,247,118,235,101,11,165,135,165,82,132,61,71,29,53,173,38,50,137,45,82,246,223,155,168,217,218,186,236,37,48,243,222,155,121,47,35,88,139,170,99,57,66,138,68,76,201,82,135,123,41,74,94,245,196,52,151,194,247,190,125,111,19,69,17,236,84,223,182,140,134,120,174,19,146,159,188,64,130,47,204,106,41,63,160,64,149,19,239,172,10,74,146,237,25,64,161,185,30,220,152,104,49,167,235,179,134,231,192,133,70,42,173,139,151,227,164,121,250,157,229,246,24,186,177,98,222,205,13,97,101,151,28,80,215,178,80,247,144,140,99,38,240,191,213,177,177,39,100,26,47,57,13,207,154,165,175,169,211,49,98,45,8,243,69,143,193,44,13,226,227,159,80,225,46,26,89,87,69,139,48,65,252,134,170,111,244,117,29,18,73,58,160,82,172,194,32,78,107,4,115,37,91,192,136,172,197,132,186,39,161,226,132,145,194,194,229,52,60,7,88,102,38,101,3,41,13,207,168,215,191,124,59,183,94,179,119,39,223,130,236,53,172,169,14,95,180,182,96,23,108,44,95,105,226,162,154,140,206,17,238,30,230,187,161,40,166,211,141,245,201,247,78,63,77,43,212,153,128,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96f3414e-d8a1-4585-8da8-b94ccc3c921b"));
		}

		#endregion

	}

	#endregion

}

