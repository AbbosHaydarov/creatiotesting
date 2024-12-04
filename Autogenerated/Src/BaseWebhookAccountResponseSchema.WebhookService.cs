namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseWebhookAccountResponseSchema

	/// <exclude/>
	public class BaseWebhookAccountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseWebhookAccountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseWebhookAccountResponseSchema(BaseWebhookAccountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0327d562-7b53-46be-9ae5-db7a20f892a0");
			Name = "BaseWebhookAccountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,144,65,107,195,48,12,133,207,13,228,63,8,118,79,238,107,25,116,217,165,108,176,210,5,118,86,18,37,49,77,44,99,217,140,80,250,223,231,196,217,216,86,216,69,160,39,241,244,61,1,104,28,73,12,214,4,37,89,139,194,173,203,10,214,173,234,188,69,167,88,103,47,168,27,165,59,117,208,142,186,168,165,201,37,77,54,94,130,12,111,147,56,26,183,105,18,148,59,75,93,24,67,49,160,200,61,60,162,208,59,85,61,243,121,95,215,236,181,59,133,91,172,133,150,237,60,207,97,39,126,28,209,78,15,107,95,12,236,27,176,235,26,60,149,175,240,161,92,15,74,183,108,199,229,56,96,197,222,1,70,199,44,93,141,242,31,78,198,87,131,170,161,158,49,254,161,128,136,120,195,182,9,233,66,253,142,115,180,108,200,58,69,33,211,113,177,142,243,191,1,22,161,236,9,208,40,56,211,52,179,221,194,125,209,137,179,243,255,246,70,61,211,4,23,232,200,109,65,230,114,93,207,147,110,34,193,210,71,245,183,120,77,147,79,177,204,22,248,195,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0327d562-7b53-46be-9ae5-db7a20f892a0"));
		}

		#endregion

	}

	#endregion

}

