namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebhookEntityProviderSchema

	/// <exclude/>
	public class IWebhookEntityProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebhookEntityProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebhookEntityProviderSchema(IWebhookEntityProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd2e4593-dbe9-4b91-9fef-074b97ab2c88");
			Name = "IWebhookEntityProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e50fad81-60b2-4030-89a7-8b387fd6a892");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,63,79,195,48,16,197,231,86,226,59,156,202,2,75,178,211,208,5,170,170,18,160,74,84,98,118,147,75,98,53,177,173,243,133,42,170,250,221,241,159,132,150,194,192,18,197,126,239,221,253,124,182,18,45,90,35,114,132,45,18,9,171,75,78,158,180,42,101,213,145,96,169,213,205,244,120,51,157,116,86,170,10,222,123,203,216,58,189,105,48,247,162,77,86,168,144,100,62,255,246,92,150,33,76,150,138,37,75,180,206,224,44,105,154,66,102,187,182,21,212,47,134,245,182,70,48,164,63,101,129,4,186,132,3,238,106,173,247,128,62,217,39,99,42,189,136,153,110,215,200,28,164,98,164,210,179,175,63,98,40,116,235,55,67,53,231,116,236,238,59,185,37,172,28,46,56,197,32,121,158,7,216,132,34,81,191,230,10,27,47,210,178,7,10,32,46,2,124,73,122,208,180,183,112,144,92,123,196,223,140,147,245,82,117,45,146,216,53,152,89,38,55,155,5,68,190,55,63,115,56,66,133,60,135,211,64,136,170,136,144,63,137,95,145,107,93,252,7,119,133,28,17,207,131,251,131,42,236,24,65,162,5,229,48,30,103,195,184,103,11,127,15,195,34,201,210,96,57,39,8,185,35,101,131,201,26,204,101,41,177,24,59,101,233,40,123,127,60,163,199,137,127,119,195,221,60,163,205,73,26,255,108,198,62,247,241,85,92,31,222,141,228,244,5,7,72,16,213,152,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd2e4593-dbe9-4b91-9fef-074b97ab2c88"));
		}

		#endregion

	}

	#endregion

}

