namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INonPersistentColumnsAggregatorSchema

	/// <exclude/>
	public class INonPersistentColumnsAggregatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INonPersistentColumnsAggregatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INonPersistentColumnsAggregatorSchema(INonPersistentColumnsAggregatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("872298ee-2333-4faf-aa08-02b8773d99f5");
			Name = "INonPersistentColumnsAggregator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,142,65,10,194,64,12,69,215,14,244,14,129,110,165,7,112,167,5,97,54,210,133,23,24,107,58,12,180,73,73,210,85,241,238,70,173,43,93,230,243,222,255,161,52,161,206,169,71,184,162,72,82,30,172,105,153,134,146,23,73,86,152,154,115,25,49,78,51,139,85,97,173,194,174,22,204,158,67,36,67,25,220,60,64,108,121,92,38,210,78,184,71,85,150,42,56,56,47,183,177,244,80,190,28,196,11,83,135,162,69,13,201,54,231,152,179,23,38,99,1,47,250,67,108,165,123,136,167,164,248,99,249,208,10,143,247,96,141,116,255,60,247,58,61,123,2,65,162,222,236,221,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("872298ee-2333-4faf-aa08-02b8773d99f5"));
		}

		#endregion

	}

	#endregion

}

