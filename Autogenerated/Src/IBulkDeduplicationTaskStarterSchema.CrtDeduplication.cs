namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationTaskStarterSchema

	/// <exclude/>
	public class IBulkDeduplicationTaskStarterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationTaskStarterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationTaskStarterSchema(IBulkDeduplicationTaskStarterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34bd4c3a-5be2-45e6-81db-f052a01f9932");
			Name = "IBulkDeduplicationTaskStarter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,189,78,195,48,16,158,27,41,239,112,106,23,88,146,29,74,135,210,165,75,133,212,190,128,147,92,130,213,248,71,119,54,18,66,125,119,206,14,149,2,25,144,188,124,231,239,207,103,171,12,178,87,45,194,5,137,20,187,62,84,175,206,246,122,136,164,130,118,182,58,96,23,253,168,219,140,202,226,171,44,86,114,54,132,131,96,56,218,128,212,139,254,9,142,251,56,94,127,177,47,138,175,231,160,72,40,101,33,162,186,174,97,203,209,24,69,159,187,31,252,70,238,67,119,200,96,48,188,187,14,122,71,192,73,163,237,0,141,56,66,55,183,4,79,174,69,230,234,110,87,207,252,124,108,132,7,250,222,233,191,74,171,244,152,69,171,60,200,28,254,147,29,68,156,130,151,201,211,196,43,82,6,172,172,244,101,205,216,38,205,73,192,122,119,158,64,190,170,182,117,230,101,89,227,220,56,101,45,90,62,112,160,180,131,153,209,227,179,104,110,121,149,27,180,221,244,5,9,222,190,1,144,34,241,78,199,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34bd4c3a-5be2-45e6-81db-f052a01f9932"));
		}

		#endregion

	}

	#endregion

}

