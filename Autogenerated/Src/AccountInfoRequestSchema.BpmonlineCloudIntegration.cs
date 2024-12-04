namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoRequestSchema

	/// <exclude/>
	public class AccountInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoRequestSchema(AccountInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d34c2d1e-3df3-49cb-81c1-5fa5d286583e");
			Name = "AccountInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,193,74,195,64,16,61,183,144,127,24,218,139,94,146,123,91,133,90,69,68,42,165,233,77,60,76,183,147,184,152,236,198,157,217,66,44,254,187,155,13,141,40,130,151,93,230,237,123,243,230,205,26,172,137,27,84,4,59,114,14,217,22,146,174,172,41,116,233,29,138,182,38,93,221,229,107,123,160,138,147,241,41,25,39,227,145,103,109,74,200,91,22,170,211,173,55,162,107,74,115,114,26,43,253,17,53,243,200,155,58,42,67,1,171,10,153,103,176,84,202,6,242,131,41,236,150,222,61,177,68,214,243,45,10,6,71,113,168,228,37,0,141,223,87,90,129,234,84,127,136,96,6,55,200,20,252,142,90,209,208,105,212,207,54,152,110,156,109,200,137,166,224,188,137,29,147,248,158,101,25,44,216,215,53,186,246,250,12,220,147,48,88,7,220,221,242,74,128,62,156,33,152,138,113,224,141,218,116,16,103,191,213,139,35,86,158,134,114,247,159,254,155,30,179,175,169,222,147,187,120,10,31,1,87,48,233,164,143,212,78,46,187,93,156,151,193,226,186,157,47,251,55,56,65,73,50,239,198,157,195,103,159,107,74,230,208,71,143,117,143,254,4,3,246,5,174,237,37,248,238,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d34c2d1e-3df3-49cb-81c1-5fa5d286583e"));
		}

		#endregion

	}

	#endregion

}

