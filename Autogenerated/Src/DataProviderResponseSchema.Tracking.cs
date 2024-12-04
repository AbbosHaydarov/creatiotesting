namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DataProviderResponseSchema

	/// <exclude/>
	public class DataProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DataProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DataProviderResponseSchema(DataProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("128127f7-43f7-4cf4-9f1d-06f7c505c1c3");
			Name = "DataProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,80,203,106,195,64,12,60,199,224,127,16,233,221,190,247,145,75,218,99,33,148,252,128,186,150,55,75,99,173,145,214,9,37,244,223,171,245,163,152,182,151,5,205,142,70,51,195,216,145,246,232,8,142,36,130,26,219,84,237,35,183,193,15,130,41,68,174,142,130,238,35,176,47,139,91,89,148,197,230,78,200,27,14,251,51,170,222,195,51,38,60,72,188,132,134,228,205,164,34,43,141,188,186,174,225,81,135,174,67,249,220,205,243,66,0,151,151,161,141,98,20,178,81,168,125,218,46,151,214,146,219,122,7,200,13,4,62,145,132,68,205,180,74,90,45,39,234,213,141,126,120,63,7,55,171,255,239,108,51,165,248,137,97,140,158,36,5,178,44,135,113,125,250,255,109,127,4,172,153,132,129,21,172,43,243,110,213,41,122,130,235,137,24,178,204,216,24,4,133,129,117,112,206,190,179,205,191,62,23,163,154,196,242,194,75,86,123,157,197,110,224,41,61,128,230,231,107,246,74,220,76,118,199,121,66,215,160,33,223,185,57,18,109,201,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("128127f7-43f7-4cf4-9f1d-06f7c505c1c3"));
		}

		#endregion

	}

	#endregion

}

