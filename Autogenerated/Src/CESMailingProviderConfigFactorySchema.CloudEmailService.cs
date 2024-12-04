namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigFactorySchema

	/// <exclude/>
	public class CESMailingProviderConfigFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigFactorySchema(CESMailingProviderConfigFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1");
			Name = "CESMailingProviderConfigFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,95,75,195,48,16,127,158,224,119,56,230,203,4,105,223,231,86,152,69,101,15,130,248,231,3,196,236,90,3,107,82,46,201,68,196,239,238,53,201,92,59,55,5,95,90,122,249,221,239,207,229,170,69,131,182,21,18,225,9,137,132,53,149,203,74,163,43,85,123,18,78,25,125,122,242,113,122,50,242,86,233,122,0,33,188,60,82,207,110,132,116,134,20,90,70,48,230,140,176,102,34,40,215,194,218,41,148,215,143,119,66,173,185,239,158,204,70,173,144,162,94,236,122,15,45,121,158,195,204,250,166,17,244,94,164,239,132,182,208,160,123,53,43,11,149,33,144,132,236,146,45,40,109,157,208,146,69,193,84,224,94,145,251,17,187,243,106,62,94,30,20,28,231,69,182,213,202,123,98,173,127,89,43,9,178,179,251,151,91,152,194,242,247,52,35,30,31,63,191,167,112,23,221,79,225,62,200,196,195,253,188,161,80,118,217,56,79,138,134,7,130,29,115,151,162,253,204,22,43,173,32,209,128,230,171,159,143,189,13,77,26,101,119,219,227,98,217,83,235,41,61,15,97,204,63,203,3,205,142,149,208,121,210,182,120,136,239,255,250,158,229,91,162,142,57,93,198,225,33,167,17,109,45,79,134,38,97,24,237,28,186,69,30,141,54,130,0,117,173,52,46,168,182,48,7,141,111,192,48,235,200,119,119,198,85,223,160,118,147,253,209,92,236,19,118,63,64,228,147,107,227,87,215,129,148,9,195,162,167,5,200,110,209,205,174,218,198,104,182,143,229,14,87,76,118,38,250,76,49,88,114,117,100,76,147,212,16,193,217,35,210,70,73,92,180,138,251,122,86,122,7,17,31,30,113,186,73,40,212,63,211,134,162,94,197,37,13,223,177,58,44,114,237,11,236,249,107,76,49,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1"));
		}

		#endregion

	}

	#endregion

}

