namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountRestResponseSchema

	/// <exclude/>
	public class AccountRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountRestResponseSchema(AccountRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c549c9b6-fa79-24e6-145a-6a71c2ee8ca3");
			Name = "AccountRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,93,107,195,32,20,125,110,160,255,225,66,223,147,247,118,12,74,6,165,80,88,233,199,15,48,122,147,9,70,195,85,59,74,217,127,159,154,100,91,183,18,246,160,226,241,228,124,92,162,89,139,182,99,28,225,132,68,204,154,218,229,165,209,181,108,60,49,39,141,206,143,134,75,166,118,200,196,6,245,60,187,205,179,153,183,82,55,112,188,90,135,237,106,158,5,100,65,216,4,50,148,138,89,187,132,53,231,198,107,119,64,27,87,103,180,197,68,43,138,2,158,172,111,91,70,215,231,225,94,42,227,5,208,64,131,151,211,43,188,75,247,6,82,215,134,218,148,1,88,101,188,3,214,171,230,163,80,241,67,169,243,149,146,28,120,244,127,100,15,75,184,43,18,223,246,100,46,82,32,125,71,156,133,118,97,255,170,19,24,29,146,147,24,58,237,147,67,255,254,187,71,2,6,87,144,34,38,252,27,113,204,184,241,82,140,228,173,128,27,52,232,86,96,227,246,49,33,191,181,227,0,194,233,228,5,167,93,42,99,84,248,102,157,168,255,54,41,9,227,196,225,124,216,77,203,91,71,241,31,24,248,103,82,143,44,22,168,69,63,201,116,239,209,123,48,96,159,9,248,138,11,131,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c549c9b6-fa79-24e6-145a-6a71c2ee8ca3"));
		}

		#endregion

	}

	#endregion

}

