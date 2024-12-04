namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigSchema

	/// <exclude/>
	public class CESMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigSchema(CESMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4");
			Name = "CESMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,81,77,107,195,48,12,61,187,208,255,32,218,123,114,239,186,194,40,29,244,48,40,164,127,192,115,149,204,16,127,32,59,133,48,246,223,167,216,105,88,183,133,193,46,70,146,223,147,222,147,172,52,24,188,84,8,103,36,146,193,213,177,216,59,91,235,166,35,25,181,179,203,197,251,114,33,186,160,109,3,85,31,34,154,135,41,159,161,20,251,67,197,32,134,173,9,27,46,128,106,101,8,27,224,250,139,212,45,83,79,228,174,250,130,148,121,9,91,150,37,108,67,103,140,164,126,55,230,35,44,128,74,56,112,53,196,55,4,147,155,128,31,187,20,55,122,249,133,239,187,215,86,171,60,122,118,50,108,224,56,35,73,176,111,126,39,15,252,239,145,162,70,54,114,74,189,243,255,119,221,169,112,180,33,74,203,91,29,21,111,3,34,40,194,250,113,117,155,119,70,227,91,25,241,89,170,232,168,95,149,187,193,198,79,31,98,52,50,195,227,35,220,231,195,185,132,104,48,14,119,18,34,164,96,8,63,254,169,151,119,247,228,245,223,250,50,14,42,164,171,86,56,132,191,74,153,132,172,209,94,242,110,83,158,171,247,69,174,125,2,228,15,11,154,161,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4"));
		}

		#endregion

	}

	#endregion

}

