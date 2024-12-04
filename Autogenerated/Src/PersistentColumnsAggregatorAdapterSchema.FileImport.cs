namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PersistentColumnsAggregatorAdapterSchema

	/// <exclude/>
	public class PersistentColumnsAggregatorAdapterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PersistentColumnsAggregatorAdapterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PersistentColumnsAggregatorAdapterSchema(PersistentColumnsAggregatorAdapterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a19ab3c1-267e-4152-ae6e-61811f92503a");
			Name = "PersistentColumnsAggregatorAdapter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,84,77,107,227,64,12,61,183,208,255,32,220,75,10,197,190,167,169,33,164,31,228,176,75,161,219,189,79,198,138,59,96,107,140,102,166,16,202,254,247,149,237,224,216,217,218,217,66,79,189,216,30,249,233,73,79,210,136,84,137,174,82,26,225,23,50,43,103,183,62,94,89,218,154,60,176,242,198,82,252,96,10,92,151,149,101,127,113,254,126,113,126,22,156,161,28,158,119,206,99,41,208,162,64,93,227,92,252,136,132,108,244,77,135,233,51,50,138,93,254,92,50,230,130,134,85,161,156,155,195,19,178,51,194,68,94,152,66,73,238,137,173,70,231,44,47,51,85,121,228,198,169,10,155,194,104,208,181,207,191,46,203,60,23,82,229,59,31,152,79,129,174,97,61,230,40,161,68,161,60,15,105,138,48,207,65,11,166,206,182,201,163,69,36,73,2,11,67,175,34,217,103,86,67,146,118,86,23,202,82,241,174,51,172,24,149,71,7,70,184,20,73,169,237,22,252,174,66,65,34,130,102,220,222,70,167,85,69,18,34,238,98,36,199,65,22,149,98,85,2,73,63,111,163,224,144,37,117,106,91,19,165,47,114,6,221,25,226,69,210,160,63,118,38,75,199,217,116,93,113,81,58,233,91,253,167,227,190,163,167,85,207,94,6,82,96,168,236,186,230,58,91,223,83,40,145,213,166,192,197,250,231,104,246,41,76,42,251,128,107,20,156,194,184,208,171,134,103,14,27,229,112,118,148,238,137,12,166,88,225,29,254,124,179,201,251,162,33,152,40,120,175,106,151,72,89,123,169,135,55,252,7,250,87,155,157,184,220,109,165,70,247,70,148,244,245,188,89,147,193,50,203,102,237,214,188,39,111,252,14,76,239,32,43,168,57,181,124,82,158,250,53,52,254,86,69,144,14,29,190,247,227,217,131,220,161,243,134,154,37,13,217,225,123,98,82,62,47,99,63,128,179,241,66,182,214,161,81,108,127,1,125,1,55,3,88,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a19ab3c1-267e-4152-ae6e-61811f92503a"));
		}

		#endregion

	}

	#endregion

}

