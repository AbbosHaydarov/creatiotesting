namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiFormListResponseSchema

	/// <exclude/>
	public class AccountApiFormListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiFormListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiFormListResponseSchema(AccountApiFormListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c594cadb-29f2-49ba-adfb-e460ee13e9d5");
			Name = "AccountApiFormListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,79,79,194,64,16,197,207,144,240,29,38,112,209,75,123,7,66,66,48,26,12,81,34,220,140,135,101,119,90,55,182,187,205,236,22,67,8,223,221,233,31,208,86,68,189,108,210,55,243,126,251,118,166,70,164,232,50,33,17,214,72,36,156,141,124,48,179,38,210,113,78,194,107,107,130,149,149,90,36,11,20,234,14,77,175,187,239,117,59,185,211,38,134,7,124,247,214,148,142,123,103,205,232,84,88,237,156,199,148,49,73,130,178,96,184,128,173,72,90,114,15,119,13,8,99,86,97,150,8,231,134,48,149,210,230,198,79,51,125,107,41,93,104,231,159,56,18,187,176,236,14,195,16,198,46,79,83,65,187,73,253,125,179,126,4,255,42,60,40,116,146,244,134,16,166,203,57,80,237,131,136,108,10,162,226,130,67,218,106,137,193,145,21,126,129,101,249,38,209,18,100,145,228,66,16,24,66,99,12,172,251,37,217,173,86,72,159,97,59,60,27,62,219,239,43,96,85,161,113,91,37,119,142,166,147,139,185,25,146,215,200,214,101,105,168,27,158,139,41,215,213,221,85,95,171,254,245,75,89,168,177,137,229,217,207,21,236,33,70,63,226,103,243,113,56,239,53,188,245,150,219,121,42,151,202,149,191,16,18,109,222,80,205,205,140,80,120,84,107,253,19,112,241,189,241,63,252,149,23,62,119,151,209,85,207,89,234,0,141,170,230,90,9,181,222,150,127,155,125,43,92,196,171,59,102,170,35,21,127,203,184,88,233,164,92,236,217,52,173,91,43,181,41,30,122,221,15,60,192,47,239,146,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c594cadb-29f2-49ba-adfb-e460ee13e9d5"));
		}

		#endregion

	}

	#endregion

}

