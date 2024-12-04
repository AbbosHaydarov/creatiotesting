namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RootAccountInfoResponseSchema

	/// <exclude/>
	public class RootAccountInfoResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RootAccountInfoResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RootAccountInfoResponseSchema(RootAccountInfoResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c2134ec-81df-40a8-823f-e035797122bd");
			Name = "RootAccountInfoResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,146,203,106,195,48,16,69,215,49,248,31,6,178,183,247,105,41,180,46,20,67,161,193,73,62,64,145,199,142,192,150,204,104,220,18,66,254,189,178,100,247,73,10,38,221,8,230,113,239,156,145,164,69,139,182,19,18,97,139,68,194,154,138,147,204,232,74,213,61,9,86,70,199,209,41,142,226,104,177,36,172,93,8,89,35,172,93,65,97,12,223,75,105,122,205,185,174,76,225,76,140,182,232,91,211,52,133,91,219,183,173,160,227,221,24,103,141,233,75,160,177,13,30,183,47,240,166,248,0,202,137,169,245,147,64,236,77,207,32,130,107,50,25,165,95,156,186,126,223,40,9,114,96,184,132,0,43,120,16,22,199,202,39,216,34,236,241,177,200,154,76,135,196,10,221,54,107,239,27,234,63,233,3,62,225,192,8,187,226,121,0,251,77,54,161,89,38,165,235,169,127,71,13,156,160,70,190,1,59,28,231,63,70,60,33,91,48,52,52,90,224,3,130,28,103,202,70,161,102,80,165,59,85,165,144,230,16,100,94,156,151,255,134,97,209,37,56,153,141,176,241,186,235,49,194,53,240,209,85,232,21,105,238,139,228,163,124,227,213,23,222,103,137,186,12,191,196,199,33,251,61,121,142,163,119,38,132,234,112,59,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c2134ec-81df-40a8-823f-e035797122bd"));
		}

		#endregion

	}

	#endregion

}

