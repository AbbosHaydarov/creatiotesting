namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StartOAuthFlowResponseSchema

	/// <exclude/>
	public class StartOAuthFlowResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StartOAuthFlowResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StartOAuthFlowResponseSchema(StartOAuthFlowResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b4b97235-8444-47bd-8398-56bb3b3cb9ef");
			Name = "StartOAuthFlowResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,193,74,3,65,12,134,207,22,250,14,1,175,178,123,111,69,168,11,130,7,177,84,125,128,56,205,174,3,179,147,154,100,20,45,125,119,103,119,186,197,234,37,144,127,146,249,191,63,17,123,210,29,58,130,70,172,9,156,182,247,209,168,19,52,207,177,122,224,45,5,173,54,121,132,163,146,206,103,251,249,236,34,169,143,29,60,147,8,42,183,86,53,28,91,223,165,178,179,156,207,242,200,165,80,151,27,104,2,170,46,224,201,80,236,46,240,231,134,222,19,169,13,51,121,170,174,107,184,214,212,247,40,95,55,199,126,242,130,86,184,7,101,231,49,0,58,199,41,26,40,201,135,119,116,5,142,163,161,143,10,24,2,248,216,50,24,131,14,46,128,201,222,160,205,94,213,228,80,255,178,216,165,215,224,29,184,129,171,96,61,174,242,66,97,59,58,47,224,22,149,86,197,115,82,243,110,206,158,235,41,219,90,120,71,98,158,114,192,117,26,190,45,239,127,83,141,194,139,132,115,68,22,255,61,30,236,196,250,31,118,162,85,147,225,226,167,43,14,159,237,161,35,91,230,139,228,114,56,130,81,220,22,182,177,47,234,185,120,248,1,68,49,30,80,240,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4b97235-8444-47bd-8398-56bb3b3cb9ef"));
		}

		#endregion

	}

	#endregion

}

