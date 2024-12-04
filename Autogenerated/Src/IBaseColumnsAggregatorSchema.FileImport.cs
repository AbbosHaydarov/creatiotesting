namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBaseColumnsAggregatorSchema

	/// <exclude/>
	public class IBaseColumnsAggregatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBaseColumnsAggregatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBaseColumnsAggregatorSchema(IBaseColumnsAggregatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bf20cba9-3c75-48fd-bbc1-dd610d81de84");
			Name = "IBaseColumnsAggregator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,80,205,106,195,48,12,62,47,144,119,16,61,109,48,226,251,150,5,186,178,65,110,101,140,221,213,84,9,134,216,14,146,93,40,165,239,190,196,78,218,176,221,44,233,251,181,69,67,50,96,67,240,77,204,40,174,245,197,206,217,86,119,129,209,107,103,139,79,221,83,109,6,199,62,207,46,121,246,160,148,130,82,130,49,200,231,106,158,191,104,96,18,178,94,224,128,66,208,6,219,76,100,236,181,63,67,235,24,26,215,7,99,5,176,235,152,58,244,142,23,41,181,210,26,194,161,215,13,104,235,137,219,41,84,253,62,202,237,18,119,123,163,194,11,212,123,118,13,137,208,241,7,251,64,50,142,39,125,36,126,134,250,30,56,17,103,228,7,179,251,115,102,66,191,168,143,238,83,187,127,245,226,34,33,5,116,228,205,101,138,27,124,93,33,109,6,100,52,96,199,207,125,219,36,116,140,185,169,146,27,156,166,169,40,85,196,221,105,76,62,176,149,42,229,91,124,74,181,236,39,224,186,218,28,44,13,143,235,75,180,155,5,226,251,233,117,36,95,243,236,250,11,216,117,112,102,242,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf20cba9-3c75-48fd-bbc1-dd610d81de84"));
		}

		#endregion

	}

	#endregion

}

