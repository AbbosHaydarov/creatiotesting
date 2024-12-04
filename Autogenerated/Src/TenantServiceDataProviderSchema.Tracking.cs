namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TenantServiceDataProviderSchema

	/// <exclude/>
	public class TenantServiceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TenantServiceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TenantServiceDataProviderSchema(TenantServiceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("187f0e27-7e57-4243-a537-36ca44a321f2");
			Name = "TenantServiceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,193,106,227,48,16,61,171,208,127,24,210,75,12,139,125,223,54,129,37,93,150,94,186,133,164,123,93,84,123,28,68,109,201,140,164,64,8,253,247,29,73,118,83,187,117,54,7,199,26,63,205,188,247,102,70,203,22,109,39,75,132,29,18,73,107,106,151,111,140,174,213,222,147,116,202,232,124,71,178,124,85,122,127,125,117,186,190,18,222,242,235,8,75,120,251,30,15,167,116,27,86,241,48,206,197,64,134,222,16,238,249,0,155,70,90,251,29,134,252,247,210,201,39,50,7,85,33,69,92,81,20,112,103,125,219,74,58,174,251,115,15,0,165,107,67,109,76,10,53,153,22,28,106,169,29,88,164,131,42,49,31,174,23,31,238,119,254,165,81,37,148,161,44,43,8,248,109,130,127,44,13,115,140,4,203,231,231,59,125,254,210,33,57,133,172,225,137,212,65,58,76,128,41,239,24,216,30,173,195,150,249,57,199,153,45,104,246,29,88,3,188,72,139,19,246,224,169,9,10,62,75,16,93,42,4,214,81,234,67,184,247,163,170,8,173,221,246,185,31,67,234,213,26,22,131,142,132,122,166,102,145,26,32,110,80,87,73,197,37,73,198,97,233,176,74,144,73,225,191,110,200,121,59,43,121,247,73,20,28,100,227,113,86,90,95,112,44,142,75,64,24,60,33,246,232,250,55,161,106,88,38,84,254,96,31,125,211,252,166,159,109,231,142,203,51,175,44,27,192,226,28,236,167,50,13,101,206,61,25,60,203,127,161,251,19,200,45,159,153,47,127,215,76,133,45,249,54,111,113,150,239,204,54,114,88,102,209,4,254,17,58,79,122,234,142,16,111,128,13,183,249,244,63,88,252,139,207,183,203,157,98,134,172,223,151,206,80,232,85,156,236,11,211,183,57,195,193,212,32,211,18,204,52,34,70,58,73,178,141,83,186,90,248,145,37,139,245,3,39,147,154,91,202,169,198,118,229,119,69,188,152,26,154,246,109,118,211,38,86,195,184,76,198,139,24,118,99,57,13,159,224,107,111,82,116,28,228,216,63,109,246,183,107,225,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("187f0e27-7e57-4243-a537-36ca44a321f2"));
		}

		#endregion

	}

	#endregion

}

