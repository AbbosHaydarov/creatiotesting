namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthConfigServiceDtoSchema

	/// <exclude/>
	public class OAuthConfigServiceDtoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthConfigServiceDtoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthConfigServiceDtoSchema(OAuthConfigServiceDtoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2501d98-fcfc-4786-9ed5-b96381b1cbae");
			Name = "OAuthConfigServiceDto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,86,77,79,220,48,16,61,47,18,255,193,90,46,69,170,86,85,143,160,10,173,22,169,226,80,138,146,238,169,234,193,235,12,139,165,172,19,102,198,72,45,226,191,119,226,116,249,8,14,27,195,66,185,36,178,227,247,198,121,126,51,30,167,87,64,181,54,160,126,0,162,166,234,156,39,179,202,157,219,165,71,205,182,114,147,239,83,207,23,159,63,237,238,92,239,238,140,60,89,183,84,249,111,98,88,29,118,198,147,204,59,182,43,152,228,128,86,151,246,79,192,203,42,89,183,135,176,148,129,154,149,154,232,64,77,139,98,86,90,112,156,193,165,7,226,176,230,231,177,102,45,177,25,181,225,95,50,81,251,69,105,141,50,13,38,2,25,201,134,228,121,203,125,134,85,13,200,22,36,192,89,128,182,223,3,239,55,88,45,0,63,156,202,239,170,47,106,236,228,61,254,168,78,168,97,179,8,133,76,50,122,216,111,226,174,3,19,99,243,119,1,115,173,150,192,135,138,154,199,77,63,175,48,9,155,225,57,150,227,24,87,118,247,189,75,57,26,245,145,234,186,22,138,160,102,195,59,112,219,211,7,168,225,209,40,28,230,156,0,79,138,141,177,190,122,91,252,59,254,22,17,19,106,15,92,209,158,81,24,183,179,157,201,126,131,80,93,57,130,52,135,180,24,117,160,30,88,89,124,121,101,13,220,81,190,196,65,38,132,18,137,98,218,183,251,136,171,209,79,150,131,65,224,39,8,219,5,91,146,120,94,23,154,33,53,13,163,168,70,199,167,85,236,183,219,173,142,3,109,157,42,109,200,244,255,152,214,3,147,58,61,131,7,229,239,163,100,61,218,152,173,49,78,75,83,195,246,170,35,228,162,170,202,35,57,181,246,219,38,91,38,155,50,55,226,35,122,158,53,59,216,247,96,208,254,8,8,84,121,52,208,140,135,70,201,238,97,182,162,252,49,148,144,94,14,162,168,205,106,191,69,49,72,86,32,52,58,57,48,11,115,130,237,226,176,247,160,193,160,219,38,41,74,255,5,20,173,68,114,223,2,38,180,44,249,26,176,149,243,148,126,96,157,37,105,93,68,23,245,170,125,4,53,149,42,90,254,67,13,219,210,101,127,255,248,178,225,98,196,96,111,208,85,189,110,35,116,243,23,45,218,88,158,244,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2501d98-fcfc-4786-9ed5-b96381b1cbae"));
		}

		#endregion

	}

	#endregion

}

