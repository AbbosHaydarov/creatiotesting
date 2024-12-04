namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSharedOAuthClientSchema

	/// <exclude/>
	public class GoogleSharedOAuthClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSharedOAuthClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSharedOAuthClientSchema(GoogleSharedOAuthClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6e2a4fc-fe7f-4b18-9691-d148df804de7");
			Name = "GoogleSharedOAuthClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,77,79,195,48,12,61,23,105,255,193,42,151,78,66,237,29,182,73,48,4,66,226,75,27,156,16,135,208,186,93,164,46,169,156,4,132,16,255,29,39,221,198,58,214,29,56,116,93,156,231,103,191,103,87,137,37,154,70,228,8,79,72,36,140,46,109,58,213,170,148,149,35,97,165,86,131,163,175,193,81,228,140,84,85,7,66,120,214,19,79,175,68,110,53,73,52,251,16,115,157,75,81,167,15,231,206,46,248,158,17,199,132,21,23,130,105,45,140,57,133,107,173,171,26,231,11,65,88,4,212,180,150,168,108,128,102,89,6,35,227,150,75,65,159,147,213,121,134,13,161,97,132,1,161,86,217,16,18,33,15,153,80,106,2,19,248,160,106,175,69,211,212,50,15,250,210,53,109,182,197,251,114,137,165,112,181,189,144,170,224,246,19,251,217,160,46,147,173,118,134,39,112,207,214,193,24,226,158,134,227,225,43,51,53,238,141,43,113,39,172,173,79,26,172,69,119,228,70,236,59,255,254,218,163,149,177,228,188,181,236,210,99,224,109,17,187,174,132,192,22,220,75,252,171,177,141,52,130,196,18,20,75,25,199,206,32,221,234,74,170,120,50,202,194,69,192,173,36,244,52,159,112,21,63,225,77,242,9,60,243,95,46,175,48,247,6,135,155,223,227,208,83,70,167,240,38,12,38,91,73,59,40,240,91,23,125,175,44,64,85,180,46,116,45,185,67,187,208,133,119,131,180,229,68,44,14,24,50,67,235,72,241,146,112,235,220,183,31,63,239,133,223,13,62,255,111,111,250,76,165,182,212,100,100,16,33,39,44,199,241,254,15,32,189,9,47,255,108,90,138,179,9,72,158,157,80,57,166,163,108,205,21,38,177,150,9,250,157,249,100,129,176,135,0,174,209,118,2,201,225,129,180,86,71,109,33,80,248,241,119,212,93,186,157,124,255,149,247,76,170,141,118,131,28,251,1,75,84,114,159,117,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6e2a4fc-fe7f-4b18-9691-d148df804de7"));
		}

		#endregion

	}

	#endregion

}

