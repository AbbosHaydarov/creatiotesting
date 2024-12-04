namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoResponseSchema

	/// <exclude/>
	public class AccountInfoResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoResponseSchema(AccountInfoResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("126bd8c9-55dd-b001-f748-1309e196c95f");
			Name = "AccountInfoResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,221,106,131,48,20,190,174,224,59,28,232,189,222,175,99,48,220,40,133,194,74,127,30,32,198,163,11,104,34,231,36,219,74,217,187,47,70,45,221,86,196,155,192,249,242,253,29,18,45,26,228,86,72,132,35,18,9,54,165,77,50,163,75,85,57,18,86,25,157,28,140,84,162,222,162,40,214,168,227,232,18,71,11,199,74,87,112,56,179,197,102,21,71,30,89,18,86,158,12,89,45,152,31,224,89,74,227,180,221,232,210,236,189,189,209,140,129,150,166,41,60,178,107,26,65,231,167,97,126,57,190,1,13,36,248,84,246,29,148,151,81,19,210,65,228,198,89,16,189,95,50,90,164,55,30,173,203,107,37,65,118,201,247,131,23,190,179,63,175,37,119,100,90,36,171,208,55,221,5,117,127,255,183,93,0,54,60,166,3,126,41,182,220,149,248,223,98,172,145,27,83,123,205,208,227,53,40,224,2,21,218,21,112,119,124,79,100,13,42,80,197,116,200,218,169,226,186,106,49,219,254,102,21,33,173,250,192,153,171,116,212,217,33,25,97,247,114,112,218,111,167,237,217,82,247,139,6,254,137,234,123,17,75,212,69,255,106,97,238,209,223,160,199,126,0,198,184,95,237,197,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("126bd8c9-55dd-b001-f748-1309e196c95f"));
		}

		#endregion

	}

	#endregion

}

