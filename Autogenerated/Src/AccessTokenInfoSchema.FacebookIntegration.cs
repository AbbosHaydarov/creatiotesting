namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccessTokenInfoSchema

	/// <exclude/>
	public class AccessTokenInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccessTokenInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccessTokenInfoSchema(AccessTokenInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcf69f4-2a5f-419d-9855-0d3c0ba8478a");
			Name = "AccessTokenInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,148,219,110,194,48,12,134,175,59,137,119,136,224,134,221,240,0,59,73,136,29,84,105,155,166,193,118,131,166,42,77,13,202,8,73,20,167,211,14,226,221,231,164,101,192,88,153,212,155,170,177,127,251,179,221,184,154,47,1,45,23,192,38,224,28,71,51,243,131,145,209,51,57,47,29,247,210,232,193,216,8,201,85,231,232,171,115,148,148,40,245,156,141,63,208,195,242,244,215,153,194,148,2,17,98,112,112,3,26,156,20,123,154,199,82,123,185,132,193,152,188,92,201,207,136,216,168,174,169,144,220,152,5,89,200,214,115,48,39,55,27,41,142,120,194,134,66,0,226,196,44,64,167,122,102,162,100,250,147,40,87,240,18,12,151,220,115,106,192,59,46,124,48,216,50,87,82,48,17,114,236,167,72,168,43,122,254,160,30,156,177,224,188,4,226,61,196,200,202,31,211,222,193,50,7,215,191,167,145,177,115,214,229,155,100,221,227,128,74,166,235,250,239,184,181,212,79,191,214,100,126,75,84,23,132,222,133,142,183,42,98,97,194,73,50,7,31,6,146,36,88,191,172,14,148,96,109,90,52,195,173,205,100,241,55,54,4,182,3,82,150,248,213,14,97,127,105,246,216,107,127,139,10,224,221,74,7,56,244,141,252,90,145,113,191,139,87,134,224,87,235,240,246,232,84,255,139,150,186,25,157,182,233,90,226,51,221,242,230,79,45,49,123,219,18,212,88,146,40,150,86,161,173,160,88,66,113,96,210,149,224,239,65,167,117,112,11,46,10,90,66,108,164,238,184,107,228,173,68,127,102,242,87,250,255,92,176,113,20,180,0,251,176,134,147,15,11,141,236,168,200,252,70,178,123,181,227,30,135,4,45,224,37,130,59,176,204,193,221,180,205,79,49,244,31,102,15,116,81,253,229,226,185,178,238,26,87,223,167,4,218,2,14,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcf69f4-2a5f-419d-9855-0d3c0ba8478a"));
		}

		#endregion

	}

	#endregion

}

