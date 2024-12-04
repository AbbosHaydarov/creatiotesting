namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleOAuthClientSchema

	/// <exclude/>
	public class GoogleOAuthClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleOAuthClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleOAuthClientSchema(GoogleOAuthClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3c16520-2979-4ffd-92ac-fac71311fb0b");
			Name = "GoogleOAuthClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,77,75,195,64,16,61,183,208,255,48,228,148,66,73,238,53,13,104,197,34,136,66,213,147,120,216,110,39,113,33,217,13,251,161,20,241,191,59,187,105,107,218,164,120,88,54,243,241,222,204,188,201,74,86,163,105,24,71,120,65,173,153,81,133,77,150,74,22,162,116,154,89,161,228,100,252,61,25,143,156,17,178,60,73,209,120,117,193,159,220,49,110,149,22,104,134,50,158,21,23,172,74,158,174,157,253,160,56,101,164,105,10,153,113,117,205,244,46,223,219,107,108,52,26,148,214,0,147,176,82,170,172,16,2,6,120,37,200,159,28,128,105,7,249,118,139,5,115,149,189,17,114,75,85,99,187,107,80,21,113,192,45,3,108,58,131,71,154,24,22,16,181,164,157,88,52,125,39,142,198,109,42,193,169,10,51,6,122,57,48,135,142,69,233,94,156,222,4,193,65,42,26,171,157,151,194,55,219,239,182,245,52,76,179,26,36,53,181,136,156,65,253,160,74,33,163,60,75,67,32,228,237,91,234,53,19,19,191,23,247,8,155,193,43,125,82,97,137,220,239,46,68,254,204,41,120,182,209,28,54,204,96,220,65,157,167,133,161,126,194,114,134,103,91,163,117,90,210,110,168,23,106,68,112,70,83,66,65,135,236,75,235,186,164,128,110,201,242,204,32,2,215,88,44,162,225,223,37,185,15,151,63,199,162,81,154,131,32,161,153,228,152,100,233,129,43,200,166,149,165,137,112,11,234,147,248,196,22,97,128,0,86,104,79,28,241,63,26,6,113,70,109,33,144,248,213,221,203,41,209,25,210,191,6,175,170,63,116,253,2,1,82,167,218,122,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3c16520-2979-4ffd-92ac-fac71311fb0b"));
		}

		#endregion

	}

	#endregion

}

