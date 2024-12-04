namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountMLangBinderSchema

	/// <exclude/>
	public class AccountMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountMLangBinderSchema(AccountMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b2c9475-0367-40a6-8f73-d4237f998eae");
			Name = "AccountMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,193,74,3,49,20,60,111,161,255,16,234,165,130,236,222,181,20,108,81,40,180,40,40,120,206,102,95,215,192,230,101,73,94,138,69,250,239,190,108,178,210,106,47,9,201,204,155,204,76,80,26,240,189,84,32,222,193,57,233,237,158,202,181,197,189,110,131,147,164,45,78,39,223,211,73,17,188,198,246,130,226,160,124,150,138,172,211,224,31,174,48,62,160,102,150,49,22,25,101,252,198,65,203,114,98,221,73,239,239,197,163,82,54,32,237,182,18,219,149,198,6,220,192,170,170,74,44,124,48,70,186,227,50,159,51,85,152,208,145,238,152,31,100,11,66,69,29,81,15,163,229,56,89,157,141,246,161,238,180,202,188,255,207,9,246,208,247,79,7,64,218,106,79,128,224,86,210,3,15,114,94,94,127,13,239,128,62,109,195,150,95,7,193,4,102,113,123,224,188,186,1,113,176,186,17,47,200,138,111,36,29,205,71,105,174,146,224,139,132,74,251,173,136,101,22,69,205,47,149,103,244,17,142,69,22,197,80,81,42,247,88,70,183,139,77,244,29,99,111,8,248,91,172,187,27,19,253,5,150,243,89,70,102,73,237,148,211,0,54,41,208,112,78,183,151,151,167,31,83,78,45,213,12,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b2c9475-0367-40a6-8f73-d4237f998eae"));
		}

		#endregion

	}

	#endregion

}

