namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationManagerV2Schema

	/// <exclude/>
	public class IBulkDeduplicationManagerV2Schema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationManagerV2Schema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationManagerV2Schema(IBulkDeduplicationManagerV2Schema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b690585-6925-4a7e-949f-0578a80311b8");
			Name = "IBulkDeduplicationManagerV2";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,77,111,219,48,12,61,183,64,255,3,145,94,54,160,176,129,29,187,204,135,166,89,144,67,183,162,95,119,197,166,61,173,182,236,137,210,0,99,232,127,31,37,197,177,29,55,65,55,160,7,27,226,199,35,31,159,4,42,81,33,53,34,69,120,64,173,5,213,185,137,22,181,202,101,97,181,48,178,86,209,53,102,182,41,101,234,173,179,211,63,103,167,39,150,164,42,224,190,37,131,213,231,61,155,209,101,137,169,75,166,104,133,10,181,76,57,135,179,206,53,22,236,133,181,50,168,115,110,121,9,235,43,91,62,143,26,220,8,37,10,212,79,159,60,36,142,99,152,147,173,42,161,219,100,107,59,8,100,67,12,84,1,4,178,171,28,117,216,120,0,110,236,134,17,125,210,177,238,112,132,27,151,98,17,248,191,155,232,6,205,143,58,163,75,184,245,45,66,112,159,187,119,172,208,16,20,186,182,13,65,157,67,87,28,1,149,145,70,34,57,230,83,234,193,211,8,45,42,80,124,99,95,102,254,140,60,9,205,146,219,221,25,234,205,79,214,62,154,199,62,222,67,53,26,171,21,37,171,99,173,231,113,151,230,112,126,252,46,137,60,240,142,159,10,95,43,186,49,66,165,239,121,159,242,225,85,175,39,71,208,243,253,232,94,204,201,113,133,118,228,8,54,109,208,235,157,133,185,126,165,227,84,143,165,147,170,93,148,146,53,219,211,198,17,223,185,150,91,73,175,90,31,115,202,28,138,253,151,62,86,201,95,22,65,99,90,235,140,64,242,151,235,186,2,106,48,149,185,196,108,168,32,71,223,42,158,127,10,237,55,62,207,146,48,171,15,76,101,27,130,250,86,235,140,69,127,28,114,3,193,75,165,61,44,251,227,191,14,50,190,147,245,82,217,10,181,216,148,56,95,89,153,37,78,158,80,243,46,148,100,74,95,185,224,224,149,146,209,110,91,245,163,94,192,180,204,104,38,119,35,7,239,99,33,84,138,229,222,66,50,130,158,223,170,57,133,101,25,68,191,15,198,84,245,223,181,204,182,189,70,59,233,129,59,117,35,13,42,117,148,207,81,101,97,73,121,251,37,44,226,145,243,229,47,171,91,207,183,3,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b690585-6925-4a7e-949f-0578a80311b8"));
		}

		#endregion

	}

	#endregion

}

