namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EqualComparatorProviderSchema

	/// <exclude/>
	public class EqualComparatorProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EqualComparatorProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EqualComparatorProviderSchema(EqualComparatorProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ebef606a-f1e5-4bdb-b9fe-2515dda709fc");
			Name = "EqualComparatorProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,84,203,74,195,64,20,93,167,208,127,184,82,144,20,36,217,91,31,139,182,136,11,181,88,113,63,77,110,234,72,50,19,231,33,68,219,127,119,50,51,137,49,141,46,4,221,52,204,185,247,156,115,95,148,145,2,101,73,18,132,7,20,130,72,158,169,104,206,89,70,183,90,16,69,57,139,150,76,81,85,173,43,150,60,9,206,232,155,69,199,163,247,241,104,60,10,180,164,108,11,235,74,42,44,102,22,153,8,220,154,4,152,231,68,202,83,88,190,104,146,207,121,81,18,35,199,197,74,240,87,154,162,176,169,113,28,195,153,212,69,65,68,117,225,223,62,65,66,210,114,36,100,92,64,74,179,12,5,50,5,170,42,81,70,13,63,238,8,148,122,147,211,4,146,218,250,59,103,56,133,235,111,139,10,92,87,109,19,55,168,158,120,106,218,88,89,101,23,236,151,109,129,123,84,90,48,9,88,75,119,138,183,181,75,37,204,152,234,146,15,107,118,136,112,244,139,207,162,162,179,184,1,235,44,223,90,111,13,115,158,235,194,252,182,110,87,168,214,214,172,215,98,56,5,211,90,16,4,78,19,82,204,113,75,20,134,124,243,140,137,2,201,181,72,240,145,228,26,79,192,99,102,11,138,50,235,99,3,141,68,163,17,118,72,112,116,14,76,231,57,28,31,31,240,186,177,14,37,178,37,202,240,192,102,234,92,130,221,206,88,184,201,93,203,91,35,112,39,150,69,169,170,208,163,211,142,216,212,138,255,148,124,104,99,238,213,184,236,237,103,255,219,213,166,102,136,15,180,192,127,90,238,194,216,253,229,106,23,190,157,75,79,107,222,112,14,97,27,235,14,126,214,231,117,164,135,201,125,239,217,208,81,45,26,234,240,93,245,195,254,98,218,3,107,226,145,187,180,250,57,112,110,3,89,95,143,175,55,130,159,75,241,225,161,179,154,32,75,221,63,138,125,59,244,43,104,176,15,174,91,181,145,139,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ebef606a-f1e5-4bdb-b9fe-2515dda709fc"));
		}

		#endregion

	}

	#endregion

}

