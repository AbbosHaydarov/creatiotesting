namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookMappingSchema

	/// <exclude/>
	public class FacebookMappingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookMappingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookMappingSchema(FacebookMappingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d848782-ec7f-4a67-83bd-2846ad8a81d8");
			Name = "FacebookMapping";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,193,106,195,48,12,134,207,9,228,29,12,187,180,48,242,0,45,59,148,178,221,90,2,237,78,99,12,39,83,131,153,99,27,89,238,8,163,239,62,37,49,105,26,218,139,177,127,253,254,245,73,70,54,224,157,172,64,28,1,81,122,123,162,124,107,205,73,213,1,37,41,107,242,131,173,148,212,89,250,151,165,73,240,202,212,226,208,122,130,102,157,165,172,60,33,212,236,18,91,45,189,95,137,55,78,42,173,253,217,73,231,216,218,91,62,54,68,168,202,64,240,238,101,13,139,241,121,148,88,3,249,188,64,235,0,169,125,22,27,173,237,239,46,104,82,78,131,120,17,132,1,150,159,156,225,66,169,85,37,170,174,203,188,137,88,137,49,146,173,204,201,231,21,204,26,207,49,21,89,100,190,162,207,25,28,49,115,150,182,96,119,23,106,120,49,75,209,13,157,36,123,190,51,77,39,173,123,161,144,8,134,88,26,204,249,107,227,168,237,75,151,216,29,204,247,0,112,75,19,71,85,48,103,65,117,150,4,49,79,124,141,173,34,100,212,247,29,200,192,196,155,139,183,4,129,2,154,201,167,142,130,79,127,181,244,53,230,61,75,29,166,158,136,59,111,239,250,249,238,0,196,193,31,34,76,62,222,129,24,170,143,49,166,91,139,218,237,34,47,255,85,55,175,138,175,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d848782-ec7f-4a67-83bd-2846ad8a81d8"));
		}

		#endregion

	}

	#endregion

}

