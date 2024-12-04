namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnsAggregatorFactorySchema

	/// <exclude/>
	public class IColumnsAggregatorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnsAggregatorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnsAggregatorFactorySchema(IColumnsAggregatorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9f4596c-5acf-4767-9176-f091a98db598");
			Name = "IColumnsAggregatorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,203,106,195,64,12,60,219,224,127,16,62,181,151,236,7,212,49,4,67,138,47,37,148,246,3,212,141,236,46,120,31,72,187,135,16,242,239,93,39,77,91,99,232,101,65,210,204,104,52,235,208,146,4,212,4,111,196,140,226,135,184,233,188,27,204,152,24,163,241,110,179,55,19,245,54,120,142,85,121,174,202,34,137,113,227,2,205,244,84,149,121,162,148,130,70,146,181,200,167,246,187,126,165,192,36,228,162,128,165,248,233,143,48,120,6,205,132,145,64,251,41,89,39,128,227,200,52,98,244,124,87,81,127,100,66,250,152,140,6,227,34,241,48,59,237,187,27,111,247,67,219,163,206,239,41,131,103,135,43,35,197,220,232,254,217,121,5,44,150,222,58,1,25,45,184,156,209,182,78,66,156,147,113,164,231,88,234,182,81,215,233,47,152,41,38,118,210,54,66,121,13,211,176,173,251,23,239,14,196,98,36,230,8,86,182,107,149,85,238,180,89,103,125,217,238,136,33,223,13,207,180,166,63,188,47,44,193,210,225,99,254,148,226,82,149,151,47,222,179,155,242,227,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9f4596c-5acf-4767-9176-f091a98db598"));
		}

		#endregion

	}

	#endregion

}

