namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnsAggregatorFactorySchema

	/// <exclude/>
	public class ColumnsAggregatorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnsAggregatorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnsAggregatorFactorySchema(ColumnsAggregatorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32c31bbf-f71f-44eb-9406-7b7d802e4208");
			Name = "ColumnsAggregatorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,82,77,75,195,64,16,61,167,208,255,48,228,148,128,36,119,181,66,173,86,122,41,61,232,73,68,182,233,108,92,216,236,134,153,13,82,196,255,238,164,53,214,90,22,161,144,15,54,121,243,222,155,55,227,84,131,220,170,10,225,17,137,20,123,29,138,153,119,218,212,29,169,96,188,43,230,198,226,162,105,61,133,241,232,99,60,74,58,54,174,62,66,19,94,69,190,23,115,85,5,79,6,89,16,130,41,203,18,174,141,123,67,50,97,227,43,168,8,245,36,93,204,188,237,26,199,211,186,38,172,149,20,236,203,182,105,121,51,20,113,215,52,138,182,195,89,12,89,108,208,5,6,227,2,146,238,59,208,158,122,70,21,16,170,61,35,168,31,202,129,168,252,197,244,124,135,90,117,54,220,26,183,17,243,89,216,182,232,117,22,245,147,95,192,82,242,130,9,56,121,9,50,10,204,95,132,190,237,214,214,72,147,86,49,67,12,10,151,16,213,19,142,62,241,243,98,27,228,79,97,211,141,106,37,51,120,192,112,242,47,123,98,36,89,0,135,85,63,125,232,142,142,57,236,252,36,113,206,215,239,228,87,228,43,100,246,212,175,70,146,24,13,217,49,85,33,234,11,158,203,180,58,194,123,167,214,22,55,89,42,234,43,36,54,28,100,182,135,205,75,243,65,57,57,17,232,167,129,239,112,40,139,121,251,99,32,223,59,251,4,180,140,255,177,47,189,59,91,96,247,36,148,62,93,36,158,30,34,183,92,95,53,165,181,4,143,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32c31bbf-f71f-44eb-9406-7b7d802e4208"));
		}

		#endregion

	}

	#endregion

}

