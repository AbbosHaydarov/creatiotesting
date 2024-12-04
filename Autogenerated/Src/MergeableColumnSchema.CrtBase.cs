namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MergeableColumnSchema

	/// <exclude/>
	public class MergeableColumnSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MergeableColumnSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MergeableColumnSchema(MergeableColumnSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("130e3881-b742-42e2-8cd7-66092d66a439");
			Name = "MergeableColumn";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,78,49,14,194,48,12,156,27,41,127,200,11,248,0,19,234,2,3,44,240,1,55,117,163,72,73,28,197,137,80,133,250,119,146,2,3,18,32,6,91,103,223,157,207,133,109,48,234,60,115,70,191,149,162,172,227,5,83,2,166,41,111,122,242,158,194,71,34,97,93,75,17,192,35,71,208,248,70,134,201,154,146,32,91,10,82,220,164,232,98,25,156,213,74,59,96,86,71,76,6,97,112,216,147,43,190,42,186,38,121,105,56,167,150,245,224,122,136,237,136,90,5,157,193,92,67,43,224,39,88,90,251,230,61,213,215,254,53,14,68,78,29,120,231,174,48,243,222,142,35,254,204,172,181,220,1,203,55,130,245,59,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("130e3881-b742-42e2-8cd7-66092d66a439"));
		}

		#endregion

	}

	#endregion

}

