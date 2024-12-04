namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountRequestSchema

	/// <exclude/>
	public class AccountRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountRequestSchema(AccountRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2254511-5ed7-2a4b-f1ee-949aba2a67b2");
			Name = "AccountRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,207,74,195,64,16,135,207,13,228,29,6,122,207,222,85,4,73,65,4,193,160,125,129,233,102,18,22,146,217,56,179,123,144,210,119,183,217,77,164,90,233,101,96,254,124,124,191,97,28,73,39,180,4,123,18,65,245,93,168,106,207,157,235,163,96,112,158,171,15,111,29,14,175,132,237,51,113,89,28,203,162,44,54,91,161,254,188,132,122,64,213,59,120,178,214,71,14,239,244,25,73,67,186,48,198,192,131,198,113,68,249,122,92,250,221,254,13,36,223,64,231,5,48,99,16,167,22,3,105,181,98,230,130,155,226,97,112,22,236,44,186,242,108,114,154,159,56,141,248,137,36,56,58,103,106,18,152,247,230,79,152,52,168,133,230,15,161,245,35,58,158,229,215,246,85,175,65,28,247,43,178,75,4,28,161,167,112,15,58,151,211,13,81,115,129,130,99,13,200,150,110,251,14,222,15,137,91,176,151,133,250,207,185,37,110,243,255,169,207,211,223,195,211,55,109,19,228,33,231,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2254511-5ed7-2a4b-f1ee-949aba2a67b2"));
		}

		#endregion

	}

	#endregion

}

