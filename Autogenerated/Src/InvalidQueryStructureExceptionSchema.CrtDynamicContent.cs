namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvalidQueryStructureExceptionSchema

	/// <exclude/>
	public class InvalidQueryStructureExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvalidQueryStructureExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvalidQueryStructureExceptionSchema(InvalidQueryStructureExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efb635f4-13c4-4e2e-a2d4-fb0118960ea2");
			Name = "InvalidQueryStructureException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("69e28147-db31-49df-9976-b6fb9eb762c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,201,110,194,64,12,61,131,196,63,88,225,2,151,228,158,2,7,72,15,189,81,209,31,48,131,147,140,148,76,162,89,74,163,138,127,175,39,11,1,170,34,245,144,81,252,252,108,63,47,10,75,50,53,10,130,15,210,26,77,149,218,112,87,169,84,102,78,163,149,149,10,147,70,97,41,5,131,150,148,157,77,191,103,211,137,51,82,101,112,104,140,165,242,229,106,223,102,208,20,38,91,118,177,115,174,41,227,68,176,43,208,152,24,146,221,129,10,18,118,235,100,113,34,253,250,37,168,246,133,90,110,20,69,176,50,174,44,81,55,155,222,190,50,192,230,186,58,43,56,54,204,33,2,161,41,93,7,15,249,130,104,3,231,156,212,45,165,35,120,79,142,6,164,250,196,66,158,192,88,237,132,117,172,116,40,28,221,84,174,221,177,144,2,132,23,13,111,93,200,187,35,221,28,134,176,81,87,60,106,228,72,30,16,191,99,219,149,234,42,85,154,187,223,183,105,59,198,99,179,45,144,80,138,174,176,32,198,48,175,239,183,192,65,225,115,109,139,37,248,133,77,46,79,74,238,251,86,199,138,144,242,103,200,2,111,148,255,248,68,12,102,196,147,3,26,18,255,33,170,69,106,212,88,2,159,13,173,131,62,54,216,140,227,234,161,112,21,181,196,127,52,195,250,252,161,245,9,150,62,112,18,195,17,13,45,6,236,174,221,57,169,83,183,134,214,238,208,123,240,242,3,24,81,106,110,2,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efb635f4-13c4-4e2e-a2d4-fb0118960ea2"));
		}

		#endregion

	}

	#endregion

}

