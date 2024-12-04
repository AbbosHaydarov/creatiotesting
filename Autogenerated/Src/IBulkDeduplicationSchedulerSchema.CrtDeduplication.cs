namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationSchedulerSchema

	/// <exclude/>
	public class IBulkDeduplicationSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationSchedulerSchema(IBulkDeduplicationSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ddfb5587-be3e-400d-bba5-ff6929417fb9");
			Name = "IBulkDeduplicationScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,193,78,195,48,12,134,207,155,180,119,176,182,11,92,218,251,24,59,64,47,67,2,77,108,119,148,182,110,27,104,147,42,73,65,19,226,221,113,146,101,237,216,6,92,162,218,177,127,127,254,149,10,214,160,110,89,134,176,69,165,152,150,133,137,238,165,40,120,217,41,102,184,20,81,130,121,215,214,60,115,209,100,252,57,25,143,102,10,75,10,96,37,12,170,130,154,231,240,178,186,235,234,183,163,218,13,50,149,85,155,172,162,100,141,106,50,166,206,56,142,97,161,187,166,97,106,183,220,199,207,216,42,212,40,140,6,6,58,148,67,33,21,52,76,176,146,139,18,130,44,106,208,78,22,94,101,170,163,160,24,15,36,219,46,165,82,224,129,13,206,144,245,76,35,218,135,206,195,74,143,104,42,153,235,57,172,157,140,191,252,73,237,18,65,196,82,159,197,131,15,110,42,187,82,139,25,47,56,230,208,50,69,118,19,151,5,63,37,247,25,87,4,130,10,111,167,189,110,152,150,123,87,215,65,105,186,220,86,216,11,131,44,192,80,34,216,120,134,204,250,106,233,180,97,202,144,183,209,34,118,237,142,224,93,242,252,176,153,31,245,32,211,171,228,79,142,193,160,75,37,215,55,191,184,153,96,77,53,195,23,112,193,212,116,119,100,233,254,198,54,53,204,185,246,95,111,125,203,19,125,123,15,79,149,14,86,229,22,206,254,11,39,86,121,236,222,40,109,148,125,174,189,118,88,122,134,34,247,79,204,197,95,238,28,38,41,243,13,217,149,162,53,140,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ddfb5587-be3e-400d-bba5-ff6929417fb9"));
		}

		#endregion

	}

	#endregion

}

