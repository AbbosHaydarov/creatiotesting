namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastCalculatorSchema

	/// <exclude/>
	public class IForecastCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastCalculatorSchema(IForecastCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ec2b165-5e49-4298-bc0b-1de925207e9f");
			Name = "IForecastCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,75,107,2,49,16,62,43,248,31,6,189,232,101,3,61,86,221,139,80,240,32,244,80,122,159,102,39,18,200,99,153,36,5,41,254,247,198,232,54,91,21,114,152,201,247,154,100,28,90,10,61,74,130,15,98,198,224,85,108,118,222,41,125,76,140,81,123,215,188,121,38,137,33,126,190,192,207,108,58,201,103,193,116,204,8,236,93,36,86,89,251,10,251,129,181,67,35,147,193,232,121,54,205,84,33,4,108,66,178,22,249,212,222,250,74,1,61,56,128,202,157,186,121,128,244,38,89,23,154,193,64,140,28,250,244,101,180,28,41,159,70,79,46,163,62,164,255,139,167,112,31,8,223,104,18,149,216,199,220,235,77,143,140,22,92,254,180,237,188,212,148,199,8,243,246,253,175,110,54,162,0,85,195,20,19,187,208,30,124,167,149,166,14,170,48,147,7,244,66,31,191,164,56,134,58,237,242,9,88,141,86,235,172,63,151,47,95,144,235,174,11,42,219,58,255,2,35,91,209,232,226,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ec2b165-5e49-4298-bc0b-1de925207e9f"));
		}

		#endregion

	}

	#endregion

}

