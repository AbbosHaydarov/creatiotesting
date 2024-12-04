namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesEntitySchemaColumnSchema

	/// <exclude/>
	public class LookupValuesEntitySchemaColumnSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesEntitySchemaColumnSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesEntitySchemaColumnSchema(LookupValuesEntitySchemaColumnSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76ad8774-b047-419f-b521-b9a051bdfc9f");
			Name = "LookupValuesEntitySchemaColumn";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,79,75,3,49,16,197,207,93,232,119,24,232,69,65,186,119,171,130,44,86,10,69,132,170,247,152,205,182,193,100,178,230,207,97,41,126,119,39,217,172,174,45,84,61,230,101,230,205,251,77,130,76,11,215,50,46,224,73,88,203,156,105,252,188,50,216,200,109,176,204,75,131,243,165,84,98,165,91,99,253,180,216,79,139,73,112,18,183,176,233,156,23,122,49,45,72,153,89,177,165,74,128,74,49,231,46,97,109,204,91,104,95,152,10,194,221,161,151,190,219,240,157,208,172,50,42,104,76,45,101,89,194,149,11,90,51,219,221,228,243,45,130,68,231,25,82,24,211,128,223,73,7,60,58,2,55,232,25,221,1,82,90,96,88,131,72,182,224,146,47,4,148,239,65,128,172,163,220,72,97,99,191,74,41,134,74,158,102,207,135,209,229,104,118,27,94,149,228,121,212,111,217,39,113,5,223,196,75,41,84,77,200,143,201,35,161,29,177,37,97,253,35,205,81,224,24,236,56,217,16,237,62,200,26,198,105,158,87,245,226,207,195,122,244,180,187,211,99,156,183,241,105,31,168,48,187,207,4,214,61,106,62,219,158,155,126,8,21,7,238,141,61,128,207,86,167,215,120,118,14,123,248,248,79,67,218,64,207,243,181,129,139,33,112,36,35,199,232,54,57,216,18,92,31,118,17,25,149,69,70,186,139,157,73,200,97,198,188,89,27,75,164,124,2,154,116,46,235,48,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76ad8774-b047-419f-b521-b9a051bdfc9f"));
		}

		#endregion

	}

	#endregion

}

