namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailValidatorFactorySchema

	/// <exclude/>
	public class BulkEmailValidatorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailValidatorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailValidatorFactorySchema(BulkEmailValidatorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("08193153-e2ef-4f67-84d1-ac8831a1fb44");
			Name = "BulkEmailValidatorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,111,219,48,12,61,39,64,254,3,209,94,228,139,141,93,187,38,192,146,173,67,129,118,41,144,160,59,12,59,168,54,149,8,149,165,76,146,135,25,67,255,251,40,127,196,105,108,163,61,44,7,35,162,200,199,199,71,82,154,231,232,14,60,69,216,162,181,220,25,225,227,149,209,66,238,10,203,189,52,122,54,253,59,155,78,10,39,245,14,54,165,243,152,211,189,82,152,134,75,23,127,69,141,86,166,31,207,125,238,164,254,213,25,79,177,45,198,55,60,245,198,74,116,228,65,62,73,146,192,181,43,242,156,219,114,209,156,111,181,71,43,2,47,97,44,164,22,137,12,1,113,72,247,92,106,48,2,158,10,245,12,152,115,169,224,55,87,50,227,4,233,226,22,46,57,193,59,20,79,74,166,32,143,144,183,75,138,253,18,66,31,219,200,154,82,73,222,161,220,30,165,202,176,10,44,208,189,139,68,159,197,100,201,29,222,163,115,124,135,199,180,13,230,42,224,173,69,159,150,99,27,212,25,85,190,45,15,8,174,251,31,5,113,95,70,229,59,82,213,25,228,92,83,202,247,209,238,177,254,241,25,5,47,148,95,202,42,53,243,148,219,8,54,174,96,20,253,236,36,79,21,119,14,70,125,225,234,205,86,4,225,46,45,238,104,216,224,30,253,222,100,238,10,30,42,244,250,178,98,44,245,158,166,208,103,134,82,90,20,243,139,113,216,248,45,197,47,146,170,91,77,5,255,183,105,80,13,215,228,78,58,127,61,132,188,168,58,115,134,6,115,88,5,29,59,93,232,71,139,231,63,41,53,140,194,162,198,233,59,201,130,236,216,98,152,47,186,126,199,39,36,221,214,52,209,24,182,223,83,97,142,157,18,111,1,215,54,67,187,44,199,32,31,172,164,189,246,101,235,190,53,161,84,86,13,235,200,2,8,105,157,239,142,243,33,5,226,155,224,180,182,205,44,182,120,82,0,59,15,159,131,46,148,106,133,158,88,244,133,213,149,173,142,121,25,103,146,22,214,162,126,197,229,53,122,141,64,239,17,242,116,15,108,16,164,207,158,222,157,193,154,54,207,242,192,62,68,71,170,3,233,207,77,212,50,255,13,255,120,214,199,107,36,169,203,107,170,30,96,95,191,24,147,75,106,109,189,84,213,57,68,205,166,244,253,7,235,230,43,197,14,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08193153-e2ef-4f67-84d1-ac8831a1fb44"));
		}

		#endregion

	}

	#endregion

}

