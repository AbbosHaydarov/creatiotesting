namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationTaskClientSchema

	/// <exclude/>
	public class IBulkDeduplicationTaskClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationTaskClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationTaskClientSchema(IBulkDeduplicationTaskClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fef75578-f348-4491-a5ba-51e5ae6801c5");
			Name = "IBulkDeduplicationTaskClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,147,77,79,195,48,12,134,207,76,218,127,176,198,5,36,212,222,97,12,141,15,161,93,16,130,73,156,189,213,29,17,109,82,197,14,98,66,251,239,184,233,186,15,6,12,206,92,170,218,241,99,191,177,99,139,37,113,133,83,130,49,121,143,236,114,73,174,156,205,205,44,120,20,227,108,114,77,89,168,10,51,141,86,183,243,222,237,28,4,54,118,6,91,7,55,5,178,152,105,114,237,74,52,159,160,100,140,252,114,246,51,247,68,147,97,101,234,210,226,113,42,156,60,168,44,103,153,148,83,242,208,211,76,163,97,100,133,124,174,114,79,97,116,25,138,151,173,92,117,153,171,194,144,149,200,164,105,10,125,14,101,137,126,62,88,218,247,222,189,154,140,24,16,152,4,92,14,217,102,6,16,77,193,80,162,197,25,149,154,8,74,146,103,151,113,2,109,194,116,35,99,21,38,74,130,105,69,237,209,116,160,189,211,239,142,176,232,120,32,241,134,94,85,90,173,1,88,80,2,195,100,14,138,26,153,131,213,65,1,218,76,171,101,244,22,205,164,101,71,121,3,101,78,113,235,4,232,205,176,48,120,146,224,173,186,66,81,172,130,183,110,208,120,42,244,88,198,148,231,189,166,220,157,254,247,6,55,235,210,73,63,141,81,95,67,81,83,195,140,214,242,118,144,165,158,193,86,135,54,239,171,72,27,83,67,59,157,124,140,81,23,112,75,242,205,217,17,107,27,245,145,173,175,113,2,75,215,74,228,241,217,175,230,160,207,48,96,209,200,251,55,115,240,203,181,219,55,137,118,61,235,81,12,99,163,118,66,254,48,138,69,179,228,100,179,102,207,107,115,241,1,165,211,169,59,155,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fef75578-f348-4491-a5ba-51e5ae6801c5"));
		}

		#endregion

	}

	#endregion

}

