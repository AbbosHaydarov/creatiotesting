namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthExceptionsSchema

	/// <exclude/>
	public class OAuthExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthExceptionsSchema(OAuthExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc203001-613e-494f-8857-3cb5ad94462e");
			Name = "OAuthExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,205,107,194,48,20,63,87,240,127,8,120,81,144,118,236,232,198,64,202,14,158,54,116,183,177,67,140,175,109,160,77,74,146,162,110,248,191,239,245,83,103,253,24,93,203,182,75,219,151,190,252,62,242,242,19,52,2,29,83,6,228,5,148,162,90,122,198,118,165,240,184,159,40,106,184,20,246,211,52,49,193,237,77,191,247,209,239,89,137,230,194,39,139,173,54,16,221,29,213,246,60,17,134,71,96,47,64,113,26,242,247,108,63,118,97,223,64,129,143,5,113,67,170,245,132,100,152,115,208,50,81,12,30,55,12,226,180,53,235,116,28,135,220,235,36,138,168,218,62,20,117,213,65,76,160,228,90,144,117,192,67,32,170,0,192,15,159,163,2,133,90,236,18,194,57,192,120,173,20,45,67,120,195,133,56,89,134,156,17,150,170,57,35,134,76,246,180,184,3,205,227,115,239,67,10,109,84,194,140,84,104,231,57,131,203,59,50,114,46,2,100,52,43,201,156,148,191,228,59,205,52,28,145,244,104,173,93,99,0,148,146,142,1,39,169,169,15,35,148,190,164,26,134,85,221,42,252,248,96,28,92,8,80,85,121,76,60,174,253,63,20,50,0,177,202,79,243,226,209,42,105,128,25,88,93,82,95,246,156,51,240,229,66,206,132,39,81,152,39,199,100,97,20,208,8,189,33,167,129,141,33,44,127,143,82,84,203,42,220,228,189,229,175,179,30,138,181,35,91,151,46,254,76,184,33,7,97,26,7,128,101,219,9,141,99,156,94,102,174,205,40,212,228,117,30,137,26,227,48,155,68,163,235,91,199,186,146,146,206,152,126,16,152,99,77,157,103,166,238,165,205,236,92,177,243,237,0,229,26,167,113,252,199,146,83,215,213,89,100,234,84,13,178,114,2,164,237,144,92,165,248,15,233,112,235,38,126,57,22,187,79,96,185,28,103,184,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc203001-613e-494f-8857-3cb5ad94462e"));
		}

		#endregion

	}

	#endregion

}

