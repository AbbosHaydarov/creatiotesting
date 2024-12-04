namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMLangBinderSchema

	/// <exclude/>
	public class BaseMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMLangBinderSchema(BaseMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4367ba23-e656-4615-8c59-3352d06c36d8");
			Name = "BaseMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,77,107,194,64,16,61,43,248,31,6,123,73,65,146,187,138,80,173,5,169,210,130,66,207,155,100,76,23,246,35,236,78,164,82,252,239,157,221,196,86,165,165,151,13,251,222,155,55,51,47,107,132,70,95,139,2,97,135,206,9,111,247,148,46,172,217,203,170,113,130,164,53,131,254,231,160,223,107,188,52,213,149,196,97,250,36,10,178,78,162,159,252,162,120,195,156,85,90,91,195,44,243,119,14,43,182,131,133,18,222,143,97,46,60,110,214,194,84,115,105,74,116,81,146,101,25,76,125,163,181,112,199,89,119,15,58,208,141,34,169,88,220,136,10,161,8,14,144,199,186,244,92,150,93,212,213,77,174,100,209,233,110,26,193,24,30,234,122,121,64,67,107,233,9,13,186,160,224,42,94,147,207,239,57,55,72,239,182,228,73,95,163,91,75,118,206,246,192,107,202,18,225,96,101,9,47,134,29,183,36,28,37,103,107,78,144,240,131,160,104,191,247,16,50,236,245,114,238,148,94,200,207,244,36,178,49,153,54,211,99,26,166,157,174,162,143,161,103,73,35,136,75,252,0,179,228,223,178,45,67,56,130,165,22,82,237,106,117,137,206,146,97,11,163,174,149,32,28,254,109,22,218,134,220,87,132,252,34,172,27,193,35,238,5,255,145,91,130,61,59,166,115,59,117,137,162,41,219,80,227,189,69,175,193,211,23,52,164,234,86,135,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4367ba23-e656-4615-8c59-3352d06c36d8"));
		}

		#endregion

	}

	#endregion

}

