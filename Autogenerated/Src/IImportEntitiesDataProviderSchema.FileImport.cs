namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportEntitiesDataProviderSchema

	/// <exclude/>
	public class IImportEntitiesDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportEntitiesDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportEntitiesDataProviderSchema(IImportEntitiesDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18959618-7987-4279-b581-a64c3683bed3");
			Name = "IImportEntitiesDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,203,110,219,48,16,60,199,128,255,97,225,92,28,160,144,238,141,106,160,126,36,53,138,160,70,28,244,78,73,43,135,48,69,10,75,82,133,81,228,223,187,148,108,199,145,31,241,161,23,217,226,206,236,236,140,72,106,81,162,173,68,134,240,130,68,194,154,194,69,19,163,11,185,242,36,156,52,58,122,144,10,231,101,101,200,245,123,127,251,189,27,111,165,94,193,114,99,29,150,247,157,119,166,42,133,89,224,217,232,17,53,146,204,24,195,168,202,167,74,102,32,181,67,42,130,220,188,237,57,211,78,58,137,118,42,156,88,144,169,101,142,196,112,22,226,231,205,45,225,138,123,193,19,186,87,147,219,175,176,104,218,180,197,56,142,33,177,190,44,5,109,70,187,133,137,66,65,22,114,110,7,5,153,18,198,190,40,144,48,63,144,219,128,19,169,66,72,55,80,181,146,57,36,149,32,81,18,22,160,57,145,111,3,217,192,151,104,45,235,207,243,1,196,123,137,36,238,138,182,228,51,204,81,18,55,229,6,93,27,153,55,51,234,19,115,113,12,195,71,207,128,78,139,187,251,255,99,56,58,237,224,211,153,46,234,79,81,161,67,48,106,55,54,224,150,23,93,25,88,33,245,86,113,17,86,185,27,217,7,175,179,115,201,253,82,157,1,159,197,159,176,125,134,129,148,132,0,191,64,183,223,8,206,169,92,52,55,215,22,217,81,199,24,56,3,121,122,173,189,106,47,247,209,208,17,112,141,27,62,62,190,212,167,128,132,206,147,182,92,216,253,11,165,212,24,5,75,81,227,199,64,94,204,116,60,236,154,133,247,65,56,159,153,246,37,82,216,21,73,11,108,165,71,240,62,197,229,109,247,138,217,26,68,45,164,106,206,18,211,32,107,121,252,235,181,187,54,158,245,94,111,18,104,131,209,207,163,78,103,195,120,70,235,149,131,90,40,201,251,31,25,120,20,206,239,109,141,187,30,202,12,249,34,58,176,218,172,237,252,222,162,206,219,123,167,125,199,154,63,60,204,194,243,135,208,185,66,74,102,68,134,158,248,124,138,21,54,133,239,180,226,61,118,234,232,133,175,51,29,55,132,112,91,190,245,123,111,255,0,245,43,193,77,116,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18959618-7987-4279-b581-a64c3683bed3"));
		}

		#endregion

	}

	#endregion

}

