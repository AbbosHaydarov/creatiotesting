namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiFormFieldsResponseSchema

	/// <exclude/>
	public class AccountApiFormFieldsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiFormFieldsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiFormFieldsResponseSchema(AccountApiFormFieldsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2106199-c783-417b-8ee7-13bea17b63c5");
			Name = "AccountApiFormFieldsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,84,77,79,227,48,16,61,23,137,255,96,193,133,189,180,119,64,149,170,174,216,101,197,71,22,122,67,28,140,61,109,45,37,118,214,227,0,21,226,191,239,36,113,210,38,117,74,132,138,184,88,202,204,155,55,207,47,227,97,154,39,128,41,23,192,102,96,45,71,51,119,195,169,209,115,181,200,44,119,202,232,225,189,17,138,199,87,192,229,47,208,135,7,111,135,7,131,12,149,94,176,27,120,113,70,23,21,127,208,232,179,58,113,191,66,7,9,209,196,49,136,156,3,135,84,10,86,9,194,16,234,216,194,130,162,108,26,115,196,83,54,17,194,100,218,77,82,117,97,108,114,161,32,150,120,71,162,168,14,10,252,104,52,98,231,152,37,9,183,171,177,255,254,57,187,101,110,201,29,147,128,194,170,39,11,108,18,93,50,235,235,216,220,154,132,241,146,153,33,216,103,37,96,88,113,141,54,200,210,236,41,86,130,137,92,203,78,41,236,148,53,172,160,184,139,172,121,86,18,236,90,238,128,252,161,179,125,199,223,74,74,208,5,97,153,111,180,109,100,7,21,69,205,65,93,82,176,78,1,17,69,69,157,7,60,228,190,251,236,234,228,40,255,151,71,63,30,139,148,231,71,103,139,95,69,25,246,198,22,224,206,200,12,58,222,195,12,92,227,11,216,48,199,164,200,5,89,142,65,203,82,107,25,240,241,118,184,229,9,141,25,130,118,1,63,234,204,231,189,80,178,117,11,69,115,112,41,251,152,32,202,238,51,120,117,97,39,166,107,192,62,237,200,208,153,36,39,253,155,209,104,213,176,166,51,1,208,30,77,242,23,236,231,211,63,175,160,219,168,74,227,151,56,117,157,197,78,165,49,76,151,134,222,246,135,158,117,193,191,243,185,125,155,131,145,5,9,115,165,65,238,240,45,4,250,188,91,105,205,86,236,185,240,117,163,38,104,31,55,238,210,215,146,183,92,175,96,244,218,188,180,43,133,238,124,99,67,143,55,215,53,134,36,134,247,73,136,214,111,146,113,181,82,122,209,109,173,128,32,243,22,138,154,108,87,246,238,23,126,62,216,217,57,140,175,52,116,176,245,80,179,30,163,93,26,182,71,119,28,24,231,96,191,214,28,149,209,102,240,253,63,185,61,31,246,54,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2106199-c783-417b-8ee7-13bea17b63c5"));
		}

		#endregion

	}

	#endregion

}

