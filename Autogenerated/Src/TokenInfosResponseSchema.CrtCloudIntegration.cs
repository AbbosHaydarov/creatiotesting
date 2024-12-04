namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TokenInfosResponseSchema

	/// <exclude/>
	public class TokenInfosResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TokenInfosResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TokenInfosResponseSchema(TokenInfosResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5c5f2197-25b9-40c8-8034-e8561b25d0ff");
			Name = "TokenInfosResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,147,79,75,195,64,16,197,207,22,250,29,134,122,209,75,114,183,165,160,65,164,66,165,216,222,196,195,38,153,132,197,205,108,216,217,69,66,233,119,119,255,180,181,34,130,135,92,118,153,121,179,243,30,63,18,18,29,114,47,42,132,194,216,66,105,87,175,200,98,107,132,149,154,178,181,174,81,113,246,234,71,52,49,242,116,178,159,78,174,28,75,106,225,5,63,173,111,234,198,102,207,172,105,126,22,182,3,91,236,178,66,43,133,85,88,195,217,19,18,26,89,125,207,236,208,24,17,223,22,154,26,217,186,100,232,7,252,200,181,193,214,23,80,40,193,124,7,59,253,129,180,162,70,115,84,243,60,135,5,187,174,19,102,88,30,235,109,42,65,250,41,16,165,118,22,108,120,5,229,0,189,18,182,209,166,3,65,53,136,190,87,178,138,94,167,85,249,197,174,222,149,94,134,42,24,127,251,194,69,134,7,193,232,7,61,6,127,158,147,110,140,238,209,88,137,62,238,38,238,72,250,91,32,115,20,135,155,89,204,52,187,125,15,210,209,138,173,137,60,98,218,61,180,104,231,192,225,56,28,29,144,234,100,226,171,212,187,108,141,74,139,199,193,197,227,242,226,217,15,96,171,71,114,29,26,81,42,92,36,120,203,228,198,227,226,75,193,255,32,24,191,138,68,110,45,36,129,168,42,237,200,254,159,81,216,238,49,133,235,62,189,61,253,99,176,255,21,115,58,57,124,1,173,61,87,201,167,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5c5f2197-25b9-40c8-8034-e8561b25d0ff"));
		}

		#endregion

	}

	#endregion

}

