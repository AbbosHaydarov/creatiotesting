namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NonPersistentColumnsAggregatorAdapterSchema

	/// <exclude/>
	public class NonPersistentColumnsAggregatorAdapterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NonPersistentColumnsAggregatorAdapterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NonPersistentColumnsAggregatorAdapterSchema(NonPersistentColumnsAggregatorAdapterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e17349a-19a3-44d5-b001-2f4514573b56");
			Name = "NonPersistentColumnsAggregatorAdapter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,77,75,195,64,16,61,183,224,127,24,210,75,5,73,238,181,6,74,81,233,65,9,168,63,96,187,153,198,133,100,55,204,108,132,82,252,239,78,62,140,77,180,210,131,23,47,129,76,222,204,123,51,111,38,86,21,200,165,210,8,207,72,164,216,237,124,184,118,118,103,178,138,148,55,206,134,119,38,199,77,81,58,242,23,211,195,197,116,82,177,177,25,60,237,217,99,33,208,60,71,93,227,56,188,71,139,100,244,117,143,57,174,72,40,113,249,50,35,204,4,13,176,206,21,243,2,30,157,77,144,216,72,53,235,165,90,85,88,94,101,153,160,148,119,180,74,85,233,145,154,204,40,138,96,105,236,171,112,248,212,105,208,132,187,155,160,75,73,200,105,100,118,20,68,177,96,203,106,155,27,129,212,28,231,81,192,2,198,165,174,96,115,90,208,68,70,33,207,190,31,153,25,123,170,180,96,164,171,164,225,111,17,141,110,174,138,66,209,62,254,12,172,9,149,71,6,35,89,202,202,244,221,14,252,190,68,65,34,118,173,157,165,91,250,13,123,150,104,76,179,44,21,169,2,172,152,124,19,84,140,36,50,109,235,87,16,191,200,59,232,62,16,46,163,6,253,115,178,110,248,251,217,112,16,31,195,187,121,159,165,120,254,50,208,1,67,89,87,117,185,201,100,115,107,171,2,73,109,115,92,118,46,244,220,49,140,197,92,182,73,11,216,42,198,249,168,224,119,52,28,224,253,200,155,175,157,106,118,231,127,26,246,119,14,92,254,50,204,163,209,205,208,166,237,238,15,15,225,1,253,171,75,127,186,129,111,183,123,242,188,218,35,254,236,233,205,153,20,58,251,230,237,159,40,169,251,70,65,138,33,163,192,105,137,109,116,24,148,216,7,82,17,140,142,2,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e17349a-19a3-44d5-b001-2f4514573b56"));
		}

		#endregion

	}

	#endregion

}

