namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceSchemaClientSchema

	/// <exclude/>
	public class ServiceSchemaClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceSchemaClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceSchemaClientSchema(ServiceSchemaClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c738511-5733-4fc5-9114-2b98f15b5f10");
			Name = "ServiceSchemaClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,83,193,78,194,64,16,61,151,132,127,216,224,165,36,164,31,128,226,129,162,134,131,198,128,158,140,135,101,153,194,154,118,139,179,91,34,49,252,187,179,221,22,186,82,36,158,154,157,121,243,230,205,155,169,226,25,232,13,23,192,94,0,145,235,60,49,81,156,171,68,174,10,228,70,230,42,154,3,110,165,128,185,88,67,198,187,157,239,110,39,40,180,84,43,54,223,105,3,25,161,211,20,132,133,234,232,1,20,160,20,215,7,76,147,20,225,92,60,186,231,194,228,40,65,183,33,42,1,54,71,217,43,132,21,245,98,83,101,0,19,18,62,100,83,79,98,156,74,80,166,196,110,138,69,42,5,147,53,244,12,50,176,51,5,117,206,69,103,228,10,77,4,236,238,11,68,97,32,180,144,224,85,3,146,59,202,205,203,10,239,57,96,37,70,27,180,250,181,99,123,34,127,253,68,6,102,157,47,27,241,137,44,203,57,238,110,28,100,192,242,197,7,113,222,178,13,71,194,145,122,221,183,206,236,157,3,160,150,206,4,122,52,28,137,83,174,245,144,157,51,227,109,2,9,47,82,51,150,106,73,77,66,179,219,64,158,132,109,150,244,251,239,71,247,132,165,109,99,101,195,63,253,172,202,47,216,122,193,209,54,51,79,125,252,135,141,172,212,22,108,57,178,140,43,190,2,100,163,50,18,132,167,23,231,223,254,163,195,247,125,141,116,243,198,203,135,189,182,170,94,185,64,215,88,55,243,83,165,13,87,116,155,163,90,144,101,172,163,227,157,29,48,108,204,127,202,83,109,99,212,206,27,197,8,220,128,183,133,208,31,225,148,114,6,159,5,232,6,167,171,171,184,170,108,120,220,64,197,224,87,71,213,247,249,224,62,241,29,87,225,74,16,76,129,234,87,155,250,56,124,62,215,132,254,129,150,255,160,219,217,255,0,144,26,70,78,202,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c738511-5733-4fc5-9114-2b98f15b5f10"));
		}

		#endregion

	}

	#endregion

}

