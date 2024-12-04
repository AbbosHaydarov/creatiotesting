namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetTokensRequestSchema

	/// <exclude/>
	public class GetTokensRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetTokensRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetTokensRequestSchema(GetTokensRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a97aed5f-6169-4529-9b9a-e0bbe2b1e025");
			Name = "GetTokensRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,65,75,195,64,16,133,207,41,228,63,12,245,82,47,201,189,85,65,43,136,66,75,105,188,137,135,109,50,13,139,217,221,184,51,171,196,210,255,110,118,219,212,182,4,197,203,194,206,126,111,222,219,25,71,82,151,48,199,79,54,154,204,154,147,39,50,122,18,15,92,168,103,13,49,170,100,233,52,75,133,73,134,86,138,74,126,9,150,1,138,7,90,40,164,90,228,8,83,203,211,202,184,226,81,51,150,54,16,201,204,20,88,81,178,196,119,135,196,20,15,54,94,19,93,88,44,219,103,152,86,130,104,12,15,200,207,230,13,245,30,11,72,237,86,149,204,33,247,196,57,0,99,184,19,132,153,201,219,48,139,74,240,218,88,213,70,251,144,57,30,122,68,173,85,180,221,217,161,46,118,142,191,185,211,159,246,116,218,60,74,211,20,174,200,41,37,108,115,211,21,110,235,186,85,134,239,131,31,206,1,76,143,201,151,123,193,98,134,106,133,118,52,111,41,184,134,161,248,81,14,47,95,3,229,119,177,176,166,70,203,205,168,7,216,199,36,182,126,89,199,214,27,40,145,39,64,254,216,77,161,63,110,55,190,127,102,173,247,50,127,239,15,219,67,156,166,237,156,67,203,179,184,189,139,219,126,3,225,69,2,64,171,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a97aed5f-6169-4529-9b9a-e0bbe2b1e025"));
		}

		#endregion

	}

	#endregion

}

