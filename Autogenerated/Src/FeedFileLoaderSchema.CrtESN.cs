namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeedFileLoaderSchema

	/// <exclude/>
	public class FeedFileLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeedFileLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeedFileLoaderSchema(FeedFileLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bcaef2e2-05be-4e8f-8a25-8d27e34d45f1");
			Name = "FeedFileLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,147,223,107,219,48,16,199,159,93,232,255,112,164,47,41,20,251,125,75,2,37,36,165,176,141,209,108,207,67,145,206,177,152,45,153,147,156,97,198,254,247,157,228,184,141,213,100,123,188,211,221,231,126,124,79,70,52,232,90,33,17,190,33,145,112,182,244,249,218,154,82,31,58,18,94,91,147,111,118,95,110,111,126,223,222,100,157,211,230,0,187,222,121,108,62,190,218,215,210,182,186,198,79,86,168,203,145,132,215,252,249,198,120,237,53,186,171,1,91,33,189,165,33,130,99,238,8,15,92,16,214,181,112,238,3,108,17,213,88,27,41,70,180,221,190,214,18,100,8,72,222,129,19,206,130,179,48,231,27,209,26,231,133,241,76,253,74,250,40,60,70,92,214,14,6,16,10,101,77,221,195,243,198,153,128,121,193,214,58,205,205,245,240,163,156,216,67,171,217,29,26,53,192,131,13,73,41,234,194,96,161,90,108,120,72,41,138,2,22,174,107,26,65,253,106,116,172,185,180,71,7,2,12,254,2,29,219,100,9,109,9,190,66,14,71,4,73,88,46,103,211,105,103,197,10,124,223,98,254,10,46,82,242,162,21,36,26,48,124,22,203,89,231,144,184,51,131,50,72,58,91,157,129,191,79,159,24,60,118,145,47,138,200,136,200,211,234,167,109,204,167,201,48,45,115,207,154,236,133,195,121,234,142,218,100,71,65,73,194,35,29,186,6,141,135,101,220,198,217,42,199,151,121,58,201,67,90,51,28,91,150,37,162,49,48,30,213,112,112,125,254,132,126,241,94,234,85,210,232,88,116,96,254,185,36,252,155,238,159,209,87,86,197,3,179,158,243,81,157,169,174,77,133,164,189,178,114,84,83,143,43,204,215,21,202,159,47,124,128,193,247,40,37,58,55,143,63,167,223,201,10,27,241,0,79,157,86,247,44,204,112,177,39,58,216,35,127,38,173,16,246,214,214,240,63,10,240,28,9,18,194,142,158,213,40,7,161,239,200,164,231,126,177,189,41,235,132,249,199,146,6,239,212,201,190,191,255,140,148,172,178,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bcaef2e2-05be-4e8f-8a25-8d27e34d45f1"));
		}

		#endregion

	}

	#endregion

}

