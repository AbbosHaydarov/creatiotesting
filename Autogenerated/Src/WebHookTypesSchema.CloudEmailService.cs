namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookTypesSchema

	/// <exclude/>
	public class WebHookTypesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookTypesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookTypesSchema(WebHookTypesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3d2ed00b-c1c2-42d1-a51d-b896bc7b6d83");
			Name = "WebHookTypes";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,203,106,221,48,16,93,59,144,127,16,201,198,129,224,15,104,232,230,62,146,64,26,8,181,67,23,165,4,89,158,235,136,200,146,59,26,155,152,146,127,175,100,203,175,212,116,35,52,175,163,115,102,70,154,87,96,107,46,128,101,128,200,173,57,81,178,55,250,36,203,6,57,73,163,207,207,254,156,159,69,141,149,186,100,105,103,9,170,155,201,222,27,132,217,90,2,32,36,135,157,11,185,224,37,66,233,112,216,94,113,107,191,176,29,183,240,3,242,123,99,222,250,112,221,228,74,10,198,115,75,200,5,49,225,211,214,89,145,99,224,206,9,233,9,77,13,72,18,28,220,83,95,62,196,3,84,74,142,184,37,41,142,45,104,202,186,218,105,243,135,215,17,69,37,144,167,28,69,54,92,62,66,49,202,150,19,176,131,59,50,89,1,123,1,95,238,205,155,5,248,20,238,193,189,53,227,134,91,132,64,13,106,22,248,63,147,84,210,147,77,238,128,82,126,130,244,183,242,117,241,252,192,213,192,232,99,228,53,2,205,25,236,43,107,185,106,96,145,24,120,95,130,46,134,190,172,155,244,8,244,106,138,237,14,77,205,110,141,44,216,61,215,133,26,187,29,63,91,64,183,0,26,132,159,62,107,86,166,39,186,192,201,141,81,44,195,110,141,112,216,29,223,65,52,100,144,21,249,120,189,102,255,7,30,20,19,118,163,246,185,52,113,3,69,202,144,107,203,251,228,56,244,43,90,191,251,47,213,79,56,123,83,85,114,19,40,76,140,112,234,48,19,156,196,43,139,143,239,2,234,158,48,92,109,80,251,110,148,202,185,120,219,2,125,228,110,240,186,156,231,31,136,126,51,101,114,68,52,120,107,176,226,20,95,252,12,129,65,14,38,110,191,5,88,27,188,54,249,220,225,95,23,215,142,205,114,103,2,255,19,87,118,16,48,46,245,48,167,86,34,53,92,49,55,117,255,81,221,30,222,161,105,234,7,232,226,81,84,64,240,31,37,201,76,218,39,6,37,219,139,54,120,215,206,222,247,23,151,231,245,153,82,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d2ed00b-c1c2-42d1-a51d-b896bc7b6d83"));
		}

		#endregion

	}

	#endregion

}

