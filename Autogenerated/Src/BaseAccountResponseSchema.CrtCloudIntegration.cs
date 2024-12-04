namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAccountResponseSchema

	/// <exclude/>
	public class BaseAccountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAccountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAccountResponseSchema(BaseAccountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70d366b9-fe0c-4c17-99b3-f6cd244e3e7c");
			Name = "BaseAccountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,221,106,195,48,12,133,175,27,200,59,136,238,190,190,223,79,97,43,187,28,148,178,23,208,28,197,53,52,114,144,108,70,41,125,247,217,113,50,246,211,27,131,228,163,163,79,135,113,32,29,209,18,188,147,8,106,232,227,102,23,184,247,46,9,70,31,184,109,46,109,211,54,171,59,33,151,75,216,157,80,245,30,94,80,233,217,218,144,56,30,178,65,96,165,73,102,140,129,71,77,195,128,114,222,206,245,34,0,91,102,161,15,146,37,148,75,161,254,105,125,195,105,109,182,128,220,129,231,35,137,143,212,213,73,210,205,178,193,252,88,49,166,143,147,183,179,249,77,174,85,61,225,251,134,189,132,145,36,122,202,135,236,83,153,174,255,127,225,167,70,78,35,162,103,133,156,79,38,207,113,41,58,130,207,35,49,20,155,41,37,240,10,28,34,104,178,54,11,10,231,127,208,133,84,163,120,118,240,90,252,222,102,187,11,56,138,15,160,229,185,206,180,196,93,5,158,234,218,253,221,188,126,1,163,187,89,189,191,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70d366b9-fe0c-4c17-99b3-f6cd244e3e7c"));
		}

		#endregion

	}

	#endregion

}

