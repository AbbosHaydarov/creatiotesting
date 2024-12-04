namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchOAuthScopesSchema

	/// <exclude/>
	public class GlobalSearchOAuthScopesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchOAuthScopesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchOAuthScopesSchema(GlobalSearchOAuthScopesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d20499a8-e69d-4f2f-b21b-32f0cd735faa");
			Name = "GlobalSearchOAuthScopes";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ca3090cb-7cbd-4956-acde-76442c58fa1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,81,193,110,194,48,12,61,23,137,127,176,216,5,46,233,125,99,76,8,49,196,97,108,82,183,15,8,169,161,149,218,36,114,28,105,104,218,191,207,105,7,3,196,46,145,242,252,252,252,252,108,117,139,193,107,131,240,142,68,58,184,29,171,133,179,187,122,31,73,115,237,172,90,53,110,171,155,2,53,153,106,56,248,26,14,178,24,106,187,191,224,183,173,179,15,55,43,132,183,240,115,77,181,182,140,180,19,11,65,168,66,190,35,220,203,96,88,52,58,132,123,56,231,190,206,35,87,133,113,30,67,71,245,113,219,212,6,2,139,85,3,38,53,252,207,207,196,187,188,39,253,23,228,202,149,50,225,173,83,233,139,121,158,195,52,196,182,213,116,152,29,129,21,50,104,239,201,121,170,53,35,132,164,8,37,122,180,101,90,76,196,184,66,136,1,9,248,224,81,157,148,242,107,169,169,215,164,91,176,18,251,227,40,53,72,216,22,77,74,122,52,251,72,2,230,4,64,109,101,51,107,80,77,243,174,173,83,185,220,57,48,37,7,226,176,91,243,217,209,34,18,161,229,164,53,78,207,223,128,206,224,223,119,2,233,152,89,70,200,145,174,139,106,249,41,87,177,186,153,27,57,76,88,151,106,29,54,142,151,173,231,195,120,2,79,176,42,250,92,85,17,189,119,196,32,151,58,66,27,71,173,110,210,225,179,239,223,204,37,169,62,246,238,223,163,151,160,96,63,212,211,121,130,141,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d20499a8-e69d-4f2f-b21b-32f0cd735faa"));
		}

		#endregion

	}

	#endregion

}

