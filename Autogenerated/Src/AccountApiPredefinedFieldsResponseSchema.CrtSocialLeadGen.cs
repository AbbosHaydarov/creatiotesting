namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiPredefinedFieldsResponseSchema

	/// <exclude/>
	public class AccountApiPredefinedFieldsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiPredefinedFieldsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiPredefinedFieldsResponseSchema(AccountApiPredefinedFieldsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1521232e-cc77-4fda-b150-54054f3f6789");
			Name = "AccountApiPredefinedFieldsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,193,74,195,64,16,61,167,208,127,24,234,69,47,201,189,45,133,82,81,148,162,213,246,38,30,182,155,73,92,72,118,195,204,166,82,74,255,221,77,178,105,77,172,232,101,96,223,188,247,230,205,172,22,57,114,33,36,194,6,137,4,155,196,134,11,163,19,149,150,36,172,50,58,92,27,169,68,182,68,17,223,163,30,14,14,195,65,80,178,210,41,60,225,167,53,186,86,60,178,209,147,83,99,189,103,139,185,179,201,50,148,149,7,135,78,138,164,164,227,56,214,21,97,234,80,88,100,130,121,12,115,41,77,169,237,188,80,43,194,24,19,165,49,190,83,152,197,252,234,162,57,53,214,170,40,138,96,202,101,158,11,218,207,252,251,118,243,12,246,67,88,136,145,37,169,45,33,204,87,15,64,94,7,9,153,28,68,227,15,140,180,83,18,195,214,43,250,102,86,148,219,76,73,144,85,162,127,4,130,49,116,206,226,112,187,34,179,83,49,210,57,116,224,110,229,106,127,223,179,233,75,233,116,174,211,208,58,25,46,145,130,214,240,228,232,102,22,72,86,97,101,91,203,61,225,173,250,17,223,221,95,143,138,238,30,163,155,247,154,229,39,178,165,234,219,122,203,194,1,82,180,19,119,54,87,142,237,96,212,113,51,187,1,60,222,135,255,202,247,107,188,118,89,246,17,125,194,165,98,59,253,121,146,217,133,51,241,165,220,189,124,13,218,5,143,95,143,75,58,123,10,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1521232e-cc77-4fda-b150-54054f3f6789"));
		}

		#endregion

	}

	#endregion

}

