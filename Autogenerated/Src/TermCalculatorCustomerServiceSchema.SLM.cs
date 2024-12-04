namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculatorCustomerServiceSchema

	/// <exclude/>
	public class TermCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculatorCustomerServiceSchema(TermCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5034a0e1-cd7c-4f00-b59d-d7837cec6620");
			Name = "TermCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,82,81,107,194,48,16,126,174,224,127,200,28,72,5,233,15,208,185,193,138,136,48,65,166,219,123,108,78,23,104,147,238,146,8,101,248,223,151,164,173,214,186,250,176,199,251,238,238,251,238,187,59,163,184,56,144,77,161,52,100,211,126,207,52,194,232,141,139,239,51,182,5,68,170,228,94,71,177,68,232,128,163,185,208,92,115,80,54,223,239,9,154,129,202,105,2,87,85,98,207,15,6,169,230,82,244,123,63,174,46,120,68,56,216,144,196,41,85,106,226,170,179,152,166,137,73,169,150,24,27,165,101,6,184,1,60,242,4,124,67,110,118,41,79,72,226,234,239,151,147,54,157,237,182,162,193,69,83,10,165,209,36,54,101,165,215,158,216,107,212,34,119,233,195,15,5,104,41,4,36,206,16,49,87,225,152,44,12,103,68,149,181,75,187,211,37,171,176,28,185,68,174,139,37,27,17,39,22,76,200,142,42,8,219,4,173,222,102,155,183,113,42,103,125,4,193,74,67,46,106,250,91,129,254,146,204,89,67,169,45,43,176,202,93,29,18,121,180,215,225,12,202,193,22,160,173,91,75,71,113,201,194,74,37,64,208,6,5,217,92,166,33,15,51,34,76,154,146,225,176,9,71,182,127,91,228,192,98,153,154,76,124,210,212,192,147,35,126,14,7,23,222,193,200,181,59,56,154,103,185,46,188,70,240,242,31,162,178,181,220,94,212,26,126,218,177,161,191,247,115,123,250,243,102,222,237,31,219,63,129,45,207,236,154,64,175,184,104,66,97,51,136,253,188,170,124,116,130,62,195,110,18,245,98,175,152,171,99,215,24,153,157,93,181,5,59,105,189,229,250,92,183,141,175,197,186,250,160,176,37,54,238,30,181,107,141,21,214,132,78,191,114,187,211,82,80,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5034a0e1-cd7c-4f00-b59d-d7837cec6620"));
		}

		#endregion

	}

	#endregion

}

