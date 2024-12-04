namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookEntityMetadataSchema

	/// <exclude/>
	public class FacebookEntityMetadataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookEntityMetadataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookEntityMetadataSchema(FacebookEntityMetadataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3e1645a-bfb9-4c64-806f-498f877105d0");
			Name = "FacebookEntityMetadata";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eff9ab8e-fb1d-46f5-bbeb-f2b4e8220404");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,65,106,195,48,16,60,43,144,63,136,228,146,66,240,3,90,122,40,105,115,8,184,152,58,183,208,195,218,94,27,81,91,18,210,250,224,150,252,189,43,217,73,105,192,228,98,164,153,157,157,209,88,67,135,222,66,137,242,136,206,129,55,53,37,59,163,107,213,244,14,72,25,157,228,166,84,208,46,23,63,203,133,232,189,210,141,204,7,79,216,61,221,220,147,143,94,147,234,48,201,209,177,64,125,71,249,223,212,158,77,10,99,190,24,97,108,237,176,97,90,238,90,240,254,241,74,190,241,10,26,82,36,168,128,32,78,158,94,249,196,145,200,65,73,159,12,216,190,104,85,41,203,160,156,17,202,219,141,44,227,252,252,189,26,103,206,88,116,164,144,221,179,184,113,228,163,93,138,93,129,110,243,206,229,200,103,185,170,21,182,149,95,61,4,119,113,186,108,78,193,90,126,216,230,66,111,101,6,14,53,5,69,55,5,153,52,83,228,131,55,250,133,91,30,228,62,74,100,232,84,136,6,41,212,36,132,159,14,231,249,40,52,88,156,13,18,201,251,49,60,185,240,67,142,60,125,39,193,26,117,53,246,21,239,35,250,31,60,255,2,97,90,83,250,66,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3e1645a-bfb9-4c64-806f-498f877105d0"));
		}

		#endregion

	}

	#endregion

}

